using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graghics
{
    public static class InterfaceHelper
    {
        public static void OnMouseEnterGrayButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.FromArgb(115, 115, 115);
        }
        public static void OnMouseLeaveGrayButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.FromArgb(196, 196, 196);
        }

        public static void OnMouseEnterGreenButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.FromArgb(11, 150, 71);
        }
        public static void OnMouseLeaveGreenButton(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.FromArgb(33, 150, 83);
        }
    }
}
