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
    public partial class frmMultiplicacao : Form
    {
        public frmMultiplicacao()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            float result = float.Parse(txtNumero1.Text) * float.Parse(txtNumero2.Text);
        }
    }
}
