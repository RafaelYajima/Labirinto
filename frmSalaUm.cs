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
    public partial class frmSalaUm : Form
    {
        public frmSalaUm()
        {
            InitializeComponent();
        }

        private void btnSala2_Click(object sender, EventArgs e)
        {
            frmSalaDois frmSalaDois = new frmSalaDois();

            this.Hide();

            frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaDois.Show();
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
            armadilha1 armadilha1 = new armadilha1();

            this.Hide();

            armadilha1.Closed += (object s, EventArgs ev) => this.Show();

            armadilha1.Show();
        }
    }
}
