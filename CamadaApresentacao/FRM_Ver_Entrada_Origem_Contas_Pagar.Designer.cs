namespace CamadaApresentacao
{
    partial class FRM_Ver_Entrada_Origem_Contas_Pagar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataListaDetalhes = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DTP_Data_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.DTP_Data_Fabricacao = new System.Windows.Forms.DateTimePicker();
            this.TXB_TotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.LB_Titulo_Total_Pagar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNum_Comprovante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.TXB_Fornecedor = new System.Windows.Forms.TextBox();
            this.TXB_Funcionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Tipo_Comprovante = new System.Windows.Forms.TextBox();
            this.TXB_Tipo_Compra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataListaDetalhes);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(34, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(897, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Compra";
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
            this.dataListaDetalhes.ReadOnly = true;
            this.dataListaDetalhes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataListaDetalhes.Size = new System.Drawing.Size(885, 246);
            this.dataListaDetalhes.TabIndex = 23;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.ReadOnly = true;
            this.Selecionar.Visible = false;
            this.Selecionar.Width = 35;
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
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
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 39);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
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
            this.btnCancelar.Location = new System.Drawing.Point(789, 29);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 30);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "   SAIR";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(240, 516);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 89;
            this.label10.Text = "Data de Vencimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 516);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 88;
            this.label1.Text = "Data de Fabricação";
            // 
            // DTP_Data_Vencimento
            // 
            this.DTP_Data_Vencimento.Enabled = false;
            this.DTP_Data_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Data_Vencimento.Location = new System.Drawing.Point(243, 532);
            this.DTP_Data_Vencimento.Name = "DTP_Data_Vencimento";
            this.DTP_Data_Vencimento.Size = new System.Drawing.Size(148, 20);
            this.DTP_Data_Vencimento.TabIndex = 87;
            // 
            // DTP_Data_Fabricacao
            // 
            this.DTP_Data_Fabricacao.Enabled = false;
            this.DTP_Data_Fabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Data_Fabricacao.Location = new System.Drawing.Point(46, 532);
            this.DTP_Data_Fabricacao.Name = "DTP_Data_Fabricacao";
            this.DTP_Data_Fabricacao.Size = new System.Drawing.Size(143, 20);
            this.DTP_Data_Fabricacao.TabIndex = 86;
            // 
            // TXB_TotalPagar
            // 
            this.TXB_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TotalPagar.ForeColor = System.Drawing.Color.Green;
            this.TXB_TotalPagar.Location = new System.Drawing.Point(655, 523);
            this.TXB_TotalPagar.Name = "TXB_TotalPagar";
            this.TXB_TotalPagar.ReadOnly = true;
            this.TXB_TotalPagar.Size = new System.Drawing.Size(213, 29);
            this.TXB_TotalPagar.TabIndex = 85;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            // 
            // LB_Titulo_Total_Pagar
            // 
            this.LB_Titulo_Total_Pagar.AutoSize = true;
            this.LB_Titulo_Total_Pagar.BackColor = System.Drawing.Color.Transparent;
            this.LB_Titulo_Total_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo_Total_Pagar.Location = new System.Drawing.Point(601, 532);
            this.LB_Titulo_Total_Pagar.Name = "LB_Titulo_Total_Pagar";
            this.LB_Titulo_Total_Pagar.Size = new System.Drawing.Size(48, 16);
            this.LB_Titulo_Total_Pagar.TabIndex = 84;
            this.LB_Titulo_Total_Pagar.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(601, 401);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 78;
            this.label7.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(37, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Tipo de Compra";
            // 
            // txtNum_Comprovante
            // 
            this.txtNum_Comprovante.Location = new System.Drawing.Point(222, 467);
            this.txtNum_Comprovante.Name = "txtNum_Comprovante";
            this.txtNum_Comprovante.ReadOnly = true;
            this.txtNum_Comprovante.Size = new System.Drawing.Size(169, 20);
            this.txtNum_Comprovante.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(219, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Nº Comprovante";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(37, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Comprovante";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(966, 17);
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 596);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(966, 17);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(955, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 600);
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 600);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // TXB_Fornecedor
            // 
            this.TXB_Fornecedor.Location = new System.Drawing.Point(604, 418);
            this.TXB_Fornecedor.Name = "TXB_Fornecedor";
            this.TXB_Fornecedor.ReadOnly = true;
            this.TXB_Fornecedor.Size = new System.Drawing.Size(321, 20);
            this.TXB_Fornecedor.TabIndex = 94;
            // 
            // TXB_Funcionario
            // 
            this.TXB_Funcionario.Location = new System.Drawing.Point(604, 467);
            this.TXB_Funcionario.Name = "TXB_Funcionario";
            this.TXB_Funcionario.ReadOnly = true;
            this.TXB_Funcionario.Size = new System.Drawing.Size(321, 20);
            this.TXB_Funcionario.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(601, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Funcionário";
            // 
            // TXB_Tipo_Comprovante
            // 
            this.TXB_Tipo_Comprovante.Location = new System.Drawing.Point(40, 466);
            this.TXB_Tipo_Comprovante.Name = "TXB_Tipo_Comprovante";
            this.TXB_Tipo_Comprovante.ReadOnly = true;
            this.TXB_Tipo_Comprovante.Size = new System.Drawing.Size(149, 20);
            this.TXB_Tipo_Comprovante.TabIndex = 97;
            // 
            // TXB_Tipo_Compra
            // 
            this.TXB_Tipo_Compra.Location = new System.Drawing.Point(40, 417);
            this.TXB_Tipo_Compra.Name = "TXB_Tipo_Compra";
            this.TXB_Tipo_Compra.ReadOnly = true;
            this.TXB_Tipo_Compra.Size = new System.Drawing.Size(351, 20);
            this.TXB_Tipo_Compra.TabIndex = 98;
            // 
            // FRM_Ver_Entrada_Origem_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 612);
            this.Controls.Add(this.TXB_Tipo_Compra);
            this.Controls.Add(this.TXB_Tipo_Comprovante);
            this.Controls.Add(this.TXB_Funcionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_Fornecedor);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTP_Data_Vencimento);
            this.Controls.Add(this.DTP_Data_Fabricacao);
            this.Controls.Add(this.TXB_TotalPagar);
            this.Controls.Add(this.LB_Titulo_Total_Pagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNum_Comprovante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FRM_Ver_Entrada_Origem_Contas_Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Compra de Origem";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Ver_Venda_Origem_Contas_Pagar_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Ver_Venda_Origem_Contas_Pagar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Ver_Venda_Origem_Contas_Pagar_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dataListaDetalhes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
        public System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP_Data_Vencimento;
        private System.Windows.Forms.DateTimePicker DTP_Data_Fabricacao;
        public System.Windows.Forms.MaskedTextBox TXB_TotalPagar;
        private System.Windows.Forms.Label LB_Titulo_Total_Pagar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNum_Comprovante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TXB_Fornecedor;
        private System.Windows.Forms.TextBox TXB_Funcionario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TXB_Tipo_Comprovante;
        public System.Windows.Forms.TextBox TXB_Tipo_Compra;
    }
}