namespace Calculadora
{
    partial class frmBRUNO
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Numero3 = new System.Windows.Forms.TextBox();
            this.Numero2 = new System.Windows.Forms.TextBox();
            this.Numero1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(184, 231);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(153, 31);
            this.lblresultado.TabIndex = 19;
            this.lblresultado.Text = "lblresultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Numero 3:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Numero 1:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 165);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Multiplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Subtrair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Somar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Numero3
            // 
            this.Numero3.Location = new System.Drawing.Point(277, 94);
            this.Numero3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Numero3.Name = "Numero3";
            this.Numero3.Size = new System.Drawing.Size(75, 22);
            this.Numero3.TabIndex = 12;
            // 
            // Numero2
            // 
            this.Numero2.Location = new System.Drawing.Point(187, 94);
            this.Numero2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Numero2.Name = "Numero2";
            this.Numero2.Size = new System.Drawing.Size(81, 22);
            this.Numero2.TabIndex = 11;
            // 
            // Numero1
            // 
            this.Numero1.Location = new System.Drawing.Point(104, 94);
            this.Numero1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Numero1.Name = "Numero1";
            this.Numero1.Size = new System.Drawing.Size(73, 22);
            this.Numero1.TabIndex = 10;
            // 
            // frmBRUNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 382);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Numero3);
            this.Controls.Add(this.Numero2);
            this.Controls.Add(this.Numero1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBRUNO";
            this.Text = "Bruno Skajko Sacciotti 2200002-2";
            this.Load += new System.EventHandler(this.frmBRUNO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Numero3;
        private System.Windows.Forms.TextBox Numero2;
        private System.Windows.Forms.TextBox Numero1;



    }
}