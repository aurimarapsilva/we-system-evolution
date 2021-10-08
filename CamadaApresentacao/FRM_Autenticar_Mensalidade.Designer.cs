namespace CamadaApresentacao
{
    partial class FRM_Autenticar_Mensalidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Autenticar_Mensalidade));
            this.DGV_Mensalidades = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_Codigo_Autenticacao = new System.Windows.Forms.TextBox();
            this.CHK_Selecionar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mensalidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Mensalidades
            // 
            this.DGV_Mensalidades.AllowUserToAddRows = false;
            this.DGV_Mensalidades.AllowUserToDeleteRows = false;
            this.DGV_Mensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Mensalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select});
            this.DGV_Mensalidades.Location = new System.Drawing.Point(24, 40);
            this.DGV_Mensalidades.MultiSelect = false;
            this.DGV_Mensalidades.Name = "DGV_Mensalidades";
            this.DGV_Mensalidades.ReadOnly = true;
            this.DGV_Mensalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Mensalidades.Size = new System.Drawing.Size(155, 128);
            this.DGV_Mensalidades.TabIndex = 25;
            this.DGV_Mensalidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Mensalidades_CellContentClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.ReadOnly = true;
            this.Select.Visible = false;
            this.Select.Width = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(201, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Selecione a mensalidade vencida e insira o respectivo código.";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(581, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 190);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(7, 190);
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 183);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(588, 7);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 7);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(412, 130);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(95, 23);
            this.BTN_Cancelar.TabIndex = 19;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Confirmar
            // 
            this.BTN_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Confirmar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Confirmar.Location = new System.Drawing.Point(255, 130);
            this.BTN_Confirmar.Name = "BTN_Confirmar";
            this.BTN_Confirmar.Size = new System.Drawing.Size(95, 23);
            this.BTN_Confirmar.TabIndex = 18;
            this.BTN_Confirmar.Text = "   Confirmar";
            this.BTN_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Confirmar.UseVisualStyleBackColor = true;
            this.BTN_Confirmar.Click += new System.EventHandler(this.BTN_Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(217, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código de Autenticação:";
            // 
            // TXB_Codigo_Autenticacao
            // 
            this.TXB_Codigo_Autenticacao.Location = new System.Drawing.Point(220, 95);
            this.TXB_Codigo_Autenticacao.Name = "TXB_Codigo_Autenticacao";
            this.TXB_Codigo_Autenticacao.Size = new System.Drawing.Size(324, 20);
            this.TXB_Codigo_Autenticacao.TabIndex = 16;
            // 
            // CHK_Selecionar
            // 
            this.CHK_Selecionar.AutoSize = true;
            this.CHK_Selecionar.BackColor = System.Drawing.Color.Transparent;
            this.CHK_Selecionar.Location = new System.Drawing.Point(24, 20);
            this.CHK_Selecionar.Name = "CHK_Selecionar";
            this.CHK_Selecionar.Size = new System.Drawing.Size(76, 17);
            this.CHK_Selecionar.TabIndex = 26;
            this.CHK_Selecionar.Text = "Selecionar";
            this.CHK_Selecionar.UseVisualStyleBackColor = false;
            this.CHK_Selecionar.CheckedChanged += new System.EventHandler(this.CHK_Selecionar_CheckedChanged);
            // 
            // FRM_Autenticar_Mensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(588, 190);
            this.Controls.Add(this.DGV_Mensalidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Codigo_Autenticacao);
            this.Controls.Add(this.CHK_Selecionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Autenticar_Mensalidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autenticar Mensalidade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Autenticar_Mensalidade_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Autenticar_Mensalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Mensalidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Mensalidades;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_Codigo_Autenticacao;
        private System.Windows.Forms.CheckBox CHK_Selecionar;
    }
}