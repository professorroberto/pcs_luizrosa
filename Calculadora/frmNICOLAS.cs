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
    public partial class frmNICOLAS : Form
    {
        public frmNICOLAS()
        {
            InitializeComponent();
        }

        private void frmNICOLAS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int resultado = n1 * n2 * n3;
            label1.Text = resultado.ToString();
            MessageBox.Show("parabens, voce acaba de executar a operação SUBTRAÇÃO com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é" + resultado);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int resultado = n1 + n2 + n3;
            label1.Text = resultado.ToString();
            MessageBox.Show("parabens, voce acaba de executar a operação SOMA com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é" + resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int resultado = n1 - n2 - n3;
            label1.Text = resultado.ToString();
            MessageBox.Show("parabens, voce acaba de executar a operação MULTIPLICAÇÃO com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é" + resultado);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    label1.Text = Convert.ToString(n1);
                }
            }
            else if (n2 > n1)
            {
                if (n2 > n3)
                {
                    label1.Text = Convert.ToString(n2);
                }
            }
            else if (n3 > n1)
            {
                if (n3 > n2)
                {
                    label1.Text = Convert.ToString(n3);
                }
            }
            MessageBox.Show("parabens, voce acaba de executar a operação MAIOR com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    label1.Text = Convert.ToString(n1);
                }
            }
            else if (n2 < n1)
            {
                if (n2 < n3)
                {
                    label1.Text = Convert.ToString(n2);
                }
            }
            else if (n3 < n1)
            {
                if (n3 < n2)
                {
                    label1.Text = Convert.ToString(n3);
                }
            }
            MessageBox.Show("parabens, voce acaba de executar a operação MENOR com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é");


        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
           textBox2.Text = " ";
            textBox3.Text = " ";
            label1.Text = " ";
            MessageBox.Show("parabens, voce acaba de executar a operação LIMPAR com sucesso! Ficamos muito felizes por ultilizar os nossos sistemas! conte sempre conosco! e o resultado da operação é");
        }
    }
}
