namespace CamadaApresentacao
{
    partial class FRM_Controle_Cartao_Credito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Controle_Cartao_Credito));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DGV_Dados = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Total_Registros = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar_Datas = new System.Windows.Forms.Button();
            this.BTN_Ver_Origem = new System.Windows.Forms.Button();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Compensar = new System.Windows.Forms.Button();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 10);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 434);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(887, 23);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 454);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(877, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 454);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // DGV_Dados
            // 
            this.DGV_Dados.AllowUserToAddRows = false;
            this.DGV_Dados.AllowUserToDeleteRows = false;
            this.DGV_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.DGV_Dados.Location = new System.Drawing.Point(18, 95);
            this.DGV_Dados.Name = "DGV_Dados";
            this.DGV_Dados.ReadOnly = true;
            this.DGV_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Dados.Size = new System.Drawing.Size(853, 333);
            this.DGV_Dados.TabIndex = 4;
            this.DGV_Dados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Dados_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total de registros:";
            // 
            // LB_Total_Registros
            // 
            this.LB_Total_Registros.AutoSize = true;
            this.LB_Total_Registros.BackColor = System.Drawing.Color.Navy;
            this.LB_Total_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total_Registros.ForeColor = System.Drawing.Color.White;
            this.LB_Total_Registros.Location = new System.Drawing.Point(506, 439);
            this.LB_Total_Registros.Name = "LB_Total_Registros";
            this.LB_Total_Registros.Size = new System.Drawing.Size(34, 13);
            this.LB_Total_Registros.TabIndex = 6;
            this.LB_Total_Registros.Text = "label";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dtInicial);
            this.groupBox3.Controls.Add(this.dtFinal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnBuscar_Datas);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(432, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 73);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa por Datas";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(87, 19);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(100, 20);
            this.dtInicial.TabIndex = 8;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(87, 47);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(100, 20);
            this.dtFinal.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Inicial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data Final";
            // 
            // btnBuscar_Datas
            // 
            this.btnBuscar_Datas.BackgroundImage = global::CamadaApresentacao.Properties.Resources.buscar3;
            this.btnBuscar_Datas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_Datas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_Datas.Location = new System.Drawing.Point(205, 28);
            this.btnBuscar_Datas.Name = "btnBuscar_Datas";
            this.btnBuscar_Datas.Size = new System.Drawing.Size(29, 28);
            this.btnBuscar_Datas.TabIndex = 11;
            this.btnBuscar_Datas.UseVisualStyleBackColor = true;
            this.btnBuscar_Datas.Click += new System.EventHandler(this.btnBuscar_Datas_Click);
            // 
            // BTN_Ver_Origem
            // 
            this.BTN_Ver_Origem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ver_Origem.Enabled = false;
            this.BTN_Ver_Origem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Ver_Origem.ForeColor = System.Drawing.Color.Black;
            this.BTN_Ver_Origem.Image = global::CamadaApresentacao.Properties.Resources.Ver_16x16;
            this.BTN_Ver_Origem.Location = new System.Drawing.Point(172, 40);
            this.BTN_Ver_Origem.Name = "BTN_Ver_Origem";
            this.BTN_Ver_Origem.Size = new System.Drawing.Size(126, 23);
            this.BTN_Ver_Origem.TabIndex = 68;
            this.BTN_Ver_Origem.Text = "      Ver Origem";
            this.BTN_Ver_Origem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Ver_Origem.UseVisualStyleBackColor = true;
            this.BTN_Ver_Origem.Click += new System.EventHandler(this.BTN_Ver_Origem_Click);
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Deletar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Deletar.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.BTN_Deletar.Location = new System.Drawing.Point(26, 40);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(115, 23);
            this.BTN_Deletar.TabIndex = 87;
            this.BTN_Deletar.Text = "       Deletar";
            this.BTN_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.BackColor = System.Drawing.Color.Transparent;
            this.CHK_Selecionar.ForeColor = System.Drawing.Color.Black;
            this.CHK_Selecionar.Location = new System.Drawing.Point(48, 17);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 88;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = false;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Compensar);
            this.groupBox1.Controls.Add(this.BTN_Deletar);
            this.groupBox1.Controls.Add(this.CHK_Selecionar);
            this.groupBox1.Controls.Add(this.BTN_Ver_Origem);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 73);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // BTN_Compensar
            // 
            this.BTN_Compensar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Compensar.Enabled = false;
            this.BTN_Compensar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Compensar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Compensar.Image = global::CamadaApresentacao.Properties.Resources.Money;
            this.BTN_Compensar.Location = new System.Drawing.Point(172, 13);
            this.BTN_Compensar.Name = "BTN_Compensar";
            this.BTN_Compensar.Size = new System.Drawing.Size(126, 23);
            this.BTN_Compensar.TabIndex = 89;
            this.BTN_Compensar.Text = "      Compensar";
            this.BTN_Compensar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Compensar.UseVisualStyleBackColor = true;
            this.BTN_Compensar.Click += new System.EventHandler(this.BTN_Compensar_Click);
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Mostrar_Tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mostrar_Tudo.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(779, 434);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(92, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 69;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = true;
            this.BTN_Mostrar_Tudo.Visible = false;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Navy;
            this.LB_Modo_Exibicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Modo_Exibicao.ForeColor = System.Drawing.Color.White;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(158, 439);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(34, 13);
            this.LB_Modo_Exibicao.TabIndex = 71;
            this.LB_Modo_Exibicao.Text = "label";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Modo de exibição atual:";
            // 
            // FRM_Controle_Cartao_Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 457);
            this.Controls.Add(this.LB_Modo_Exibicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BTN_Mostrar_Tudo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LB_Total_Registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Dados);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Controle_Cartao_Credito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Cartão de Crédito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Controle_Cartao_Credito_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Controle_Cartao_Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView DGV_Dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Total_Registros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar_Datas;
        private System.Windows.Forms.Button BTN_Ver_Origem;
        private System.Windows.Forms.Button BTN_Deletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Compensar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        public System.Windows.Forms.CheckBox CHK_Selecionar;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        private System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Label label4;
    }
}