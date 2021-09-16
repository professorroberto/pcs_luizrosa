namespace Calculadora
{
    partial class frmJONAS
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.btnmais = new System.Windows.Forms.Button();
            this.btnvezes = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnmaior = new System.Windows.Forms.Button();
            this.btnmenor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(52, 87);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(130, 46);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(207, 87);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(130, 46);
            this.txt2.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(354, 87);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(130, 46);
            this.txt3.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(49, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Numero:1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(204, 53);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Numero:2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(351, 53);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Numero:3";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblres.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.Location = new System.Drawing.Point(265, 304);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(138, 55);
            this.lblres.TabIndex = 6;
            this.lblres.Text = "lblres";
            // 
            // btnmais
            // 
            this.btnmais.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmais.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmais.Location = new System.Drawing.Point(97, 187);
            this.btnmais.Name = "btnmais";
            this.btnmais.Size = new System.Drawing.Size(119, 41);
            this.btnmais.TabIndex = 7;
            this.btnmais.Text = "somar";
            this.btnmais.UseVisualStyleBackColor = false;
            this.btnmais.Click += new System.EventHandler(this.btnmais_Click);
            // 
            // btnvezes
            // 
            this.btnvezes.BackColor = System.Drawing.Color.Chartreuse;
            this.btnvezes.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvezes.Location = new System.Drawing.Point(252, 187);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(187, 41);
            this.btnvezes.TabIndex = 8;
            this.btnvezes.Text = "multiplicar";
            this.btnvezes.UseVisualStyleBackColor = false;
            this.btnvezes.Click += new System.EventHandler(this.btnvezes_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmenos.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(478, 187);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(139, 41);
            this.btnmenos.TabIndex = 9;
            this.btnmenos.Text = "subtrair";
            this.btnmenos.UseVisualStyleBackColor = false;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnmaior
            // 
            this.btnmaior.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmaior.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmaior.Location = new System.Drawing.Point(478, 297);
            this.btnmaior.Name = "btnmaior";
            this.btnmaior.Size = new System.Drawing.Size(119, 67);
            this.btnmaior.TabIndex = 10;
            this.btnmaior.Text = "maior";
            this.btnmaior.UseVisualStyleBackColor = false;
            this.btnmaior.Click += new System.EventHandler(this.btnmaior_Click);
            // 
            // btnmenor
            // 
            this.btnmenor.BackColor = System.Drawing.Color.Chartreuse;
            this.btnmenor.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenor.Location = new System.Drawing.Point(97, 298);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(119, 67);
            this.btnmenor.TabIndex = 11;
            this.btnmenor.Text = "menor";
            this.btnmenor.UseVisualStyleBackColor = false;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jonas Comparoni Junior 2200056-6";
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Chartreuse;
            this.btnlimpar.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(275, 375);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(119, 67);
            this.btnlimpar.TabIndex = 13;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            // 
            // frmJONAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 457);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmenor);
            this.Controls.Add(this.btnmaior);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnvezes);
            this.Controls.Add(this.btnmais);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "frmJONAS";
            this.Text = "frmJONAS";
            this.Load += new System.EventHandler(this.frmJONAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblres;
        private System.Windows.Forms.Button btnmais;
        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnmaior;
        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlimpar;

    }
}