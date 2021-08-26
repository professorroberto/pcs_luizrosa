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
    public partial class frmTIAGO : Form
    {
        public frmTIAGO()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 * n2 * n3;
            lblResultado.Text = resultado.ToString();

            MessageBox.Show ("Parabens, voce acaba de executar a operaçao (mutiplicar)com sucesso ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operaçao é:"+ lblResultado);
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 + n2 + n3;
            lblResultado.Text = resultado.ToString();

            MessageBox.Show ( "Parabens, voce acaba de executar a operaçao (Somar)com sucesso ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operaçao é:"+ lblResultado); 
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int n3;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            n3 = int.Parse(txtNum3.Text);

            int resultado;
            resultado = n1 - n2 - n3;
            lblResultado.Text = resultado.ToString();

            MessageBox.Show ("Parabens, voce acaba de executar a operaçao (Subtrair)com sucesso ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operaçao é:"+ lblResultado);
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum1.Text);

            if (n1 > n2 && n1 > n3)
                lblResultado.Text = txtNum1.Text;
            else
                if (n2 > n3)
                    lblResultado.Text = n2.ToString();
                else
                    lblResultado.Text = n3.ToString();

            MessageBox.Show ( "Parabens, voce acaba de executar a operaçao (Maior)com sucesso ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operaçao é:"+ lblResultado);
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum1.Text);

            if (n1 < n2 && n1 < n3)
                lblResultado.Text = txtNum1.Text;
            else
                if (n2 < n3)
                    lblResultado.Text = n2.ToString();
                else
                    lblResultado.Text = n3.ToString();

            MessageBox.Show ("Parabens, voce acaba de executar a operaçao (Menor)com sucesso ficamos muito felizes por utilizar os nossos sistemas! Conte sempre conosco! E o resultado da sua operaçao é:"+ lblResultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtNum3.Text = "";
            lblResultado.Text = "";
        }


    }
}
