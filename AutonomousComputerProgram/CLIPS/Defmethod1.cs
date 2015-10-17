using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defmethod
    {
        public override bool Equals(object obj) { return (true); }
        public override int GetHashCode() { return (1); }
        public override string ToString() { return ("*"); }
        public bool Undefmethod() { return (false); }
        public CLIPSNet.Defgeneric Defgeneric { get; }
        public string Description { get; }
        public bool IsDeletable { get; }
        public string PPForm { get; }
        public CLIPSNet.DataTypes.Multifield Restrictions { get; }
        public bool Watch { get; set; }

        public interface IHavePPForm
        {
            string PPForm { get; }
        }

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
