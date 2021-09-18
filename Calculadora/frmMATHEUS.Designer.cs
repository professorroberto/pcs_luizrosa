namespace Calculadora
{
    partial class frmMATHEUS
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSub = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(45, 68);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(118, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(181, 68);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(123, 20);
            this.txtN2.TabIndex = 1;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(326, 68);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(115, 20);
            this.txtN3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(68, 112);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(76, 45);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(211, 193);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(55, 13);
            this.lblRes.TabIndex = 10;
            this.lblRes.Text = "Resultado";
            // 
            // frmMATHEUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Name = "frmMATHEUS";
            this.Text = "frmMATHEUS Ra:2200022-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblRes;

    }
}