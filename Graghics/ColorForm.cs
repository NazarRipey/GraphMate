using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graghics
{
    public partial class ColorForm : Form
    {
        private StartPage startPage;
        private Bitmap bmp;
        private Bitmap bmp2;

        public ColorForm(StartPage startPage)
        {
            InitializeComponent();
            this.startPage = startPage;
            BeforePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            AfterPicture.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void BeforePicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmp != null)
            {
                Color color;
                try
                {
                    color = bmp.GetPixel(e.X, e.Y);
                }
                catch (Exception)
                {
                    color = Color.FromArgb(0, 0, 0, 0);
                }

                currentColor.BackColor = color;

                R.Text = currentColor.BackColor.R.ToString();
                G.Text = currentColor.BackColor.G.ToString();
                B.Text = currentColor.BackColor.B.ToString();

                R.Refresh(); G.Refresh(); B.Refresh();

                HSV hsv = ColorModelConvertor.ConvertToHSV(currentColor.BackColor);

                H.Text = $"{hsv.H:0.00}";
                S.Text = $"{hsv.S:0.000}";
                V.Text = $"{hsv.V:0.000}";

                H.Refresh(); S.Refresh(); V.Refresh();
            }
        }

        private void AfterPicture_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmp2 != null)
            {
                Color color;
                try
                {
                    color = bmp2.GetPixel(e.X, e.Y);
                }
                catch (Exception)
                {
                    color = Color.FromArgb(0, 0, 0, 0);
                }

                currentColor.BackColor = color;

                R.Text = currentColor.BackColor.R.ToString();
                G.Text = currentColor.BackColor.G.ToString();
                B.Text = currentColor.BackColor.B.ToString();

                R.Refresh(); G.Refresh(); B.Refresh();

                HSV hsv = ColorModelConvertor.ConvertToHSV(currentColor.BackColor);

                H.Text = $"{hsv.H:0.00}";
                S.Text = $"{hsv.S:0.000}";
                V.Text = $"{hsv.V:0.000}";

                H.Refresh(); S.Refresh(); V.Refresh();
            }
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {

                bmp = new Bitmap(dlg.FileName);

                BeforePicture.Image = bmp;

                AfterPicture.Image = null;
                bmp2 = null;
            }

            dlg.Dispose();
            saveToolStripMenuItem.Enabled = false;
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Open image first.");
                return;
            }

            progressBar1.Minimum = 0;
            progressBar1.Maximum = bmp.Width;
            progressBar1.Visible = true;
            progressBar1.Value = 0;

            bmp2 = new Bitmap(bmp);
            Color col;
            HSV hsv = new HSV();

            double brightness = Double.Parse(valueBar.Value.ToString()) / 100;
            double saturation = Double.Parse(saturationBar.Value.ToString()) / 100;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    col = bmp.GetPixel(i, j);
                    hsv = ColorModelConvertor.ConvertToHSV(col);
                    if ((hsv.H >= 340 && hsv.H <= 360) || (hsv.H <= 20 && hsv.H >= 0))
                    {
                        if (hsv.S >= 0.4 && hsv.V >= 0.4)
                        {
                            hsv.V = brightness;
                            hsv.S = saturation;

                            bmp2.SetPixel(i, j, ColorModelConvertor.ConvertToRGB(hsv));
                        }
                    }
                }
                if (this.progressBar1.Value == bmp.Width)
                    this.progressBar1.Value = 0;
                else
                    this.progressBar1.Value += 1;
            }

            progressBar1.Visible = false;
            AfterPicture.Image = bmp2;
            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Title = "Save image";
            f.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (f.ShowDialog() == DialogResult.OK)
            {
                bmp2.Save(f.FileName);
            }
        }

        private void ValueBar_Scroll(object sender, EventArgs e)
        {
            ValueBox.Text = ((double)valueBar.Value / 100).ToString();
        }

        private void saturationBar_Scroll(object sender, EventArgs e)
        {
            SaturationBox.Text = ((double)saturationBar.Value / 100).ToString();
        }

        private void ColorForm_Closed(object sender, FormClosedEventArgs e)
        {
            startPage.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getHelpBtn_Click(object sender, EventArgs e)
        {
            HelpColorModel hcm = new HelpColorModel();
            hcm.ShowDialog();
        }
    }
}
