using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FRM_Informacoes_Cartao_Debito : Form
    {
        private DataTable TBL_Info_Cartao_Debito;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Informacoes_Cartao_Debito _Instancia;

        public static FRM_Informacoes_Cartao_Debito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Informacoes_Cartao_Debito();
            }
            return _Instancia;
        }

        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Set_Bandeira(string bandeira)
        {
            this.TXB_Bandeira.Text = bandeira;
        }

        public FRM_Informacoes_Cartao_Debito()
        {
            InitializeComponent();
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.TXB_Bandeira.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma bandeira", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FRM_Caixa frm = FRM_Caixa.GetInstancia();
                frm.bandeira_cartao_debito = this.TXB_Bandeira.Text;
                this.Close();
            }
        }

        private void FRM_Informacoes_Cartao_Debito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            if (this.TXB_Bandeira.Text == string.Empty)
            {
                this.MensagemErro("Etapa abortada.");

                FRM_Caixa frm = FRM_Caixa.GetInstancia();
                frm.CriarTabela_FP();
            }
            else
            {
                this.MensagemOk("Etapa concluída com sucesso");
            }
        }

        private void BTN_Buscar_Bandeira_Click(object sender, EventArgs e)
        {
            FRM_Selecionar_Bandeira_Cartao_Debito frm = FRM_Selecionar_Bandeira_Cartao_Debito.GetInstancia();
            frm.Show();
            this.BTN_Selecionar.Enabled = true;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
