namespace CamadaApresentacao
{
    partial class FRM_Equipamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Equipamentos));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TT_Mensagem = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.TXB_Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CHKB_Selecionar = new System.Windows.Forms.CheckBox();
            this.DataLista = new System.Windows.Forms.DataGridView();
            this.Deletar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LB_Total = new System.Windows.Forms.Label();
            this.BTN_Deletar = new System.Windows.Forms.Button();
            this.TXB_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(513, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 379);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(520, 15);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 15);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // TT_Mensagem
            // 
            this.TT_Mensagem.IsBalloon = true;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 379);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(320, 202);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(90, 23);
            this.BTN_Cancelar.TabIndex = 8;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Editar);
            this.groupBox1.Controls.Add(this.BTN_Cancelar);
            this.groupBox1.Controls.Add(this.BTN_Salvar);
            this.groupBox1.Controls.Add(this.BTN_Novo);
            this.groupBox1.Controls.Add(this.TXB_Nome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXB_Id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastar Categorias";
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Editar.Image = global::CamadaApresentacao.Properties.Resources.Editar16x16;
            this.BTN_Editar.Location = new System.Drawing.Point(129, 202);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Editar.TabIndex = 9;
            this.BTN_Editar.Text = "   Editar";
            this.BTN_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(224, 202);
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
            this.BTN_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Novo.Image = global::CamadaApresentacao.Properties.Resources.Novo16x16;
            this.BTN_Novo.Location = new System.Drawing.Point(37, 202);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(75, 23);
            this.BTN_Novo.TabIndex = 0;
            this.BTN_Novo.Text = "   Novo";
            this.BTN_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // TXB_Nome
            // 
            this.TXB_Nome.Location = new System.Drawing.Point(175, 117);
            this.TXB_Nome.Name = "TXB_Nome";
            this.TXB_Nome.Size = new System.Drawing.Size(168, 20);
            this.TXB_Nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(115, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // TXB_Id
            // 
            this.TXB_Id.Location = new System.Drawing.Point(175, 81);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.Size = new System.Drawing.Size(168, 20);
            this.TXB_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(115, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 289);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastrar";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(21, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 315);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.tabPage1.Controls.Add(this.CHKB_Selecionar);
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
            // CHKB_Selecionar
            // 
            this.CHKB_Selecionar.AutoSize = true;
            this.CHKB_Selecionar.BackColor = System.Drawing.Color.Transparent;
            this.CHKB_Selecionar.Location = new System.Drawing.Point(6, 41);
            this.CHKB_Selecionar.Name = "CHKB_Selecionar";
            this.CHKB_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHKB_Selecionar.TabIndex = 6;
            this.CHKB_Selecionar.Text = "Selecionar";
            this.CHKB_Selecionar.UseVisualStyleBackColor = false;
            this.CHKB_Selecionar.CheckedChanged += new System.EventHandler(this.CHKB_Selecionar_CheckedChanged);
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
            this.BTN_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Deletar.Enabled = false;
            this.BTN_Deletar.Image = global::CamadaApresentacao.Properties.Resources.Excluir_16x16;
            this.BTN_Deletar.Location = new System.Drawing.Point(315, 8);
            this.BTN_Deletar.Name = "BTN_Deletar";
            this.BTN_Deletar.Size = new System.Drawing.Size(90, 23);
            this.BTN_Deletar.TabIndex = 2;
            this.BTN_Deletar.Text = "    Deletar";
            this.BTN_Deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Deletar.UseVisualStyleBackColor = true;
            this.BTN_Deletar.Click += new System.EventHandler(this.BTN_Deletar_Click);
            // 
            // TXB_Buscar
            // 
            this.TXB_Buscar.Location = new System.Drawing.Point(57, 10);
            this.TXB_Buscar.Name = "TXB_Buscar";
            this.TXB_Buscar.Size = new System.Drawing.Size(214, 20);
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
            // FRM_Equipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(519, 379);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Equipamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipamentos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Equipamentos_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Equipamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip TT_Mensagem;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox CHKB_Selecionar;
        private System.Windows.Forms.DataGridView DataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Deletar;
        private System.Windows.Forms.Label LB_Total;
        private System.Windows.Forms.Button BTN_Deletar;
        private System.Windows.Forms.TextBox TXB_Buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Novo;
        private System.Windows.Forms.TextBox TXB_Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Editar;
    }
}