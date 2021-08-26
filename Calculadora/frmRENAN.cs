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
    public partial class frmRENAN : Form
    {
        int res;
        //RA: 2200060-6
        public frmRENAN()
        {
            InitializeComponent();
        }
        private void frmRENAN_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblRES.Text);
        }
        private void btnSOMA_Click(object sender, EventArgs e)
        {
            int res;
            res = int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblRES.Text);
        }
        private void lblRES_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int res;
            res = int.Parse(txtN1.Text) - int.Parse(txtN2.Text) - int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
            MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é  " + lblRES.Text);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtN1.Text) > int.Parse(txtN2.Text) && int.Parse(txtN1.Text) > int.Parse(txtN3.Text))
            {
                MessageBox.Show("NUMERO 1 É O MAIOR");
                MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 1 ");
            }
            else if (int.Parse(txtN2.Text) > int.Parse(txtN3.Text) && int.Parse(txtN2.Text) > int.Parse(txtN1.Text))
            {
                MessageBox.Show("NUMERO 2 É O MAIOR");
                MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 2");
            }
            else
            {
                MessageBox.Show("NUMERO 3 É O MAIOR");
                MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 3");

                MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é ");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
                     if (int.Parse(txtN1.Text) < int.Parse(txtN2.Text) && int.Parse(txtN1.Text) < int.Parse(txtN3.Text))
                     {
                MessageBox.Show("NUMERO 1 É O MENOR");
                         MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 1 É MENOS");
                     }
            else if (int.Parse(txtN2.Text) < int.Parse(txtN3.Text) && int.Parse(txtN2.Text) < int.Parse(txtN1.Text))
                     {
                         MessageBox.Show("NUMERO 2 É O MENOR");
                                             MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 2 É MENOr");
            }
            else
                     {
                MessageBox.Show("NUMERO 3 É O MENOR");
                                     MessageBox.Show("Parabéns, você acaba de executar a operação de MAIOR com sucesso! Ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco! E o resultado da sua operação é 3 É MENOr");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            lblRES.Text="";
        }

        }
    }

