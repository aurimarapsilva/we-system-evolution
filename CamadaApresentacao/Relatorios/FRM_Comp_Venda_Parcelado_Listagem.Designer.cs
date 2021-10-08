namespace CamadaApresentacao
{
    partial class FRM_Comp_Venda_Parcelado_Listagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Comp_Venda_Parcelado_Listagem));
            this.rPTCompVendaCabecalhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Comprovante_Venda = new CamadaApresentacao.DS_Comprovante_Venda();
            this.rPTCompVendaDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTCompVendaParcelamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Comp_Venda_CabecalhoTableAdapter = new CamadaApresentacao.DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter();
            this.rPT_Comp_Venda_DadosTableAdapter = new CamadaApresentacao.DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_DadosTableAdapter();
            this.rPT_Comp_Venda_ParcelamentoTableAdapter = new CamadaApresentacao.DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_ParcelamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaCabecalhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Comprovante_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaParcelamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCompVendaCabecalhoBindingSource
            // 
            this.rPTCompVendaCabecalhoBindingSource.DataMember = "RPT_Comp_Venda_Cabecalho";
            this.rPTCompVendaCabecalhoBindingSource.DataSource = this.dS_Comprovante_Venda;
            // 
            // dS_Comprovante_Venda
            // 
            this.dS_Comprovante_Venda.DataSetName = "DS_Comprovante_Venda";
            this.dS_Comprovante_Venda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTCompVendaDadosBindingSource
            // 
            this.rPTCompVendaDadosBindingSource.DataMember = "RPT_Comp_Venda_Dados";
            this.rPTCompVendaDadosBindingSource.DataSource = this.dS_Comprovante_Venda;
            // 
            // rPTCompVendaParcelamentoBindingSource
            // 
            this.rPTCompVendaParcelamentoBindingSource.DataMember = "RPT_Comp_Venda_Parcelamento";
            this.rPTCompVendaParcelamentoBindingSource.DataSource = this.dS_Comprovante_Venda;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCompVendaCabecalhoBindingSource;
            reportDataSource2.Name = "Dados_da_Venda";
            reportDataSource2.Value = this.rPTCompVendaDadosBindingSource;
            reportDataSource3.Name = "Parcelamento";
            reportDataSource3.Value = this.rPTCompVendaParcelamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Comp_Venda_Parcelado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Comp_Venda_CabecalhoTableAdapter
            // 
            this.rPT_Comp_Venda_CabecalhoTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Comp_Venda_DadosTableAdapter
            // 
            this.rPT_Comp_Venda_DadosTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Comp_Venda_ParcelamentoTableAdapter
            // 
            this.rPT_Comp_Venda_ParcelamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Comp_Venda_Parcelado_Listagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Comp_Venda_Parcelado_Listagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprovante de Venda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Comp_Venda_Parcelado_Listagem_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Comp_Venda_Parcelado_Listagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaCabecalhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Comprovante_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCompVendaParcelamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Comprovante_Venda dS_Comprovante_Venda;
        private System.Windows.Forms.BindingSource rPTCompVendaCabecalhoBindingSource;
        private DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_CabecalhoTableAdapter rPT_Comp_Venda_CabecalhoTableAdapter;
        private System.Windows.Forms.BindingSource rPTCompVendaDadosBindingSource;
        private System.Windows.Forms.BindingSource rPTCompVendaParcelamentoBindingSource;
        private DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_DadosTableAdapter rPT_Comp_Venda_DadosTableAdapter;
        private DS_Comprovante_VendaTableAdapters.RPT_Comp_Venda_ParcelamentoTableAdapter rPT_Comp_Venda_ParcelamentoTableAdapter;
    }
}