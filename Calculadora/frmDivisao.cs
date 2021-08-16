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
    public partial class frmDivisao : Form
    {
        public frmDivisao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
                MessageBox.Show("Insira os números");
            else
            {
                int N1 = int.Parse(txtNumero1.Text);
                int N2 = int.Parse(txtNumero2.Text);

                int result = N1 / N2;
                lblResultado.Text = result.ToString();
            }
        }

        private void frmDivisao_Load(object sender, EventArgs e)
        {

        }

    }
}
