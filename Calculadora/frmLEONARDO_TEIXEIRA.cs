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
    public partial class frmLEONARDO_TEIXEIRA : Form
    {
        public frmLEONARDO_TEIXEIRA()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtNumero1.Text);
            int N2 = int.Parse(txtNumero2.Text);
            int N3 = int.Parse(txtNumero3.Text);

            int result = N1 * N2 * N3 ;
            lblResultado.Text = result.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtNumero1.Text);
            int N2 = int.Parse(txtNumero2.Text);
            int N3 = int.Parse(txtNumero3.Text);

            int result = N1 + N2 + N3;
            lblResultado.Text = result.ToString();
        }
    }
}
