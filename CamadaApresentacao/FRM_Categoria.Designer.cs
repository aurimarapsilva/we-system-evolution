namespace CamadaApresentacao
{
    partial class FRM_Categoria
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Categoria));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CHKB_Deletar = new System.Windows.Forms.CheckBox();
            this.DataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LB_Total = new System.Windows.Forms.Label();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.TXB_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.TXB_Descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.TT_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 315);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage1.Controls.Add(this.CHKB_Deletar);
            this.tabPage1.Controls.Add(this.DataLista);
            this.tabPage1.Controls.Add(this.LB_Total);
            this.tabPage1.Controls.Add(this.BTN_Deletar);
            this.tabPage1.Controls.Add(this.TXB_Buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 289);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizar";
            // 
            // CHKB_Deletar
            // 
            this.CHKB_Deletar.AutoSize = true;
            this.CHKB_Deletar.BackColor = System.Drawing.Color.Transparent;
            this.CHKB_Deletar.Location = new System.Drawing.Point(6, 41);
            this.CHKB_Deletar.Name = "CHKB_Deletar";
            this.CHKB_Deletar.Size = new System.Drawing.Size(76, 17);
            this.CHKB_Deletar.TabIndex = 6;
            this.CHKB_Deletar.Text = "Selecionar";
            this.CHKB_Deletar.UseVisualStyleBackColor = false;
            this.CHKB_Deletar.CheckedChanged += new System.EventHandler(this.CHKB_Deletar_CheckedChanged);
            // 
            // DataLista
            // 
            this.DataLista.AllowUserToAddRows = false;
            this.DataLista.AllowUserToDeleteRows = false;
            this.DataLista.AllowUserToOrderColumns = true;
            this.DataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deletar});
            this.DataLista.Location = new System.Drawing.Point(6, 66);
            this.DataLista.MultiSelect = false;
            this.DataLista.Name = "DataLista";
            this.DataLista.ReadOnly = true;
            this.DataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataLista.Size = new System.Drawing.Size(456, 220);
            this.DataLista.TabIndex = 5;
            this.DataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellContentClick);
            this.DataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataLista_CellDoubleClick);
            // 
            // Deletar
            // 
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 47;
            // 
            // LB_Total
            // 
            this.LB_Total.AutoSize = true;
            this.LB_Total.Location = new System.Drawing.Point(172, 42);
            this.LB_Total.Name = "LB_Total";
            this.LB_Total.Size = new System.Drawing.Size(35, 13);
            this.LB_Total.TabIndex = 4;
            this.LB_Total.Text = "label2";
            // 
            // BTN_Deletar
            // 
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.BTN_Deletar.Location = new System.Drawing.Point(250, 8);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(85, 23);
            this.BTN_Deletar.TabIndex = 2;
            this.BTN_Deletar.Text = "   Deletar";
            this.BTN_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // TXB_Buscar
            // 
            this.TXB_Buscar.Location = new System.Drawing.Point(57, 10);
            this.TXB_Buscar.Name = "TXB_Buscar";
            this.TXB_Buscar.Size = new System.Drawing.Size(163, 20);
            this.TXB_Buscar.TabIndex = 1;
            this.TXB_Buscar.TextChanged += new System.EventHandler(this.TXB_Buscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Editar);
            this.groupBox1.Controls.Add(this.BTN_Cancelar);
            this.groupBox1.Controls.Add(this.BTN_Salvar);
            this.groupBox1.Controls.Add(this.BTN_Novo);
            this.groupBox1.Controls.Add(this.TXB_Descricao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TXB_Nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXB_Id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 283);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastar Categorias";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Image = global::CamadaApresentacao.Properties.Resources.Editar16x16;
            this.BTN_Editar.Location = new System.Drawing.Point(234, 228);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Editar.TabIndex = 10;
            this.BTN_Editar.Text = "     Editar";
            this.BTN_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(348, 228);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Cancelar.TabIndex = 8;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(127, 228);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(80, 23);
            this.BTN_Salvar.TabIndex = 7;
            this.BTN_Salvar.Text = "   Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Novo
            // 
            this.BTN_Novo.Image = global::CamadaApresentacao.Properties.Resources.Novo16x16;
            this.BTN_Novo.Location = new System.Drawing.Point(19, 228);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(80, 23);
            this.BTN_Novo.TabIndex = 0;
            this.BTN_Novo.Text = "    Novo";
            this.BTN_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // TXB_Descricao
            // 
            this.TXB_Descricao.Location = new System.Drawing.Point(133, 122);
            this.TXB_Descricao.Multiline = true;
            this.TXB_Descricao.Name = "TXB_Descricao";
            this.TXB_Descricao.Size = new System.Drawing.Size(260, 63);
            this.TXB_Descricao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(73, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Descrição";
            // 
            // TXB_Nome
            // 
            this.TXB_Nome.BackColor = System.Drawing.SystemColors.Window;
            this.TXB_Nome.Location = new System.Drawing.Point(133, 83);
            this.TXB_Nome.Name = "TXB_Nome";
            this.TXB_Nome.Size = new System.Drawing.Size(168, 20);
            this.TXB_Nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(73, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // TXB_Id
            // 
            this.TXB_Id.Location = new System.Drawing.Point(133, 47);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.Size = new System.Drawing.Size(168, 20);
            this.TXB_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(73, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // TT_Mensagem
            // 
            this.TT_Mensagem.IsBalloon = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 15);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 15);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 379);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(514, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 379);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // FRM_Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(519, 379);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Categoria_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Categoria_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox CHKB_Deletar;
        private System.Windows.Forms.DataGridView DataLista;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.Button BTN_Deletar;
        private System.Windows.Forms.TextBox TXB_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXB_Descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXB_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Novo;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.ToolTip TT_Mensagem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BTN_Editar;
    }
}