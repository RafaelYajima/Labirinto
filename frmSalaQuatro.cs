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
    public partial class frmSalaQuatro : Form
    {
        public frmSalaQuatro()
        {
            InitializeComponent();
        }
        private void btnSala5_Click(object sender, EventArgs e)
        {
            frmSalaCinco frmSalaQuatro = new frmSalaCinco();

            this.Hide();

            frmSalaQuatro.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaQuatro.Show();
        }

        private void btnSala1_Click(object sender, EventArgs e)
        {
            frmSalaUm frmSalaUm = new frmSalaUm();

            this.Hide();

            frmSalaUm.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaUm.Show();
        }
        private void armadilha_Click(object sender, EventArgs e)
        {
            armadilha1 armadilha1 = new armadilha1();

            this.Hide();

            armadilha1.Closed += (object s, EventArgs ev) => this.Show();

            armadilha1.Show();
        }

    }
}
