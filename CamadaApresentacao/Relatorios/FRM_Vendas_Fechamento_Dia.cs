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
    public partial class FRM_Vendas_Fechamento_Dia : Form
    {
        private string _Data;
        private string _IdGuiche;
        private string _IdFuncionario;

        public string Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }

        public string IdGuiche
        {
            get
            {
                return _IdGuiche;
            }

            set
            {
                _IdGuiche = value;
            }
        }

        public string IdFuncionario
        {
            get
            {
                return _IdFuncionario;
            }

            set
            {
                _IdFuncionario = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Vendas_Fechamento_Dia _Instancia;

        public static FRM_Vendas_Fechamento_Dia GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Vendas_Fechamento_Dia();
            }
            return _Instancia;
        }

        public FRM_Vendas_Fechamento_Dia()
        {
            InitializeComponent();
        }

        private void FRM_Vendas_Fechamento_Dia_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Vendas.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Vendas.RPT_Cabecalho_Geral);
                this.rPT_resultado_fechamento_diaTableAdapter.Fill(this.dS_Vendas.RPT_resultado_fechamento_dia, this.Data, this.IdGuiche, this.IdFuncionario);
                this.rPT_TotaisTableAdapter.Fill(this.dS_Vendas.RPT_Totais, this.Data, this.IdGuiche, this.IdFuncionario);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Vendas_Fechamento_Dia_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
