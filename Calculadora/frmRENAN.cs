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
    public partial class frmRENAN : Form
    {
        int res;
        //RA: 2200060-6
        public frmRENAN()
        {
            InitializeComponent();
        }
        private void frmRENAN_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
        }
        private void btnSOMA_Click(object sender, EventArgs e)
        {
            int res;
            res = int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
        }
        private void lblRES_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int res;
            res = int.Parse(txtN1.Text) - int.Parse(txtN2.Text) - int.Parse(txtN3.Text);
            lblRES.Text = res.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtN1.Text) > int.Parse(txtN2.Text) && int.Parse(txtN1.Text) > int.Parse(txtN3.Text))
                MessageBox.Show("NUMERO 1 É O MAIOR");
            else if (int.Parse(txtN2.Text) > int.Parse(txtN3.Text) && int.Parse(txtN2.Text) > int.Parse(txtN1.Text))
                MessageBox.Show("NUMERO 2 É O MAIOR");
            else
                MessageBox.Show("NUMERO 3 É O MAIOR");
            
  
            
        }
    }
}
