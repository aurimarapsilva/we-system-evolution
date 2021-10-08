namespace CamadaApresentacao
{
    partial class FRM_Primeiro_Uso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Primeiro_Uso));
            this.label1 = new System.Windows.Forms.Label();
            this.TXB_Usuario = new System.Windows.Forms.TextBox();
            this.TXB_Senha = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PB_Foto = new System.Windows.Forms.PictureBox();
            this.BTN_limpar = new System.Windows.Forms.Button();
            this.BTN_Salvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // TXB_Usuario
            // 
            this.TXB_Usuario.Enabled = false;
            this.TXB_Usuario.Location = new System.Drawing.Point(33, 54);
            this.TXB_Usuario.Name = "TXB_Usuario";
            this.TXB_Usuario.Size = new System.Drawing.Size(230, 20);
            this.TXB_Usuario.TabIndex = 1;
            this.TXB_Usuario.Text = "ADMINISTRADOR";
            // 
            // TXB_Senha
            // 
            this.TXB_Senha.Location = new System.Drawing.Point(33, 104);
            this.TXB_Senha.Name = "TXB_Senha";
            this.TXB_Senha.PasswordChar = '*';
            this.TXB_Senha.Size = new System.Drawing.Size(230, 20);
            this.TXB_Senha.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Usuario);
            this.groupBox1.Controls.Add(this.PB_Foto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTN_limpar);
            this.groupBox1.Controls.Add(this.BTN_Salvar);
            this.groupBox1.Controls.Add(this.TXB_Senha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(175, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 191);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrador Geral";
            // 
            // PB_Foto
            // 
            this.PB_Foto.Image = global::CamadaApresentacao.Properties.Resources.Fundo_White;
            this.PB_Foto.Location = new System.Drawing.Point(149, 15);
            this.PB_Foto.Name = "PB_Foto";
            this.PB_Foto.Size = new System.Drawing.Size(20, 16);
            this.PB_Foto.TabIndex = 5;
            this.PB_Foto.TabStop = false;
            this.PB_Foto.Visible = false;
            // 
            // BTN_limpar
            // 
            this.BTN_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_limpar.Image = global::CamadaApresentacao.Properties.Resources.Limpr16x16;
            this.BTN_limpar.Location = new System.Drawing.Point(167, 153);
            this.BTN_limpar.Name = "BTN_limpar";
            this.BTN_limpar.Size = new System.Drawing.Size(78, 23);
            this.BTN_limpar.TabIndex = 5;
            this.BTN_limpar.Text = "  Limpar";
            this.BTN_limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_limpar.UseVisualStyleBackColor = true;
            this.BTN_limpar.Click += new System.EventHandler(this.BTN_limpar_Click);
            // 
            // BTN_Salvar
            // 
            this.BTN_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Salvar.Image = global::CamadaApresentacao.Properties.Resources.Confirmar16x12;
            this.BTN_Salvar.Location = new System.Drawing.Point(51, 153);
            this.BTN_Salvar.Name = "BTN_Salvar";
            this.BTN_Salvar.Size = new System.Drawing.Size(78, 23);
            this.BTN_Salvar.TabIndex = 4;
            this.BTN_Salvar.Text = "   Salvar";
            this.BTN_Salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Salvar.UseVisualStyleBackColor = true;
            this.BTN_Salvar.Click += new System.EventHandler(this.BTN_Salvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Navy;
            this.pictureBox6.Location = new System.Drawing.Point(495, 65);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(6, 240);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Navy;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(6, 305);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 33);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(102, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 69);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, -26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 98);
            this.label4.TabIndex = 6;
            this.label4.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(26, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ACESSO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::CamadaApresentacao.Properties.Resources.TAG_WE2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(41, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(111, 111);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Navy;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(157, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(312, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "WE System Evolution";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Navy;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(243, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Seja bem vindo!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Navy;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(165, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Desenvolvido por Wagner M. Alves";
            // 
            // FRM_Primeiro_Uso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Primeiro_Uso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Primeiro_Uso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Primeiro_Uso_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Primeiro_Uso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXB_Usuario;
        private System.Windows.Forms.TextBox TXB_Senha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_limpar;
        private System.Windows.Forms.Button BTN_Salvar;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.PictureBox PB_Foto;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}