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
            string num1;
                string num2;
                    string  num3;
                    string  resultado;
                        num1 = textBox1.Text;
                            num2 = textBox2.Text;
                            num3 = textBox3.Text;
                            resultado =  num1 * num2 * num3;
                            label4.Text = resultado;

        }
    }
}
