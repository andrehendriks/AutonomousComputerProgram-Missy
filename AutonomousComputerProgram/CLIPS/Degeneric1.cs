using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defgeneric : CLIPSNet.Wrapper
    {
        public CLIPSNet.DataTypes.Multifield GetDefmethodList() { return null; }
        public override string ToString() { return ("*"); }
        public bool Undefgeneric() { return (true); }
        public bool Undefmethod(int index) { return (true); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public CLIPSNet.Defmethod This(int index) { return null; }
        public CLIPSNet.Defmodule Defmodule1 { get; }
        public bool Watch { get; set; }
    }
}
