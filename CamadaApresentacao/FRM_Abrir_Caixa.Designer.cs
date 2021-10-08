namespace CamadaApresentacao
{
    partial class FRM_Abrir_Caixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Abrir_Caixa));
            this.CB_Guiche_Atendimento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Abrir = new System.Windows.Forms.Button();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Valor_Inicial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Guiche_Atendimento
            // 
            this.CB_Guiche_Atendimento.FormattingEnabled = true;
            this.CB_Guiche_Atendimento.Location = new System.Drawing.Point(73, 24);
            this.CB_Guiche_Atendimento.Name = "CB_Guiche_Atendimento";
            this.CB_Guiche_Atendimento.Size = new System.Drawing.Size(205, 21);
            this.CB_Guiche_Atendimento.TabIndex = 0;
            this.CB_Guiche_Atendimento.SelectedIndexChanged += new System.EventHandler(this.CB_Guiche_Atendimento_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caixa:";
            // 
            // BTN_Abrir
            // 
            this.BTN_Abrir.Image = global::CamadaApresentacao.Properties.Resources.Abrir;
            this.BTN_Abrir.Location = new System.Drawing.Point(55, 92);
            this.BTN_Abrir.Name = "BTN_Abrir";
            this.BTN_Abrir.Size = new System.Drawing.Size(72, 23);
            this.BTN_Abrir.TabIndex = 2;
            this.BTN_Abrir.Text = "   Abrir";
            this.BTN_Abrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Abrir.UseVisualStyleBackColor = true;
            this.BTN_Abrir.Click += new System.EventHandler(this.BTN_Abrir_Click);
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(167, 92);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(89, 23);
            this.BTN_Cancelar.TabIndex = 3;
            this.BTN_Cancelar.Text = "   Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 8);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 138);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(308, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 138);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(316, 8);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Valor Inicial:";
            // 
            // TXB_Valor_Inicial
            // 
            this.TXB_Valor_Inicial.Location = new System.Drawing.Point(101, 54);
            this.TXB_Valor_Inicial.Name = "TXB_Valor_Inicial";
            this.TXB_Valor_Inicial.Size = new System.Drawing.Size(177, 20);
            this.TXB_Valor_Inicial.TabIndex = 28;
            this.TXB_Valor_Inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Valor_Inicial_KeyPress);
            // 
            // FRM_Abrir_Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(315, 137);
            this.Controls.Add(this.TXB_Valor_Inicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Abrir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Guiche_Atendimento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Abrir_Caixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Abrir_Caixa_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Abrir_Caixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Guiche_Atendimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Abrir;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Valor_Inicial;
    }
}