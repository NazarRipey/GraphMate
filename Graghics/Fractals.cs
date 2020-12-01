using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Graghics
{
    public partial class Fractals : Form
    {
        delegate void TrigonometricFunc(ref double oldReal, ref double oldImagine, out double newReal, out double newImagine, double cReal, double cImagine);

        private Form startPage;
        private Bitmap bitmap;
        private int w;
        private int h;

        private string[] functionArray = {
            "z*sin(z) + c",
            "cos(z) + c",
            "tg(z) + c",
            "ctg(z) + c"
        };

        private string[] colorArray = {
            "Monochrome",
            "Color"
        };

        private FractalFunc fractalFunc = new FractalFunc();
        TrigonometricFunc func;
        private struct FractalFunc
        {
            public void sinus(ref double oldReal, ref double oldImagine, out double newReal, out double newImagine, double cReal, double cImagine)
            {
                newReal = Math.Sin(oldReal) * Math.Cosh(oldImagine) + cReal;
                newImagine = Math.Cos(oldReal) * Math.Sinh(oldImagine) + cImagine;
            }

            public void cosinus(ref double oldReal, ref double oldImagine, out double newReal, out double newImagine, double cReal, double cImagine)
            {
                newReal = Math.Cos(oldReal) * Math.Cosh(oldImagine) + cReal;
                newImagine = -(Math.Sin(oldReal) * Math.Sinh(oldImagine)) + cImagine;
            }

            public void tangent(ref double oldReal, ref double oldImagine, out double newReal, out double newImagine, double cReal, double cImagine)
            {
                double tanRe = Math.Tan(oldReal);
                double tanhIm = Math.Tanh(oldImagine);
                double divider = (1 + Math.Pow(tanRe, 2) * Math.Pow(tanhIm, 2));

                newReal = (tanRe - tanRe * Math.Pow(tanhIm, 2)) / divider + cReal;
                newImagine = (tanhIm + Math.Pow(tanRe, 2) * tanhIm) / divider + cImagine;
            }

            public void cotangent(ref double oldReal, ref double oldImagine, out double newReal, out double newImagine, double cReal, double cImagine)
            {
                double cotRe = 1 / Math.Tan(oldReal);
                double cothIm = (Math.Exp(2 * oldImagine) + 1) / (Math.Exp(2 * oldImagine) - 1);
                double divider = Math.Pow(cotRe, 2) + Math.Pow(cothIm, 2);

                newReal = (-cotRe - cotRe * Math.Pow(cothIm, 2)) / divider + cReal;
                newImagine = (Math.Pow(cotRe, 2) * cothIm - cothIm) / divider + cImagine;
            }
        }

        public Fractals(StartPage sp)
        {
            this.startPage = sp;
            InitializeComponent();
            this.FunctionComboBox.Items.AddRange(this.functionArray);
            this.FunctionComboBox.SelectedIndex = 0;
            this.ColorComboBox.Items.AddRange(this.colorArray);
            this.ColorComboBox.SelectedIndex = 0;
            this.h = FractalBox.Height;
            this.w = FractalBox.Width;
        }

        public void DrawFractal(Graphics g, Pen pen, ProgressBar progress, double cReal, double cImagine, double scaling, int colorMode)
        {
            double newReal, newImagine, oldReal, oldImagine;
            double zoom = scaling, moveX = 0, moveY = 0;
            int maxIterations = 300;

            Random rnd = new Random();
            int rConst = colorMode * rnd.Next(255);
            int gConst = colorMode * rnd.Next(255);
            int bConst = colorMode * rnd.Next(255);

            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    newReal = 1.5 * (x - w / 2) / (0.5 * zoom * w) + moveX;
                    newImagine = (y - h / 2) / (0.5 * zoom * h) + moveY;

                    int i;

                    for (i = 0; i < maxIterations;)
                    {
                        oldReal = newReal;
                        oldImagine = newImagine;

                        func(ref oldReal, ref oldImagine, out newReal, out newImagine, cReal, cImagine);

                        ++i;
                        if (Math.Abs(Math.Abs(oldImagine) - Math.Abs(newImagine)) < 0.001)
                            break;
                    }
                    pen.Color = Color.FromArgb(255, (i * 9 + rConst) % 255, (i * 9 + gConst) % 255, (i * 9 + bConst) % 255);
                    g.DrawRectangle(pen, x, y, 1, 1);
                }
                progress.Value += 1;
            }
        }

        private void setupProgressBar()
        {
            this.progressBar1.Visible = true;
            progressBar1.Value = 0;
            progressBar1.Maximum = FractalBox.Width;
        }

        private void collectDrawParams(ref bool norm, out double cReal, out double cImagine, out int color, out int scaling)
        {
            double cRealText, cImagineText;
            int scaleText;

            if (double.TryParse(this.CReal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out cRealText) &&
                double.TryParse(this.CImagine.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out cImagineText)
                && cRealText >= -2 && cRealText <= 2 && cImagineText >= -2 && cImagineText <= 2)
            {
                cReal = cRealText;
                cImagine = cImagineText;
            }
            else
            {
                norm = false;
                cReal = cImagine = 0;
                MessageBox.Show("Real and imagine parts of Z must be float numbers from -2.0 to 2.0");
            }

            if (int.TryParse(this.Scaling.Text, out scaleText) && scaleText >= 50 && scaleText <= 200)
            {
                scaling = scaleText;
            }
            else
            {
                norm = false;
                scaling = 0;
                MessageBox.Show("Scaling must be integer number from 50 to 200");
            }

            color = this.ColorComboBox.SelectedIndex;
        }

        private void startDrawingBtn_Click(object sender, EventArgs e)
        {
            this.bitmap = new Bitmap(FractalBox.ClientSize.Width, FractalBox.ClientSize.Height);
            FractalBox.Image = bitmap;
            Pen myPen = new Pen(Color.Black, 1);
            Graphics g = Graphics.FromImage(bitmap);

            double cReal, cImagine;
            int scaling, color;
            bool norm = true;

            collectDrawParams(ref norm, out cReal, out cImagine, out color, out scaling);

            if (norm)
            {
                setupProgressBar();
                DrawFractal(g, myPen, progressBar1, cReal, cImagine, (double)scaling / 100.0, color);
                this.saveToolStripMenuItem.Enabled = true;
                this.progressBar1.Visible = false;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "JPG(*.JPG)|*.jpg";
            if (f.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(f.FileName);
            }
        }

        private void FunctionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.FunctionComboBox.SelectedIndex)
            {
                case 0:
                    func = null;
                    func = this.fractalFunc.sinus;
                    break;
                case 1:
                    func = null;
                    func = this.fractalFunc.cosinus;
                    break;
                case 2:
                    func = null;
                    func = this.fractalFunc.tangent;
                    break;
                case 3:
                    func = null;
                    func = this.fractalFunc.cotangent;
                    break;
            }
        }
        private void Fractals_Closed(object sender, FormClosedEventArgs e)
        {
            startPage.Show();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
