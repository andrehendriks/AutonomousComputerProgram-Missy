using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    class Deffacts1
    {
        public override string ToString() { return ("*"); }
        public bool Undeffacts() { return (false); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
    }
}
