namespace CamadaApresentacao
{
    partial class FRM_Livro_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Livro_Caixa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LB_Saldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.DT_Data_Final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Data_Inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Lançar_Debito = new System.Windows.Forms.Button();
            this.BTN_Lançar_Credito = new System.Windows.Forms.Button();
            this.BTN_Relatorios = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 23);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 594);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 569);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(999, 26);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(991, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 595);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Navy;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(21, 573);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 16);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "label3";
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dataLista.Location = new System.Drawing.Point(24, 112);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(954, 441);
            this.dataLista.TabIndex = 30;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataLista_CellValidating);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Width = 35;
            // 
            // LB_Saldo
            // 
            this.LB_Saldo.AutoSize = true;
            this.LB_Saldo.BackColor = System.Drawing.Color.Navy;
            this.LB_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Saldo.ForeColor = System.Drawing.Color.White;
            this.LB_Saldo.Location = new System.Drawing.Point(438, 573);
            this.LB_Saldo.Name = "LB_Saldo";
            this.LB_Saldo.Size = new System.Drawing.Size(147, 16);
            this.LB_Saldo.TabIndex = 32;
            this.LB_Saldo.Text = "Saldo Atual: R$ 0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Buscar);
            this.groupBox1.Controls.Add(this.DT_Data_Final);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DT_Data_Inicial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(24, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 76);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa por Datas";
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackgroundImage = global::CamadaApresentacao.Properties.Resources.buscar3;
            this.BTN_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Buscar.Location = new System.Drawing.Point(211, 29);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(29, 28);
            this.BTN_Buscar.TabIndex = 34;
            this.BTN_Buscar.UseVisualStyleBackColor = true;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // DT_Data_Final
            // 
            this.DT_Data_Final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Data_Final.Location = new System.Drawing.Point(82, 49);
            this.DT_Data_Final.Name = "DT_Data_Final";
            this.DT_Data_Final.Size = new System.Drawing.Size(107, 20);
            this.DT_Data_Final.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Data Final";
            // 
            // DT_Data_Inicial
            // 
            this.DT_Data_Inicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Data_Inicial.Location = new System.Drawing.Point(82, 19);
            this.DT_Data_Inicial.Name = "DT_Data_Inicial";
            this.DT_Data_Inicial.Size = new System.Drawing.Size(107, 20);
            this.DT_Data_Inicial.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Data Inicial";
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Deletar.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.BTN_Deletar.Location = new System.Drawing.Point(38, 48);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(92, 22);
            this.BTN_Deletar.TabIndex = 34;
            this.BTN_Deletar.Text = "    Deletar";
            this.BTN_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CHK_Selecionar);
            this.groupBox2.Controls.Add(this.BTN_Deletar);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(582, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 76);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deletar Lançamento";
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.ForeColor = System.Drawing.Color.Black;
            this.CHK_Selecionar.Location = new System.Drawing.Point(38, 22);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 35;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = true;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BTN_Lançar_Debito);
            this.groupBox3.Controls.Add(this.BTN_Lançar_Credito);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(323, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 76);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lançamentos";
            // 
            // BTN_Lançar_Debito
            // 
            this.BTN_Lançar_Debito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Lançar_Debito.ForeColor = System.Drawing.Color.Black;
            this.BTN_Lançar_Debito.Image = global::CamadaApresentacao.Properties.Resources.Money;
            this.BTN_Lançar_Debito.Location = new System.Drawing.Point(29, 48);
            this.BTN_Lançar_Debito.Name = "BTN_Lançar_Debito";
            this.BTN_Lançar_Debito.Size = new System.Drawing.Size(129, 21);
            this.BTN_Lançar_Debito.TabIndex = 1;
            this.BTN_Lançar_Debito.Text = "   Lançar Debito";
            this.BTN_Lançar_Debito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Lançar_Debito.UseVisualStyleBackColor = true;
            this.BTN_Lançar_Debito.Click += new System.EventHandler(this.BTN_Lançar_Debito_Click);
            // 
            // BTN_Lançar_Credito
            // 
            this.BTN_Lançar_Credito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Lançar_Credito.ForeColor = System.Drawing.Color.Black;
            this.BTN_Lançar_Credito.Image = global::CamadaApresentacao.Properties.Resources.Money;
            this.BTN_Lançar_Credito.Location = new System.Drawing.Point(29, 20);
            this.BTN_Lançar_Credito.Name = "BTN_Lançar_Credito";
            this.BTN_Lançar_Credito.Size = new System.Drawing.Size(129, 21);
            this.BTN_Lançar_Credito.TabIndex = 0;
            this.BTN_Lançar_Credito.Text = "   Lançar Crédito";
            this.BTN_Lançar_Credito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Lançar_Credito.UseVisualStyleBackColor = true;
            this.BTN_Lançar_Credito.Click += new System.EventHandler(this.BTN_Lançar_Credito_Click);
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
            this.BTN_Relatorios.TabIndex = 41;
            this.BTN_Relatorios.Text = "       Relatórios";
            this.BTN_Relatorios.UseVisualStyleBackColor = true;
            this.BTN_Relatorios.Click += new System.EventHandler(this.BTN_Relatorios_Click);
            // 
            // FRM_Livro_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 594);
            this.Controls.Add(this.BTN_Relatorios);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB_Saldo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Livro_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livro Caixa";
            this.Load += new System.EventHandler(this.FRM_Livro_Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label LB_Saldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DT_Data_Final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_Data_Inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.Button BTN_Deletar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_Lançar_Debito;
        private System.Windows.Forms.Button BTN_Lançar_Credito;
        private System.Windows.Forms.CheckBox CHK_Selecionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        private System.Windows.Forms.Button BTN_Relatorios;
    }
}