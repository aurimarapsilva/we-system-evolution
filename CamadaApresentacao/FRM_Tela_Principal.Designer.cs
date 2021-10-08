namespace CamadaApresentacao
{
    partial class FRM_Tela_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tela_Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Clientes = new System.Windows.Forms.Button();
            this.BTN_Estoque = new System.Windows.Forms.Button();
            this.BTN_Fornecedores = new System.Windows.Forms.Button();
            this.BTN_Funcionarios = new System.Windows.Forms.Button();
            this.BTN_Caixa = new System.Windows.Forms.Button();
            this.BTN_Contas_Receber = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Nome = new System.Windows.Forms.Label();
            this.LB_Acesso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnContas_Pagar = new System.Windows.Forms.Button();
            this.BTN_Relatorio = new System.Windows.Forms.Button();
            this.BTN_OS = new System.Windows.Forms.Button();
            this.Time_Atualizacao_Apos_Deletar_Entrada = new System.Windows.Forms.Timer(this.components);
            this.BTN_Outras_Financas = new System.Windows.Forms.Button();
            this.BTN_Listagem_Vendas = new System.Windows.Forms.Button();
            this.BTN_Backup = new System.Windows.Forms.Button();
            this.BTN_Configuracoes = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Desbloquear = new System.Windows.Forms.Button();
            this.BTN_Licenciamento = new System.Windows.Forms.Button();
            this.BTN_Pesquisar_Preco = new System.Windows.Forms.Button();
            this.BTN_Etiquetas = new System.Windows.Forms.Button();
            this.BTN_Orcamento = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Enabled = false;
            this.sToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.sToolStripMenuItem.Text = "S";
            // 
            // BTN_Clientes
            // 
            this.BTN_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Clientes.FlatAppearance.BorderSize = 0;
            this.BTN_Clientes.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Clientes.Image = global::CamadaApresentacao.Properties.Resources.Clientes;
            this.BTN_Clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Clientes.Location = new System.Drawing.Point(545, 170);
            this.BTN_Clientes.Name = "BTN_Clientes";
            this.BTN_Clientes.Size = new System.Drawing.Size(105, 105);
            this.BTN_Clientes.TabIndex = 6;
            this.BTN_Clientes.Text = "Clientes";
            this.BTN_Clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Clientes.UseVisualStyleBackColor = true;
            this.BTN_Clientes.Click += new System.EventHandler(this.BTN_Clientes_Click);
            // 
            // BTN_Estoque
            // 
            this.BTN_Estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Estoque.FlatAppearance.BorderSize = 0;
            this.BTN_Estoque.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Estoque.Image = global::CamadaApresentacao.Properties.Resources.Estoque;
            this.BTN_Estoque.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Estoque.Location = new System.Drawing.Point(668, 170);
            this.BTN_Estoque.Name = "BTN_Estoque";
            this.BTN_Estoque.Size = new System.Drawing.Size(105, 105);
            this.BTN_Estoque.TabIndex = 7;
            this.BTN_Estoque.Text = "Estoque";
            this.BTN_Estoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Estoque.UseVisualStyleBackColor = true;
            this.BTN_Estoque.Click += new System.EventHandler(this.BTN_Estoque_Click);
            // 
            // BTN_Fornecedores
            // 
            this.BTN_Fornecedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Fornecedores.FlatAppearance.BorderSize = 0;
            this.BTN_Fornecedores.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Fornecedores.Image = global::CamadaApresentacao.Properties.Resources.Fornecedores;
            this.BTN_Fornecedores.Location = new System.Drawing.Point(791, 170);
            this.BTN_Fornecedores.Name = "BTN_Fornecedores";
            this.BTN_Fornecedores.Size = new System.Drawing.Size(105, 105);
            this.BTN_Fornecedores.TabIndex = 8;
            this.BTN_Fornecedores.Text = "Fornecedores";
            this.BTN_Fornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Fornecedores.UseVisualStyleBackColor = true;
            this.BTN_Fornecedores.Click += new System.EventHandler(this.BTN_Fornecedores_Click);
            // 
            // BTN_Funcionarios
            // 
            this.BTN_Funcionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Funcionarios.FlatAppearance.BorderSize = 0;
            this.BTN_Funcionarios.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Funcionarios.Image = global::CamadaApresentacao.Properties.Resources.Funcionarios;
            this.BTN_Funcionarios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Funcionarios.Location = new System.Drawing.Point(911, 170);
            this.BTN_Funcionarios.Name = "BTN_Funcionarios";
            this.BTN_Funcionarios.Size = new System.Drawing.Size(105, 105);
            this.BTN_Funcionarios.TabIndex = 9;
            this.BTN_Funcionarios.Text = "Funcionários";
            this.BTN_Funcionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Funcionarios.UseVisualStyleBackColor = true;
            this.BTN_Funcionarios.Click += new System.EventHandler(this.BTN_Funcionarios_Click);
            // 
            // BTN_Caixa
            // 
            this.BTN_Caixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Caixa.FlatAppearance.BorderSize = 0;
            this.BTN_Caixa.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Caixa.Image = global::CamadaApresentacao.Properties.Resources.Livro_Caixa4;
            this.BTN_Caixa.Location = new System.Drawing.Point(545, 290);
            this.BTN_Caixa.Name = "BTN_Caixa";
            this.BTN_Caixa.Size = new System.Drawing.Size(105, 105);
            this.BTN_Caixa.TabIndex = 10;
            this.BTN_Caixa.Text = "Livro Caixa";
            this.BTN_Caixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Caixa.UseVisualStyleBackColor = true;
            this.BTN_Caixa.Click += new System.EventHandler(this.BTN_Caixa_Click);
            // 
            // BTN_Contas_Receber
            // 
            this.BTN_Contas_Receber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Contas_Receber.FlatAppearance.BorderSize = 0;
            this.BTN_Contas_Receber.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Contas_Receber.Image = global::CamadaApresentacao.Properties.Resources.Contas_a_receber;
            this.BTN_Contas_Receber.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Contas_Receber.Location = new System.Drawing.Point(668, 290);
            this.BTN_Contas_Receber.Name = "BTN_Contas_Receber";
            this.BTN_Contas_Receber.Size = new System.Drawing.Size(105, 105);
            this.BTN_Contas_Receber.TabIndex = 11;
            this.BTN_Contas_Receber.Text = "Contas a Receber";
            this.BTN_Contas_Receber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Contas_Receber.UseVisualStyleBackColor = true;
            this.BTN_Contas_Receber.Click += new System.EventHandler(this.BTN_Contas_Receber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(612, 687);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário Logado:";
            // 
            // LB_Nome
            // 
            this.LB_Nome.AutoSize = true;
            this.LB_Nome.BackColor = System.Drawing.Color.Transparent;
            this.LB_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Nome.ForeColor = System.Drawing.Color.White;
            this.LB_Nome.Location = new System.Drawing.Point(727, 687);
            this.LB_Nome.Name = "LB_Nome";
            this.LB_Nome.Size = new System.Drawing.Size(47, 15);
            this.LB_Nome.TabIndex = 13;
            this.LB_Nome.Text = "label2";
            // 
            // LB_Acesso
            // 
            this.LB_Acesso.AutoSize = true;
            this.LB_Acesso.BackColor = System.Drawing.Color.Transparent;
            this.LB_Acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Acesso.ForeColor = System.Drawing.Color.White;
            this.LB_Acesso.Location = new System.Drawing.Point(1182, 687);
            this.LB_Acesso.Name = "LB_Acesso";
            this.LB_Acesso.Size = new System.Drawing.Size(47, 15);
            this.LB_Acesso.TabIndex = 15;
            this.LB_Acesso.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1070, 687);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nível de Acesso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::CamadaApresentacao.Properties.Resources.User_Logado;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(590, 681);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 27);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.ForeColor = System.Drawing.Color.Navy;
            this.btnCaixa.Image = global::CamadaApresentacao.Properties.Resources.Caixa_Icone2;
            this.btnCaixa.Location = new System.Drawing.Point(243, 290);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(105, 105);
            this.btnCaixa.TabIndex = 18;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // btnContas_Pagar
            // 
            this.btnContas_Pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContas_Pagar.FlatAppearance.BorderSize = 0;
            this.btnContas_Pagar.ForeColor = System.Drawing.Color.Navy;
            this.btnContas_Pagar.Image = global::CamadaApresentacao.Properties.Resources.Contas_a_Pagar2;
            this.btnContas_Pagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContas_Pagar.Location = new System.Drawing.Point(793, 290);
            this.btnContas_Pagar.Name = "btnContas_Pagar";
            this.btnContas_Pagar.Size = new System.Drawing.Size(105, 105);
            this.btnContas_Pagar.TabIndex = 19;
            this.btnContas_Pagar.Text = "Contas a Pagar";
            this.btnContas_Pagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnContas_Pagar.UseVisualStyleBackColor = true;
            this.btnContas_Pagar.Click += new System.EventHandler(this.btnContas_Pagar_Click);
            // 
            // BTN_Relatorio
            // 
            this.BTN_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Relatorio.FlatAppearance.BorderSize = 0;
            this.BTN_Relatorio.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Relatorio.Image = global::CamadaApresentacao.Properties.Resources.BTN_Report_Oficial;
            this.BTN_Relatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Relatorio.Location = new System.Drawing.Point(911, 410);
            this.BTN_Relatorio.Name = "BTN_Relatorio";
            this.BTN_Relatorio.Size = new System.Drawing.Size(105, 105);
            this.BTN_Relatorio.TabIndex = 20;
            this.BTN_Relatorio.Text = "Relatórios";
            this.BTN_Relatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Relatorio.UseVisualStyleBackColor = true;
            this.BTN_Relatorio.Click += new System.EventHandler(this.BTN_Relatorio_Click);
            // 
            // BTN_OS
            // 
            this.BTN_OS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OS.FlatAppearance.BorderSize = 0;
            this.BTN_OS.ForeColor = System.Drawing.Color.Navy;
            this.BTN_OS.Image = global::CamadaApresentacao.Properties.Resources.OS3;
            this.BTN_OS.Location = new System.Drawing.Point(545, 410);
            this.BTN_OS.Name = "BTN_OS";
            this.BTN_OS.Size = new System.Drawing.Size(105, 105);
            this.BTN_OS.TabIndex = 23;
            this.BTN_OS.Text = " Ordem de Serviço";
            this.BTN_OS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_OS.UseVisualStyleBackColor = true;
            this.BTN_OS.Click += new System.EventHandler(this.BTN_OS_Click);
            // 
            // Time_Atualizacao_Apos_Deletar_Entrada
            // 
            this.Time_Atualizacao_Apos_Deletar_Entrada.Enabled = true;
            this.Time_Atualizacao_Apos_Deletar_Entrada.Interval = 1000;
            this.Time_Atualizacao_Apos_Deletar_Entrada.Tick += new System.EventHandler(this.Time_Atualizacao_Apos_Deletar_Entrada_Tick);
            // 
            // BTN_Outras_Financas
            // 
            this.BTN_Outras_Financas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Outras_Financas.FlatAppearance.BorderSize = 0;
            this.BTN_Outras_Financas.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Outras_Financas.Image = global::CamadaApresentacao.Properties.Resources.Outras_Financas85x55;
            this.BTN_Outras_Financas.Location = new System.Drawing.Point(911, 290);
            this.BTN_Outras_Financas.Name = "BTN_Outras_Financas";
            this.BTN_Outras_Financas.Size = new System.Drawing.Size(105, 105);
            this.BTN_Outras_Financas.TabIndex = 24;
            this.BTN_Outras_Financas.Text = "Outras Finanças";
            this.BTN_Outras_Financas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Outras_Financas.UseVisualStyleBackColor = true;
            this.BTN_Outras_Financas.Click += new System.EventHandler(this.BTN_Outras_Financas_Click);
            // 
            // BTN_Listagem_Vendas
            // 
            this.BTN_Listagem_Vendas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Listagem_Vendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Listagem_Vendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Listagem_Vendas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Listagem_Vendas.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Listagem_Vendas.Image = global::CamadaApresentacao.Properties.Resources.Ver_Vendas_16x16;
            this.BTN_Listagem_Vendas.Location = new System.Drawing.Point(12, 0);
            this.BTN_Listagem_Vendas.Name = "BTN_Listagem_Vendas";
            this.BTN_Listagem_Vendas.Size = new System.Drawing.Size(184, 28);
            this.BTN_Listagem_Vendas.TabIndex = 25;
            this.BTN_Listagem_Vendas.Text = "   Listagem das Vendas";
            this.BTN_Listagem_Vendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Listagem_Vendas.UseVisualStyleBackColor = false;
            this.BTN_Listagem_Vendas.Click += new System.EventHandler(this.BTN_Listagem_Vendas_Click);
            // 
            // BTN_Backup
            // 
            this.BTN_Backup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Backup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Backup.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Backup.Image = global::CamadaApresentacao.Properties.Resources.Backup_16x16;
            this.BTN_Backup.Location = new System.Drawing.Point(192, 0);
            this.BTN_Backup.Name = "BTN_Backup";
            this.BTN_Backup.Size = new System.Drawing.Size(96, 28);
            this.BTN_Backup.TabIndex = 26;
            this.BTN_Backup.Text = "   Backup";
            this.BTN_Backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Backup.UseVisualStyleBackColor = false;
            this.BTN_Backup.Click += new System.EventHandler(this.BTN_Backup_Click);
            // 
            // BTN_Configuracoes
            // 
            this.BTN_Configuracoes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Configuracoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Configuracoes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Configuracoes.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Configuracoes.Image = global::CamadaApresentacao.Properties.Resources.Config_16x16;
            this.BTN_Configuracoes.Location = new System.Drawing.Point(281, 0);
            this.BTN_Configuracoes.Name = "BTN_Configuracoes";
            this.BTN_Configuracoes.Size = new System.Drawing.Size(137, 28);
            this.BTN_Configuracoes.TabIndex = 27;
            this.BTN_Configuracoes.Text = "  Configurações";
            this.BTN_Configuracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Configuracoes.UseVisualStyleBackColor = false;
            this.BTN_Configuracoes.Click += new System.EventHandler(this.BTN_Configuracoes_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Sair.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Saida_16x16;
            this.BTN_Sair.Location = new System.Drawing.Point(678, 0);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(76, 28);
            this.BTN_Sair.TabIndex = 28;
            this.BTN_Sair.Text = "   Sair";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Desbloquear
            // 
            this.BTN_Desbloquear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Desbloquear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Desbloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Desbloquear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Desbloquear.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Desbloquear.Image = global::CamadaApresentacao.Properties.Resources.Desbloqiear_16x16;
            this.BTN_Desbloquear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Desbloquear.Location = new System.Drawing.Point(752, 0);
            this.BTN_Desbloquear.Name = "BTN_Desbloquear";
            this.BTN_Desbloquear.Size = new System.Drawing.Size(194, 28);
            this.BTN_Desbloquear.TabIndex = 29;
            this.BTN_Desbloquear.Text = "   Desbloquear Sistema";
            this.BTN_Desbloquear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Desbloquear.UseVisualStyleBackColor = false;
            this.BTN_Desbloquear.Visible = false;
            this.BTN_Desbloquear.Click += new System.EventHandler(this.BTN_Desbloquear_Click);
            // 
            // BTN_Licenciamento
            // 
            this.BTN_Licenciamento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Licenciamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Licenciamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Licenciamento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Licenciamento.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Licenciamento.Image = global::CamadaApresentacao.Properties.Resources.Chave_16x16;
            this.BTN_Licenciamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Licenciamento.Location = new System.Drawing.Point(415, 0);
            this.BTN_Licenciamento.Name = "BTN_Licenciamento";
            this.BTN_Licenciamento.Size = new System.Drawing.Size(149, 28);
            this.BTN_Licenciamento.TabIndex = 30;
            this.BTN_Licenciamento.Text = "   Licenciamento";
            this.BTN_Licenciamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Licenciamento.UseVisualStyleBackColor = false;
            this.BTN_Licenciamento.Click += new System.EventHandler(this.BTN_Licenciamento_Click);
            // 
            // BTN_Pesquisar_Preco
            // 
            this.BTN_Pesquisar_Preco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisar_Preco.FlatAppearance.BorderSize = 0;
            this.BTN_Pesquisar_Preco.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Pesquisar_Preco.Image = global::CamadaApresentacao.Properties.Resources.Pesquisar_Preco3;
            this.BTN_Pesquisar_Preco.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Pesquisar_Preco.Location = new System.Drawing.Point(793, 410);
            this.BTN_Pesquisar_Preco.Name = "BTN_Pesquisar_Preco";
            this.BTN_Pesquisar_Preco.Size = new System.Drawing.Size(105, 105);
            this.BTN_Pesquisar_Preco.TabIndex = 74;
            this.BTN_Pesquisar_Preco.Text = "Pesquisar Preço";
            this.BTN_Pesquisar_Preco.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Pesquisar_Preco.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar_Preco.Click += new System.EventHandler(this.BTN_Pesquisar_Preco_Click);
            // 
            // BTN_Etiquetas
            // 
            this.BTN_Etiquetas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BTN_Etiquetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Etiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Etiquetas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Etiquetas.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Etiquetas.Image = global::CamadaApresentacao.Properties.Resources.Etiquetas;
            this.BTN_Etiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Etiquetas.Location = new System.Drawing.Point(561, 0);
            this.BTN_Etiquetas.Name = "BTN_Etiquetas";
            this.BTN_Etiquetas.Size = new System.Drawing.Size(118, 28);
            this.BTN_Etiquetas.TabIndex = 75;
            this.BTN_Etiquetas.Text = "   Etiquetas";
            this.BTN_Etiquetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Etiquetas.UseVisualStyleBackColor = false;
            this.BTN_Etiquetas.Click += new System.EventHandler(this.BTN_Etiquetas_Click);
            // 
            // BTN_Orcamento
            // 
            this.BTN_Orcamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Orcamento.FlatAppearance.BorderSize = 0;
            this.BTN_Orcamento.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Orcamento.Image = global::CamadaApresentacao.Properties.Resources.Orcamento;
            this.BTN_Orcamento.Location = new System.Drawing.Point(668, 410);
            this.BTN_Orcamento.Name = "BTN_Orcamento";
            this.BTN_Orcamento.Size = new System.Drawing.Size(105, 105);
            this.BTN_Orcamento.TabIndex = 76;
            this.BTN_Orcamento.Text = " Orçamento";
            this.BTN_Orcamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Orcamento.UseVisualStyleBackColor = true;
            this.BTN_Orcamento.Click += new System.EventHandler(this.BTN_Orcamento_Click);
            // 
            // FRM_Tela_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_FormTPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 713);
            this.Controls.Add(this.BTN_Orcamento);
            this.Controls.Add(this.BTN_Etiquetas);
            this.Controls.Add(this.BTN_Pesquisar_Preco);
            this.Controls.Add(this.BTN_Licenciamento);
            this.Controls.Add(this.BTN_Desbloquear);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Configuracoes);
            this.Controls.Add(this.BTN_Backup);
            this.Controls.Add(this.BTN_Listagem_Vendas);
            this.Controls.Add(this.BTN_Outras_Financas);
            this.Controls.Add(this.BTN_OS);
            this.Controls.Add(this.BTN_Relatorio);
            this.Controls.Add(this.btnContas_Pagar);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LB_Acesso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LB_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Contas_Receber);
            this.Controls.Add(this.BTN_Caixa);
            this.Controls.Add(this.BTN_Funcionarios);
            this.Controls.Add(this.BTN_Fornecedores);
            this.Controls.Add(this.BTN_Estoque);
            this.Controls.Add(this.BTN_Clientes);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Tela_Principal";
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Tela_Principal_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Tela_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button BTN_Clientes;
        private System.Windows.Forms.Button BTN_Estoque;
        private System.Windows.Forms.Button BTN_Fornecedores;
        private System.Windows.Forms.Button BTN_Funcionarios;
        private System.Windows.Forms.Button BTN_Caixa;
        private System.Windows.Forms.Button BTN_Contas_Receber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Nome;
        private System.Windows.Forms.Label LB_Acesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnContas_Pagar;
        private System.Windows.Forms.Button BTN_Relatorio;
        private System.Windows.Forms.Button BTN_OS;
        private System.Windows.Forms.Button BTN_Outras_Financas;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.Button BTN_Listagem_Vendas;
        private System.Windows.Forms.Button BTN_Backup;
        private System.Windows.Forms.Button BTN_Configuracoes;
        private System.Windows.Forms.Button BTN_Sair;
        public System.Windows.Forms.Button BTN_Desbloquear;
        public System.Windows.Forms.Button BTN_Licenciamento;
        public System.Windows.Forms.Button BTN_Pesquisar_Preco;
        public System.Windows.Forms.Timer Time_Atualizacao_Apos_Deletar_Entrada;
        public System.Windows.Forms.Button BTN_Etiquetas;
        private System.Windows.Forms.Button BTN_Orcamento;
    }
}