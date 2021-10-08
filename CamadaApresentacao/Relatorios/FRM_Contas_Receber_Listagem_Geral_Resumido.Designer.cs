namespace CamadaApresentacao
{
    partial class FRM_Contas_Receber_Listagem_Geral_Resumido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Contas_Receber_Listagem_Geral_Resumido));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Contas_Receber = new CamadaApresentacao.DS_Contas_Receber();
            this.rPTContasReceberListagemGeralResumidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_Contas_ReceberTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter = new CamadaApresentacao.DS_Contas_ReceberTableAdapters.RPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Receber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasReceberListagemGeralResumidoBindingSource)).BeginInit();
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
            // rPTContasReceberListagemGeralResumidoBindingSource
            // 
            this.rPTContasReceberListagemGeralResumidoBindingSource.DataMember = "RPT_Contas_Receber_Listagem_Geral_Resumido";
            this.rPTContasReceberListagemGeralResumidoBindingSource.DataSource = this.dS_Contas_Receber;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTContasReceberListagemGeralResumidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Contas_Receber_Listagem_Geral_Resumido.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter
            // 
            this.rPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Contas_Receber_Listagem_Geral_Resumido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Contas_Receber_Listagem_Geral_Resumido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber - Listagem Geral - Resumido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Contas_Receber_Listagem_Geral_Resumido_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Contas_Receber_Listagem_Geral_Resumido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Receber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasReceberListagemGeralResumidoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Contas_Receber dS_Contas_Receber;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_Contas_ReceberTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTContasReceberListagemGeralResumidoBindingSource;
        private DS_Contas_ReceberTableAdapters.RPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter rPT_Contas_Receber_Listagem_Geral_ResumidoTableAdapter;
    }
}