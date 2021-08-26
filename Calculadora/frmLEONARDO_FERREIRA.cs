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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text) + int.Parse(txtNumero3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(int.Parse(txtNumero1.Text) - int.Parse(txtNumero2.Text) - int.Parse(txtNumero3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumero1.Text) > int.Parse(txtNumero2.Text))
            {
                if (int.Parse(txtNumero1.Text) > int.Parse(txtNumero3.Text))
                {
                    MessageBox.Show("O Numero1");
                }
                else
                    MessageBox.Show("O Numero3 é maior");
            }
            else if (int.Parse(txtNumero2.Text) > int.Parse(txtNumero3.Text))
            {
                MessageBox.Show("O Numero2 é maior");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNumero1.Text) < int.Parse(txtNumero2.Text))
            {
                if (int.Parse(txtNumero1.Text) < int.Parse(txtNumero3.Text))
                {
                    MessageBox.Show("O Numero 1 é menor");
                }
                else
                    MessageBox.Show("O Numero3 é menor");
            }
            else if (int.Parse(txtNumero2.Text) < int.Parse(txtNumero3.Text))
            {
                MessageBox.Show("O Numero2 é menor");

            }
        }
    }
}
