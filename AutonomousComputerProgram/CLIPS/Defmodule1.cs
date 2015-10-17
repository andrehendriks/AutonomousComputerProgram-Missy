using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defmodule : CLIPSNet.Wrapper
    {
        public override string ToString() { return("*"); }
        public string Name { get; }
        public string PPForm { get; }
    }
}
