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
    public partial class FRM_Gerar_Contas_Pagar : Form
    {
        public bool eNovo = false;
        DataTable dtparc;

        //Variavel para receber Nome Fornecedor;
        public int idfornecedor;
        public string fornecedor_nome;

        private int col0;
        private decimal col1;
        private DateTime col2;

        //private List<DDetalhe_Contas_Receber> lista;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Gerar_Contas_Pagar _Instancia;

        public static FRM_Gerar_Contas_Pagar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Gerar_Contas_Pagar();
            }
            return _Instancia;
        }


        //CLASSSE PARCELAS E SUAS PROPRIEDADES
        public class Parcela
        {
            public int num_parcela { get; set; }
            public decimal valor { get; set; }
            public DateTime vencimento { get; set; }
        }


        public FRM_Gerar_Contas_Pagar()
        {
            InitializeComponent();
            this.TXB_Id.Enabled = false;
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
            this.TXB_Num_Doc.Text = string.Empty;
            this.TXB_Valor.Text = string.Empty;
            this.DT_Vencimento.Text = string.Empty;
        }


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.BTN_Gravar.Enabled = true;
            }
            else
            {
                this.BTN_Gravar.Enabled = false;
            }
        }


        private void CriarTabela()
        {
            this.dtparc = new DataTable("Gerar");
            this.dtparc.Columns.Add("num_parcela", System.Type.GetType("System.Int32"));
            this.dtparc.Columns.Add("valor", System.Type.GetType("System.Decimal"));
            this.dtparc.Columns.Add("vencimento", System.Type.GetType("System.DateTime"));
            this.dtparc.Columns.Add("estado", System.Type.GetType("System.String"));
            this.dtparc.Columns.Add("obs", System.Type.GetType("System.String"));
            this.dtparc.Columns.Add("idfornecedor", System.Type.GetType("System.Int32"));
        }

        private void FRM_Gerar_Contas_Pagar_Load(object sender, EventArgs e)
        {
            this.botoes();
            this.BTN_Gravar.Enabled = true;
            this.CB_Qtd_Parc.SelectedIndex = 0;
            this.CriarTabela();
        }

        private void BTN_Gravar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.DGV_Parcelas.Rows.Count == 0)
                {
                    this.MensagemErro("Não há parcelas.");
                }
                else
                {
                    if (this.eNovo)
                    {
                        for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                        {
                            this.col0 = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[0].Value);  //num_parcela
                            this.col1 = Convert.ToDecimal(DGV_Parcelas.Rows[i].Cells[1].Value);  //valor
                            this.col2 = Convert.ToDateTime(DGV_Parcelas.Rows[i].Cells[2].Value);   //vencimento


                            DataRow row = dtparc.NewRow();

                            row["num_parcela"] = col0;
                            row["valor"] = col1;
                            row["vencimento"] = col2;
                            row["estado"] = "A VENCER";
                            row["obs"] = "";
                            row["idfornecedor"] = this.idfornecedor;
                            this.dtparc.Rows.Add(row);
                        }

                        // Capturando IDVENDA
                        DataTable Dados_Entrada = NEntrada.Mostrar();
                        int identrada = Convert.ToInt32(Dados_Entrada.Rows[0][0]);

                        resp = NContas_Pagar.Inserir_Contas_Pagar_Apos_Entrada(identrada, this.DT_Vencimento.Value, this.fornecedor_nome, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor.Text), this.dtparc);
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.botoes();
                    this.Limpar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Gerar_Contas_Pagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Gerar_Parc_Click(object sender, EventArgs e)
        {
            string escolha = CB_Qtd_Parc.SelectedItem.ToString();

            switch (escolha)
            {
                case "1 X":
                    CalcularParcela(1);
                    break;

                case "2 X":
                    CalcularParcela(2);
                    break;

                case "3 X":
                    CalcularParcela(3);
                    break;

                case "4 X":
                    CalcularParcela(4);
                    break;

                case "5 X":
                    CalcularParcela(5);
                    break;

                case "6 X":
                    CalcularParcela(6);
                    break;

                case "7 X":
                    CalcularParcela(7);
                    break;

                case "8 X":
                    CalcularParcela(8);
                    break;

                case "9 X":
                    CalcularParcela(9);
                    break;

                case "10 X":
                    CalcularParcela(10);
                    break;

                case "11 X":
                    CalcularParcela(11);
                    break;

                case "12 X":
                    CalcularParcela(12);
                    break;
            }
        }


        private void CalcularParcela(int qtdeParcela)
        {
            DateTime DataVencimento = DT_Vencimento.Value;
            decimal ValorTotal = Convert.ToDecimal(TXB_Valor.Text.ToString());

            int totalParcelas = qtdeParcela;

            int contador = 0;

            List<Parcela> lista = new List<Parcela>();
            for (int i = 0; i < totalParcelas; i++)
            {
                contador++;

                var parcela = new Parcela();
                parcela.num_parcela = contador;
                parcela.valor = ValorTotal / qtdeParcela;
                parcela.vencimento = DataVencimento.AddMonths(contador);

                lista.Add(parcela);
            }

            DGV_Parcelas.AutoGenerateColumns = false;
            DGV_Parcelas.DataSource = null;
            DGV_Parcelas.DataSource = lista;
        }
    }
}
