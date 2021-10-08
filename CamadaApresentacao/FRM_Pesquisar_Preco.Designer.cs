namespace CamadaApresentacao
{
    partial class FRM_Pesquisar_Preco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Pesquisar_Preco));
            this.TXB_Descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXB_Tipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_Estoque_Atual = new System.Windows.Forms.TextBox();
            this.PX_Imagem = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXB_Prateleira_Dep = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TXB_Corredor_Dep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXB_Prateleira_Expo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXB_Corredor_Expo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CB_Parcel_Cred_Loja = new System.Windows.Forms.ComboBox();
            this.CB_Parcel_Card_Cred = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TXB_Valor_Cred_Loja = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXB_Valor_Card_Cred = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXB_Valor_Dinheiro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DGV_Pesquisar_Preco_Codigo_Barras = new System.Windows.Forms.DataGridView();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PX_Imagem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pesquisar_Preco_Codigo_Barras)).BeginInit();
            this.SuspendLayout();
            // 
            // TXB_Descricao
            // 
            this.TXB_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Descricao.ForeColor = System.Drawing.Color.Black;
            this.TXB_Descricao.Location = new System.Drawing.Point(27, 62);
            this.TXB_Descricao.Name = "TXB_Descricao";
            this.TXB_Descricao.Size = new System.Drawing.Size(735, 29);
            this.TXB_Descricao.TabIndex = 0;
            this.TXB_Descricao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXB_Descricao_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // TXB_Tipo
            // 
            this.TXB_Tipo.Enabled = false;
            this.TXB_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Tipo.ForeColor = System.Drawing.Color.Black;
            this.TXB_Tipo.Location = new System.Drawing.Point(27, 142);
            this.TXB_Tipo.Name = "TXB_Tipo";
            this.TXB_Tipo.Size = new System.Drawing.Size(249, 29);
            this.TXB_Tipo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(509, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estoque Atual:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Estoque_Atual);
            this.groupBox1.Controls.Add(this.PX_Imagem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXB_Descricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXB_Tipo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(33, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Primários";
            // 
            // TXB_Estoque_Atual
            // 
            this.TXB_Estoque_Atual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Estoque_Atual.ForeColor = System.Drawing.Color.Navy;
            this.TXB_Estoque_Atual.Location = new System.Drawing.Point(513, 142);
            this.TXB_Estoque_Atual.Name = "TXB_Estoque_Atual";
            this.TXB_Estoque_Atual.ReadOnly = true;
            this.TXB_Estoque_Atual.Size = new System.Drawing.Size(249, 29);
            this.TXB_Estoque_Atual.TabIndex = 77;
            // 
            // PX_Imagem
            // 
            this.PX_Imagem.BackgroundImage = global::CamadaApresentacao.Properties.Resources.DefaultImage;
            this.PX_Imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PX_Imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PX_Imagem.Location = new System.Drawing.Point(811, 20);
            this.PX_Imagem.Name = "PX_Imagem";
            this.PX_Imagem.Size = new System.Drawing.Size(163, 163);
            this.PX_Imagem.TabIndex = 6;
            this.PX_Imagem.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TXB_Prateleira_Dep);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TXB_Corredor_Dep);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXB_Prateleira_Expo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXB_Corredor_Expo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(33, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 269);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localização";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(228, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prateleira:";
            // 
            // TXB_Prateleira_Dep
            // 
            this.TXB_Prateleira_Dep.Enabled = false;
            this.TXB_Prateleira_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Prateleira_Dep.ForeColor = System.Drawing.Color.Black;
            this.TXB_Prateleira_Dep.Location = new System.Drawing.Point(232, 210);
            this.TXB_Prateleira_Dep.Name = "TXB_Prateleira_Dep";
            this.TXB_Prateleira_Dep.Size = new System.Drawing.Size(169, 29);
            this.TXB_Prateleira_Dep.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Corredor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(166, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "DEPOSITO";
            // 
            // TXB_Corredor_Dep
            // 
            this.TXB_Corredor_Dep.Enabled = false;
            this.TXB_Corredor_Dep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Corredor_Dep.ForeColor = System.Drawing.Color.Black;
            this.TXB_Corredor_Dep.Location = new System.Drawing.Point(24, 210);
            this.TXB_Corredor_Dep.Name = "TXB_Corredor_Dep";
            this.TXB_Corredor_Dep.Size = new System.Drawing.Size(169, 29);
            this.TXB_Corredor_Dep.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(228, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Prateleira:";
            // 
            // TXB_Prateleira_Expo
            // 
            this.TXB_Prateleira_Expo.Enabled = false;
            this.TXB_Prateleira_Expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Prateleira_Expo.ForeColor = System.Drawing.Color.Black;
            this.TXB_Prateleira_Expo.Location = new System.Drawing.Point(232, 86);
            this.TXB_Prateleira_Expo.Name = "TXB_Prateleira_Expo";
            this.TXB_Prateleira_Expo.Size = new System.Drawing.Size(169, 29);
            this.TXB_Prateleira_Expo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Corredor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(166, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "EXPOSIÇÃO";
            // 
            // TXB_Corredor_Expo
            // 
            this.TXB_Corredor_Expo.Enabled = false;
            this.TXB_Corredor_Expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Corredor_Expo.ForeColor = System.Drawing.Color.Black;
            this.TXB_Corredor_Expo.Location = new System.Drawing.Point(24, 86);
            this.TXB_Corredor_Expo.Name = "TXB_Corredor_Expo";
            this.TXB_Corredor_Expo.Size = new System.Drawing.Size(169, 29);
            this.TXB_Corredor_Expo.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.CB_Parcel_Cred_Loja);
            this.groupBox3.Controls.Add(this.CB_Parcel_Card_Cred);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.TXB_Valor_Cred_Loja);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.TXB_Valor_Card_Cred);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TXB_Valor_Dinheiro);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(529, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 244);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Financeiro";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(438, 202);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 20);
            this.label16.TabIndex = 88;
            this.label16.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(438, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 20);
            this.label15.TabIndex = 87;
            this.label15.Text = "X";
            // 
            // CB_Parcel_Cred_Loja
            // 
            this.CB_Parcel_Cred_Loja.FormattingEnabled = true;
            this.CB_Parcel_Cred_Loja.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CB_Parcel_Cred_Loja.Location = new System.Drawing.Point(326, 197);
            this.CB_Parcel_Cred_Loja.Name = "CB_Parcel_Cred_Loja";
            this.CB_Parcel_Cred_Loja.Size = new System.Drawing.Size(106, 28);
            this.CB_Parcel_Cred_Loja.TabIndex = 86;
            this.CB_Parcel_Cred_Loja.SelectedIndexChanged += new System.EventHandler(this.CB_Parcel_Cred_Loja_SelectedIndexChanged);
            // 
            // CB_Parcel_Card_Cred
            // 
            this.CB_Parcel_Card_Cred.FormattingEnabled = true;
            this.CB_Parcel_Card_Cred.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.CB_Parcel_Card_Cred.Location = new System.Drawing.Point(326, 120);
            this.CB_Parcel_Card_Cred.Name = "CB_Parcel_Card_Cred";
            this.CB_Parcel_Card_Cred.Size = new System.Drawing.Size(106, 28);
            this.CB_Parcel_Card_Cred.TabIndex = 85;
            this.CB_Parcel_Card_Cred.SelectedIndexChanged += new System.EventHandler(this.CB_Parcel_Card_Cred_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(322, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 20);
            this.label14.TabIndex = 84;
            this.label14.Text = "Parcelado em:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(322, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 83;
            this.label13.Text = "Parcelado em:";
            // 
            // TXB_Valor_Cred_Loja
            // 
            this.TXB_Valor_Cred_Loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Cred_Loja.ForeColor = System.Drawing.Color.Navy;
            this.TXB_Valor_Cred_Loja.Location = new System.Drawing.Point(41, 197);
            this.TXB_Valor_Cred_Loja.Name = "TXB_Valor_Cred_Loja";
            this.TXB_Valor_Cred_Loja.ReadOnly = true;
            this.TXB_Valor_Cred_Loja.Size = new System.Drawing.Size(246, 29);
            this.TXB_Valor_Cred_Loja.TabIndex = 82;
            this.TXB_Valor_Cred_Loja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(37, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 20);
            this.label12.TabIndex = 81;
            this.label12.Text = "Valor no Crediário da Loja";
            // 
            // TXB_Valor_Card_Cred
            // 
            this.TXB_Valor_Card_Cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Card_Cred.ForeColor = System.Drawing.Color.Navy;
            this.TXB_Valor_Card_Cred.Location = new System.Drawing.Point(41, 120);
            this.TXB_Valor_Card_Cred.Name = "TXB_Valor_Card_Cred";
            this.TXB_Valor_Card_Cred.ReadOnly = true;
            this.TXB_Valor_Card_Cred.Size = new System.Drawing.Size(246, 29);
            this.TXB_Valor_Card_Cred.TabIndex = 80;
            this.TXB_Valor_Card_Cred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(37, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 20);
            this.label11.TabIndex = 79;
            this.label11.Text = "Valor no Cartão de Crédito";
            // 
            // TXB_Valor_Dinheiro
            // 
            this.TXB_Valor_Dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Dinheiro.ForeColor = System.Drawing.Color.Navy;
            this.TXB_Valor_Dinheiro.Location = new System.Drawing.Point(122, 48);
            this.TXB_Valor_Dinheiro.Name = "TXB_Valor_Dinheiro";
            this.TXB_Valor_Dinheiro.ReadOnly = true;
            this.TXB_Valor_Dinheiro.Size = new System.Drawing.Size(246, 29);
            this.TXB_Valor_Dinheiro.TabIndex = 78;
            this.TXB_Valor_Dinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(118, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Valor em Dinheiro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 10);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(0, 552);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1050, 10);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 562);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(1040, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 562);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // DGV_Pesquisar_Preco_Codigo_Barras
            // 
            this.DGV_Pesquisar_Preco_Codigo_Barras.AllowUserToAddRows = false;
            this.DGV_Pesquisar_Preco_Codigo_Barras.AllowUserToDeleteRows = false;
            this.DGV_Pesquisar_Preco_Codigo_Barras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Pesquisar_Preco_Codigo_Barras.Location = new System.Drawing.Point(813, 12);
            this.DGV_Pesquisar_Preco_Codigo_Barras.Name = "DGV_Pesquisar_Preco_Codigo_Barras";
            this.DGV_Pesquisar_Preco_Codigo_Barras.ReadOnly = true;
            this.DGV_Pesquisar_Preco_Codigo_Barras.Size = new System.Drawing.Size(12, 16);
            this.DGV_Pesquisar_Preco_Codigo_Barras.TabIndex = 6;
            this.DGV_Pesquisar_Preco_Codigo_Barras.Visible = false;
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Limpar.Image = global::CamadaApresentacao.Properties.Resources.Limpr16x16;
            this.BTN_Limpar.Location = new System.Drawing.Point(627, 504);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(109, 29);
            this.BTN_Limpar.TabIndex = 21;
            this.BTN_Limpar.Text = "   LIMPAR";
            this.BTN_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Limpar.UseVisualStyleBackColor = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.ForeColor = System.Drawing.Color.Black;
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Saida_16x16;
            this.BTN_Sair.Location = new System.Drawing.Point(797, 504);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(109, 29);
            this.BTN_Sair.TabIndex = 22;
            this.BTN_Sair.Text = "   SAIR";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // FRM_Pesquisar_Preco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 562);
            this.Controls.Add(this.BTN_Sair);
            this.Controls.Add(this.BTN_Limpar);
            this.Controls.Add(this.DGV_Pesquisar_Preco_Codigo_Barras);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FRM_Pesquisar_Preco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Preço";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Pesquisar_Preco_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Pesquisar_Preco_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Pesquisar_Preco_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PX_Imagem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Pesquisar_Preco_Codigo_Barras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TXB_Descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXB_Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXB_Prateleira_Dep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXB_Corredor_Dep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXB_Prateleira_Expo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXB_Corredor_Expo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView DGV_Pesquisar_Preco_Codigo_Barras;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.PictureBox PX_Imagem;
        private System.Windows.Forms.TextBox TXB_Estoque_Atual;
        private System.Windows.Forms.TextBox TXB_Valor_Dinheiro;
        private System.Windows.Forms.TextBox TXB_Valor_Cred_Loja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXB_Valor_Card_Cred;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CB_Parcel_Card_Cred;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox CB_Parcel_Cred_Loja;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}