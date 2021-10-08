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
    public partial class FRM_Contas_Pagar_Vencendo_Hoje : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Contas_Pagar_Vencendo_Hoje _Instancia;

        public static FRM_Contas_Pagar_Vencendo_Hoje GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Contas_Pagar_Vencendo_Hoje();
            }
            return _Instancia;
        }

        public FRM_Contas_Pagar_Vencendo_Hoje()
        {
            InitializeComponent();
        }

        private void FRM_Contas_Pagar_Vencendo_Hoje_Load(object sender, EventArgs e)
        {
            try
            {
                string Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");

                // TODO: esta linha de código carrega dados na tabela 'dS_Contas_Pagar.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Contas_Pagar.RPT_Cabecalho_Geral);
                this.rPT_Contas_Pagar_Vencendo_HojeTableAdapter.Fill(this.dS_Contas_Pagar.RPT_Contas_Pagar_Vencendo_Hoje, Convert.ToDateTime(Data_Atual));

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Contas_Pagar_Vencendo_Hoje_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
