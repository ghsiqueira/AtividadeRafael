using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AtividadeRafael
{
    public partial class EditarDadosMercadoria : Form
    {
        public void limpar()
        {
            txtCodMerc.Text = "";
            txtNome.Text = "";
            mskVal.Text = " ";
            mskVenda.Text = " ";
            txtForn.Text = " ";
        }
        public EditarDadosMercadoria()
        {
            InitializeComponent();
        }

        private void EditarDadosMercadoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAtualizarCadastro_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=mercado;pwd='etec'");
            conexao.Open();
            MySqlCommand objCmd = new MySqlCommand("update mercadoria set nomeProduto = ?, validadeProduto = ?, nomeFornecedor = ?, vl_venda = ? where codProduto = ?", conexao);
            objCmd.Parameters.Clear();
            objCmd.Parameters.Add("@nomeProduto", MySqlDbType.VarChar, 50).Value = txtNome.Text;
            objCmd.Parameters.Add("@validadeProduto", MySqlDbType.VarChar, 20).Value = mskVal.Text;
            objCmd.Parameters.Add("@nomeFornecedor", MySqlDbType.VarChar, 20).Value = txtForn.Text;
            objCmd.Parameters.Add("@vl_venda", MySqlDbType.VarChar, 100).Value = mskVenda.Text;
            objCmd.Parameters.Add("@codProduto", MySqlDbType.Int32).Value = txtCodMerc.Text;
            objCmd.ExecuteNonQuery();
            conexao.Close();
            MessageBox.Show("Atualização realizada com sucesso!");
            limpar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=mercado;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("select nomeProduto, validadeProduto, nomeFornecedor, vl_venda from mercadoria where codProduto = ?", conexao);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@codProduto", MySqlDbType.Int32).Value = txtCodMerc.Text;
                objCmd.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                txtNome.Text = dr.GetString(0);
                mskVal.Text = dr.GetString(1);
                txtForn.Text = dr.GetString(2);
                mskVenda.Text = dr.GetString(3);
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Falha ao Buscar!");
            }
        }

        private void btnVoltarDadosCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultadoCaixaTexto = MessageBox.Show("Tem certeza que deseja excluir esse cadastro?", "Mercado", MessageBoxButtons.YesNo);
            if (resultadoCaixaTexto == DialogResult.Yes)
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=mercado;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("delete from mercadoria where codProduto = ?", conexao);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@codProduto", MySqlDbType.Int32).Value = txtCodMerc.Text;
                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Cadastro excluido com sucesso!");
                limpar();
            }
            else
            {
                MessageBox.Show("Cuidado!");
            }
        }
    }
}
