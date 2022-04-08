namespace volumeLp
{
    partial class fmrVolume
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
            this.lblRaio = new System.Windows.Forms.Label();
            this.lvlAltura = new System.Windows.Forms.Label();
            this.txbRaio = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(57, 93);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(29, 13);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Raio";
            // 
            // lvlAltura
            // 
            this.lvlAltura.AutoSize = true;
            this.lvlAltura.Location = new System.Drawing.Point(60, 122);
            this.lvlAltura.Name = "lvlAltura";
            this.lvlAltura.Size = new System.Drawing.Size(34, 13);
            this.lvlAltura.TabIndex = 1;
            this.lvlAltura.Text = "Altura";
            // 
            // txbRaio
            // 
            this.txbRaio.Location = new System.Drawing.Point(131, 85);
            this.txbRaio.Name = "txbRaio";
            this.txbRaio.Size = new System.Drawing.Size(100, 20);
            this.txbRaio.TabIndex = 2;
            // 
            // txbAltura
            // 
            this.txbAltura.Location = new System.Drawing.Point(131, 122);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 20);
            this.txbAltura.TabIndex = 3;
            // 
            // txbVolume
            // 
            this.txbVolume.Location = new System.Drawing.Point(131, 158);
            this.txbVolume.Name = "txbVolume";
            this.txbVolume.Size = new System.Drawing.Size(100, 20);
            this.txbVolume.TabIndex = 3;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(60, 161);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(42, 13);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "Volume";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(63, 204);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(156, 204);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // fmrVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 280);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbVolume);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbRaio);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lvlAltura);
            this.Controls.Add(this.lblRaio);
            this.Name = "fmrVolume";
            this.Text = "volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lvlAltura;
        private System.Windows.Forms.TextBox txbRaio;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
    }
}

