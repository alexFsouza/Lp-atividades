namespace trabalhoSalario
{
    partial class frmMenu
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
            this.mtbSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mtbAliqIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbAliqInss = new System.Windows.Forms.MaskedTextBox();
            this.mtbSalLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mtbDescIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mtbDescInss = new System.Windows.Forms.MaskedTextBox();
            this.mtbSalFamilia = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilhos = new System.Windows.Forms.Label();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.lblAliquotaIrpf = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.lblDescontoIrpf = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Button();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbM = new System.Windows.Forms.RadioButton();
            this.rdbF = new System.Windows.Forms.RadioButton();
            this.gpbCasado = new System.Windows.Forms.GroupBox();
            this.ckbCasado = new System.Windows.Forms.CheckBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.gpbSexo.SuspendLayout();
            this.gpbCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbSalBruto
            // 
            this.mtbSalBruto.Location = new System.Drawing.Point(140, 59);
            this.mtbSalBruto.Mask = "00000.00";
            this.mtbSalBruto.Name = "mtbSalBruto";
            this.mtbSalBruto.Size = new System.Drawing.Size(162, 20);
            this.mtbSalBruto.TabIndex = 0;
            // 
            // mtbNumFilhos
            // 
            this.mtbNumFilhos.Location = new System.Drawing.Point(140, 85);
            this.mtbNumFilhos.Mask = "09";
            this.mtbNumFilhos.Name = "mtbNumFilhos";
            this.mtbNumFilhos.Size = new System.Drawing.Size(162, 20);
            this.mtbNumFilhos.TabIndex = 0;
            // 
            // mtbAliqIrpf
            // 
            this.mtbAliqIrpf.Enabled = false;
            this.mtbAliqIrpf.Location = new System.Drawing.Point(140, 280);
            this.mtbAliqIrpf.Name = "mtbAliqIrpf";
            this.mtbAliqIrpf.Size = new System.Drawing.Size(162, 20);
            this.mtbAliqIrpf.TabIndex = 0;
            // 
            // mtbAliqInss
            // 
            this.mtbAliqInss.Enabled = false;
            this.mtbAliqInss.Location = new System.Drawing.Point(140, 250);
            this.mtbAliqInss.Name = "mtbAliqInss";
            this.mtbAliqInss.Size = new System.Drawing.Size(162, 20);
            this.mtbAliqInss.TabIndex = 0;
            // 
            // mtbSalLiquido
            // 
            this.mtbSalLiquido.Enabled = false;
            this.mtbSalLiquido.Location = new System.Drawing.Point(140, 344);
            this.mtbSalLiquido.Name = "mtbSalLiquido";
            this.mtbSalLiquido.Size = new System.Drawing.Size(162, 20);
            this.mtbSalLiquido.TabIndex = 0;
            // 
            // mtbDescIrpf
            // 
            this.mtbDescIrpf.Enabled = false;
            this.mtbDescIrpf.Location = new System.Drawing.Point(397, 278);
            this.mtbDescIrpf.Name = "mtbDescIrpf";
            this.mtbDescIrpf.Size = new System.Drawing.Size(117, 20);
            this.mtbDescIrpf.TabIndex = 0;
            // 
            // mtbDescInss
            // 
            this.mtbDescInss.Enabled = false;
            this.mtbDescInss.Location = new System.Drawing.Point(397, 250);
            this.mtbDescInss.Name = "mtbDescInss";
            this.mtbDescInss.Size = new System.Drawing.Size(117, 20);
            this.mtbDescInss.TabIndex = 0;
            // 
            // mtbSalFamilia
            // 
            this.mtbSalFamilia.Enabled = false;
            this.mtbSalFamilia.Location = new System.Drawing.Point(140, 309);
            this.mtbSalFamilia.Name = "mtbSalFamilia";
            this.mtbSalFamilia.Size = new System.Drawing.Size(162, 20);
            this.mtbSalFamilia.TabIndex = 0;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(45, 32);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFuncionario.TabIndex = 1;
            this.lblNomeFuncionario.Text = "Nome Funcionario";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(67, 62);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Sálario Bruto";
            // 
            // lblNumeroFilhos
            // 
            this.lblNumeroFilhos.AutoSize = true;
            this.lblNumeroFilhos.Location = new System.Drawing.Point(45, 88);
            this.lblNumeroFilhos.Name = "lblNumeroFilhos";
            this.lblNumeroFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumeroFilhos.TabIndex = 1;
            this.lblNumeroFilhos.Text = "Numero de Filhos";
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(45, 254);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaInss.TabIndex = 1;
            this.lblAliquotaInss.Text = "Aliquota INSS";
            // 
            // lblAliquotaIrpf
            // 
            this.lblAliquotaIrpf.AutoSize = true;
            this.lblAliquotaIrpf.Location = new System.Drawing.Point(45, 281);
            this.lblAliquotaIrpf.Name = "lblAliquotaIrpf";
            this.lblAliquotaIrpf.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIrpf.TabIndex = 1;
            this.lblAliquotaIrpf.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(45, 310);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(74, 13);
            this.lblSalarioFamilia.TabIndex = 1;
            this.lblSalarioFamilia.Text = "Sálario Familia";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(45, 345);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioLiquido.TabIndex = 1;
            this.lblSalarioLiquido.Text = "Sálario Liquido";
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(310, 254);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoInss.TabIndex = 1;
            this.lblDescontoInss.Text = "Desconto INSS";
            // 
            // lblDescontoIrpf
            // 
            this.lblDescontoIrpf.AutoSize = true;
            this.lblDescontoIrpf.Location = new System.Drawing.Point(311, 285);
            this.lblDescontoIrpf.Name = "lblDescontoIrpf";
            this.lblDescontoIrpf.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIrpf.TabIndex = 1;
            this.lblDescontoIrpf.Text = "Desconto IRPF";
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(140, 107);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(162, 46);
            this.d.TabIndex = 2;
            this.d.Text = "Verifica Desconto";
            this.d.UseVisualStyleBackColor = true;
            this.d.Click += new System.EventHandler(this.d_Click);
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbM);
            this.gpbSexo.Controls.Add(this.rdbF);
            this.gpbSexo.Location = new System.Drawing.Point(314, 22);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(200, 79);
            this.gpbSexo.TabIndex = 3;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbM
            // 
            this.rdbM.AutoSize = true;
            this.rdbM.Location = new System.Drawing.Point(6, 42);
            this.rdbM.Name = "rdbM";
            this.rdbM.Size = new System.Drawing.Size(34, 17);
            this.rdbM.TabIndex = 0;
            this.rdbM.Text = "M";
            this.rdbM.UseVisualStyleBackColor = true;
            // 
            // rdbF
            // 
            this.rdbF.AutoSize = true;
            this.rdbF.Checked = true;
            this.rdbF.Location = new System.Drawing.Point(6, 19);
            this.rdbF.Name = "rdbF";
            this.rdbF.Size = new System.Drawing.Size(31, 17);
            this.rdbF.TabIndex = 0;
            this.rdbF.TabStop = true;
            this.rdbF.Text = "F";
            this.rdbF.UseVisualStyleBackColor = true;
            // 
            // gpbCasado
            // 
            this.gpbCasado.Controls.Add(this.ckbCasado);
            this.gpbCasado.Location = new System.Drawing.Point(314, 107);
            this.gpbCasado.Name = "gpbCasado";
            this.gpbCasado.Size = new System.Drawing.Size(200, 46);
            this.gpbCasado.TabIndex = 3;
            this.gpbCasado.TabStop = false;
            // 
            // ckbCasado
            // 
            this.ckbCasado.AutoSize = true;
            this.ckbCasado.Location = new System.Drawing.Point(6, 19);
            this.ckbCasado.Name = "ckbCasado";
            this.ckbCasado.Size = new System.Drawing.Size(62, 17);
            this.ckbCasado.TabIndex = 0;
            this.ckbCasado.Text = "Casado";
            this.ckbCasado.UseVisualStyleBackColor = true;
            // 
            // txbResult
            // 
            this.txbResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbResult.Enabled = false;
            this.txbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txbResult.Location = new System.Drawing.Point(17, 173);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ReadOnly = true;
            this.txbResult.Size = new System.Drawing.Size(497, 55);
            this.txbResult.TabIndex = 4;
            // 
            // mtbNome
            // 
            this.mtbNome.Location = new System.Drawing.Point(141, 30);
            this.mtbNome.Mask = "???????????????????????????????";
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(162, 20);
            this.mtbNome.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 399);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.gpbCasado);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.d);
            this.Controls.Add(this.lblDescontoIrpf);
            this.Controls.Add(this.lblDescontoInss);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIrpf);
            this.Controls.Add(this.lblAliquotaInss);
            this.Controls.Add(this.lblNumeroFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.mtbSalFamilia);
            this.Controls.Add(this.mtbDescInss);
            this.Controls.Add(this.mtbDescIrpf);
            this.Controls.Add(this.mtbSalLiquido);
            this.Controls.Add(this.mtbAliqInss);
            this.Controls.Add(this.mtbAliqIrpf);
            this.Controls.Add(this.mtbNome);
            this.Controls.Add(this.mtbNumFilhos);
            this.Controls.Add(this.mtbSalBruto);
            this.Name = "frmMenu";
            this.Text = "Calculo de Descontos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbCasado.ResumeLayout(false);
            this.gpbCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbSalBruto;
        private System.Windows.Forms.MaskedTextBox mtbNumFilhos;
        private System.Windows.Forms.MaskedTextBox mtbAliqIrpf;
        private System.Windows.Forms.MaskedTextBox mtbAliqInss;
        private System.Windows.Forms.MaskedTextBox mtbSalLiquido;
        private System.Windows.Forms.MaskedTextBox mtbDescIrpf;
        private System.Windows.Forms.MaskedTextBox mtbDescInss;
        private System.Windows.Forms.MaskedTextBox mtbSalFamilia;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumeroFilhos;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaIrpf;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.Label lblDescontoIrpf;
        private System.Windows.Forms.Button d;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbM;
        private System.Windows.Forms.RadioButton rdbF;
        private System.Windows.Forms.GroupBox gpbCasado;
        private System.Windows.Forms.CheckBox ckbCasado;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.MaskedTextBox mtbNome;
    }
}

