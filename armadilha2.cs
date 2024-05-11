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
    public partial class armadilha2 : Form
    {
        int vidas = 0;
        public armadilha2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            MessageBox.Show("Voce conseguiu sair da armadilha");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vidas = vidas - 1;
            MessageBox.Show("Voce morreu!");
            frmMenu frmMenu = new frmMenu();

            this.Hide();

            frmMenu.Closed += (object s, EventArgs ev) => this.Show();

            frmMenu.Show();
        }
    }
}
