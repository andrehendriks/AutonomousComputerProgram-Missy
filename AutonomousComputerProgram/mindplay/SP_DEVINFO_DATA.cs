using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuroSky.ThinkGear;

namespace AutonomousComputerProgram.mindplay
{
    public class SP_DEVINFO_DATA
    {
        public SP_DEVINFO_DATA() { }
        public int cbSize;
        public System.Guid classGuid;
        public int devInst;
        public ulong reserved;
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
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
}
