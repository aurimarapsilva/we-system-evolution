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
    public partial class FRM_Detalhes_Cheque_Orcamento : Form
    {
        public DateTime Data;
        public string banco_emissor = "";
        public string nome_titular = "";
        public decimal valor_total = 0;
        public decimal valor_parcela = 0;
        public int quant_parcelas = 0;
        public int Intervalo_Parcelas = 0;
        private int num_parcela = 1;

        public FRM_Detalhes_Cheque_Orcamento()
        {
            InitializeComponent();
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Detalhes_Cheque_Orcamento _Instancia;

        public static FRM_Detalhes_Cheque_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Detalhes_Cheque_Orcamento();
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


        // Metodo Limpar Campos e variaveis
        private void Limpar()
        {
            this.TXB_Num_Parcela.Text = string.Empty;
            this.TXB_Num_Cheque.Text = string.Empty;
            this.banco_emissor = string.Empty;
            this.nome_titular = string.Empty;
            this.quant_parcelas = 0;
            this.valor_parcela = 0;
            this.num_parcela = 1;
        }

        private void FRM_Detalhes_Cheque_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FRM_Detalhes_Cheque_Orcamento_Load(object sender, EventArgs e)
        {
            this.TXB_Num_Parcela.Text = this.num_parcela + " / " + this.quant_parcelas.ToString();
            this.TXB_Num_Cheque.Text = "CHEQUE " + this.num_parcela.ToString();
            this.DTP_Data_Deposito.Value = this.DTP_Data_Deposito.Value.AddDays(this.Intervalo_Parcelas);
            this.TXB_Num_Cheque.Focus();

            if (this.num_parcela == this.quant_parcelas)
            {
                this.BTN_Confirmar.Text = "    Concluir";
            }
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Tem certeza que os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                FRM_Orcamento frm = FRM_Orcamento.GetInstancia();

                if (this.TXB_Num_Cheque.Text == string.Empty)
                {
                    this.MensagemErro("Informe o número do cheque.");
                }
                else
                {
                    if (this.num_parcela == this.quant_parcelas)
                    {
                        frm.SetDados_Pagamento_Cheque(this.Data, this.banco_emissor, this.nome_titular, TXB_Num_Cheque.Text, TXB_Num_Parcela.Text, this.valor_parcela, this.DTP_Data_Deposito.Value);

                        this.MensagemOk("Etapa concluída com sucesso.");
                        frm.Add_Dados_Grid_Forma_Pgto_Cheque(this.valor_total, this.valor_total, this.quant_parcelas);
                        this.Limpar();
                        this.Close();
                    }
                    else
                    {
                        frm.SetDados_Pagamento_Cheque(this.Data, this.banco_emissor, this.nome_titular, TXB_Num_Cheque.Text, TXB_Num_Parcela.Text, this.valor_parcela, this.DTP_Data_Deposito.Value);

                        this.num_parcela++;
                        this.DTP_Data_Deposito.Value = this.DTP_Data_Deposito.Value.AddDays(this.Intervalo_Parcelas);
                        this.TXB_Num_Parcela.Text = this.num_parcela + " / " + this.quant_parcelas.ToString();
                        this.TXB_Num_Cheque.Text = "CHEQUE " + this.num_parcela.ToString();
                        this.TXB_Num_Cheque.Focus();

                        if (this.num_parcela == this.quant_parcelas)
                        {
                            this.BTN_Confirmar.Text = "    Concluir";
                        }
                    }
                }
            }
        }
    }
}
