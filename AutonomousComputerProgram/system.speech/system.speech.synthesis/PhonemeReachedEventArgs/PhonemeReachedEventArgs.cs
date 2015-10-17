using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace AutonomousComputerProgram.system.speech.system.speech.synthesis.PhonemeReachedEventArgs
{
    public class PhonemeReachedEventArgs 
    {
        public System.TimeSpan AudioPosition { get; }
        public System.TimeSpan Duration { get; }
        public System.Speech.Synthesis.SynthesizerEmphasis Emphasis { get; }
        public string NextPhoneme { get; }
        public string Phoneme { get; }
        public abstract class PromptEventArgs
        {
            public System.Speech.Synthesis.Prompt Prompt { get; }
            public class AsyncCompletedEventArgs
            {
                public AsyncCompletedEventArgs(System.Exception error, bool cancelled, object userState) { }
                protected void RaiseExceptionIfNecessary() { }
                public bool Cancelled { get; }
                public System.Exception Error { get; }
                public object UserState { get; }
                public class EventArgs
                {
                    public EventArgs() { }
                    public static readonly System.EventArgs Empty;
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
        }
    }
}
