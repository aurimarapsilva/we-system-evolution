namespace CamadaApresentacao
{
    partial class FRM_Informacoes_Cheque_Multiformas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Informacoes_Cheque_Multiformas));
            this.CB_Intervalo_Parcelas = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Decrementar = new System.Windows.Forms.Button();
            this.BTN_Incrementar = new System.Windows.Forms.Button();
            this.TXB_Quant_Parc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_Valor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Nome_Titular = new System.Windows.Forms.TextBox();
            this.DTP_Data = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Banco_Emissor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Confirmar = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Intervalo_Parcelas
            // 
            this.CB_Intervalo_Parcelas.FormattingEnabled = true;
            this.CB_Intervalo_Parcelas.Items.AddRange(new object[] {
            "7",
            "14",
            "21",
            "28",
            "30",
            "31"});
            this.CB_Intervalo_Parcelas.Location = new System.Drawing.Point(25, 19);
            this.CB_Intervalo_Parcelas.Name = "CB_Intervalo_Parcelas";
            this.CB_Intervalo_Parcelas.Size = new System.Drawing.Size(77, 21);
            this.CB_Intervalo_Parcelas.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.CB_Intervalo_Parcelas);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(311, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 74);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Intervalo das Parcelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(108, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Dias:";
            // 
            // BTN_Decrementar
            // 
            this.BTN_Decrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Decrementar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Decrementar.Location = new System.Drawing.Point(213, 71);
            this.BTN_Decrementar.Name = "BTN_Decrementar";
            this.BTN_Decrementar.Size = new System.Drawing.Size(24, 24);
            this.BTN_Decrementar.TabIndex = 46;
            this.BTN_Decrementar.Text = "-";
            this.BTN_Decrementar.UseVisualStyleBackColor = true;
            this.BTN_Decrementar.Click += new System.EventHandler(this.BTN_Decrementar_Click);
            // 
            // BTN_Incrementar
            // 
            this.BTN_Incrementar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Incrementar.Location = new System.Drawing.Point(182, 71);
            this.BTN_Incrementar.Name = "BTN_Incrementar";
            this.BTN_Incrementar.Size = new System.Drawing.Size(24, 24);
            this.BTN_Incrementar.TabIndex = 45;
            this.BTN_Incrementar.Text = "+";
            this.BTN_Incrementar.UseVisualStyleBackColor = true;
            this.BTN_Incrementar.Click += new System.EventHandler(this.BTN_Incrementar_Click);
            // 
            // TXB_Quant_Parc
            // 
            this.TXB_Quant_Parc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Quant_Parc.Location = new System.Drawing.Point(99, 72);
            this.TXB_Quant_Parc.Name = "TXB_Quant_Parc";
            this.TXB_Quant_Parc.ReadOnly = true;
            this.TXB_Quant_Parc.Size = new System.Drawing.Size(66, 24);
            this.TXB_Quant_Parc.TabIndex = 44;
            this.TXB_Quant_Parc.TextChanged += new System.EventHandler(this.TXB_Quant_Parc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor:";
            // 
            // TXB_Valor
            // 
            this.TXB_Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor.Location = new System.Drawing.Point(67, 29);
            this.TXB_Valor.Name = "TXB_Valor";
            this.TXB_Valor.ReadOnly = true;
            this.TXB_Valor.Size = new System.Drawing.Size(170, 24);
            this.TXB_Valor.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Parcelar em:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BTN_Decrementar);
            this.groupBox2.Controls.Add(this.BTN_Incrementar);
            this.groupBox2.Controls.Add(this.TXB_Quant_Parc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXB_Valor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(26, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 110);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parcelamento";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXB_Nome_Titular);
            this.groupBox1.Controls.Add(this.DTP_Data);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CB_Banco_Emissor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 131);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Primários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Data:";
            // 
            // TXB_Nome_Titular
            // 
            this.TXB_Nome_Titular.ForeColor = System.Drawing.Color.Black;
            this.TXB_Nome_Titular.Location = new System.Drawing.Point(18, 93);
            this.TXB_Nome_Titular.Name = "TXB_Nome_Titular";
            this.TXB_Nome_Titular.Size = new System.Drawing.Size(404, 20);
            this.TXB_Nome_Titular.TabIndex = 37;
            // 
            // DTP_Data
            // 
            this.DTP_Data.Enabled = false;
            this.DTP_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Data.Location = new System.Drawing.Point(18, 41);
            this.DTP_Data.Name = "DTP_Data";
            this.DTP_Data.Size = new System.Drawing.Size(118, 20);
            this.DTP_Data.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(183, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bando Emissor:";
            // 
            // CB_Banco_Emissor
            // 
            this.CB_Banco_Emissor.FormattingEnabled = true;
            this.CB_Banco_Emissor.Items.AddRange(new object[] {
            "BANCO DO BRASIL",
            "BRADESCO",
            "CAIXA ECO FEDERAL",
            "HSBC",
            "ITAÚ UNIBANCO",
            "OUTROS",
            "SANTANDER",
            "SICOOB"});
            this.CB_Banco_Emissor.Location = new System.Drawing.Point(186, 40);
            this.CB_Banco_Emissor.Name = "CB_Banco_Emissor";
            this.CB_Banco_Emissor.Size = new System.Drawing.Size(236, 21);
            this.CB_Banco_Emissor.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nome do Titular:";
            // 
            // BTN_Confirmar
            // 
            this.BTN_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Confirmar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Confirmar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Confirmar.Location = new System.Drawing.Point(339, 238);
            this.BTN_Confirmar.Name = "BTN_Confirmar";
            this.BTN_Confirmar.Size = new System.Drawing.Size(98, 30);
            this.BTN_Confirmar.TabIndex = 50;
            this.BTN_Confirmar.Text = "   Continuar";
            this.BTN_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Confirmar.UseVisualStyleBackColor = true;
            this.BTN_Confirmar.Click += new System.EventHandler(this.BTN_Confirmar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(492, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 290);
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 290);
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 282);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(498, 8);
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 8);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Informacoes_Cheque_Multiformas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(498, 290);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Confirmar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Informacoes_Cheque_Multiformas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações - Cheque";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Informacoes_Cheque_Multiformas_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Informacoes_Cheque_Multiformas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Intervalo_Parcelas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Decrementar;
        private System.Windows.Forms.Button BTN_Incrementar;
        private System.Windows.Forms.TextBox TXB_Quant_Parc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXB_Valor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Nome_Titular;
        public System.Windows.Forms.DateTimePicker DTP_Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Banco_Emissor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Confirmar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}