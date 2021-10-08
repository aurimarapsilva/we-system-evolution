namespace CamadaApresentacao
{
    partial class FRM_Tipo_Relatorio_Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Tipo_Relatorio_Estoque));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Selecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.BTN_Selecionar_Produto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(321, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 169);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 169);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 6);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 6);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(189, 131);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(94, 23);
            this.BTN_Cancelar.TabIndex = 13;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Selecionar
            // 
            this.BTN_Selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Selecionar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Selecionar.Location = new System.Drawing.Point(40, 131);
            this.BTN_Selecionar.Name = "BTN_Selecionar";
            this.BTN_Selecionar.Size = new System.Drawing.Size(114, 23);
            this.BTN_Selecionar.TabIndex = 12;
            this.BTN_Selecionar.Text = " Gerar Relatório";
            this.BTN_Selecionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Selecionar.UseVisualStyleBackColor = true;
            this.BTN_Selecionar.Click += new System.EventHandler(this.BTN_Selecionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Selecione o tipo:";
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "Inventario",
            "Listagem - dez mais vendidos",
            "Listagem - dez menos vendidos",
            "Listagem geral - detalhado",
            "Listagem geral - resumido",
            "Produto específico",
            "Reposição dos produtos",
            "Vencimento dos produtos"});
            this.CB_Tipo.Location = new System.Drawing.Point(30, 39);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(264, 24);
            this.CB_Tipo.TabIndex = 10;
            this.CB_Tipo.SelectedIndexChanged += new System.EventHandler(this.CB_Tipo_SelectedIndexChanged);
            // 
            // BTN_Selecionar_Produto
            // 
            this.BTN_Selecionar_Produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Selecionar_Produto.Enabled = false;
            this.BTN_Selecionar_Produto.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Selecionar_Produto.Location = new System.Drawing.Point(50, 81);
            this.BTN_Selecionar_Produto.Name = "BTN_Selecionar_Produto";
            this.BTN_Selecionar_Produto.Size = new System.Drawing.Size(219, 23);
            this.BTN_Selecionar_Produto.TabIndex = 18;
            this.BTN_Selecionar_Produto.Text = "         SELECIONAR PRODUTO";
            this.BTN_Selecionar_Produto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Selecionar_Produto.UseVisualStyleBackColor = true;
            this.BTN_Selecionar_Produto.Click += new System.EventHandler(this.BTN_Selecionar_Produto_Click);
            // 
            // FRM_Tipo_Relatorio_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(327, 168);
            this.Controls.Add(this.BTN_Selecionar_Produto);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Selecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Tipo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Tipo_Relatorio_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipo de Relatório - Estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Tipo_Relatorio_Estoque_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Selecionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Tipo;
        private System.Windows.Forms.Button BTN_Selecionar_Produto;
    }
}