namespace CamadaApresentacao
{
    partial class FRM_Entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Entrada));
            this.dataListaDetalhes = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.BTN_Deletar_Item = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.CB_Tipo_Compra = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtNum_Comprovante = new System.Windows.Forms.TextBox();
            this.cbTipo_Comprovante = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.chkAnular = new System.Windows.Forms.CheckBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXB_TotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.LB_Titulo_Total_Pagar = new System.Windows.Forms.Label();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DGV_Select_Prod_Cod_Barra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaDetalhes
            // 
            this.dataListaDetalhes.AllowUserToAddRows = false;
            this.dataListaDetalhes.AllowUserToDeleteRows = false;
            this.dataListaDetalhes.BackgroundColor = System.Drawing.Color.White;
            this.dataListaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dataListaDetalhes.Location = new System.Drawing.Point(6, 65);
            this.dataListaDetalhes.Name = "dataListaDetalhes";
            this.dataListaDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataListaDetalhes.Size = new System.Drawing.Size(885, 246);
            this.dataListaDetalhes.TabIndex = 23;
            this.dataListaDetalhes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaDetalhes_CellContentClick);
            this.dataListaDetalhes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataListaDetalhes_CellFormatting);
            this.dataListaDetalhes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataListaDetalhes_KeyPress);
            this.dataListaDetalhes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataListaDetalhes_KeyUp);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHK_Selecionar);
            this.groupBox1.Controls.Add(this.BTN_Deletar_Item);
            this.groupBox1.Controls.Add(this.dataListaDetalhes);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de Produtos";
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.Location = new System.Drawing.Point(304, 10);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 87;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = true;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // BTN_Deletar_Item
            // 
            this.BTN_Deletar_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar_Item.Enabled = false;
            this.BTN_Deletar_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Deletar_Item.Image = global::CamadaApresentacao.Properties.Resources.Excluir;
            this.BTN_Deletar_Item.Location = new System.Drawing.Point(301, 29);
            this.BTN_Deletar_Item.Name = "BTN_Deletar_Item";
            this.BTN_Deletar_Item.Size = new System.Drawing.Size(155, 30);
            this.BTN_Deletar_Item.TabIndex = 86;
            this.BTN_Deletar_Item.Text = "  DELETAR ITEM";
            this.BTN_Deletar_Item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar_Item.UseVisualStyleBackColor = true;
            this.BTN_Deletar_Item.Click += new System.EventHandler(this.BTN_Deletar_Item_Click);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(167, 39);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(108, 20);
            this.dtData.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Data";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 39);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(120, 20);
            this.txtId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel22x22;
            this.btnCancelar.Location = new System.Drawing.Point(756, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "   CANCELAR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = global::CamadaApresentacao.Properties.Resources.Novo24x24;
            this.btnNovo.Location = new System.Drawing.Point(480, 29);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(114, 30);
            this.btnNovo.TabIndex = 8;
            this.btnNovo.Text = "   NOVO";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(616, 29);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(120, 30);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "   SALVAR";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // CB_Tipo_Compra
            // 
            this.CB_Tipo_Compra.FormattingEnabled = true;
            this.CB_Tipo_Compra.Items.AddRange(new object[] {
            "A Vista",
            "Parcelado"});
            this.CB_Tipo_Compra.Location = new System.Drawing.Point(9, 376);
            this.CB_Tipo_Compra.Name = "CB_Tipo_Compra";
            this.CB_Tipo_Compra.Size = new System.Drawing.Size(351, 21);
            this.CB_Tipo_Compra.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Compra";
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(463, 376);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(321, 21);
            this.cbFornecedor.TabIndex = 27;
            // 
            // txtNum_Comprovante
            // 
            this.txtNum_Comprovante.Location = new System.Drawing.Point(173, 437);
            this.txtNum_Comprovante.Name = "txtNum_Comprovante";
            this.txtNum_Comprovante.Size = new System.Drawing.Size(187, 20);
            this.txtNum_Comprovante.TabIndex = 25;
            // 
            // cbTipo_Comprovante
            // 
            this.cbTipo_Comprovante.FormattingEnabled = true;
            this.cbTipo_Comprovante.Items.AddRange(new object[] {
            "Nota Fiscal",
            "Recibo de Compra"});
            this.cbTipo_Comprovante.Location = new System.Drawing.Point(9, 437);
            this.cbTipo_Comprovante.Name = "cbTipo_Comprovante";
            this.cbTipo_Comprovante.Size = new System.Drawing.Size(140, 21);
            this.cbTipo_Comprovante.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fornecedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Comprovante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº Comprovante";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBuscar.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.txtBuscar.Location = new System.Drawing.Point(447, 18);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(97, 23);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.Text = "   Pesquisar";
            this.txtBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(28, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 539);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.dtFinal);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.dtInicial);
            this.tabPage1.Controls.Add(this.chkAnular);
            this.tabPage1.Controls.Add(this.dataLista);
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar";
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(307, 20);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(125, 20);
            this.dtFinal.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data Final";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(86, 20);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(125, 20);
            this.dtInicial.TabIndex = 8;
            // 
            // chkAnular
            // 
            this.chkAnular.AutoSize = true;
            this.chkAnular.Location = new System.Drawing.Point(3, 60);
            this.chkAnular.Name = "chkAnular";
            this.chkAnular.Size = new System.Drawing.Size(76, 17);
            this.chkAnular.TabIndex = 7;
            this.chkAnular.Text = "Selecionar";
            this.chkAnular.UseVisualStyleBackColor = true;
            this.chkAnular.CheckedChanged += new System.EventHandler(this.chkAnular_CheckedChanged);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.dataLista.Location = new System.Drawing.Point(3, 83);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(895, 394);
            this.dataLista.TabIndex = 6;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellDoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Anular";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 43;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(699, 61);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "label3";
            // 
            // btnAnular
            // 
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.btnAnular.Location = new System.Drawing.Point(560, 18);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(82, 23);
            this.btnAnular.TabIndex = 3;
            this.btnAnular.Text = "   Excluir";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Inicial";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.TXB_TotalPagar);
            this.tabPage2.Controls.Add(this.cbFornecedor);
            this.tabPage2.Controls.Add(this.CB_Tipo_Compra);
            this.tabPage2.Controls.Add(this.LB_Titulo_Total_Pagar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtNum_Comprovante);
            this.tabPage2.Controls.Add(this.cbTipo_Comprovante);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            // 
            // TXB_TotalPagar
            // 
            this.TXB_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TotalPagar.ForeColor = System.Drawing.Color.Green;
            this.TXB_TotalPagar.Location = new System.Drawing.Point(463, 429);
            this.TXB_TotalPagar.Name = "TXB_TotalPagar";
            this.TXB_TotalPagar.ReadOnly = true;
            this.TXB_TotalPagar.Size = new System.Drawing.Size(213, 29);
            this.TXB_TotalPagar.TabIndex = 71;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            // 
            // LB_Titulo_Total_Pagar
            // 
            this.LB_Titulo_Total_Pagar.AutoSize = true;
            this.LB_Titulo_Total_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo_Total_Pagar.Location = new System.Drawing.Point(460, 410);
            this.LB_Titulo_Total_Pagar.Name = "LB_Titulo_Total_Pagar";
            this.LB_Titulo_Total_Pagar.Size = new System.Drawing.Size(107, 16);
            this.LB_Titulo_Total_Pagar.TabIndex = 70;
            this.LB_Titulo_Total_Pagar.Text = "Total a Pagar:";
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
            this.pictureBox4.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(966, 24);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 17);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(959, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 600);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(6, 600);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // DGV_Select_Prod_Cod_Barra
            // 
            this.DGV_Select_Prod_Cod_Barra.AllowUserToAddRows = false;
            this.DGV_Select_Prod_Cod_Barra.AllowUserToDeleteRows = false;
            this.DGV_Select_Prod_Cod_Barra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Select_Prod_Cod_Barra.Location = new System.Drawing.Point(939, 29);
            this.DGV_Select_Prod_Cod_Barra.Name = "DGV_Select_Prod_Cod_Barra";
            this.DGV_Select_Prod_Cod_Barra.ReadOnly = true;
            this.DGV_Select_Prod_Cod_Barra.Size = new System.Drawing.Size(13, 15);
            this.DGV_Select_Prod_Cod_Barra.TabIndex = 76;
            // 
            // FRM_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 612);
            this.Controls.Add(this.DGV_Select_Prod_Cod_Barra);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FRM_Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Entrada_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Entrada_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Entrada_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipo_Comprovante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.CheckBox chkAnular;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dataListaDetalhes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Tipo_Compra;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox TXB_TotalPagar;
        private System.Windows.Forms.Label LB_Titulo_Total_Pagar;
        public System.Windows.Forms.ComboBox cbFornecedor;
        public System.Windows.Forms.TextBox txtNum_Comprovante;
        public System.Windows.Forms.DateTimePicker dtData;
        public System.Windows.Forms.CheckBox CHK_Selecionar;
        private System.Windows.Forms.Button BTN_Deletar_Item;
        private System.Windows.Forms.DataGridView DGV_Select_Prod_Cod_Barra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}