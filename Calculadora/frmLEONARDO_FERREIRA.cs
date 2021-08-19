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
    public partial class frmLEONARDO_FERREIRA : Form
    {
        public frmLEONARDO_FERREIRA()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(int.Parse(txtNumero1.Text) * int.Parse(txtNumero2.Text) * int.Parse(txtNumero3.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(int.Parse(txtNumero1.Text) + int.Parse(txtNumero2.Text) + int.Parse(txtNumero3.Text));
        }
    }
}
