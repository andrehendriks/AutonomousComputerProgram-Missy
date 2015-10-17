using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.CLIPS.DataTypes
{
    public class Boolean : CLIPSNet.DataTypes.Symbol
    {
        public Boolean(bool val) { }
        public static implicit operator Boolean(bool val) { return (true); }
        public static CLIPSNet.DataTypes.Boolean False { get; }
        public static CLIPSNet.DataTypes.Boolean True { get; }
    }
}
