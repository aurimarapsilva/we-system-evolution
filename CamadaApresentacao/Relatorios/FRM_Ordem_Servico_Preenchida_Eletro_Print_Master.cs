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
    public partial class FRM_Ordem_Servico_Preenchida_Eletro_Print_Master : Form
    {
        private int _IdOS;

        public int IdOS
        {
            get
            {
                return _IdOS;
            }

            set
            {
                _IdOS = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Ordem_Servico_Preenchida_Eletro_Print_Master _Instancia;

        public static FRM_Ordem_Servico_Preenchida_Eletro_Print_Master GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Ordem_Servico_Preenchida_Eletro_Print_Master();
            }
            return _Instancia;
        }

        public FRM_Ordem_Servico_Preenchida_Eletro_Print_Master()
        {
            InitializeComponent();
        }

        

        private void FRM_Ordem_Servico_Preenchida_Eletro_Print_Master_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Ordem_Servico.RPT_Ordem_Servico_Clausulas'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Comp_Venda_CabecalhoTableAdapter.Fill(this.dS_Ordem_Servico.RPT_Comp_Venda_Cabecalho);
                this.rPT_Ordem_Servico_Principal_Preenchida_EletroTableAdapter.Fill(this.dS_Ordem_Servico.RPT_Ordem_Servico_Principal_Preenchida_Eletro, this.IdOS);
                this.rPT_Ordem_Servico_SecundarioTableAdapter.Fill(this.dS_Ordem_Servico.RPT_Ordem_Servico_Secundario, this.IdOS);
                this.rPT_Ordem_Servico_ClausulasTableAdapter.Fill(this.dS_Ordem_Servico.RPT_Ordem_Servico_Clausulas);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Ordem_Servico_Preenchida_Eletro_Print_Master_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
