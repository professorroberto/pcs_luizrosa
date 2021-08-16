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
    public partial class frmAdicao : Form
    {
        public frmAdicao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtNumero1.Text);
                int N2 = int.Parse(txtNumero2.Text);

                int result = N1 + N2;
                lblResultado.Text = result.ToString();
            }


        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
