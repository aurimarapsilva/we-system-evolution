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
    public partial class FRM_Clientes_LIstagem_Geral_Detalhado : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Clientes_LIstagem_Geral_Detalhado _Instancia;

        public static FRM_Clientes_LIstagem_Geral_Detalhado GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Clientes_LIstagem_Geral_Detalhado();
            }
            return _Instancia;
        }

        public FRM_Clientes_LIstagem_Geral_Detalhado()
        {
            InitializeComponent();
        }

        private void FRM_Clientes_LIstagem_Geral_Detalhado_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.RPT_Clientes_Listagem_Tudo'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Clientes_Listagem_TudoTableAdapter.Fill(this.dS_Clientes.RPT_Clientes_Listagem_Tudo);
                // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Clientes.RPT_Cabecalho_Geral);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
            
        }

        private void FRM_Clientes_LIstagem_Geral_Detalhado_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
