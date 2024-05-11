using System;
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
    public partial class frmSalaCinco : Form
    {
        public frmSalaCinco()
        {
            InitializeComponent();
        }

        private void btnSala6_Click(object sender, EventArgs e)
        {
            frmSalaSeis frmSalaSeis = new frmSalaSeis();

            this.Hide();

            frmSalaSeis.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaSeis.Show();
        }

        private void armadilha2_Click(object sender, EventArgs e)
        {
            armadilha1 armadilha1 = new armadilha1();

            this.Hide();

            armadilha1.Closed += (object s, EventArgs ev) => this.Show();

            armadilha1.Show();
        }

        private void armadilha_Click(object sender, EventArgs e)
        {
            armadilha2 armadilha2 = new armadilha2();

            this.Hide();

            armadilha2.Closed += (object s, EventArgs ev) => this.Show();

            armadilha2.Show();
        }
    }
}
