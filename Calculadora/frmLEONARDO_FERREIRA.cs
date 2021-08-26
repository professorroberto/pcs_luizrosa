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
    public partial class frmLEONARDO_FERREIRA : Form
    {
        public frmLEONARDO_FERREIRA()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(int.Parse(txtNumero1.Text) * int.Parse(txtNumero2.Text) * int.Parse(txtNumero3.Text));
            MessageBox.Show("Parabéns, você acaba de executar a operação de Multiplicação com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é:" + label5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text) + int.Parse(txtNumero3.Text));
            MessageBox.Show("Parabéns, você acaba de executar a operação de Soma com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é:" + label5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(int.Parse(txtNumero1.Text) - int.Parse(txtNumero2.Text) - int.Parse(txtNumero3.Text));
            MessageBox.Show("Parabéns, você acaba de executar a operação de Subtração com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operação é:" + label5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumero1.Text) > int.Parse(txtNumero2.Text))
            {
                if (int.Parse(txtNumero1.Text) > int.Parse(txtNumero3.Text))
                {
                    MessageBox.Show("Parabéns, você acaba de executar a operação Maior com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O Numero 1 é maior");
                }
                else
                    MessageBox.Show("Parabéns, você acaba de executar a operação Maior com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O Numero3 é maior");
            }
            else if (int.Parse(txtNumero2.Text) > int.Parse(txtNumero3.Text))
            {
                MessageBox.Show("Parabéns, você acaba de executar a operação Maior com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O Numero2 é maior");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumero2.Text) > int.Parse(txtNumero1.Text))
            {
                if (int.Parse(txtNumero3.Text) > int.Parse(txtNumero1.Text))
                {
                    MessageBox.Show("Parabéns, você acaba de executar a operação Menor com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O Numero 1 é menor");
                }
                else
                    MessageBox.Show("Parabéns, você acaba de executar a operação Menor com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O Numero3 é menor");
            }
            else if (int.Parse(txtNumero3.Text) > int.Parse(txtNumero2.Text))
            {
                MessageBox.Show("Parabéns, você acaba de executar a operação Menor com sucesso! Ficamos muito felizes por utilizar os nossos sistemas! Conte sempre consco! E o resultado da sua operação é O numero 2 é maior");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtNumero3.Text = "";
            label5.Text = "";
        }
    }
}
