using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace AutonomousComputerProgram.cprolog
{
    public class SolutionSet
    {
        public SolutionSet() { }
        public override string ToString() { return (""); }
        public int Count { get; }
        public string ErrMsg { get; }
        public bool HasError { get; }
        public System.Collections.Generic.IEnumerable<Prolog.Solution> NextSolution { get; }
        public string Query { get; }
        public bool Success { get; }
        public Prolog.Solution this[int i] { get { return null; } }
        public class Object
        {
            ~Object() { }
            public new  virtual bool Equals(object obj) { return (true); }
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
