namespace CamadaApresentacao
{
    partial class FRM_Cartao_Debito_Periodo_Especifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cartao_Debito_Periodo_Especifico));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Cartao_Debito = new CamadaApresentacao.DS_Cartao_Debito();
            this.rPTCartaoDebitoPeriodoEspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_Cartao_DebitoTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Cartao_Debito_Periodo_EspecificoTableAdapter = new CamadaApresentacao.DS_Cartao_DebitoTableAdapters.RPT_Cartao_Debito_Periodo_EspecificoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Cartao_Debito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCartaoDebitoPeriodoEspecificoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Cartao_Debito;
            // 
            // dS_Cartao_Debito
            // 
            this.dS_Cartao_Debito.DataSetName = "DS_Cartao_Debito";
            this.dS_Cartao_Debito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTCartaoDebitoPeriodoEspecificoBindingSource
            // 
            this.rPTCartaoDebitoPeriodoEspecificoBindingSource.DataMember = "RPT_Cartao_Debito_Periodo_Especifico";
            this.rPTCartaoDebitoPeriodoEspecificoBindingSource.DataSource = this.dS_Cartao_Debito;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTCartaoDebitoPeriodoEspecificoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Cartao_Debito_Periodo_Especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Cartao_Debito_Periodo_EspecificoTableAdapter
            // 
            this.rPT_Cartao_Debito_Periodo_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Cartao_Debito_Periodo_Especifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Cartao_Debito_Periodo_Especifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cartão de Debito - Período Específico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Cartao_Debito_Periodo_Especifico_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Cartao_Debito_Periodo_Especifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Cartao_Debito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCartaoDebitoPeriodoEspecificoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Cartao_Debito dS_Cartao_Debito;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_Cartao_DebitoTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTCartaoDebitoPeriodoEspecificoBindingSource;
        private DS_Cartao_DebitoTableAdapters.RPT_Cartao_Debito_Periodo_EspecificoTableAdapter rPT_Cartao_Debito_Periodo_EspecificoTableAdapter;
    }
}