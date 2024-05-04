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
    public partial class frmSalaFim : Form
    {
        public frmSalaFim()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mimic!");
            MessageBox.Show("Voce morreu!");

            frmMenu frmMenu = new frmMenu();

            this.Hide();

            frmMenu.Closed += (object s, EventArgs ev) => this.Show();

            frmMenu.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parabens voce achou o premio!");

            frmMenu frmMenu = new frmMenu();

            this.Hide();

            frmMenu.Closed += (object s, EventArgs ev) => this.Show();

            frmMenu.Show();
        }
    }
}
