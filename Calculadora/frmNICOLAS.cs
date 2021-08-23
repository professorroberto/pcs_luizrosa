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


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int resultado = n1 + n2 + n3;
            label1.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            int n3 = int.Parse(textBox3.Text);
            int resultado = n1 - n2 - n3;
            label1.Text = resultado.ToString();
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
                    label1.Text = Convert.ToString (n1);
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
        }

        
    }
}
