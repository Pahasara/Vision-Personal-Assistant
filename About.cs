<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Vision.Core;

namespace MARK
{
    partial class About : Form
    {
        Vision.Core.Main MK_MAIN = new Vision.Core.Main();
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

        private void About_Load(object sender, EventArgs e)
        {
            label15.Text = "Copyright © " + "2018 - " + MK_MAIN.getYear() + " Dewnith Fernando. All rights reserved.";
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Vision.Core;

namespace MARK
{
    partial class About : Form
    {
        Vision.Core.Main MK_MAIN = new Vision.Core.Main();
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

        private void About_Load(object sender, EventArgs e)
        {
            label15.Text = "Copyright © " + "2018 - " + MK_MAIN.getYear() + " Dewnith Fernando. All rights reserved.";
        }
    }
}
>>>>>>> 710ed28d91dd6f2bae8186008a9e446b1f8e94e8
