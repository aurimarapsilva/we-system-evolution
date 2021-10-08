namespace CamadaApresentacao
{
    partial class FRM_Orcamentos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Orcamentos));
            this.RPT_Comp_Venda_CabecalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Orcamento = new CamadaApresentacao.DS_Orcamento();
            this.RPT_OrcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RPT_Orcamento_Formas_PgtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPT_Comp_Venda_CabecalhoTableAdapter = new CamadaApresentacao.DS_OrcamentoTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter();
            this.RPT_OrcamentoTableAdapter = new CamadaApresentacao.DS_OrcamentoTableAdapters.RPT_OrcamentoTableAdapter();
            this.RPT_Orcamento_Formas_PgtoTableAdapter = new CamadaApresentacao.DS_OrcamentoTableAdapters.RPT_Orcamento_Formas_PgtoTableAdapter();
            this.spmostrarconfigorcamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spmostrar_config_orcamentoTableAdapter = new CamadaApresentacao.DS_OrcamentoTableAdapters.spmostrar_config_orcamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Comp_Venda_CabecalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Orcamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_OrcamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Orcamento_Formas_PgtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarconfigorcamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_Comp_Venda_CabecalhoBindingSource
            // 
            this.RPT_Comp_Venda_CabecalhoBindingSource.DataMember = "RPT_Comp_Venda_Cabecalho";
            this.RPT_Comp_Venda_CabecalhoBindingSource.DataSource = this.DS_Orcamento;
            // 
            // DS_Orcamento
            // 
            this.DS_Orcamento.DataSetName = "DS_Orcamento";
            this.DS_Orcamento.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RPT_OrcamentoBindingSource
            // 
            this.RPT_OrcamentoBindingSource.DataMember = "RPT_Orcamento";
            this.RPT_OrcamentoBindingSource.DataSource = this.DS_Orcamento;
            // 
            // RPT_Orcamento_Formas_PgtoBindingSource
            // 
            this.RPT_Orcamento_Formas_PgtoBindingSource.DataMember = "RPT_Orcamento_Formas_Pgto";
            this.RPT_Orcamento_Formas_PgtoBindingSource.DataSource = this.DS_Orcamento;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.RPT_Comp_Venda_CabecalhoBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.RPT_OrcamentoBindingSource;
            reportDataSource3.Name = "Formas_Pgto";
            reportDataSource3.Value = this.RPT_Orcamento_Formas_PgtoBindingSource;
            reportDataSource4.Name = "Clausulas";
            reportDataSource4.Value = this.spmostrarconfigorcamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Orcamento.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPT_Comp_Venda_CabecalhoTableAdapter
            // 
            this.RPT_Comp_Venda_CabecalhoTableAdapter.ClearBeforeFill = true;
            // 
            // RPT_OrcamentoTableAdapter
            // 
            this.RPT_OrcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // RPT_Orcamento_Formas_PgtoTableAdapter
            // 
            this.RPT_Orcamento_Formas_PgtoTableAdapter.ClearBeforeFill = true;
            // 
            // spmostrarconfigorcamentoBindingSource
            // 
            this.spmostrarconfigorcamentoBindingSource.DataMember = "spmostrar_config_orcamento";
            this.spmostrarconfigorcamentoBindingSource.DataSource = this.DS_Orcamento;
            // 
            // spmostrar_config_orcamentoTableAdapter
            // 
            this.spmostrar_config_orcamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Orcamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Orcamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orçamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Orcamentos_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Orcamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Comp_Venda_CabecalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Orcamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_OrcamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_Orcamento_Formas_PgtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spmostrarconfigorcamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_Comp_Venda_CabecalhoBindingSource;
        private DS_Orcamento DS_Orcamento;
        private System.Windows.Forms.BindingSource RPT_OrcamentoBindingSource;
        private System.Windows.Forms.BindingSource RPT_Orcamento_Formas_PgtoBindingSource;
        private DS_OrcamentoTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter RPT_Comp_Venda_CabecalhoTableAdapter;
        private DS_OrcamentoTableAdapters.RPT_OrcamentoTableAdapter RPT_OrcamentoTableAdapter;
        private DS_OrcamentoTableAdapters.RPT_Orcamento_Formas_PgtoTableAdapter RPT_Orcamento_Formas_PgtoTableAdapter;
        private System.Windows.Forms.BindingSource spmostrarconfigorcamentoBindingSource;
        private DS_OrcamentoTableAdapters.spmostrar_config_orcamentoTableAdapter spmostrar_config_orcamentoTableAdapter;
    }
}