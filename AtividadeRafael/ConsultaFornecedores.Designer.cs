
namespace AtividadeRafael
{
    partial class ConsultaFornecedores
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
            this.btnVoltarConsultaFornecedores = new System.Windows.Forms.Button();
            this.lblConsultaFornecedores = new System.Windows.Forms.Label();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarConsultaFornecedores
            // 
            this.btnVoltarConsultaFornecedores.Location = new System.Drawing.Point(360, 382);
            this.btnVoltarConsultaFornecedores.Name = "btnVoltarConsultaFornecedores";
            this.btnVoltarConsultaFornecedores.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarConsultaFornecedores.TabIndex = 11;
            this.btnVoltarConsultaFornecedores.Text = "Voltar";
            this.btnVoltarConsultaFornecedores.UseVisualStyleBackColor = true;
            this.btnVoltarConsultaFornecedores.Click += new System.EventHandler(this.btnVoltarConsultaFornecedores_Click);
            // 
            // lblConsultaFornecedores
            // 
            this.lblConsultaFornecedores.AutoSize = true;
            this.lblConsultaFornecedores.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaFornecedores.Location = new System.Drawing.Point(205, 39);
            this.lblConsultaFornecedores.Name = "lblConsultaFornecedores";
            this.lblConsultaFornecedores.Size = new System.Drawing.Size(446, 33);
            this.lblConsultaFornecedores.TabIndex = 10;
            this.lblConsultaFornecedores.Text = "Consultar Fornecedores";
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Location = new System.Drawing.Point(135, 102);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.RowHeadersWidth = 51;
            this.dgvConsultaCliente.RowTemplate.Height = 29;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(531, 245);
            this.dgvConsultaCliente.TabIndex = 9;
            // 
            // ConsultaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarConsultaFornecedores);
            this.Controls.Add(this.lblConsultaFornecedores);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "ConsultaFornecedores";
            this.Text = "ConsultaFornecedores";
            this.Load += new System.EventHandler(this.ConsultaFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarConsultaFornecedores;
        private System.Windows.Forms.Label lblConsultaFornecedores;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
    }
}