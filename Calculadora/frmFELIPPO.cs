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
    public partial class frmFELIPPO : Form
    {
        public frmFELIPPO()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) + double.Parse(txtnum2.Text) + double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) * double.Parse(txtnum2.Text) * double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString();
        }

        private void Btncalc_Click_1(object sender, EventArgs e)
        {
            double res;
            res = double.Parse(txtnum1.Text) - double.Parse(txtnum2.Text) - double.Parse(txtnum3.Text);
            lblresult.Text = res.ToString(); 
        }

        private void frmFELIPPO_Load(object sender, EventArgs e)
        {
            lblresult.BackColor = Color.DarkGreen;
    }
}
