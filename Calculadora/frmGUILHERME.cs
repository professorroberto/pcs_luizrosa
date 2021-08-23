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
    public partial class frmGUILHERME : Form
    {
        public frmGUILHERME()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 * mn2 * mn3);
            label4.Text = "Resultado: " + resultado.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 + mn2 + mn3);
            label4.Text = "Resultado: " + resultado.ToString();
        }

        private void frmGUILHERME_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resultado;

            int mn1 = Convert.ToInt32(txtn1.Text);
            int mn2 = Convert.ToInt32(txtn2.Text);
            int mn3 = Convert.ToInt32(txtn3.Text);

            resultado = Convert.ToString(mn1 - mn2 - mn3);
            label4.Text = "Resultado: " + resultado.ToString();
        }
    }
}
