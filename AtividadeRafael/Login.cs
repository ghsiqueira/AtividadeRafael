using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeRafael
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("O usuário deve ser preenchido!");
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("A senha deve ser preenchido!");
            }
            else
            {

                if (txtUsuario.Text == "user" && txtSenha.Text == "user")
                {
                    TelaInicial abrirTelaInicial = new TelaInicial();
                    abrirTelaInicial.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    return;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saindo..");
            Close();
        }
    }
}