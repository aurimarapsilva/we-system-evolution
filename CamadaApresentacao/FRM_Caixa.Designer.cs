namespace CamadaApresentacao
{
    partial class FRM_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Caixa));
            this.LB_Cx_Livre = new System.Windows.Forms.Label();
            this.GB_Efetuar_Venda = new System.Windows.Forms.GroupBox();
            this.TXB_Valor_Entrada = new System.Windows.Forms.TextBox();
            this.LB_Vaslor_Entrada = new System.Windows.Forms.Label();
            this.TXB_Entrada_Dinheiro = new System.Windows.Forms.TextBox();
            this.LB_Entrada = new System.Windows.Forms.Label();
            this.BTN_Cancelar_Venda = new System.Windows.Forms.Button();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.BTN_Deletar_Item = new System.Windows.Forms.Button();
            this.BTN_Fechar_Caixa = new System.Windows.Forms.Button();
            this.TXB_Recebimento = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.TXB_TotalPagar = new System.Windows.Forms.TextBox();
            this.TXB_Troco = new System.Windows.Forms.TextBox();
            this.TXT_Recebido = new System.Windows.Forms.TextBox();
            this.LB_Troco = new System.Windows.Forms.Label();
            this.LB_Recebido = new System.Windows.Forms.Label();
            this.LB_Titulo_Total_Pagar = new System.Windows.Forms.Label();
            this.txtNum_Comprovante = new System.Windows.Forms.TextBox();
            this.cbTipo_Comprovante = new System.Windows.Forms.ComboBox();
            this.LB_Comp = new System.Windows.Forms.Label();
            this.LB_Num_Comp = new System.Windows.Forms.Label();
            this.GB_Cliente = new System.Windows.Forms.GroupBox();
            this.CHK_Venda_Rapida = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXB_IdCliente = new System.Windows.Forms.TextBox();
            this.BTN_Selecionar_Cliente = new System.Windows.Forms.Button();
            this.TXB_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.LB_Nome_Cliente = new System.Windows.Forms.Label();
            this.dataListaDetalhes = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.lbData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Cheque = new System.Windows.Forms.Button();
            this.CHK_Usar_Uma_foma_Pgto = new System.Windows.Forms.CheckBox();
            this.BTN_Crediario_Loja = new System.Windows.Forms.Button();
            this.BTN_Dinheiro = new System.Windows.Forms.Button();
            this.BTN_Cartão_Debito = new System.Windows.Forms.Button();
            this.BTN_Cartao_Credito = new System.Windows.Forms.Button();
            this.DGV_Formas_Pagamento = new System.Windows.Forms.DataGridView();
            this.BTN_Excluir = new System.Windows.Forms.Button();
            this.BTN_Multiformas = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnNova_Venda = new System.Windows.Forms.Button();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnContas_Pagar = new System.Windows.Forms.Button();
            this.BTN_Contas_Receber = new System.Windows.Forms.Button();
            this.DGV_Select_Prod_Cod_Barra = new System.Windows.Forms.DataGridView();
            this.Atualizador_Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Operador = new System.Windows.Forms.Label();
            this.BTN_Pesquisar_Preco = new System.Windows.Forms.Button();
            this.BTN_Novo_Guiche = new System.Windows.Forms.Button();
            this.BTN_informacoes = new System.Windows.Forms.Button();
            this.BTN_Importar_OS = new System.Windows.Forms.Button();
            this.BTN_Importar_Orcamento = new System.Windows.Forms.Button();
            this.GB_Efetuar_Venda.SuspendLayout();
            this.GB_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_Cx_Livre
            // 
            this.LB_Cx_Livre.AutoSize = true;
            this.LB_Cx_Livre.BackColor = System.Drawing.Color.Navy;
            this.LB_Cx_Livre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Cx_Livre.ForeColor = System.Drawing.Color.White;
            this.LB_Cx_Livre.Location = new System.Drawing.Point(62, 687);
            this.LB_Cx_Livre.Name = "LB_Cx_Livre";
            this.LB_Cx_Livre.Size = new System.Drawing.Size(16, 15);
            this.LB_Cx_Livre.TabIndex = 45;
            this.LB_Cx_Livre.Text = "C";
            this.LB_Cx_Livre.Visible = false;
            // 
            // GB_Efetuar_Venda
            // 
            this.GB_Efetuar_Venda.BackColor = System.Drawing.Color.Transparent;
            this.GB_Efetuar_Venda.Controls.Add(this.TXB_Valor_Entrada);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Vaslor_Entrada);
            this.GB_Efetuar_Venda.Controls.Add(this.TXB_Entrada_Dinheiro);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Entrada);
            this.GB_Efetuar_Venda.Controls.Add(this.BTN_Cancelar_Venda);
            this.GB_Efetuar_Venda.Controls.Add(this.CHK_Selecionar);
            this.GB_Efetuar_Venda.Controls.Add(this.BTN_Deletar_Item);
            this.GB_Efetuar_Venda.Controls.Add(this.BTN_Fechar_Caixa);
            this.GB_Efetuar_Venda.Controls.Add(this.TXB_Recebimento);
            this.GB_Efetuar_Venda.Controls.Add(this.label);
            this.GB_Efetuar_Venda.Controls.Add(this.TXB_TotalPagar);
            this.GB_Efetuar_Venda.Controls.Add(this.TXB_Troco);
            this.GB_Efetuar_Venda.Controls.Add(this.TXT_Recebido);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Troco);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Recebido);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Titulo_Total_Pagar);
            this.GB_Efetuar_Venda.Controls.Add(this.txtNum_Comprovante);
            this.GB_Efetuar_Venda.Controls.Add(this.cbTipo_Comprovante);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Comp);
            this.GB_Efetuar_Venda.Controls.Add(this.LB_Num_Comp);
            this.GB_Efetuar_Venda.Controls.Add(this.GB_Cliente);
            this.GB_Efetuar_Venda.Controls.Add(this.dataListaDetalhes);
            this.GB_Efetuar_Venda.Controls.Add(this.btnSalvar);
            this.GB_Efetuar_Venda.Controls.Add(this.dtData);
            this.GB_Efetuar_Venda.Controls.Add(this.lbData);
            this.GB_Efetuar_Venda.Controls.Add(this.groupBox1);
            this.GB_Efetuar_Venda.Location = new System.Drawing.Point(222, 45);
            this.GB_Efetuar_Venda.Name = "GB_Efetuar_Venda";
            this.GB_Efetuar_Venda.Size = new System.Drawing.Size(977, 625);
            this.GB_Efetuar_Venda.TabIndex = 46;
            this.GB_Efetuar_Venda.TabStop = false;
            this.GB_Efetuar_Venda.Text = "Efetuar Venda";
            // 
            // TXB_Valor_Entrada
            // 
            this.TXB_Valor_Entrada.Location = new System.Drawing.Point(112, 589);
            this.TXB_Valor_Entrada.Name = "TXB_Valor_Entrada";
            this.TXB_Valor_Entrada.ReadOnly = true;
            this.TXB_Valor_Entrada.Size = new System.Drawing.Size(88, 20);
            this.TXB_Valor_Entrada.TabIndex = 90;
            this.TXB_Valor_Entrada.Visible = false;
            // 
            // LB_Vaslor_Entrada
            // 
            this.LB_Vaslor_Entrada.AutoSize = true;
            this.LB_Vaslor_Entrada.Location = new System.Drawing.Point(109, 573);
            this.LB_Vaslor_Entrada.Name = "LB_Vaslor_Entrada";
            this.LB_Vaslor_Entrada.Size = new System.Drawing.Size(34, 13);
            this.LB_Vaslor_Entrada.TabIndex = 89;
            this.LB_Vaslor_Entrada.Text = "Valor:";
            this.LB_Vaslor_Entrada.Visible = false;
            // 
            // TXB_Entrada_Dinheiro
            // 
            this.TXB_Entrada_Dinheiro.Location = new System.Drawing.Point(20, 589);
            this.TXB_Entrada_Dinheiro.Name = "TXB_Entrada_Dinheiro";
            this.TXB_Entrada_Dinheiro.ReadOnly = true;
            this.TXB_Entrada_Dinheiro.Size = new System.Drawing.Size(70, 20);
            this.TXB_Entrada_Dinheiro.TabIndex = 88;
            this.TXB_Entrada_Dinheiro.Visible = false;
            // 
            // LB_Entrada
            // 
            this.LB_Entrada.AutoSize = true;
            this.LB_Entrada.Location = new System.Drawing.Point(17, 573);
            this.LB_Entrada.Name = "LB_Entrada";
            this.LB_Entrada.Size = new System.Drawing.Size(47, 13);
            this.LB_Entrada.TabIndex = 87;
            this.LB_Entrada.Text = "Entrada:";
            this.LB_Entrada.Visible = false;
            // 
            // BTN_Cancelar_Venda
            // 
            this.BTN_Cancelar_Venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar_Venda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cancelar_Venda.Image = global::CamadaApresentacao.Properties.Resources.Cancel22x22;
            this.BTN_Cancelar_Venda.Location = new System.Drawing.Point(581, 33);
            this.BTN_Cancelar_Venda.Name = "BTN_Cancelar_Venda";
            this.BTN_Cancelar_Venda.Size = new System.Drawing.Size(136, 30);
            this.BTN_Cancelar_Venda.TabIndex = 86;
            this.BTN_Cancelar_Venda.Text = "   CANCELAR";
            this.BTN_Cancelar_Venda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar_Venda.UseVisualStyleBackColor = true;
            this.BTN_Cancelar_Venda.Click += new System.EventHandler(this.BTN_Cancelar_Venda_Click);
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.Location = new System.Drawing.Point(212, 14);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 85;
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
            this.BTN_Deletar_Item.Location = new System.Drawing.Point(209, 33);
            this.BTN_Deletar_Item.Name = "BTN_Deletar_Item";
            this.BTN_Deletar_Item.Size = new System.Drawing.Size(155, 30);
            this.BTN_Deletar_Item.TabIndex = 84;
            this.BTN_Deletar_Item.Text = "  DELETAR ITEM";
            this.BTN_Deletar_Item.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar_Item.UseVisualStyleBackColor = true;
            this.BTN_Deletar_Item.Click += new System.EventHandler(this.BTN_Deletar_Item_Click);
            // 
            // BTN_Fechar_Caixa
            // 
            this.BTN_Fechar_Caixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Fechar_Caixa.Image = global::CamadaApresentacao.Properties.Resources.Fechar_Caixa;
            this.BTN_Fechar_Caixa.Location = new System.Drawing.Point(797, 33);
            this.BTN_Fechar_Caixa.Name = "BTN_Fechar_Caixa";
            this.BTN_Fechar_Caixa.Size = new System.Drawing.Size(168, 30);
            this.BTN_Fechar_Caixa.TabIndex = 83;
            this.BTN_Fechar_Caixa.Text = "   FECHAR CAIXA";
            this.BTN_Fechar_Caixa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Fechar_Caixa.UseVisualStyleBackColor = true;
            this.BTN_Fechar_Caixa.Click += new System.EventHandler(this.BTN_Fechar_Caixa_Click);
            // 
            // TXB_Recebimento
            // 
            this.TXB_Recebimento.Location = new System.Drawing.Point(20, 537);
            this.TXB_Recebimento.Name = "TXB_Recebimento";
            this.TXB_Recebimento.ReadOnly = true;
            this.TXB_Recebimento.Size = new System.Drawing.Size(180, 20);
            this.TXB_Recebimento.TabIndex = 82;
            this.TXB_Recebimento.TextChanged += new System.EventHandler(this.TXB_Recebimento_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(17, 521);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 13);
            this.label.TabIndex = 81;
            this.label.Text = "Recebimento:";
            // 
            // TXB_TotalPagar
            // 
            this.TXB_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TotalPagar.ForeColor = System.Drawing.Color.Navy;
            this.TXB_TotalPagar.Location = new System.Drawing.Point(265, 495);
            this.TXB_TotalPagar.Name = "TXB_TotalPagar";
            this.TXB_TotalPagar.ReadOnly = true;
            this.TXB_TotalPagar.Size = new System.Drawing.Size(210, 29);
            this.TXB_TotalPagar.TabIndex = 76;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            // 
            // TXB_Troco
            // 
            this.TXB_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Troco.ForeColor = System.Drawing.Color.Green;
            this.TXB_Troco.Location = new System.Drawing.Point(265, 565);
            this.TXB_Troco.Name = "TXB_Troco";
            this.TXB_Troco.ReadOnly = true;
            this.TXB_Troco.Size = new System.Drawing.Size(210, 31);
            this.TXB_Troco.TabIndex = 75;
            this.TXB_Troco.Visible = false;
            // 
            // TXT_Recebido
            // 
            this.TXT_Recebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Recebido.Location = new System.Drawing.Point(265, 430);
            this.TXT_Recebido.Name = "TXT_Recebido";
            this.TXT_Recebido.Size = new System.Drawing.Size(210, 29);
            this.TXT_Recebido.TabIndex = 74;
            this.TXT_Recebido.Visible = false;
            this.TXT_Recebido.TextChanged += new System.EventHandler(this.TXT_Recebido_TextChanged);
            this.TXT_Recebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Recebido_KeyPress);
            // 
            // LB_Troco
            // 
            this.LB_Troco.AutoSize = true;
            this.LB_Troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Troco.Location = new System.Drawing.Point(262, 546);
            this.LB_Troco.Name = "LB_Troco";
            this.LB_Troco.Size = new System.Drawing.Size(53, 16);
            this.LB_Troco.TabIndex = 72;
            this.LB_Troco.Text = "Troco:";
            this.LB_Troco.Visible = false;
            // 
            // LB_Recebido
            // 
            this.LB_Recebido.AutoSize = true;
            this.LB_Recebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Recebido.Location = new System.Drawing.Point(262, 411);
            this.LB_Recebido.Name = "LB_Recebido";
            this.LB_Recebido.Size = new System.Drawing.Size(121, 16);
            this.LB_Recebido.TabIndex = 70;
            this.LB_Recebido.Text = "Valor Recebido:";
            this.LB_Recebido.Visible = false;
            // 
            // LB_Titulo_Total_Pagar
            // 
            this.LB_Titulo_Total_Pagar.AutoSize = true;
            this.LB_Titulo_Total_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo_Total_Pagar.Location = new System.Drawing.Point(262, 476);
            this.LB_Titulo_Total_Pagar.Name = "LB_Titulo_Total_Pagar";
            this.LB_Titulo_Total_Pagar.Size = new System.Drawing.Size(213, 16);
            this.LB_Titulo_Total_Pagar.TabIndex = 65;
            this.LB_Titulo_Total_Pagar.Text = "Total em Produtos / Serviços:";
            // 
            // txtNum_Comprovante
            // 
            this.txtNum_Comprovante.Location = new System.Drawing.Point(20, 486);
            this.txtNum_Comprovante.Name = "txtNum_Comprovante";
            this.txtNum_Comprovante.ReadOnly = true;
            this.txtNum_Comprovante.Size = new System.Drawing.Size(180, 20);
            this.txtNum_Comprovante.TabIndex = 63;
            // 
            // cbTipo_Comprovante
            // 
            this.cbTipo_Comprovante.FormattingEnabled = true;
            this.cbTipo_Comprovante.Items.AddRange(new object[] {
            "Recibo de Venda",
            "Nota Fiscal"});
            this.cbTipo_Comprovante.Location = new System.Drawing.Point(20, 435);
            this.cbTipo_Comprovante.Name = "cbTipo_Comprovante";
            this.cbTipo_Comprovante.Size = new System.Drawing.Size(180, 21);
            this.cbTipo_Comprovante.TabIndex = 62;
            // 
            // LB_Comp
            // 
            this.LB_Comp.AutoSize = true;
            this.LB_Comp.Location = new System.Drawing.Point(17, 419);
            this.LB_Comp.Name = "LB_Comp";
            this.LB_Comp.Size = new System.Drawing.Size(70, 13);
            this.LB_Comp.TabIndex = 61;
            this.LB_Comp.Text = "Comprovante";
            // 
            // LB_Num_Comp
            // 
            this.LB_Num_Comp.AutoSize = true;
            this.LB_Num_Comp.Location = new System.Drawing.Point(17, 470);
            this.LB_Num_Comp.Name = "LB_Num_Comp";
            this.LB_Num_Comp.Size = new System.Drawing.Size(85, 13);
            this.LB_Num_Comp.TabIndex = 60;
            this.LB_Num_Comp.Text = "Nº Comprovante";
            // 
            // GB_Cliente
            // 
            this.GB_Cliente.Controls.Add(this.CHK_Venda_Rapida);
            this.GB_Cliente.Controls.Add(this.label7);
            this.GB_Cliente.Controls.Add(this.TXB_IdCliente);
            this.GB_Cliente.Controls.Add(this.BTN_Selecionar_Cliente);
            this.GB_Cliente.Controls.Add(this.TXB_Nome_Cliente);
            this.GB_Cliente.Controls.Add(this.LB_Nome_Cliente);
            this.GB_Cliente.Location = new System.Drawing.Point(20, 308);
            this.GB_Cliente.Name = "GB_Cliente";
            this.GB_Cliente.Size = new System.Drawing.Size(463, 88);
            this.GB_Cliente.TabIndex = 57;
            this.GB_Cliente.TabStop = false;
            this.GB_Cliente.Text = "Cliente";
            // 
            // CHK_Venda_Rapida
            // 
            this.CHK_Venda_Rapida.AutoSize = true;
            this.CHK_Venda_Rapida.Checked = true;
            this.CHK_Venda_Rapida.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_Venda_Rapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Venda_Rapida.Location = new System.Drawing.Point(20, 63);
            this.CHK_Venda_Rapida.Name = "CHK_Venda_Rapida";
            this.CHK_Venda_Rapida.Size = new System.Drawing.Size(106, 17);
            this.CHK_Venda_Rapida.TabIndex = 63;
            this.CHK_Venda_Rapida.Text = "Venda Rápida";
            this.CHK_Venda_Rapida.UseVisualStyleBackColor = true;
            this.CHK_Venda_Rapida.CheckedChanged += new System.EventHandler(this.CHK_Venda_Rapida_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Código:";
            // 
            // TXB_IdCliente
            // 
            this.TXB_IdCliente.Location = new System.Drawing.Point(20, 35);
            this.TXB_IdCliente.Name = "TXB_IdCliente";
            this.TXB_IdCliente.ReadOnly = true;
            this.TXB_IdCliente.Size = new System.Drawing.Size(88, 20);
            this.TXB_IdCliente.TabIndex = 60;
            this.TXB_IdCliente.Text = "0";
            this.TXB_IdCliente.TextChanged += new System.EventHandler(this.TXB_IdCliente_TextChanged);
            // 
            // BTN_Selecionar_Cliente
            // 
            this.BTN_Selecionar_Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Selecionar_Cliente.Enabled = false;
            this.BTN_Selecionar_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Selecionar_Cliente.Location = new System.Drawing.Point(364, 62);
            this.BTN_Selecionar_Cliente.Name = "BTN_Selecionar_Cliente";
            this.BTN_Selecionar_Cliente.Size = new System.Drawing.Size(74, 19);
            this.BTN_Selecionar_Cliente.TabIndex = 62;
            this.BTN_Selecionar_Cliente.Text = "Selecionar:";
            this.BTN_Selecionar_Cliente.UseVisualStyleBackColor = true;
            this.BTN_Selecionar_Cliente.Click += new System.EventHandler(this.BTN_Selecionar_Cliente_Click);
            // 
            // TXB_Nome_Cliente
            // 
            this.TXB_Nome_Cliente.Location = new System.Drawing.Point(129, 35);
            this.TXB_Nome_Cliente.Name = "TXB_Nome_Cliente";
            this.TXB_Nome_Cliente.ReadOnly = true;
            this.TXB_Nome_Cliente.Size = new System.Drawing.Size(309, 20);
            this.TXB_Nome_Cliente.TabIndex = 59;
            this.TXB_Nome_Cliente.Text = "CONSUMIDOR";
            // 
            // LB_Nome_Cliente
            // 
            this.LB_Nome_Cliente.AutoSize = true;
            this.LB_Nome_Cliente.Location = new System.Drawing.Point(126, 19);
            this.LB_Nome_Cliente.Name = "LB_Nome_Cliente";
            this.LB_Nome_Cliente.Size = new System.Drawing.Size(85, 13);
            this.LB_Nome_Cliente.TabIndex = 30;
            this.LB_Nome_Cliente.Text = "Nome Completo:";
            // 
            // dataListaDetalhes
            // 
            this.dataListaDetalhes.AllowUserToAddRows = false;
            this.dataListaDetalhes.AllowUserToDeleteRows = false;
            this.dataListaDetalhes.BackgroundColor = System.Drawing.Color.White;
            this.dataListaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dataListaDetalhes.Location = new System.Drawing.Point(20, 69);
            this.dataListaDetalhes.Name = "dataListaDetalhes";
            this.dataListaDetalhes.Size = new System.Drawing.Size(945, 233);
            this.dataListaDetalhes.TabIndex = 56;
            this.dataListaDetalhes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaDetalhes_CellContentClick);
            this.dataListaDetalhes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataListaDetalhes_CellFormatting);
            this.dataListaDetalhes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataListaDetalhes_EditingControlShowing);
            this.dataListaDetalhes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataListaDetalhes_KeyPress);
            this.dataListaDetalhes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataListaDetalhes_KeyUp);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selecionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 35;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar;
            this.btnSalvar.Location = new System.Drawing.Point(438, 33);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(122, 30);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "   GRAVAR";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(20, 43);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(108, 20);
            this.dtData.TabIndex = 53;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(17, 27);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 52;
            this.lbData.Text = "Data";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Cheque);
            this.groupBox1.Controls.Add(this.CHK_Usar_Uma_foma_Pgto);
            this.groupBox1.Controls.Add(this.BTN_Crediario_Loja);
            this.groupBox1.Controls.Add(this.BTN_Dinheiro);
            this.groupBox1.Controls.Add(this.BTN_Cartão_Debito);
            this.groupBox1.Controls.Add(this.BTN_Cartao_Credito);
            this.groupBox1.Controls.Add(this.DGV_Formas_Pagamento);
            this.groupBox1.Controls.Add(this.BTN_Excluir);
            this.groupBox1.Controls.Add(this.BTN_Multiformas);
            this.groupBox1.Location = new System.Drawing.Point(503, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 270);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamento";
            // 
            // BTN_Cheque
            // 
            this.BTN_Cheque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cheque.Location = new System.Drawing.Point(357, 184);
            this.BTN_Cheque.Name = "BTN_Cheque";
            this.BTN_Cheque.Size = new System.Drawing.Size(105, 23);
            this.BTN_Cheque.TabIndex = 85;
            this.BTN_Cheque.Text = "Cheque";
            this.BTN_Cheque.UseVisualStyleBackColor = true;
            this.BTN_Cheque.Click += new System.EventHandler(this.BTN_Cheque_Click);
            // 
            // CHK_Usar_Uma_foma_Pgto
            // 
            this.CHK_Usar_Uma_foma_Pgto.AutoSize = true;
            this.CHK_Usar_Uma_foma_Pgto.Checked = true;
            this.CHK_Usar_Uma_foma_Pgto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHK_Usar_Uma_foma_Pgto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHK_Usar_Uma_foma_Pgto.Location = new System.Drawing.Point(170, 24);
            this.CHK_Usar_Uma_foma_Pgto.Name = "CHK_Usar_Uma_foma_Pgto";
            this.CHK_Usar_Uma_foma_Pgto.Size = new System.Drawing.Size(251, 17);
            this.CHK_Usar_Uma_foma_Pgto.TabIndex = 84;
            this.CHK_Usar_Uma_foma_Pgto.Text = "Usar Somente uma forma de pagamento";
            this.CHK_Usar_Uma_foma_Pgto.UseVisualStyleBackColor = true;
            this.CHK_Usar_Uma_foma_Pgto.CheckedChanged += new System.EventHandler(this.CHK_Multiformas_CheckedChanged);
            // 
            // BTN_Crediario_Loja
            // 
            this.BTN_Crediario_Loja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Crediario_Loja.Location = new System.Drawing.Point(357, 154);
            this.BTN_Crediario_Loja.Name = "BTN_Crediario_Loja";
            this.BTN_Crediario_Loja.Size = new System.Drawing.Size(105, 23);
            this.BTN_Crediario_Loja.TabIndex = 83;
            this.BTN_Crediario_Loja.Text = "Crediário da Loja";
            this.BTN_Crediario_Loja.UseVisualStyleBackColor = true;
            this.BTN_Crediario_Loja.Click += new System.EventHandler(this.BTN_Crediario_Loja_Click);
            // 
            // BTN_Dinheiro
            // 
            this.BTN_Dinheiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Dinheiro.Location = new System.Drawing.Point(357, 62);
            this.BTN_Dinheiro.Name = "BTN_Dinheiro";
            this.BTN_Dinheiro.Size = new System.Drawing.Size(105, 23);
            this.BTN_Dinheiro.TabIndex = 82;
            this.BTN_Dinheiro.Text = "Dinheiro";
            this.BTN_Dinheiro.UseVisualStyleBackColor = true;
            this.BTN_Dinheiro.Click += new System.EventHandler(this.BTN_Dinheiro_Click);
            // 
            // BTN_Cartão_Debito
            // 
            this.BTN_Cartão_Debito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cartão_Debito.Location = new System.Drawing.Point(357, 124);
            this.BTN_Cartão_Debito.Name = "BTN_Cartão_Debito";
            this.BTN_Cartão_Debito.Size = new System.Drawing.Size(105, 23);
            this.BTN_Cartão_Debito.TabIndex = 81;
            this.BTN_Cartão_Debito.Text = "Cartão de Debito";
            this.BTN_Cartão_Debito.UseVisualStyleBackColor = true;
            this.BTN_Cartão_Debito.Click += new System.EventHandler(this.BTN_Cartão_Debito_Click);
            // 
            // BTN_Cartao_Credito
            // 
            this.BTN_Cartao_Credito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cartao_Credito.Location = new System.Drawing.Point(357, 93);
            this.BTN_Cartao_Credito.Name = "BTN_Cartao_Credito";
            this.BTN_Cartao_Credito.Size = new System.Drawing.Size(105, 23);
            this.BTN_Cartao_Credito.TabIndex = 80;
            this.BTN_Cartao_Credito.Text = "Cartão de Crédito";
            this.BTN_Cartao_Credito.UseVisualStyleBackColor = true;
            this.BTN_Cartao_Credito.Click += new System.EventHandler(this.BTN_Cartao_Credito_Click);
            // 
            // DGV_Formas_Pagamento
            // 
            this.DGV_Formas_Pagamento.AllowUserToAddRows = false;
            this.DGV_Formas_Pagamento.AllowUserToDeleteRows = false;
            this.DGV_Formas_Pagamento.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Formas_Pagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Formas_Pagamento.Location = new System.Drawing.Point(10, 62);
            this.DGV_Formas_Pagamento.Name = "DGV_Formas_Pagamento";
            this.DGV_Formas_Pagamento.ReadOnly = true;
            this.DGV_Formas_Pagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Formas_Pagamento.Size = new System.Drawing.Size(341, 198);
            this.DGV_Formas_Pagamento.TabIndex = 77;
            // 
            // BTN_Excluir
            // 
            this.BTN_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Excluir.Image = global::CamadaApresentacao.Properties.Resources.Excluir;
            this.BTN_Excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Excluir.Location = new System.Drawing.Point(10, 19);
            this.BTN_Excluir.Name = "BTN_Excluir";
            this.BTN_Excluir.Size = new System.Drawing.Size(80, 25);
            this.BTN_Excluir.TabIndex = 79;
            this.BTN_Excluir.Text = "         Excluir";
            this.BTN_Excluir.UseVisualStyleBackColor = true;
            this.BTN_Excluir.Click += new System.EventHandler(this.BTN_Excluir_Click);
            // 
            // BTN_Multiformas
            // 
            this.BTN_Multiformas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Multiformas.Enabled = false;
            this.BTN_Multiformas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Multiformas.Location = new System.Drawing.Point(357, 235);
            this.BTN_Multiformas.Name = "BTN_Multiformas";
            this.BTN_Multiformas.Size = new System.Drawing.Size(105, 25);
            this.BTN_Multiformas.TabIndex = 78;
            this.BTN_Multiformas.Text = "Multiformas";
            this.BTN_Multiformas.UseVisualStyleBackColor = true;
            this.BTN_Multiformas.Click += new System.EventHandler(this.BTN_Multiformas_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(920, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(73, 20);
            this.txtId.TabIndex = 47;
            // 
            // btnNova_Venda
            // 
            this.btnNova_Venda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNova_Venda.ForeColor = System.Drawing.Color.Navy;
            this.btnNova_Venda.Image = global::CamadaApresentacao.Properties.Resources.Venda;
            this.btnNova_Venda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNova_Venda.Location = new System.Drawing.Point(55, 110);
            this.btnNova_Venda.Name = "btnNova_Venda";
            this.btnNova_Venda.Size = new System.Drawing.Size(105, 105);
            this.btnNova_Venda.TabIndex = 48;
            this.btnNova_Venda.Text = "Nova Venda";
            this.btnNova_Venda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNova_Venda.UseVisualStyleBackColor = true;
            this.btnNova_Venda.Click += new System.EventHandler(this.btnNova_Venda_Click);
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // btnContas_Pagar
            // 
            this.btnContas_Pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContas_Pagar.FlatAppearance.BorderSize = 0;
            this.btnContas_Pagar.ForeColor = System.Drawing.Color.Navy;
            this.btnContas_Pagar.Image = global::CamadaApresentacao.Properties.Resources.Contas_a_Pagar2;
            this.btnContas_Pagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContas_Pagar.Location = new System.Drawing.Point(55, 372);
            this.btnContas_Pagar.Name = "btnContas_Pagar";
            this.btnContas_Pagar.Size = new System.Drawing.Size(105, 105);
            this.btnContas_Pagar.TabIndex = 65;
            this.btnContas_Pagar.Text = "Contas a Pagar";
            this.btnContas_Pagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContas_Pagar.UseVisualStyleBackColor = true;
            this.btnContas_Pagar.Click += new System.EventHandler(this.btnContas_Pagar_Click);
            // 
            // BTN_Contas_Receber
            // 
            this.BTN_Contas_Receber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Contas_Receber.FlatAppearance.BorderSize = 0;
            this.BTN_Contas_Receber.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Contas_Receber.Image = global::CamadaApresentacao.Properties.Resources.Contas_a_receber;
            this.BTN_Contas_Receber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Contas_Receber.Location = new System.Drawing.Point(55, 252);
            this.BTN_Contas_Receber.Name = "BTN_Contas_Receber";
            this.BTN_Contas_Receber.Size = new System.Drawing.Size(105, 105);
            this.BTN_Contas_Receber.TabIndex = 64;
            this.BTN_Contas_Receber.Text = "Contas a Receber";
            this.BTN_Contas_Receber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Contas_Receber.UseVisualStyleBackColor = true;
            this.BTN_Contas_Receber.Click += new System.EventHandler(this.BTN_Contas_Receber_Click);
            // 
            // DGV_Select_Prod_Cod_Barra
            // 
            this.DGV_Select_Prod_Cod_Barra.AllowUserToAddRows = false;
            this.DGV_Select_Prod_Cod_Barra.AllowUserToDeleteRows = false;
            this.DGV_Select_Prod_Cod_Barra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Select_Prod_Cod_Barra.Location = new System.Drawing.Point(21, 30);
            this.DGV_Select_Prod_Cod_Barra.Name = "DGV_Select_Prod_Cod_Barra";
            this.DGV_Select_Prod_Cod_Barra.ReadOnly = true;
            this.DGV_Select_Prod_Cod_Barra.Size = new System.Drawing.Size(17, 15);
            this.DGV_Select_Prod_Cod_Barra.TabIndex = 66;
            // 
            // Atualizador_Timer
            // 
            this.Atualizador_Timer.Enabled = true;
            this.Atualizador_Timer.Interval = 1000;
            this.Atualizador_Timer.Tick += new System.EventHandler(this.Atualizador_Timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caixaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 25);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(28, 21);
            this.caixaToolStripMenuItem.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 70;
            this.label1.Text = "Guiche:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 687);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 71;
            this.label2.Text = "Operador(a):";
            // 
            // LB_Operador
            // 
            this.LB_Operador.AutoSize = true;
            this.LB_Operador.BackColor = System.Drawing.Color.Navy;
            this.LB_Operador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Operador.ForeColor = System.Drawing.Color.White;
            this.LB_Operador.Location = new System.Drawing.Point(478, 687);
            this.LB_Operador.Name = "LB_Operador";
            this.LB_Operador.Size = new System.Drawing.Size(16, 15);
            this.LB_Operador.TabIndex = 72;
            this.LB_Operador.Text = "C";
            this.LB_Operador.Visible = false;
            // 
            // BTN_Pesquisar_Preco
            // 
            this.BTN_Pesquisar_Preco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisar_Preco.FlatAppearance.BorderSize = 0;
            this.BTN_Pesquisar_Preco.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Pesquisar_Preco.Image = global::CamadaApresentacao.Properties.Resources.Pesquisar_Preco3;
            this.BTN_Pesquisar_Preco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Pesquisar_Preco.Location = new System.Drawing.Point(55, 511);
            this.BTN_Pesquisar_Preco.Name = "BTN_Pesquisar_Preco";
            this.BTN_Pesquisar_Preco.Size = new System.Drawing.Size(105, 105);
            this.BTN_Pesquisar_Preco.TabIndex = 73;
            this.BTN_Pesquisar_Preco.Text = "Pesquisar Preço";
            this.BTN_Pesquisar_Preco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Pesquisar_Preco.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar_Preco.Click += new System.EventHandler(this.BTN_Pesquisar_Preco_Click);
            // 
            // BTN_Novo_Guiche
            // 
            this.BTN_Novo_Guiche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Novo_Guiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Novo_Guiche.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Novo_Guiche.Image = global::CamadaApresentacao.Properties.Resources.Caixa_16x16;
            this.BTN_Novo_Guiche.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Novo_Guiche.Location = new System.Drawing.Point(114, 0);
            this.BTN_Novo_Guiche.Name = "BTN_Novo_Guiche";
            this.BTN_Novo_Guiche.Size = new System.Drawing.Size(108, 25);
            this.BTN_Novo_Guiche.TabIndex = 87;
            this.BTN_Novo_Guiche.Text = "    Novo Guiche";
            this.BTN_Novo_Guiche.UseVisualStyleBackColor = true;
            this.BTN_Novo_Guiche.Click += new System.EventHandler(this.BTN_Novo_Guiche_Click);
            // 
            // BTN_informacoes
            // 
            this.BTN_informacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_informacoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_informacoes.ForeColor = System.Drawing.Color.Navy;
            this.BTN_informacoes.Image = global::CamadaApresentacao.Properties.Resources.Informação_16x16;
            this.BTN_informacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_informacoes.Location = new System.Drawing.Point(10, 0);
            this.BTN_informacoes.Name = "BTN_informacoes";
            this.BTN_informacoes.Size = new System.Drawing.Size(107, 25);
            this.BTN_informacoes.TabIndex = 88;
            this.BTN_informacoes.Text = "      Informações";
            this.BTN_informacoes.UseVisualStyleBackColor = true;
            this.BTN_informacoes.Click += new System.EventHandler(this.BTN_informacoes_Click);
            // 
            // BTN_Importar_OS
            // 
            this.BTN_Importar_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Importar_OS.Enabled = false;
            this.BTN_Importar_OS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Importar_OS.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Importar_OS.Image = global::CamadaApresentacao.Properties.Resources.Importar_16x16;
            this.BTN_Importar_OS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Importar_OS.Location = new System.Drawing.Point(221, 0);
            this.BTN_Importar_OS.Name = "BTN_Importar_OS";
            this.BTN_Importar_OS.Size = new System.Drawing.Size(108, 25);
            this.BTN_Importar_OS.TabIndex = 89;
            this.BTN_Importar_OS.Text = "        Importar O.S.";
            this.BTN_Importar_OS.UseVisualStyleBackColor = true;
            this.BTN_Importar_OS.Click += new System.EventHandler(this.BTN_Importar_OS_Click);
            // 
            // BTN_Importar_Orcamento
            // 
            this.BTN_Importar_Orcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Importar_Orcamento.Enabled = false;
            this.BTN_Importar_Orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Importar_Orcamento.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Importar_Orcamento.Image = global::CamadaApresentacao.Properties.Resources.Importar_16x16;
            this.BTN_Importar_Orcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Importar_Orcamento.Location = new System.Drawing.Point(328, 0);
            this.BTN_Importar_Orcamento.Name = "BTN_Importar_Orcamento";
            this.BTN_Importar_Orcamento.Size = new System.Drawing.Size(135, 25);
            this.BTN_Importar_Orcamento.TabIndex = 90;
            this.BTN_Importar_Orcamento.Text = "        Importar Orçamento";
            this.BTN_Importar_Orcamento.UseVisualStyleBackColor = true;
            this.BTN_Importar_Orcamento.Click += new System.EventHandler(this.BTN_Importar_Orcamento_Click);
            // 
            // FRM_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_FormTPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 720);
            this.Controls.Add(this.BTN_Importar_Orcamento);
            this.Controls.Add(this.BTN_Importar_OS);
            this.Controls.Add(this.BTN_informacoes);
            this.Controls.Add(this.BTN_Novo_Guiche);
            this.Controls.Add(this.BTN_Pesquisar_Preco);
            this.Controls.Add(this.LB_Operador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Select_Prod_Cod_Barra);
            this.Controls.Add(this.btnContas_Pagar);
            this.Controls.Add(this.BTN_Contas_Receber);
            this.Controls.Add(this.btnNova_Venda);
            this.Controls.Add(this.GB_Efetuar_Venda);
            this.Controls.Add(this.LB_Cx_Livre);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtId);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FRM_Caixa";
            this.Text = "Caixa";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Caixa_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Caixa_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Caixa_KeyUp);
            this.GB_Efetuar_Venda.ResumeLayout(false);
            this.GB_Efetuar_Venda.PerformLayout();
            this.GB_Cliente.ResumeLayout(false);
            this.GB_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.DataGridView dataListaDetalhes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox GB_Cliente;
        private System.Windows.Forms.Label LB_Nome_Cliente;
        private System.Windows.Forms.Label LB_Comp;
        private System.Windows.Forms.Label LB_Num_Comp;
        private System.Windows.Forms.Label LB_Titulo_Total_Pagar;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        public System.Windows.Forms.DateTimePicker dtData;
        public System.Windows.Forms.TextBox txtNum_Comprovante;
        private System.Windows.Forms.TextBox TXB_TotalPagar;
        private System.Windows.Forms.DataGridView DGV_Select_Prod_Cod_Barra;
        private System.Windows.Forms.Button BTN_Selecionar_Cliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TXB_IdCliente;
        public System.Windows.Forms.TextBox TXB_Nome_Cliente;
        private System.Windows.Forms.Button BTN_Multiformas;
        public System.Windows.Forms.DataGridView DGV_Formas_Pagamento;
        private System.Windows.Forms.Button BTN_Excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Crediario_Loja;
        private System.Windows.Forms.Button BTN_Dinheiro;
        private System.Windows.Forms.Button BTN_Cartão_Debito;
        private System.Windows.Forms.Button BTN_Cartao_Credito;
        private System.Windows.Forms.CheckBox CHK_Usar_Uma_foma_Pgto;
        public System.Windows.Forms.TextBox TXB_Recebimento;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button BTN_Cheque;
        private System.Windows.Forms.Button BTN_Fechar_Caixa;
        public System.Windows.Forms.Label LB_Troco;
        public System.Windows.Forms.Label LB_Recebido;
        public System.Windows.Forms.TextBox TXT_Recebido;
        public System.Windows.Forms.TextBox TXB_Troco;
        private System.Windows.Forms.Timer Atualizador_Timer;
        public System.Windows.Forms.GroupBox GB_Efetuar_Venda;
        public System.Windows.Forms.Button btnNova_Venda;
        public System.Windows.Forms.Label LB_Cx_Livre;
        public System.Windows.Forms.ComboBox cbTipo_Comprovante;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Deletar_Item;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LB_Operador;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        public System.Windows.Forms.CheckBox CHK_Selecionar;
        public System.Windows.Forms.CheckBox CHK_Venda_Rapida;
        private System.Windows.Forms.Button BTN_Cancelar_Venda;
        public System.Windows.Forms.Button btnContas_Pagar;
        public System.Windows.Forms.Button BTN_Contas_Receber;
        public System.Windows.Forms.Button BTN_Pesquisar_Preco;
        public System.Windows.Forms.TextBox TXB_Entrada_Dinheiro;
        public System.Windows.Forms.TextBox TXB_Valor_Entrada;
        public System.Windows.Forms.Label LB_Entrada;
        public System.Windows.Forms.Label LB_Vaslor_Entrada;
        private System.Windows.Forms.Button BTN_Novo_Guiche;
        private System.Windows.Forms.Button BTN_informacoes;
        public System.Windows.Forms.Button BTN_Importar_OS;
        public System.Windows.Forms.Button BTN_Importar_Orcamento;
    }
}