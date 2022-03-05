using System.Drawing;

namespace TinyCLR.Compass
{
    public static class GraphicsExtensions
    {
        public static void FillPolygon(this Graphics g, Brush brush, Point[] Points)
        {
            if (Points.Length <= 1) return;
            var pen = new Pen(brush);
            for (var i = 0; i < Points.Length; i++)
            {
                if (i + 1 < Points.Length)
                {
                    var Src = Points[i];
                    var Dst = Points[i + 1];
                    g.DrawLine(pen, (int)Src.X, (int)Src.Y, (int)Dst.X, (int)Dst.Y);
                }
            }
        }
        
        public static void DrawPolygon(this Graphics g, Pen pen, Point[] Points)
        {
            if (Points.Length <= 1) return;
            for (var i = 0; i < Points.Length; i++)
            {
                if (i + 1 < Points.Length)
                {
                    var Src = Points[i];
                    var Dst = Points[i + 1];
                    g.DrawLine(pen, (int)Src.X, (int)Src.Y, (int)Dst.X, (int)Dst.Y);
                }
            }
        }
    }
}