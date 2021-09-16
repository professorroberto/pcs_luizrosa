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
    public partial class frmJONAS : Form
    {
        public frmJONAS()
        {
            InitializeComponent();
        }

        private void btnmenos_Click(object sender, EventArgs e)
        {
            

            if (txt1.Text == "" && txt2.Text == "" && txt3.Text == "")
                {
                MessageBox.Show("Preencha todos os campos");
                }
            else
            {
                int N1 = int.Parse(txt1.Text);
                int N2 = int.Parse(txt2.Text);
                int N3 = int.Parse(txt3.Text);
                int result = N1 - N2 - N3;
                lblres.Text = result.ToString();
            }
              
       }

        private void frmJONAS_Load(object sender, EventArgs e)
        {
        
        }
    }
}

