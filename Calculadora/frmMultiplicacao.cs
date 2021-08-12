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
    public partial class frmMultiplicacao : Form
    {
        int res;
        public frmMultiplicacao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            res = int.Parse(txtNumero1.Text) * int.Parse(txtNumero2.Text);
            lblResultado.Text = res.ToString();
        }
    }
}
