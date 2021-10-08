namespace CamadaApresentacao
{
    partial class FRM_Etiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Etiquetas));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Selecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_SubTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_Tamanho_Etiqueta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(445, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 230);
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 230);
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 6);
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 6);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(260, 195);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(94, 23);
            this.BTN_Cancelar.TabIndex = 72;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Selecionar
            // 
            this.BTN_Selecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Selecionar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Selecionar.Location = new System.Drawing.Point(84, 195);
            this.BTN_Selecionar.Name = "BTN_Selecionar";
            this.BTN_Selecionar.Size = new System.Drawing.Size(133, 23);
            this.BTN_Selecionar.TabIndex = 71;
            this.BTN_Selecionar.Text = "    Gerar Etiquetas";
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
            this.label1.TabIndex = 70;
            this.label1.Text = "Selecione o tipo:";
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "Por Categoria",
            "Por Produto Específico",
            "Por Tipo"});
            this.CB_Tipo.Location = new System.Drawing.Point(30, 39);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(389, 24);
            this.CB_Tipo.TabIndex = 69;
            this.CB_Tipo.SelectedIndexChanged += new System.EventHandler(this.CB_Tipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 78;
            this.label2.Text = "Selecione Subtipo:";
            // 
            // CB_SubTipo
            // 
            this.CB_SubTipo.Enabled = false;
            this.CB_SubTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SubTipo.FormattingEnabled = true;
            this.CB_SubTipo.Items.AddRange(new object[] {
            "Por Categoria",
            "Por Produto Específico",
            "Por Tipo"});
            this.CB_SubTipo.Location = new System.Drawing.Point(30, 97);
            this.CB_SubTipo.Name = "CB_SubTipo";
            this.CB_SubTipo.Size = new System.Drawing.Size(389, 24);
            this.CB_SubTipo.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 81;
            this.label3.Text = "Tamanho da Etiqueta:";
            // 
            // CB_Tamanho_Etiqueta
            // 
            this.CB_Tamanho_Etiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tamanho_Etiqueta.FormattingEnabled = true;
            this.CB_Tamanho_Etiqueta.Items.AddRange(new object[] {
            "Pimaco 6080 / 6180 / 6280 / 62580 | 6,67cm X 2,54cm | Carta",
            "Pimaco 6081 / 6181 / 6281 / 62581 | 10,16cm X 2,54cm | Carta",
            "Pimaco 6082 / 6182 / 6282 / 62582 | 10,16cm X 3,39cm | Carta"});
            this.CB_Tamanho_Etiqueta.Location = new System.Drawing.Point(30, 154);
            this.CB_Tamanho_Etiqueta.Name = "CB_Tamanho_Etiqueta";
            this.CB_Tamanho_Etiqueta.Size = new System.Drawing.Size(389, 24);
            this.CB_Tamanho_Etiqueta.TabIndex = 80;
            // 
            // FRM_Etiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(450, 230);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Tamanho_Etiqueta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_SubTipo);
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
            this.Name = "FRM_Etiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas - Estoque";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Etiquetas_FormClosed);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_SubTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_Tamanho_Etiqueta;
    }
}