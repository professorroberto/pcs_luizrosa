﻿namespace Calculadora
{
    partial class frmLUIS_FELIPE
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
            this.btnsoma = new System.Windows.Forms.Button();
            this.btnsub = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.lblres = new System.Windows.Forms.Label();
            this.txtMaior = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsoma
            // 
            this.btnsoma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsoma.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoma.Location = new System.Drawing.Point(13, 80);
            this.btnsoma.Name = "btnsoma";
            this.btnsoma.Size = new System.Drawing.Size(92, 87);
            this.btnsoma.TabIndex = 0;
            this.btnsoma.Text = "SOmar";
            this.btnsoma.UseVisualStyleBackColor = false;
            this.btnsoma.Click += new System.EventHandler(this.btnsoma_Click);
            // 
            // btnsub
            // 
            this.btnsub.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnsub.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsub.Location = new System.Drawing.Point(107, 80);
            this.btnsub.Name = "btnsub";
            this.btnsub.Size = new System.Drawing.Size(92, 87);
            this.btnsub.TabIndex = 1;
            this.btnsub.Text = "Subtrair";
            this.btnsub.UseVisualStyleBackColor = false;
            this.btnsub.Click += new System.EventHandler(this.btnsub_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnmult.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.Location = new System.Drawing.Point(211, 80);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(92, 87);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "Multiplicar";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(107, 33);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(92, 39);
            this.num2.TabIndex = 4;
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(211, 33);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(92, 39);
            this.num3.TabIndex = 5;
            this.num3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(13, 33);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 39);
            this.num1.TabIndex = 6;
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblres.Location = new System.Drawing.Point(46, 266);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(241, 55);
            this.lblres.TabIndex = 7;
            this.lblres.Text = "Resultado";
            this.lblres.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaior
            // 
            this.txtMaior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtMaior.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaior.Location = new System.Drawing.Point(73, 176);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(92, 87);
            this.txtMaior.TabIndex = 8;
            this.txtMaior.Text = "Maior";
            this.txtMaior.UseVisualStyleBackColor = false;
            this.txtMaior.Click += new System.EventHandler(this.txtMaior_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenor.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenor.Location = new System.Drawing.Point(183, 176);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(92, 87);
            this.btnMenor.TabIndex = 9;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = false;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(12, -7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Luis Felipe 2200032-2";
            // 
            // frmLUIS_FELIPE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(334, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.btnsub);
            this.Controls.Add(this.btnsoma);
            this.Name = "frmLUIS_FELIPE";
            this.Text = "2200032-2";
            this.Load += new System.EventHandler(this.frmLUIS_FELIPE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsoma;
        private System.Windows.Forms.Button btnsub;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button txtMaior;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label label1;
    }
}