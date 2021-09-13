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
            this.hEITORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jONASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lUISHENRIQUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATHEUSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAMUELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.hEITORToolStripMenuItem,
            this.jONASToolStripMenuItem,
            this.lUISHENRIQUEToolStripMenuItem,
            this.mATHEUSToolStripMenuItem,
            this.sAMUELToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // hEITORToolStripMenuItem
            // 
            this.hEITORToolStripMenuItem.Name = "hEITORToolStripMenuItem";
            this.hEITORToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hEITORToolStripMenuItem.Text = "HEITOR";
            this.hEITORToolStripMenuItem.Click += new System.EventHandler(this.hEITORToolStripMenuItem_Click);
            // 
            // jONASToolStripMenuItem
            // 
            this.jONASToolStripMenuItem.Name = "jONASToolStripMenuItem";
            this.jONASToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.jONASToolStripMenuItem.Text = "JONAS";
            this.jONASToolStripMenuItem.Click += new System.EventHandler(this.jONASToolStripMenuItem_Click);
            // 
            // lUISHENRIQUEToolStripMenuItem
            // 
            this.lUISHENRIQUEToolStripMenuItem.Name = "lUISHENRIQUEToolStripMenuItem";
            this.lUISHENRIQUEToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lUISHENRIQUEToolStripMenuItem.Text = "LUIS HENRIQUE";
            this.lUISHENRIQUEToolStripMenuItem.Click += new System.EventHandler(this.lUISHENRIQUEToolStripMenuItem_Click);
            // 
            // mATHEUSToolStripMenuItem
            // 
            this.mATHEUSToolStripMenuItem.Name = "mATHEUSToolStripMenuItem";
            this.mATHEUSToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mATHEUSToolStripMenuItem.Text = "MATHEUS";
            this.mATHEUSToolStripMenuItem.Click += new System.EventHandler(this.mATHEUSToolStripMenuItem_Click);
            // 
            // sAMUELToolStripMenuItem
            // 
            this.sAMUELToolStripMenuItem.Name = "sAMUELToolStripMenuItem";
            this.sAMUELToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sAMUELToolStripMenuItem.Text = "SAMUEL";
            this.sAMUELToolStripMenuItem.Click += new System.EventHandler(this.sAMUELToolStripMenuItem_Click);
            // 
            // mdiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
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
        private System.Windows.Forms.ToolStripMenuItem hEITORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jONASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lUISHENRIQUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATHEUSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAMUELToolStripMenuItem;

    }
}

