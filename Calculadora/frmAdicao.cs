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
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);
            
            int resultado = numero1 + numero2;

            lblResultado.Text = resultado.ToString();
        }
    }
}
