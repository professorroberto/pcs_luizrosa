﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmGUILHERME : Form
    {
        public frmGUILHERME()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 * mn2 * mn3);
            label4.Text = "Resultado: " + resultado.ToString();

            MessageBox.Show("Parabens, voce acaba de executar a operação Multiplicar com sucesso! ficamos muito felizes por utilizar os nossos sistemas! conte sempre conosco! e o resultado da sua operação é" + resultado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 + mn2 + mn3);
            label4.Text = "Resultado: " + resultado.ToString();

            MessageBox.Show ("Parabens, voce acaba de executar a operação Somar com sucesso! ficamos muito felizes por utilizar os nossos sistemas! conte sempre conosco! e o resultado da sua operação é" + resultado);
        }

        private void frmGUILHERME_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 - mn2 - mn3);
            label4.Text = "Resultado: " + resultado.ToString();

            MessageBox.Show("Parabens, voce acaba de executar a operação SUbtrair com sucesso! ficamos muito felizes por utilizar os nossos sistemas! conte sempre conosco! e o resultado da sua operação é" + resultado);
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int n3 = Convert.ToInt32(txtn3.Text);

            if (n1 > n2)
                label4.Text = "Maior Numero: Numero 1";
            else if (n2 > n3)
            {
                label4.Text = "Maior Numero: Numero 2";
            }
            else if (n3 > n2)
            {
                label4.Text = "Maior Numero: Numero 3";
            }
            else if (n3 > n1)
            {
                label4.Text = "Maior Numero: Numero 3";
            }
            else if (n2 > n1)
            {
                label4.Text = "Maior Numero: Numero 2";
            }
            else if (n1 > n3)
            {
                label4.Text = "Maior Numero: Numero 1";
            }
            MessageBox.Show("Parabens, voce acaba de executar a operação Maior com sucesso! ficamos muito felizes por utilizar os nossos sistemas! conte sempre conosco! e o resultado da sua operação é");
        }

        private void txtn3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtn1.Text);
            int n2 = Convert.ToInt32(txtn2.Text);
            int n3 = Convert.ToInt32(txtn3.Text);

            if (n1 < n2)
                label4.Text = "Maior Numero: Numero 1";
            else if (n2 < n3)
            {
                label4.Text = "Maior Numero: Numero 2";
            }
            else if (n3 < n2)
            {
                label4.Text = "Maior Numero: Numero 3";
            }
            else if (n3 < n1)
            {
                label4.Text = "Maior Numero: Numero 3";
            }
            else if (n2 < n1)
            {
                label4.Text = "Maior Numero: Numero 2";
            }
            else if (n1 < n3)
            {
                label4.Text = "Maior Numero: Numero 1";
            }
            MessageBox.Show("Parabens, voce acaba de executar a operação Menor com sucesso! ficamos muito felizes por utilizar os nossos sistemas! conte sempre conosco! e o resultado da sua operação é");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtn1.Text = null;
            txtn2.Text = null;
            txtn3.Text = null;
            label4.Text = "RESULTADO";
        }
    }
}
