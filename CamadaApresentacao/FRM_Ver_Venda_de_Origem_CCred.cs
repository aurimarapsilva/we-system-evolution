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
    public partial class FRM_Ver_Venda_de_Origem_CCred : Form
    {
        public string idvenda;
        private DataTable TBL_Info_Venda;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Ver_Venda_de_Origem_CCred _Instancia;

        public static FRM_Ver_Venda_de_Origem_CCred GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Ver_Venda_de_Origem_CCred();
            }
            return _Instancia;
        }

        public FRM_Ver_Venda_de_Origem_CCred()
        {
            InitializeComponent();
            this.TXB_TotalPagar.BackColor = Color.WhiteSmoke;
            this.TXB_TotalPagar.ForeColor = Color.Green;

            this.TXB_Valor_Entrada.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Entrada.ForeColor = Color.Green;
        }

        //Limpar campos
        private void Limpar()
        {
            this.txtId.Text = string.Empty;
            this.txtComprovante.Text = string.Empty;
            this.txtNum_Comprovante.Text = string.Empty;
            this.txtCliente.Text = string.Empty;
            this.txtFuncionario.Text = string.Empty;
            this.TXB_Recebimento.Text = string.Empty;
            this.TXB_Valor_Entrada.Text = string.Empty;
            this.TXB_Juros_Card_Cred.Text = string.Empty;
            this.TXB_Juros_Cred_Loja.Text = string.Empty;
            this.TXB_Comissao_Paga.Text = string.Empty;
            this.TXB_TotalPagar.Text = "R$ 0,00";

            // Limpar Grid - dataListaDetalhes
            if (this.dataListaDetalhes.DataSource != null)
            {
                this.dataListaDetalhes.DataSource = null;
            }
            else
            {
                this.dataListaDetalhes.Rows.Clear();
            }


            // Limpar Grid - DGV_Formas_Pagamento
            if (this.DGV_Formas_Pagamento.DataSource != null)
            {
                this.DGV_Formas_Pagamento.DataSource = null;
            }
            else
            {
                this.DGV_Formas_Pagamento.Rows.Clear();
            }
        }
        
        // Mostar Informações da Venda
        private void Mostrar_Info_Venda()
        {
            // Buscando Informações da Venda
            this.TBL_Info_Venda = NVenda.Mostrar_Venda_Pelo_ID(this.idvenda);

            // Mostrar informaões obtidas
            decimal valor;
            decimal entrada;
            decimal comissao_paga;

            this.txtId.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][0]);
            this.dtData.Value = Convert.ToDateTime(this.TBL_Info_Venda.Rows[0][1]);
            this.txtCliente.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][2]);
            this.txtComprovante.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][3]);
            this.txtNum_Comprovante.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][4]);
            this.txtFuncionario.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][5]);
            this.TXB_Recebimento.Text = Convert.ToString(this.TBL_Info_Venda.Rows[0][6]);

            entrada = Convert.ToDecimal(this.TBL_Info_Venda.Rows[0]["valor_entrada"]);
            this.TXB_Valor_Entrada.Text = entrada.ToString("C");

            comissao_paga = Convert.ToDecimal(this.TBL_Info_Venda.Rows[0]["comissao_paga"]);
            this.TXB_Comissao_Paga.Text = comissao_paga.ToString("C");

            valor = Convert.ToDecimal(this.TBL_Info_Venda.Rows[0][7]);
            this.TXB_TotalPagar.Text = valor.ToString("C");
        }


        // Mostrar Detalhes Entrada
        private void MostrarDetalheVenda()
        {
            this.dataListaDetalhes.DataSource = NVenda.MostrarDetalhes(this.idvenda);

            // Nome das Colunas
            this.dataListaDetalhes.Columns[0].HeaderText = "Quant.";
            this.dataListaDetalhes.Columns[1].HeaderText = "Descrição";
            this.dataListaDetalhes.Columns[2].HeaderText = "Valor Unit.";
            this.dataListaDetalhes.Columns[3].HeaderText = "Subtotal";

            // Tamanho da Coluna
            this.dataListaDetalhes.Columns[0].Width = 100;
            this.dataListaDetalhes.Columns[1].Width = 540;
            this.dataListaDetalhes.Columns[2].Width = 100;
            this.dataListaDetalhes.Columns[3].Width = 100;

            // Formato Moeda
            this.dataListaDetalhes.Columns[2].DefaultCellStyle.Format = "c";
            this.dataListaDetalhes.Columns[3].DefaultCellStyle.Format = "c";
        }

        // Mostrar Formas de Pagamento - VENDA
        private void Mostrar_Formas_Pagamento()
        {
            this.DGV_Formas_Pagamento.DataSource = NVenda.Mostrar_Formas_Pagamento_Venda(this.idvenda);

            // Ocultar Colunas
            this.DGV_Formas_Pagamento.Columns[0].Visible = false;
            this.DGV_Formas_Pagamento.Columns[1].Visible = false;

            // Nome da Coluna
            this.DGV_Formas_Pagamento.Columns[2].HeaderText = "Forma";
            this.DGV_Formas_Pagamento.Columns[3].HeaderText = "Valor Primário";
            this.DGV_Formas_Pagamento.Columns[4].HeaderText = "Valor Final";

            // Formato da Coluna
            this.DGV_Formas_Pagamento.Columns[3].DefaultCellStyle.Format = "c";
            this.DGV_Formas_Pagamento.Columns[4].DefaultCellStyle.Format = "c";

            this.Mostrar_Taxa_Juros_Parcel();
        }


        private void Mostrar_Taxa_Juros_Parcel()
        {
            DataTable Dados_Juros_Parcelamento = NConfig_Juros_Parcelamento.Mostrar();
            decimal Taxa_Card_Cred = Convert.ToDecimal(Dados_Juros_Parcelamento.Rows[0][1]);
            decimal Taxa_Cred_Loja = Convert.ToDecimal(Dados_Juros_Parcelamento.Rows[0][2]);
            string Status = Dados_Juros_Parcelamento.Rows[0][3].ToString();

            if (Status.Equals("SIM"))
            {
                foreach (DataGridViewRow row in DGV_Formas_Pagamento.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals("Cartão de Crédito") && Taxa_Card_Cred > 0)
                    {
                        this.TXB_Juros_Card_Cred.Text = Taxa_Card_Cred.ToString() + "% a.m.";
                    }
                    if (row.Cells[2].Value.ToString().Equals("Crediário da Loja") && Taxa_Cred_Loja > 0)
                    {
                        this.TXB_Juros_Cred_Loja.Text = Taxa_Cred_Loja.ToString() + "% a.m.";
                    }
                }
            }
        }


        private void FRM_Ver_Venda_de_Origem_Load(object sender, EventArgs e)
        {
            this.Mostrar_Info_Venda();
            this.MostrarDetalheVenda();
            this.Mostrar_Formas_Pagamento();
        }

        private void FRM_Ver_Venda_de_Origem_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            FRM_Controle_Cartao_Credito frm = FRM_Controle_Cartao_Credito.GetInstancia();
            frm.CHK_Selecionar.Checked = false;
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.Close();
        }

        private void FRM_Ver_Venda_de_Origem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.Limpar();
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
