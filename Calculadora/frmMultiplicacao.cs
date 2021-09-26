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
        public frmMultiplicacao()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if ((txtNumero1.Text != null) && (txtNumero2.Text != null))
            {
                int var1 = Convert.ToInt32(txtNumero1.Text);
                int var2 = Convert.ToInt32(txtNumero2.Text);
                label3.Text = Convert.ToString(var1 * var2);
            }
            else
            {
                label3.Text = "CAMPOS VAZIOS!";
            }
        }

        private void frmMultiplicacao_Load(object sender, EventArgs e)
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
        }
    }
}
