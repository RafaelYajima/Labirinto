﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPortal frmPortal = new frmPortal();

            this.Hide();

            frmPortal.Closed += (object s, EventArgs ev) => this.Show();

            frmPortal.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
