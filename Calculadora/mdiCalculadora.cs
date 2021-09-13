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
    public partial class mdiCalculadora : Form
    {
        public mdiCalculadora()
        {
            InitializeComponent();
        }

        void openForm(Form formularioParaAbrir)
        {
            formularioParaAbrir.Show();
        }

        private void hEITORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmHEITOR());
        }

        private void jONASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmJONAS());
        }

        private void lUISHENRIQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLUIS_HENRIQUE());
        }

        private void mATHEUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmMATHEUS());
        }

        
        private void sAMUELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmSAMUEL());
        }
    }
}
