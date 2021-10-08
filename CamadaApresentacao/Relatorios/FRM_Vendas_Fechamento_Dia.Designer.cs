namespace CamadaApresentacao
{
    partial class FRM_Vendas_Fechamento_Dia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Vendas_Fechamento_Dia));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Vendas = new CamadaApresentacao.DS_Vendas();
            this.rPTresultadofechamentodiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTTotaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_VendasTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_resultado_fechamento_diaTableAdapter = new CamadaApresentacao.DS_VendasTableAdapters.RPT_resultado_fechamento_diaTableAdapter();
            this.rPT_TotaisTableAdapter = new CamadaApresentacao.DS_VendasTableAdapters.RPT_TotaisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Vendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTresultadofechamentodiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTotaisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Vendas;
            // 
            // dS_Vendas
            // 
            this.dS_Vendas.DataSetName = "DS_Vendas";
            this.dS_Vendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTresultadofechamentodiaBindingSource
            // 
            this.rPTresultadofechamentodiaBindingSource.DataMember = "RPT_resultado_fechamento_dia";
            this.rPTresultadofechamentodiaBindingSource.DataSource = this.dS_Vendas;
            // 
            // rPTTotaisBindingSource
            // 
            this.rPTTotaisBindingSource.DataMember = "RPT_Totais";
            this.rPTTotaisBindingSource.DataSource = this.dS_Vendas;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTresultadofechamentodiaBindingSource;
            reportDataSource3.Name = "Totais";
            reportDataSource3.Value = this.rPTTotaisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Vendas_Fechamento_Dia.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_resultado_fechamento_diaTableAdapter
            // 
            this.rPT_resultado_fechamento_diaTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_TotaisTableAdapter
            // 
            this.rPT_TotaisTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Vendas_Fechamento_Dia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Vendas_Fechamento_Dia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas -Fechamento do Dia";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Vendas_Fechamento_Dia_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Vendas_Fechamento_Dia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Vendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTresultadofechamentodiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTTotaisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Vendas dS_Vendas;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_VendasTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTresultadofechamentodiaBindingSource;
        private System.Windows.Forms.BindingSource rPTTotaisBindingSource;
        private DS_VendasTableAdapters.RPT_resultado_fechamento_diaTableAdapter rPT_resultado_fechamento_diaTableAdapter;
        private DS_VendasTableAdapters.RPT_TotaisTableAdapter rPT_TotaisTableAdapter;
    }
}