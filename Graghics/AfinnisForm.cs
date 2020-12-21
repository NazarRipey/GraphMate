using Graghics.Afinnis;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Graghics
{
    public partial class AfinnisForm : Form
    {
        private StartPage startPage;
        AfinnisGraphics graphics;
        static double movePerStep = 0;

        public AfinnisForm(StartPage startPage)
        {
            InitializeComponent();

            this.startPage = startPage;
            drawGrid();
        }
        void drawGrid()
        {
            canvas.Image = null;
            graphics = null;
            canvas.Image = new Bitmap(canvas.Width, canvas.Height);
            graphics = new AfinnisGraphics(canvas.Image as Bitmap);
            graphics.InitCanvas();
            canvas.BackColor = Color.White;
        }

        public Triangle FirstTriangle { get; set; }
        public Triangle SecondTriangle { get; set; }

        TransformationMatrix rotate1 = new TransformationMatrix(new double[]
               {
                    Math.Sqrt(2)/2, -Math.Sqrt(2)/2, 0,
                    Math.Sqrt(2)/2, Math.Sqrt(2)/2, 0,
                    0, 0, 1
               }),
            rotate2 = new TransformationMatrix(new double[]
               {
                    Math.Sqrt(2)/2,  Math.Sqrt(2)/2, 0,
                    -Math.Sqrt(2)/2, Math.Sqrt(2)/2, 0,
                    0, 0, 1
               });

        TransformationMatrix mirror = new TransformationMatrix(new double[] { 0, 1, 0,
                                                                              1, 0, 0,
                                                                              0, 0, 1});

        private void transformButton_Click(object sender, EventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            TransformationMatrix coordinates = new TransformationMatrix(FirstTriangle.Points);
            TransformationMatrix coordinates2 = new TransformationMatrix(SecondTriangle.Points);

            double length = (double)lengthBar.Value;
            double scaleCoef = 1 + (double)scalePerStep.Value / 10;
            movePerStep = length / numberOfSteps.Value;

            TransformationMatrix scale = new TransformationMatrix(new double[] { scaleCoef, 0, 0,
                                                                                 0, scaleCoef, 0,
                                                                                 0, 0, 1 });

            TransformationMatrix translate = new TransformationMatrix(new double[] { 1, 0, 0,
                                                                                     0, 1, 0,
                                                                           movePerStep, 0, 1 });
            var option = rotate1 * translate * scale * rotate2;

            for (int i = 0; i < numberOfSteps.Value; ++i)
            {
                coordinates *= option;
                coordinates2 = coordinates * mirror;

                coordinates.ReturnPoints(FirstTriangle.Points);
                coordinates2.ReturnPoints(SecondTriangle.Points);

                drawGrid();
                graphics.DrawTriangle(FirstTriangle, Color.Red, false);
                graphics.DrawTriangle(SecondTriangle, Color.Green, false);

                canvas.Refresh();
                System.Threading.Thread.Sleep(500);
            }
        }
        private void numberOfSteps_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = numberOfSteps.Value.ToString();
        }

        private void scalePerStep_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = scalePerStep.Value * 10 + "%";
        }
        private void lengthBar_ValueChanged(object sender, EventArgs e)
        {
            label10.Text = lengthBar.Value.ToString();
        }

        private void newTriangleButton_Click(object sender, EventArgs e)
        {
            PointF[] pf = null;
            Triangle tempTriangle = new Triangle(pf);
            TriangleForm triangleForm = new TriangleForm(tempTriangle);
            triangleForm.ShowDialog();

            if (tempTriangle.Points != null)
            {
                FirstTriangle = tempTriangle;
                SecondTriangle = new Triangle(FirstTriangle);

                TransformationMatrix coordinates = new TransformationMatrix(SecondTriangle.Points);
                coordinates *= mirror;
                coordinates.ReturnPoints(SecondTriangle.Points);

                drawGrid();
                graphics.DrawTriangle(FirstTriangle, Color.Red, false);
                graphics.DrawTriangle(SecondTriangle, Color.Green, false);

                this.TransormBtn.Enabled = true;
            }
            else if (FirstTriangle != null)
            {
                drawGrid();
                graphics.DrawTriangle(FirstTriangle, Color.Red, false);
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Title = "Save image";
            f.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (f.ShowDialog() == DialogResult.OK)
            {
                canvas.Image.Save(f.FileName);
            }
        }

        private void AfinnisForm_Closed(object sender, FormClosedEventArgs e)
        {
            startPage.Show();
        }
    }
}
