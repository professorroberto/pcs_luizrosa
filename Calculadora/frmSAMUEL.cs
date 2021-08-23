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
    public partial class frmSAMUEL : Form
    {
        public frmSAMUEL()
        {
            InitializeComponent();
        }

        private void frmSAMUEL_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(Num1.Text);
            int n2 = int.Parse(Num2.Text);
            int n3 = int.Parse(Num3.Text);
            int result = n1 - n2 - n3;
            label4.Text = result.ToString;

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
