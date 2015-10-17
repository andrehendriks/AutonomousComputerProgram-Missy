using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.CLIPS
{
    public class Deftemplate : CLIPSNet.Wrapper
    {
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.Fact CreateFact();
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.DataType SlotAllowedValues(string slot);
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.DataTypes.Multifield SlotCardinality(string slot);
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.Deftemplate.DefaultP SlotDefaultP(string slot);
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.DataType SlotDefaultValue(string slot);
        public bool SlotExistP(string slot) { return (true); }
        public bool SlotMultiP(string slot) { return (true); }
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.DataTypes.Multifield SlotNames();
        [DllImport("msvcrt.dll")]
        public static extern CLIPSNet.DataType SlotRange(string slot);
        public bool SlotSingleP(string slot) { return (true); }
        [DllImport("msvcrt.dll")]
        public static extern System.Type[] SlotTypes(string slot);
        public override string ToString() { return ("*"); }
        public bool Undeftemplate() { return (true); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public bool Watch { get; set; }
      }
}
