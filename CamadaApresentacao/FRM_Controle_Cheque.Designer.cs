namespace CamadaApresentacao
{
    partial class FRM_Controle_Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Controle_Cheque));
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.BTN_Compensar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Atualizar_Devolvido = new System.Windows.Forms.Button();
            this.BTN_Atualizar_Depositar = new System.Windows.Forms.Button();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.BTN_Ver_Origem = new System.Windows.Forms.Button();
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            this.LB_Total_Registros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Buscar_Devolvido = new System.Windows.Forms.Button();
            this.BTN_Buscar_Depositado = new System.Windows.Forms.Button();
            this.BTN_Buscar_Aguardando = new System.Windows.Forms.Button();
            this.Buscar_Depositr_Hoje = new System.Windows.Forms.Button();
            this.DGV_Dados = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Modo de exibição atual:";
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Mostrar_Tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mostrar_Tudo.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(913, 478);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(92, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 81;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = true;
            this.BTN_Mostrar_Tudo.Visible = false;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // BTN_Compensar
            // 
            this.BTN_Compensar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Compensar.Enabled = false;
            this.BTN_Compensar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Compensar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Compensar.Image = global::CamadaApresentacao.Properties.Resources.Money;
            this.BTN_Compensar.Location = new System.Drawing.Point(157, 19);
            this.BTN_Compensar.Name = "BTN_Compensar";
            this.BTN_Compensar.Size = new System.Drawing.Size(126, 23);
            this.BTN_Compensar.TabIndex = 89;
            this.BTN_Compensar.Text = "      Compensar";
            this.BTN_Compensar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Compensar.UseVisualStyleBackColor = true;
            this.BTN_Compensar.Click += new System.EventHandler(this.BTN_Compensar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Atualizar_Devolvido);
            this.groupBox1.Controls.Add(this.BTN_Atualizar_Depositar);
            this.groupBox1.Controls.Add(this.BTN_Compensar);
            this.groupBox1.Controls.Add(this.BTN_Deletar);
            this.groupBox1.Controls.Add(this.CHK_Selecionar);
            this.groupBox1.Controls.Add(this.BTN_Ver_Origem);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 90);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // BTN_Atualizar_Devolvido
            // 
            this.BTN_Atualizar_Devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Atualizar_Devolvido.Enabled = false;
            this.BTN_Atualizar_Devolvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Atualizar_Devolvido.ForeColor = System.Drawing.Color.Black;
            this.BTN_Atualizar_Devolvido.Image = global::CamadaApresentacao.Properties.Resources.Atualizar_16x16;
            this.BTN_Atualizar_Devolvido.Location = new System.Drawing.Point(336, 55);
            this.BTN_Atualizar_Devolvido.Name = "BTN_Atualizar_Devolvido";
            this.BTN_Atualizar_Devolvido.Size = new System.Drawing.Size(168, 23);
            this.BTN_Atualizar_Devolvido.TabIndex = 91;
            this.BTN_Atualizar_Devolvido.Text = "    Atualizar para Devolvido";
            this.BTN_Atualizar_Devolvido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Atualizar_Devolvido.UseVisualStyleBackColor = true;
            this.BTN_Atualizar_Devolvido.Click += new System.EventHandler(this.BTN_Atualizar_Devolvido_Click);
            // 
            // BTN_Atualizar_Depositar
            // 
            this.BTN_Atualizar_Depositar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Atualizar_Depositar.Enabled = false;
            this.BTN_Atualizar_Depositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Atualizar_Depositar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Atualizar_Depositar.Image = global::CamadaApresentacao.Properties.Resources.Atualizar_16x16;
            this.BTN_Atualizar_Depositar.Location = new System.Drawing.Point(336, 19);
            this.BTN_Atualizar_Depositar.Name = "BTN_Atualizar_Depositar";
            this.BTN_Atualizar_Depositar.Size = new System.Drawing.Size(168, 23);
            this.BTN_Atualizar_Depositar.TabIndex = 90;
            this.BTN_Atualizar_Depositar.Text = "   Atualizar para Depositado";
            this.BTN_Atualizar_Depositar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Atualizar_Depositar.UseVisualStyleBackColor = true;
            this.BTN_Atualizar_Depositar.Click += new System.EventHandler(this.BTN_Atualizar_Depositar_Click);
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Deletar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Deletar.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.BTN_Deletar.Location = new System.Drawing.Point(15, 55);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(111, 23);
            this.BTN_Deletar.TabIndex = 87;
            this.BTN_Deletar.Text = "      Deletar";
            this.BTN_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.BackColor = System.Drawing.Color.Transparent;
            this.CHK_Selecionar.ForeColor = System.Drawing.Color.Black;
            this.CHK_Selecionar.Location = new System.Drawing.Point(33, 23);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 88;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = false;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // BTN_Ver_Origem
            // 
            this.BTN_Ver_Origem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ver_Origem.Enabled = false;
            this.BTN_Ver_Origem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ver_Origem.ForeColor = System.Drawing.Color.Black;
            this.BTN_Ver_Origem.Image = global::CamadaApresentacao.Properties.Resources.Ver_16x16;
            this.BTN_Ver_Origem.Location = new System.Drawing.Point(157, 55);
            this.BTN_Ver_Origem.Name = "BTN_Ver_Origem";
            this.BTN_Ver_Origem.Size = new System.Drawing.Size(126, 23);
            this.BTN_Ver_Origem.TabIndex = 68;
            this.BTN_Ver_Origem.Text = "      Ver Origem";
            this.BTN_Ver_Origem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ver_Origem.UseVisualStyleBackColor = true;
            this.BTN_Ver_Origem.Click += new System.EventHandler(this.BTN_Ver_Origem_Click);
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Navy;
            this.LB_Modo_Exibicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Modo_Exibicao.ForeColor = System.Drawing.Color.White;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(158, 483);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(34, 13);
            this.LB_Modo_Exibicao.TabIndex = 83;
            this.LB_Modo_Exibicao.Text = "label";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // LB_Total_Registros
            // 
            this.LB_Total_Registros.AutoSize = true;
            this.LB_Total_Registros.BackColor = System.Drawing.Color.Navy;
            this.LB_Total_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total_Registros.ForeColor = System.Drawing.Color.White;
            this.LB_Total_Registros.Location = new System.Drawing.Point(604, 483);
            this.LB_Total_Registros.Name = "LB_Total_Registros";
            this.LB_Total_Registros.Size = new System.Drawing.Size(34, 13);
            this.LB_Total_Registros.TabIndex = 78;
            this.LB_Total_Registros.Text = "label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total de registros:";
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 35;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BTN_Buscar_Devolvido);
            this.groupBox3.Controls.Add(this.BTN_Buscar_Depositado);
            this.groupBox3.Controls.Add(this.BTN_Buscar_Aguardando);
            this.groupBox3.Controls.Add(this.Buscar_Depositr_Hoje);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(651, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 90);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar Cheques";
            // 
            // BTN_Buscar_Devolvido
            // 
            this.BTN_Buscar_Devolvido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Buscar_Devolvido.ForeColor = System.Drawing.Color.Black;
            this.BTN_Buscar_Devolvido.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Buscar_Devolvido.Location = new System.Drawing.Point(169, 55);
            this.BTN_Buscar_Devolvido.Name = "BTN_Buscar_Devolvido";
            this.BTN_Buscar_Devolvido.Size = new System.Drawing.Size(123, 23);
            this.BTN_Buscar_Devolvido.TabIndex = 3;
            this.BTN_Buscar_Devolvido.Text = "     Devolvido";
            this.BTN_Buscar_Devolvido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Buscar_Devolvido.UseVisualStyleBackColor = true;
            this.BTN_Buscar_Devolvido.Click += new System.EventHandler(this.BTN_Buscar_Devolvido_Click);
            // 
            // BTN_Buscar_Depositado
            // 
            this.BTN_Buscar_Depositado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Buscar_Depositado.ForeColor = System.Drawing.Color.Black;
            this.BTN_Buscar_Depositado.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Buscar_Depositado.Location = new System.Drawing.Point(169, 19);
            this.BTN_Buscar_Depositado.Name = "BTN_Buscar_Depositado";
            this.BTN_Buscar_Depositado.Size = new System.Drawing.Size(123, 23);
            this.BTN_Buscar_Depositado.TabIndex = 2;
            this.BTN_Buscar_Depositado.Text = "    Depositado";
            this.BTN_Buscar_Depositado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Buscar_Depositado.UseVisualStyleBackColor = true;
            this.BTN_Buscar_Depositado.Click += new System.EventHandler(this.BTN_Buscar_Depositado_Click);
            // 
            // BTN_Buscar_Aguardando
            // 
            this.BTN_Buscar_Aguardando.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Buscar_Aguardando.ForeColor = System.Drawing.Color.Black;
            this.BTN_Buscar_Aguardando.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Buscar_Aguardando.Location = new System.Drawing.Point(16, 55);
            this.BTN_Buscar_Aguardando.Name = "BTN_Buscar_Aguardando";
            this.BTN_Buscar_Aguardando.Size = new System.Drawing.Size(123, 23);
            this.BTN_Buscar_Aguardando.TabIndex = 1;
            this.BTN_Buscar_Aguardando.Text = "    Aguardando";
            this.BTN_Buscar_Aguardando.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Buscar_Aguardando.UseVisualStyleBackColor = true;
            this.BTN_Buscar_Aguardando.Click += new System.EventHandler(this.BTN_Buscar_Aguardando_Click);
            // 
            // Buscar_Depositr_Hoje
            // 
            this.Buscar_Depositr_Hoje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar_Depositr_Hoje.ForeColor = System.Drawing.Color.Black;
            this.Buscar_Depositr_Hoje.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.Buscar_Depositr_Hoje.Location = new System.Drawing.Point(16, 19);
            this.Buscar_Depositr_Hoje.Name = "Buscar_Depositr_Hoje";
            this.Buscar_Depositr_Hoje.Size = new System.Drawing.Size(123, 23);
            this.Buscar_Depositr_Hoje.TabIndex = 0;
            this.Buscar_Depositr_Hoje.Text = "   Depositar Hoje";
            this.Buscar_Depositr_Hoje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Buscar_Depositr_Hoje.UseVisualStyleBackColor = true;
            this.Buscar_Depositr_Hoje.Click += new System.EventHandler(this.Buscar_Depositr_Hoje_Click);
            // 
            // DGV_Dados
            // 
            this.DGV_Dados.AllowUserToAddRows = false;
            this.DGV_Dados.AllowUserToDeleteRows = false;
            this.DGV_Dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.DGV_Dados.Location = new System.Drawing.Point(16, 118);
            this.DGV_Dados.Name = "DGV_Dados";
            this.DGV_Dados.ReadOnly = true;
            this.DGV_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Dados.Size = new System.Drawing.Size(989, 354);
            this.DGV_Dados.TabIndex = 76;
            this.DGV_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Dados_CellContentClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(1011, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 501);
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 501);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 478);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1021, 23);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1021, 10);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Controle_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 501);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Mostrar_Tudo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_Modo_Exibicao);
            this.Controls.Add(this.LB_Total_Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DGV_Dados);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Controle_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cheque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Controle_Cheque_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Controle_Cheque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        private System.Windows.Forms.Button BTN_Compensar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Deletar;
        public System.Windows.Forms.CheckBox CHK_Selecionar;
        private System.Windows.Forms.Button BTN_Ver_Origem;
        private System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Label LB_Total_Registros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DGV_Dados;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Buscar_Depositr_Hoje;
        private System.Windows.Forms.Button BTN_Buscar_Devolvido;
        private System.Windows.Forms.Button BTN_Buscar_Depositado;
        private System.Windows.Forms.Button BTN_Buscar_Aguardando;
        private System.Windows.Forms.Button BTN_Atualizar_Devolvido;
        private System.Windows.Forms.Button BTN_Atualizar_Depositar;
    }
}