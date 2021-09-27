namespace Calculadora
{
    partial class frmGABRIEL
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
            this.BNT1 = new System.Windows.Forms.Button();
            this.BNT2 = new System.Windows.Forms.Button();
            this.BNT3 = new System.Windows.Forms.Button();
            this.TXTB1 = new System.Windows.Forms.TextBox();
            this.TXTB3 = new System.Windows.Forms.TextBox();
            this.TXTB2 = new System.Windows.Forms.TextBox();
            this.LBL1 = new System.Windows.Forms.Label();
            this.LBL2 = new System.Windows.Forms.Label();
            this.LBL3 = new System.Windows.Forms.Label();
            this.LBLR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BNT1
            // 
            this.BNT1.Location = new System.Drawing.Point(59, 105);
            this.BNT1.Name = "BNT1";
            this.BNT1.Size = new System.Drawing.Size(92, 37);
            this.BNT1.TabIndex = 0;
            this.BNT1.Text = "SOMAR";
            this.BNT1.UseVisualStyleBackColor = true;
            // 
            // BNT2
            // 
            this.BNT2.Location = new System.Drawing.Point(157, 105);
            this.BNT2.Name = "BNT2";
            this.BNT2.Size = new System.Drawing.Size(92, 37);
            this.BNT2.TabIndex = 1;
            this.BNT2.Text = "SUBTRAIR";
            this.BNT2.UseVisualStyleBackColor = true;
            // 
            // BNT3
            // 
            this.BNT3.Location = new System.Drawing.Point(255, 105);
            this.BNT3.Name = "BNT3";
            this.BNT3.Size = new System.Drawing.Size(92, 37);
            this.BNT3.TabIndex = 2;
            this.BNT3.Text = "MULTIPLICAR";
            this.BNT3.UseVisualStyleBackColor = true;
            this.BNT3.Click += new System.EventHandler(this.BNT3_Click);
            // 
            // TXTB1
            // 
            this.TXTB1.Location = new System.Drawing.Point(59, 79);
            this.TXTB1.Name = "TXTB1";
            this.TXTB1.Size = new System.Drawing.Size(92, 20);
            this.TXTB1.TabIndex = 3;
            // 
            // TXTB3
            // 
            this.TXTB3.Location = new System.Drawing.Point(255, 79);
            this.TXTB3.Name = "TXTB3";
            this.TXTB3.Size = new System.Drawing.Size(92, 20);
            this.TXTB3.TabIndex = 4;
            // 
            // TXTB2
            // 
            this.TXTB2.Location = new System.Drawing.Point(157, 79);
            this.TXTB2.Name = "TXTB2";
            this.TXTB2.Size = new System.Drawing.Size(92, 20);
            this.TXTB2.TabIndex = 5;
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(56, 63);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(50, 13);
            this.LBL1.TabIndex = 6;
            this.LBL1.Text = "Número1";
            // 
            // LBL2
            // 
            this.LBL2.AutoSize = true;
            this.LBL2.Location = new System.Drawing.Point(154, 63);
            this.LBL2.Name = "LBL2";
            this.LBL2.Size = new System.Drawing.Size(50, 13);
            this.LBL2.TabIndex = 8;
            this.LBL2.Text = "Número2";
            // 
            // LBL3
            // 
            this.LBL3.AutoSize = true;
            this.LBL3.Location = new System.Drawing.Point(252, 63);
            this.LBL3.Name = "LBL3";
            this.LBL3.Size = new System.Drawing.Size(50, 13);
            this.LBL3.TabIndex = 10;
            this.LBL3.Text = "Número3";
            // 
            // LBLR
            // 
            this.LBLR.AutoSize = true;
            this.LBLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLR.Location = new System.Drawing.Point(12, 177);
            this.LBLR.Name = "LBLR";
            this.LBLR.Size = new System.Drawing.Size(189, 31);
            this.LBLR.TabIndex = 11;
            this.LBLR.Text = "RESULTADO:";
            // 
            // frmGABRIEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 217);
            this.Controls.Add(this.LBLR);
            this.Controls.Add(this.LBL3);
            this.Controls.Add(this.LBL2);
            this.Controls.Add(this.LBL1);
            this.Controls.Add(this.TXTB2);
            this.Controls.Add(this.TXTB3);
            this.Controls.Add(this.TXTB1);
            this.Controls.Add(this.BNT3);
            this.Controls.Add(this.BNT2);
            this.Controls.Add(this.BNT1);
            this.Name = "frmGABRIEL";
            this.Text = "2190028-9";
            this.Load += new System.EventHandler(this.frmGABRIEL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNT1;
        private System.Windows.Forms.Button BNT2;
        private System.Windows.Forms.Button BNT3;
        private System.Windows.Forms.TextBox TXTB1;
        private System.Windows.Forms.TextBox TXTB3;
        private System.Windows.Forms.TextBox TXTB2;
        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label LBL2;
        private System.Windows.Forms.Label LBL3;
        private System.Windows.Forms.Label LBLR;
    }
}