﻿using System;
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
            lblRes.Text = Convert.ToString(Convert.ToDouble(txt1.Text) * Convert.ToDouble(txt2.Text) * Convert.ToDouble(txt1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblRes.Text = Convert.ToString(Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt1.Text));
        }



        private void button5_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txt1.Text) > Convert.ToDouble(txt2.Text) || Convert.ToDouble(txt1.Text) > Convert.ToDouble(txt3.Text));
            { MessageBox.Show("1Maior"); }
            if (Convert.ToDouble(txt2.Text) > Convert.ToDouble(txt1.Text) || Convert.ToDouble(txt2.Text) > Convert.ToDouble(txt3.Text));
            { MessageBox.Show("2Maior"); }
            if (Convert.ToDouble(txt3.Text) > Convert.ToDouble(txt2.Text) || Convert.ToDouble(txt3.Text) > Convert.ToDouble(txt1.Text));
            { MessageBox.Show("1Maior"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                List<int> Listinha = new List<int>();

                Listinha.Add(int.Parse(txt1.Text));
                Listinha.Add(int.Parse(txt2.Text));
                Listinha.Add(int.Parse(txt3.Text));

                MessageBox.Show("" + Listinha.Min());
            }
        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            lblRes.Text = "";
        }
    }
}
