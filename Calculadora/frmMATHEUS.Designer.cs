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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(414, 186);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(118, 46);
            this.txtN1.TabIndex = 0;
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(583, 186);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(123, 46);
            this.txtN2.TabIndex = 1;
            this.txtN2.TextChanged += new System.EventHandler(this.txtN2_TextChanged);
            // 
            // txtN3
            // 
            this.txtN3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(728, 186);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(115, 46);
            this.txtN3.TabIndex = 2;
            this.txtN3.TextChanged += new System.EventHandler(this.txtN3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(769, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSub.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(383, 293);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(218, 73);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(607, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 73);
            this.button2.TabIndex = 8;
            this.button2.Text = "Multiplicação";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chartreuse;
            this.button3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(837, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 73);
            this.button3.TabIndex = 9;
            this.button3.Text = "Adição";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblRes.Location = new System.Drawing.Point(578, 538);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(265, 61);
            this.lblRes.TabIndex = 10;
            this.lblRes.Text = "Resultado";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(387, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 73);
            this.button1.TabIndex = 11;
            this.button1.Text = "Maior";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chartreuse;
            this.button4.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(607, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(224, 73);
            this.button4.TabIndex = 12;
            this.button4.Text = "menor";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label4.Location = new System.Drawing.Point(353, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Matheus Araujo Ferreira 2200022";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chartreuse;
            this.button5.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(837, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 73);
            this.button5.TabIndex = 14;
            this.button5.Text = "Limpar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmMATHEUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1204, 631);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;

    }
}