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
    public partial class FRM_Entrada_em_Dinheiro_Card_Cred : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Entrada_em_Dinheiro_Card_Cred _Instancia;

        public static FRM_Entrada_em_Dinheiro_Card_Cred GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Entrada_em_Dinheiro_Card_Cred();
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

        public FRM_Entrada_em_Dinheiro_Card_Cred()
        {
            InitializeComponent();
        }

        private void FRM_Entrada_em_Dinheiro_Card_Cred_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            if (this.BTN_Confirmar.Enabled)
            {
                this.MensagemOk("Etapa concluída com sucesso.");
            }
            else
            {
                this.MensagemErro("Procedimento cancelado");
            }
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Você escolheu a opção: " + this.CB_Tipo_Recebimento.Text + ". Está correto?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                if (this.TXB_Valor_Entrada.Text == string.Empty)
                {
                    this.MensagemErro("Informe o valor da entrada.");
                }
                else
                {
                    FRM_Caixa frm = FRM_Caixa.GetInstancia();
                    frm.Set_Detalhe_Recebimento(this.CB_Tipo_Recebimento.Text, Convert.ToDecimal(this.TXB_Valor_Entrada.Text));
                    frm.Adicionar_Informacoes_Cartao_Credito();
                    this.Close();
                }
            }
        }

        private void CB_Tipo_Recebimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo_Recebimento.Text.Equals(""))
            {
                this.BTN_Confirmar.Enabled = false; 
            }
            else
            {
                this.BTN_Confirmar.Enabled = true;

                if (this.CB_Tipo_Recebimento.Text.Equals("SIM"))
                {
                    this.TXB_Valor_Entrada.ReadOnly = false;
                    this.TXB_Valor_Entrada.Text = string.Empty;
                    this.TXB_Valor_Entrada.Focus();
                }
                else if (this.CB_Tipo_Recebimento.Text.Equals("NÃO"))
                {
                    this.TXB_Valor_Entrada.ReadOnly = true;
                    this.TXB_Valor_Entrada.Text = "0,00";
                }
            }
        }

        private void TXB_Valor_Entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
