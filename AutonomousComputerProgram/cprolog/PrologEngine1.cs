using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prolog;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.cprolog
{
    public class PrologEngine
    {
        public void CheckConfigFile() { }
        public void CheckInitialConsultFile() { }
        public long ClockTicksMSecs() { return (200); }
        public void Console_CancelKeyPress(object sender, System.ConsoleCancelEventArgs e) { }
        public void Consult(string fileName) { }
        public void CreateFact(string functor, Prolog.PrologEngine.BaseTerm[] args) { }
        public int ElapsedTime() { return (1); }
        public void EraseVariables() { }
//        public Prolog.SolutionSet GetAllSolutions(string sourceFileName, string query) { }
//        public Prolog.SolutionSet GetAllSolutions(string sourceFileName, string query, int maxSolutionCount) {  }
        public string GetAllSolutionsXml(string sourceFileName, string destinFileName, string query) { return (""); }
        public string GetAllSolutionsXml(string sourceFileName, string destinFileName, string query, int maxSolutionCount) { return (""); }
//       public System.Collections.Generic.IEnumerable<Prolog.PrologEngine.ISolution> GetEnumerator() {  }
//        public Prolog.PrologEngine.ISolution GetFirstSolution(string query) {  }
//        public Prolog.PrologEngine.BaseTerm GetVariable(string s) { return ("s"); }
        public static bool MaxWriteDepthExceeded(int level) { return (true); }
//        public Prolog.PrologEngine.BaseTerm NewIsoOrCsStringTerm(string s) { }
        public void NewLine() { }
        public  void PersistCommandHistory() { }
        public  void PostQueryTidyUp() { }
        public bool PrepareSolutions(string query) { return (true); }
        public bool ProcessArgs(string[] args, bool windowsMode) { return (true); }
//        public  System.TimeSpan ProcessorTime() {  }
        public PrologEngine() { }
        public PrologEngine(Prolog.BasicIo io) { }
        public  void RegisterVarNonSingleton(string s) { }
        public  void ReportSingletons(Prolog.PrologEngine.ClauseNode c, int lineNo, ref bool firstReport) { }
        public void Reset() { }
        public  void RetryCurrentGoal(int level) { }
        public void SetProfiling(bool mode) { }
        public  void SetStringStyle(Prolog.PrologEngine.BaseTerm t) { }
        public  void SetVariable(Prolog.PrologEngine.BaseTerm t, string s) { }
        public  void Write(string s) { }
        public  void Write(string s, params object[] args) { }
        public  void WriteLine(string s) { }
        public  void WriteLine(string s, params object[] args) { }
        public Prolog.PrologEngine.BracketTable AltListTable { get; }
        public Prolog.BasicIo BasicIO { get; set; }
        public int CmdNo { get; }
        public bool Debugging { get; }
        public bool Error { get; }
        public bool Halted { get; set; }
        public Prolog.PrologEngine.OperatorTable OpTable { get; }
        public string Prompt { get; }
        public Prolog.PrologEngine.PredicateTable Ps { get; }
        public string Query { get; set; }
        public Prolog.PrologEngine.BracketTable WrapTable { get; }
        public static readonly System.Globalization.CultureInfo CIC;
        public static string IntroText;
        public System.Collections.Generic.IEnumerable<Prolog.PrologEngine.ISolution> SolutionIterator;
        public class Object
        {
            ~Object() { }
            public new  virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return (true); }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new  virtual string ToString() { return (""); }
        }
    }
}
