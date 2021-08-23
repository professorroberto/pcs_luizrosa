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
    public partial class frmBRUNO : Form
    {
        public frmBRUNO()
        {
            InitializeComponent();
        }

        private void frmBRUNO_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 * N2 * N3;
                lblresultado.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 - N2 - N3;
                lblresultado.Text = result.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Numero1.Text == "" || Numero2.Text == "" || Numero3.Text == "")
                MessageBox.Show("Preencha todos os campos");
            else
            {
                int N1 = int.Parse(Numero1.Text);
                int N2 = int.Parse(Numero2.Text);
                int N3 = int.Parse(Numero3.Text);

                int result = N1 + N2 + N3;
                lblresultado.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(Numero1.Text) > int.Parse(Numero2.Text) && int.Parse(Numero1.Text) > int.Parse(Numero3.Text))
                MessageBox.Show("O numero 1 é o maior");
            else if (int.Parse(Numero2.Text) > int.Parse(Numero3.Text) && int.Parse(Numero2.Text) > int.Parse(Numero1.Text))
                MessageBox.Show("O numero 2 é o meior");
            else
                MessageBox.Show("O numero 3 é o maior");
        }
    }
}
