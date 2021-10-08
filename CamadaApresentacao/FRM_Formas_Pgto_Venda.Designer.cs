namespace CamadaApresentacao
{
    partial class FRM_Formas_Pgto_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Formas_Pgto_Venda));
            this.CB_Formas_Pgto = new System.Windows.Forms.ComboBox();
            this.TXB_Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Adicionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.LB_Valor_Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Formas_Pgto
            // 
            this.CB_Formas_Pgto.FormattingEnabled = true;
            this.CB_Formas_Pgto.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Debito",
            "Cheque",
            "Crediário da Loja",
            "Dinheiro"});
            this.CB_Formas_Pgto.Location = new System.Drawing.Point(33, 89);
            this.CB_Formas_Pgto.Name = "CB_Formas_Pgto";
            this.CB_Formas_Pgto.Size = new System.Drawing.Size(194, 21);
            this.CB_Formas_Pgto.TabIndex = 0;
            this.CB_Formas_Pgto.SelectedIndexChanged += new System.EventHandler(this.CB_Formas_Pgto_SelectedIndexChanged);
            // 
            // TXB_Valor
            // 
            this.TXB_Valor.Location = new System.Drawing.Point(253, 90);
            this.TXB_Valor.Name = "TXB_Valor";
            this.TXB_Valor.Size = new System.Drawing.Size(113, 20);
            this.TXB_Valor.TabIndex = 1;
            this.TXB_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXB_Valor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Formas de Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(257, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor Total:";
            // 
            // BTN_Adicionar
            // 
            this.BTN_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Adicionar.Image = global::CamadaApresentacao.Properties.Resources.Add_16x16;
            this.BTN_Adicionar.Location = new System.Drawing.Point(95, 140);
            this.BTN_Adicionar.Name = "BTN_Adicionar";
            this.BTN_Adicionar.Size = new System.Drawing.Size(117, 25);
            this.BTN_Adicionar.TabIndex = 6;
            this.BTN_Adicionar.Text = "    Adicionar";
            this.BTN_Adicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Adicionar.UseVisualStyleBackColor = true;
            this.BTN_Adicionar.Click += new System.EventHandler(this.BTN_Adicionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 8);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 191);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(409, 8);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(6, 197);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(403, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(6, 199);
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Saida_16x16;
            this.BTN_Sair.Location = new System.Drawing.Point(234, 140);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(85, 25);
            this.BTN_Sair.TabIndex = 25;
            this.BTN_Sair.Text = "     Sair";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // LB_Valor_Total
            // 
            this.LB_Valor_Total.AutoSize = true;
            this.LB_Valor_Total.BackColor = System.Drawing.Color.Transparent;
            this.LB_Valor_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Valor_Total.Location = new System.Drawing.Point(230, 24);
            this.LB_Valor_Total.Name = "LB_Valor_Total";
            this.LB_Valor_Total.Size = new System.Drawing.Size(76, 25);
            this.LB_Valor_Total.TabIndex = 26;
            this.LB_Valor_Total.Text = "label4";
            this.LB_Valor_Total.TextChanged += new System.EventHandler(this.LB_Valor_Total_TextChanged);
            // 
            // FRM_Formas_Pgto_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(410, 199);
            this.Controls.Add(this.LB_Valor_Total);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Adicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXB_Valor);
            this.Controls.Add(this.CB_Formas_Pgto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Formas_Pgto_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Forma(s) de Pagamento";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Formas_Pgto_Venda_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Formas_Pgto_Venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Formas_Pgto;
        private System.Windows.Forms.TextBox TXB_Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_Adicionar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Label LB_Valor_Total;
    }
}