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

        private void mnuAdicao_Click(object sender, EventArgs e)
        {
            frmAdicao frm = new frmAdicao();
            frm.Show();
        }

        private void mnuSubtracao_Click(object sender, EventArgs e)
        {
            frmSubtracao frm = new frmSubtracao();
            frm.Show();
        }
    }
}
