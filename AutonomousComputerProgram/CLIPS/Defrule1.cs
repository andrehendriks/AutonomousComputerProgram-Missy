using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defrule : CLIPSNet.Wrapper
    {
        public bool Matches() { return (true); }
        public bool Refresh() { return (true); }
        public bool RemoveBreak() { return (false); }
        public void SetBreak() { }
        public override string ToString() { return ("*"); }
        public bool Undefrule() { return (false); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool HasBreakpoint { get; }
        public bool IsDeletable { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public bool WatchActivations { get; set; }
        public bool WatchFirings { get; set; }
    }
}
