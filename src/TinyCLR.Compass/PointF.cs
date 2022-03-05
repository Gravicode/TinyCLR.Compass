using System;
using System.Collections;
using System.Text;
using System.Threading;

namespace TinyCLR.Compass
{
    public struct PointF
    {
        public PointF(float ax, float ay)
        {
            this.X = ax;
            this.Y = ay;

        }
        public float X { get; set; }
        public float Y { get; set; }
    }

    public class CompassSize
    {
        public CompassSize(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    public struct Point
    {
        public Point(int ax, int ay)
        {
            this.X = ax;
            this.Y = ay;

        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
