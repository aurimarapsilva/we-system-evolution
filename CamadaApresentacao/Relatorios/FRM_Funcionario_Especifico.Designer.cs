namespace CamadaApresentacao
{
    partial class FRM_Funcionario_Especifico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Funcionario_Especifico));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS_Funcionarios = new CamadaApresentacao.DS_Funcionarios();
            this.dSFuncionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTCabecalhoGeralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Cabecalho_GeralTableAdapter = new CamadaApresentacao.DS_FuncionariosTableAdapters.RPT_Cabecalho_GeralTableAdapter();
            this.rPTFuncionarioEspecificoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Funcionario_EspecificoTableAdapter = new CamadaApresentacao.DS_FuncionariosTableAdapters.RPT_Funcionario_EspecificoTableAdapter();
            this.rPTFuncionarioProdutividadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPT_Funcionario_ProdutividadeTableAdapter = new CamadaApresentacao.DS_FuncionariosTableAdapters.RPT_Funcionario_ProdutividadeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTFuncionarioEspecificoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTFuncionarioProdutividadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cabecalho";
            reportDataSource1.Value = this.rPTCabecalhoGeralBindingSource;
            reportDataSource2.Name = "Dados";
            reportDataSource2.Value = this.rPTFuncionarioEspecificoBindingSource;
            reportDataSource3.Name = "Produtividade";
            reportDataSource3.Value = this.rPTFuncionarioProdutividadeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.Funcionario_especifico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(779, 682);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS_Funcionarios
            // 
            this.dS_Funcionarios.DataSetName = "DS_Funcionarios";
            this.dS_Funcionarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSFuncionariosBindingSource
            // 
            this.dSFuncionariosBindingSource.DataSource = this.dS_Funcionarios;
            this.dSFuncionariosBindingSource.Position = 0;
            // 
            // rPTCabecalhoGeralBindingSource
            // 
            this.rPTCabecalhoGeralBindingSource.DataMember = "RPT_Cabecalho_Geral";
            this.rPTCabecalhoGeralBindingSource.DataSource = this.dS_Funcionarios;
            // 
            // rPT_Cabecalho_GeralTableAdapter
            // 
            this.rPT_Cabecalho_GeralTableAdapter.ClearBeforeFill = true;
            // 
            // rPTFuncionarioEspecificoBindingSource
            // 
            this.rPTFuncionarioEspecificoBindingSource.DataMember = "RPT_Funcionario_Especifico";
            this.rPTFuncionarioEspecificoBindingSource.DataSource = this.dS_Funcionarios;
            // 
            // rPT_Funcionario_EspecificoTableAdapter
            // 
            this.rPT_Funcionario_EspecificoTableAdapter.ClearBeforeFill = true;
            // 
            // rPTFuncionarioProdutividadeBindingSource
            // 
            this.rPTFuncionarioProdutividadeBindingSource.DataMember = "RPT_Funcionario_Produtividade";
            this.rPTFuncionarioProdutividadeBindingSource.DataSource = this.dS_Funcionarios;
            // 
            // rPT_Funcionario_ProdutividadeTableAdapter
            // 
            this.rPT_Funcionario_ProdutividadeTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_Funcionario_Especifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 682);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRM_Funcionario_Especifico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário Específico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRM_Funcionario_Especifico_FormClosed);
            this.Load += new System.EventHandler(this.FRM_Funcionario_Especifico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS_Funcionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFuncionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCabecalhoGeralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTFuncionarioEspecificoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTFuncionarioProdutividadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_Funcionarios dS_Funcionarios;
        private System.Windows.Forms.BindingSource dSFuncionariosBindingSource;
        private System.Windows.Forms.BindingSource rPTCabecalhoGeralBindingSource;
        private DS_FuncionariosTableAdapters.RPT_Cabecalho_GeralTableAdapter rPT_Cabecalho_GeralTableAdapter;
        private System.Windows.Forms.BindingSource rPTFuncionarioEspecificoBindingSource;
        private System.Windows.Forms.BindingSource rPTFuncionarioProdutividadeBindingSource;
        private DS_FuncionariosTableAdapters.RPT_Funcionario_EspecificoTableAdapter rPT_Funcionario_EspecificoTableAdapter;
        private DS_FuncionariosTableAdapters.RPT_Funcionario_ProdutividadeTableAdapter rPT_Funcionario_ProdutividadeTableAdapter;
    }
}