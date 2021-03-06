namespace CamadaApresentacao
{
    partial class FRM_Estoque_Dez_Mais_Vendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Estoque_Dez_Mais_Vendidos));
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Estoque = new CamadaApresentacao.DS_Estoque();
            this.rPTEstoqueDezMaisVendidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_EstoqueTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.dSEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Estoque_Dez_Mais_VendidosTableAdapter = new CamadaApresentacao.DS_EstoqueTableAdapters.RPT_Estoque_Dez_Mais_VendidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Estoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTEstoqueDezMaisVendidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Estoque;
            // 
            // dS_Estoque
            // 
            this.dS_Estoque.DataSetName = "DS_Estoque";
            this.dS_Estoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTEstoqueDezMaisVendidosBindingSource
            // 
            this.rPTEstoqueDezMaisVendidosBindingSource.DataMember = "RPT_Estoque_Dez_Mais_Vendidos";
            this.rPTEstoqueDezMaisVendidosBindingSource.DataSource = this.dS_Estoque;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTEstoqueDezMaisVendidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Estoque_Dez_Mais_Vendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1104, 612);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // dSEstoqueBindingSource
            // 
            this.dSEstoqueBindingSource.DataSource = this.dS_Estoque;
            this.dSEstoqueBindingSource.Position = 0;
            // 
            // rPT_Estoque_Dez_Mais_VendidosTableAdapter
            // 
            this.rPT_Estoque_Dez_Mais_VendidosTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Estoque_Dez_Mais_Vendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 612);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Estoque_Dez_Mais_Vendidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dez Produtos Mais Vendidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Estoque_Dez_Mais_Vendidos_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Estoque_Dez_Mais_Vendidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Estoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTEstoqueDezMaisVendidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Estoque dS_Estoque;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_EstoqueTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource dSEstoqueBindingSource;
        private System.Windows.Forms.BindingSource rPTEstoqueDezMaisVendidosBindingSource;
        private DS_EstoqueTableAdapters.RPT_Estoque_Dez_Mais_VendidosTableAdapter rPT_Estoque_Dez_Mais_VendidosTableAdapter;
    }
}