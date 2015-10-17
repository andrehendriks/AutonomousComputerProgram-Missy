using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;

namespace AutonomousComputerProgram.system.speech.system.speech.synthesis.FilePrompt
{

    public class FilePrompt
    {
        public FilePrompt(string path, System.Speech.Synthesis.SynthesisMediaType media) { }
        public FilePrompt(System.Uri promptFile, System.Speech.Synthesis.SynthesisMediaType media) { }
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
