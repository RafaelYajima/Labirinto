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
            MessageBox.Show("Voce caio em uma armadilha!");
        }

        private void armadilha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce caio em uma armadilha!");
        }
    }
}
