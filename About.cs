using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace MARK
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "About US";
        }

        private void About_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Leave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label19_MouseMove(object sender, MouseEventArgs e)
        {
            label19.ForeColor = Color.DeepSkyBlue;
        }

        private void Label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = Color.DodgerBlue;
        }

        private void Label19_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.github.com/Pahasara");
        }
    }
}
