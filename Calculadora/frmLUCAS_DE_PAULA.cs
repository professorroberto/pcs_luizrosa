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
    public partial class frmLUCAS_DE_PAULA : Form
    {
        public frmLUCAS_DE_PAULA()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             txt3.Text = Convert.ToString(Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt2.Text));s
        }
    }
}
