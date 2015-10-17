using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS.DataTypes
{
    public class ExternalObject 
    {
        public void Dispose() { }
        public override bool Equals(object obj) { return (true); }
        public ExternalObject(CLIPSNet.Environment env) { }
        public ExternalObject(CLIPSNet.Environment env, object val) { }
        public override int GetHashCode() { return (1); }
        public int ID { get; }
    }
}
