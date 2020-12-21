using System;
using System.Drawing;
using System.Windows;

namespace Graghics.Afinnis
{
    public class Triangle
    {
        public PointF[] Points;

        public Triangle(PointF[] points)
        {
            this.Points = points;
        }

        public Triangle(Triangle square)
        {
            this.Points = new PointF[square.Points.Length];
            square.Points.CopyTo(this.Points, 0);
        }

        public void Scale(double a, double d)
        {
            var matrix1 = new TransformationMatrix(this.Points);
            var matrix2 = new TransformationMatrix(new double[] { a, 0, 0, 0, d, 0, 0, 0, 0 });
            TransformationMatrix result = matrix1 * matrix2;
            result.ReturnPoints(this.Points);
        }



        public void Translate(double m, double n)
        {
            var matrix1 = new TransformationMatrix(this.Points);
            var matrix2 = new TransformationMatrix(new double[] { 1, 0, 0, 0, 1, 0, m, n, 1 });
            TransformationMatrix result = matrix1 * matrix2;
            result.ReturnPoints(this.Points);
        }


        public void Rotate(double angle, bool direction)
        {
            var matrix1 = new TransformationMatrix(this.Points);
            TransformationMatrix matrix2;
            if (!direction)
            {

                matrix2 = new TransformationMatrix(new double[]
                {
                    Math.Cos(angle), Math.Sin(angle), 0,
                    -Math.Sin(angle), Math.Cos(angle), 0,
                    0, 0, 1
                });
            }
            else
            {
                matrix2 = new TransformationMatrix(new double[]
                { Math.Cos(angle), -Math.Sin(angle),0,
                    Math.Sin(angle), Math.Cos(angle),0,
                    0,0,1
                });
            }
            TransformationMatrix result = matrix1 * matrix2;
            result.ReturnPoints(this.Points);
        }

        public static bool IsValid(PointF A, PointF B, PointF C)
        {
            Vector a = new Vector(B.X - A.X, B.Y - A.Y);
            Vector b = new Vector(C.X - B.X, C.Y - B.Y);
            Vector c = new Vector(A.X - C.X, A.Y - C.Y);

            return (a.Length + b.Length > c.Length && a.Length + c.Length > b.Length && b.Length + c.Length > a.Length);
        }
    }
}
