
namespace AtividadeRafael
{
    partial class ConsultarMercadorias
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
            this.btnVoltarConsultaCliente = new System.Windows.Forms.Button();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltarConsultaCliente
            // 
            this.btnVoltarConsultaCliente.Location = new System.Drawing.Point(357, 378);
            this.btnVoltarConsultaCliente.Name = "btnVoltarConsultaCliente";
            this.btnVoltarConsultaCliente.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarConsultaCliente.TabIndex = 5;
            this.btnVoltarConsultaCliente.Text = "Voltar";
            this.btnVoltarConsultaCliente.UseVisualStyleBackColor = true;
            this.btnVoltarConsultaCliente.Click += new System.EventHandler(this.btnVoltarConsultaCliente_Click);
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaCliente.Location = new System.Drawing.Point(204, 44);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(410, 33);
            this.lblConsultaCliente.TabIndex = 4;
            this.lblConsultaCliente.Text = "Consulta Mercadorias";
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Location = new System.Drawing.Point(134, 107);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.RowHeadersWidth = 51;
            this.dgvConsultaCliente.RowTemplate.Height = 29;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(531, 245);
            this.dgvConsultaCliente.TabIndex = 3;
            // 
            // ConsultarMercadorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarConsultaCliente);
            this.Controls.Add(this.lblConsultaCliente);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "ConsultarMercadorias";
            this.Text = "ConsultarMercadorias";
            this.Load += new System.EventHandler(this.ConsultarMercadorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarConsultaCliente;
        private System.Windows.Forms.Label lblConsultaCliente;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
    }
}