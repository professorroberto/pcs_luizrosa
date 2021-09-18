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
    public partial class frmMATHEUS : Form
    {
        public frmMATHEUS()
        {
            InitializeComponent();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int Res = n1 - n2 - n3;
            string result = Res.ToString();

            lblRes.Text = result;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int Res = n1 * n2 * n3;
            string result = Res.ToString();

            lblRes.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int Res = n1 + n2 + n3;
            string result = Res.ToString();

            lblRes.Text = result;
        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtN3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int menor;

            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else
            {
                if (n2 < n1 && n2 < n3)
                {
                    menor = n2;
                }
                else
                {
                    menor = n3;
                }
            }
            lblRes.Text = menor.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            int n3 = int.Parse(txtN3.Text);
            int menor;

            if (n1 > n2 && n1 > n3)
            {
                menor = n1;
            }
            else
            {
                if (n2 > n1 && n2 > n3)
                {
                    menor = n2;
                }
                else
                {
                    menor = n3;
                }
            }
            lblRes.Text = menor.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
