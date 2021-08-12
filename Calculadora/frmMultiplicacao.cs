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

        double resultado = 0;
        private void btnResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click_1(object sender, EventArgs e)
        {
            double mN1 = double.Parse(txtNumero1.Text);
            double mN2 = double.Parse(txtNumero2.Text);

            resultado = mN1 * mN2;
            lblResultado.Text = "Resultado: " + resultado.ToString();
        }
    }
}
