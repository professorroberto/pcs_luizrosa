namespace Calculadora
{
    partial class frmSAMUEL
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
            this.Nume3 = new System.Windows.Forms.TextBox();
            this.Nume2 = new System.Windows.Forms.TextBox();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.Label();
            this.n2 = new System.Windows.Forms.Label();
            this.n3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Nume1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nume3
            // 
            this.Nume3.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume3.Location = new System.Drawing.Point(288, 40);
            this.Nume3.Name = "Nume3";
            this.Nume3.Size = new System.Drawing.Size(106, 39);
            this.Nume3.TabIndex = 0;
            // 
            // Nume2
            // 
            this.Nume2.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume2.Location = new System.Drawing.Point(158, 40);
            this.Nume2.Name = "Nume2";
            this.Nume2.Size = new System.Drawing.Size(99, 39);
            this.Nume2.TabIndex = 1;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(27, 40);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(0, 20);
            this.Num1.TabIndex = 2;
            // 
            // n1
            // 
            this.n1.AutoSize = true;
            this.n1.Location = new System.Drawing.Point(24, 24);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(53, 13);
            this.n1.TabIndex = 3;
            this.n1.Text = "Numero 1";
            this.n1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n2
            // 
            this.n2.AutoSize = true;
            this.n2.Location = new System.Drawing.Point(155, 24);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(53, 13);
            this.n2.TabIndex = 4;
            this.n2.Text = "Numero 2";
            // 
            // n3
            // 
            this.n3.AutoSize = true;
            this.n3.Location = new System.Drawing.Point(294, 24);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(53, 13);
            this.n3.TabIndex = 5;
            this.n3.Text = "Numero 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Somar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Subtrair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(176, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resultado";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(133, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 44);
            this.button4.TabIndex = 10;
            this.button4.Text = "Maior";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Nume1
            // 
            this.Nume1.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nume1.Location = new System.Drawing.Point(13, 40);
            this.Nume1.Name = "Nume1";
            this.Nume1.Size = new System.Drawing.Size(114, 39);
            this.Nume1.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button5.Location = new System.Drawing.Point(138, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "MENOR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // frmSAMUEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(427, 337);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Nume1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.n3);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.Nume2);
            this.Controls.Add(this.Nume3);
            this.Name = "frmSAMUEL";
            this.Text = "22000728";
            this.Load += new System.EventHandler(this.frmSAMUEL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nume3;
        private System.Windows.Forms.TextBox Nume2;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.Label n1;
        private System.Windows.Forms.Label n2;
        private System.Windows.Forms.Label n3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Nume1;
        private System.Windows.Forms.Button button5;
    }
}