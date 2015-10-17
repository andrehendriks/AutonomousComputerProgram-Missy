using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.cprolog
{
    public static class Extensions
    {
        
        public static string AddEndDot(this string s) { return ("s"); }
        
        public static void AppendLine(this System.Text.StringBuilder sb, string format, params object[] args) { }
        
        public static void AppendPacked(this System.Text.StringBuilder sb, string s) { }
        
        public static void AppendPacked(this System.Text.StringBuilder sb, string s, bool mustPack) { }
        
        public static void AppendPossiblySpaced(this System.Text.StringBuilder sb, string s) { }
        public static bool Contains(this string s, char c) { return (true); }
        public static string Dequoted(this string s) { return (""); }
        public static string Dequoted(this string s, string quote) { return ("''"); }
        public static string Enquote(this string s, char quoteChar) { return ("'"); }
        public static string EscapeDoubleQuotes(this string s) { return ("''"); }
        public static bool HasAtomFormat(this string s) { return (true); }
        public static bool HasSignedImagNumberFormat(this string s) { return (true); }
        public static bool HasSignedRealNumberFormat(this string s) { return (true); }
        public static bool HasUnsignedIntegerFormat(this string s) { return (true); }
        public static float Levenshtein(this string a, string b) { return (1); }
        
        public static string MakeAtomic(this string s) { return ("s"); }
        
        public static string Mirror(this string s) { return ("s"); }
        
        public static string Packed(this string s) { return ("s"); }
        
        public static string Packed(this string s, bool mustPack) { return ("s"); }
        
        public static string RemoveUnnecessaryAtomQuotes(this string s) { return ("s"); }
        
        public static string Repeat(this string s, int n) { return ("s"); }
        
        public static string Reverse(this string s) { return ("s"); }
        
        public static string ToAtom(this string s) { return ("s"); }
        
//        public static string ToAtomic(this string s, out Prolog.TermType type) { return ("s"); }
        
        public static string[] Tokens(this string s) { return null; }
        
        public static string Unescaped(this string s) { return ("s"); }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new  System.Type GetType() { return null; }
            protected new  object MemberwiseClone() { return (true); }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return (""); }
        }
    }
}
