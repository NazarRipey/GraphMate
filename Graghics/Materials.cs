using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graghics
{
    public partial class Materials : Form
    {
        private Form startPage;
        public Materials(StartPage sp)
        {
            this.startPage = sp;
            InitializeComponent();
        }
        private void Materials_Closes(object sender, FormClosedEventArgs e)
        {
            startPage.Show();
        }
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
