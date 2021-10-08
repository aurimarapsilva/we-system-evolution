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
    public partial class FRM_Informacoes_Cartao_Credito_Orcamento : Form
    {
        public decimal Valor_Produtos_Servicos = 0;
        private decimal Total_Geral = 0;
        private decimal Valor_Parcelas;
        private DataTable TBL_Dados_Juros_Parcelamento;
        private decimal Juros_Mensal = 0;
        private string Status = "";

        public FRM_Informacoes_Cartao_Credito_Orcamento()
        {
            InitializeComponent();
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Informacoes_Cartao_Credito_Orcamento _Instancia;

        public static FRM_Informacoes_Cartao_Credito_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Informacoes_Cartao_Credito_Orcamento();
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

        private void Calcular_Juros_Parcelamento()
        {
            if (this.Status.Equals("SIM"))
            {
                decimal valor_juros = this.Valor_Produtos_Servicos * this.Juros_Mensal / 100;
                decimal total_juros = 0;

                total_juros = valor_juros * Convert.ToDecimal(this.CB_Quant_Parc.Text);
                this.Total_Geral = this.Valor_Produtos_Servicos + total_juros;

                this.TXB_Total_Geral.Text = this.Total_Geral.ToString("C");
            }
            else
            {
                this.Total_Geral = this.Valor_Produtos_Servicos;
                this.TXB_Total_Geral.Text = this.Total_Geral.ToString("C");
            }
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.TXB_Bandeira.Text == string.Empty)
            {
                MessageBox.Show("Selecione uma bandeira", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.CB_Quant_Parc.Text.Equals(""))
                {
                    this.MensagemErro("Selecione a quantidade de parcelas.");
                }
                else
                {
                    FRM_Orcamento frm = FRM_Orcamento.GetInstancia();
                    frm.Set_Dados_Card_Cred(this.TXB_Bandeira.Text, this.Valor_Parcelas, Convert.ToInt32(this.CB_Quant_Parc.Text));

                    this.Close();
                }
            }
        }

        private void FRM_Informacoes_Cartao_Credito_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            if (this.TXB_Bandeira.Text == string.Empty)
            {
                this.MensagemErro("Etapa abortada.");
            }
            else
            {
                this.MensagemOk("Etapa concluída com sucesso");

                FRM_Orcamento frm = FRM_Orcamento.GetInstancia();
                frm.Add_Dados_Grid_Forma_Pgto_Cartao_Credito(this.Valor_Produtos_Servicos, this.Total_Geral, Convert.ToInt32(this.CB_Quant_Parc.Text));
            }
        }

        private void FRM_Informacoes_Cartao_Credito_Orcamento_Load(object sender, EventArgs e)
        {
            this.TXB_Total_Prod_Serv.Text = this.Valor_Produtos_Servicos.ToString("C");

            // Obtendo Dados dos Juros de Parcelamneto
            this.TBL_Dados_Juros_Parcelamento = NConfig_Juros_Parcelamento.Mostrar();
            this.Juros_Mensal = Convert.ToDecimal(this.TBL_Dados_Juros_Parcelamento.Rows[0][1]);
            this.Status = this.TBL_Dados_Juros_Parcelamento.Rows[0][3].ToString();

            // Mostrando Juros Atual e Status
            this.LB_Taxa_Juros.Text = this.Juros_Mensal.ToString() + "% a.m.";

            if (this.Juros_Mensal > 0)
            {
                this.LB_Status.Text = "Status: ATIVADO";
            }
            else
            {
                this.LB_Status.Text = "Status: DESATIVADO";
            }
        }

        private void BTN_Selecionar_Bandeira_Click(object sender, EventArgs e)
        {
            FRM_Selecionar_Bandeira_Cartao_Credito_Orcamento frm = FRM_Selecionar_Bandeira_Cartao_Credito_Orcamento.GetInstancia();
            frm.ShowDialog();
        }

        private void CB_Quant_Parc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Calcular_Juros_Parcelamento();

            this.Valor_Parcelas = this.Total_Geral / Convert.ToDecimal(this.CB_Quant_Parc.Text);
            this.TXB_Valor_Parcelas.Text = this.Valor_Parcelas.ToString("C");
        }
    }
}
