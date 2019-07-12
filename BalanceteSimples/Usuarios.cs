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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            preencheTabelaUsuario();

            dgUsuarios.BorderStyle = BorderStyle.None;
            dgUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgUsuarios.BackgroundColor = Color.White;

            dgUsuarios.EnableHeadersVisualStyles = false;
            dgUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgUsuarios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgUsuarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgUsuarios.Columns["columnUsuario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgUsuarios.Columns["columnSenha"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgUsuarios.Columns["columnDataCadastro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgUsuarios.Columns["columnExcluir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            ///defininindo o tamanho das colunas
            dgUsuarios.Columns["columnUsuario"].Width = 120;
            dgUsuarios.Columns["columnSenha"].Width = 250;
            dgUsuarios.Columns["columnDataCadastro"].Width = 110;
            dgUsuarios.Columns["columnExcluir"].Width = 50;
            dgUsuarios.AllowUserToAddRows = false;
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=balancetesimples;sslMode=none;");

        private void preencheTabelaUsuario()
        {
            conexao.Open(); //abre a conexao
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT*FROM usuarios ORDER BY data_cadastro DESC", conexao);  //cria o componente para buscar os dados do banco
            DataTable dt = new DataTable(); //cria uma tabela de dados
            da.Fill(dt); //preenche a tabela com os dados do banco de dados
            dgUsuarios.DataSource = dt; //mostra os dados da tabela na tela
            conexao.Close(); //fecha a conexao
        }

        private void limpar()
        {
            txtConfirmaSenha.Clear();
            txtSenha.Clear();
            txtUsuario.Clear();
        }
        private void cadastraUsuario(string user, string pass)
        {
            if (MessageBox.Show("Atenção, após o usuário logar no sistema não será possível a exclusão do mesmo. \nDeseja realmente continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conexao.Open();
                string sql = string.Format("INSERT INTO usuarios VALUES('{0}',SHA1('{1}'),NOW(),false)", user, pass);
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.ExecuteNonQuery();
                limpar();
                conexao.Close();
                preencheTabelaUsuario();
            }
        }

        private bool verificaUsuarioIgual(string usuario)
        {
            conexao.Open();
            string sql = string.Format("SELECT*FROM usuarios WHERE usuario= '{0}'", usuario);
            MySqlCommand comandosql = new MySqlCommand(sql, conexao);

            var achou = comandosql.ExecuteScalar();
            conexao.Close();
            if (achou is null)
                return true;
            else
                return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            string confirmaSenha = txtConfirmaSenha.Text;

            //Aplica validações 
            if (usuario == "" || senha == "" || confirmaSenha == "")
                MessageBox.Show("Preencha todos os campos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (senha.Length < 5 || confirmaSenha.Length < 5)
                MessageBox.Show("Os campos de senha devem ter pelo menos 5 caracteres!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (senha != confirmaSenha)
                MessageBox.Show("As senhas informadas não são iguais!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!verificaUsuarioIgual(usuario))
                MessageBox.Show("Já existe usuário cadastrado com esse nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                cadastraUsuario(usuario, senha);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void deletarUsuario(string usuario)
        {
            conexao.Open();
            string sql = string.Format("DELETE FROM usuarios WHERE usuario = '{0}';", usuario);
            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            comandosql.ExecuteNonQuery();
            conexao.Close();
        }

        private bool podeApagarUsuario(string usuario)
        {
            conexao.Open();
            string sql = string.Format("SELECT logou FROM usuarios WHERE usuario = '{0}';", usuario);
            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            
            var podeApagarUsuario = comandosql.ExecuteScalar();
            conexao.Close();
            if (podeApagarUsuario is false) //nunca logou
                return true;
            else
                return false;
        }

        private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CERTIFICA QUE O USUÁRIO NÃO CLICOU NO HEADER
            if (e.RowIndex != -1)
            {
                string usuario = dgUsuarios.Rows[e.RowIndex].Cells["columnUsuario"].Value.ToString();
                //VERIFICANDO SE A COLUNA DE EXCLUIR FOI CLICADA
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("Deseja Realmente Excluir", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        /*VERIFICAR SE O USUÁRIO JÁ LOGOU NO SISTEMA*/
                        if (!podeApagarUsuario(usuario))
                        {
                            MessageBox.Show("Não é possível remover o usuário, \npois o mesmo já acessou o sistema mais de uma vez", "OPS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            deletarUsuario(usuario);
                            preencheTabelaUsuario();
                            MessageBox.Show("Usuário deletado!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
