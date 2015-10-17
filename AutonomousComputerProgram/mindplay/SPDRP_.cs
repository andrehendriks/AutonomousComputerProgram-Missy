using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeuroSky.ThinkGear;
using System.Runtime.InteropServices;
namespace AutonomousComputerProgram.mindplay
{
    public enum SPDRP_
    {
        SPDRP_CAPABILITIES, SPDRP_CLASS, SPDRP_CLASSGUID, SPDRP_CONFIGFLAGS, SPDRP_DEVICEDESC, SPDRP_DRIVER, SPDRP_FRIENDLYNAME, SPDRP_HARDWAREID, SPDRP_INSTALL_STATE, SPDRP_MFG, SPDRP_PHYSICAL_DEVICE_OBJECT_NAME, SPDRP_REMOVAL_POLICY_HW_DEFAULT, SPDRP_SERVICE
    }
    public abstract class Enum
    {
        public int CompareTo(object target) { return (1); }
        protected Enum() { }
        public override bool Equals(object obj) { return true; }
        public static string Format(System.Type enumType, object value, string format) { return ("*"); }
        public override int GetHashCode() { return (1); }
        public static string GetName(System.Type enumType, object value) { return ("*"); }
        [DllImport("Thinkgear")]
        public static extern string[] GetNames(System.Type enumType); //{ return; }
        //[DllImport("Thinkgear")]
        public System.TypeCode GetTypeCode() { return(0); }
        [DllImport("Thinkgear")]
        public static extern System.Type GetUnderlyingType(System.Type enumType); //{ return(0); }
        [DllImport("Thinkgear")]
        public static extern System.Array GetValues(System.Type enumType); //{ return (0); }
        public bool HasFlag(System.Enum flag) { return true; }
        public static bool IsDefined(System.Type enumType, object value) { return true; }
        public static object Parse(System.Type enumType, string value) { return (""); }
        public static object Parse(System.Type enumType, string value, bool ignoreCase) { return true; }
        public static object ToObject(System.Type enumType, byte value) { return 0x1; }
        public static object ToObject(System.Type enumType, int value) { return 1; }
        public static object ToObject(System.Type enumType, long value) { return 200; }
        public static object ToObject(System.Type enumType, object value) { return true; }
        public static object ToObject(System.Type enumType, sbyte value) { return 0x1; }
        public static object ToObject(System.Type enumType, short value) { return 1; }
        public static object ToObject(System.Type enumType, uint value) { return 1; }
        public static object ToObject(System.Type enumType, ulong value) { return 200; }
        public static object ToObject(System.Type enumType, ushort value) { return 1; }
        public override string ToString() { return ""; }
        public string ToString(string format) { return ""; }
        public string ToString(string format, System.IFormatProvider provider) { return ""; }
        public string ToString(System.IFormatProvider provider) { return ""; }
        //[DllImport("Thinkgear")]
        //public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct {   }
        //public static bool TryParse<TEnum>(string value, out TEnum result) where TEnum : struct { return true; }
        public interface IComparable
        { int CompareTo(object obj); }
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
        public interface IFormattable
        {
            string ToString(string format, System.IFormatProvider formatProvider);
        }
        public abstract class ValueType
        {
            public override bool Equals(object obj) { return true; }
            public override int GetHashCode() { return 1; }
            public override string ToString() { return ""; }
            protected ValueType() { }
        }
    }
}
