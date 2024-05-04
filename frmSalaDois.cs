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
    public partial class frmSalaDois : Form
    {
        public frmSalaDois()
        {
            InitializeComponent();
        }
        private void btnSala3_Click(object sender, EventArgs e)
        {
            frmSalaTres frmSalaTres = new frmSalaTres();

            this.Hide();

            frmSalaTres.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaTres.Show();
        }

        private void armadilha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce caio em uma armadilha!");
        }

    }
}
