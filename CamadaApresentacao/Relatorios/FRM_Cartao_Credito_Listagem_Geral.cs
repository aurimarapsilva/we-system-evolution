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
    public partial class FRM_Cartao_Credito_Listagem_Geral : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Cartao_Credito_Listagem_Geral _Instancia;

        public static FRM_Cartao_Credito_Listagem_Geral GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Cartao_Credito_Listagem_Geral();
            }
            return _Instancia;
        }

        public FRM_Cartao_Credito_Listagem_Geral()
        {
            InitializeComponent();
        }

        private void FRM_Cartao_Credito_Listagem_Geral_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Cartao_Credito.RPT_Cartao_Credito_Listagem_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cartao_Credito_Listagem_GeralTableAdapter.Fill(this.dS_Cartao_Credito.RPT_Cartao_Credito_Listagem_Geral);
                // TODO: esta linha de código carrega dados na tabela 'dS_Cartao_Credito.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Cartao_Credito.RPT_Cabecalho_Geral);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Cartao_Credito_Listagem_Geral_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
