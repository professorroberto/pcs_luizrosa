namespace Calculadora
{
    partial class frmJONAS
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnvezes = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(52, 54);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(130, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(207, 54);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(130, 20);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(354, 54);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(130, 20);
            this.txt3.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(49, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Numero:1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(204, 20);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Numero:2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(351, 20);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Numero:3";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(265, 271);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(31, 13);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "lblres";
            // 
            // btnmais
            // 
            this.btnmais.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmais.Location = new System.Drawing.Point(97, 154);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(85, 41);
            this.btnmais.TabIndex = 7;
            this.btnmais.Text = "somar";
            this.btnmais.UseVisualStyleBackColor = false;
            // 
            // btnvezes
            // 
            this.btnvezes.BackColor = System.Drawing.Color.Chartreuse;
            this.btnvezes.Location = new System.Drawing.Point(252, 154);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(85, 41);
            this.btnvezes.TabIndex = 8;
            this.btnvezes.Text = "multiplicar";
            this.btnvezes.UseVisualStyleBackColor = false;
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmenos.Location = new System.Drawing.Point(399, 154);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(85, 41);
            this.btnmenos.TabIndex = 9;
            this.btnmenos.Text = "subtrair";
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // frmJONAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 438);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnvezes);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "frmJONAS";
            this.Text = "frmJONAS";
            this.Load += new System.EventHandler(this.frmJONAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btnmenos;

    }
}