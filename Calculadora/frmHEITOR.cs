//Heitor Freitas - 2200012-8

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
    public partial class frmHEITOR : Form
    {
        public frmHEITOR()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text) * int.Parse(textBox3.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text));
        }
    }
}
