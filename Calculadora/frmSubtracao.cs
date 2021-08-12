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
        double resul = 0;
        public frmSubtracao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            double valor1 = double.Parse(txtNumero1.Text);
            double valor2 = double.Parse(txtNumero2.Text);

            resul = valor1 - valor2;
            lblResultado.Text = "Resultado: " + resul.ToString();
        }
    }
}
