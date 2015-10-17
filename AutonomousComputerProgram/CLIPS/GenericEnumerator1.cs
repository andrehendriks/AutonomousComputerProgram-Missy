using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.CLIPS
{
    public abstract class GenericEnumerator<T>
    {
        public virtual void Dispose() { }
        public GenericEnumerator(CLIPSNet.Environment env) { }
        protected abstract T GetFirst();
        protected abstract T GetNext(T curr);
        public bool MoveNext() { return (true); }
        public void Reset() { }
        public T Current { get; }
        protected CLIPSNet.Environment env;
    }
}
