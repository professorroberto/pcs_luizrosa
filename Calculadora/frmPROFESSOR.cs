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
    public partial class frmPROFESSOR : Form
    {
        public frmPROFESSOR()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (int.Parse(txtNumero1.Text) * int.Parse(txtNumero2.Text) * int.Parse(txtNumero3.Text)).ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de MULTIPLICAÇÃO com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é: " + lblResultado.Text);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text) + int.Parse(txtNumero3.Text)).ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de ADIÇÃO com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é: " + lblResultado.Text);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (int.Parse(txtNumero1.Text) - int.Parse(txtNumero2.Text) - int.Parse(txtNumero3.Text)).ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de SUBTRAÇÃO com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é: " + lblResultado.Text);
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>() { int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text) };
            lblResultado.Text = numeros.Max().ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de VERIFICAÇÃO DO MAIOR NÚMERO com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é: " + lblResultado.Text);
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>() { int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text) };
            lblResultado.Text = numeros.Min().ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de VERIFICAÇÃO DO MENOR NÚMERO com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é: " + lblResultado.Text);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            lblResultado.Text = "";
        }
    }
}
