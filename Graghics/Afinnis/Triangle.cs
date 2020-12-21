using System;
using System.Drawing;

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

        /*public bool IsValid()
        {
            float P(int i, int j)
            {
                return Points[i - 1].X * Points[j - 1].Y;
            }

            return P(1, 4) + P(2, 1) + P(2, 3) + 2 * P(4, 2) + P(3, 4) ==
                   P(1, 2) + 2 * P(2, 4) + P(4, 1) + P(4, 3) + P(3, 2);
        }*/

        public static bool IsValid(PointF A, PointF B, PointF C)
        {
            double a, b, c;

            a = A.GetLength();
            b = B.GetLength();
            c = C.GetLength();

            return (a + b > c && a + c > b && b + c > a);
        }
    }
}
