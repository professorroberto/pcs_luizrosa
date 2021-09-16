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
    public partial class frmJONAS : Form
    {
        public frmJONAS()
        {
            InitializeComponent();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {


            if (txt1.Text == "" && txt2.Text == "" && txt3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                int N1 = int.Parse(txt1.Text);
                int N2 = int.Parse(txt2.Text);
                int N3 = int.Parse(txt3.Text);
                int result = N1 - N2 - N3;
                lblres.Text = result.ToString();
            }

        }

        private void frmJONAS_Load(object sender, EventArgs e)
        {

        }

        private void btnvezes_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" && txt2.Text == "" && txt3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                int N1 = int.Parse(txt1.Text);
                int N2 = int.Parse(txt2.Text);
                int N3 = int.Parse(txt3.Text);
                int result = N1 * N2 * N3;
                lblres.Text = result.ToString();
            }
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "" && txt2.Text == "" && txt3.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                int N1 = int.Parse(txt1.Text);
                int N2 = int.Parse(txt2.Text);
                int N3 = int.Parse(txt3.Text);
                int result = N1 + N2 + N3;
                lblres.Text = result.ToString();
            }
        }

        private void btnmenor_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txt1.Text),B = Convert.ToInt32(txt2.Text),C = Convert.ToInt32(txt3.Text); 

            int menor = A;
            if(menor > B)
            {
                  menor = B;
            }
            if(menor > C)
            {
                 menor = C;
                 
           }
            lblres.Text = menor.ToString();
        }

        private void btnmaior_Click(object sender, EventArgs e)
        {
            int A = Convert.ToInt32(txt1.Text), B = Convert.ToInt32(txt2.Text), C = Convert.ToInt32(txt3.Text);

            int maior = A;
            if (maior < B)
            {
                maior = B;
            }
            if (maior < C)
            {
                maior = C;

            }
            lblres.Text = maior.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            lblres.Text = "";
        }
    }
}

