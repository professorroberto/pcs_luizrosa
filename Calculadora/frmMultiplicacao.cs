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

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int Num1 = int.Parse(txtNumero1.Text);
                int Num2 = int.Parse(txtNumero2.Text);

                int resultado = Num1 * Num2;
                lblResultado.Text = resultado.ToString();
            }
        }
        
    }
}
