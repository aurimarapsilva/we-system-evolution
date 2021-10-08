namespace CamadaApresentacao
{
    partial class FRM_Ordem_Servico_Em_Branco
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Ordem_Servico_Em_Branco));
            this.rPTCompVendaCabecalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Ordem_Servico = new CamadaApresentacao.DS_Ordem_Servico();
            this.rPTOrdemServicoClausulasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTOrdemServicoEmBrancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Comp_Venda_CabecalhoTableAdapter = new CamadaApresentacao.DS_Ordem_ServicoTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter();
            this.rPT_Ordem_Servico_ClausulasTableAdapter = new CamadaApresentacao.DS_Ordem_ServicoTableAdapters.RPT_Ordem_Servico_ClausulasTableAdapter();
            this.rPT_Ordem_Servico_Em_BrancoTableAdapter = new CamadaApresentacao.DS_Ordem_ServicoTableAdapters.RPT_Ordem_Servico_Em_BrancoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaCabecalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Ordem_Servico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTOrdemServicoClausulasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTOrdemServicoEmBrancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCompVendaCabecalhoBindingSource
            // 
            this.rPTCompVendaCabecalhoBindingSource.DataMember = "RPT_Comp_Venda_Cabecalho";
            this.rPTCompVendaCabecalhoBindingSource.DataSource = this.dS_Ordem_Servico;
            // 
            // dS_Ordem_Servico
            // 
            this.dS_Ordem_Servico.DataSetName = "DS_Ordem_Servico";
            this.dS_Ordem_Servico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTOrdemServicoClausulasBindingSource
            // 
            this.rPTOrdemServicoClausulasBindingSource.DataMember = "RPT_Ordem_Servico_Clausulas";
            this.rPTOrdemServicoClausulasBindingSource.DataSource = this.dS_Ordem_Servico;
            // 
            // rPTOrdemServicoEmBrancoBindingSource
            // 
            this.rPTOrdemServicoEmBrancoBindingSource.DataMember = "RPT_Ordem_Servico_Em_Branco";
            this.rPTOrdemServicoEmBrancoBindingSource.DataSource = this.dS_Ordem_Servico;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCompVendaCabecalhoBindingSource;
            reportDataSource2.Name = "Clausulas";
            reportDataSource2.Value = this.rPTOrdemServicoClausulasBindingSource;
            reportDataSource3.Name = "Corpo_os";
            reportDataSource3.Value = this.rPTOrdemServicoEmBrancoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Ordem_Servico_Em_Branco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Comp_Venda_CabecalhoTableAdapter
            // 
            this.rPT_Comp_Venda_CabecalhoTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Ordem_Servico_ClausulasTableAdapter
            // 
            this.rPT_Ordem_Servico_ClausulasTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Ordem_Servico_Em_BrancoTableAdapter
            // 
            this.rPT_Ordem_Servico_Em_BrancoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Ordem_Servico_Em_Branco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Ordem_Servico_Em_Branco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Serviço";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Ordem_Servico_Em_Branco_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Ordem_Servico_Em_Branco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaCabecalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Ordem_Servico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTOrdemServicoClausulasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTOrdemServicoEmBrancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Ordem_Servico dS_Ordem_Servico;
        private System.Windows.Forms.BindingSource rPTCompVendaCabecalhoBindingSource;
        private DS_Ordem_ServicoTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter rPT_Comp_Venda_CabecalhoTableAdapter;
        private System.Windows.Forms.BindingSource rPTOrdemServicoClausulasBindingSource;
        private DS_Ordem_ServicoTableAdapters.RPT_Ordem_Servico_ClausulasTableAdapter rPT_Ordem_Servico_ClausulasTableAdapter;
        private System.Windows.Forms.BindingSource rPTOrdemServicoEmBrancoBindingSource;
        private DS_Ordem_ServicoTableAdapters.RPT_Ordem_Servico_Em_BrancoTableAdapter rPT_Ordem_Servico_Em_BrancoTableAdapter;
    }
}