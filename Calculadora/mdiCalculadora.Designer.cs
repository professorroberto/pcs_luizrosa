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
            this.adiçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtraaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.adiçãoToolStripMenuItem,
            this.subtraaoToolStripMenuItem,
            this.multiplicaçãoToolStripMenuItem,
            this.divisãoToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // adiçãoToolStripMenuItem
            // 
            this.adiçãoToolStripMenuItem.Name = "adiçãoToolStripMenuItem";
            this.adiçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adiçãoToolStripMenuItem.Text = "Adição";
            this.adiçãoToolStripMenuItem.Click += new System.EventHandler(this.adiçãoToolStripMenuItem_Click);
            // 
            // subtraaoToolStripMenuItem
            // 
            this.subtraaoToolStripMenuItem.Name = "subtraaoToolStripMenuItem";
            this.subtraaoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.subtraaoToolStripMenuItem.Text = "Subtração";
            // 
            // multiplicaçãoToolStripMenuItem
            // 
            this.multiplicaçãoToolStripMenuItem.Name = "multiplicaçãoToolStripMenuItem";
            this.multiplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.multiplicaçãoToolStripMenuItem.Text = "Multiplicação";
            // 
            // divisãoToolStripMenuItem
            // 
            this.divisãoToolStripMenuItem.Name = "divisãoToolStripMenuItem";
            this.divisãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.divisãoToolStripMenuItem.Text = "Divisão";
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
        private System.Windows.Forms.ToolStripMenuItem adiçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtraaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisãoToolStripMenuItem;

    }
}

