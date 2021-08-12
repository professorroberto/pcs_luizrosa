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
    //Leozao códigos - 2200037-1
    //Luis Felipe - 2200032-2
    public partial class frmAdicao : Form
    {
        double resul = 0;
        public frmAdicao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            double valor1 = double.Parse(txtNumero1.Text);
            double valor2 = double.Parse(txtNumero2.Text);

            resul = valor1 + valor2;
            lblResultado.Text = "Resultado: " + resul.ToString();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
