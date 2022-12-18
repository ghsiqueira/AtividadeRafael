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
    public partial class CadastroMercadoria : Form
    {
        public CadastroMercadoria()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=localhost;port=3306;User=root;database=mercado;pwd='etec'");
                conexao.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into mercadoria values(null, ?, ?, ?, ?)", conexao);
                objCmd.Parameters.Add("@nomeProduto", MySqlDbType.VarChar, 50).Value = txtNome.Text;
                objCmd.Parameters.Add("@validadeProduto", MySqlDbType.VarChar, 11).Value = mskVal.Text;
                objCmd.Parameters.Add("@nomeFornecedor", MySqlDbType.VarChar, 100).Value = txtForn.Text;
                objCmd.Parameters.Add("@vl_venda", MySqlDbType.VarChar, 50).Value = mskVenda.Text;
                objCmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("Produto Cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Não Cadastrado: ");
            }
        }

        private void btnVoltarCadastroCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }
    }
}
