﻿namespace Calculadora
{
    partial class frmFELIPPO
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btncalcS = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btncalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(12, 38);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 39);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(118, 38);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 39);
            this.txtnum2.TabIndex = 1;
            // 
            // btncalcS
            // 
            this.btncalcS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btncalcS.Location = new System.Drawing.Point(23, 83);
            this.btncalcS.Name = "btncalcS";
            this.btncalcS.Size = new System.Drawing.Size(75, 23);
            this.btncalcS.TabIndex = 2;
            this.btncalcS.Text = "SOMAR";
            this.btncalcS.UseVisualStyleBackColor = false;
            this.btncalcS.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(85, 156);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(181, 31);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "RESULTADO";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // txtnum3
            // 
            this.txtnum3.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum3.Location = new System.Drawing.Point(224, 38);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.Size = new System.Drawing.Size(100, 39);
            this.txtnum3.TabIndex = 4;
            this.txtnum3.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(236, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "MULTIPLICAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btncalc
            // 
            this.Btncalc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Btncalc.Location = new System.Drawing.Point(133, 83);
            this.Btncalc.Name = "Btncalc";
            this.Btncalc.Size = new System.Drawing.Size(75, 23);
            this.Btncalc.TabIndex = 6;
            this.Btncalc.Text = "SUBTRAIR";
            this.Btncalc.UseVisualStyleBackColor = false;
            this.Btncalc.Click += new System.EventHandler(this.Btncalc_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número 3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(286, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 50);
            this.button2.TabIndex = 10;
            this.button2.Text = "MAIOR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(10, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 50);
            this.button3.TabIndex = 11;
            this.button3.Text = "MENOR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // frmFELIPPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(386, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btncalc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btncalcS);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "frmFELIPPO";
            this.Text = "2200029-9";
            this.Load += new System.EventHandler(this.frmFELIPPO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btncalcS;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btncalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}