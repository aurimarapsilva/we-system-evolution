namespace CamadaApresentacao
{
    partial class FRM_Deletar_mais_1_Item_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Deletar_mais_1_Item_Venda));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TXB_Quant = new System.Windows.Forms.TextBox();
            this.BTN_Incremento = new System.Windows.Forms.Button();
            this.BTN_decremento = new System.Windows.Forms.Button();
            this.BTN_Confirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 7);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(334, 7);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 150);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(325, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(8, 150);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // TXB_Quant
            // 
            this.TXB_Quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Quant.Location = new System.Drawing.Point(35, 43);
            this.TXB_Quant.Name = "TXB_Quant";
            this.TXB_Quant.ReadOnly = true;
            this.TXB_Quant.Size = new System.Drawing.Size(144, 24);
            this.TXB_Quant.TabIndex = 5;
            this.TXB_Quant.TextChanged += new System.EventHandler(this.TXB_Quant_TextChanged);
            // 
            // BTN_Incremento
            // 
            this.BTN_Incremento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Incremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Incremento.Location = new System.Drawing.Point(208, 33);
            this.BTN_Incremento.Name = "BTN_Incremento";
            this.BTN_Incremento.Size = new System.Drawing.Size(30, 30);
            this.BTN_Incremento.TabIndex = 6;
            this.BTN_Incremento.Text = "+";
            this.BTN_Incremento.UseVisualStyleBackColor = true;
            this.BTN_Incremento.Click += new System.EventHandler(this.BTN_Incremento_Click);
            // 
            // BTN_decremento
            // 
            this.BTN_decremento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_decremento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_decremento.Location = new System.Drawing.Point(254, 33);
            this.BTN_decremento.Name = "BTN_decremento";
            this.BTN_decremento.Size = new System.Drawing.Size(30, 30);
            this.BTN_decremento.TabIndex = 7;
            this.BTN_decremento.Text = "-";
            this.BTN_decremento.UseVisualStyleBackColor = true;
            this.BTN_decremento.Click += new System.EventHandler(this.BTN_decremento_Click);
            // 
            // BTN_Confirmar
            // 
            this.BTN_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Confirmar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Confirmar.Location = new System.Drawing.Point(102, 96);
            this.BTN_Confirmar.Name = "BTN_Confirmar";
            this.BTN_Confirmar.Size = new System.Drawing.Size(136, 26);
            this.BTN_Confirmar.TabIndex = 8;
            this.BTN_Confirmar.Text = "    Confirmar";
            this.BTN_Confirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Confirmar.UseVisualStyleBackColor = true;
            this.BTN_Confirmar.Click += new System.EventHandler(this.BTN_Confirmar_Click);
            // 
            // FRM_Deletar_mais_1_Item_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(333, 150);
            this.Controls.Add(this.BTN_Confirmar);
            this.Controls.Add(this.BTN_decremento);
            this.Controls.Add(this.BTN_Incremento);
            this.Controls.Add(this.TXB_Quant);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Deletar_mais_1_Item_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deletar Item(s) da lista";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Deletar_mais_1_Item_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Deletar_mais_1_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox TXB_Quant;
        private System.Windows.Forms.Button BTN_Incremento;
        private System.Windows.Forms.Button BTN_decremento;
        private System.Windows.Forms.Button BTN_Confirmar;
    }
}