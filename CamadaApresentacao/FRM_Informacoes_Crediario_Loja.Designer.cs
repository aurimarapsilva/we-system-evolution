namespace CamadaApresentacao
{
    partial class FRM_Informacoes_Crediario_Loja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Informacoes_Crediario_Loja));
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_Total_Prod_Serv = new System.Windows.Forms.TextBox();
            this.TXB_Total_Geral = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Quant_Parc = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGV_Parcelamento = new System.Windows.Forms.DataGridView();
            this.BTN_Gerar_Parc = new System.Windows.Forms.Button();
            this.BTN_Concluir = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_Taxa_Juros = new System.Windows.Forms.Label();
            this.LB_Status = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total em Produtos / Serviços:";
            // 
            // TXB_Total_Prod_Serv
            // 
            this.TXB_Total_Prod_Serv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Total_Prod_Serv.ForeColor = System.Drawing.Color.Black;
            this.TXB_Total_Prod_Serv.Location = new System.Drawing.Point(27, 46);
            this.TXB_Total_Prod_Serv.Name = "TXB_Total_Prod_Serv";
            this.TXB_Total_Prod_Serv.ReadOnly = true;
            this.TXB_Total_Prod_Serv.Size = new System.Drawing.Size(164, 24);
            this.TXB_Total_Prod_Serv.TabIndex = 1;
            // 
            // TXB_Total_Geral
            // 
            this.TXB_Total_Geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Total_Geral.ForeColor = System.Drawing.Color.Black;
            this.TXB_Total_Geral.Location = new System.Drawing.Point(225, 46);
            this.TXB_Total_Geral.Name = "TXB_Total_Geral";
            this.TXB_Total_Geral.ReadOnly = true;
            this.TXB_Total_Geral.Size = new System.Drawing.Size(164, 24);
            this.TXB_Total_Geral.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(222, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Geral:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(418, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parcelar em:";
            // 
            // CB_Quant_Parc
            // 
            this.CB_Quant_Parc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Quant_Parc.ForeColor = System.Drawing.Color.Black;
            this.CB_Quant_Parc.FormattingEnabled = true;
            this.CB_Quant_Parc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CB_Quant_Parc.Location = new System.Drawing.Point(421, 46);
            this.CB_Quant_Parc.Name = "CB_Quant_Parc";
            this.CB_Quant_Parc.Size = new System.Drawing.Size(121, 24);
            this.CB_Quant_Parc.TabIndex = 5;
            this.CB_Quant_Parc.SelectedIndexChanged += new System.EventHandler(this.CB_Quant_Parc_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Total_Prod_Serv);
            this.groupBox1.Controls.Add(this.CB_Quant_Parc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXB_Total_Geral);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 92);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DGV_Parcelamento);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(26, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 258);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parcelas Geradas";
            // 
            // DGV_Parcelamento
            // 
            this.DGV_Parcelamento.AllowUserToAddRows = false;
            this.DGV_Parcelamento.AllowUserToDeleteRows = false;
            this.DGV_Parcelamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Parcelamento.Location = new System.Drawing.Point(6, 19);
            this.DGV_Parcelamento.Name = "DGV_Parcelamento";
            this.DGV_Parcelamento.ReadOnly = true;
            this.DGV_Parcelamento.Size = new System.Drawing.Size(428, 233);
            this.DGV_Parcelamento.TabIndex = 0;
            // 
            // BTN_Gerar_Parc
            // 
            this.BTN_Gerar_Parc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Gerar_Parc.Image = global::CamadaApresentacao.Properties.Resources.Atualizar_16x16;
            this.BTN_Gerar_Parc.Location = new System.Drawing.Point(503, 208);
            this.BTN_Gerar_Parc.Name = "BTN_Gerar_Parc";
            this.BTN_Gerar_Parc.Size = new System.Drawing.Size(91, 36);
            this.BTN_Gerar_Parc.TabIndex = 15;
            this.BTN_Gerar_Parc.Text = "      Gerar       Parcelas";
            this.BTN_Gerar_Parc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Gerar_Parc.UseVisualStyleBackColor = true;
            this.BTN_Gerar_Parc.Click += new System.EventHandler(this.BTN_Gerar_Parc_Click);
            // 
            // BTN_Concluir
            // 
            this.BTN_Concluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Concluir.Enabled = false;
            this.BTN_Concluir.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Concluir.Location = new System.Drawing.Point(503, 276);
            this.BTN_Concluir.Name = "BTN_Concluir";
            this.BTN_Concluir.Size = new System.Drawing.Size(91, 36);
            this.BTN_Concluir.TabIndex = 16;
            this.BTN_Concluir.Text = "   Concluir";
            this.BTN_Concluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Concluir.UseVisualStyleBackColor = true;
            this.BTN_Concluir.Click += new System.EventHandler(this.BTN_Concluir_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(629, 10);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 20);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 425);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(619, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 425);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Taxa de Juros:";
            // 
            // LB_Taxa_Juros
            // 
            this.LB_Taxa_Juros.AutoSize = true;
            this.LB_Taxa_Juros.BackColor = System.Drawing.Color.Navy;
            this.LB_Taxa_Juros.ForeColor = System.Drawing.Color.White;
            this.LB_Taxa_Juros.Location = new System.Drawing.Point(107, 408);
            this.LB_Taxa_Juros.Name = "LB_Taxa_Juros";
            this.LB_Taxa_Juros.Size = new System.Drawing.Size(59, 13);
            this.LB_Taxa_Juros.TabIndex = 23;
            this.LB_Taxa_Juros.Text = "0,00% a.m.";
            // 
            // LB_Status
            // 
            this.LB_Status.AutoSize = true;
            this.LB_Status.BackColor = System.Drawing.Color.Navy;
            this.LB_Status.ForeColor = System.Drawing.Color.White;
            this.LB_Status.Location = new System.Drawing.Point(279, 408);
            this.LB_Status.Name = "LB_Status";
            this.LB_Status.Size = new System.Drawing.Size(40, 13);
            this.LB_Status.TabIndex = 24;
            this.LB_Status.Text = "Status:";
            // 
            // FRM_Informacoes_Crediario_Loja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(630, 426);
            this.Controls.Add(this.LB_Status);
            this.Controls.Add(this.LB_Taxa_Juros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_Concluir);
            this.Controls.Add(this.BTN_Gerar_Parc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Informacoes_Crediario_Loja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações - Crediário da Loja";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Informacoes_Crediario_Loja_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Informacoes_Crediario_Loja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Parcelamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_Total_Prod_Serv;
        private System.Windows.Forms.TextBox TXB_Total_Geral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Quant_Parc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Gerar_Parc;
        private System.Windows.Forms.Button BTN_Concluir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_Taxa_Juros;
        public System.Windows.Forms.DataGridView DGV_Parcelamento;
        private System.Windows.Forms.Label LB_Status;
    }
}