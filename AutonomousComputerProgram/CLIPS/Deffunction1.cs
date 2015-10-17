using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Deffunction : CLIPSNet.Wrapper
    {
        public override string ToString() { return ("*"); }
        public bool Undeffunction() { return (true); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public bool Watch { get; set; }
    }
}
