using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class mdiCalculadora : Form
    {
        public mdiCalculadora()
        {
            InitializeComponent();
        }

        private void adiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdicao frm = new frmAdicao();
            frm.Show();
        }

        private void mdiCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void subtraaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDivisao frm2 = new frmDivisao();
            frm2.Show();
        }

        private void multiplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiplicacao frm3 = new frmMultiplicacao();
            frm3.Show();
        }

        private void divisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubtracao frm4 = new frmSubtracao();
            frm4.Show();
        }
    }
}
