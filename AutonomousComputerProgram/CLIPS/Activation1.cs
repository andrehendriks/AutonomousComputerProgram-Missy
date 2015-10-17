using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Activation : CLIPSNet.Wrapper
    {
        public CLIPSNet.Defrule Defrule { get; }
        public string Name { get; }
        public string PPForm { get; }
        public int Salience { get; set; }
        public interface IHavePPForm
        {
            string PPForm { get; }
        }
        public abstract class Wrapper
        {
            public override bool Equals(object obj) { return (true); }
            public override int GetHashCode() { return (1); }
            protected Wrapper() { }
            protected System.IntPtr rawPtr;
            public class Object
            {
                ~Object() { }
                public new virtual bool Equals(object obj) { return (true); }
                public new static bool Equals(object objA, object objB) { return (true); }
                public new virtual int GetHashCode() { return (1); }
                public new System.Type GetType() { return null; }
                protected new object MemberwiseClone() { return null; }
                public Object() { }
                public new static bool ReferenceEquals(object objA, object objB) { return (true); }
                public new virtual string ToString() { return (""); }

            }
        }
    }
}
