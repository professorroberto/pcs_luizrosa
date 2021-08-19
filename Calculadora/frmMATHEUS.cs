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
        

<<<<<<< HEAD
            //res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            //lblRes.text = res.ToString();
=======
            res = int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text);
            lblRes.Text = res.ToString();
>>>>>>> 50adc3cff4e67e89ed18f2850db97c9f1b7359bf
        }
    }
}
