using System;
using System.Drawing;

namespace Graghics.Afinnis
{
    public static class PointFExtension
    {
        public static double GetLength(this PointF point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }
    }
}
