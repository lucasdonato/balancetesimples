namespace BalanceteSimples
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.abaConsulta = new System.Windows.Forms.TabControl();
            this.abaCadastro = new System.Windows.Forms.TabPage();
            this.txtTotalLiquido = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPesquisaGeral = new System.Windows.Forms.Label();
            this.listaIconesMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.rdbPoupanca = new System.Windows.Forms.RadioButton();
            this.rdbCorrente = new System.Windows.Forms.RadioButton();
            this.cmbNatureza = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataLancamento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabelaPrincipal = new System.Windows.Forms.DataGridView();
            this.columnEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnIdConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIDNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoNatureza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAcrescimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_liquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscaGeral = new System.Windows.Forms.TextBox();
            this.abadeConsultas = new System.Windows.Forms.TabPage();
            this.btnLimparTabela = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalCredito = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalDebito = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.tabelaListagem = new System.Windows.Forms.DataGridView();
            this.nome2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaTotais = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuPrincipalAba = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPlano = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abaConsulta.SuspendLayout();
            this.abaCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrincipal)).BeginInit();
            this.abadeConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaListagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTotais)).BeginInit();
            this.menuPrincipalAba.SuspendLayout();
            this.SuspendLayout();
            // 
            // abaConsulta
            // 
            this.abaConsulta.Controls.Add(this.abaCadastro);
            this.abaConsulta.Controls.Add(this.abadeConsultas);
            this.abaConsulta.ImageList = this.listaIconesMenu;
            this.abaConsulta.Location = new System.Drawing.Point(0, 27);
            this.abaConsulta.Name = "abaConsulta";
            this.abaConsulta.SelectedIndex = 0;
            this.abaConsulta.Size = new System.Drawing.Size(845, 498);
            this.abaConsulta.TabIndex = 0;
            // 
            // abaCadastro
            // 
            this.abaCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abaCadastro.Controls.Add(this.txtTotalLiquido);
            this.abaCadastro.Controls.Add(this.label15);
            this.abaCadastro.Controls.Add(this.btnSair);
            this.abaCadastro.Controls.Add(this.lblPesquisaGeral);
            this.abaCadastro.Controls.Add(this.btnLimpar);
            this.abaCadastro.Controls.Add(this.btnSalvar);
            this.abaCadastro.Controls.Add(this.txtDesconto);
            this.abaCadastro.Controls.Add(this.txtAcrescimo);
            this.abaCadastro.Controls.Add(this.txtValorTotal);
            this.abaCadastro.Controls.Add(this.rdbPoupanca);
            this.abaCadastro.Controls.Add(this.rdbCorrente);
            this.abaCadastro.Controls.Add(this.cmbNatureza);
            this.abaCadastro.Controls.Add(this.txtDescricao);
            this.abaCadastro.Controls.Add(this.label7);
            this.abaCadastro.Controls.Add(this.dataLancamento);
            this.abaCadastro.Controls.Add(this.label6);
            this.abaCadastro.Controls.Add(this.label5);
            this.abaCadastro.Controls.Add(this.label3);
            this.abaCadastro.Controls.Add(this.label4);
            this.abaCadastro.Controls.Add(this.label2);
            this.abaCadastro.Controls.Add(this.label1);
            this.abaCadastro.Controls.Add(this.tabelaPrincipal);
            this.abaCadastro.Controls.Add(this.txtBuscaGeral);
            this.abaCadastro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abaCadastro.ImageIndex = 0;
            this.abaCadastro.Location = new System.Drawing.Point(4, 23);
            this.abaCadastro.Name = "abaCadastro";
            this.abaCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadastro.Size = new System.Drawing.Size(837, 471);
            this.abaCadastro.TabIndex = 0;
            this.abaCadastro.Text = "Cadastros";
            // 
            // txtTotalLiquido
            // 
            this.txtTotalLiquido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLiquido.Location = new System.Drawing.Point(615, 326);
            this.txtTotalLiquido.Name = "txtTotalLiquido";
            this.txtTotalLiquido.ReadOnly = true;
            this.txtTotalLiquido.Size = new System.Drawing.Size(134, 23);
            this.txtTotalLiquido.TabIndex = 23;
            this.txtTotalLiquido.Text = "0,00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(499, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Total Líquido:";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.Location = new System.Drawing.Point(604, 373);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(145, 82);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPesquisaGeral
            // 
            this.lblPesquisaGeral.AutoSize = true;
            this.lblPesquisaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaGeral.ImageKey = "Gakuseisean-Ivista-2-Start-Menu-Search.ico";
            this.lblPesquisaGeral.ImageList = this.listaIconesMenu;
            this.lblPesquisaGeral.Location = new System.Drawing.Point(722, 6);
            this.lblPesquisaGeral.Name = "lblPesquisaGeral";
            this.lblPesquisaGeral.Size = new System.Drawing.Size(15, 24);
            this.lblPesquisaGeral.TabIndex = 20;
            this.lblPesquisaGeral.Text = " ";
            this.lblPesquisaGeral.Click += new System.EventHandler(this.lblPesquisaGeral_Click);
            // 
            // listaIconesMenu
            // 
            this.listaIconesMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaIconesMenu.ImageStream")));
            this.listaIconesMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.listaIconesMenu.Images.SetKeyName(0, "Oxygen-Icons.org-Oxygen-Actions-insert-table.ico");
            this.listaIconesMenu.Images.SetKeyName(1, "Gakuseisean-Ivista-2-Start-Menu-Search.ico");
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(339, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(145, 82);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(63, 373);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(145, 82);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Cadastrar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(615, 292);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(134, 23);
            this.txtDesconto.TabIndex = 16;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.Click += new System.EventHandler(this.txtDesconto_Click);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcrescimo.Location = new System.Drawing.Point(615, 266);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.Size = new System.Drawing.Size(134, 23);
            this.txtAcrescimo.TabIndex = 15;
            this.txtAcrescimo.Text = "0,00";
            this.txtAcrescimo.Click += new System.EventHandler(this.txtAcrescimo_Click);
            this.txtAcrescimo.Leave += new System.EventHandler(this.txtAcrescimo_Leave);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(615, 241);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(134, 23);
            this.txtValorTotal.TabIndex = 14;
            this.txtValorTotal.Text = "0,00";
            this.txtValorTotal.Click += new System.EventHandler(this.txtValorTotal_Click);
            this.txtValorTotal.Leave += new System.EventHandler(this.txtValorTotal_Leave);
            // 
            // rdbPoupanca
            // 
            this.rdbPoupanca.AutoSize = true;
            this.rdbPoupanca.BackColor = System.Drawing.Color.Transparent;
            this.rdbPoupanca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPoupanca.Location = new System.Drawing.Point(212, 326);
            this.rdbPoupanca.Name = "rdbPoupanca";
            this.rdbPoupanca.Size = new System.Drawing.Size(81, 20);
            this.rdbPoupanca.TabIndex = 13;
            this.rdbPoupanca.TabStop = true;
            this.rdbPoupanca.Text = "Poupança";
            this.rdbPoupanca.UseVisualStyleBackColor = false;
            // 
            // rdbCorrente
            // 
            this.rdbCorrente.AutoSize = true;
            this.rdbCorrente.BackColor = System.Drawing.Color.Transparent;
            this.rdbCorrente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorrente.Location = new System.Drawing.Point(130, 326);
            this.rdbCorrente.Name = "rdbCorrente";
            this.rdbCorrente.Size = new System.Drawing.Size(76, 20);
            this.rdbCorrente.TabIndex = 12;
            this.rdbCorrente.TabStop = true;
            this.rdbCorrente.Text = "Corrente";
            this.rdbCorrente.UseVisualStyleBackColor = false;
            // 
            // cmbNatureza
            // 
            this.cmbNatureza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNatureza.FormattingEnabled = true;
            this.cmbNatureza.Location = new System.Drawing.Point(130, 296);
            this.cmbNatureza.Name = "cmbNatureza";
            this.cmbNatureza.Size = new System.Drawing.Size(147, 24);
            this.cmbNatureza.TabIndex = 11;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(130, 241);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(380, 23);
            this.txtDescricao.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Data Lançamento:";
            // 
            // dataLancamento
            // 
            this.dataLancamento.Location = new System.Drawing.Point(130, 270);
            this.dataLancamento.Name = "dataLancamento";
            this.dataLancamento.Size = new System.Drawing.Size(260, 23);
            this.dataLancamento.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(544, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Natureza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(533, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(537, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Acréscimo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Conta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            // 
            // tabelaPrincipal
            // 
            this.tabelaPrincipal.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelaPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabelaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnEditar,
            this.columnExcluir,
            this.columnIdConta,
            this.columnIDNatureza,
            this.columnDescricao,
            this.columnData,
            this.columnTipoConta,
            this.columnNatureza,
            this.TipoNatureza,
            this.columnValor,
            this.columnAcrescimo,
            this.columnDesconto,
            this.total_liquido});
            this.tabelaPrincipal.Location = new System.Drawing.Point(6, 36);
            this.tabelaPrincipal.Name = "tabelaPrincipal";
            this.tabelaPrincipal.ReadOnly = true;
            this.tabelaPrincipal.Size = new System.Drawing.Size(825, 191);
            this.tabelaPrincipal.TabIndex = 1;
            this.tabelaPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaPrincipal_CellContentClick);
            // 
            // columnEditar
            // 
            this.columnEditar.HeaderText = "Editar";
            this.columnEditar.Image = ((System.Drawing.Image)(resources.GetObject("columnEditar.Image")));
            this.columnEditar.Name = "columnEditar";
            this.columnEditar.ReadOnly = true;
            this.columnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // columnExcluir
            // 
            this.columnExcluir.HeaderText = "Excluir";
            this.columnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("columnExcluir.Image")));
            this.columnExcluir.Name = "columnExcluir";
            this.columnExcluir.ReadOnly = true;
            this.columnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnExcluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // columnIdConta
            // 
            this.columnIdConta.DataPropertyName = "id_conta";
            this.columnIdConta.HeaderText = "ID CONTA";
            this.columnIdConta.Name = "columnIdConta";
            this.columnIdConta.ReadOnly = true;
            this.columnIdConta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnIDNatureza
            // 
            this.columnIDNatureza.DataPropertyName = "id_natureza";
            this.columnIDNatureza.HeaderText = "id_natureza";
            this.columnIDNatureza.Name = "columnIDNatureza";
            this.columnIDNatureza.ReadOnly = true;
            this.columnIDNatureza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnDescricao
            // 
            this.columnDescricao.DataPropertyName = "descricao_conta";
            this.columnDescricao.HeaderText = "Descrição";
            this.columnDescricao.Name = "columnDescricao";
            this.columnDescricao.ReadOnly = true;
            this.columnDescricao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnData
            // 
            this.columnData.DataPropertyName = "data_lancamento";
            this.columnData.HeaderText = "Data Lançamento";
            this.columnData.Name = "columnData";
            this.columnData.ReadOnly = true;
            this.columnData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnTipoConta
            // 
            this.columnTipoConta.DataPropertyName = "tipo_conta";
            this.columnTipoConta.HeaderText = "Tipo Conta";
            this.columnTipoConta.Name = "columnTipoConta";
            this.columnTipoConta.ReadOnly = true;
            this.columnTipoConta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnNatureza
            // 
            this.columnNatureza.DataPropertyName = "nome";
            this.columnNatureza.HeaderText = "Natureza";
            this.columnNatureza.Name = "columnNatureza";
            this.columnNatureza.ReadOnly = true;
            this.columnNatureza.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoNatureza
            // 
            this.TipoNatureza.DataPropertyName = "tipo";
            this.TipoNatureza.HeaderText = "Tipo Lançamento";
            this.TipoNatureza.Name = "TipoNatureza";
            this.TipoNatureza.ReadOnly = true;
            // 
            // columnValor
            // 
            this.columnValor.DataPropertyName = "valor_total";
            this.columnValor.HeaderText = "Valor Bruto";
            this.columnValor.Name = "columnValor";
            this.columnValor.ReadOnly = true;
            this.columnValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnAcrescimo
            // 
            this.columnAcrescimo.DataPropertyName = "acrescimo";
            this.columnAcrescimo.HeaderText = "Acréscimo";
            this.columnAcrescimo.Name = "columnAcrescimo";
            this.columnAcrescimo.ReadOnly = true;
            this.columnAcrescimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // columnDesconto
            // 
            this.columnDesconto.DataPropertyName = "desconto";
            this.columnDesconto.HeaderText = "Desconto";
            this.columnDesconto.Name = "columnDesconto";
            this.columnDesconto.ReadOnly = true;
            this.columnDesconto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // total_liquido
            // 
            this.total_liquido.DataPropertyName = "total_liquido";
            this.total_liquido.HeaderText = "Valor Líquido";
            this.total_liquido.Name = "total_liquido";
            this.total_liquido.ReadOnly = true;
            // 
            // txtBuscaGeral
            // 
            this.txtBuscaGeral.Location = new System.Drawing.Point(9, 7);
            this.txtBuscaGeral.Name = "txtBuscaGeral";
            this.txtBuscaGeral.Size = new System.Drawing.Size(707, 23);
            this.txtBuscaGeral.TabIndex = 0;
            this.txtBuscaGeral.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscaDescricao);
            this.txtBuscaGeral.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscaDescricao);
            // 
            // abadeConsultas
            // 
            this.abadeConsultas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.abadeConsultas.Controls.Add(this.btnLimparTabela);
            this.abadeConsultas.Controls.Add(this.label13);
            this.abadeConsultas.Controls.Add(this.label11);
            this.abadeConsultas.Controls.Add(this.lblTotalCredito);
            this.abadeConsultas.Controls.Add(this.label14);
            this.abadeConsultas.Controls.Add(this.lblTotalDebito);
            this.abadeConsultas.Controls.Add(this.label12);
            this.abadeConsultas.Controls.Add(this.lblSaldo);
            this.abadeConsultas.Controls.Add(this.label10);
            this.abadeConsultas.Controls.Add(this.lblBuscar);
            this.abadeConsultas.Controls.Add(this.dtFim);
            this.abadeConsultas.Controls.Add(this.label9);
            this.abadeConsultas.Controls.Add(this.dtInicio);
            this.abadeConsultas.Controls.Add(this.label8);
            this.abadeConsultas.Controls.Add(this.tabelaListagem);
            this.abadeConsultas.Controls.Add(this.tabelaTotais);
            this.abadeConsultas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abadeConsultas.ImageIndex = 1;
            this.abadeConsultas.Location = new System.Drawing.Point(4, 23);
            this.abadeConsultas.Name = "abadeConsultas";
            this.abadeConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.abadeConsultas.Size = new System.Drawing.Size(837, 471);
            this.abadeConsultas.TabIndex = 1;
            this.abadeConsultas.Text = "Consultas";
            // 
            // btnLimparTabela
            // 
            this.btnLimparTabela.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparTabela.Image")));
            this.btnLimparTabela.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparTabela.Location = new System.Drawing.Point(698, 391);
            this.btnLimparTabela.Name = "btnLimparTabela";
            this.btnLimparTabela.Size = new System.Drawing.Size(118, 39);
            this.btnLimparTabela.TabIndex = 30;
            this.btnLimparTabela.Text = "Limpar";
            this.btnLimparTabela.UseVisualStyleBackColor = true;
            this.btnLimparTabela.Click += new System.EventHandler(this.btnLimparTabela_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(348, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "Agrupamento das saídas e entradas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Datalhamento dos valores";
            // 
            // lblTotalCredito
            // 
            this.lblTotalCredito.AutoSize = true;
            this.lblTotalCredito.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCredito.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCredito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalCredito.Location = new System.Drawing.Point(121, 440);
            this.lblTotalCredito.Name = "lblTotalCredito";
            this.lblTotalCredito.Size = new System.Drawing.Size(53, 18);
            this.lblTotalCredito.TabIndex = 27;
            this.lblTotalCredito.Text = "$0,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(24, 440);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "Total Crédito.:";
            // 
            // lblTotalDebito
            // 
            this.lblTotalDebito.AutoSize = true;
            this.lblTotalDebito.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDebito.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebito.ForeColor = System.Drawing.Color.Red;
            this.lblTotalDebito.Location = new System.Drawing.Point(353, 440);
            this.lblTotalDebito.Name = "lblTotalDebito";
            this.lblTotalDebito.Size = new System.Drawing.Size(53, 18);
            this.lblTotalDebito.TabIndex = 25;
            this.lblTotalDebito.Text = "$0,00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total Débito.:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(583, 439);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 19);
            this.lblSaldo.TabIndex = 23;
            this.lblSaldo.Text = "$0,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(525, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Saldo.:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ImageKey = "Gakuseisean-Ivista-2-Start-Menu-Search.ico";
            this.lblBuscar.ImageList = this.listaIconesMenu;
            this.lblBuscar.Location = new System.Drawing.Point(524, 36);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(15, 24);
            this.lblBuscar.TabIndex = 21;
            this.lblBuscar.Text = " ";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // dtFim
            // 
            this.dtFim.Location = new System.Drawing.Point(291, 37);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(217, 23);
            this.dtFim.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(258, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "a";
            // 
            // dtInicio
            // 
            this.dtInicio.Location = new System.Drawing.Point(25, 37);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(217, 23);
            this.dtInicio.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Selecione o período";
            // 
            // tabelaListagem
            // 
            this.tabelaListagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaListagem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome2,
            this.tipo,
            this.valortot,
            this.DataLanc});
            this.tabelaListagem.Location = new System.Drawing.Point(25, 114);
            this.tabelaListagem.Name = "tabelaListagem";
            this.tabelaListagem.Size = new System.Drawing.Size(657, 150);
            this.tabelaListagem.TabIndex = 1;
            // 
            // nome2
            // 
            this.nome2.DataPropertyName = "nome";
            this.nome2.HeaderText = "Nome";
            this.nome2.Name = "nome2";
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // valortot
            // 
            this.valortot.DataPropertyName = "total_liquido";
            this.valortot.HeaderText = "Valor Líquido";
            this.valortot.Name = "valortot";
            // 
            // DataLanc
            // 
            this.DataLanc.DataPropertyName = "data_lancamento";
            this.DataLanc.HeaderText = "Data Lançamento";
            this.DataLanc.Name = "DataLanc";
            // 
            // tabelaTotais
            // 
            this.tabelaTotais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaTotais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.Tipo2,
            this.total});
            this.tabelaTotais.Location = new System.Drawing.Point(25, 313);
            this.tabelaTotais.Name = "tabelaTotais";
            this.tabelaTotais.Size = new System.Drawing.Size(657, 117);
            this.tabelaTotais.TabIndex = 0;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // Tipo2
            // 
            this.Tipo2.DataPropertyName = "tipo";
            this.Tipo2.HeaderText = "Tipo";
            this.Tipo2.Name = "Tipo2";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total Líquido";
            this.total.Name = "total";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuPrincipalAba
            // 
            this.menuPrincipalAba.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuPrincipalAba.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuPrincipalAba.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipalAba.Name = "menuPrincipalAba";
            this.menuPrincipalAba.Size = new System.Drawing.Size(852, 24);
            this.menuPrincipalAba.TabIndex = 2;
            this.menuPrincipalAba.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPlano});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.opçõesToolStripMenuItem.Text = "Natureza Operação";
            // 
            // MenuPlano
            // 
            this.MenuPlano.Image = ((System.Drawing.Image)(resources.GetObject("MenuPlano.Image")));
            this.MenuPlano.Name = "MenuPlano";
            this.MenuPlano.Size = new System.Drawing.Size(123, 22);
            this.MenuPlano.Text = "Visualizar";
            this.MenuPlano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuPlano.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MenuPlano.Click += new System.EventHandler(this.MenuPlano_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ajudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripMenuItem.Image")));
            this.ajudaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ajudaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(852, 526);
            this.Controls.Add(this.abaConsulta);
            this.Controls.Add(this.menuPrincipalAba);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipalAba;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BALANCETE SIMPLES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.abaConsulta.ResumeLayout(false);
            this.abaCadastro.ResumeLayout(false);
            this.abaCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaPrincipal)).EndInit();
            this.abadeConsultas.ResumeLayout(false);
            this.abadeConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaListagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaTotais)).EndInit();
            this.menuPrincipalAba.ResumeLayout(false);
            this.menuPrincipalAba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl abaConsulta;
        private System.Windows.Forms.TabPage abaCadastro;
        private System.Windows.Forms.TabPage abadeConsultas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuPrincipalAba;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuPlano;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ImageList listaIconesMenu;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dataLancamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscaGeral;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cmbNatureza;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.RadioButton rdbPoupanca;
        private System.Windows.Forms.RadioButton rdbCorrente;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblPesquisaGeral;
        public System.Windows.Forms.DataGridView tabelaPrincipal;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tabelaListagem;
        private System.Windows.Forms.DataGridView tabelaTotais;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCredito;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalDebito;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtTotalLiquido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLanc;
        private System.Windows.Forms.DataGridViewImageColumn columnEditar;
        private System.Windows.Forms.DataGridViewImageColumn columnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIDNatureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTipoConta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNatureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoNatureza;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAcrescimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_liquido;
        private System.Windows.Forms.Button btnLimparTabela;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}

