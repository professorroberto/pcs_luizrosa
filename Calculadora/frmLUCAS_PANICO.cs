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
    public partial class frmLUCAS_PANICO : Form
    {
        List<int> maior = new List<int>();
        public frmLUCAS_PANICO()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (txtNumero1.Text == "" || txtNumero2.Text == "" || txtNumero3.Text == "")
                MessageBox.Show("Parabéns, você acaba de executar a operaçao Multiplicar com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);
            else
            {
                int N1 = int.Parse(txtNumero1.Text);
                int N2 = int.Parse(txtNumero2.Text);
                int N3 = int.Parse(txtNumero3.Text);
                int result = N1 * N2 * N3;
                lblResultado.Text = result.ToString();

                MessageBox.Show("Parabéns, você acaba de executar a operaçao Multiplicar com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);

            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "" || txtNumero2.Text == "" || txtNumero3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtNumero1.Text);
                int N2 = int.Parse(txtNumero2.Text);
                int N3 = int.Parse(txtNumero3.Text);
                int result = N1 + N2 + N3;
                lblResultado.Text = result.ToString();
                MessageBox.Show("Parabéns, você acaba de executar a operaçao Somar com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            if (txtNumero1.Text == "" || txtNumero2.Text == "" || txtNumero3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(txtNumero1.Text);
                int N2 = int.Parse(txtNumero2.Text);
                int N3 = int.Parse(txtNumero3.Text);
                int result = N1 - N2 - N3;
                lblResultado.Text = result.ToString();
                MessageBox.Show("Parabéns, você acaba de executar a operaçao Subtrair com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtNumero1.Text);
            int N2 = int.Parse(txtNumero2.Text);
            int N3 = int.Parse(txtNumero3.Text);

            if (N1 > N2)
            {
                if (N1 > N3)
                {
                    lblResultado.Text = Convert.ToString(N1);
                } 
            }
            else
            if (N1 > N2)
            {
                if (N2 > N3)
                {
                    lblResultado.Text = Convert.ToString(N2);
                }
            }
            else
                if (N3 > N1)
                {
                    if (N3 > N2)
                    {
                        lblResultado.Text = Convert.ToString(N3);
                    }
                }

            MessageBox.Show("Parabéns, você acaba de executar a operaçao Maior com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(txtNumero1.Text);
            int N2 = int.Parse(txtNumero2.Text);
            int N3 = int.Parse(txtNumero3.Text);

            if (N1 < N2)
            {
                if (N1 < N3)
                {
                    lblResultado.Text = Convert.ToString(N1);
                }
            }
            else
                if (N1 < N2)
                {
                    if (N2 < N3)
                    {
                        lblResultado.Text = Convert.ToString(N2);
                    }
                }
                else
                    if (N3 < N1)
                    {
                        if (N3 < N2)
                        {
                            lblResultado.Text = Convert.ToString(N3);
                        }
                    }
            MessageBox.Show("Parabéns, você acaba de executar a operaçao Menor com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado de sua operação é " + lblResultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
             txtNumero2.Text = "";
            txtNumero3.Text = "";
            lblResultado.Text = "";
        }

    
    }
}
