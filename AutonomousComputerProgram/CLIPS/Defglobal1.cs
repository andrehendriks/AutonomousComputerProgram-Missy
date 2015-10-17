using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defglobal : CLIPSNet.Wrapper
    {
        public Defglobal(CLIPSNet.Environment env, System.IntPtr ptr) { }
        public bool Undefglobal() { return (false); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public CLIPSNet.DataType Value { get; set; }
        public string ValueFrom { get; }
        public bool Watch { get; set; }
    }
}
