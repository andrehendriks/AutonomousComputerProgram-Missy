using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;

namespace AutonomousComputerProgram.cprolog
{
    public class Bootstrap
    {
        public Bootstrap() { }
        public static string PredefinedPredicates;
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return (true); }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return (""); }
        }
    }
}
