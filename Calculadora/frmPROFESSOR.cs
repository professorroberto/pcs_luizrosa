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
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text) + int.Parse(txtNumero3.Text)).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (int.Parse(txtNumero1.Text) - int.Parse(txtNumero2.Text) - int.Parse(txtNumero3.Text)).ToString();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>() { int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text) };
            lblResultado.Text = numeros.Max().ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int>() { int.Parse(txtNumero1.Text), int.Parse(txtNumero2.Text), int.Parse(txtNumero3.Text) };
            lblResultado.Text = numeros.Min().ToString();
        }
    }
}
