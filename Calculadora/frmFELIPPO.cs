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
    public partial class frmFELIPPO : Form
    {
        public frmFELIPPO()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) + double.Parse(txtnum2.Text) + double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de ADIÇÃO com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblresult.Text);
            
            
        }

        
           
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) * double.Parse(txtnum2.Text) * double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de MULTIPLICAÇÃO com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblresult.Text);
        }

        private void Btncalc_Click_1(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) - double.Parse(txtnum2.Text) - double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de SUBTRAIR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblresult.Text);
        }

        private void frmFELIPPO_Load(object sender, EventArgs e)
        {
            lblresult.BackColor = Color.DarkGreen;
            button2.BackColor = Color.LightSteelBlue;
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtnum1.Text) > int.Parse(txtnum2.Text))
            {
                if (int.Parse(txtnum1.Text) > int.Parse(txtnum3.Text))
                    MessageBox.Show("Número 1 é o maior");
                else
                    MessageBox.Show("Número 3 é o maior");
            }
            else if (int.Parse(txtnum2.Text) > int.Parse(txtnum3.Text))
            {
                MessageBox.Show("Número 2 é o maior");
            }
            else MessageBox.Show("Numero 3 é o maior");
            MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblresult.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtnum1.Text) < int.Parse(txtnum2.Text))
            {
                if (int.Parse(txtnum1.Text) < int.Parse(txtnum3.Text))
                    MessageBox.Show("Número 1 é o menor");
                else
                    MessageBox.Show("Número 3 é o menor");
            }
            else if (int.Parse(txtnum2.Text) < int.Parse(txtnum3.Text))
            {
                MessageBox.Show("Número 2 é o menor");
            }
            else MessageBox.Show("Numero 3 é o menor");
            MessageBox.Show("Parabéns, você acaba de executar a operação de MENOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblresult.Text);

            

        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            lblresult.Text = "";
        }
    }
}
