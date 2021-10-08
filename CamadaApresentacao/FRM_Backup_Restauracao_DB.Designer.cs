namespace CamadaApresentacao
{
    partial class FRM_Backup_Restauracao_DB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Backup_Restauracao_DB));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_Servidor = new System.Windows.Forms.TextBox();
            this.TXB_Database = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Backup = new System.Windows.Forms.Button();
            this.BTN_Restauracao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CB_Backups = new System.Windows.Forms.ComboBox();
            this.BTN_Local_Backup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-39, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(541, 8);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 8);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 251);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(496, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 251);
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Servidor:";
            // 
            // TXB_Servidor
            // 
            this.TXB_Servidor.ForeColor = System.Drawing.Color.Black;
            this.TXB_Servidor.Location = new System.Drawing.Point(29, 39);
            this.TXB_Servidor.Name = "TXB_Servidor";
            this.TXB_Servidor.ReadOnly = true;
            this.TXB_Servidor.Size = new System.Drawing.Size(192, 20);
            this.TXB_Servidor.TabIndex = 27;
            this.TXB_Servidor.Text = "SERVIDOR\\SQLEXPRESS";
            // 
            // TXB_Database
            // 
            this.TXB_Database.ForeColor = System.Drawing.Color.Black;
            this.TXB_Database.Location = new System.Drawing.Point(275, 39);
            this.TXB_Database.Name = "TXB_Database";
            this.TXB_Database.ReadOnly = true;
            this.TXB_Database.Size = new System.Drawing.Size(151, 20);
            this.TXB_Database.TabIndex = 29;
            this.TXB_Database.Text = "DB_WE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(272, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Banco de Dados:";
            // 
            // BTN_Backup
            // 
            this.BTN_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Backup.ForeColor = System.Drawing.Color.Black;
            this.BTN_Backup.Location = new System.Drawing.Point(29, 65);
            this.BTN_Backup.Name = "BTN_Backup";
            this.BTN_Backup.Size = new System.Drawing.Size(397, 26);
            this.BTN_Backup.TabIndex = 30;
            this.BTN_Backup.Text = "Backup";
            this.BTN_Backup.UseVisualStyleBackColor = true;
            this.BTN_Backup.Click += new System.EventHandler(this.BTN_Backup_Click);
            // 
            // BTN_Restauracao
            // 
            this.BTN_Restauracao.Enabled = false;
            this.BTN_Restauracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Restauracao.ForeColor = System.Drawing.Color.Black;
            this.BTN_Restauracao.Location = new System.Drawing.Point(29, 56);
            this.BTN_Restauracao.Name = "BTN_Restauracao";
            this.BTN_Restauracao.Size = new System.Drawing.Size(397, 26);
            this.BTN_Restauracao.TabIndex = 32;
            this.BTN_Restauracao.Text = "Restaurar";
            this.BTN_Restauracao.UseVisualStyleBackColor = true;
            this.BTN_Restauracao.Click += new System.EventHandler(this.BTN_Restauracao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BTN_Backup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXB_Servidor);
            this.groupBox1.Controls.Add(this.TXB_Database);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(20, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 106);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CB_Backups);
            this.groupBox2.Controls.Add(this.BTN_Local_Backup);
            this.groupBox2.Controls.Add(this.BTN_Restauracao);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(20, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 94);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restauração";
            // 
            // CB_Backups
            // 
            this.CB_Backups.Enabled = false;
            this.CB_Backups.FormattingEnabled = true;
            this.CB_Backups.Location = new System.Drawing.Point(29, 29);
            this.CB_Backups.Name = "CB_Backups";
            this.CB_Backups.Size = new System.Drawing.Size(333, 21);
            this.CB_Backups.TabIndex = 38;
            this.CB_Backups.SelectedIndexChanged += new System.EventHandler(this.CB_Backups_SelectedIndexChanged);
            // 
            // BTN_Local_Backup
            // 
            this.BTN_Local_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Local_Backup.ForeColor = System.Drawing.Color.Black;
            this.BTN_Local_Backup.Location = new System.Drawing.Point(383, 27);
            this.BTN_Local_Backup.Name = "BTN_Local_Backup";
            this.BTN_Local_Backup.Size = new System.Drawing.Size(43, 23);
            this.BTN_Local_Backup.TabIndex = 36;
            this.BTN_Local_Backup.Text = "...";
            this.BTN_Local_Backup.UseVisualStyleBackColor = true;
            this.BTN_Local_Backup.Click += new System.EventHandler(this.BTN_Local_Backup_Click);
            // 
            // FRM_Backup_Restauracao_DB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(503, 250);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Backup_Restauracao_DB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Backup e Restauração - Banco de Dados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Backup_Restauracao_DB_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Backup_Restauracao_DB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_Servidor;
        private System.Windows.Forms.TextBox TXB_Database;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Backup;
        private System.Windows.Forms.Button BTN_Restauracao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Local_Backup;
        private System.Windows.Forms.ComboBox CB_Backups;
    }
}