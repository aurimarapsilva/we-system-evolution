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
    public partial class FRM_Ver_Entrada_Origem_Contas_Pagar : Form
    {
        public string identrada;
        private DataTable TBL_Info_Entrada;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Ver_Entrada_Origem_Contas_Pagar _Instancia;

        public static FRM_Ver_Entrada_Origem_Contas_Pagar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Ver_Entrada_Origem_Contas_Pagar();
            }
            return _Instancia;
        }

        public FRM_Ver_Entrada_Origem_Contas_Pagar()
        {
            InitializeComponent();
            this.TXB_TotalPagar.BackColor = Color.WhiteSmoke;
            this.TXB_TotalPagar.ForeColor = Color.Green;
        }


        //Limpar campos
        private void Limpar()
        {
            this.txtId.Text = string.Empty;
            this.TXB_Tipo_Comprovante.Text = string.Empty;
            this.txtNum_Comprovante.Text = string.Empty;
            this.TXB_Fornecedor.Text = string.Empty;
            this.TXB_Funcionario.Text = string.Empty;
            this.TXB_Tipo_Compra.Text = string.Empty;
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
        }


        // Mostrar Informações da Compra
        private void Mostrar_Info_Compra()
        {
            // Buscando Informações da Compra
            this.TBL_Info_Entrada = NEntrada.Mostrar_Entrada_Pelo_ID(this.identrada);

            // Mostrar informaões obtidas
            decimal valor;

            this.txtId.Text = Convert.ToString(this.TBL_Info_Entrada.Rows[0][0]);
            this.dtData.Value = Convert.ToDateTime(this.TBL_Info_Entrada.Rows[0][1]);
            this.TXB_Fornecedor.Text = Convert.ToString(this.TBL_Info_Entrada.Rows[0][2]);
            
            this.TXB_Tipo_Comprovante.Text = Convert.ToString(this.TBL_Info_Entrada.Rows[0][3]);
            this.txtNum_Comprovante.Text = Convert.ToString(this.TBL_Info_Entrada.Rows[0][4]);
            this.TXB_Tipo_Compra.Text = Convert.ToString(this.TBL_Info_Entrada.Rows[0][6]);
            valor = Convert.ToDecimal(this.TBL_Info_Entrada.Rows[0][7]);

            this.TXB_TotalPagar.Text = valor.ToString("C");
        }


        // Mostrar Detalhes Compra
        private void MostrarDetalheVenda()
        {
            this.dataListaDetalhes.DataSource = NEntrada.MostrarDetalhes(this.identrada);

            // Ocultar Colunas
            this.dataListaDetalhes.Columns[1].Visible = false;

            // Tamanho das Colunas
            this.dataListaDetalhes.Columns[3].Width = 510;

            // Nome das Colunas
            this.dataListaDetalhes.Columns[2].HeaderText = "Quant";
            this.dataListaDetalhes.Columns[3].HeaderText = "Descrição";
            this.dataListaDetalhes.Columns[4].HeaderText = "Fabricação";
            this.dataListaDetalhes.Columns[5].HeaderText = "Vencimento";
            this.dataListaDetalhes.Columns[6].HeaderText = "Valor Unit.";
            this.dataListaDetalhes.Columns[7].HeaderText = "Subtotal";
            
            // Formato Moeda 
            this.dataListaDetalhes.Columns[6].DefaultCellStyle.Format = "c";
            this.dataListaDetalhes.Columns[7].DefaultCellStyle.Format = "c";
        }

        private void FRM_Ver_Venda_Origem_Contas_Pagar_Load(object sender, EventArgs e)
        {
            this.Mostrar_Info_Compra();
            this.MostrarDetalheVenda();
        }

        private void FRM_Ver_Venda_Origem_Contas_Pagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            FRM_Contas_Pagar frm = FRM_Contas_Pagar.GetInstancia();
            frm.CHK_Selecionar.Checked = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.Close();
        }

        private void FRM_Ver_Venda_Origem_Contas_Pagar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                this.Limpar();
                this.Close();
            }
        }
    }
}
