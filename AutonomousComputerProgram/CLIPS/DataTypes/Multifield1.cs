using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;


namespace AutonomousComputerProgram.CLIPS.DataTypes
{
    class Multifield
    {
        public void Add(CLIPSNet.DataType item) { }
        public void Add(params CLIPSNet.DataType[] items) { }
        public void Clear() { }
        public bool Contains(CLIPSNet.DataType item) { return (true); }
        public void CopyTo(CLIPSNet.DataType[] array) { }
        public void CopyTo(CLIPSNet.DataType[] array, int arrayIndex) { }
        public void CopyTo(int index, CLIPSNet.DataType[] array, int arrayIndex, int count) { }
        public override bool Equals(object obj) { return (true); }
        public System.Collections.Generic.IEnumerator<CLIPSNet.DataType> GetEnumerator() { return null; }
        public override int GetHashCode() { return (1); }
        public Multifield(params CLIPSNet.DataType[] fals) { }
        public bool Remove(CLIPSNet.DataType item) { return (true); }
        public void RemoveAt(int index) { }
        public override string ToString() { return ("*"); }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public  CLIPSNet.DataType this[int index] { get { return null; }  set { } }
    }

    public abstract class DataType
    {
        protected DataType() { }
        public interface ICollection<DataType> {
            void Add(CLIPSNet.DataType item);
            void Clear();
            bool Contains(CLIPSNet.DataType item);
            void CopyTo(CLIPSNet.DataType[] array, int arrayIndex);
            bool Remove(CLIPSNet.DataType item);
            int Count { get; }
            bool IsReadOnly { get; }
        }
        public interface IEnumerable
        {
            System.Collections.IEnumerator GetEnumerator();
        }
        public interface IEnumerable<DataType>
        {
            System.Collections.Generic.IEnumerator<CLIPSNet.DataType> GetEnumerator();
        }
    }
}
