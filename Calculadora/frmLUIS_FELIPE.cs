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
    public partial class frmLUIS_FELIPE : Form
    {
        public frmLUIS_FELIPE()
        {
            InitializeComponent();
            //2200032-2
            //2200032-2
            //2200032-2
            //2200032-2
        }

        private void frmLUIS_FELIPE_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int numero3;

            numero1 = int.Parse(num1.Text);
            numero2 = int.Parse(num2.Text);
            numero3 = int.Parse(num3.Text);

            lblres.Text = (numero1 + numero2 + numero3).ToString();
        }

        private void btnmult_Click(object sender, EventArgs e)
        {

            int numero1;
            int numero2;
            int numero3;

            numero1 = int.Parse(num1.Text);
            numero2 = int.Parse(num2.Text);
            numero3 = int.Parse(num3.Text);

            lblres.Text = (numero1 * numero2 * numero3).ToString();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;
            int numero3;

            numero1 = int.Parse(num1.Text);
            numero2 = int.Parse(num2.Text);
            numero3 = int.Parse(num3.Text);

            lblres.Text = (numero1 - numero2 - numero3).ToString();
        }

        private void txtMaior_Click(object sender, EventArgs e)
        {
            
        }
    }
}
