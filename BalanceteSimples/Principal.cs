using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BalanceteSimples
{

    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {
            InitializeComponent();

            //PERSONALIZANDO A TABELA FEIA
            tabelaPrincipal.BorderStyle = BorderStyle.None;
            tabelaPrincipal.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tabelaPrincipal.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelaPrincipal.BackgroundColor = Color.White;

            tabelaPrincipal.EnableHeadersVisualStyles = false;
            tabelaPrincipal.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabelaPrincipal.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tabelaPrincipal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabelaPrincipal.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //CENTRALIZAR CONTEÚDO COLUNAS
            tabelaPrincipal.Columns["columnDescricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnTipoConta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnExcluir"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnEditar"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnAcrescimo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnData"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnDesconto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnValor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnNatureza"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["columnTipoConta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["TipoNatureza"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaPrincipal.Columns["total_liquido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //PERSONALIZANDO TABELA LISTAGEM
            tabelaListagem.BorderStyle = BorderStyle.None;
            tabelaListagem.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tabelaListagem.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelaListagem.BackgroundColor = Color.White;

            tabelaListagem.EnableHeadersVisualStyles = false;
            tabelaListagem.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabelaListagem.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tabelaListagem.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabelaListagem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabelaListagem.Columns["DataLanc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaListagem.Columns["valortot"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaListagem.Columns["tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaListagem.Columns["nome2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //PERSONALIZANDO TABELA TOTAIS
            tabelaTotais.BorderStyle = BorderStyle.None;
            tabelaTotais.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            tabelaTotais.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tabelaTotais.BackgroundColor = Color.White;

            tabelaTotais.EnableHeadersVisualStyles = false;
            tabelaTotais.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tabelaTotais.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            tabelaTotais.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabelaTotais.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tabelaTotais.Columns["nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaTotais.Columns["Tipo2"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabelaTotais.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            abaCadastro.BackColor = Color.FromArgb(225, 234, 243);
            abadeConsultas.BackColor = Color.FromArgb(225, 234, 243);

            ///defininindo o tamanho das colunas
            tabelaPrincipal.Columns["columnDescricao"].Width = 200;
        }

        public void MenuPrincipal_Load(object sender, EventArgs e)
        {
            AtualizarGridView();
            carregaCombo();

            //escondendo a coluna do ID
            tabelaPrincipal.Columns["columnIDConta"].Visible = false;
            tabelaPrincipal.Columns["columnIDNatureza"].Visible = false;

            //ESCONDE A ÚLTIMA LINHA EM BRANCO
            tabelaPrincipal.AllowUserToAddRows = false;
            tabelaTotais.AllowUserToAddRows = false;
            tabelaListagem.AllowUserToAddRows = false;

        }

        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=balancetesimples;sslMode=none;");

        public void AtualizarGridView()
        {
            conexao.Open(); //abre a conexao
            MySqlDataAdapter da = new MySqlDataAdapter("select c.*,no.nome,IF(no.tipo='E','ENTRADA','SAIDA') as tipo from contas c join natureza_operacao no " +
                "on c.id_natureza = no.id_natureza ORDER BY c.id_conta DESC;", conexao);  //cria o componente para buscar os dados do banco
            DataTable dt = new DataTable(); //cria uma tabela de dados
            da.Fill(dt); //preenche a tabela com os dados do banco de dados
            tabelaPrincipal.DataSource = dt; //mostra os dados da tabela na tela
            conexao.Close(); //fecha a conexao

        }

        /*CARREGA OS COMBOBOX COM OS PLANOS
         CADASTROS NO BANCO DE DADOS*/
        public void carregaCombo()
        {
            conexao.Open(); //abre a conexao
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT id_natureza,nome FROM natureza_operacao", conexao);
            DataTable dt_comboBox = new DataTable();
            da.Fill(dt_comboBox);

            //carrega as informacoes no combo
            cmbNatureza.DataSource = dt_comboBox;
            cmbNatureza.DisplayMember = "nome";
            cmbNatureza.ValueMember = "id_natureza";

            conexao.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "" || txtValorTotal.Text == "" || (rdbCorrente.Checked == false && rdbPoupanca.Checked == false) || cmbNatureza.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtAcrescimo.Text == "")
                    txtAcrescimo.Text = "0,00";
                if (txtDesconto.Text == "")
                    txtDesconto.Text = "0,00";

                inserirConta();
            }
        }

        private void inserirConta()
        {
            //Verificando o tipo de conta selecionado.
            string conta = "";
            if (rdbCorrente.Checked)
                conta = "Corrente";
            else
                conta = "Poupança";

            //Obtendo o ID do plano orçamentário
            string plano_escolhido = cmbNatureza.SelectedValue.ToString();

            if (MessageBox.Show("Cadastrar lançamento?", "Confirmaçao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //valida se o total liquido é maior que 0
                if (Convert.ToDouble(txtTotalLiquido.Text) > 0)
                {
                    string sql = string.Format("insert into contas values (null,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');",
                    txtDescricao.Text, cmbNatureza.SelectedValue, conta, dataLancamento.Value.ToString("yyyy/MM/dd"), txtValorTotal.Text.Replace(',', '.'), txtAcrescimo.Text.Replace(',', '.'), txtDesconto.Text.Replace(',', '.'), txtTotalLiquido.Text.Replace(',', '.'));

                    ExecutarComandoSQL(sql);
                    MessageBox.Show("Lançamento cadastrado", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    AtualizarGridView();
                }
                else
                {
                    MessageBox.Show("O total líquido do lançamento não pode ser igual ou menor que $0,00", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void limpar()
        {
            txtAcrescimo.Clear();
            txtDesconto.Clear();
            txtDescricao.Clear();
            txtValorTotal.Clear();
            rdbCorrente.Checked = false;
            rdbPoupanca.Checked = false;
            dataLancamento.Value = DateTime.Now.Date;
            txtDescricao.Focus();
            txtValorTotal.Text = "0,00";
            txtAcrescimo.Text = "0,00";
            txtDesconto.Text = "0,00";
            txtTotalLiquido.Text = "0,00";
        }

        public void deletar(int id_conta)
        {
            string sql = string.Format("DELETE FROM contas where id_conta = '{0}';", id_conta);
            ExecutarComandoSQL(sql);
            AtualizarGridView();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();

        }

        public void ExecutarComandoSQL(string sql)
        {

            conexao.Open();
            MySqlCommand comandosql = new MySqlCommand(sql, conexao); //cria um comando de query sql
            comandosql.ExecuteNonQuery(); // executa a query
            conexao.Close();
        }

        /*MEODO PARA FAZER A BUSCA CONFORME O DIGITADO PELO USUÁRIO*/
        private void buscaGeral()
        {
            conexao.Open();

            string sql = string.Format("select c.*,no.nome,IF(no.tipo='E','ENTRADA','SAIDA') as tipo from contas c join natureza_operacao no on c.id_natureza = no.id_natureza WHERE c.descricao_conta LIKE '%{0}%';", txtBuscaGeral.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tabelaPrincipal.DataSource = dt;
            conexao.Close();
        }

        //AÇÃO QUANDO A BUSCA FOR FEITA CLICANDO NA LUPA
        private void lblPesquisaGeral_Click(object sender, EventArgs e)
        {
            if (txtBuscaGeral.TextLength <= 0)
                MessageBox.Show("Insira um valor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                buscaGeral();
        }

        private void txtBuscaDescricao(object sender, KeyEventArgs e)
        {
            if (txtBuscaGeral.TextLength <= 0)
                AtualizarGridView();
            else
                buscaGeral();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            encerrar();
        }

        //EVENTO DISPARADO AO CLICAR NAS COLUNAS DAS TABELAS
        private void tabelaPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //CERTIFICA QUE O USUÁRIO NÃO CLICOU NO HEADER
            if (e.RowIndex != -1)
            {
                int id_conta = Convert.ToInt32(tabelaPrincipal.Rows[e.RowIndex].Cells["columnIdConta"].Value.ToString());

                //VERIFICANDO SE A COLUNA DE EXCLUIR FOI CLICADA
                if (e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Deseja Realmente Excluir", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        MessageBox.Show("Registro deletado!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deletar(id_conta);
                    }
                }
                //VERIFICANDO SE A COLUNA DE EDITAR FOI CLICADA
                else if (e.ColumnIndex == 0)
                {

                    try
                    {
                        int id;
                        string descricao;
                        string tipo;
                        DateTime data = new DateTime();
                        double total;
                        double acrescimo;
                        double desconto;
                        double total_liquido;


                        id = Convert.ToInt32(tabelaPrincipal.Rows[e.RowIndex].Cells["columnIdConta"].Value.ToString());
                        descricao = tabelaPrincipal.Rows[e.RowIndex].Cells["columnDescricao"].Value.ToString();
                        data = Convert.ToDateTime(tabelaPrincipal.Rows[e.RowIndex].Cells["columnData"].Value.ToString());
                        total = Convert.ToDouble(tabelaPrincipal.Rows[e.RowIndex].Cells["columnValor"].Value.ToString());
                        desconto = Convert.ToDouble(tabelaPrincipal.Rows[e.RowIndex].Cells["columnDesconto"].Value.ToString());
                        acrescimo = Convert.ToDouble(tabelaPrincipal.Rows[e.RowIndex].Cells["columnAcrescimo"].Value.ToString());
                        total_liquido = Convert.ToDouble(tabelaPrincipal.Rows[e.RowIndex].Cells["total_liquido"].Value.ToString());

                        if (tabelaPrincipal.Rows[e.RowIndex].Cells["columnTipoConta"].Value.ToString() == "Corrente")
                            tipo = "Corrente";
                        else
                            tipo = "Poupança";

                        //PASSANDO VALORES DAS VÁRIAVEIS PELO CONSTRUTOR
                        EditarLancamentos editar = new EditarLancamentos(id, descricao, tipo, data, total, desconto, acrescimo, total_liquido);

                        /*NECESSÁRIO UTILIZAR O SHOWDIALOG
                         ELE VAI BLOQUEAR O FORM PAI E NÃO EXECUTA O RESTO
                         DO CÓDIGO ATUALIZANDO A TABELA
                         ENQUANTO O DIALOG NÃO FOR ENCEERRADO*/
                        editar.ShowDialog();
                        AtualizarGridView();

                    }
                    catch (Exception ex)
                    {
                        //caso o usuário clique no header, o catch não da pau.
                    }
                }
            }

        }

        private void MenuPlano_Click(object sender, EventArgs e)
        {
            PlanosOrcamentarios plano = new PlanosOrcamentarios();
            plano.ShowDialog();
            carregaCombo();
        }

        public void buscaPlano(string datainicial, string datafinal)
        {
            conexao.Open();
            string sql = string.Format("SELECT no.nome,IF(tipo='S', 'SAÍDA', 'ENTRADA') as Tipo,SUM(c.total_liquido) as total FROM contas c JOIN natureza_operacao no ON c.id_natureza = no.id_natureza WHERE data_lancamento between '{0}' and '{1}' GROUP BY c.id_natureza;", datainicial, datafinal);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();
            da.Fill(dt);
            tabelaTotais.DataSource = dt;
            conexao.Close();
        }

        public void preencheDadosPlano(string datainicial, string datafinal)
        {
            conexao.Open();
            string sql = string.Format("SELECT no.nome,IF(tipo='S', 'SAÍDA', 'ENTRADA') as Tipo,c.data_lancamento,c.total_liquido FROM contas c JOIN natureza_operacao no ON c.id_natureza = no.id_natureza WHERE data_lancamento between '{0}' and '{1}' ORDER BY no.nome", datainicial, datafinal);
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);

            DataTable dt = new DataTable();
            da.Fill(dt);
            tabelaListagem.DataSource = dt;
            conexao.Close();

        }

        private double preencheTotalizadorCredito(string datainicial, string datafinal)
        {
            conexao.Open();
            string sql = string.Format("SELECT SUM(c.total_liquido) as total FROM contas c JOIN natureza_operacao no ON c.id_natureza = no.id_natureza WHERE data_lancamento between '{0}' and '{1}' AND no.tipo = 'E'", datainicial, datafinal);

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            MySqlDataReader adapter = comandosql.ExecuteReader();

            double total_credito = 0.00;
            while (adapter.Read())

            {
                /*tratamento para verificar se o SUM da consulta 
                 retornou nulo*/
                if (Convert.IsDBNull(adapter[0]))
                {
                    total_credito = 0.00;
                    lblTotalCredito.Text = "0,00";
                }
                else
                {
                    lblTotalCredito.Text = String.Format("{0:C}", Convert.ToDecimal(adapter[0]));
                    total_credito = Convert.ToDouble(adapter[0]);
                }

            }
            conexao.Close();
            return total_credito;
        }
        private double preencheTotalizadorDebito(string datainicial, string datafinal)
        {
            conexao.Open();
            string sql = string.Format("SELECT SUM(c.total_liquido) as total FROM contas c JOIN natureza_operacao no ON c.id_natureza = no.id_natureza WHERE data_lancamento between '{0}' and '{1}' AND no.tipo = 'S'", datainicial, datafinal);

            MySqlCommand comandosql = new MySqlCommand(sql, conexao);
            MySqlDataReader adapter = comandosql.ExecuteReader();

            double total_debito = 0.00;
            while (adapter.Read())

                if (Convert.IsDBNull(adapter[0]))
                {
                    total_debito = 0.00;
                    lblTotalDebito.Text = "$0,00";
                }
                else
                {
                    lblTotalDebito.Text = String.Format("{0:C}", Convert.ToDecimal(adapter[0]));
                    total_debito = Convert.ToDouble(adapter[0]);

                }
            conexao.Close();
            return total_debito;
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            string dt_inicio = dtInicio.Value.ToString("yyyy-MM-dd");
            string dt_Fim = dtFim.Value.ToString("yyyy-MM-dd");

            //converte as strings em date para fazer a comparação das datas maiores e menores
            DateTime dataI = Convert.ToDateTime(dt_inicio);
            DateTime dataF = Convert.ToDateTime(dt_Fim);

            //verifica se a segunda final é menor que a data inicial
            if (dataF < dataI)
            {
                MessageBox.Show("A data final não pode ser menor que a data inicial", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                buscaPlano(dt_inicio, dt_Fim);

                //verifica quantidade de registros encontrado
                if (tabelaTotais.RowCount == 0)
                {
                    limpaTabela();

                    MessageBox.Show("Nenhum registro encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    preencheDadosPlano(dt_inicio, dt_Fim);
                    preencheTotalizadorCredito(dt_inicio, dt_Fim);
                    preencheTotalizadorDebito(dt_inicio, dt_Fim);
                    double saldo = preencheTotalizadorCredito(dt_inicio, dt_Fim) - preencheTotalizadorDebito(dt_inicio, dt_Fim);

                    //validando a cor a ser aplicada na label de saldo
                    if (saldo >= 0)
                    {
                        lblSaldo.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblSaldo.ForeColor = Color.Red;

                    }
                    //FAZ A FORMATAÇÃO PARA MOEDA
                    decimal saldo_formatado = Convert.ToDecimal(saldo);
                    lblSaldo.Text = String.Format("{0:C}", saldo_formatado);

                }
            }
        }

        /*METODO PARA LIMPAR AS TABELAS CASO
         NENHUM REGISTRO SEJA ENCONTRADO*/
        public void limpaTabela()
        {
            //tabela listagem
            while (tabelaListagem.Rows.Count > 0)
            {
                int i = 0;
                tabelaListagem.Rows.Remove(tabelaListagem.Rows[i]);
                i++;
            }

            //tabela totais
            while (tabelaTotais.Rows.Count > 0)
            {
                int i = 0;
                tabelaTotais.Rows.Remove(tabelaTotais.Rows[i]);
                i++;
            }

            lblSaldo.Text = "$0,00";
            lblTotalCredito.Text = "$0,00";
            lblTotalDebito.Text = "$0,00";
        }

        /*GARANTE QUE A APLICAÇÃO SERÁ ENCERRADA 
         QUANDO O FORM FECHAR*/
        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            encerrar();
        }

        private void encerrar()
        {
            if (MessageBox.Show("Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        //Mensagem do menu SOBRE
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por: Lucas Donato - 31826336 " +
                "\nSoftware com intenção de simular um balancete simples." +
                "\nO objetivo foi implementar todas as validações e regras da matéria." +
                "", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //função para calcular o valor líquido
        public void calculaTotalLiquido(double totalBruto, double acrescimo, double desconto)
        {
            txtTotalLiquido.Text = "" + (totalBruto + acrescimo - desconto);
        }

        /*Ao perder o focu dos campos de totais, é chamada
         a função para calcular o subtotal líquido*/
        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (txtValorTotal.Text == "")
                txtValorTotal.Text = "0,00";
            else
                calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));
        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            if (txtAcrescimo.Text == "")
                txtAcrescimo.Text = "0,00";
            else
                calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            if (txtDesconto.Text == "")
                txtDesconto.Text = "0,00";
            else
                calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));
        }


        /*----------------------------------------------*/
        private void txtValorTotal_Click(object sender, EventArgs e)
        {
            txtValorTotal.Clear();
        }

        private void txtAcrescimo_Click(object sender, EventArgs e)
        {
            txtAcrescimo.Clear();
        }

        private void txtDesconto_Click(object sender, EventArgs e)
        {
            txtDesconto.Clear();
        }

        private void btnLimparTabela_Click(object sender, EventArgs e)
        {
            //verifica se as tabelas já estão limpas
            if (tabelaTotais.RowCount == 0 && tabelaListagem.RowCount == 0)
                MessageBox.Show("As tabelas já estão vazias", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                limpaTabela();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            user.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realizar logout?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Dispose();
                Login log = new Login();
                log.Show();
            }
        }
    }
}
