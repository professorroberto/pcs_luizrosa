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
    public partial class frmMATHEUS : Form
    {
        public frmMATHEUS()
        {
            InitializeComponent();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {

            int res;

            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRes.Text = res.ToString();
            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRes.Text = res.ToString();

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int res;
            res = int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text);

            lblRes.Text = res.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

        }
    }
}
