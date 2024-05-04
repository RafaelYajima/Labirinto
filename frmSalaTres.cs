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
    public partial class frmSalaTres : Form
    {
        public frmSalaTres()
        {
            InitializeComponent();
        }

        private void btnSala4_Click(object sender, EventArgs e)
        {
            frmSalaQuatro frmSalaQuatro = new frmSalaQuatro();

            this.Hide();

            frmSalaQuatro.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaQuatro.Show();
        }

        private void armadilha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce caio em uma armadilha!");
        }

        private void armadilha2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Voce caio em uma armadilha!");
        }
    }
}
