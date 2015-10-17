using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.system.speech.system.speech.synthesis
{
    /// <summary>
    /// 
    /// </summary>
    public class SpeakCompletedEventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public abstract class PromptEventArgs
        {
            /// <summary>
            /// 
            /// </summary>
            public System.Speech.Synthesis.Prompt Prompt { get; }
            /// <summary>
            /// 
            /// </summary>
            public class AsyncCompletedEventArgs : System.EventArgs
            {
                
                public AsyncCompletedEventArgs(System.Exception error, bool cancelled, object userState) { }
                protected void RaiseExceptionIfNecessary() { }
                /// <summary>
                /// 
                /// </summary>
                public bool Cancelled { get; }
                /// <summary>
                /// 
                /// </summary>
                public System.Exception Error { get; }
                /// <summary>
                /// 
                /// </summary>
                public object UserState { get; }
                /// <summary>
                /// 
                /// </summary>
                public class EventArgs
                {
                    public EventArgs() { }
                    public static readonly System.EventArgs Empty;
                    public class Object
                    {
                        /// <summary>
                        /// 
                        /// </summary>
                        ~Object() { }
                        public new virtual bool Equals(object obj) { return true; }
                        public new static bool Equals(object objA, object objB) { return true; }
                        public new virtual int GetHashCode() { return 1; }
                        //public  System.Type GetType() { }
                        protected new object MemberwiseClone() { return true; }
                        public Object() { }
                        public new static bool ReferenceEquals(object objA, object objB) { return true; }
                        public new virtual string ToString() { return ""; }

                    }
                }
            }
        }
    }

        
}
