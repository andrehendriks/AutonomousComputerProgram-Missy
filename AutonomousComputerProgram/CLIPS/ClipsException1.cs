using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public class ClipsException : System.Exception
    {
        public ClipsException() { }
        public ClipsException(string message) { }
        public ClipsException(string message, System.Exception innerException) { }
    }
}
