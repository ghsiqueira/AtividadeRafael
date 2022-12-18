
namespace AtividadeRafael
{
    partial class TelaInicial
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMercadoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDeletarMercadoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mercadoriaToolStripMenuItem,
            this.funcionáriosToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.logoffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mercadoriaToolStripMenuItem
            // 
            this.mercadoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarMercadoriaToolStripMenuItem,
            this.consultarMercadoriasToolStripMenuItem,
            this.editarDeletarMercadoriasToolStripMenuItem});
            this.mercadoriaToolStripMenuItem.Name = "mercadoriaToolStripMenuItem";
            this.mercadoriaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.mercadoriaToolStripMenuItem.Text = "Mercadorias";
            // 
            // cadastrarMercadoriaToolStripMenuItem
            // 
            this.cadastrarMercadoriaToolStripMenuItem.Name = "cadastrarMercadoriaToolStripMenuItem";
            this.cadastrarMercadoriaToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.cadastrarMercadoriaToolStripMenuItem.Text = "Cadastrar Mercadoria";
            this.cadastrarMercadoriaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMercadoriaToolStripMenuItem_Click);
            // 
            // consultarMercadoriasToolStripMenuItem
            // 
            this.consultarMercadoriasToolStripMenuItem.Name = "consultarMercadoriasToolStripMenuItem";
            this.consultarMercadoriasToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.consultarMercadoriasToolStripMenuItem.Text = "Consultar Mercadorias";
            this.consultarMercadoriasToolStripMenuItem.Click += new System.EventHandler(this.consultarMercadoriasToolStripMenuItem_Click);
            // 
            // editarDeletarMercadoriasToolStripMenuItem
            // 
            this.editarDeletarMercadoriasToolStripMenuItem.Name = "editarDeletarMercadoriasToolStripMenuItem";
            this.editarDeletarMercadoriasToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.editarDeletarMercadoriasToolStripMenuItem.Text = "Editar/Deletar Mercadorias";
            this.editarDeletarMercadoriasToolStripMenuItem.Click += new System.EventHandler(this.editarDeletarMercadoriasToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFuncionariosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            // 
            // consultarFuncionariosToolStripMenuItem
            // 
            this.consultarFuncionariosToolStripMenuItem.Name = "consultarFuncionariosToolStripMenuItem";
            this.consultarFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.consultarFuncionariosToolStripMenuItem.Text = "Consultar Funcionarios";
            this.consultarFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.consultarFuncionariosToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarFornecedoresToolStripMenuItem});
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // consultarFornecedoresToolStripMenuItem
            // 
            this.consultarFornecedoresToolStripMenuItem.Name = "consultarFornecedoresToolStripMenuItem";
            this.consultarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.consultarFornecedoresToolStripMenuItem.Text = "Consultar Fornecedores";
            this.consultarFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.consultarFornecedoresToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.logoffToolStripMenuItem.Text = "Logoff";
            this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMercadoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDeletarMercadoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFuncionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFornecedoresToolStripMenuItem;
    }
}