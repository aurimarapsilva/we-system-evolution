namespace CamadaApresentacao
{
    partial class FRM_Atualizar_Dados_Secundários_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Atualizar_Dados_Secundários_OS));
            this.DGV_Atualizador = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.TXB_Total_Geral = new System.Windows.Forms.TextBox();
            this.DGV_Select_Prod_Cod_Barra = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Atualizador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Atualizador
            // 
            this.DGV_Atualizador.AllowUserToAddRows = false;
            this.DGV_Atualizador.AllowUserToDeleteRows = false;
            this.DGV_Atualizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Atualizador.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.DGV_Atualizador.Location = new System.Drawing.Point(24, 35);
            this.DGV_Atualizador.Name = "DGV_Atualizador";
            this.DGV_Atualizador.Size = new System.Drawing.Size(733, 159);
            this.DGV_Atualizador.TabIndex = 3;
            this.DGV_Atualizador.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_Atualizador_CellFormatting);
            this.DGV_Atualizador.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGV_Atualizador_EditingControlShowing);
            this.DGV_Atualizador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Atualizador_KeyPress);
            this.DGV_Atualizador.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DGV_Atualizador_KeyUp);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 15);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(788, 15);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 287);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(782, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 287);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(565, 221);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(93, 29);
            this.BTN_Salvar.TabIndex = 29;
            this.BTN_Salvar.Text = "    Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Saida_16x16;
            this.BTN_Sair.Location = new System.Drawing.Point(682, 221);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(75, 29);
            this.BTN_Sair.TabIndex = 30;
            this.BTN_Sair.Text = "    Sair";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(20, 217);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(234, 20);
            this.label30.TabIndex = 82;
            this.label30.Text = "Total em produtos / serviços";
            // 
            // TXB_Total_Geral
            // 
            this.TXB_Total_Geral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Total_Geral.ForeColor = System.Drawing.Color.Red;
            this.TXB_Total_Geral.Location = new System.Drawing.Point(24, 240);
            this.TXB_Total_Geral.Name = "TXB_Total_Geral";
            this.TXB_Total_Geral.Size = new System.Drawing.Size(230, 26);
            this.TXB_Total_Geral.TabIndex = 81;
            this.TXB_Total_Geral.Text = "R$ 0,00";
            // 
            // DGV_Select_Prod_Cod_Barra
            // 
            this.DGV_Select_Prod_Cod_Barra.AllowUserToAddRows = false;
            this.DGV_Select_Prod_Cod_Barra.AllowUserToDeleteRows = false;
            this.DGV_Select_Prod_Cod_Barra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Select_Prod_Cod_Barra.Location = new System.Drawing.Point(761, 21);
            this.DGV_Select_Prod_Cod_Barra.Name = "DGV_Select_Prod_Cod_Barra";
            this.DGV_Select_Prod_Cod_Barra.ReadOnly = true;
            this.DGV_Select_Prod_Cod_Barra.Size = new System.Drawing.Size(15, 19);
            this.DGV_Select_Prod_Cod_Barra.TabIndex = 87;
            // 
            // FRM_Atualizar_Dados_Secundários_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(788, 287);
            this.Controls.Add(this.DGV_Select_Prod_Cod_Barra);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.TXB_Total_Geral);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Atualizador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Atualizar_Dados_Secundários_OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Dados Secundários da OS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Atualizar_Dados_Secundários_OS_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Atualizar_Dados_Secundários_OS_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Atualizar_Dados_Secundários_OS_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Atualizador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Select_Prod_Cod_Barra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox TXB_Total_Geral;
        private System.Windows.Forms.DataGridView DGV_Select_Prod_Cod_Barra;
        public System.Windows.Forms.DataGridView DGV_Atualizador;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}