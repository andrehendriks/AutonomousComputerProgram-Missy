using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS.DataTypes
{
    public abstract class GenericDataType<T> : CLIPSNet.DataType
    {
        public override bool Equals(object obj) { return (true); }
        public GenericDataType() { }
        public GenericDataType(T val) { }
        public override int GetHashCode() { return (1); }
        public override string ToString() { return ("*"); }
        public virtual T Value { get; set; }
        protected T val;
    }
}
