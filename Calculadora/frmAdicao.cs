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
            int resultado;
            int valor1;
            int valor2;
            valor1 = int.Parse(txtNumero1.Text);
            valor2 = int.Parse(txtNumero2.Text);
            resultado = valor1 + valor2;
        }
    }
}
