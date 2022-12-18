using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AtividadeRafael
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login abrirTelaLogin = new Login();
            abrirTelaLogin.Show();
            this.Hide();
        }

        private void cadastrarMercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMercadoria abrirTelaCadastroMercadoria = new CadastroMercadoria();
            abrirTelaCadastroMercadoria.Show();
            this.Hide();
        }

        private void consultarMercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarMercadorias abrirTelaConsultaMercadoria = new ConsultarMercadorias();
            abrirTelaConsultaMercadoria.Show();
            this.Hide();
        }

        private void editarDeletarMercadoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarDadosMercadoria abrirTelaEditarMercadoria = new EditarDadosMercadoria();
            abrirTelaEditarMercadoria.Show();
            this.Hide();
        }

        private void consultarFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarFuncionarios abrirTelaConsultaFuncionarios = new ConsultarFuncionarios();
            abrirTelaConsultaFuncionarios.Show();
            this.Hide();
        }

        private void consultarFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFornecedores abrirTelaConsultaFornecedores = new ConsultaFornecedores();
            abrirTelaConsultaFornecedores.Show();
            this.Hide();
        }
    }
}
