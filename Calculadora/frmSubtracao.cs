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
    public partial class frmSubtracao : Form
    {
        public frmSubtracao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            double resultado;
            if (txtNumero1.Text != "" | txtNumero2.Text != "")
            {
                resultado = Convert.ToDouble(txtNumero1.Text) + Convert.ToDouble(txtNumero1.Text);

            }
        }
    }
}
