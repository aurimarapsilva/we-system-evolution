namespace CamadaApresentacao
{
    partial class FRM_Caixa_Operacao_Dia
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DGV_Dados = new System.Windows.Forms.DataGridView();
            this.LB_Total_Registros = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscar_Datas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Pesquisar_Caixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Caixa = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Pesquisar_Funcionario = new System.Windows.Forms.Button();
            this.CB_Funcionario = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(1, 536);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(926, 23);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(9, 559);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(917, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(9, 559);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // DGV_Dados
            // 
            this.DGV_Dados.AllowUserToAddRows = false;
            this.DGV_Dados.AllowUserToDeleteRows = false;
            this.DGV_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Dados.Location = new System.Drawing.Point(28, 179);
            this.DGV_Dados.Name = "DGV_Dados";
            this.DGV_Dados.ReadOnly = true;
            this.DGV_Dados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Dados.Size = new System.Drawing.Size(872, 345);
            this.DGV_Dados.TabIndex = 30;
            // 
            // LB_Total_Registros
            // 
            this.LB_Total_Registros.AutoSize = true;
            this.LB_Total_Registros.BackColor = System.Drawing.Color.Navy;
            this.LB_Total_Registros.ForeColor = System.Drawing.Color.White;
            this.LB_Total_Registros.Location = new System.Drawing.Point(475, 541);
            this.LB_Total_Registros.Name = "LB_Total_Registros";
            this.LB_Total_Registros.Size = new System.Drawing.Size(35, 13);
            this.LB_Total_Registros.TabIndex = 31;
            this.LB_Total_Registros.Text = "label1";
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
            this.groupBox3.Location = new System.Drawing.Point(329, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 116);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa por Datas";
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(24, 37);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(116, 20);
            this.dtInicial.TabIndex = 8;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(24, 81);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(116, 20);
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
            this.label9.Location = new System.Drawing.Point(21, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Data Final";
            // 
            // btnBuscar_Datas
            // 
            this.btnBuscar_Datas.BackgroundImage = global::CamadaApresentacao.Properties.Resources.buscar3;
            this.btnBuscar_Datas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar_Datas.Location = new System.Drawing.Point(171, 52);
            this.btnBuscar_Datas.Name = "btnBuscar_Datas";
            this.btnBuscar_Datas.Size = new System.Drawing.Size(29, 28);
            this.btnBuscar_Datas.TabIndex = 11;
            this.btnBuscar_Datas.UseVisualStyleBackColor = true;
            this.btnBuscar_Datas.Click += new System.EventHandler(this.btnBuscar_Datas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Pesquisar_Caixa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_Caixa);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(28, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 116);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Caixa ";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // BTN_Pesquisar_Caixa
            // 
            this.BTN_Pesquisar_Caixa.ForeColor = System.Drawing.Color.Black;
            this.BTN_Pesquisar_Caixa.Location = new System.Drawing.Point(72, 78);
            this.BTN_Pesquisar_Caixa.Name = "BTN_Pesquisar_Caixa";
            this.BTN_Pesquisar_Caixa.Size = new System.Drawing.Size(104, 23);
            this.BTN_Pesquisar_Caixa.TabIndex = 12;
            this.BTN_Pesquisar_Caixa.Text = "Pesquisar";
            this.BTN_Pesquisar_Caixa.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar_Caixa.Click += new System.EventHandler(this.BTN_Pesquisar_Caixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Selecionar:";
            // 
            // CB_Caixa
            // 
            this.CB_Caixa.FormattingEnabled = true;
            this.CB_Caixa.Location = new System.Drawing.Point(19, 40);
            this.CB_Caixa.Name = "CB_Caixa";
            this.CB_Caixa.Size = new System.Drawing.Size(218, 21);
            this.CB_Caixa.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BTN_Pesquisar_Funcionario);
            this.groupBox2.Controls.Add(this.CB_Funcionario);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(586, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 116);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa por Funcionário";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Selecionar:";
            // 
            // BTN_Pesquisar_Funcionario
            // 
            this.BTN_Pesquisar_Funcionario.ForeColor = System.Drawing.Color.Black;
            this.BTN_Pesquisar_Funcionario.Location = new System.Drawing.Point(109, 78);
            this.BTN_Pesquisar_Funcionario.Name = "BTN_Pesquisar_Funcionario";
            this.BTN_Pesquisar_Funcionario.Size = new System.Drawing.Size(104, 23);
            this.BTN_Pesquisar_Funcionario.TabIndex = 13;
            this.BTN_Pesquisar_Funcionario.Text = "Pesquisar";
            this.BTN_Pesquisar_Funcionario.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar_Funcionario.Click += new System.EventHandler(this.BTN_Pesquisar_Funcionario_Click);
            // 
            // CB_Funcionario
            // 
            this.CB_Funcionario.FormattingEnabled = true;
            this.CB_Funcionario.Location = new System.Drawing.Point(21, 40);
            this.CB_Funcionario.Name = "CB_Funcionario";
            this.CB_Funcionario.Size = new System.Drawing.Size(271, 21);
            this.CB_Funcionario.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 69;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatório";
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Navy;
            this.LB_Modo_Exibicao.ForeColor = System.Drawing.Color.White;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(168, 541);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(35, 13);
            this.LB_Modo_Exibicao.TabIndex = 70;
            this.LB_Modo_Exibicao.Text = "label1";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Modo de exibição atual:";
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Mostrar_Tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mostrar_Tudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Mostrar_Tudo.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(789, 536);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(111, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 12;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = true;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(361, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Total de Registros:";
            // 
            // FRM_Caixa_Operacao_Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTN_Mostrar_Tudo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Modo_Exibicao);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.LB_Total_Registros);
            this.Controls.Add(this.DGV_Dados);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FRM_Caixa_Operacao_Dia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Guiche de Atendimento";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Caixa_Operacao_Dia_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Caixa_Operacao_Dia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Dados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView DGV_Dados;
        private System.Windows.Forms.Label LB_Total_Registros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar_Datas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Pesquisar_Caixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Caixa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Pesquisar_Funcionario;
        private System.Windows.Forms.ComboBox CB_Funcionario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        private System.Windows.Forms.Label label5;
    }
}