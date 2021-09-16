namespace Calculadora
{
    partial class frmLUIS_HENRIQUE
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
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoSoma = new System.Windows.Forms.Button();
            this.botaoMenos = new System.Windows.Forms.Button();
            this.botaoMultiplicacao = new System.Windows.Forms.Button();
            this.botaoMaior = new System.Windows.Forms.Button();
            this.botaoMenor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtn1
            // 
            this.txtn1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn1.Location = new System.Drawing.Point(332, 220);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(48, 46);
            this.txtn1.TabIndex = 0;
            // 
            // txtn3
            // 
            this.txtn3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn3.Location = new System.Drawing.Point(440, 220);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(48, 46);
            this.txtn3.TabIndex = 1;
            // 
            // txtn2
            // 
            this.txtn2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn2.Location = new System.Drawing.Point(386, 220);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(48, 46);
            this.txtn2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "numero 1";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblResposta.Location = new System.Drawing.Point(508, 227);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(42, 61);
            this.lblResposta.TabIndex = 4;
            this.lblResposta.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "numero 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "numero 2";
            // 
            // botaoSoma
            // 
            this.botaoSoma.BackColor = System.Drawing.Color.Chartreuse;
            this.botaoSoma.Location = new System.Drawing.Point(327, 272);
            this.botaoSoma.Name = "botaoSoma";
            this.botaoSoma.Size = new System.Drawing.Size(51, 31);
            this.botaoSoma.TabIndex = 7;
            this.botaoSoma.Text = "Somar";
            this.botaoSoma.UseVisualStyleBackColor = false;
            this.botaoSoma.Click += new System.EventHandler(this.botaoSoma_Click);
            // 
            // botaoMenos
            // 
            this.botaoMenos.BackColor = System.Drawing.Color.Chartreuse;
            this.botaoMenos.Location = new System.Drawing.Point(384, 272);
            this.botaoMenos.Name = "botaoMenos";
            this.botaoMenos.Size = new System.Drawing.Size(51, 44);
            this.botaoMenos.TabIndex = 8;
            this.botaoMenos.Text = "Subtracao";
            this.botaoMenos.UseVisualStyleBackColor = false;
            this.botaoMenos.Click += new System.EventHandler(this.botaoMenos_Click);
            // 
            // botaoMultiplicacao
            // 
            this.botaoMultiplicacao.BackColor = System.Drawing.Color.Chartreuse;
            this.botaoMultiplicacao.Location = new System.Drawing.Point(437, 272);
            this.botaoMultiplicacao.Name = "botaoMultiplicacao";
            this.botaoMultiplicacao.Size = new System.Drawing.Size(51, 44);
            this.botaoMultiplicacao.TabIndex = 9;
            this.botaoMultiplicacao.Text = "Multiplicacao";
            this.botaoMultiplicacao.UseVisualStyleBackColor = false;
            this.botaoMultiplicacao.Click += new System.EventHandler(this.botaoMultiplicacao_Click);
            // 
            // botaoMaior
            // 
            this.botaoMaior.BackColor = System.Drawing.Color.Chartreuse;
            this.botaoMaior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoMaior.Location = new System.Drawing.Point(327, 332);
            this.botaoMaior.Name = "botaoMaior";
            this.botaoMaior.Size = new System.Drawing.Size(46, 48);
            this.botaoMaior.TabIndex = 10;
            this.botaoMaior.Text = "Maior";
            this.botaoMaior.UseVisualStyleBackColor = false;
            // 
            // botaoMenor
            // 
            this.botaoMenor.BackColor = System.Drawing.Color.Chartreuse;
            this.botaoMenor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botaoMenor.Location = new System.Drawing.Point(386, 332);
            this.botaoMenor.Name = "botaoMenor";
            this.botaoMenor.Size = new System.Drawing.Size(46, 48);
            this.botaoMenor.TabIndex = 11;
            this.botaoMenor.Text = "Menor";
            this.botaoMenor.UseVisualStyleBackColor = false;
            this.botaoMenor.Click += new System.EventHandler(this.botaoMenor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumOrchid;
            this.label2.Location = new System.Drawing.Point(191, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Luis Henrique Franco Delmadi 2200004-7";
            // 
            // frmLUIS_HENRIQUE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1107, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoMenor);
            this.Controls.Add(this.botaoMaior);
            this.Controls.Add(this.botaoMultiplicacao);
            this.Controls.Add(this.botaoMenos);
            this.Controls.Add(this.botaoSoma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn1);
            this.Name = "frmLUIS_HENRIQUE";
            this.Text = "frmLUIS_HENRIQUE 2200004-7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoSoma;
        private System.Windows.Forms.Button botaoMenos;
        private System.Windows.Forms.Button botaoMultiplicacao;
        private System.Windows.Forms.Button botaoMaior;
        private System.Windows.Forms.Button botaoMenor;
        private System.Windows.Forms.Label label2;

    }
}