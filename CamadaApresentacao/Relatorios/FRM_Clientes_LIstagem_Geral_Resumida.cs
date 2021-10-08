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
    public partial class FRM_Clientes_LIstagem_Geral_Resumida : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Clientes_LIstagem_Geral_Resumida _Instancia;

        public static FRM_Clientes_LIstagem_Geral_Resumida GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Clientes_LIstagem_Geral_Resumida();
            }
            return _Instancia;
        }

        public FRM_Clientes_LIstagem_Geral_Resumida()
        {
            InitializeComponent();
        }

        private void FRM_Clientes_LIstagem_Geral_Resumida_Load(object sender, EventArgs e)
        {
           
          
            this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Clientes.RPT_Cabecalho_Geral);
            this.rPT_Clientes_Listagem_ResumoTableAdapter.Fill(this.dS_Clientes.RPT_Clientes_Listagem_Resumo);
            this.reportViewer1.RefreshReport();
           /* try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.RPT_Clientes_Listagem_Resumo'. Você pode movê-la ou removê-la conforme necessário.
                
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }*/
        }

        private void FRM_Clientes_LIstagem_Geral_Resumida_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
