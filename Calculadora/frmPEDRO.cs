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
    public partial class frmPEDRO : Form
    {
        public frmPEDRO()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;
            n1 = int.Parse(txtNumero1.Text);
            n2 = int.Parse(txtNumero2.Text);
            n3 = int.Parse(txtNumero3.Text);
            int resultado;
            resultado = n1 * n2 * n3;
            lblResultado.Text = resultado.ToString();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;
            n1 = int.Parse(txtNumero1.Text);
            n2 = int.Parse(txtNumero2.Text);
            n3 = int.Parse(txtNumero3.Text);
            int resultado;
            resultado = n1 + n2 + n3;
            lblResultado.Text = resultado.ToString();
        }

        private void btnSubtraçao_Click(object sender, EventArgs e)
        {

        }
    }
}
