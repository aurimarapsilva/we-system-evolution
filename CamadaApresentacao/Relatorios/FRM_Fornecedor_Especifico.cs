using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class FRM_Fornecedor_Especifico : Form
    {
        private int _IdFornecedor;

        public int IdFornecedor
        {
            get
            {
                return _IdFornecedor;
            }

            set
            {
                _IdFornecedor = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Fornecedor_Especifico _Instancia;

        public static FRM_Fornecedor_Especifico GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Fornecedor_Especifico();
            }
            return _Instancia;
        }

        public FRM_Fornecedor_Especifico()
        {
            InitializeComponent();
        }

        
        private void FRM_Fornecedor_Especifico_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Fornecedores.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Fornecedores.RPT_Cabecalho_Geral);
                this.rPT_Fornecedor_EspecificoTableAdapter.Fill(this.dS_Fornecedores.RPT_Fornecedor_Especifico, this.IdFornecedor);
                this.rPT_Fornecedor_Especifico_Dados_FinanceirosTableAdapter.Fill(this.dS_Fornecedores.RPT_Fornecedor_Especifico_Dados_Financeiros, this.IdFornecedor);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Fornecedor_Especifico_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
