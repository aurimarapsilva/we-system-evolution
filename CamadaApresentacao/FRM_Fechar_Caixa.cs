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
    public partial class FRM_Fechar_Caixa : Form
    {
        public bool eFechar = false;
        public int IdGuiche;
        public int IdFuncionario;
        public decimal Valor_Inicial_Caixa;

        private DataTable TBL_Cartao_Credito;
        private DataTable TBL_Cartao_Debito;
        private DataTable TBL_Cheque;
        private DataTable TBL_Crediario_Loja;
        private DataTable TBL_Dinheiro;

        private decimal Cartao_Credito = 0;
        private decimal Cartao_Debito = 0;
        private decimal Cheque = 0;
        private decimal Crediario_Loja = 0;
        private decimal Dinheiro = 0;
        private decimal Total = 0;
        private decimal Total_Geral = 0;
        

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Fechar_Caixa _Instancia;

        public static FRM_Fechar_Caixa GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Fechar_Caixa();
            }
            return _Instancia;
        }

        public FRM_Fechar_Caixa()
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

        //Limpar campos
        private void Limpar()
        {
            this.TXB_Data.Text = string.Empty;
            this.TXB_Hora_Aberto.Text = string.Empty;
            this.TXB_Hora_Fechado.Text = string.Empty;
            this.TXB_Nome_Guiche.Text = string.Empty;
            this.TXB_Total_Card_Credito.Text = string.Empty;
            this.TXB_Total_Card_Debito.Text = string.Empty;
            this.TXB_Total_Cheque.Text = string.Empty;
            this.TXB_Total_Crediario_Loja.Text = string.Empty;
            this.TXB_Total_Dinheiro.Text = string.Empty;
            this.TXB_Total_Geral.Text = string.Empty;
            this.TXB_Valor_Inicial.Text = string.Empty;
            this.LB_Funcionario.Text = string.Empty;
        }


        // Mostrar Movimentação do Dia
        private void Mostrar_Resultado_Fechar_Dia()
        {
            this.DGV_Detalhe_Movimentacao.DataSource = NVenda.Mostrar_Resultado_Fechar_Dia(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));
            lblTotal.Text = "Total de registros: " + Convert.ToString(DGV_Detalhe_Movimentacao.Rows.Count);

            // Ocultar colunas do grid
            this.DGV_Detalhe_Movimentacao.Columns[2].Visible = false;
            this.DGV_Detalhe_Movimentacao.Columns[4].Visible = false;

            // Nome das Colunas
            this.DGV_Detalhe_Movimentacao.Columns[0].HeaderText = "Cód. Venda";
            this.DGV_Detalhe_Movimentacao.Columns[1].HeaderText = "Data";
            this.DGV_Detalhe_Movimentacao.Columns[3].HeaderText = "Guiche";
            this.DGV_Detalhe_Movimentacao.Columns[6].HeaderText = "Entrada";
            this.DGV_Detalhe_Movimentacao.Columns[7].HeaderText = "Recebimento";
            this.DGV_Detalhe_Movimentacao.Columns[8].HeaderText = "Valor";

            // Formato moeda
            this.DGV_Detalhe_Movimentacao.Columns[6].DefaultCellStyle.Format = "c";
            this.DGV_Detalhe_Movimentacao.Columns[8].DefaultCellStyle.Format = "c";
        }

        // Metodo Calcular Movimentação do Dia
        private void Calcular_Movimentacao_Dia()
        {
            // Calculando Cartão de Credito
            if (TBL_Cartao_Credito.Rows.Count > 0)
            {
                for (int i = 0; i <= TBL_Cartao_Credito.Rows.Count - 1; i++)
                {
                    this.Cartao_Credito += Convert.ToDecimal(TBL_Cartao_Credito.Rows[i][7]);
                }
                this.TXB_Total_Card_Credito.Text = this.Cartao_Credito.ToString("C");
            }
            // Calculando Cartão de Debito
            if (TBL_Cartao_Debito.Rows.Count > 0)
            {
                for (int i = 0; i <= TBL_Cartao_Debito.Rows.Count - 1; i++)
                {
                    this.Cartao_Debito += Convert.ToDecimal(TBL_Cartao_Debito.Rows[i][7]);
                }
                this.TXB_Total_Card_Debito.Text = this.Cartao_Debito.ToString("C");
            }
            // Calculando Cheque
            if (TBL_Cheque.Rows.Count > 0)
            {
                for (int i = 0; i <= TBL_Cheque.Rows.Count - 1; i++)
                {
                    this.Cheque += Convert.ToDecimal(TBL_Cheque.Rows[i][7]);
                }
                this.TXB_Total_Cheque.Text = this.Cheque.ToString("C");
            }
            // Calculando Crediario da Loja
            if (TBL_Crediario_Loja.Rows.Count > 0)
            {
                for (int i = 0; i <= TBL_Crediario_Loja.Rows.Count - 1; i++)
                {
                    this.Crediario_Loja += Convert.ToDecimal(TBL_Crediario_Loja.Rows[i][7]);
                }
                this.TXB_Total_Crediario_Loja.Text = this.Crediario_Loja.ToString("C");
            }
            // Calculando Dinheiro
            if (TBL_Dinheiro.Rows.Count > 0)
            {
                for (int i = 0; i <= TBL_Dinheiro.Rows.Count - 1; i++)
                {
                    this.Dinheiro += Convert.ToDecimal(TBL_Dinheiro.Rows[i][7]);
                }
                this.TXB_Total_Dinheiro.Text = this.Dinheiro.ToString("C");
            }

            // Calculando total
            this.Total = Cartao_Credito + Cartao_Debito + Cheque + Crediario_Loja + Dinheiro;
            this.TXB_Total.Text = this.Total.ToString("C");

            // Calculando Total Geral
            this.Total_Geral = this.Valor_Inicial_Caixa + Cartao_Credito + Cartao_Debito + Cheque + Crediario_Loja + Dinheiro;
            this.TXB_Total_Geral.Text = this.Total_Geral.ToString("C");
        }


        private void FRM_Fechar_Caixa_Load(object sender, EventArgs e)
        {
            this.TXB_Valor_Inicial.Text = this.Valor_Inicial_Caixa.ToString("C");
            this.Mostrar_Resultado_Fechar_Dia();

            this.TBL_Cartao_Credito = NVenda.Mostrar_Resultado_Dia_Cartao_Credito(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));
            this.TBL_Cartao_Debito = NVenda.Mostrar_Resultado_Dia_Cartao_Debito(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));
            this.TBL_Cheque = NVenda.Mostrar_Resultado_Dia_Cheque(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));
            this.TBL_Crediario_Loja = NVenda.Mostrar_Resultado_Dia_Crediario_Loja(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));
            this.TBL_Dinheiro = NVenda.Mostrar_Resultado_Dia_Dinheiro(this.TXB_Data.Text, Convert.ToString(this.IdGuiche), Convert.ToString(this.IdFuncionario));

            this.Calcular_Movimentacao_Dia();
        }

        private void BTN_Fechar_Caixa_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (eFechar)
                {
                    resp = NCaixa_Operacao_Dia.Inserir(this.IdGuiche, this.TXB_Nome_Guiche.Text, this.IdFuncionario, this.LB_Funcionario.Text, Convert.ToDateTime(this.TXB_Data.Text), this.TXB_Hora_Aberto.Text, this.TXB_Hora_Fechado.Text, this.Valor_Inicial_Caixa, this.Cartao_Credito, this.Cheque, this.Cartao_Debito, this.Crediario_Loja, this.Dinheiro, this.Total);
                }
                if (resp.Equals("Ok"))
                {
                    this.MensagemOk("Operação realizada com sucesso");

                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Deseja imprimir o fechamento do dia?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.Yes)
                    {
                        FRM_Vendas_Fechamento_Dia frm = FRM_Vendas_Fechamento_Dia.GetInstancia();
                        frm.Data = this.TXB_Data.Text;
                        frm.IdGuiche = this.IdGuiche.ToString();
                        frm.IdFuncionario = this.IdFuncionario.ToString();
                        frm.Show();
                    }
                }
                else
                {
                    this.MensagemErro(resp);
                }

                this.Limpar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Fechar_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
