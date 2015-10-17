using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace AutonomousComputerProgram.cprolog
{
    public interface IVarValue
    {
        string DataType { get; }
        string Name { get; }
        Prolog.ITermNode Value { get; }
    }
}
