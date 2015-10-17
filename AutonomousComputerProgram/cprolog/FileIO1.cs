using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.cprolog
{
    public class FilelO
    {
        
        public void Clear() { }
       
        public void Close() { }
        public FilelO(string inFileName, string outFileName) { }
        public int ReadChar() { return (1); }
        public string ReadLine() { return (""); }
        
        public void Reset() { }
        
        public void Write(string s) { }
        
        public void WriteLine() { }
        
        public void WriteLine(string s) { }
    }
}
