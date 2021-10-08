namespace CamadaApresentacao
{
    partial class FRM_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Venda));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSelecionar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_Juros_Card_Cred = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXB_Juros_Cred_Loja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXB_Comissao_Paga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DGV_Formas_Pagamento = new System.Windows.Forms.DataGridView();
            this.TXB_Valor_Entrada = new System.Windows.Forms.TextBox();
            this.TXB_Recebimento = new System.Windows.Forms.TextBox();
            this.TXB_TotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.LB_Titulo_Total_Pagar = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComprovante = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNum_Comprovante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataListaDetalhes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(1172, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 690);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::CamadaApresentacao.Properties.Resources.Buscar_20x20;
            this.btnBuscar.Location = new System.Drawing.Point(159, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(91, 28);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = " Pesquisar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(23, 84);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(116, 20);
            this.dtFinal.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data Final";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(23, 35);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(116, 20);
            this.dtInicial.TabIndex = 8;
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dataLista.Location = new System.Drawing.Point(27, 226);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(269, 415);
            this.dataLista.TabIndex = 6;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellDoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 5;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Excluir;
            this.btnDeletar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(228, 172);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(30, 30);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Inicial";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(24, 210);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 62;
            this.lblTotal.Text = "label3";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Print;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(266, 172);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(30, 30);
            this.btnImprimir.TabIndex = 63;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1183, 24);
            this.pictureBox4.TabIndex = 40;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 673);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1181, 17);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 690);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtInicial);
            this.groupBox3.Controls.Add(this.dtFinal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(27, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 116);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa por Datas";
            // 
            // chkSelecionar
            // 
            this.chkSelecionar.AutoSize = true;
            this.chkSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.chkSelecionar.Location = new System.Drawing.Point(31, 180);
            this.chkSelecionar.Name = "chkSelecionar";
            this.chkSelecionar.Size = new System.Drawing.Size(76, 17);
            this.chkSelecionar.TabIndex = 66;
            this.chkSelecionar.Text = "Selecionar";
            this.chkSelecionar.UseVisualStyleBackColor = false;
            this.chkSelecionar.CheckedChanged += new System.EventHandler(this.chkSelecionar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Juros_Card_Cred);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TXB_Juros_Cred_Loja);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TXB_Comissao_Paga);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.TXB_Valor_Entrada);
            this.groupBox1.Controls.Add(this.TXB_Recebimento);
            this.groupBox1.Controls.Add(this.TXB_TotalPagar);
            this.groupBox1.Controls.Add(this.LB_Titulo_Total_Pagar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtComprovante);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNum_Comprovante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.dataListaDetalhes);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(322, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 628);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Venda";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TXB_Juros_Card_Cred
            // 
            this.TXB_Juros_Card_Cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Juros_Card_Cred.ForeColor = System.Drawing.Color.Green;
            this.TXB_Juros_Card_Cred.Location = new System.Drawing.Point(633, 405);
            this.TXB_Juros_Card_Cred.Name = "TXB_Juros_Card_Cred";
            this.TXB_Juros_Card_Cred.ReadOnly = true;
            this.TXB_Juros_Card_Cred.Size = new System.Drawing.Size(187, 22);
            this.TXB_Juros_Card_Cred.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(630, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 15);
            this.label14.TabIndex = 86;
            this.label14.Text = "Juros de Parcel. - Card. Cred.";
            // 
            // TXB_Juros_Cred_Loja
            // 
            this.TXB_Juros_Cred_Loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Juros_Cred_Loja.ForeColor = System.Drawing.Color.Green;
            this.TXB_Juros_Cred_Loja.Location = new System.Drawing.Point(437, 405);
            this.TXB_Juros_Cred_Loja.Name = "TXB_Juros_Cred_Loja";
            this.TXB_Juros_Cred_Loja.ReadOnly = true;
            this.TXB_Juros_Cred_Loja.Size = new System.Drawing.Size(187, 22);
            this.TXB_Juros_Cred_Loja.TabIndex = 85;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(434, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 15);
            this.label13.TabIndex = 84;
            this.label13.Text = "Juros de Parcel. - Cred. Loja";
            // 
            // TXB_Comissao_Paga
            // 
            this.TXB_Comissao_Paga.ForeColor = System.Drawing.Color.Black;
            this.TXB_Comissao_Paga.Location = new System.Drawing.Point(200, 599);
            this.TXB_Comissao_Paga.Name = "TXB_Comissao_Paga";
            this.TXB_Comissao_Paga.Size = new System.Drawing.Size(152, 20);
            this.TXB_Comissao_Paga.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(197, 583);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 82;
            this.label12.Text = "Comissão Paga:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DGV_Formas_Pagamento);
            this.groupBox5.Location = new System.Drawing.Point(426, 437);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(392, 182);
            this.groupBox5.TabIndex = 81;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formas de Pagamento";
            // 
            // DGV_Formas_Pagamento
            // 
            this.DGV_Formas_Pagamento.AllowUserToAddRows = false;
            this.DGV_Formas_Pagamento.AllowUserToDeleteRows = false;
            this.DGV_Formas_Pagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Formas_Pagamento.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Formas_Pagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Formas_Pagamento.Location = new System.Drawing.Point(12, 19);
            this.DGV_Formas_Pagamento.Name = "DGV_Formas_Pagamento";
            this.DGV_Formas_Pagamento.ReadOnly = true;
            this.DGV_Formas_Pagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Formas_Pagamento.Size = new System.Drawing.Size(374, 156);
            this.DGV_Formas_Pagamento.TabIndex = 77;
            // 
            // TXB_Valor_Entrada
            // 
            this.TXB_Valor_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Entrada.ForeColor = System.Drawing.Color.Green;
            this.TXB_Valor_Entrada.Location = new System.Drawing.Point(620, 353);
            this.TXB_Valor_Entrada.Name = "TXB_Valor_Entrada";
            this.TXB_Valor_Entrada.Size = new System.Drawing.Size(200, 26);
            this.TXB_Valor_Entrada.TabIndex = 73;
            // 
            // TXB_Recebimento
            // 
            this.TXB_Recebimento.ForeColor = System.Drawing.Color.Black;
            this.TXB_Recebimento.Location = new System.Drawing.Point(23, 599);
            this.TXB_Recebimento.Name = "TXB_Recebimento";
            this.TXB_Recebimento.Size = new System.Drawing.Size(134, 20);
            this.TXB_Recebimento.TabIndex = 72;
            // 
            // TXB_TotalPagar
            // 
            this.TXB_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TotalPagar.ForeColor = System.Drawing.Color.Green;
            this.TXB_TotalPagar.Location = new System.Drawing.Point(620, 321);
            this.TXB_TotalPagar.Name = "TXB_TotalPagar";
            this.TXB_TotalPagar.Size = new System.Drawing.Size(200, 26);
            this.TXB_TotalPagar.TabIndex = 71;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            // 
            // LB_Titulo_Total_Pagar
            // 
            this.LB_Titulo_Total_Pagar.AutoSize = true;
            this.LB_Titulo_Total_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo_Total_Pagar.ForeColor = System.Drawing.Color.Black;
            this.LB_Titulo_Total_Pagar.Location = new System.Drawing.Point(475, 327);
            this.LB_Titulo_Total_Pagar.Name = "LB_Titulo_Total_Pagar";
            this.LB_Titulo_Total_Pagar.Size = new System.Drawing.Size(139, 16);
            this.LB_Titulo_Total_Pagar.TabIndex = 70;
            this.LB_Titulo_Total_Pagar.Text = "Total em Produtos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(461, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 66;
            this.label11.Text = "Entrada em Dinheiro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 583);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Recebimento:";
            // 
            // txtComprovante
            // 
            this.txtComprovante.ForeColor = System.Drawing.Color.Black;
            this.txtComprovante.Location = new System.Drawing.Point(23, 551);
            this.txtComprovante.Name = "txtComprovante";
            this.txtComprovante.Size = new System.Drawing.Size(134, 20);
            this.txtComprovante.TabIndex = 64;
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(23, 38);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(108, 20);
            this.dtData.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Data";
            // 
            // txtNum_Comprovante
            // 
            this.txtNum_Comprovante.ForeColor = System.Drawing.Color.Black;
            this.txtNum_Comprovante.Location = new System.Drawing.Point(196, 551);
            this.txtNum_Comprovante.Name = "txtNum_Comprovante";
            this.txtNum_Comprovante.Size = new System.Drawing.Size(156, 20);
            this.txtNum_Comprovante.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Comprovante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(193, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº Comprovante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // txtId
            // 
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(184, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 20);
            this.txtId.TabIndex = 3;
            // 
            // dataListaDetalhes
            // 
            this.dataListaDetalhes.AllowUserToAddRows = false;
            this.dataListaDetalhes.AllowUserToDeleteRows = false;
            this.dataListaDetalhes.BackgroundColor = System.Drawing.Color.White;
            this.dataListaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaDetalhes.Location = new System.Drawing.Point(23, 64);
            this.dataListaDetalhes.Name = "dataListaDetalhes";
            this.dataListaDetalhes.Size = new System.Drawing.Size(797, 252);
            this.dataListaDetalhes.TabIndex = 23;
            this.dataListaDetalhes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataListaDetalhes_CellFormatting_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 66);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(26, 38);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(303, 20);
            this.txtCliente.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFuncionario);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(23, 424);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 86);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionário";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.ForeColor = System.Drawing.Color.Black;
            this.txtFuncionario.Location = new System.Drawing.Point(26, 45);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(303, 20);
            this.txtFuncionario.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome";
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.ForeColor = System.Drawing.Color.Black;
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Limpar_24x24;
            this.BTN_Sair.Location = new System.Drawing.Point(123, 172);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(91, 30);
            this.BTN_Sair.TabIndex = 62;
            this.BTN_Sair.Text = "  Limpar";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(206, 644);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(90, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 68;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = true;
            this.BTN_Mostrar_Tudo.Visible = false;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Modo de Exibição:";
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Transparent;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(138, 649);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(15, 13);
            this.LB_Modo_Exibicao.TabIndex = 70;
            this.LB_Modo_Exibicao.Text = "lb";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // FRM_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1180, 690);
            this.Controls.Add(this.LB_Modo_Exibicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Mostrar_Tudo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkSelecionar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem das Vendas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Venda_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNum_Comprovante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.DataGridView dataListaDetalhes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.TextBox txtComprovante;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView dataLista;
        public System.Windows.Forms.MaskedTextBox TXB_TotalPagar;
        private System.Windows.Forms.Label LB_Titulo_Total_Pagar;
        private System.Windows.Forms.TextBox TXB_Valor_Entrada;
        private System.Windows.Forms.TextBox TXB_Recebimento;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.DataGridView DGV_Formas_Pagamento;
        private System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        public System.Windows.Forms.CheckBox chkSelecionar;
        private System.Windows.Forms.TextBox TXB_Comissao_Paga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXB_Juros_Card_Cred;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXB_Juros_Cred_Loja;
        private System.Windows.Forms.Label label13;
    }
}