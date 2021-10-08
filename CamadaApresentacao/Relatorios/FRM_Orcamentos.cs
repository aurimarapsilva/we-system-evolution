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
    public partial class FRM_Orcamentos : Form
    {
        private int _IdOrcamento;

        public int IdOrcamento
        {
            get
            {
                return _IdOrcamento;
            }

            set
            {
                _IdOrcamento = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Orcamentos _Instancia;

        public static FRM_Orcamentos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Orcamentos();
            }
            return _Instancia;
        }

        public FRM_Orcamentos()
        {
            InitializeComponent();
        }
        
        private void FRM_Orcamentos_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'DS_Orcamento.RPT_Comp_Venda_Cabecalho'. Você pode movê-la ou removê-la conforme necessário.
                this.RPT_Comp_Venda_CabecalhoTableAdapter.Fill(this.DS_Orcamento.RPT_Comp_Venda_Cabecalho);
                this.RPT_OrcamentoTableAdapter.Fill(this.DS_Orcamento.RPT_Orcamento, this.IdOrcamento);
                this.RPT_Orcamento_Formas_PgtoTableAdapter.Fill(this.DS_Orcamento.RPT_Orcamento_Formas_Pgto, this.IdOrcamento);
                this.spmostrar_config_orcamentoTableAdapter.Fill(this.DS_Orcamento.spmostrar_config_orcamento);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Orcamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
