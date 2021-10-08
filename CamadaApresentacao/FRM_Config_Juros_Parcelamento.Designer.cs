namespace CamadaApresentacao
{
    partial class FRM_Config_Juros_Parcelamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Config_Juros_Parcelamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_Habilitar = new System.Windows.Forms.ComboBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Juros_Cred_Loja = new System.Windows.Forms.TextBox();
            this.TXB_Juros_Card_Cred = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.CB_Habilitar);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 87);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilitar";
            // 
            // CB_Habilitar
            // 
            this.CB_Habilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Habilitar.FormattingEnabled = true;
            this.CB_Habilitar.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.CB_Habilitar.Location = new System.Drawing.Point(26, 36);
            this.CB_Habilitar.Name = "CB_Habilitar";
            this.CB_Habilitar.Size = new System.Drawing.Size(121, 26);
            this.CB_Habilitar.TabIndex = 1;
            this.CB_Habilitar.SelectedIndexChanged += new System.EventHandler(this.CB_Habilitar_SelectedIndexChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(417, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 184);
            this.pictureBox4.TabIndex = 46;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 184);
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 6);
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 6);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Editar.Image = global::CamadaApresentacao.Properties.Resources.Editar16x16;
            this.BTN_Editar.Location = new System.Drawing.Point(45, 135);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(90, 23);
            this.BTN_Editar.TabIndex = 42;
            this.BTN_Editar.Text = "     Alterar";
            this.BTN_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(165, 135);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(90, 23);
            this.BTN_Salvar.TabIndex = 40;
            this.BTN_Salvar.Text = "    Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(281, 135);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(97, 23);
            this.BTN_Cancelar.TabIndex = 41;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(389, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(389, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "%";
            // 
            // TXB_Juros_Cred_Loja
            // 
            this.TXB_Juros_Cred_Loja.Location = new System.Drawing.Point(230, 90);
            this.TXB_Juros_Cred_Loja.Name = "TXB_Juros_Cred_Loja";
            this.TXB_Juros_Cred_Loja.Size = new System.Drawing.Size(157, 20);
            this.TXB_Juros_Cred_Loja.TabIndex = 37;
            this.TXB_Juros_Cred_Loja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Juros_Cred_Loja_KeyPress);
            // 
            // TXB_Juros_Card_Cred
            // 
            this.TXB_Juros_Card_Cred.Location = new System.Drawing.Point(230, 41);
            this.TXB_Juros_Card_Cred.Name = "TXB_Juros_Card_Cred";
            this.TXB_Juros_Card_Cred.Size = new System.Drawing.Size(157, 20);
            this.TXB_Juros_Card_Cred.TabIndex = 36;
            this.TXB_Juros_Card_Cred.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Juros_Card_Cred_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(227, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Juros ao mês - Crediário da loja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(227, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Juros ao mês - Cartão de Crédito";
            // 
            // FRM_Config_Juros_Parcelamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(423, 184);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_Juros_Cred_Loja);
            this.Controls.Add(this.TXB_Juros_Card_Cred);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Config_Juros_Parcelamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações - Juros de Parcelamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Config_Juros_Parcelamento_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Config_Juros_Parcelamento_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_Habilitar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Juros_Cred_Loja;
        private System.Windows.Forms.TextBox TXB_Juros_Card_Cred;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}