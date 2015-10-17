using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.cprolog
{
    public class Variable
    {
        public override string ToString() { return (""); }
        public Variable(string name, string type, string value) { }
        public string Name { get; }
        public string Type { get; }
        public string Value { get; }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new  static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { throw new System.Exception(); }
            protected new object MemberwiseClone() { return (true); }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new  virtual string ToString() { return (""); }
        }
    }
}
