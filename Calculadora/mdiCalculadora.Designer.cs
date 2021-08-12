namespace Calculadora
{
    partial class mdiCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuOperacoes = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdicao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSubtracao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMultiplicacao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDivisao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOperacoes
            // 
            this.mnuOperacoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.mnuOperacoes.Location = new System.Drawing.Point(0, 0);
            this.mnuOperacoes.Name = "mnuOperacoes";
            this.mnuOperacoes.Size = new System.Drawing.Size(396, 24);
            this.mnuOperacoes.TabIndex = 1;
            this.mnuOperacoes.Text = "menuStrip1";
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdicao,
            this.mnuSubtracao,
            this.mnuMultiplicacao,
            this.mnuDivisao});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // mnuAdicao
            // 
            this.mnuAdicao.Name = "mnuAdicao";
            this.mnuAdicao.Size = new System.Drawing.Size(152, 22);
            this.mnuAdicao.Text = "Adição";
            this.mnuAdicao.Click += new System.EventHandler(this.mnuAdicao_Click);
            // 
            // mnuSubtracao
            // 
            this.mnuSubtracao.Name = "mnuSubtracao";
            this.mnuSubtracao.Size = new System.Drawing.Size(152, 22);
            this.mnuSubtracao.Text = "Subtração";
            this.mnuSubtracao.Click += new System.EventHandler(this.mnuSubtracao_Click);
            // 
            // mnuMultiplicacao
            // 
            this.mnuMultiplicacao.Name = "mnuMultiplicacao";
            this.mnuMultiplicacao.Size = new System.Drawing.Size(152, 22);
            this.mnuMultiplicacao.Text = "Multiplicação";
            // 
            // mnuDivisao
            // 
            this.mnuDivisao.Name = "mnuDivisao";
            this.mnuDivisao.Size = new System.Drawing.Size(152, 22);
            this.mnuDivisao.Text = "Divisão";
            // 
            // mdiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 368);
            this.Controls.Add(this.mnuOperacoes);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuOperacoes;
            this.MaximizeBox = false;
            this.Name = "mdiCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuOperacoes.ResumeLayout(false);
            this.mnuOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOperacoes;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAdicao;
        private System.Windows.Forms.ToolStripMenuItem mnuSubtracao;
        private System.Windows.Forms.ToolStripMenuItem mnuMultiplicacao;
        private System.Windows.Forms.ToolStripMenuItem mnuDivisao;

    }
}

