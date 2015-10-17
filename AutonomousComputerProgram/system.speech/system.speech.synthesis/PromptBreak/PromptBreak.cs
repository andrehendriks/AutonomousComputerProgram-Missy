using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram._1.system.speech.system.speech.synthesis.PromptBreak
{
    public enum PromptBreak
    {
        ExtraLarge, ExtraSmall, Large, Medium, None, Small
    }

    public abstract class Enum
    {
        public int CompareTo(object target) { return (1); }
        protected Enum() { }
        public override bool Equals(object obj) { return (true); }
        [DllImport("mscorlib.dll")]
        public extern static string Format(System.Type enumType, object value, string format);
        public override int GetHashCode() { return (1); }
        [DllImport("mscorlib.dll")]
        public extern static string GetName(System.Type enumType, object value);
        [DllImport("mscorlib.dll")]
        public extern static string[] GetNames(System.Type enumType);
        [DllImport("mscorlib.dll")]
        public static extern System.TypeCode GetTypeCode();
        [DllImport("mscorlib.dll")]
        public extern static System.Type GetUnderlyingType(System.Type enumType);
        [DllImport("mscorlib.dll")]
        public extern static System.Array GetValues(System.Type enumType);
        public bool HasFlag(System.Enum flag) { return (true); }
        public static bool IsDefined(System.Type enumType, object value) { return (true); }
        [DllImport("mscorlib.dll")]
        public extern static object Parse(System.Type enumType, string value);
        [DllImport("mscorlib.dll")]
        public extern static object Parse(System.Type enumType, string value, bool ignoreCase);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, byte value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, int value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, long value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, object value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, sbyte value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, short value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, uint value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, ulong value);
        [DllImport("mscorlib.dll")]
        public extern static object ToObject(System.Type enumType, ushort value);
        public override string ToString() { return (""); }
        [DllImport("mscorlib.dll")]
        public static extern string ToString(string format);
        [DllImport("mscorlib.dll")]
        public static extern string ToString(string format, System.IFormatProvider provider);
        [DllImport("mscorlib.dll")]
        public static extern string ToString(System.IFormatProvider provider);
        //public extern static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result)
    //where TEnum : struct;
        //public extern static bool TryParse<TEnum>(string value, out TEnum result)
    //where TEnum : struct;
        public interface IComparable { int CompareTo(object obj); }
        public interface IConvertible
        {
            System.TypeCode GetTypeCode();
            bool ToBoolean(System.IFormatProvider provider);
            byte ToByte(System.IFormatProvider provider);
            char ToChar(System.IFormatProvider provider);
            System.DateTime ToDateTime(System.IFormatProvider provider);
            decimal ToDecimal(System.IFormatProvider provider);
            double ToDouble(System.IFormatProvider provider);
            short ToInt16(System.IFormatProvider provider);
            int ToInt32(System.IFormatProvider provider);
            long ToInt64(System.IFormatProvider provider);
            sbyte ToSByte(System.IFormatProvider provider);
            float ToSingle(System.IFormatProvider provider);
            string ToString(System.IFormatProvider provider);
            object ToType(System.Type conversionType, System.IFormatProvider provider);
            ushort ToUInt16(System.IFormatProvider provider);
            uint ToUInt32(System.IFormatProvider provider);
            ulong ToUInt64(System.IFormatProvider provider);
        }
        public interface IFormattable { string ToString(string format, System.IFormatProvider formatProvider); }

        public abstract class ValueType
        {
            public override bool Equals(object obj) { return (true); }
            public override int GetHashCode() { return (1); }
            public override string ToString() { return ("*"); }
            protected ValueType() { }

            public class Object
            {
                ~Object() { }
                public new virtual bool Equals(object obj) { return (true); }
                public new static bool Equals(object objA, object objB) { return (true); }
                public new virtual int GetHashCode() { return (1); }
                //public extern System.Type GetType();
                protected new object MemberwiseClone() { return true; }
                public Object() { }
                public new static bool ReferenceEquals(object objA, object objB) { return (true); }
                public new virtual string ToString() { return ("*"); }
            }

        }
    }
}
