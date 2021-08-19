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
    public partial class frmBRUNO : Form
    {
        public frmBRUNO()
        {
            InitializeComponent();
        }

        private void frmBRUNO_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);

                int result = N1 * N2;
                lblresultado.Text = result.ToString();
            }
        }
    }
}
