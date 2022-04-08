namespace triangulo_lp
{
    partial class frmTriangulo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txbValA = new System.Windows.Forms.TextBox();
            this.txbValB = new System.Windows.Forms.TextBox();
            this.txbValC = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(110, 147);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 43);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(60, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(44, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Valor A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(60, 76);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(44, 13);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Valor B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(60, 107);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(44, 13);
            this.lblC.TabIndex = 3;
            this.lblC.Text = "Valor C:";
            // 
            // txbValA
            // 
            this.txbValA.Location = new System.Drawing.Point(110, 47);
            this.txbValA.Name = "txbValA";
            this.txbValA.Size = new System.Drawing.Size(100, 20);
            this.txbValA.TabIndex = 4;
            // 
            // txbValB
            // 
            this.txbValB.Location = new System.Drawing.Point(110, 73);
            this.txbValB.Name = "txbValB";
            this.txbValB.Size = new System.Drawing.Size(100, 20);
            this.txbValB.TabIndex = 5;
            // 
            // txbValC
            // 
            this.txbValC.Location = new System.Drawing.Point(110, 104);
            this.txbValC.Name = "txbValC";
            this.txbValC.Size = new System.Drawing.Size(100, 20);
            this.txbValC.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(213, 147);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 43);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 240);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbValC);
            this.Controls.Add(this.txbValB);
            this.Controls.Add(this.txbValA);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmTriangulo";
            this.Text = "Verificar Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txbValA;
        private System.Windows.Forms.TextBox txbValB;
        private System.Windows.Forms.TextBox txbValC;
        private System.Windows.Forms.Button btnLimpar;
    }
}

