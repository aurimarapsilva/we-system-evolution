namespace CamadaApresentacao
{
    partial class FRM_Clientes_LIstagem_Geral_Resumida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Clientes_LIstagem_Geral_Resumida));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes = new CamadaApresentacao.DS_Clientes();
            this.rPTClientesListagemResumoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Clientes_Listagem_ResumoTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Clientes_Listagem_ResumoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClientesListagemResumoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Clientes;
            // 
            // dS_Clientes
            // 
            this.dS_Clientes.DataSetName = "DS_Clientes";
            this.dS_Clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTClientesListagemResumoBindingSource
            // 
            this.rPTClientesListagemResumoBindingSource.DataMember = "RPT_Clientes_Listagem_Resumo";
            this.rPTClientesListagemResumoBindingSource.DataSource = this.dS_Clientes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cliente_Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Clientes_Dados";
            reportDataSource2.Value = this.rPTClientesListagemResumoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Clientes_Listagem_Geral_Resumida.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Clientes_Listagem_ResumoTableAdapter
            // 
            this.rPT_Clientes_Listagem_ResumoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Clientes_LIstagem_Geral_Resumida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Clientes_LIstagem_Geral_Resumida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem Geral de Clientes - Resumido";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Clientes_LIstagem_Geral_Resumida_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Clientes_LIstagem_Geral_Resumida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClientesListagemResumoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Clientes dS_Clientes;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_ClientesTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTClientesListagemResumoBindingSource;
        private DS_ClientesTableAdapters.RPT_Clientes_Listagem_ResumoTableAdapter rPT_Clientes_Listagem_ResumoTableAdapter;
    }
}