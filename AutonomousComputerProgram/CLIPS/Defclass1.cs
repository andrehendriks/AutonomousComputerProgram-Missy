using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram.CLIPS
{
    public class Defclass : CLIPSNet.Wrapper
    {
        public void BrowseClasses(string router) { }
        public CLIPSNet.DataTypes.Multifield ClassSlots(bool includeInherited) { return null; }
        public CLIPSNet.DataTypes.Multifield ClassSubclasses(bool includeInherited) { return null; }
        public CLIPSNet.Instance CreateRawInstance(string instanceName) { return null; }
        public void DescribeClass(string router) { }
        public CLIPSNet.DataTypes.Multifield GetDefmessageHandlerList(bool includeInherited) { return null; }
        public bool IsSubclassOf(CLIPSNet.Defclass d) { return (true); }
        public bool IsSuperclassOf(CLIPSNet.Defclass d) { return (true); }
        public void ListMessageHandlers(string router, bool includeInherited) { }
        public void PreviewSend(string router, string messageName) { }
        public CLIPSNet.DataTypes.Multifield SlotAllowedClasses(string slotName) { return null; }
        public CLIPSNet.DataTypes.Multifield SlotAllowedValues(string slotName) { return null; }
        public CLIPSNet.DataTypes.Multifield SlotCardinality(string slotName) { return null; }
        public bool SlotDefaultP(string slotName) { return (true); }
        public CLIPSNet.DataType SlotDefaultValue(string slotName) { return null; }
        public bool SlotDirectAccessP(string slotName) { return (true); }
        public bool SlotExistP(string slotName, bool includeInherited) { return (true); }
        public CLIPSNet.DataTypes.Multifield SlotFacets(string slotName) { return null; }
        public bool SlotInitableP(string slotName) { return (true); }
        public bool SlotPublicP(string slotName) { return (true); }
        public CLIPSNet.DataTypes.Multifield SlotRange(string slotName) { return null; }
        public CLIPSNet.DataTypes.Multifield SlotSources(string slotName) { return null; }
        public Type[] SlotTypes(string slotName) { return null; }
        public bool SlotWritableP(string slotName) { return (true); }
        public override string ToString() { return ("*"); }
        public bool Undefclass() { return (false); }
        public bool UndefmessageHandlers() { return (true); }
        public CLIPSNet.Defmodule Defmodule { get; }
        public bool IsAbstract { get; }
        public bool IsDeletable { get; }
        public bool IsReactive { get; }
        public string ModuleName { get; }
        public string Name { get; }
        public string PPForm { get; }
        public  CLIPSNet.DefmessageHandler This(string name, CLIPSNet.DefmessageHandler.Type type) { return null; }
        public bool WatchInstances { get; set; }
        public bool WatchSlots { get; set; }
    }
}
