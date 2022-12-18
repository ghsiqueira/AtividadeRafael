
namespace AtividadeRafael
{
    partial class EditarDadosMercadoria
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
            this.btnVoltarDadosCliente = new System.Windows.Forms.Button();
            this.lblcdMercadoria = new System.Windows.Forms.Label();
            this.txtCodMerc = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtualizarCadastro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.mskVal = new System.Windows.Forms.MaskedTextBox();
            this.mskVenda = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarDadosCliente
            // 
            this.btnVoltarDadosCliente.Location = new System.Drawing.Point(68, 317);
            this.btnVoltarDadosCliente.Name = "btnVoltarDadosCliente";
            this.btnVoltarDadosCliente.Size = new System.Drawing.Size(86, 29);
            this.btnVoltarDadosCliente.TabIndex = 79;
            this.btnVoltarDadosCliente.Text = "Voltar";
            this.btnVoltarDadosCliente.UseVisualStyleBackColor = true;
            this.btnVoltarDadosCliente.Click += new System.EventHandler(this.btnVoltarDadosCliente_Click);
            // 
            // lblcdMercadoria
            // 
            this.lblcdMercadoria.AutoSize = true;
            this.lblcdMercadoria.Location = new System.Drawing.Point(87, 95);
            this.lblcdMercadoria.Name = "lblcdMercadoria";
            this.lblcdMercadoria.Size = new System.Drawing.Size(162, 20);
            this.lblcdMercadoria.TabIndex = 78;
            this.lblcdMercadoria.Text = "Código da Mercadoria:";
            // 
            // txtCodMerc
            // 
            this.txtCodMerc.Location = new System.Drawing.Point(255, 92);
            this.txtCodMerc.Name = "txtCodMerc";
            this.txtCodMerc.Size = new System.Drawing.Size(54, 27);
            this.txtCodMerc.TabIndex = 77;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 90);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 31);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtualizarCadastro
            // 
            this.btnAtualizarCadastro.Location = new System.Drawing.Point(208, 317);
            this.btnAtualizarCadastro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAtualizarCadastro.Name = "btnAtualizarCadastro";
            this.btnAtualizarCadastro.Size = new System.Drawing.Size(86, 29);
            this.btnAtualizarCadastro.TabIndex = 61;
            this.btnAtualizarCadastro.Text = "Atualizar";
            this.btnAtualizarCadastro.UseVisualStyleBackColor = true;
            this.btnAtualizarCadastro.Click += new System.EventHandler(this.btnAtualizarCadastro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(351, 316);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(86, 31);
            this.btnExcluir.TabIndex = 60;
            this.btnExcluir.Text = "Excluir Cadastro";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // mskVal
            // 
            this.mskVal.Location = new System.Drawing.Point(143, 175);
            this.mskVal.Mask = "00/00/0000";
            this.mskVal.Name = "mskVal";
            this.mskVal.Size = new System.Drawing.Size(87, 27);
            this.mskVal.TabIndex = 87;
            // 
            // mskVenda
            // 
            this.mskVenda.Location = new System.Drawing.Point(143, 262);
            this.mskVenda.Mask = "$00,00";
            this.mskVenda.Name = "mskVenda";
            this.mskVenda.Size = new System.Drawing.Size(87, 27);
            this.mskVenda.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 85;
            this.label3.Text = "Valor de Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Fornecedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Validade:";
            // 
            // txtForn
            // 
            this.txtForn.Location = new System.Drawing.Point(143, 219);
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(294, 27);
            this.txtForn.TabIndex = 82;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 131);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 27);
            this.txtNome.TabIndex = 81;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(87, 134);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 80;
            this.lblNome.Text = "Nome:";
            // 
            // EditarDadosMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 395);
            this.Controls.Add(this.mskVal);
            this.Controls.Add(this.mskVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtForn);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnVoltarDadosCliente);
            this.Controls.Add(this.lblcdMercadoria);
            this.Controls.Add(this.txtCodMerc);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtualizarCadastro);
            this.Controls.Add(this.btnExcluir);
            this.Name = "EditarDadosMercadoria";
            this.Text = "EditarDadosMercadoria";
            this.Load += new System.EventHandler(this.EditarDadosMercadoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarDadosCliente;
        private System.Windows.Forms.Label lblcdMercadoria;
        private System.Windows.Forms.TextBox txtCodMerc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtualizarCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox mskVal;
        private System.Windows.Forms.MaskedTextBox mskVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}