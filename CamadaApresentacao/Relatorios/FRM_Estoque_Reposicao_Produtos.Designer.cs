namespace CamadaApresentacao
{
    partial class FRM_Estoque_Reposicao_Produtos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Estoque_Reposicao_Produtos));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Estoque = new CamadaApresentacao.DS_Estoque();
            this.rPTEstoqueReposicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_EstoqueTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Estoque_ReposicaoTableAdapter = new CamadaApresentacao.DS_EstoqueTableAdapters.RPT_Estoque_ReposicaoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTEstoqueReposicaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Estoque;
            // 
            // dS_Estoque
            // 
            this.dS_Estoque.DataSetName = "DS_Estoque";
            this.dS_Estoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTEstoqueReposicaoBindingSource
            // 
            this.rPTEstoqueReposicaoBindingSource.DataMember = "RPT_Estoque_Reposicao";
            this.rPTEstoqueReposicaoBindingSource.DataSource = this.dS_Estoque;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTEstoqueReposicaoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Estoque_Reposicao_Produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1104, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Estoque_ReposicaoTableAdapter
            // 
            this.rPT_Estoque_ReposicaoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Estoque_Reposicao_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 612);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Estoque_Reposicao_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reposição de Produtos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Estoque_Reposicao_Produtos_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Estoque_Reposicao_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTEstoqueReposicaoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Estoque dS_Estoque;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_EstoqueTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTEstoqueReposicaoBindingSource;
        private DS_EstoqueTableAdapters.RPT_Estoque_ReposicaoTableAdapter rPT_Estoque_ReposicaoTableAdapter;
    }
}