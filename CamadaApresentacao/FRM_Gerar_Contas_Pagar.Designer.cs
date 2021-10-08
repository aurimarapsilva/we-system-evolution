namespace CamadaApresentacao
{
    partial class FRM_Gerar_Contas_Pagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Parcelas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            this.BTN_Gravar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DT_Vencimento = new System.Windows.Forms.DateTimePicker();
            this.TXB_Valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_Num_Doc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Qtd_Parc = new System.Windows.Forms.ComboBox();
            this.BTN_Gerar_Parc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Parcelas
            // 
            this.DGV_Parcelas.AllowUserToAddRows = false;
            this.DGV_Parcelas.AllowUserToDeleteRows = false;
            this.DGV_Parcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Parcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGV_Parcelas.Location = new System.Drawing.Point(26, 42);
            this.DGV_Parcelas.Name = "DGV_Parcelas";
            this.DGV_Parcelas.ReadOnly = true;
            this.DGV_Parcelas.Size = new System.Drawing.Size(391, 321);
            this.DGV_Parcelas.TabIndex = 26;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "num_parcela";
            this.Column1.HeaderText = "Nº da Parcela";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "c";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            // TXB_Id
            // 
            this.TXB_Id.Location = new System.Drawing.Point(469, 58);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.Size = new System.Drawing.Size(79, 20);
            this.TXB_Id.TabIndex = 25;
            // 
            // BTN_Gravar
            // 
            this.BTN_Gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Gravar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Gravar.Location = new System.Drawing.Point(566, 327);
            this.BTN_Gravar.Name = "BTN_Gravar";
            this.BTN_Gravar.Size = new System.Drawing.Size(91, 36);
            this.BTN_Gravar.TabIndex = 24;
            this.BTN_Gravar.Text = "    Salvar";
            this.BTN_Gravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Gravar.UseVisualStyleBackColor = true;
            this.BTN_Gravar.Click += new System.EventHandler(this.BTN_Gravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(466, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Data da Venda";
            // 
            // DT_Vencimento
            // 
            this.DT_Vencimento.Enabled = false;
            this.DT_Vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Vencimento.Location = new System.Drawing.Point(469, 111);
            this.DT_Vencimento.Name = "DT_Vencimento";
            this.DT_Vencimento.Size = new System.Drawing.Size(112, 20);
            this.DT_Vencimento.TabIndex = 22;
            // 
            // TXB_Valor
            // 
            this.TXB_Valor.Location = new System.Drawing.Point(473, 281);
            this.TXB_Valor.Name = "TXB_Valor";
            this.TXB_Valor.ReadOnly = true;
            this.TXB_Valor.Size = new System.Drawing.Size(116, 20);
            this.TXB_Valor.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(473, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Valor Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(473, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Parcelar em:";
            // 
            // TXB_Num_Doc
            // 
            this.TXB_Num_Doc.Location = new System.Drawing.Point(469, 164);
            this.TXB_Num_Doc.Name = "TXB_Num_Doc";
            this.TXB_Num_Doc.ReadOnly = true;
            this.TXB_Num_Doc.Size = new System.Drawing.Size(140, 20);
            this.TXB_Num_Doc.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(470, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nº  do Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(469, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Código";
            // 
            // CB_Qtd_Parc
            // 
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
            this.CB_Qtd_Parc.Location = new System.Drawing.Point(473, 222);
            this.CB_Qtd_Parc.Name = "CB_Qtd_Parc";
            this.CB_Qtd_Parc.Size = new System.Drawing.Size(75, 21);
            this.CB_Qtd_Parc.TabIndex = 16;
            // 
            // BTN_Gerar_Parc
            // 
            this.BTN_Gerar_Parc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Gerar_Parc.Image = global::CamadaApresentacao.Properties.Resources.Atualizar_16x16;
            this.BTN_Gerar_Parc.Location = new System.Drawing.Point(460, 327);
            this.BTN_Gerar_Parc.Name = "BTN_Gerar_Parc";
            this.BTN_Gerar_Parc.Size = new System.Drawing.Size(84, 36);
            this.BTN_Gerar_Parc.TabIndex = 27;
            this.BTN_Gerar_Parc.Text = "    Gerar      Parcelas";
            this.BTN_Gerar_Parc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Gerar_Parc.UseVisualStyleBackColor = true;
            this.BTN_Gerar_Parc.Click += new System.EventHandler(this.BTN_Gerar_Parc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Gerador de Parcelas";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(678, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 389);
            this.pictureBox4.TabIndex = 32;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 389);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 381);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(686, 8);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 22);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Gerar_Contas_Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(686, 388);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Parcelas);
            this.Controls.Add(this.TXB_Id);
            this.Controls.Add(this.BTN_Gravar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DT_Vencimento);
            this.Controls.Add(this.TXB_Valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXB_Num_Doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Qtd_Parc);
            this.Controls.Add(this.BTN_Gerar_Parc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Gerar_Contas_Pagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Contas a Pagar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Gerar_Contas_Pagar_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Gerar_Contas_Pagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Parcelas;
        private System.Windows.Forms.TextBox TXB_Id;
        private System.Windows.Forms.Button BTN_Gravar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DateTimePicker DT_Vencimento;
        public System.Windows.Forms.TextBox TXB_Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TXB_Num_Doc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_Qtd_Parc;
        private System.Windows.Forms.Button BTN_Gerar_Parc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}