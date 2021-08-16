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
    public partial class frmSubtracao : Form
    {
        public frmSubtracao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Double var1 = 0, var2 = 0, res = 0;
            var1 = Double.Parse(txtNumero1.Text);
            var2 = Double.Parse(txtNumero2.Text);
            res = var1 - var2;
            MessageBox.Show("resultado:" + res);
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
