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

        private void btnMaior_Click(object sender, EventArgs e)
        {
            List<int> Listinha = new List<int>();

            Listinha.Add(int.Parse(txtN1.Text));
            Listinha.Add(int.Parse(txtN2.Text));
            Listinha.Add(int.Parse(txtN3.Text));

            MessageBox.Show( "" + Listinha.Max());
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            List<int> Listinha = new List<int>();

            Listinha.Add(int.Parse(txtN1.Text));
            Listinha.Add(int.Parse(txtN2.Text));
            Listinha.Add(int.Parse(txtN3.Text));

            MessageBox.Show("" + Listinha.Min());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();

            lblresultado.Text = "";
        }


    }
}
