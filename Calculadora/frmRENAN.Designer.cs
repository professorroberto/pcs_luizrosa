namespace Calculadora
{
    partial class frmRENAN
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
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnSOMA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblRES = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 3";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(31, 48);
            this.txtN1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(65, 20);
            this.txtN1.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(109, 48);
            this.txtN2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(65, 20);
            this.txtN2.TabIndex = 4;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(190, 48);
            this.txtN3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(65, 20);
            this.txtN3.TabIndex = 5;
            // 
            // btnSOMA
            // 
            this.btnSOMA.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSOMA.Location = new System.Drawing.Point(32, 76);
            this.btnSOMA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSOMA.Name = "btnSOMA";
            this.btnSOMA.Size = new System.Drawing.Size(62, 27);
            this.btnSOMA.TabIndex = 6;
            this.btnSOMA.Text = "SOMAR";
            this.btnSOMA.UseVisualStyleBackColor = false;
            this.btnSOMA.Click += new System.EventHandler(this.btnSOMA_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(109, 76);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "SUBTRAIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMultiplicar.Location = new System.Drawing.Point(191, 76);
            this.btnMultiplicar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(78, 27);
            this.btnMultiplicar.TabIndex = 8;
            this.btnMultiplicar.Text = "MULTIPLICAR";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblRES
            // 
            this.lblRES.AutoSize = true;
            this.lblRES.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRES.Location = new System.Drawing.Point(94, 133);
            this.lblRES.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRES.Name = "lblRES";
            this.lblRES.Size = new System.Drawing.Size(126, 31);
            this.lblRES.TabIndex = 9;
            this.lblRES.Text = "resultado";
            this.lblRES.Click += new System.EventHandler(this.lblRES_Click);
            // 
            // frmRENAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 384);
            this.Controls.Add(this.lblRES);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSOMA);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRENAN";
            this.Text = "a";
            this.Load += new System.EventHandler(this.frmRENAN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Button btnSOMA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label lblRES;
    }
}