using AIMLbot;
using System;
using System.IO;
using System.Speech.Synthesis;
using NeuroSky.ThinkGear;

namespace AutonomousComputerProgram
{
    public class Missy
    {
        #region declarartions
        private Bot myBot;
        private User myUser;
        #endregion declarations


        public Missy()
        {
            myBot = new Bot();
            myUser = new User("DefaultUser", myBot);
            Initialize();
        }

        #region initialize
        public void Initialize()
        {
            myBot.loadSettings();
            AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(myBot);
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/App_Data/Graphmaster.dat"))
                myBot.loadFromBinaryFile(AppDomain.CurrentDomain.BaseDirectory + @"/App_Data/Graphmaster.dat");
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/App_Data/Missy.db"))
                myBot.loadFromBinaryFile(AppDomain.CurrentDomain.BaseDirectory + @"/App_Data/Missy.db");
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/reasoner-3.3.2/reasoner-3.3.2/bin/su.dat"))
                myBot.loadFromBinaryFile(AppDomain.CurrentDomain.BaseDirectory + @"/reasoner-3.3.2/reasoner-3.3.2/bin/su.dat");
            myBot.isAcceptingUserInput = false;
            loader.loadAIML(myBot.PathToAIML);
            myBot.isAcceptingUserInput = true;
        }
        #endregion initialize
        
        #region getoutput
        public String getOutput(String rawInput)
        {
            
            SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();
            Request request = new Request(rawInput, myUser, myBot);
            Result result = myBot.Chat(request);
            SpeechSynth.Speak(result.Output);
            return (result.Output);
        }
        #endregion getoutput
    }
}
