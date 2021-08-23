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

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Convert.ToString(int.Parse(txtN1.Text) + int.Parse(txtN2.Text) + int.Parse(txtN3.Text));
        }

        private void frmENZO_Load(object sender, EventArgs e)
        {
            btnSomar.BackColor = Color.LightSteelBlue;
            btnSubtrair.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;

            lblresultado.BackColor = Color.DarkGreen;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblresultado.Text = Convert.ToString(int.Parse(txtN1.Text) - int.Parse(txtN2.Text) - int.Parse(txtN3.Text));
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtN1.Text) > int.Parse(txtN2.Text))
            {
                if (int.Parse(txtN1.Text) > int.Parse(txtN3.Text))
                {
                    MessageBox.Show("N1");
                }
                else
                    MessageBox.Show("N3");
            }
            else if (int.Parse(txtN2.Text) > int.Parse(txtN3.Text))
            {
                MessageBox.Show("N2");
            }
        }


    }
}
