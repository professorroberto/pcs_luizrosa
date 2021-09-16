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
    public partial class frmLUIS_HENRIQUE : Form
    {
        public frmLUIS_HENRIQUE()
        {
            InitializeComponent();
        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            if (txtn1.Text == "" &&  txtn2.Text == "" &&  txtn3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtn1.Text);
                int N2 = int.Parse(txtn2.Text);
                int n3 = int.Parse(txtn3.Text);
                int result = N1 - N2 - n3;
                lblResposta.Text = result.ToString();
            }
        
        }

    }

}


