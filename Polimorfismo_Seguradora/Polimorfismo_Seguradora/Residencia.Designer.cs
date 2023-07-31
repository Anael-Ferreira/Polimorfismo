namespace Polimorfismo_Seguradora
{
    partial class Residencia
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
            this.components = new System.ComponentModel.Container();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblbairro = new System.Windows.Forms.Label();
            this.lblendereco = new System.Windows.Forms.Label();
            this.lbluf = new System.Windows.Forms.Label();
            this.lblcidade = new System.Windows.Forms.Label();
            this.lblmunicipio = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.DTime = new System.Windows.Forms.DateTimePicker();
            this.lblValorBem = new System.Windows.Forms.Label();
            this.lblValorApolice = new System.Windows.Forms.Label();
            this.lblValorPremio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCodSeguranca = new System.Windows.Forms.Label();
            this.lblNumApolice = new System.Windows.Forms.Label();
            this.txtValorPremio = new System.Windows.Forms.TextBox();
            this.txtValorBem = new System.Windows.Forms.TextBox();
            this.txtCodSeguranca = new System.Windows.Forms.TextBox();
            this.txtValorApolice = new System.Windows.Forms.TextBox();
            this.txtNumApolice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(42, 248);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(184, 20);
            this.txtUF.TabIndex = 0;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(49, 112);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(177, 20);
            this.txtCEP.TabIndex = 1;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(74, 179);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(152, 20);
            this.txtMunicipio.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(74, 80);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(152, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(55, 145);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 20);
            this.txtBairro.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(61, 213);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(165, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Residência:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(12, 119);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(31, 13);
            this.lblcep.TabIndex = 7;
            this.lblcep.Text = "CEP:";
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(12, 152);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(37, 13);
            this.lblbairro.TabIndex = 8;
            this.lblbairro.Text = "Bairro:";
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(12, 87);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(56, 13);
            this.lblendereco.TabIndex = 9;
            this.lblendereco.Text = "Endereço:";
            this.lblendereco.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(12, 255);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(24, 13);
            this.lbluf.TabIndex = 10;
            this.lbluf.Text = "UF:";
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(12, 220);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(43, 13);
            this.lblcidade.TabIndex = 11;
            this.lblcidade.Text = "Cidade:";
            // 
            // lblmunicipio
            // 
            this.lblmunicipio.AutoSize = true;
            this.lblmunicipio.Location = new System.Drawing.Point(12, 186);
            this.lblmunicipio.Name = "lblmunicipio";
            this.lblmunicipio.Size = new System.Drawing.Size(57, 13);
            this.lblmunicipio.TabIndex = 12;
            this.lblmunicipio.Text = "Município:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(42, 330);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(119, 71);
            this.btnVerificar.TabIndex = 55;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // DTime
            // 
            this.DTime.Location = new System.Drawing.Point(565, 197);
            this.DTime.Name = "DTime";
            this.DTime.Size = new System.Drawing.Size(211, 20);
            this.DTime.TabIndex = 69;
            // 
            // lblValorBem
            // 
            this.lblValorBem.AutoSize = true;
            this.lblValorBem.Location = new System.Drawing.Point(526, 250);
            this.lblValorBem.Name = "lblValorBem";
            this.lblValorBem.Size = new System.Drawing.Size(72, 13);
            this.lblValorBem.TabIndex = 68;
            this.lblValorBem.Text = "Valor do bem:";
            // 
            // lblValorApolice
            // 
            this.lblValorApolice.AutoSize = true;
            this.lblValorApolice.Location = new System.Drawing.Point(526, 126);
            this.lblValorApolice.Name = "lblValorApolice";
            this.lblValorApolice.Size = new System.Drawing.Size(86, 13);
            this.lblValorApolice.TabIndex = 67;
            this.lblValorApolice.Text = "Valor da apólice:";
            // 
            // lblValorPremio
            // 
            this.lblValorPremio.AutoSize = true;
            this.lblValorPremio.Location = new System.Drawing.Point(526, 293);
            this.lblValorPremio.Name = "lblValorPremio";
            this.lblValorPremio.Size = new System.Drawing.Size(83, 13);
            this.lblValorPremio.TabIndex = 66;
            this.lblValorPremio.Text = "Valor do prêmio:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(526, 203);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 65;
            this.lblData.Text = "Data:";
            // 
            // lblCodSeguranca
            // 
            this.lblCodSeguranca.AutoSize = true;
            this.lblCodSeguranca.Location = new System.Drawing.Point(526, 166);
            this.lblCodSeguranca.Name = "lblCodSeguranca";
            this.lblCodSeguranca.Size = new System.Drawing.Size(111, 13);
            this.lblCodSeguranca.TabIndex = 64;
            this.lblCodSeguranca.Text = "Código da segurança:";
            // 
            // lblNumApolice
            // 
            this.lblNumApolice.AutoSize = true;
            this.lblNumApolice.Location = new System.Drawing.Point(526, 87);
            this.lblNumApolice.Name = "lblNumApolice";
            this.lblNumApolice.Size = new System.Drawing.Size(100, 13);
            this.lblNumApolice.TabIndex = 63;
            this.lblNumApolice.Text = "Número da Apólice:";
            // 
            // txtValorPremio
            // 
            this.txtValorPremio.Location = new System.Drawing.Point(618, 286);
            this.txtValorPremio.Name = "txtValorPremio";
            this.txtValorPremio.Size = new System.Drawing.Size(158, 20);
            this.txtValorPremio.TabIndex = 62;
            // 
            // txtValorBem
            // 
            this.txtValorBem.Location = new System.Drawing.Point(604, 243);
            this.txtValorBem.Name = "txtValorBem";
            this.txtValorBem.Size = new System.Drawing.Size(172, 20);
            this.txtValorBem.TabIndex = 61;
            // 
            // txtCodSeguranca
            // 
            this.txtCodSeguranca.Location = new System.Drawing.Point(643, 159);
            this.txtCodSeguranca.Name = "txtCodSeguranca";
            this.txtCodSeguranca.Size = new System.Drawing.Size(133, 20);
            this.txtCodSeguranca.TabIndex = 60;
            // 
            // txtValorApolice
            // 
            this.txtValorApolice.Location = new System.Drawing.Point(618, 119);
            this.txtValorApolice.Name = "txtValorApolice";
            this.txtValorApolice.Size = new System.Drawing.Size(158, 20);
            this.txtValorApolice.TabIndex = 59;
            // 
            // txtNumApolice
            // 
            this.txtNumApolice.Location = new System.Drawing.Point(632, 80);
            this.txtNumApolice.Name = "txtNumApolice";
            this.txtNumApolice.Size = new System.Drawing.Size(144, 20);
            this.txtNumApolice.TabIndex = 58;
            // 
            // Residencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTime);
            this.Controls.Add(this.lblValorBem);
            this.Controls.Add(this.lblValorApolice);
            this.Controls.Add(this.lblValorPremio);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCodSeguranca);
            this.Controls.Add(this.lblNumApolice);
            this.Controls.Add(this.txtValorPremio);
            this.Controls.Add(this.txtValorBem);
            this.Controls.Add(this.txtCodSeguranca);
            this.Controls.Add(this.txtValorApolice);
            this.Controls.Add(this.txtNumApolice);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblmunicipio);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtUF);
            this.Name = "Residencia";
            this.Text = "Residencia";
            this.Load += new System.EventHandler(this.Residencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.Label lblmunicipio;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.DateTimePicker DTime;
        private System.Windows.Forms.Label lblValorBem;
        private System.Windows.Forms.Label lblValorApolice;
        private System.Windows.Forms.Label lblValorPremio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCodSeguranca;
        private System.Windows.Forms.Label lblNumApolice;
        private System.Windows.Forms.TextBox txtValorPremio;
        private System.Windows.Forms.TextBox txtValorBem;
        private System.Windows.Forms.TextBox txtCodSeguranca;
        private System.Windows.Forms.TextBox txtValorApolice;
        private System.Windows.Forms.TextBox txtNumApolice;
    }
}