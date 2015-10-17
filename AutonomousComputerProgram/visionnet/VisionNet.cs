using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisionNET;

namespace AutonomousComputerProgram.visionnet
{
    class VisionNet
    {
    }
    public sealed class BinaryImage
    {
        //public int BinaryImage(int rows, int columns) { return (1); }
        public void Clear() { }
        public bool ComputeRectangleSum(int startRow, int startColumn, int rows, int columns, int channel) { return (true); }
        public bool ComputeRectangleSum(int row, int column, int channel, VisionNET.Rectangle rect) { return (true); }
        public void ExtractChannel(bool[,] channel) { }
        public void ExtractRectangle(bool[,,] startRow, int startColumn, int rows, int columns) { }
        public void SetData(bool[,,] data) { }
        public void SetDimensions(int rows, int columns, int channels) { }
        //public System.Windows.Media.Imaging.BitmapSource ToBitmap() { return; }
        public int Channels { get; }
        public int Columns { get; }
        public int Height { get; }
        public string ID { get; set; }
        public bool IsIntegral { get; set; }
        public bool[,,] RawArray { get; }
        public int Rows { get; }
        //public bool this[int row, int column, int channel] { get; set; }
        //public bool this[int row, int column] { get; set; }
        public int Width { get; }
    }
    public sealed class BooleanArrayHandler
    {
        public BooleanArrayHandler() { }
        public BooleanArrayHandler(bool[,,] data) { }
        public BooleanArrayHandler(int rows, int columns, int channels) { }
        public void Clear() { }
        public bool ComputeRectangleSum(int startRow, int startColumn, int rows, int columns, int channel) { return (true); }
        public bool ComputeRectangleSum(int row, int column, int channel, VisionNET.Rectangle rect) { return (true); }
        public void ExtractChannel(bool[,] channel) { }
        public void ExtractRectangle(bool[,,] startRow, int startColumn, int rows, int columns) { }
        public void SetData(bool[,,] data) { }
        public void SetDimensions(int rows, int columns, int channels) { }
        public int Channels { get; }
        public int Columns { get; }
        public bool IsIntegral { get; set; }
        public bool[,,] RawArray { get; }
        public int Rows { get; }
        //public bool this[int row, int column, int channel] { get; set; }
    }
    public sealed class ByteArrayHandler
    {
        public ByteArrayHandler() { }
        public ByteArrayHandler(byte[,,] data) { }
        public ByteArrayHandler(int rows, int columns, int channels) { }
        public void Clear() { }
        public byte ComputeRectangleSum(int startRow, int startColumn, int rows, int columns, int channel) { return (0x1); }
        public byte[,] ExtractChannel(int channel) { return null; }
        public byte[,,] ExtractRectangle(int startRow, int startColumn, int rows, int columns) { return null; }
        public void SetData(byte[,,] data) { }
        public void SetDimensions(int rows, int columns, int channels) { }
        public int Channels { get; }
        public int Columns { get; }
        public bool IsIntegral { get; set; }
        public byte[,,] RawArray { get; }
        public int Rows { get; }
        //        public byte this[int row, int column, int channel] { get; set; }
    }
    public static class Canny
    {
        public static VisionNET.BinaryImage Compute(VisionNET.GradientImage image) { return null; }
        public static VisionNET.BinaryImage Compute(VisionNET.GradientImage image, float lowThreshold, float highThreshold) { return null; }
        //public const float HIGHER_THRESHOLD;
        //public const float LOWER_THRESHOLD;
    }
    public class ClearHandler
    {
        public virtual System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object obja, object objb) { return null; }
        public ClearHandler(object obja, object objb, System.IntPtr method) { return; }
        public virtual void EndInvoke(System.IAsyncResult result) { return; }
        public virtual void Invoke() { return; }

    }
    public static class ColorConversion
    {
        public static void HSV2RGB(float h, float s, float v, ref float r, ref float g, ref float b) { }
        public static void Lab2RGB(float L, float a, float b, ref float R, ref float G, ref float B) { }
        public static void RGB2HSV(float r, float g, float b, ref float h, ref float s, ref float v) { }
        public static void RGB2Lab(float R, float G, float B, ref float L, ref float a, ref float b) { }
        public static void RGB2rgb(float R, float G, float B, ref float r, ref float g, ref float b) { }
        public static void rgb2RGB(float r, float g, float b, ref float R, ref float G, ref float B) { }
        public static void RGB2YUV(float r, float g, float b, ref float y, ref float u, ref float v) { }
        public static void RGB2YUV(int r, int g, int b, ref int y, ref int u, ref int v) { }
        public static void YUV2RGB(float y, float u, float v, ref float r, ref float g, ref float b) { }
    }

}
