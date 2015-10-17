using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram._1.system.speech.system.speech.synthesis
{
    public class Prompt
    {
        public Prompt(string textToSpeak) { }
        public Prompt(string textToSpeak, System.Speech.Synthesis.SynthesisTextFormat media) { }
        public Prompt(System.Speech.Synthesis.PromptBuilder promptBuilder) { }
        public bool IsCompleted { get; }
        /// <summary>
        /// 
        /// </summary>
        public class Object
        {
            ~Object() { }
            
            public override bool Equals(object obj) { return (true); }
            
            public new static bool Equals(object objA, object objB) { return true; } 
            public  override int GetHashCode() { return (1); }
            
            //public extern static System.Type GetType();
            
            protected new static object MemberwiseClone() { return (""); }
            public Object() { }
           
            public new static  bool ReferenceEquals(object objA, object objB) { return true; }
            public override string ToString() { return (""); }
        }
    }
}
