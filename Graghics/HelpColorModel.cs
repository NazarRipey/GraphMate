using System.Windows.Forms;

namespace Graghics
{
    public partial class HelpColorModel : Form
    {
        public HelpColorModel()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://uk.wikipedia.org/wiki/Колірна_модель");
        }
    }
}
