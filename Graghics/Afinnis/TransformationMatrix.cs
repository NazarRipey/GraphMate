using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graghics.Afinnis
{
    class TransformationMatrix
    {
        double[,] values;
        private int m;
        private int n;

        public TransformationMatrix(int rows, int cols)
        {
            this.values = new double[rows, cols];
            this.m = rows;
            this.n = cols;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    values[i, j] = 0;
                }
            }
        }

        public TransformationMatrix(double[] values)
        {
            this.values = new double[3, 3];
            m = 3;
            n = 3;
            this.values[0, 0] = values[0];
            this.values[0, 1] = values[1];
            this.values[0, 2] = values[2];

            this.values[1, 0] = values[3];
            this.values[1, 1] = values[4];
            this.values[1, 2] = values[5];

            this.values[2, 0] = values[6];
            this.values[2, 1] = values[7];
            this.values[2, 2] = values[8];
        }

        public TransformationMatrix(PointF[] points)
        {
            this.values = new double[3, 3];
            m = 3;
            n = 3;
            this.values[0, 0] = points[0].X;
            this.values[0, 1] = points[0].Y;
            this.values[0, 2] = 1;

            this.values[1, 0] = points[1].X;
            this.values[1, 1] = points[1].Y;
            this.values[1, 2] = 1;


            this.values[2, 0] = points[2].X;
            this.values[2, 1] = points[2].Y;
            this.values[2, 2] = 1;

        }

        public void Show(RichTextBox obj)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    obj.Text += $@"{values[i, j]}   ";
                }
                obj.Text += Environment.NewLine;
            }
        }

        public static TransformationMatrix operator *(TransformationMatrix a, TransformationMatrix b)
        {
            var result = new TransformationMatrix(a.m, a.n);

            for (int i = 0; i < a.m; i++)
            {
                for (int j = 0; j < a.n; j++)
                {
                    double tmp = 0;
                    for (int k = 0; k < a.n; k++)
                    {
                        tmp += a.values[i, k] * b.values[k, j];
                    }
                    result.values[i, j] = tmp;
                }
            }

            return result;
        }
        public void ReturnPoints(PointF[] points)
        {
            points[0].X = (float)this.values[0, 0];
            points[0].Y = (float)this.values[0, 1];

            points[1].X = (float)this.values[1, 0];
            points[1].Y = (float)this.values[1, 1];

            points[2].X = (float)this.values[2, 0];
            points[2].Y = (float)this.values[2, 1];
        }
    }
}
