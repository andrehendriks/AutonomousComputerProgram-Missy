using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace AutonomousComputerProgram.cprolog
{
    public interface ITermNode
    {
        T To<T>()
    where T : struct;
        string ToString();
        Prolog.ITermNode[] Args { get; }
        string Functor { get; }
    }
}
