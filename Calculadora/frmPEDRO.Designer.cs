namespace Calculadora
{
    partial class frmPEDRO
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.btnSubtraçao = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnMaior = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero1.Location = new System.Drawing.Point(81, 171);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(103, 39);
            this.txtNumero1.TabIndex = 1;
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSoma.Location = new System.Drawing.Point(81, 210);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(104, 51);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero 2";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblResultado.Location = new System.Drawing.Point(131, 274);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(241, 55);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // txtNumero2
            // 
            this.txtNumero2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero2.Location = new System.Drawing.Point(195, 171);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(104, 39);
            this.txtNumero2.TabIndex = 6;
            // 
            // txtNumero3
            // 
            this.txtNumero3.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero3.Location = new System.Drawing.Point(306, 171);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(104, 39);
            this.txtNumero3.TabIndex = 7;
            // 
            // btnSubtraçao
            // 
            this.btnSubtraçao.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSubtraçao.Location = new System.Drawing.Point(306, 210);
            this.btnSubtraçao.Name = "btnSubtraçao";
            this.btnSubtraçao.Size = new System.Drawing.Size(104, 51);
            this.btnSubtraçao.TabIndex = 8;
            this.btnSubtraçao.Text = "Subtraçao";
            this.btnSubtraçao.UseVisualStyleBackColor = false;
            this.btnSubtraçao.Click += new System.EventHandler(this.btnSubtraçao_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMultiplicar.Location = new System.Drawing.Point(196, 210);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(104, 51);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnMaior
            // 
            this.btnMaior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMaior.Location = new System.Drawing.Point(123, 342);
            this.btnMaior.Name = "btnMaior";
            this.btnMaior.Size = new System.Drawing.Size(123, 51);
            this.btnMaior.TabIndex = 10;
            this.btnMaior.Text = "MAIOR";
            this.btnMaior.UseVisualStyleBackColor = false;
            this.btnMaior.Click += new System.EventHandler(this.btnMaior_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenor.Location = new System.Drawing.Point(264, 342);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(123, 51);
            this.btnMenor.TabIndex = 11;
            this.btnMenor.Text = "menor";
            this.btnMenor.UseVisualStyleBackColor = false;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Fuchsia;
            this.label4.Location = new System.Drawing.Point(75, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "PEDRO VICTOR - 22000396";
            // 
            // frmPEDRO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(600, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMaior);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSubtraçao);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label1);
            this.Name = "frmPEDRO";
            this.Text = " 22000396";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Button btnSubtraçao;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnMaior;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label label4;
    }
}