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
    public partial class FRM_Comp_Venda_Parcelado_Guiche : Form
    {
        private int _IdVenda;

        public int IdVenda
        {
            get
            {
                return _IdVenda;
            }

            set
            {
                _IdVenda = value;
            }
        }

        public FRM_Comp_Venda_Parcelado_Guiche()
        {
            InitializeComponent();
        }
        

        private void FRM_Comp_Venda_Parcelado_Guiche_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Comprovante_Venda.RPT_Comp_Venda_Cabecalho'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Comp_Venda_CabecalhoTableAdapter.Fill(this.dS_Comprovante_Venda.RPT_Comp_Venda_Cabecalho);
                this.rPT_Comp_Venda_DadosTableAdapter.Fill(this.dS_Comprovante_Venda.RPT_Comp_Venda_Dados, this.IdVenda);
                this.rPT_Comp_Venda_ParcelamentoTableAdapter.Fill(this.dS_Comprovante_Venda.RPT_Comp_Venda_Parcelamento, this.IdVenda);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Comp_Venda_Parcelado_Guiche_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();
            DataGridView Grid =  frm.dataListaDetalhes;
            Grid.Focus();

            Grid.CurrentCell = Grid.Rows[0].Cells[2];
        }
    }
}
