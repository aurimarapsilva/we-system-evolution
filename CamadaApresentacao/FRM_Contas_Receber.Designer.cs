namespace CamadaApresentacao
{
    partial class FRM_Contas_Receber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Contas_Receber));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.LB_Valor_Total = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Pesquisa_Mista = new System.Windows.Forms.Button();
            this.LB_Total_Registros = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DGV_Contas_Receber = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Pesquisar_Devedor = new System.Windows.Forms.Button();
            this.TXB_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.BTN_Quitar_Externamente = new System.Windows.Forms.Button();
            this.BTN_Ver_Origem = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_Valor_Atualizado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CHK_Selecionar_Tudo = new System.Windows.Forms.CheckBox();
            this.BTN_Quitar_Tudo_Interno = new System.Windows.Forms.Button();
            this.BTN_Gerar_Parcelas = new System.Windows.Forms.Button();
            this.CHK_Configuracao = new System.Windows.Forms.CheckBox();
            this.CB_Qtd_Parc = new System.Windows.Forms.ComboBox();
            this.CB_Cliente = new System.Windows.Forms.ComboBox();
            this.LB_Total_Parcelas = new System.Windows.Forms.Label();
            this.DGV_Parcelas = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.num_parcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHKB_Selecionar = new System.Windows.Forms.CheckBox();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            this.TXB_Devedor_Nao_Cadastrado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DT_Data_Inicial = new System.Windows.Forms.DateTimePicker();
            this.TXB_Valor_Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_Num_Doc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Fechar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.TT_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Relatorios = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contas_Receber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 451);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.BTN_Mostrar_Tudo);
            this.tabPage1.Controls.Add(this.LB_Valor_Total);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.LB_Modo_Exibicao);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.LB_Total_Registros);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.DGV_Contas_Receber);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar";
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.BackColor = System.Drawing.Color.Navy;
            this.BTN_Mostrar_Tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Mostrar_Tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mostrar_Tudo.ForeColor = System.Drawing.Color.White;
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(829, 401);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(102, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 76;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = false;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // LB_Valor_Total
            // 
            this.LB_Valor_Total.AutoSize = true;
            this.LB_Valor_Total.BackColor = System.Drawing.Color.Transparent;
            this.LB_Valor_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Valor_Total.ForeColor = System.Drawing.Color.Black;
            this.LB_Valor_Total.Location = new System.Drawing.Point(693, 406);
            this.LB_Valor_Total.Name = "LB_Valor_Total";
            this.LB_Valor_Total.Size = new System.Drawing.Size(34, 13);
            this.LB_Valor_Total.TabIndex = 75;
            this.LB_Valor_Total.Text = "label";
            this.LB_Valor_Total.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(620, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Valor Total:";
            this.label11.Visible = false;
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Transparent;
            this.LB_Modo_Exibicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Modo_Exibicao.ForeColor = System.Drawing.Color.Black;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(180, 406);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(34, 13);
            this.LB_Modo_Exibicao.TabIndex = 73;
            this.LB_Modo_Exibicao.Text = "label";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(36, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "Modo de exibição atual:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Pesquisa_Mista);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(767, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 69);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa Específica";
            // 
            // BTN_Pesquisa_Mista
            // 
            this.BTN_Pesquisa_Mista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisa_Mista.ForeColor = System.Drawing.Color.Black;
            this.BTN_Pesquisa_Mista.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Pesquisa_Mista.Location = new System.Drawing.Point(37, 28);
            this.BTN_Pesquisa_Mista.Name = "BTN_Pesquisa_Mista";
            this.BTN_Pesquisa_Mista.Size = new System.Drawing.Size(93, 23);
            this.BTN_Pesquisa_Mista.TabIndex = 0;
            this.BTN_Pesquisa_Mista.Text = "  Pesquisar";
            this.BTN_Pesquisa_Mista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Pesquisa_Mista.UseVisualStyleBackColor = true;
            this.BTN_Pesquisa_Mista.Click += new System.EventHandler(this.BTN_Pesquisa_Mista_Click);
            // 
            // LB_Total_Registros
            // 
            this.LB_Total_Registros.AutoSize = true;
            this.LB_Total_Registros.BackColor = System.Drawing.Color.Transparent;
            this.LB_Total_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total_Registros.ForeColor = System.Drawing.Color.Black;
            this.LB_Total_Registros.Location = new System.Drawing.Point(461, 406);
            this.LB_Total_Registros.Name = "LB_Total_Registros";
            this.LB_Total_Registros.Size = new System.Drawing.Size(34, 13);
            this.LB_Total_Registros.TabIndex = 32;
            this.LB_Total_Registros.Text = "label";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(352, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Total de registros:";
            // 
            // DGV_Contas_Receber
            // 
            this.DGV_Contas_Receber.AllowUserToAddRows = false;
            this.DGV_Contas_Receber.AllowUserToDeleteRows = false;
            this.DGV_Contas_Receber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Contas_Receber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Contas_Receber.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.DGV_Contas_Receber.Location = new System.Drawing.Point(36, 82);
            this.DGV_Contas_Receber.MultiSelect = false;
            this.DGV_Contas_Receber.Name = "DGV_Contas_Receber";
            this.DGV_Contas_Receber.ReadOnly = true;
            this.DGV_Contas_Receber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Contas_Receber.Size = new System.Drawing.Size(895, 319);
            this.DGV_Contas_Receber.TabIndex = 5;
            this.DGV_Contas_Receber.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Contas_Receber_CellClick);
            this.DGV_Contas_Receber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Contas_Receber_CellContentClick);
            this.DGV_Contas_Receber.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Contas_Receber_CellDoubleClick);
            this.DGV_Contas_Receber.SelectionChanged += new System.EventHandler(this.DGV_Contas_Receber_SelectionChanged);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Visible = false;
            this.Select.Width = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_Pesquisar_Devedor);
            this.groupBox2.Controls.Add(this.TXB_Buscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(417, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 69);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar por Cliente";
            // 
            // BTN_Pesquisar_Devedor
            // 
            this.BTN_Pesquisar_Devedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisar_Devedor.Enabled = false;
            this.BTN_Pesquisar_Devedor.ForeColor = System.Drawing.Color.Black;
            this.BTN_Pesquisar_Devedor.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Pesquisar_Devedor.Location = new System.Drawing.Point(211, 14);
            this.BTN_Pesquisar_Devedor.Name = "BTN_Pesquisar_Devedor";
            this.BTN_Pesquisar_Devedor.Size = new System.Drawing.Size(93, 21);
            this.BTN_Pesquisar_Devedor.TabIndex = 2;
            this.BTN_Pesquisar_Devedor.Text = "  Pesquisar";
            this.BTN_Pesquisar_Devedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Pesquisar_Devedor.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar_Devedor.Click += new System.EventHandler(this.BTN_Pesquisar_Devedor_Click);
            // 
            // TXB_Buscar
            // 
            this.TXB_Buscar.ForeColor = System.Drawing.Color.Black;
            this.TXB_Buscar.Location = new System.Drawing.Point(13, 38);
            this.TXB_Buscar.Name = "TXB_Buscar";
            this.TXB_Buscar.Size = new System.Drawing.Size(291, 20);
            this.TXB_Buscar.TabIndex = 1;
            this.TXB_Buscar.TextChanged += new System.EventHandler(this.TXB_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Cliente:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CHK_Selecionar);
            this.groupBox4.Controls.Add(this.BTN_Quitar_Externamente);
            this.groupBox4.Controls.Add(this.BTN_Ver_Origem);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(36, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 69);
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ações";
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.ForeColor = System.Drawing.Color.Black;
            this.CHK_Selecionar.Location = new System.Drawing.Point(136, 14);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 1;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = true;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // BTN_Quitar_Externamente
            // 
            this.BTN_Quitar_Externamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Quitar_Externamente.Enabled = false;
            this.BTN_Quitar_Externamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quitar_Externamente.ForeColor = System.Drawing.Color.Black;
            this.BTN_Quitar_Externamente.Image = global::CamadaApresentacao.Properties.Resources.quitar2;
            this.BTN_Quitar_Externamente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Quitar_Externamente.Location = new System.Drawing.Point(196, 33);
            this.BTN_Quitar_Externamente.Name = "BTN_Quitar_Externamente";
            this.BTN_Quitar_Externamente.Size = new System.Drawing.Size(134, 28);
            this.BTN_Quitar_Externamente.TabIndex = 80;
            this.BTN_Quitar_Externamente.Text = "    QUITAR";
            this.BTN_Quitar_Externamente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Quitar_Externamente.UseVisualStyleBackColor = true;
            this.BTN_Quitar_Externamente.Click += new System.EventHandler(this.BTN_Quitar_Externamente_Click);
            // 
            // BTN_Ver_Origem
            // 
            this.BTN_Ver_Origem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ver_Origem.Enabled = false;
            this.BTN_Ver_Origem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ver_Origem.ForeColor = System.Drawing.Color.Black;
            this.BTN_Ver_Origem.Image = global::CamadaApresentacao.Properties.Resources.Ver_Origem_20x20;
            this.BTN_Ver_Origem.Location = new System.Drawing.Point(13, 33);
            this.BTN_Ver_Origem.Name = "BTN_Ver_Origem";
            this.BTN_Ver_Origem.Size = new System.Drawing.Size(155, 28);
            this.BTN_Ver_Origem.TabIndex = 69;
            this.BTN_Ver_Origem.Text = "    VER ORIGEM";
            this.BTN_Ver_Origem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ver_Origem.UseVisualStyleBackColor = true;
            this.BTN_Ver_Origem.Click += new System.EventHandler(this.BTN_Ver_Origem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Valor_Atualizado);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.CHK_Selecionar_Tudo);
            this.groupBox1.Controls.Add(this.BTN_Quitar_Tudo_Interno);
            this.groupBox1.Controls.Add(this.BTN_Gerar_Parcelas);
            this.groupBox1.Controls.Add(this.CHK_Configuracao);
            this.groupBox1.Controls.Add(this.CB_Qtd_Parc);
            this.groupBox1.Controls.Add(this.CB_Cliente);
            this.groupBox1.Controls.Add(this.LB_Total_Parcelas);
            this.groupBox1.Controls.Add(this.DGV_Parcelas);
            this.groupBox1.Controls.Add(this.CHKB_Selecionar);
            this.groupBox1.Controls.Add(this.BTN_Deletar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TXB_Id);
            this.groupBox1.Controls.Add(this.TXB_Devedor_Nao_Cadastrado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DT_Data_Inicial);
            this.groupBox1.Controls.Add(this.TXB_Valor_Total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXB_Num_Doc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BTN_Fechar);
            this.groupBox1.Controls.Add(this.BTN_Salvar);
            this.groupBox1.Controls.Add(this.BTN_Novo);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(950, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TXB_Valor_Atualizado
            // 
            this.TXB_Valor_Atualizado.Location = new System.Drawing.Point(22, 247);
            this.TXB_Valor_Atualizado.Name = "TXB_Valor_Atualizado";
            this.TXB_Valor_Atualizado.ReadOnly = true;
            this.TXB_Valor_Atualizado.Size = new System.Drawing.Size(140, 20);
            this.TXB_Valor_Atualizado.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(19, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Valor Atualizado:";
            // 
            // CHK_Selecionar_Tudo
            // 
            this.CHK_Selecionar_Tudo.AutoSize = true;
            this.CHK_Selecionar_Tudo.Location = new System.Drawing.Point(473, 104);
            this.CHK_Selecionar_Tudo.Name = "CHK_Selecionar_Tudo";
            this.CHK_Selecionar_Tudo.Size = new System.Drawing.Size(128, 17);
            this.CHK_Selecionar_Tudo.TabIndex = 40;
            this.CHK_Selecionar_Tudo.Text = "SELECIONAR TUDO";
            this.CHK_Selecionar_Tudo.UseVisualStyleBackColor = true;
            this.CHK_Selecionar_Tudo.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_Tudo_CheckedChanged);
            // 
            // BTN_Quitar_Tudo_Interno
            // 
            this.BTN_Quitar_Tudo_Interno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Quitar_Tudo_Interno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Quitar_Tudo_Interno.Enabled = false;
            this.BTN_Quitar_Tudo_Interno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Quitar_Tudo_Interno.Image = global::CamadaApresentacao.Properties.Resources.quitar2;
            this.BTN_Quitar_Tudo_Interno.Location = new System.Drawing.Point(709, 91);
            this.BTN_Quitar_Tudo_Interno.Name = "BTN_Quitar_Tudo_Interno";
            this.BTN_Quitar_Tudo_Interno.Size = new System.Drawing.Size(163, 30);
            this.BTN_Quitar_Tudo_Interno.TabIndex = 39;
            this.BTN_Quitar_Tudo_Interno.Text = "     QUITAR";
            this.BTN_Quitar_Tudo_Interno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Quitar_Tudo_Interno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Quitar_Tudo_Interno.UseVisualStyleBackColor = true;
            this.BTN_Quitar_Tudo_Interno.Click += new System.EventHandler(this.BTN_Quitar_Tudo_Interno_Click);
            // 
            // BTN_Gerar_Parcelas
            // 
            this.BTN_Gerar_Parcelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Gerar_Parcelas.Location = new System.Drawing.Point(218, 186);
            this.BTN_Gerar_Parcelas.Name = "BTN_Gerar_Parcelas";
            this.BTN_Gerar_Parcelas.Size = new System.Drawing.Size(65, 65);
            this.BTN_Gerar_Parcelas.TabIndex = 38;
            this.BTN_Gerar_Parcelas.Text = "Gerar Parcelas";
            this.BTN_Gerar_Parcelas.UseVisualStyleBackColor = true;
            this.BTN_Gerar_Parcelas.Click += new System.EventHandler(this.BTN_Gerar_Parcelas_Click);
            // 
            // CHK_Configuracao
            // 
            this.CHK_Configuracao.AutoSize = true;
            this.CHK_Configuracao.BackColor = System.Drawing.Color.Transparent;
            this.CHK_Configuracao.Checked = true;
            this.CHK_Configuracao.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_Configuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Configuracao.Location = new System.Drawing.Point(766, 44);
            this.CHK_Configuracao.Name = "CHK_Configuracao";
            this.CHK_Configuracao.Size = new System.Drawing.Size(163, 17);
            this.CHK_Configuracao.TabIndex = 36;
            this.CHK_Configuracao.Text = "Usar Cliente Cadastrado";
            this.CHK_Configuracao.UseVisualStyleBackColor = false;
            this.CHK_Configuracao.CheckedChanged += new System.EventHandler(this.CHK_Configuracao_CheckedChanged);
            // 
            // CB_Qtd_Parc
            // 
            this.CB_Qtd_Parc.FormattingEnabled = true;
            this.CB_Qtd_Parc.Items.AddRange(new object[] {
            "1 X",
            "2 X",
            "3 X",
            "4 X",
            "5 X",
            "6 X",
            "7 X",
            "8 X",
            "9 X",
            "10 X",
            "11 X",
            "12 X "});
            this.CB_Qtd_Parc.Location = new System.Drawing.Point(22, 305);
            this.CB_Qtd_Parc.Name = "CB_Qtd_Parc";
            this.CB_Qtd_Parc.Size = new System.Drawing.Size(140, 21);
            this.CB_Qtd_Parc.TabIndex = 35;
            // 
            // CB_Cliente
            // 
            this.CB_Cliente.FormattingEnabled = true;
            this.CB_Cliente.Location = new System.Drawing.Point(676, 18);
            this.CB_Cliente.Name = "CB_Cliente";
            this.CB_Cliente.Size = new System.Drawing.Size(253, 21);
            this.CB_Cliente.TabIndex = 34;
            // 
            // LB_Total_Parcelas
            // 
            this.LB_Total_Parcelas.AutoSize = true;
            this.LB_Total_Parcelas.Location = new System.Drawing.Point(807, 380);
            this.LB_Total_Parcelas.Name = "LB_Total_Parcelas";
            this.LB_Total_Parcelas.Size = new System.Drawing.Size(35, 13);
            this.LB_Total_Parcelas.TabIndex = 33;
            this.LB_Total_Parcelas.Text = "label8";
            // 
            // DGV_Parcelas
            // 
            this.DGV_Parcelas.AllowUserToAddRows = false;
            this.DGV_Parcelas.AllowUserToDeleteRows = false;
            this.DGV_Parcelas.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.num_parcela,
            this.valor,
            this.Column3});
            this.DGV_Parcelas.Location = new System.Drawing.Point(321, 127);
            this.DGV_Parcelas.MultiSelect = false;
            this.DGV_Parcelas.Name = "DGV_Parcelas";
            this.DGV_Parcelas.ReadOnly = true;
            this.DGV_Parcelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Parcelas.Size = new System.Drawing.Size(608, 250);
            this.DGV_Parcelas.TabIndex = 32;
            this.DGV_Parcelas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Parcelas_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Width = 35;
            // 
            // num_parcela
            // 
            this.num_parcela.DataPropertyName = "num_parcela";
            this.num_parcela.HeaderText = "Nº da Parcela";
            this.num_parcela.Name = "num_parcela";
            this.num_parcela.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "c";
            this.valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "vencimento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Vencimento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // CHKB_Selecionar
            // 
            this.CHKB_Selecionar.AutoSize = true;
            this.CHKB_Selecionar.BackColor = System.Drawing.Color.Transparent;
            this.CHKB_Selecionar.Location = new System.Drawing.Point(321, 104);
            this.CHKB_Selecionar.Name = "CHKB_Selecionar";
            this.CHKB_Selecionar.Size = new System.Drawing.Size(121, 17);
            this.CHKB_Selecionar.TabIndex = 30;
            this.CHKB_Selecionar.Text = "SELECIONAR UMA";
            this.CHKB_Selecionar.UseVisualStyleBackColor = false;
            this.CHKB_Selecionar.CheckedChanged += new System.EventHandler(this.CHKB_Selecionar_CheckedChanged_1);
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Excluir;
            this.BTN_Deletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.Location = new System.Drawing.Point(899, 91);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(30, 30);
            this.BTN_Deletar.TabIndex = 29;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Código";
            // 
            // TXB_Id
            // 
            this.TXB_Id.Location = new System.Drawing.Point(56, 19);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.Size = new System.Drawing.Size(98, 20);
            this.TXB_Id.TabIndex = 24;
            // 
            // TXB_Devedor_Nao_Cadastrado
            // 
            this.TXB_Devedor_Nao_Cadastrado.Location = new System.Drawing.Point(676, 18);
            this.TXB_Devedor_Nao_Cadastrado.Name = "TXB_Devedor_Nao_Cadastrado";
            this.TXB_Devedor_Nao_Cadastrado.Size = new System.Drawing.Size(253, 20);
            this.TXB_Devedor_Nao_Cadastrado.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(622, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Devedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(314, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Data Inicial";
            // 
            // DT_Data_Inicial
            // 
            this.DT_Data_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Data_Inicial.Location = new System.Drawing.Point(380, 19);
            this.DT_Data_Inicial.Name = "DT_Data_Inicial";
            this.DT_Data_Inicial.Size = new System.Drawing.Size(102, 20);
            this.DT_Data_Inicial.TabIndex = 20;
            // 
            // TXB_Valor_Total
            // 
            this.TXB_Valor_Total.Location = new System.Drawing.Point(22, 186);
            this.TXB_Valor_Total.Name = "TXB_Valor_Total";
            this.TXB_Valor_Total.Size = new System.Drawing.Size(140, 20);
            this.TXB_Valor_Total.TabIndex = 19;
            this.TXB_Valor_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Valor_Total_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Valor Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Parcelado em:";
            // 
            // TXB_Num_Doc
            // 
            this.TXB_Num_Doc.Location = new System.Drawing.Point(22, 127);
            this.TXB_Num_Doc.Name = "TXB_Num_Doc";
            this.TXB_Num_Doc.Size = new System.Drawing.Size(140, 20);
            this.TXB_Num_Doc.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nº  do Documento:";
            // 
            // BTN_Fechar
            // 
            this.BTN_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Fechar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Fechar.Location = new System.Drawing.Point(207, 354);
            this.BTN_Fechar.Name = "BTN_Fechar";
            this.BTN_Fechar.Size = new System.Drawing.Size(76, 23);
            this.BTN_Fechar.TabIndex = 8;
            this.BTN_Fechar.Text = "    Sair";
            this.BTN_Fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Fechar.UseVisualStyleBackColor = true;
            this.BTN_Fechar.Click += new System.EventHandler(this.BTN_Fechar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(115, 354);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(79, 23);
            this.BTN_Salvar.TabIndex = 7;
            this.BTN_Salvar.Text = "   Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Novo
            // 
            this.BTN_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Novo.Image = global::CamadaApresentacao.Properties.Resources.Novo16x16;
            this.BTN_Novo.Location = new System.Drawing.Point(25, 354);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(76, 23);
            this.BTN_Novo.TabIndex = 0;
            this.BTN_Novo.Text = "   Novo";
            this.BTN_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // TT_Mensagem
            // 
            this.TT_Mensagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(1005, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 522);
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(1, 502);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1012, 20);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1013, 23);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 524);
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(410, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // BTN_Relatorios
            // 
            this.BTN_Relatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Relatorios.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Relatorios.Image = global::CamadaApresentacao.Properties.Resources.Report_16x16;
            this.BTN_Relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Relatorios.Location = new System.Drawing.Point(8, 0);
            this.BTN_Relatorios.Name = "BTN_Relatorios";
            this.BTN_Relatorios.Size = new System.Drawing.Size(99, 23);
            this.BTN_Relatorios.TabIndex = 38;
            this.BTN_Relatorios.Text = "       Relatórios";
            this.BTN_Relatorios.UseVisualStyleBackColor = true;
            this.BTN_Relatorios.Click += new System.EventHandler(this.BTN_Relatorios_Click);
            // 
            // FRM_Contas_Receber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1014, 522);
            this.Controls.Add(this.BTN_Relatorios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Contas_Receber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Contas_Reb_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Contas_Reb_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Contas_Receber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TXB_Devedor_Nao_Cadastrado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TXB_Buscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker DT_Data_Inicial;
        public System.Windows.Forms.TextBox TXB_Valor_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TXB_Num_Doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Fechar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Novo;
        private System.Windows.Forms.TextBox TXB_Id;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip TT_Mensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTN_Deletar;
        public System.Windows.Forms.DataGridView DGV_Parcelas;
        public System.Windows.Forms.DataGridView DGV_Contas_Receber;
        private System.Windows.Forms.Label LB_Total_Parcelas;
        private System.Windows.Forms.ComboBox CB_Qtd_Parc;
        private System.Windows.Forms.ComboBox CB_Cliente;
        private System.Windows.Forms.CheckBox CHK_Configuracao;
        private System.Windows.Forms.Button BTN_Gerar_Parcelas;
        private System.Windows.Forms.Button BTN_Ver_Origem;
        private System.Windows.Forms.Label LB_Total_Registros;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Pesquisa_Mista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        private System.Windows.Forms.Label LB_Valor_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Button BTN_Pesquisar_Devedor;
        public System.Windows.Forms.CheckBox CHK_Selecionar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_parcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.CheckBox CHKB_Selecionar;
        private System.Windows.Forms.Button BTN_Quitar_Externamente;
        private System.Windows.Forms.Button BTN_Quitar_Tudo_Interno;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTN_Relatorios;
        public System.Windows.Forms.TextBox TXB_Valor_Atualizado;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.CheckBox CHK_Selecionar_Tudo;
    }
}