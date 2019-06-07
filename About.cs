using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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
    }
}
