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
    public partial class frmKAUA : Form
    {
        public frmKAUA()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            int result = n1 * n2 * n3;

            lblResult.Text = result.ToString();  
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);

            int result = n1 + n2 + n3;

            lblResult.Text = result.ToString(); 
        }
    }
}
