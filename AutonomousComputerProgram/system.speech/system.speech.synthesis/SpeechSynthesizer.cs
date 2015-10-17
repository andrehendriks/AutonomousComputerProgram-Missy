using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram._1.system.speech.system.speech.synthesis
{
    public sealed class SpeechSynthesizer
    {
        ~SpeechSynthesizer() { }
        public void AddLexicon(System.Uri uri, string mediaType) { }
        public void Dispose() { }
        [DllImport("mscorlib.dll")]
        public static extern System.Speech.Synthesis.Prompt GetCurrentlySpokenPrompt();
        [DllImport("mscorlib.dll")]
        public static extern System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices();
        [DllImport("mscorlib.dll")]
        public static extern System.Collections.ObjectModel.ReadOnlyCollection<System.Speech.Synthesis.InstalledVoice> GetInstalledVoices(System.Globalization.CultureInfo culture);
        public void Pause() { }
        public void RemoveLexicon(System.Uri uri) { }
        public void Resume() { }
        public void SelectVoice(string name) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate) { }
        public void SelectVoiceByHints(System.Speech.Synthesis.VoiceGender gender, System.Speech.Synthesis.VoiceAge age, int voiceAlternate, System.Globalization.CultureInfo culture) { }
        public void SetOutputToAudioStream(System.IO.Stream audioDestination, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
        public void SetOutputToDefaultAudioDevice() { }
        public void SetOutputToNull() { }
        public void SetOutputToWaveFile(string path) { }
        public void SetOutputToWaveFile(string path, System.Speech.AudioFormat.SpeechAudioFormatInfo formatInfo) { }
        public void SetOutputToWaveStream(System.IO.Stream audioDestination) { }
        public void Speak(string textToSpeak) { }
        public void Speak(System.Speech.Synthesis.Prompt prompt) { }
        public void Speak(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
        [DllImport("mscorlib.dll")]
        public static extern System.Speech.Synthesis.Prompt SpeakAsync(string textToSpeak);
        public void SpeakAsync(System.Speech.Synthesis.Prompt prompt) { }
        [DllImport("mscorlib.dll")]
        public static extern System.Speech.Synthesis.Prompt SpeakAsync(System.Speech.Synthesis.PromptBuilder promptBuilder);
        public void SpeakAsyncCancel(System.Speech.Synthesis.Prompt prompt) { }
        public void SpeakAsyncCancelAll() { }
        public void SpeakSsml(string textToSpeak) { }
        [DllImport("mscorlib.dll")]
        public static extern System.Speech.Synthesis.Prompt SpeakSsmlAsync(string textToSpeak);
        public SpeechSynthesizer() { }
        public int Rate { get; set; }
        public System.Speech.Synthesis.SynthesizerState State { get; }
        public System.Speech.Synthesis.VoiceInfo Voice { get; }
        public int Volume { get; set; }
        public event System.EventHandler<System.Speech.Synthesis.BookmarkReachedEventArgs> BookmarkReached;
        public event System.EventHandler<System.Speech.Synthesis.PhonemeReachedEventArgs> PhonemeReached;
        public event System.EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs> SpeakCompleted;
        public event System.EventHandler<System.Speech.Synthesis.SpeakProgressEventArgs> SpeakProgress;
        public event System.EventHandler<System.Speech.Synthesis.SpeakStartedEventArgs> SpeakStarted;
        public event System.EventHandler<System.Speech.Synthesis.StateChangedEventArgs> StateChanged;
        public event System.EventHandler<System.Speech.Synthesis.VisemeReachedEventArgs> VisemeReached;
        public event System.EventHandler<System.Speech.Synthesis.VoiceChangeEventArgs> VoiceChange;
        public interface IDisposable
        {
            void Dispose();
        }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            //public extern System.Type GetType();
            protected new object MemberwiseClone() { return true; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("*"); }
        }
    }
}
