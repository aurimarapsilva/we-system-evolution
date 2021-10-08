namespace CamadaApresentacao
{
    partial class FRM_Config_Cartao_Credito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Config_Cartao_Credito));
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_Id = new System.Windows.Forms.TextBox();
            this.TXB_Prazo_Compens_1_Parc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Prazo_Compens_Demais_Parc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_Taxa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_Config_Atual = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTN_Editar = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.BTN_Novo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_Total_Registros = new System.Windows.Forms.Label();
            this.TXB_Bandeira = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraçãoAutomáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Config_Atual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // TXB_Id
            // 
            this.TXB_Id.Enabled = false;
            this.TXB_Id.Location = new System.Drawing.Point(29, 59);
            this.TXB_Id.Name = "TXB_Id";
            this.TXB_Id.ReadOnly = true;
            this.TXB_Id.Size = new System.Drawing.Size(205, 20);
            this.TXB_Id.TabIndex = 1;
            // 
            // TXB_Prazo_Compens_1_Parc
            // 
            this.TXB_Prazo_Compens_1_Parc.Location = new System.Drawing.Point(306, 114);
            this.TXB_Prazo_Compens_1_Parc.Name = "TXB_Prazo_Compens_1_Parc";
            this.TXB_Prazo_Compens_1_Parc.Size = new System.Drawing.Size(175, 20);
            this.TXB_Prazo_Compens_1_Parc.TabIndex = 3;
            this.TXB_Prazo_Compens_1_Parc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Prazo_Compens_1_Parc_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(303, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prazo de Compensação - 1º Parcela";
            // 
            // TXB_Prazo_Compens_Demais_Parc
            // 
            this.TXB_Prazo_Compens_Demais_Parc.Location = new System.Drawing.Point(29, 169);
            this.TXB_Prazo_Compens_Demais_Parc.Name = "TXB_Prazo_Compens_Demais_Parc";
            this.TXB_Prazo_Compens_Demais_Parc.Size = new System.Drawing.Size(205, 20);
            this.TXB_Prazo_Compens_Demais_Parc.TabIndex = 5;
            this.TXB_Prazo_Compens_Demais_Parc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Prazo_Compens_Demais_Parc_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prazo de Compensação - Demais Parcelas";
            // 
            // TXB_Taxa
            // 
            this.TXB_Taxa.Location = new System.Drawing.Point(306, 169);
            this.TXB_Taxa.Name = "TXB_Taxa";
            this.TXB_Taxa.Size = new System.Drawing.Size(119, 20);
            this.TXB_Taxa.TabIndex = 7;
            this.TXB_Taxa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Taxa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(303, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Taxa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(26, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bandeira:";
            // 
            // DGV_Config_Atual
            // 
            this.DGV_Config_Atual.AllowUserToAddRows = false;
            this.DGV_Config_Atual.AllowUserToDeleteRows = false;
            this.DGV_Config_Atual.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Config_Atual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Config_Atual.Location = new System.Drawing.Point(29, 213);
            this.DGV_Config_Atual.MultiSelect = false;
            this.DGV_Config_Atual.Name = "DGV_Config_Atual";
            this.DGV_Config_Atual.ReadOnly = true;
            this.DGV_Config_Atual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Config_Atual.Size = new System.Drawing.Size(612, 177);
            this.DGV_Config_Atual.TabIndex = 12;
            this.DGV_Config_Atual.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Config_Atual_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 425);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(661, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 426);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(0, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(671, 20);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // BTN_Editar
            // 
            this.BTN_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Editar.Image = global::CamadaApresentacao.Properties.Resources.Editar16x16;
            this.BTN_Editar.Location = new System.Drawing.Point(553, 84);
            this.BTN_Editar.Name = "BTN_Editar";
            this.BTN_Editar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Editar.TabIndex = 21;
            this.BTN_Editar.Text = "     Alterar";
            this.BTN_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Editar.UseVisualStyleBackColor = true;
            this.BTN_Editar.Click += new System.EventHandler(this.BTN_Editar_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(553, 166);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Cancelar.TabIndex = 20;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(553, 125);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(88, 23);
            this.BTN_Salvar.TabIndex = 19;
            this.BTN_Salvar.Text = "    Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // BTN_Novo
            // 
            this.BTN_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Novo.Image = global::CamadaApresentacao.Properties.Resources.Novo16x16;
            this.BTN_Novo.Location = new System.Drawing.Point(553, 43);
            this.BTN_Novo.Name = "BTN_Novo";
            this.BTN_Novo.Size = new System.Drawing.Size(88, 23);
            this.BTN_Novo.TabIndex = 18;
            this.BTN_Novo.Text = "     Novo";
            this.BTN_Novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Novo.UseVisualStyleBackColor = true;
            this.BTN_Novo.Click += new System.EventHandler(this.BTN_Novo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(26, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total de Registros:";
            // 
            // LB_Total_Registros
            // 
            this.LB_Total_Registros.AutoSize = true;
            this.LB_Total_Registros.BackColor = System.Drawing.Color.Navy;
            this.LB_Total_Registros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Total_Registros.ForeColor = System.Drawing.Color.White;
            this.LB_Total_Registros.Location = new System.Drawing.Point(141, 408);
            this.LB_Total_Registros.Name = "LB_Total_Registros";
            this.LB_Total_Registros.Size = new System.Drawing.Size(34, 13);
            this.LB_Total_Registros.TabIndex = 23;
            this.LB_Total_Registros.Text = "label";
            // 
            // TXB_Bandeira
            // 
            this.TXB_Bandeira.Location = new System.Drawing.Point(29, 114);
            this.TXB_Bandeira.Name = "TXB_Bandeira";
            this.TXB_Bandeira.Size = new System.Drawing.Size(205, 20);
            this.TXB_Bandeira.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Navy;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoAutomáticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(671, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraçãoAutomáticaToolStripMenuItem
            // 
            this.configuraçãoAutomáticaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçãoAutomáticaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.configuraçãoAutomáticaToolStripMenuItem.Name = "configuraçãoAutomáticaToolStripMenuItem";
            this.configuraçãoAutomáticaToolStripMenuItem.Size = new System.Drawing.Size(162, 20);
            this.configuraçãoAutomáticaToolStripMenuItem.Text = "Compensação Automática";
            this.configuraçãoAutomáticaToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoAutomáticaToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "%";
            // 
            // FRM_Config_Cartao_Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(671, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TXB_Bandeira);
            this.Controls.Add(this.LB_Total_Registros);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BTN_Editar);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Salvar);
            this.Controls.Add(this.BTN_Novo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DGV_Config_Atual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXB_Taxa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXB_Prazo_Compens_Demais_Parc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXB_Prazo_Compens_1_Parc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXB_Id);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Config_Cartao_Credito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações - Cartão de Crédito";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Config_Cartao_Credito_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Config_Cartao_Credito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Config_Atual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_Id;
        private System.Windows.Forms.TextBox TXB_Prazo_Compens_1_Parc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Prazo_Compens_Demais_Parc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_Taxa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_Config_Atual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BTN_Editar;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.Button BTN_Novo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_Total_Registros;
        private System.Windows.Forms.TextBox TXB_Bandeira;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoAutomáticaToolStripMenuItem;
        private System.Windows.Forms.Label label6;
    }
}