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
    public partial class FRM_Receber_Contas_Externo : Form
    {
        public decimal Valor_Atualizado = 0;
        public decimal Valor_Conta = 0;
        public string Num_Doc = "";
        public string Nome_Cliente = "";
        public string Nome_Cliente_Nao_Cadastrado = "";
        public int Idregistro;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Receber_Contas_Externo _Instancia;

        public static FRM_Receber_Contas_Externo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Receber_Contas_Externo();
            }
            return _Instancia;
        }

        public FRM_Receber_Contas_Externo()
        {
            InitializeComponent();
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

        private void Limpar()
        {
            this.TXB_Valor_Atualizado.Text = string.Empty;
            this.TXB_Valor_Recebido.Text = string.Empty;
            this.Valor_Atualizado = 0;
        }

        
        private void FRM_Receber_Contas_Externo_Load(object sender, EventArgs e)
        {
            this.TXB_Valor_Atualizado.Text = this.Valor_Atualizado.ToString();
            this.TXB_Valor_Recebido.Text = this.Valor_Atualizado.ToString();
        }

        private void FRM_Receber_Contas_Externo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Limpar();
        }

        private void CHK_Habilitar_Receb_Parcial_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Habilitar_Receb_Parcial.Checked)
            {
                this.TXB_Valor_Recebido.Text = string.Empty;
                this.TXB_Valor_Recebido.Enabled = true;
                this.TXB_Valor_Recebido.ReadOnly = false;
                this.TXB_Valor_Recebido.Focus();
            }
            else
            {
                this.TXB_Valor_Recebido.Text = this.Valor_Atualizado.ToString();
                this.TXB_Valor_Recebido.Enabled = false;
                this.TXB_Valor_Recebido.ReadOnly = true;
            }
        }

        private void BTN_Receber_Click(object sender, EventArgs e)
        {
            if (this.TXB_Valor_Recebido.Text == string.Empty)
            {
                this.MensagemErro("Informe o valor recebido");
            }
            else
            {
                if (Convert.ToDecimal(this.TXB_Valor_Recebido.Text) > this.Valor_Atualizado)
                {
                    this.MensagemErro("Valor superior ao total dos debitos.");
                }
                else
                {
                    FRM_Contas_Receber frm = FRM_Contas_Receber.GetInstancia();
                    frm.Calcular_Recebimento_Externo(Convert.ToDecimal(this.TXB_Valor_Recebido.Text), this.CHK_Habilitar_Receb_Parcial.Checked, this.Valor_Conta, this.Num_Doc, this.Nome_Cliente, this.Nome_Cliente_Nao_Cadastrado, this.Idregistro);

                    this.Close();
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            FRM_Contas_Receber frm = FRM_Contas_Receber.GetInstancia();
            frm.CHK_Selecionar.Checked = false;

            this.Limpar();
            this.Close();
        }

        private void TXB_Valor_Atualizado_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXB_Valor_Recebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
