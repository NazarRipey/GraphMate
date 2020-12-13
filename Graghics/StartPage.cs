using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graghics
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BuildFractalBtn_Click(object sender, EventArgs e)
        {
            Fractals fractals = new Fractals(this);
            fractals.Show();

            this.Hide();
        }

        private void ColorModelsBtn_Click(object sender, EventArgs e)
        {
            ColorForm colorForm = new ColorForm(this);
            colorForm.Show();

            this.Hide();
        }

        private void FigureMoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReferenceBtn_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials(this);
            materials.Show();

            this.Hide();
        }
    }
}
