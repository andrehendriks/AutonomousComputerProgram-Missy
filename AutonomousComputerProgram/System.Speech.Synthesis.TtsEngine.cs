using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis.TtsEngine;
using System.Runtime.InteropServices;

namespace AutonomousComputerProgram_System_Speech_Synthesis_TtsEngine
{
    public struct ContourPoint
    {
        public float ContourPoint1(float start, float change, System.Speech.Synthesis.TtsEngine.ContourPointChangeType changeType) { return(1); }
        public override bool Equals(object obj) { return (true); }
        public bool Equals(System.Speech.Synthesis.TtsEngine.ContourPoint other) { return (true); }
        public override int GetHashCode() { return (1); }

        //public static bool operator !=(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { return (!false); }     
        //public static bool  operator  ==(System.Speech.Synthesis.TtsEngine.ContourPoint point1, System.Speech.Synthesis.TtsEngine.ContourPoint point2) { return (true); }
        public float  Change { get; }
        public System.Speech.Synthesis.TtsEngine.ContourPointChangeType ChangeType { get; }
        public float Start { get; }
        public interface IEquatable<ContourPoint> { bool Equals(System.Speech.Synthesis.TtsEngine.ContourPoint other); }
        public abstract class ValueType { }
    }
    public enum ContourPointChangeType
    {
        Hz, Percentage
    }
    public enum EmphasisBreak
    {
        Default, ExtraStrong, ExtraWeak, Medium, None, Strong, Weak
    }
    public enum EmphasisWord
    {
        Default, Moderate, None, Reduced, Strong
    }
    public enum EventParameterType
    {
        Object, Pointer, String, Token, Undefined
    }
    public struct FragmentState
    {
        public override bool Equals(object obj) { return true; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.FragmentState other) { return true; }
//        public FragmentState(System.Speech.Synthesis.TtsEngine.TtsEngineAction action, int langId, int emphasis, int duration, System.Speech.Synthesis.TtsEngine.SayAs sayAs, System.Speech.Synthesis.TtsEngine.Prosody prosody, char[] phonemes) { }
        public override int GetHashCode() { return 1; }
        //        public static bool operator !=(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2)
        //        public static bool operator ==(System.Speech.Synthesis.TtsEngine.FragmentState state1, System.Speech.Synthesis.TtsEngine.FragmentState state2)
        public System.Speech.Synthesis.TtsEngine.TtsEngineAction Action { get; }
        public int Duration { get; set; }
        public int Emphasis { get; set; }
        public int LangId { get; set; }
        public char[] Phoneme { get; set; }
        public System.Speech.Synthesis.TtsEngine.Prosody Prosody { get; set; }
        public System.Speech.Synthesis.TtsEngine.SayAs SayAs { get; set; }
        public interface IEquatable<FragmentState>
        {
            //             bool Equals(System.Speech.Synthesis.TtsEngine.FragmentState other)  { return Action; return Duration; return Emphasis; return LangId; return Phoneme; return Prosody; return SayAs; }
            
        }
    }
    public interface ITtsEngineSite
    {
        void AddEvents(System.Speech.Synthesis.TtsEngine.SpeechEventInfo[] events, int count);
        void CompleteSkip(int skipped);
        System.Speech.Synthesis.TtsEngine.SkipInfo GetSkipInfo();
        System.IO.Stream LoadResource(System.Uri uri, string mediaType);
        int Write(System.IntPtr data, int count);
        int Actions { get; }
        int EventInterest { get; }
        int Rate { get; }
        int Volume { get; }
    }
    public class Prosody
    {
        public System.Speech.Synthesis.TtsEngine.ContourPoint[] GetContourPoints() { return null; }
        public Prosody() { }
        public void SetContourPoints(System.Speech.Synthesis.TtsEngine.ContourPoint[] points) { }
        public int Duration { get; set; }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Pitch { get; set; }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Range { get; set; }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Rate { get; set; }
        public System.Speech.Synthesis.TtsEngine.ProsodyNumber Volume { get; set; }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
    public struct ProsodyNumber
    {
        public override bool Equals(object obj) { return (true); }
        public bool Equals(System.Speech.Synthesis.TtsEngine.ProsodyNumber other) { return (true); }
        public override int GetHashCode() { return (1); }
//        public ProsodyNumber(float number) {  }
//        public ProsodyNumber(int ssmlAttributeId) { }
        //public static bool operator !=(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2);
        //public static bool operator ==(System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber1, System.Speech.Synthesis.TtsEngine.ProsodyNumber prosodyNumber2);
        public bool IsNumberPercent { get; }
        public float Number { get; }
        public int SsmlAttributeId { get; }
        public System.Speech.Synthesis.TtsEngine.ProsodyUnit Unit { get; }
//        public const int AbsoluteNumber;
        public interface IEquatable<ProsodyNumber>
        {
            bool Equals(System.Speech.Synthesis.TtsEngine.ProsodyNumber other);
        }
        public abstract class ValueType
        {
            public override bool Equals(object obj) { return (true); }
            public override int GetHashCode() { return (1); }
            public override string ToString() { return (""); }
            protected ValueType() { }
            public class Object
            {
                ~Object() { }
                public new virtual bool Equals(object obj) { return (true); }
                public new static bool Equals(object objA, object objB) { return (true); }
                public new virtual int GetHashCode() { return (1); }
                public new System.Type GetType() { return null; }
                protected new object MemberwiseClone() { return null; }
                public Object(){ }
                public new static bool ReferenceEquals(object objA, object objB) { return (true); }
                public new virtual string ToString() { return (""); }
            }
        }
    }
    public enum ProsodyPitch
    {
        Default, ExtraHigh, ExtraLow, High, Low, Medium
    }
    public abstract class Enum
    {
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
        { string ToString(string format, System.IFormatProvider formatProvider); }
        public abstract int CompareTo(object target);// { return (1); }
        protected Enum() { }
        public new abstract bool Equals(object obj);// { return (true); }
        public  static string Format(System.Type enumType, object value, string format) { return ("X"); }
        public override int GetHashCode() { return (1); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType">GetName</param>
        /// <param name="value">Default</param>
        /// <returns></returns>
        public static string GetName(System.Type enumType, object value) { return ("Low"); }
        public static void  GetNames(string[] Default, System.Type enumType) { return; }
        public System.TypeCode GetTypeCode() { return (0); }
        public static System.Type GetUnderlyingType(System.Type enumType)
        {
            if (true)
            {
                return (default(Type));
            }

#pragma warning disable CS0162 // Unreachable code detected
            else if (true)
#pragma warning restore CS0162 // Unreachable code detected
            {
                return null;
            }
            else
            {
                return typeof(Type);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="enumType"></param>
        /// <returns></returns>
        public static System.Array GetValues(System.Type enumType) { return null; }
        public bool HasFlag(System.Enum flag) { return true; }
        public static bool IsDefined(System.Type enumType, object value) { return(true); }
        public static object Parse(System.Type enumType, string value) { return null; }
        public static object Parse(System.Type enumType, string value, bool ignoreCase) { return null; }
        public static object ToObject(System.Type enumType, byte value) { return null; }
        public static object ToObject(System.Type enumType, int value) { return null; }
        public static object ToObject(System.Type enumType, long value) { return null; }
        public static object ToObject(System.Type enumType, object value) { return null; }
        public static object ToObject(System.Type enumType, sbyte value) { return null; }
        public static object ToObject(System.Type enumType, short value) { return null; }
        public static object ToObject(System.Type enumType, uint value) { return null; }
        public static object ToObject(System.Type enumType, ulong value) { return null; }
        public static object ToObject(System.Type enumType, ushort value) { return null; }
        public override string ToString() { return ("message"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="format">ToString</param>
        /// <returns>message</returns>
        public string ToString(string format) { return ("message"); }
        public string ToString(string format, System.IFormatProvider provider) { return ("message"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="provider">System.Speech.Synthesiz.TTSEngine</param>
        /// <returns>message</returns>
        public string ToString(System.IFormatProvider provider) { return ("message"); }
        //        public static bool TryParse<TEnum>(string value, bool ignoreCase, out TEnum result) where TEnum : struct { }   
        //        public static bool TryParse<TEnum>(string value, out TEnum result)
        //            where TEnum : struct
        //        { }
        public abstract class ValueType
        {
            public override bool Equals(object obj) { return true; }
            public override int GetHashCode() { return 1; }
            public override string ToString() { return "message"; }
            protected ValueType() { }
            public class Object
            {
                ~Object() { }
                public new virtual bool Equals(object obj) { return true; }
                public new static bool Equals(object objA, object objB) { return true; }
                public new virtual int GetHashCode() { return 1; }
                public new System.Type GetType() { return null; }
                protected new object MemberwiseClone() { return null; }
                public Object() { }
                public new static bool ReferenceEquals(object objA, object objB) { return true; }
                public new virtual string ToString() { return "message"; }
            }
        }
    }
    public enum ProsodyRange
    {
        Default, ExtraHigh, ExtraLow, High, Low, Medium
    }
    public enum ProsodyRate
    {
        Default, ExtraFast, ExtraSlow, Fast, Medium, Slow
    }
    public enum ProsodyUnit
    {
        Default, Hz, Semitone
    }
    public enum ProsodyVolume
    {
        Default, ExtraLoud, ExtraSoft, Loud, Medium, Silent, Soft
    }

    public class SayAs
    {
        public SayAs() { }
        public string Detail { get; set; }
        public string Format { get; set; }
        public string InterpretAs { get; set; }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
    public class SkipInfo
    {
        public SkipInfo() { }
        public int Count { get; set; }
        public int Type { get; set; }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
    public enum SpeakOutputFormat
    {
        Text, WaveFormat
    }
    public struct SpeechEventInfo
    {
        public override bool Equals(object obj) { return true; }
        public bool Equals(System.Speech.Synthesis.TtsEngine.SpeechEventInfo other) { return true; }
        public override int GetHashCode() { return 1; }
        // public SpeechEventInfo(short eventId, short parameterType, int param1, System.IntPtr param2) {  }
        // public static bool operator !=(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2)
        // public static bool operator ==(System.Speech.Synthesis.TtsEngine.SpeechEventInfo event1, System.Speech.Synthesis.TtsEngine.SpeechEventInfo event2)
        public short EventId { get; }
        public int Param1 { get; }
        public System.IntPtr Param2 { get; }
        public short ParameterType { get; }
    }
    public class TextFragment
    {
        public TextFragment() { }
        public System.Speech.Synthesis.TtsEngine.FragmentState State { get; set; }
        public int TextLength { get; set; }
        public int TextOffset { get; set; }
        public string TextToSpeak { get; set; }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
    public enum TtsEngineAction
    {
        Bookmark, ParseUnknownTag, Pronounce, Silence, Speak, SpellOut, StartParagraph, StartSentence
    }
    public abstract class TtsEngineSsml
    {
        public abstract void AddLexicon(System.Uri uri, string mediaType, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
        public abstract System.IntPtr GetOutputFormat(System.Speech.Synthesis.TtsEngine.SpeakOutputFormat speakOutputFormat, System.IntPtr targetWaveFormat);
        public abstract void RemoveLexicon(System.Uri uri, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
        public abstract void Speak(System.Speech.Synthesis.TtsEngine.TextFragment[] fragment, System.IntPtr waveHeader, System.Speech.Synthesis.TtsEngine.ITtsEngineSite site);
        protected TtsEngineSsml(string registryKey) { }
        public class Object
        {
            ~Object() { }
            public new virtual bool Equals(object obj) { return (true); }
            public new static bool Equals(object objA, object objB) { return (true); }
            public new virtual int GetHashCode() { return (1); }
            public new System.Type GetType() { return null; }
            protected new object MemberwiseClone() { return null; }
            public Object() { }
            public new static bool ReferenceEquals(object objA, object objB) { return (true); }
            public new virtual string ToString() { return ("Error: the request has timed out!"); }
        }
    }
    public enum TtsEventId
    {
        AudioLevel, Bookmark, EndInputStream, Phoneme, SentenceBoundary, StartInputStream, Viseme, VoiceChange, WordBoundary
    }
}
