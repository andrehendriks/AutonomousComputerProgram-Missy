using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class DefmessageHandler
    {
        public DefmessageHandler(CLIPSNet.Environment env, CLIPSNet.Defclass defclass, uint index) {  }
        public bool UndefmessageHandler() { return (false); }
        public CLIPSNet.DefmessageHandler.Type HandlerType { get; }
        public bool IsDeletable { get; }
        public string Name { get; }
        public string PPForm { get; }
        public bool Watch { get; set; }
    }
}
