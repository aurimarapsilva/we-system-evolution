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
    public partial class FRM_Tipo_Relatorio_Cheque : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Cheque _Instancia;

        public static FRM_Tipo_Relatorio_Cheque GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Cheque();
            }
            return _Instancia;
        }

        public FRM_Tipo_Relatorio_Cheque()
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

        private void FRM_Tipo_Relatorio_Cheque_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Aguardando"))
            {
                FRM_Cheque_Aguardando frm = FRM_Cheque_Aguardando.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Depositados"))
            {
                FRM_Cheque_Depositados frm = FRM_Cheque_Depositados.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Depositar hoje"))
            {
                FRM_Cheque_Depositar_Hoje frm = FRM_Cheque_Depositar_Hoje.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Devolvidos"))
            {
                FRM_Cheque_Devolvidos frm = FRM_Cheque_Devolvidos.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral"))
            {
                FRM_Cheque_Listagem_Geral frm = FRM_Cheque_Listagem_Geral.GetInstancia();
                frm.ShowDialog();
            }
            else
            {
                FRM_Cheque_Periodo_Especifico frm = FRM_Cheque_Periodo_Especifico.GetInstancia();
                frm.Data_Inicial = this.DTP_Data_Inicial.Value.ToString("dd/MM/yyyy");
                frm.Data_Final = this.DTP_Data_Final.Value.ToString("dd/MM/yyyy");
                frm.ShowDialog();
            }
        }
    }
}
