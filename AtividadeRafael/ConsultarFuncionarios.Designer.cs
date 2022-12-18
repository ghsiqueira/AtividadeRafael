
namespace AtividadeRafael
{
    partial class ConsultarFuncionarios
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
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.dgvConsultaCliente = new System.Windows.Forms.DataGridView();
            this.btnVoltarConsultarFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultaCliente.Location = new System.Drawing.Point(205, 44);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(442, 33);
            this.lblConsultaCliente.TabIndex = 7;
            this.lblConsultaCliente.Text = "Consultar Funcionários";
            // 
            // dgvConsultaCliente
            // 
            this.dgvConsultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCliente.Location = new System.Drawing.Point(135, 107);
            this.dgvConsultaCliente.Name = "dgvConsultaCliente";
            this.dgvConsultaCliente.RowHeadersWidth = 51;
            this.dgvConsultaCliente.RowTemplate.Height = 29;
            this.dgvConsultaCliente.Size = new System.Drawing.Size(531, 245);
            this.dgvConsultaCliente.TabIndex = 6;
            // 
            // btnVoltarConsultarFunc
            // 
            this.btnVoltarConsultarFunc.Location = new System.Drawing.Point(360, 387);
            this.btnVoltarConsultarFunc.Name = "btnVoltarConsultarFunc";
            this.btnVoltarConsultarFunc.Size = new System.Drawing.Size(94, 29);
            this.btnVoltarConsultarFunc.TabIndex = 8;
            this.btnVoltarConsultarFunc.Text = "Voltar";
            this.btnVoltarConsultarFunc.UseVisualStyleBackColor = true;
            this.btnVoltarConsultarFunc.Click += new System.EventHandler(this.btnVoltarConsultarFunc_Click);
            // 
            // ConsultarFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarConsultarFunc);
            this.Controls.Add(this.lblConsultaCliente);
            this.Controls.Add(this.dgvConsultaCliente);
            this.Name = "ConsultarFuncionarios";
            this.Text = "ConsultarFuncionarios";
            this.Load += new System.EventHandler(this.ConsultarFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblConsultaCliente;
        private System.Windows.Forms.DataGridView dgvConsultaCliente;
        private System.Windows.Forms.Button btnVoltarConsultarFunc;
    }
}