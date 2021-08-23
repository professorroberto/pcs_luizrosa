namespace Calculadora
{
    partial class frmGUILHERME
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(202, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número 2";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(20, 107);
            this.txtn1.Margin = new System.Windows.Forms.Padding(4);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(160, 22);
            this.txtn1.TabIndex = 3;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(209, 107);
            this.txtn2.Margin = new System.Windows.Forms.Padding(4);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(162, 22);
            this.txtn2.TabIndex = 4;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(406, 107);
            this.txtn3.Margin = new System.Windows.Forms.Padding(4);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(160, 22);
            this.txtn3.TabIndex = 5;
            this.txtn3.TextChanged += new System.EventHandler(this.txtn3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(25, 164);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "SOMAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(307, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "MULTIPLICAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(164, 164);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "SUBTRAIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(160, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULTADO";
            // 
            // btnMaior
            // 
            this.btnMaior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMaior.Location = new System.Drawing.Point(457, 164);
            this.btnMaior.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(123, 28);
            this.btnMaior.TabIndex = 10;
            this.btnMaior.Text = "MAIOR";
            this.btnMaior.UseVisualStyleBackColor = false;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenor.Location = new System.Drawing.Point(232, 200);
            this.btnMenor.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(123, 28);
            this.btnMenor.TabIndex = 11;
            this.btnMenor.Text = "MENOR";
            this.btnMenor.UseVisualStyleBackColor = false;
            // 
            // frmGUILHERME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(724, 466);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGUILHERME";
            this.Text = "2200018-5";
            this.Load += new System.EventHandler(this.frmGUILHERME_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnMenor;
    }
}