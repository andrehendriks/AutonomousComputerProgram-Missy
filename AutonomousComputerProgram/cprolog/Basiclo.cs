using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.cprolog
{
    public abstract class Basiclo
    {
        protected Basiclo() { }
        public abstract void Clear();
        public abstract int ReadChar();
        public abstract string ReadLine();
        public abstract void Reset();
        public abstract void Write(string s);
        public abstract void Write(string s, params object[] o);
        public abstract void WriteLine();
        public abstract void WriteLine(string s);
        public abstract void WriteLine(string s, params object[] o);
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { throw new System.Exception(); }
            protected new object MemberwiseClone() { return (true); }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return (""); }
        }
    }
}
