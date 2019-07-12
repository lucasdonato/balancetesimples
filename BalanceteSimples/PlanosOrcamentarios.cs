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
    public partial class PlanosOrcamentarios : Form
    {
        MenuPrincipal menu = new MenuPrincipal();

        public PlanosOrcamentarios()
        {

            InitializeComponent();
            this.BackColor = Color.FromArgb(225, 234, 243);

            tabela.BorderStyle = BorderStyle.None;
            tabela.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tabela.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabela.BackgroundColor = Color.White;

            tabela.EnableHeadersVisualStyles = false;
            tabela.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabela.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tabela.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabela.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //CENTRALIZAR CONTEÚDO COLUNAS
            tabela.Columns["columnNome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabela.Columns["columnExcluir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabela.Columns["columnTipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AtualizarGridView();
            tabela.Columns["columnID"].Visible = false;
            tabela.Columns["columnExcluir"].DisplayIndex = 3;

            //ESCONDE A ÚLTIMA LINHA EM BRANCO
            tabela.AllowUserToAddRows = false;
        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=balancetesimples;sslMode=none;");

        public void AtualizarGridView()
        {
            conexao.Open(); //abre a conexao
            MySqlDataAdapter da = new MySqlDataAdapter("select id_natureza,nome,IF(tipo='S', 'SAÍDA', 'ENTRADA') as tipo from  natureza_operacao order by id_natureza desc", conexao);  //cria o componente para buscar os dados do banco
            DataTable dt = new DataTable(); //cria uma tabela de dados
            da.Fill(dt); //preenche a tabela com os dados do banco de dados
            tabela.DataSource = dt; //mostra os dados da tabela na tela
            conexao.Close(); //fecha a conexao

        }

        public bool buscaPlanoIgual(string nomePlano)
        {
            bool existe=false;
            conexao.Open();
            string sql = string.Format("SELECT*FROM natureza_operacao WHERE nome = '{0}';", nomePlano);

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            MySqlDataReader adapter = comandosql.ExecuteReader();

            if (adapter.HasRows)
            {
                existe = true;
            }
                conexao.Close();

            return existe;
        }

        private void inserir()
        {
            
            if (MessageBox.Show("Cadastrar plano?", "Confirmaçao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                /*ANTES DE CADASTRAR, VERIFICO SE JÁ EXISTE UM PLANO COM O MESMO NOME*/
                bool existe =  buscaPlanoIgual(txtDescricao.Text);
                if (existe)
                {
                    MessageBox.Show("Já existe um plano com esse nome!", "Não foi possível cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    char tipo = ' ';
                    if (rdbEntrada.Checked)
                    {
                        tipo = 'E';
                    }
                    else
                    {
                        tipo = 'S';

                    }

                    string sql = string.Format("insert into natureza_operacao values (null,'{0}','{1}');",txtDescricao.Text,tipo);
                    menu.ExecutarComandoSQL(sql);
                    MessageBox.Show("Plano cadastrado", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarGridView();
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || (rdbEntrada.Checked == false && rdbSaida.Checked == false))
            {
                MessageBox.Show("Preencha todos os campos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                inserir();
                txtDescricao.Clear();
            }
        }

        public void deletar(int id_plano)
        {
            try
            {
                conexao.Open();
                string sql = string.Format("DELETE FROM natureza_operacao where id_natureza = '{0}';", id_plano);
            
                MySqlCommand comandosql = new MySqlCommand(sql, conexao);
                comandosql.ExecuteNonQuery(); 
                MessageBox.Show("Registro deletado!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexao.Close();
                AtualizarGridView();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Não é possível apagar itens com vínculos!!!\n\n\n\n" + ex.Message, "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);
                conexao.Close();
            }
        }

        private void tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CERTIFICA QUE O USUÁRIO NÃO CLICOU NO HEADER
            if (e.RowIndex != -1)
            {
                int id_plano = Convert.ToInt32(tabela.Rows[e.RowIndex].Cells["columnID"].Value.ToString());

                //VERIFICANDO SE A COLUNA DE EXCLUIR FOI CLICADA
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("Deseja Realmente Excluir", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        deletar(id_plano);
                    }
                
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
