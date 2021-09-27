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
    public partial class frmGABRIEL : Form
    {
        public frmGABRIEL()
        {
            InitializeComponent();
        }

        private void BNT3_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(TXTB1.Text);
            int v2 = Convert.ToInt32(TXTB2.Text);
            int v3 = Convert.ToInt32(TXTB3.Text);

            LBLR.Text = Convert.ToString(v1 * v2 * v3);       
        }

        private void frmGABRIEL_Load(object sender, EventArgs e)
        {
            int v1 = 0;
            int v2 = 0;
            int v3 = 0;

            BNT1.BackColor = Color.LightSteelBlue;
            BNT2.BackColor = Color.LightSteelBlue;
            BNT3.BackColor = Color.LightSteelBlue;
        }

        private void BNT1_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(TXTB1.Text);
            int v2 = Convert.ToInt32(TXTB2.Text);
            int v3 = Convert.ToInt32(TXTB3.Text);

            LBLR.Text = Convert.ToString(v1 + v2 + v3);
        }

        private void BNT2_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(TXTB1.Text);
            int v2 = Convert.ToInt32(TXTB2.Text);
            int v3 = Convert.ToInt32(TXTB3.Text);

            LBLR.Text = Convert.ToString(v1 - v2 - v3);
        }
    }
}
