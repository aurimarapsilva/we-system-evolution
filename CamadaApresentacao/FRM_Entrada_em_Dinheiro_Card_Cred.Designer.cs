namespace CamadaApresentacao
{
    partial class FRM_Entrada_em_Dinheiro_Card_Cred
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Entrada_em_Dinheiro_Card_Cred));
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Valor_Entrada = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Tipo_Recebimento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor da Entrada:";
            // 
            // TXB_Valor_Entrada
            // 
            this.TXB_Valor_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Entrada.ForeColor = System.Drawing.Color.Green;
            this.TXB_Valor_Entrada.Location = new System.Drawing.Point(30, 96);
            this.TXB_Valor_Entrada.Name = "TXB_Valor_Entrada";
            this.TXB_Valor_Entrada.ReadOnly = true;
            this.TXB_Valor_Entrada.Size = new System.Drawing.Size(148, 26);
            this.TXB_Valor_Entrada.TabIndex = 16;
            this.TXB_Valor_Entrada.Text = "0,00";
            this.TXB_Valor_Entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Valor_Entrada_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(323, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 146);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 146);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 6);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 6);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Confirmar
            // 
            this.BTN_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Confirmar.Enabled = false;
            this.BTN_Confirmar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Confirmar.Location = new System.Drawing.Point(207, 58);
            this.BTN_Confirmar.Name = "BTN_Confirmar";
            this.BTN_Confirmar.Size = new System.Drawing.Size(93, 35);
            this.BTN_Confirmar.TabIndex = 11;
            this.BTN_Confirmar.Text = "   Concluir";
            this.BTN_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Confirmar.UseVisualStyleBackColor = true;
            this.BTN_Confirmar.Click += new System.EventHandler(this.BTN_Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Venda com entrada::";
            // 
            // CB_Tipo_Recebimento
            // 
            this.CB_Tipo_Recebimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tipo_Recebimento.FormattingEnabled = true;
            this.CB_Tipo_Recebimento.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.CB_Tipo_Recebimento.Location = new System.Drawing.Point(30, 40);
            this.CB_Tipo_Recebimento.Name = "CB_Tipo_Recebimento";
            this.CB_Tipo_Recebimento.Size = new System.Drawing.Size(148, 26);
            this.CB_Tipo_Recebimento.TabIndex = 9;
            this.CB_Tipo_Recebimento.SelectedIndexChanged += new System.EventHandler(this.CB_Tipo_Recebimento_SelectedIndexChanged);
            // 
            // FRM_Entrada_em_Dinheiro_Card_Cred
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(328, 146);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_Valor_Entrada);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Tipo_Recebimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Entrada_em_Dinheiro_Card_Cred";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada em Dinheiro";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Entrada_em_Dinheiro_Card_Cred_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Valor_Entrada;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Tipo_Recebimento;
    }
}