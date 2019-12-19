﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace MARK
{
    partial class MSG : Form
    {
        String UDB = "User.vidb";//Database File
        String kt = "";
        public MSG()
        {
            InitializeComponent();
        }

        private void MsgXR_Load(object sender, EventArgs e)
        {
            kt = File.ReadLines(@UDB).Skip(9).Take(1).First();
            title.Text = File.ReadLines(@UDB).Skip(10).Take(1).First();
            message.Text = File.ReadLines(@UDB).Skip(11).Take(1).First();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            MSGOK();
        }
        public void MSGOK()
        {
            if(kt == "ifthisdowntoshut311793513569") { Application.Exit(); }
            else { this.Close(); }
        }
    }
}
