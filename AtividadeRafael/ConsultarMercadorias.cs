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
    public partial class ConsultarMercadorias : Form
    {
        public ConsultarMercadorias()
        {
            InitializeComponent();
        }

        private void btnVoltarConsultaCliente_Click(object sender, EventArgs e)
        {
            TelaInicial abrirTelaInicial = new TelaInicial();
            abrirTelaInicial.Show();
            this.Hide();
        }

        private void ConsultarMercadorias_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string conexao = @"Server=localhost;Database=mercado;Uid=root;Pwd='etec'";
            MySqlConnection msConnection = new MySqlConnection(conexao);
            msConnection.Open();
            MySqlCommand msCommand = new MySqlCommand();
            msCommand.CommandText = "select * from mercadoria";
            msCommand.Connection = msConnection;
            MySqlDataAdapter msAdapter = new MySqlDataAdapter(msCommand);
            msAdapter.Fill(dt);
            dgvConsultaCliente.DataSource = dt;
        }
    }
}
