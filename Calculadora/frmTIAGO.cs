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
    public partial class frmTIAGO : Form
    {
        public frmTIAGO()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 * n2 * n3;
            lblResultado.Text = resultado.ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 + n2 + n3;
            lblResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 - n2 - n3;
            lblResultado.Text = resultado.ToString();
        }

    }
}
