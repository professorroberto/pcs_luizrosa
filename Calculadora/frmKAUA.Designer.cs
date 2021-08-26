namespace Calculadora
{
    partial class frmKAUA
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum3 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÚMERO 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NÚMERO 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NÚMERO 3";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(13, 67);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(77, 39);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(96, 67);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(78, 39);
            this.txtNum2.TabIndex = 4;
            // 
            // txtNum3
            // 
            this.txtNum3.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum3.Location = new System.Drawing.Point(180, 67);
            this.txtNum3.Name = "txtNum3";
            this.txtNum3.Size = new System.Drawing.Size(82, 39);
            this.txtNum3.TabIndex = 5;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSoma.Location = new System.Drawing.Point(12, 112);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(93, 32);
            this.btnSoma.TabIndex = 6;
            this.btnSoma.Text = "SOMAR";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSub.Location = new System.Drawing.Point(111, 112);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(90, 32);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "SUBTRAIR";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMult.Location = new System.Drawing.Point(207, 112);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(87, 32);
            this.btnMult.TabIndex = 8;
            this.btnMult.Text = "MULTIPLICAR";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResult.Location = new System.Drawing.Point(81, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(181, 31);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "RESULTADO";
            // 
            // btnMaior
            // 
            this.btnMaior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMaior.Location = new System.Drawing.Point(300, 116);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(61, 24);
            this.btnMaior.TabIndex = 10;
            this.btnMaior.Text = "MAIOR";
            this.btnMaior.UseVisualStyleBackColor = false;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenor.Location = new System.Drawing.Point(367, 116);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(56, 24);
            this.btnMenor.TabIndex = 11;
            this.btnMenor.Text = "MENOR";
            this.btnMenor.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "KAUÃ LOURENZON  2200016-9";
            // 
            // frmKAUA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(584, 436);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNum3);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKAUA";
            this.Text = "2200016-9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label label4;
    }
}