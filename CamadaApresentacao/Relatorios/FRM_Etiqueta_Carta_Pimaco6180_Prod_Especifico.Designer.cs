namespace CamadaApresentacao
{
    partial class FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico));
            this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS_Etiquetas = new CamadaApresentacao.DS_Etiquetas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter = new CamadaApresentacao.DS_EtiquetasTableAdapters.RPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Etiquetas)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource
            // 
            this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource.DataMember = "RPT_Etiquetas_Carta_Pimaco6180_Prod_Especifico";
            this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource.DataSource = this.dS_Etiquetas;
            // 
            // dS_Etiquetas
            // 
            this.dS_Etiquetas.DataSetName = "DS_Etiquetas";
            this.dS_Etiquetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Dados";
            reportDataSource1.Value = this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Etiqueta_Carta_Pimaco6180_Prod_Especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter
            // 
            this.rPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta Carta - Padrão: Pimaco 6180 - Produto Especiífico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Etiquetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rPTEtiquetasCartaPimaco6180ProdEspecificoBindingSource;
        private DS_Etiquetas dS_Etiquetas;
        private DS_EtiquetasTableAdapters.RPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter rPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter;
    }
}