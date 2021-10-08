namespace CamadaApresentacao
{
    partial class FRM_Cliente_Especifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Cliente_Especifico));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Clientes = new CamadaApresentacao.DS_Clientes();
            this.rPTClienteEspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTClienteDividaAtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPT_Cliente_EspecificoTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Cliente_EspecificoTableAdapter();
            this.rPT_Cliente_Divida_AtualTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Cliente_Divida_AtualTableAdapter();
            this.rPTClientesDividaAtrasoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Clientes_Divida_AtrasoTableAdapter = new CamadaApresentacao.DS_ClientesTableAdapters.RPT_Clientes_Divida_AtrasoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClienteEspecificoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClienteDividaAtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClientesDividaAtrasoBindingSource)).BeginInit();
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
            // rPTClienteEspecificoBindingSource
            // 
            this.rPTClienteEspecificoBindingSource.DataMember = "RPT_Cliente_Especifico";
            this.rPTClienteEspecificoBindingSource.DataSource = this.dS_Clientes;
            // 
            // rPTClienteDividaAtualBindingSource
            // 
            this.rPTClienteDividaAtualBindingSource.DataMember = "RPT_Cliente_Divida_Atual";
            this.rPTClienteDividaAtualBindingSource.DataSource = this.dS_Clientes;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTClienteEspecificoBindingSource;
            reportDataSource3.Name = "Financeiro_Divida";
            reportDataSource3.Value = this.rPTClienteDividaAtualBindingSource;
            reportDataSource4.Name = "Divida_Atraso";
            reportDataSource4.Value = this.rPTClientesDividaAtrasoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Cliente_Especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Cliente_EspecificoTableAdapter
            // 
            this.rPT_Cliente_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // rPT_Cliente_Divida_AtualTableAdapter
            // 
            this.rPT_Cliente_Divida_AtualTableAdapter.ClearBeforeFill = true;
            // 
            // rPTClientesDividaAtrasoBindingSource
            // 
            this.rPTClientesDividaAtrasoBindingSource.DataMember = "RPT_Clientes_Divida_Atraso";
            this.rPTClientesDividaAtrasoBindingSource.DataSource = this.dS_Clientes;
            // 
            // rPT_Clientes_Divida_AtrasoTableAdapter
            // 
            this.rPT_Clientes_Divida_AtrasoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Cliente_Especifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Cliente_Especifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Específico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Cliente_Especifico_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Cliente_Especifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClienteEspecificoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClienteDividaAtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTClientesDividaAtrasoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Clientes dS_Clientes;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_ClientesTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTClienteEspecificoBindingSource;
        private DS_ClientesTableAdapters.RPT_Cliente_EspecificoTableAdapter rPT_Cliente_EspecificoTableAdapter;
        private System.Windows.Forms.BindingSource rPTClienteDividaAtualBindingSource;
        private DS_ClientesTableAdapters.RPT_Cliente_Divida_AtualTableAdapter rPT_Cliente_Divida_AtualTableAdapter;
        private System.Windows.Forms.BindingSource rPTClientesDividaAtrasoBindingSource;
        private DS_ClientesTableAdapters.RPT_Clientes_Divida_AtrasoTableAdapter rPT_Clientes_Divida_AtrasoTableAdapter;
    }
}