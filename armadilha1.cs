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
    public partial class armadilha1 : Form
    {
        int vidas = 2;
        public armadilha1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            if (vidas > 0)
            {
                MessageBox.Show("Voce perdeu uma vida, so tem mais 1 chance");
            }
            else
            {
                MessageBox.Show("Voce morreu!");
                frmMenu frmMenu = new frmMenu();

                this.Hide();

                frmMenu.Closed += (object s, EventArgs ev) => this.Show();

                frmMenu.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            MessageBox.Show("Voce conseguiu sair da armadilha");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            if (vidas > 0)
            {
                MessageBox.Show("Voce perdeu uma vida, so tem mais 1 chance");
            }
            else
            {
                MessageBox.Show("Voce morreu!");
                frmMenu frmMenu = new frmMenu();

                this.Hide();

                frmMenu.Closed += (object s, EventArgs ev) => this.Show();

                frmMenu.Show();
            }
        }
    }
}
