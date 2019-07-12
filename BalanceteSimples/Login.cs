using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BalanceteSimples
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=balancetesimples;sslMode=none;");

        public bool logar(string usuario, string senha)
        {
            conexao.Open();
            string sql = string.Format("SELECT*FROM usuarios WHERE usuario= '{0}' AND senha = SHA1('{1}')",usuario,senha);
            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            var logou = comandosql.ExecuteScalar();

            if (logou is null)
                return false;
            else
                return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void setaLogado(string usuario)
        {
            conexao.Close();
            conexao.Open();
            string sql = string.Format("UPDATE usuarios SET logou = TRUE WHERE usuario = '{0}'", usuario);
            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            comandosql.ExecuteNonQuery();
            conexao.Close();
        }

        private void validaLogin()
        {
            if (txtUsuario.Text == "" || txtSenha.Text == "")
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (logar(txtUsuario.Text, txtSenha.Text))
                {
                    /*SETA A FLAG LOGADO NO BD*/
                    setaLogado(txtUsuario.Text);
                    this.Close();
                    MenuPrincipal p = new MenuPrincipal();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            conexao.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            validaLogin();
        }

        //evento no campo senha ao pressionar ENTER
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                validaLogin();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                validaLogin();
        }
    }
}
