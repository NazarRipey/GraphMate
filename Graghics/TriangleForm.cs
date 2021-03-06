﻿using Graghics.Afinnis;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graghics
{
    public partial class TriangleForm : Form
    {
        private Triangle triangle;

        public TriangleForm(Triangle triangle)
        {
            this.triangle = triangle;

            InitializeComponent();
        }
        public TriangleForm()
        {
            InitializeComponent();
        }
        private PointF GetPoint(string X, string Y)
        {
            float x, y;

            if (float.TryParse(X, out x) && float.TryParse(Y, out y))
            {
                return new PointF(x, y);
            }
            else
            {
                MessageBox.Show("Y and X must be float values");
                return PointF.Empty;
            }
        }
        private void newTriangleBtn_Click(object sender, EventArgs e)
        {
            PointF A;
            PointF B;
            PointF C;

            A = GetPoint(X1.Text, Y1.Text);
            B = GetPoint(X2.Text, Y2.Text);
            C = GetPoint(X3.Text, Y3.Text);

            if (A.IsEmpty || B.IsEmpty || C.IsEmpty)
            {
                MessageBox.Show("Points cannot be empty");
            }
            else if (!Triangle.IsValid(A, B, C))
            {
                MessageBox.Show("Triangle with such sides cannot exist");
            }
            else
            {
                triangle.Points = new PointF[] { A, B, C };
                this.Close();
            }
        }
    }
}
