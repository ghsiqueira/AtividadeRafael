
namespace AtividadeRafael
{
    partial class CadastroMercadoria
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
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnVoltarCadastroCliente = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskVenda = new System.Windows.Forms.MaskedTextBox();
            this.mskVal = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(243, 215);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(114, 30);
            this.btnCadastrarCliente.TabIndex = 51;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnVoltarCadastroCliente
            // 
            this.btnVoltarCadastroCliente.Location = new System.Drawing.Point(363, 216);
            this.btnVoltarCadastroCliente.Name = "btnVoltarCadastroCliente";
            this.btnVoltarCadastroCliente.Size = new System.Drawing.Size(114, 29);
            this.btnVoltarCadastroCliente.TabIndex = 50;
            this.btnVoltarCadastroCliente.Text = "Voltar";
            this.btnVoltarCadastroCliente.UseVisualStyleBackColor = true;
            this.btnVoltarCadastroCliente.Click += new System.EventHandler(this.btnVoltarCadastroCliente_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(131, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 27);
            this.txtNome.TabIndex = 45;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(75, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 39;
            this.lblNome.Text = "Nome:";
            // 
            // txtForn
            // 
            this.txtForn.Location = new System.Drawing.Point(131, 174);
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(294, 27);
            this.txtForn.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Validade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Valor de Venda:";
            // 
            // mskVenda
            // 
            this.mskVenda.Location = new System.Drawing.Point(131, 217);
            this.mskVenda.Mask = "$00,00";
            this.mskVenda.Name = "mskVenda";
            this.mskVenda.Size = new System.Drawing.Size(87, 27);
            this.mskVenda.TabIndex = 58;
            // 
            // mskVal
            // 
            this.mskVal.Location = new System.Drawing.Point(131, 130);
            this.mskVal.Mask = "00/00/0000";
            this.mskVal.Name = "mskVal";
            this.mskVal.Size = new System.Drawing.Size(87, 27);
            this.mskVal.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(87, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 33);
            this.label4.TabIndex = 60;
            this.label4.Text = "Cadastrar Produto";
            // 
            // CadastroMercadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 276);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskVal);
            this.Controls.Add(this.mskVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtForn);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.btnVoltarCadastroCliente);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroMercadoria";
            this.Text = "CadastroMercadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnVoltarCadastroCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskVenda;
        private System.Windows.Forms.MaskedTextBox mskVal;
        private System.Windows.Forms.Label label4;
    }
}