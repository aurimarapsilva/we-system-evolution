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
    public partial class FRM_Cheque_Aguardando : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Cheque_Aguardando _Instancia;

        public static FRM_Cheque_Aguardando GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Cheque_Aguardando();
            }
            return _Instancia;
        }

        public FRM_Cheque_Aguardando()
        {
            InitializeComponent();
        }

        private void FRM_Cheque_Aguardando_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Cheque.RPT_Cheque_Aguardando'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cheque_AguardandoTableAdapter.Fill(this.dS_Cheque.RPT_Cheque_Aguardando);
                // TODO: esta linha de código carrega dados na tabela 'dS_Cheque.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Cheque.RPT_Cabecalho_Geral);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Cheque_Aguardando_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
