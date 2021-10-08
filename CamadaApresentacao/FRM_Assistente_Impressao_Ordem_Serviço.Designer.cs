namespace CamadaApresentacao
{
    partial class FRM_Assistente_Impressao_Ordem_Serviço
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Assistente_Impressao_Ordem_Serviço));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_Tipo_OS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Num_OS = new System.Windows.Forms.TextBox();
            this.BTN_Buscar_OS = new System.Windows.Forms.Button();
            this.BTN_Imprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 7);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 7);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(7, 143);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(364, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(7, 143);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo de OS";
            // 
            // CB_Tipo_OS
            // 
            this.CB_Tipo_OS.FormattingEnabled = true;
            this.CB_Tipo_OS.Items.AddRange(new object[] {
            "OS - Em Branco",
            "OS - Preenchida",
            "Página Anexo - Prod. e Serviços"});
            this.CB_Tipo_OS.Location = new System.Drawing.Point(31, 42);
            this.CB_Tipo_OS.Name = "CB_Tipo_OS";
            this.CB_Tipo_OS.Size = new System.Drawing.Size(196, 21);
            this.CB_Tipo_OS.TabIndex = 5;
            this.CB_Tipo_OS.SelectedIndexChanged += new System.EventHandler(this.CB_Tipo_OS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nº da OS:";
            // 
            // TXB_Num_OS
            // 
            this.TXB_Num_OS.Location = new System.Drawing.Point(31, 94);
            this.TXB_Num_OS.Name = "TXB_Num_OS";
            this.TXB_Num_OS.ReadOnly = true;
            this.TXB_Num_OS.Size = new System.Drawing.Size(109, 20);
            this.TXB_Num_OS.TabIndex = 7;
            this.TXB_Num_OS.TextChanged += new System.EventHandler(this.TXB_Num_OS_TextChanged);
            // 
            // BTN_Buscar_OS
            // 
            this.BTN_Buscar_OS.Enabled = false;
            this.BTN_Buscar_OS.Image = global::CamadaApresentacao.Properties.Resources.Buscar_16x16;
            this.BTN_Buscar_OS.Location = new System.Drawing.Point(181, 91);
            this.BTN_Buscar_OS.Name = "BTN_Buscar_OS";
            this.BTN_Buscar_OS.Size = new System.Drawing.Size(46, 23);
            this.BTN_Buscar_OS.TabIndex = 8;
            this.BTN_Buscar_OS.UseVisualStyleBackColor = true;
            this.BTN_Buscar_OS.Click += new System.EventHandler(this.BTN_Buscar_OS_Click);
            // 
            // BTN_Imprimir
            // 
            this.BTN_Imprimir.Enabled = false;
            this.BTN_Imprimir.Image = global::CamadaApresentacao.Properties.Resources.Imprimir_16x16;
            this.BTN_Imprimir.Location = new System.Drawing.Point(262, 60);
            this.BTN_Imprimir.Name = "BTN_Imprimir";
            this.BTN_Imprimir.Size = new System.Drawing.Size(80, 31);
            this.BTN_Imprimir.TabIndex = 9;
            this.BTN_Imprimir.Text = "   Imprimir";
            this.BTN_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Imprimir.UseVisualStyleBackColor = true;
            this.BTN_Imprimir.Click += new System.EventHandler(this.BTN_Imprimir_Click);
            // 
            // FRM_Assistente_Impressao_Ordem_Serviço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(371, 142);
            this.Controls.Add(this.BTN_Imprimir);
            this.Controls.Add(this.BTN_Buscar_OS);
            this.Controls.Add(this.TXB_Num_OS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Tipo_OS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Assistente_Impressao_Ordem_Serviço";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assistente de Impressão de Ordem de Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Printer_Tipo_Ordem_Serviço_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_Tipo_OS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Num_OS;
        private System.Windows.Forms.Button BTN_Buscar_OS;
        private System.Windows.Forms.Button BTN_Imprimir;
    }
}