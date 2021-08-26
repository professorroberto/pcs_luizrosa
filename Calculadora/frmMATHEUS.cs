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

        private void btnMult_Click(object sender, EventArgs e)
        {

            int res;

            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRes.Text = res.ToString();
            MessageBox.Show("Parabens, você acaba de executar a operação multiplicar com sucesso ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco!E o resultado da sua operação é" + lblRes.Text);


        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            int res;
            res = int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text);

            lblRes.Text = res.ToString();
            MessageBox.Show("Parabens, você acaba de executar a operação somar com sucesso ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco!E o resultado da sua operação é" + lblRes.Text);
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
                        int res;
            res = int.Parse(txtN1.Text) - int.Parse(txtN2.Text) - int.Parse(txtN3.Text);

            lblRes.Text = res.ToString();
            MessageBox.Show("Parabens, você acaba de executar a operação subtrair com sucesso ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco!E o resultado da sua operação é" + lblRes.Text);
        }



        private void frmMATHEUS_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (int.Parse(txtN1.Text) > int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN1.Text) > int.Parse(txtN3.Text))
                {
                    lblRes.Text = txtN1.Text;
                }
            }
            if (int.Parse(txtN3.Text) > int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN3.Text) > int.Parse(txtN1.Text))
                {
                    lblRes.Text = txtN3.Text;
                }
            }
            if (int.Parse(txtN2.Text) > int.Parse(txtN1.Text))
            {
                if (int.Parse(txtN2.Text) > int.Parse(txtN3.Text))
                {
                    lblRes.Text = txtN2.Text;
                }
            }
            MessageBox.Show("Parabens, você acaba de executar a operação maior com sucesso ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco!E o resultado da sua operação é" + lblRes.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtN1.Text) < int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN1.Text) < int.Parse(txtN3.Text))
                {
                    lblRes.Text = txtN1.Text;
                }
            }
            if (int.Parse(txtN3.Text) < int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN3.Text) < int.Parse(txtN1.Text))
                {
                    lblRes.Text = txtN3.Text;
                }
            }
            if (int.Parse(txtN2.Text) < int.Parse(txtN1.Text))
            {
                if (int.Parse(txtN2.Text) < int.Parse(txtN3.Text))
                {
                    lblRes.Text = txtN2.Text;
                }
                MessageBox.Show("Parabens, você acaba de executar a operação menor com sucesso ficamos muito felizes por utilizar nossos sistemas! Conte sempre conosco!E o resultado da sua operação é" + lblRes.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            lblRes.Text = "";
        }


    }
}
