using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BalanceteSimples
{
    
    public partial class EditarLancamentos : Form
    {
        MenuPrincipal menu_principal = new MenuPrincipal();

        public int id_conta;
       

        //Dados para conectara com o banco de dados.
        MySqlConnection conexao = new MySqlConnection("server=localhost;uid=root;pwd=123456;database=balancetesimples;sslMode=none;");

        private void carregaCombo()
        {
            conexao.Open(); //abre a conexao
            string sql = string.Format("SELECT id_natureza,nome FROM natureza_operacao");
            
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexao);
            DataTable dt_comboBox = new DataTable();
            da.Fill(dt_comboBox);

            //carrega as informacoes no combo
            cmbNatureza.DataSource = dt_comboBox;
            cmbNatureza.DisplayMember = "nome";
            cmbNatureza.ValueMember = "id_natureza";
            cmbNatureza.SelectedIndex = -1;
            conexao.Close();
   
        }

        public EditarLancamentos(int id,string descricao, string tipo, DateTime data, double total,double acrescimo, double desconto,double valor_liquido) {

            InitializeComponent();
            this.BackColor = Color.FromArgb(225, 234, 243);
            limpar();
            carregaCombo();
            txtDescricao.Text     = ""+descricao;
            txtValorTotal.Text    = ""+total;
            txtAcrescimo.Text     = ""+acrescimo;
            txtDesconto.Text      = ""+desconto;
            txtTotalLiquido.Text  = "" + valor_liquido;
            dataLancamento.Value  = data;
            this.id_conta = id;

            if (tipo == "Corrente")
                rdbCorrente.Checked = true;
            else
                rdbPoupanca.Checked = true;

        }
        public void limpar()
        {
            txtAcrescimo.Clear();
            txtDesconto.Clear();
            txtDescricao.Clear();
            cmbNatureza.SelectedIndex = -1;
            txtValorTotal.Clear();
            rdbCorrente.Checked = false;
            rdbPoupanca.Checked = false;
            dataLancamento.Value = DateTime.Now.Date;
            txtDescricao.Focus();
        }

        public void editarLancamento()
        { 

            conexao.Open();
            string conta = "";
            if (rdbCorrente.Checked)
                conta = "Corrente";
            else
                conta = "Poupança";

            string sql = string.Format("UPDATE contas SET descricao_conta = '{0}',id_natureza = {1}, tipo_conta = '{2}', data_lancamento = '{3}'," +
                "valor_total = {4},acrescimo = {5},desconto = {6}, total_liquido = {7} WHERE id_conta = {8};",
                      txtDescricao.Text, cmbNatureza.SelectedValue, conta, dataLancamento.Value.ToString("yyyy/MM/dd"), txtValorTotal.Text.Replace(',', '.'), txtAcrescimo.Text.Replace(',', '.'), txtDesconto.Text.Replace(',', '.'), txtTotalLiquido.Text.Replace(',', '.'), id_conta);

            MessageBox.Show("Lançamento alterado com sucesso", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);

            menu_principal.ExecutarComandoSQL(sql);
            menu_principal.AtualizarGridView();

        } 

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Alterar lançamento?", "Confirmaçao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtDescricao.Text == "" || txtValorTotal.Text == "" || (rdbCorrente.Checked == false && rdbPoupanca.Checked == false) || cmbNatureza.SelectedIndex == -1)
                {
                    MessageBox.Show("Preencha todos os campos!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToDouble(txtTotalLiquido.Text) > 0)
                {
                    
                    if (txtAcrescimo.Text == "")
                        txtAcrescimo.Text = "0,00";
                    if (txtDesconto.Text == "")
                        txtDesconto.Text = "0,00";

                    editarLancamento();
                    limpar();
                    Dispose();

                }
                else
                {
                    MessageBox.Show("O total líquido do lançamento não pode ser igual ou menor que $0,00", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }             
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        //função para calcular o valor líquido
        public void calculaTotalLiquido(double totalBruto, double acrescimo, double desconto)
        {
            txtTotalLiquido.Text = "" + (totalBruto + acrescimo - desconto);
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {

            calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));

        }

        private void txtAcrescimo_Leave(object sender, EventArgs e)
        {
            calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));

        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            calculaTotalLiquido(Convert.ToDouble(txtValorTotal.Text), Convert.ToDouble(txtAcrescimo.Text), Convert.ToDouble(txtDesconto.Text));

        }  
        
    }
}
