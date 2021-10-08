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
    public partial class FRM_Cartao_Debito_Periodo_Especifico : Form
    {
        private string _Data_Inicial;
        private string _Data_Final;

        public string Data_Inicial
        {
            get
            {
                return _Data_Inicial;
            }

            set
            {
                _Data_Inicial = value;
            }
        }

        public string Data_Final
        {
            get
            {
                return _Data_Final;
            }

            set
            {
                _Data_Final = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Cartao_Debito_Periodo_Especifico _Instancia;

        public static FRM_Cartao_Debito_Periodo_Especifico GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Cartao_Debito_Periodo_Especifico();
            }
            return _Instancia;
        }

        public FRM_Cartao_Debito_Periodo_Especifico()
        {
            InitializeComponent();
        }

        private void FRM_Cartao_Debito_Periodo_Especifico_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Cartao_Debito.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Cartao_Debito.RPT_Cabecalho_Geral);
                this.rPT_Cartao_Debito_Periodo_EspecificoTableAdapter.Fill(this.dS_Cartao_Debito.RPT_Cartao_Debito_Periodo_Especifico, Convert.ToDateTime(this.Data_Inicial), Convert.ToDateTime(this.Data_Final));

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Cartao_Debito_Periodo_Especifico_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
