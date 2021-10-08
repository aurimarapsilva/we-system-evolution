namespace CamadaApresentacao
{
    partial class FRM_Contas_Pagar_Vencidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Contas_Pagar_Vencidas));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Contas_Pagar = new CamadaApresentacao.DS_Contas_Pagar();
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_Contas_PagarTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPTContasPagarVencidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Contas_Pagar_VencidasTableAdapter = new CamadaApresentacao.DS_Contas_PagarTableAdapters.RPT_Contas_Pagar_VencidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Pagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasPagarVencidasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 17;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTContasPagarVencidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Contas_Pagar_Vencidas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1104, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Contas_Pagar
            // 
            this.dS_Contas_Pagar.DataSetName = "DS_Contas_Pagar";
            this.dS_Contas_Pagar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Contas_Pagar;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPTContasPagarVencidasBindingSource
            // 
            this.rPTContasPagarVencidasBindingSource.DataMember = "RPT_Contas_Pagar_Vencidas";
            this.rPTContasPagarVencidasBindingSource.DataSource = this.dS_Contas_Pagar;
            // 
            // rPT_Contas_Pagar_VencidasTableAdapter
            // 
            this.rPT_Contas_Pagar_VencidasTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Contas_Pagar_Vencidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 612);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Contas_Pagar_Vencidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar - Vencidas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Contas_Pagar_Vencidas_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Contas_Pagar_Vencidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Contas_Pagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTContasPagarVencidasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Contas_Pagar dS_Contas_Pagar;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_Contas_PagarTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTContasPagarVencidasBindingSource;
        private DS_Contas_PagarTableAdapters.RPT_Contas_Pagar_VencidasTableAdapter rPT_Contas_Pagar_VencidasTableAdapter;
    }
}