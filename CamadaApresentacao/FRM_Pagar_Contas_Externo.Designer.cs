namespace CamadaApresentacao
{
    partial class FRM_Pagar_Contas_Externo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Pagar_Contas_Externo));
            this.TXB_Valor_Atualizado = new System.Windows.Forms.TextBox();
            this.TXB_Valor_Recebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Cancelar = new System.Windows.Forms.Button();
            this.BTN_Pagar = new System.Windows.Forms.Button();
            this.CHK_Habilitar_Receb_Parcial = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXB_Valor_Atualizado
            // 
            this.TXB_Valor_Atualizado.Enabled = false;
            this.TXB_Valor_Atualizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Atualizado.ForeColor = System.Drawing.Color.Black;
            this.TXB_Valor_Atualizado.Location = new System.Drawing.Point(31, 38);
            this.TXB_Valor_Atualizado.Name = "TXB_Valor_Atualizado";
            this.TXB_Valor_Atualizado.ReadOnly = true;
            this.TXB_Valor_Atualizado.Size = new System.Drawing.Size(139, 24);
            this.TXB_Valor_Atualizado.TabIndex = 0;
            // 
            // TXB_Valor_Recebido
            // 
            this.TXB_Valor_Recebido.Enabled = false;
            this.TXB_Valor_Recebido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Recebido.ForeColor = System.Drawing.Color.Black;
            this.TXB_Valor_Recebido.Location = new System.Drawing.Point(209, 38);
            this.TXB_Valor_Recebido.Name = "TXB_Valor_Recebido";
            this.TXB_Valor_Recebido.ReadOnly = true;
            this.TXB_Valor_Recebido.Size = new System.Drawing.Size(139, 24);
            this.TXB_Valor_Recebido.TabIndex = 1;
            this.TXB_Valor_Recebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Valor_Recebido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Atualizado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(206, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Pago:";
            // 
            // BTN_Cancelar
            // 
            this.BTN_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancelar.Image = global::CamadaApresentacao.Properties.Resources.Cancel16x16;
            this.BTN_Cancelar.Location = new System.Drawing.Point(309, 132);
            this.BTN_Cancelar.Name = "BTN_Cancelar";
            this.BTN_Cancelar.Size = new System.Drawing.Size(98, 26);
            this.BTN_Cancelar.TabIndex = 14;
            this.BTN_Cancelar.Text = "    Cancelar";
            this.BTN_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Cancelar.UseVisualStyleBackColor = true;
            this.BTN_Cancelar.Click += new System.EventHandler(this.BTN_Cancelar_Click);
            // 
            // BTN_Pagar
            // 
            this.BTN_Pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Pagar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Pagar.Location = new System.Drawing.Point(190, 132);
            this.BTN_Pagar.Name = "BTN_Pagar";
            this.BTN_Pagar.Size = new System.Drawing.Size(98, 26);
            this.BTN_Pagar.TabIndex = 13;
            this.BTN_Pagar.Text = "     Pagar";
            this.BTN_Pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Pagar.UseVisualStyleBackColor = true;
            this.BTN_Pagar.Click += new System.EventHandler(this.BTN_Pagar_Click);
            // 
            // CHK_Habilitar_Receb_Parcial
            // 
            this.CHK_Habilitar_Receb_Parcial.AutoSize = true;
            this.CHK_Habilitar_Receb_Parcial.BackColor = System.Drawing.Color.Transparent;
            this.CHK_Habilitar_Receb_Parcial.ForeColor = System.Drawing.Color.Black;
            this.CHK_Habilitar_Receb_Parcial.Location = new System.Drawing.Point(31, 32);
            this.CHK_Habilitar_Receb_Parcial.Name = "CHK_Habilitar_Receb_Parcial";
            this.CHK_Habilitar_Receb_Parcial.Size = new System.Drawing.Size(64, 17);
            this.CHK_Habilitar_Receb_Parcial.TabIndex = 6;
            this.CHK_Habilitar_Receb_Parcial.Text = "Habilitar";
            this.CHK_Habilitar_Receb_Parcial.UseVisualStyleBackColor = false;
            this.CHK_Habilitar_Receb_Parcial.CheckedChanged += new System.EventHandler(this.CHK_Habilitar_Receb_Parcial_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(-1, 190);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(438, 8);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(438, 8);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(430, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 198);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(7, 198);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Valor_Atualizado);
            this.groupBox1.Controls.Add(this.TXB_Valor_Recebido);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(28, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 79);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Atualizadas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CHK_Habilitar_Receb_Parcial);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(28, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 69);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagamento Parcial";
            // 
            // FRM_Pagar_Contas_Externo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(437, 198);
            this.Controls.Add(this.BTN_Cancelar);
            this.Controls.Add(this.BTN_Pagar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Pagar_Contas_Externo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento de Contas";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Pagar_Contas_Externo_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Pagar_Contas_Externo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_Valor_Atualizado;
        private System.Windows.Forms.TextBox TXB_Valor_Recebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Cancelar;
        private System.Windows.Forms.Button BTN_Pagar;
        private System.Windows.Forms.CheckBox CHK_Habilitar_Receb_Parcial;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}