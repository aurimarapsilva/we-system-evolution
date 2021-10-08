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
    public partial class FRM_Comp_Venda_Demais_Formas_Pgto_Listagem : Form
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

        public FRM_Comp_Venda_Demais_Formas_Pgto_Listagem()
        {
            InitializeComponent();
        }
        

        private void FRM_Comp_Venda_Demais_Formas_Pgto_Listagem_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Comprovante_Venda.RPT_Comp_Venda_Cabecalho'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Comp_Venda_CabecalhoTableAdapter.Fill(this.dS_Comprovante_Venda.RPT_Comp_Venda_Cabecalho);
                this.rPT_Comp_Venda_DadosTableAdapter.Fill(this.dS_Comprovante_Venda.RPT_Comp_Venda_Dados, this.IdVenda);
                
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Comp_Venda_Demais_Formas_Pgto_Listagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Venda frm = FRM_Venda.GetInstancia();
            frm.chkSelecionar.Checked = false;
        }
    }
}
