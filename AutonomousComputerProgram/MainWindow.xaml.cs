using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Recognition;
using System.Text.RegularExpressions;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;
using NeuroSky.ThinkGear;
using NeuroSky.ThinkGear.Algorithms;
using NeuroSky.ThinkGear.Algorithm.EEGTools;

using Jayrock.Json;
using NLog;



using System.Threading;

using System.Device;
using System.Device.Location;

using Microsoft.Kinect;

using Microsoft.TeamFoundation.Server;
using Microsoft.TeamFoundation.Proxy;

using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Client.Controls;
using Microsoft.VisualStudio.Services.Client.Internal;
using Microsoft.VisualStudio.Services.Common.Contracts;
using Microsoft.VisualStudio.Services.Common.Internal;
using Microsoft.VisualStudio.Services.Common.TokenStorage;
using Microsoft.VisualStudio.Services.Location;

using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

using WinSimulatorUtilitiesElevatedLib;

using AutonomousComputerProgram.visionnet;

namespace AutonomousComputerProgram
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static KinectSensor sensor;
        private static WriteableBitmap ColorBitmap = ColorBitmap;
        private byte[] colorPixels;

        String rawInput = null;
        Missy myMissy = new Missy();


        private Connector connector;



        public bool avatarDescription { get; private set; }

        public MainWindow()
        {


            InitializeComponent();

            


            Regex regex = new Regex(@"</?\w+((\s+\w+(\s*=\s*(?:"".*?""|'.*?'|[^'"">\s]+))?)+\s*|\s*)/?>", RegexOptions.Singleline);
            SpeechRecognitionEngine speechEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            speechEngine.LoadGrammar(new Grammar(new GrammarBuilder("quit")));

            speechEngine.SpeechRecognized += speechEngine_SpeechRecognized;
            speechEngine.SetInputToDefaultAudioDevice(); // set input to default audio device

            speechEngine.RecognizeAsync(RecognizeMode.Multiple); // recognize speech
            speechEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechEngine_SpeechRecognized);

            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnected);
            connector.DeviceFound += new EventHandler(OnDeviceFound);
            connector.DeviceNotFound += new EventHandler(OnDeviceNotFound);
            connector.DeviceConnectFail += new EventHandler(OnDeviceNotFound);
            connector.DeviceDisconnected += new EventHandler(OnDeviceDisconnected);
            connector.DeviceValidating += new EventHandler(OnDeviceValidating);

            connector.setMentalEffortEnable(true);
            connector.setAppreciationEnabled(true);
            connector.setBlinkDetectionEnabled(false);
            connector.setMentalEffortRunContinuous(true);
            connector.setPositivityEnable(true);
            connector.setRespirationRateEnable(true);


            AvatarDescription.CreateRandom(AvatarBodyType.Female);

            //connector.Find();
            //connector.thinkGearPorts("COM5");
            //connector.Connect("COM5");
            //connector.Connect("COM6");
            // Scan for devices across COM ports
            // The COM port named will be the first COM port that is checked.
            connector.ConnectScan("COM29");

            // Blink detection needs to be manually turned on
            // connector.setBlinkDetectionEnabled(true);
            // Thread.Sleep(450000);

            if (connector.setMentalEffortEnable(true))
            {     // return true, means success 
                Console.WriteLine("HelloEEG: MentalEffort is Enabled");
            }
            else
            {
                // return false, meaning not supported because:     
                //  + connected hardware doesn't support     
                //  + conflict with another option already set
                Console.WriteLine("Connected hardware doesn't support, or a conflict with another option already set.");
            }
            if (connector.getMentalEffortEnable())
            {     // return true, means it is enabled 
                Console.WriteLine("HelloEEG: MentalEffort is configured");
            }
            else
            {     // return false, meaning not currently configured 
                Console.WriteLine("HelloEEG: MentalEffort is NOT configured");

            }
            if (connector.setMentalEffortRunContinuous(true))
            {     // return true, means success 
                Console.WriteLine("HelloEEG: MentalEffort Continuous operation");
            }
            else
            {     // return false, meaning not supported because:     //  + connected hardware doesn't support     //  + conflict with another option already set     //  + not support by this version of the SDK 
                Console.WriteLine("HelloEEG: MentalEffort normal operation ");
            }
            if (connector.getMentalEffortRunContinuous())
            {     // return true, means it is enabled 
                Console.WriteLine("HelloEEG: MentalEffort Continuous operation");
            }
            else
            {
                // return false, meaning not currently configured 
                Console.WriteLine("HelloEEG: MentalEffort normal operation");
            }
        }

        
        public void ViewBox(Viewport3D viewbox1)
        {
            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                {
                    sensor = potentialSensor;
                    break;
                }
            }
            if (null != sensor)
            {
                sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
                colorPixels = new byte[sensor.ColorStream.FramePixelDataLength];
                sensor.ColorFrameReady += SensorColorFrameReady;

                try
                {
                    sensor.Start();
                }
                catch (IOException)
                {
                    sensor = null;
                }
            }
        }
        /// <summary>
        /// Event handler for Kinect sensor's ColorFrameReady event
        /// </summary>
        /// <param name="sender">object sending the event</param>
        /// <param name="e">event arguments</param>
        private void SensorColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            using (ColorImageFrame colorFrame = e.OpenColorImageFrame())
            {
                if (colorFrame != null)
                {
                    // Copy the pixel data from the image to a temporary array
                    colorFrame.CopyPixelDataTo(this.colorPixels);

                    // Write the pixel data into our bitmap
                    ColorBitmap.WritePixels(
                        new Int32Rect(0, 0, ColorBitmap.PixelWidth, ColorBitmap.PixelHeight),
                        colorPixels,
                        ColorBitmap.PixelWidth * sizeof(int),
                        0);
                }
            }
        }

    

        private void OnDeviceValidating(object sender, EventArgs e)
        {
            Console.WriteLine("Validating: ");
        }

        private void OnDeviceDisconnected(object sender, EventArgs e)
        {
            Console.WriteLine("Dive Disconnected: ");
            
        }

        private void OnDeviceNotFound(object sender, EventArgs e)
        {
            Console.WriteLine("No devices found! :");
        }

        private void OnDeviceFound(object sender, EventArgs e)
        {
            Console.WriteLine("Device Found: ");
        }




        

        void OnDeviceConnected(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs deviceEventArgs = (Connector.DeviceEventArgs)e; Console.WriteLine("New Headset Created." + deviceEventArgs.Device.PortName);
            
            
            deviceEventArgs.Device.DataReceived += new EventHandler(OnDataReceived);
        }

        void OnDataReceived(object sender, EventArgs e)
        {
            /* Cast the event sender as a Device object, and e as the Device's DataEventArgs */
            Device d = (Device)sender; Device.DataEventArgs de = (Device.DataEventArgs)e;
            /* Create a TGParser to parse the Device's DataRowArray[] */
            TGParser tgParser = new TGParser(); tgParser.Read(de.DataRowArray);
            /* Loop through parsed data TGParser for its parsed data... */
            for (int i = 0; i < tgParser.ParsedData.Length; i++)
            {
                // See the Data Types documentation for valid keys such        // as "Raw", "PoorSignal", "Attention", etc. 
                if (tgParser.ParsedData[i].ContainsKey("Raw")) { Console.WriteLine("Raw Value:" + tgParser.ParsedData[i]["Raw"]); }
                if (tgParser.ParsedData[i].ContainsKey("PoorSignal")) { Console.WriteLine("PQ Value:" + tgParser.ParsedData[i]["PoorSignal"]); }
                if (tgParser.ParsedData[i].ContainsKey("Attention")) { Console.WriteLine("Att Value:" + tgParser.ParsedData[i]["Attention"]); }
                if (tgParser.ParsedData[i].ContainsKey("Meditation")) { Console.WriteLine("Med Value:" + tgParser.ParsedData[i]["Meditation"]); }
            }
        }


        private void speechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            textBox.AppendText(e.Result.Text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            rawInput = textBox.Text;
            textBlock.Text = myMissy.getOutput(rawInput);
            textBox.Text = "";
            rawInput = null;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (null != sensor)
            {
                sensor.Stop();
            }
            textBlock.Text = "GoodBye!: ";
            connector.Close();
            Environment.Exit(0);
        }

        
    }
}
