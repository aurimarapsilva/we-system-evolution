namespace CamadaApresentacao
{
    partial class FRM_Buscar_OS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Buscar_OS));
            this.LB_Modo_Exibicao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Mostrar_Tudo = new System.Windows.Forms.Button();
            this.BTN_Pesquisar = new System.Windows.Forms.Button();
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_Modo_Exibicao
            // 
            this.LB_Modo_Exibicao.AutoSize = true;
            this.LB_Modo_Exibicao.BackColor = System.Drawing.Color.Navy;
            this.LB_Modo_Exibicao.ForeColor = System.Drawing.Color.White;
            this.LB_Modo_Exibicao.Location = new System.Drawing.Point(151, 399);
            this.LB_Modo_Exibicao.Name = "LB_Modo_Exibicao";
            this.LB_Modo_Exibicao.Size = new System.Drawing.Size(35, 13);
            this.LB_Modo_Exibicao.TabIndex = 81;
            this.LB_Modo_Exibicao.Text = "label2";
            this.LB_Modo_Exibicao.TextChanged += new System.EventHandler(this.LB_Modo_Exibicao_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Modo de exibição atual:";
            // 
            // BTN_Mostrar_Tudo
            // 
            this.BTN_Mostrar_Tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Mostrar_Tudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Mostrar_Tudo.ForeColor = System.Drawing.Color.Navy;
            this.BTN_Mostrar_Tudo.Location = new System.Drawing.Point(526, 394);
            this.BTN_Mostrar_Tudo.Name = "BTN_Mostrar_Tudo";
            this.BTN_Mostrar_Tudo.Size = new System.Drawing.Size(101, 23);
            this.BTN_Mostrar_Tudo.TabIndex = 79;
            this.BTN_Mostrar_Tudo.Text = "Mostrar Tudo";
            this.BTN_Mostrar_Tudo.UseVisualStyleBackColor = true;
            this.BTN_Mostrar_Tudo.Visible = false;
            this.BTN_Mostrar_Tudo.Click += new System.EventHandler(this.BTN_Mostrar_Tudo_Click);
            // 
            // BTN_Pesquisar
            // 
            this.BTN_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pesquisar.Enabled = false;
            this.BTN_Pesquisar.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Pesquisar.Location = new System.Drawing.Point(458, 44);
            this.BTN_Pesquisar.Name = "BTN_Pesquisar";
            this.BTN_Pesquisar.Size = new System.Drawing.Size(104, 23);
            this.BTN_Pesquisar.TabIndex = 77;
            this.BTN_Pesquisar.Text = "    Pesquisar";
            this.BTN_Pesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Pesquisar.UseVisualStyleBackColor = true;
            this.BTN_Pesquisar.Click += new System.EventHandler(this.BTN_Pesquisar_Click);
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Nº da OS",
            "Nome do Cliente"});
            this.cbBuscar.Location = new System.Drawing.Point(23, 46);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(142, 21);
            this.cbBuscar.TabIndex = 76;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataLista.Location = new System.Drawing.Point(23, 84);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(604, 299);
            this.dataLista.TabIndex = 70;
            this.dataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellDoubleClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(645, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 405);
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 405);
            this.pictureBox3.TabIndex = 74;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(655, 24);
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Navy;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(289, 399);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 13);
            this.lblTotal.TabIndex = 71;
            this.lblTotal.Text = "Total de registros:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(171, 46);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar.TabIndex = 69;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 23);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 5;
            // 
            // FRM_Buscar_OS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(652, 417);
            this.Controls.Add(this.LB_Modo_Exibicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Mostrar_Tudo);
            this.Controls.Add(this.BTN_Pesquisar);
            this.Controls.Add(this.cbBuscar);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Buscar_OS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Ordem de Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Buscar_OS_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Buscar_OS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Modo_Exibicao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Mostrar_Tudo;
        private System.Windows.Forms.Button BTN_Pesquisar;
        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}