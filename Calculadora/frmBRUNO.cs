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
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 * N2 * N3;
                lblresultado.Text = result.ToString();
                MessageBox.Show("Parabéns, você acaba de executar a operação Multiplicação com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é" + MessageBox.Show("Parabéns, você acaba de executar a operação soma com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é 8" + lblresultado.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 - N2 - N3;
                lblresultado.Text = result.ToString();
                MessageBox.Show("Parabéns, você acaba de executar a operação Subtração com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é" + lblresultado.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 + N2 + N3;
                lblresultado.Text = result.ToString();
                MessageBox.Show("Parabéns, você acaba de executar a operação soma com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é 8");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(Numero1.Text) > int.Parse(Numero2.Text) && int.Parse(Numero1.Text) > int.Parse(Numero3.Text))
            MessageBox.Show("O numero 1 é o maior");
            else if (int.Parse(Numero2.Text) > int.Parse(Numero3.Text) && int.Parse(Numero2.Text) > int.Parse(Numero1.Text))
            MessageBox.Show("O numero 2 é o meior");
            else
            MessageBox.Show("O numero 3 é o maior");
            MessageBox.Show("Parabéns, você acaba de executar a operação Maior com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é" + lblresultado.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(Numero1.Text) < int.Parse(Numero2.Text) && int.Parse(Numero1.Text) < int.Parse(Numero3.Text))
                MessageBox.Show("O numero 1 é o menor");
            else if (int.Parse(Numero2.Text) < int.Parse(Numero3.Text) && int.Parse(Numero2.Text) < int.Parse(Numero1.Text))
                MessageBox.Show("O numero 2 é o menor");
            else
                MessageBox.Show("O numero 3 é o menor");
            MessageBox.Show("Parabéns, você acaba de executar a operação Menor com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco! e o resultado da sua operação é" + lblresultado.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Numero1.Text = "";
            Numero2.Text = "";
            Numero3.Text = "";
            lblresultado.Text = "";
            MessageBox.Show("Parabéns, você acaba de executar a operação Limpar com sucesso! ficamos muito felizes por utilizar os sistemas conte sempre conosco!");
        }
    }
}
