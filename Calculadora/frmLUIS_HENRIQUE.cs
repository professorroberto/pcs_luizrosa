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
                MessageBox.Show("Parabéns, você executou a operação subtracao com sucesso! O resultado é " + lblResposta.Text);
            }
        
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtn1.Text == "" && txtn2.Text == "" && txtn3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtn1.Text);
                int N2 = int.Parse(txtn2.Text);
                int n3 = int.Parse(txtn3.Text);
                int result = N1 * N2 * n3;
                lblResposta.Text = result.ToString();
                MessageBox.Show("Parabéns, você executou a operação multiplicacao com sucesso! O resultado é " + lblResposta.Text);
            }
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            if (txtn1.Text == "" && txtn2.Text == "" && txtn3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtn1.Text);
                int N2 = int.Parse(txtn2.Text);
                int n3 = int.Parse(txtn3.Text);
                int result = N1 + N2 + n3;
                lblResposta.Text = result.ToString();
                MessageBox.Show("Parabéns, você executou a operação soma com sucesso! O resultado é " + lblResposta.Text);
            }
        }

        private void botaoMenor_Click(object sender, EventArgs e)
        {
            int menor;
            menor =  Convert.ToInt32(txtn1.Text);
            if(menor > Convert.ToInt32(txtn2.Text))
            {
            menor =  Convert.ToInt32(txtn2.Text);
            }
            else if (menor > Convert.ToInt32(txtn3.Text))
            {
            menor =  Convert.ToInt32(txtn3.Text);
            }
            lblResposta.Text = menor.ToString();
        }

        private void botaoMaior_Click(object sender, EventArgs e)
        {
            int maior;
            maior = Convert.ToInt32(txtn1.Text);
            if (maior < Convert.ToInt32(txtn2.Text))
            {
                maior = Convert.ToInt32(txtn2.Text);
            }
            else if (maior < Convert.ToInt32(txtn3.Text))
            {
                maior = Convert.ToInt32(txtn3.Text);
            }
            lblResposta.Text = maior.ToString();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            txtn1.Text = null;
            txtn2.Text = null;
            txtn3.Text = null;
            lblResposta.Text = null;
        }

    }

}


