namespace CamadaApresentacao
{
    partial class FRM_Ver_Venda_Origem_Cheque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ver_Venda_Origem_Cheque));
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DGV_Formas_Pagamento = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TXB_Recebimento = new System.Windows.Forms.TextBox();
            this.TXB_TotalPagar = new System.Windows.Forms.MaskedTextBox();
            this.LB_Titulo_Total_Pagar = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtComprovante = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.ttMensagem = new System.Windows.Forms.ToolTip(this.components);
            this.txtNum_Comprovante = new System.Windows.Forms.TextBox();
            this.errorIcone = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dataListaDetalhes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXB_Juros_Card_Cred = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TXB_Juros_Cred_Loja = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TXB_Comissao_Paga = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TXB_Valor_Entrada = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome";
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Sair.ForeColor = System.Drawing.Color.Black;
            this.BTN_Sair.Image = global::CamadaApresentacao.Properties.Resources.Cancel22x22;
            this.BTN_Sair.Location = new System.Drawing.Point(874, 22);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(98, 30);
            this.BTN_Sair.TabIndex = 82;
            this.BTN_Sair.Text = "   SAIR";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTN_Sair.UseVisualStyleBackColor = true;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DGV_Formas_Pagamento);
            this.groupBox5.Location = new System.Drawing.Point(542, 433);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(430, 189);
            this.groupBox5.TabIndex = 81;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formas de Pagamento";
            // 
            // DGV_Formas_Pagamento
            // 
            this.DGV_Formas_Pagamento.AllowUserToAddRows = false;
            this.DGV_Formas_Pagamento.AllowUserToDeleteRows = false;
            this.DGV_Formas_Pagamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_Formas_Pagamento.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Formas_Pagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Formas_Pagamento.Location = new System.Drawing.Point(12, 21);
            this.DGV_Formas_Pagamento.Name = "DGV_Formas_Pagamento";
            this.DGV_Formas_Pagamento.ReadOnly = true;
            this.DGV_Formas_Pagamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Formas_Pagamento.Size = new System.Drawing.Size(412, 164);
            this.DGV_Formas_Pagamento.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(23, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nome";
            // 
            // TXB_Recebimento
            // 
            this.TXB_Recebimento.ForeColor = System.Drawing.Color.Black;
            this.TXB_Recebimento.Location = new System.Drawing.Point(49, 598);
            this.TXB_Recebimento.Name = "TXB_Recebimento";
            this.TXB_Recebimento.ReadOnly = true;
            this.TXB_Recebimento.Size = new System.Drawing.Size(154, 20);
            this.TXB_Recebimento.TabIndex = 72;
            // 
            // TXB_TotalPagar
            // 
            this.TXB_TotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_TotalPagar.ForeColor = System.Drawing.Color.Green;
            this.TXB_TotalPagar.Location = new System.Drawing.Point(742, 318);
            this.TXB_TotalPagar.Name = "TXB_TotalPagar";
            this.TXB_TotalPagar.ReadOnly = true;
            this.TXB_TotalPagar.Size = new System.Drawing.Size(230, 26);
            this.TXB_TotalPagar.TabIndex = 71;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            // 
            // LB_Titulo_Total_Pagar
            // 
            this.LB_Titulo_Total_Pagar.AutoSize = true;
            this.LB_Titulo_Total_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Titulo_Total_Pagar.ForeColor = System.Drawing.Color.Black;
            this.LB_Titulo_Total_Pagar.Location = new System.Drawing.Point(597, 324);
            this.LB_Titulo_Total_Pagar.Name = "LB_Titulo_Total_Pagar";
            this.LB_Titulo_Total_Pagar.Size = new System.Drawing.Size(139, 16);
            this.LB_Titulo_Total_Pagar.TabIndex = 70;
            this.LB_Titulo_Total_Pagar.Text = "Total em Produtos:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(46, 582);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 65;
            this.label10.Text = "Recebimento:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Navy;
            this.pictureBox4.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1050, 24);
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Navy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 673);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1048, 17);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Navy;
            this.pictureBox3.Location = new System.Drawing.Point(1041, -5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(8, 701);
            this.pictureBox3.TabIndex = 92;
            this.pictureBox3.TabStop = false;
            // 
            // txtComprovante
            // 
            this.txtComprovante.ForeColor = System.Drawing.Color.Black;
            this.txtComprovante.Location = new System.Drawing.Point(49, 551);
            this.txtComprovante.Name = "txtComprovante";
            this.txtComprovante.ReadOnly = true;
            this.txtComprovante.Size = new System.Drawing.Size(138, 20);
            this.txtComprovante.TabIndex = 64;
            // 
            // dtData
            // 
            this.dtData.Enabled = false;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(23, 38);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(108, 20);
            this.dtData.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tipo de Comprovante";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.ForeColor = System.Drawing.Color.Black;
            this.txtFuncionario.Location = new System.Drawing.Point(26, 45);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.Size = new System.Drawing.Size(350, 20);
            this.txtFuncionario.TabIndex = 63;
            // 
            // ttMensagem
            // 
            this.ttMensagem.IsBalloon = true;
            // 
            // txtNum_Comprovante
            // 
            this.txtNum_Comprovante.ForeColor = System.Drawing.Color.Black;
            this.txtNum_Comprovante.Location = new System.Drawing.Point(248, 551);
            this.txtNum_Comprovante.Name = "txtNum_Comprovante";
            this.txtNum_Comprovante.ReadOnly = true;
            this.txtNum_Comprovante.Size = new System.Drawing.Size(151, 20);
            this.txtNum_Comprovante.TabIndex = 25;
            // 
            // errorIcone
            // 
            this.errorIcone.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(245, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nº Comprovante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(181, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código da Venda:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(184, 38);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(158, 20);
            this.txtId.TabIndex = 3;
            // 
            // dataListaDetalhes
            // 
            this.dataListaDetalhes.AllowUserToAddRows = false;
            this.dataListaDetalhes.AllowUserToDeleteRows = false;
            this.dataListaDetalhes.BackgroundColor = System.Drawing.Color.White;
            this.dataListaDetalhes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaDetalhes.Location = new System.Drawing.Point(23, 64);
            this.dataListaDetalhes.Name = "dataListaDetalhes";
            this.dataListaDetalhes.ReadOnly = true;
            this.dataListaDetalhes.Size = new System.Drawing.Size(949, 248);
            this.dataListaDetalhes.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 66);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(26, 38);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(350, 20);
            this.txtCliente.TabIndex = 63;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFuncionario);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(23, 424);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(404, 86);
            this.groupBox4.TabIndex = 74;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Funcionário";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Navy;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 701);
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TXB_Juros_Card_Cred);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.TXB_Juros_Cred_Loja);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.TXB_Comissao_Paga);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TXB_Valor_Entrada);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BTN_Sair);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.TXB_Recebimento);
            this.groupBox1.Controls.Add(this.TXB_TotalPagar);
            this.groupBox1.Controls.Add(this.LB_Titulo_Total_Pagar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtComprovante);
            this.groupBox1.Controls.Add(this.dtData);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNum_Comprovante);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.dataListaDetalhes);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(996, 628);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes da Venda";
            // 
            // TXB_Juros_Card_Cred
            // 
            this.TXB_Juros_Card_Cred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Juros_Card_Cred.ForeColor = System.Drawing.Color.Green;
            this.TXB_Juros_Card_Cred.Location = new System.Drawing.Point(785, 405);
            this.TXB_Juros_Card_Cred.Name = "TXB_Juros_Card_Cred";
            this.TXB_Juros_Card_Cred.ReadOnly = true;
            this.TXB_Juros_Card_Cred.Size = new System.Drawing.Size(187, 22);
            this.TXB_Juros_Card_Cred.TabIndex = 95;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(782, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(196, 15);
            this.label14.TabIndex = 94;
            this.label14.Text = "Juros de Parcel. - Card. Cred.";
            // 
            // TXB_Juros_Cred_Loja
            // 
            this.TXB_Juros_Cred_Loja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Juros_Cred_Loja.ForeColor = System.Drawing.Color.Green;
            this.TXB_Juros_Cred_Loja.Location = new System.Drawing.Point(589, 405);
            this.TXB_Juros_Cred_Loja.Name = "TXB_Juros_Cred_Loja";
            this.TXB_Juros_Cred_Loja.ReadOnly = true;
            this.TXB_Juros_Cred_Loja.Size = new System.Drawing.Size(187, 22);
            this.TXB_Juros_Cred_Loja.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(586, 389);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 15);
            this.label13.TabIndex = 92;
            this.label13.Text = "Juros de Parcel. - Cred. Loja";
            // 
            // TXB_Comissao_Paga
            // 
            this.TXB_Comissao_Paga.ForeColor = System.Drawing.Color.Black;
            this.TXB_Comissao_Paga.Location = new System.Drawing.Point(248, 598);
            this.TXB_Comissao_Paga.Name = "TXB_Comissao_Paga";
            this.TXB_Comissao_Paga.Size = new System.Drawing.Size(151, 20);
            this.TXB_Comissao_Paga.TabIndex = 91;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(245, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 90;
            this.label12.Text = "Comissão Paga:";
            // 
            // TXB_Valor_Entrada
            // 
            this.TXB_Valor_Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXB_Valor_Entrada.ForeColor = System.Drawing.Color.Black;
            this.TXB_Valor_Entrada.Location = new System.Drawing.Point(742, 354);
            this.TXB_Valor_Entrada.Name = "TXB_Valor_Entrada";
            this.TXB_Valor_Entrada.Size = new System.Drawing.Size(230, 26);
            this.TXB_Valor_Entrada.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(583, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 16);
            this.label11.TabIndex = 88;
            this.label11.Text = "Entrada em Dinheiro:";
            // 
            // FRM_Ver_Venda_Origem_Cheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CamadaApresentacao.Properties.Resources.Aparencia_Form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 690);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FRM_Ver_Venda_Origem_Cheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Venda de Origem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Ver_Venda_Origem_Cheque_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Ver_Venda_Origem_Cheque_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRM_Ver_Venda_Origem_Cheque_KeyUp);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Formas_Pagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaDetalhes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.GroupBox groupBox5;
        public System.Windows.Forms.DataGridView DGV_Formas_Pagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXB_Recebimento;
        public System.Windows.Forms.MaskedTextBox TXB_TotalPagar;
        private System.Windows.Forms.Label LB_Titulo_Total_Pagar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtComprovante;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.ToolTip ttMensagem;
        private System.Windows.Forms.TextBox txtNum_Comprovante;
        private System.Windows.Forms.ErrorProvider errorIcone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.DataGridView dataListaDetalhes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TXB_Comissao_Paga;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXB_Valor_Entrada;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXB_Juros_Card_Cred;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXB_Juros_Cred_Loja;
        private System.Windows.Forms.Label label13;
    }
}