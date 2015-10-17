using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.CLIPS
{
    public abstract class Router
    {
        public void Activate() { }
        public void Deactivate() { }
        public void Dispose() { }
        protected virtual void Exit(int exitCode) { }
        protected virtual int Getc(string name) { return (1); }
        protected int OtherRouterGetc(string name) { return (1); }
        protected bool OtherRouterPrint(string name, string str) { return (true); }
        protected int OtherRouterUngetc(int ch, string name) { return (1); }
        protected virtual bool Print(string name, string str) { return (true); }
        protected virtual bool Query(string name) { return (true); }
        public Router(CLIPSNet.Environment env, string name, int priority) { return; }
        protected virtual int Ungetc(string name, int ch) { return (1); }
        public bool Activated { get; }
        public string Name { get; }
        protected CLIPSNet.Environment env;
        protected string name;
    }
}
