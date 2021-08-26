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
    public partial class frmKAUA : Form
    {
        public frmKAUA()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            int result = n1 * n2 * n3;

            lblResult.Text = result.ToString();  
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            int result = n1 + n2 + n3;

            lblResult.Text = result.ToString(); 
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            int result = n1 - n2 - n3;

            lblResult.Text = result.ToString(); 
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            if (n1 > n2 || n1 > n3)
                MessageBox.Show("o 1° numero é o maior");
            else if (n2 > n1 || n2 > n3)
                MessageBox.Show("O 2° numero é o maior");
            else if (n3 > n1 || n3 > n2)
                MessageBox.Show("o 3° numero é o maior"); 
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            if (n1 < n2 || n1 < n3)
                MessageBox.Show("o 1° numero é o menor");
            else if (n2 < n1 || n2 < n3)
                MessageBox.Show("O 2° numero é o menor");
            else if (n3 < n1 || n3 < n2)
                MessageBox.Show("o 3° numero é o menor"); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            lblResult.Text = "";
        }
    }
}
