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

        private void bRUNOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmBRUNO());
        }

        private void eNZOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmENZO());
        }

        private void fELIPPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmFELIPPO());
        }

        private void gUILHERMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmGUILHERME());
        }

        private void hEITORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmHEITOR());
        }

        private void jONASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmJONAS());
        }

        private void kAUAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmKAUA());
        }

        private void lEONARDOFERREIRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLEONARDO_FERREIRA());
        }

        private void lEONARDOTEIXEIRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLEONARDO_TEIXEIRA());
        }

        private void lUCASDEPAULAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLUCAS_DE_PAULA());
        }

        private void lUCASPANICOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLUCAS_PANICO());
        }

        private void lUISFELIPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLUIS_FELIPE());
        }

        private void lUISHENRIQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmLUIS_HENRIQUE());
        }

        private void mATHEUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmMATHEUS());
        }

        private void nICOLASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmNICOLAS());
        }

        private void pEDROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmPEDRO());
        }

        private void rENANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmRENAN());
        }

        private void sAMUELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmSAMUEL());
        }

        private void tIAGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new frmTIAGO());
        }

    }
}
