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
    public partial class frmENZO : Form
    {
        public frmENZO()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Convert.ToString(int.Parse(txtN1.Text) * int.Parse(txtN2.Text) * int.Parse(txtN3.Text));
        }

       
    }
}
