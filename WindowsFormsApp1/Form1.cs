﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practices.Form1 frm = new Practices.Form1();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
