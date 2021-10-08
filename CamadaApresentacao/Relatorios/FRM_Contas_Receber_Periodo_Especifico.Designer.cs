namespace CamadaApresentacao
{
    partial class FRM_Contas_Receber_Periodo_Especifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Contas_Receber_Periodo_Especifico));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Contas_Receber = new CamadaApresentacao.DS_Contas_Receber();
            this.rPTContasReceberPeriodoEspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_Contas_ReceberTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Contas_Receber_Periodo_EspecificoTableAdapter = new CamadaApresentacao.DS_Contas_ReceberTableAdapters.RPT_Contas_Receber_Periodo_EspecificoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasReceberPeriodoEspecificoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Contas_Receber;
            // 
            // dS_Contas_Receber
            // 
            this.dS_Contas_Receber.DataSetName = "DS_Contas_Receber";
            this.dS_Contas_Receber.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTContasReceberPeriodoEspecificoBindingSource
            // 
            this.rPTContasReceberPeriodoEspecificoBindingSource.DataMember = "RPT_Contas_Receber_Periodo_Especifico";
            this.rPTContasReceberPeriodoEspecificoBindingSource.DataSource = this.dS_Contas_Receber;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTContasReceberPeriodoEspecificoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Contas_Receber_Periodo_Especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1104, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Contas_Receber_Periodo_EspecificoTableAdapter
            // 
            this.rPT_Contas_Receber_Periodo_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Contas_Receber_Periodo_Especifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 612);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Contas_Receber_Periodo_Especifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber - Peróodo Específico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Contas_Receber_Periodo_Especifico_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Contas_Receber_Periodo_Especifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasReceberPeriodoEspecificoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Contas_Receber dS_Contas_Receber;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_Contas_ReceberTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTContasReceberPeriodoEspecificoBindingSource;
        private DS_Contas_ReceberTableAdapters.RPT_Contas_Receber_Periodo_EspecificoTableAdapter rPT_Contas_Receber_Periodo_EspecificoTableAdapter;
    }
}