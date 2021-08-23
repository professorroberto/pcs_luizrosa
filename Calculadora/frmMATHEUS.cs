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


        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            int res;
            res = int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text);

            lblRes.Text = res.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
                        int res;
            res = int.Parse(txtN1.Text) - int.Parse(txtN2.Text) - int.Parse(txtN3.Text);

            lblRes.Text = res.ToString();
        }

        private void frmMATHEUS_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int res;

            if (int.Parse(txtN1.Text) > int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN1.Text) > int.Parse(txtN3.Text))
                {
                    res = int.Parse(txtN1.Text);
                }
            }
            if (int.Parse(txtN3.Text) > int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN3.Text) > int.Parse(txtN1.Text))
                {
                    res = int.Parse(txtN3.Text);
                }
            }
            if (int.Parse(txtN2.Text) > int.Parse(txtN1.Text))
            {
                if (int.Parse(txtN2.Text) > int.Parse(txtN3.Text))
                {
                    res = int.Parse(txtN2.Text);
                }
            }
            lblRes = res;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}
