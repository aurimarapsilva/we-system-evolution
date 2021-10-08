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
    public partial class FRM_Tipo_Relatorio_Contas_Pagar : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Contas_Pagar _Instancia;

        public static FRM_Tipo_Relatorio_Contas_Pagar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Contas_Pagar();
            }
            return _Instancia;
        }

        public FRM_Tipo_Relatorio_Contas_Pagar()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Período específico"))
            {
                this.DTP_Data_Inicial.Enabled = true;
                this.DTP_Data_Final.Enabled = true;
            }
            else
            {
                this.DTP_Data_Inicial.Enabled = false;
                this.DTP_Data_Final.Enabled = false;
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Tipo_Relatorio_Contas_Pagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Listagem geral - resumido"))
            {
                FRM_Contas_Pagar_Listagem_Geral_Resumido frm = FRM_Contas_Pagar_Listagem_Geral_Resumido.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - detalhado"))
            {
                FRM_Contas_Pagar_Listagem_Geral_Detalhado frm = FRM_Contas_Pagar_Listagem_Geral_Detalhado.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Período específico"))
            {
                FRM_Contas_Pagar_Periodo_Especifico frm = FRM_Contas_Pagar_Periodo_Especifico.GetInstancia();
                frm.Data_Inicial = this.DTP_Data_Inicial.Value.ToString("dd/MM/yyyy");
                frm.Data_Final = this.DTP_Data_Final.Value.ToString("dd/MM/yyyy");
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Vencendo hoje"))
            {
                FRM_Contas_Pagar_Vencendo_Hoje frm = FRM_Contas_Pagar_Vencendo_Hoje.GetInstancia();
                frm.ShowDialog();
            }
            else
            {
                FRM_Contas_Pagar_Vencidas frm = FRM_Contas_Pagar_Vencidas.GetInstancia();
                frm.ShowDialog();
            }
        }
    }
}
