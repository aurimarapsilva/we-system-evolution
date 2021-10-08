namespace CamadaApresentacao
{
    partial class FRM_Detalhe_Config_Cartao_Debito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Detalhe_Config_Cartao_Debito));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DGV_Config_Atual = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Compensar_Auto = new System.Windows.Forms.ComboBox();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Alterar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Config_Atual)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(493, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 167);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 167);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(502, 8);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 8);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DGV_Config_Atual
            // 
            this.DGV_Config_Atual.AllowUserToAddRows = false;
            this.DGV_Config_Atual.AllowUserToDeleteRows = false;
            this.DGV_Config_Atual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Config_Atual.Location = new System.Drawing.Point(20, 38);
            this.DGV_Config_Atual.Name = "DGV_Config_Atual";
            this.DGV_Config_Atual.ReadOnly = true;
            this.DGV_Config_Atual.Size = new System.Drawing.Size(230, 81);
            this.DGV_Config_Atual.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.BTN_Sair);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CB_Compensar_Auto);
            this.groupBox2.Controls.Add(this.BTN_Salvar);
            this.groupBox2.Controls.Add(this.BTN_Alterar);
            this.groupBox2.Location = new System.Drawing.Point(298, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 139);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Sair.Location = new System.Drawing.Point(108, 105);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(60, 23);
            this.BTN_Sair.TabIndex = 4;
            this.BTN_Sair.Text = "  Sair";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Compensar:";
            // 
            // CB_Compensar_Auto
            // 
            this.CB_Compensar_Auto.Enabled = false;
            this.CB_Compensar_Auto.FormattingEnabled = true;
            this.CB_Compensar_Auto.Items.AddRange(new object[] {
            "NÃO",
            "SIM"});
            this.CB_Compensar_Auto.Location = new System.Drawing.Point(17, 40);
            this.CB_Compensar_Auto.Name = "CB_Compensar_Auto";
            this.CB_Compensar_Auto.Size = new System.Drawing.Size(151, 21);
            this.CB_Compensar_Auto.TabIndex = 2;
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Enabled = false;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(17, 105);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(78, 23);
            this.BTN_Salvar.TabIndex = 1;
            this.BTN_Salvar.Text = "   Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Alterar
            // 
            this.BTN_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Alterar.Image = global::CamadaApresentacao.Properties.Resources.Editar16x16;
            this.BTN_Alterar.Location = new System.Drawing.Point(17, 76);
            this.BTN_Alterar.Name = "BTN_Alterar";
            this.BTN_Alterar.Size = new System.Drawing.Size(151, 23);
            this.BTN_Alterar.TabIndex = 0;
            this.BTN_Alterar.Text = "      ALTERAR";
            this.BTN_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Alterar.UseVisualStyleBackColor = true;
            this.BTN_Alterar.Click += new System.EventHandler(this.BTN_Alterar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.DGV_Config_Atual);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 139);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração Atual";
            // 
            // TXB_Id
            // 
            this.TXB_Id.Location = new System.Drawing.Point(482, 147);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.Size = new System.Drawing.Size(16, 20);
            this.TXB_Id.TabIndex = 11;
            this.TXB_Id.Visible = false;
            // 
            // FRM_Detalhe_Config_Cartao_Debito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(500, 167);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TXB_Id);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Detalhe_Config_Cartao_Debito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compensação Automática de Cartão de Debito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Detalhe_Config_Cartao_Debito_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Detalhe_Config_Cartao_Debito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Config_Atual)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DGV_Config_Atual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Compensar_Auto;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Alterar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXB_Id;
    }
}