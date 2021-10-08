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
    public partial class FRM_Buscar_Produto_Pesquisa_Preco : Form
    {
        public FRM_Buscar_Produto_Pesquisa_Preco()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        //Mostrar mensagem de alerta
        private void MensagemAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Produto_Pesquisa_Preco _Instancia;

        public static FRM_Buscar_Produto_Pesquisa_Preco GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Produto_Pesquisa_Preco();
            }
            return _Instancia;
        }


        //Metodo para Formtar Grid
        private void FormataGrid()
        {
            // Ocultar colunas do Grid
            this.dataLista.Columns[0].Visible = false; // ID
            this.dataLista.Columns[4].Visible = false; // Imagem
            this.dataLista.Columns[9].Visible = false; // Corredor Expo
            this.dataLista.Columns[10].Visible = false; // Prateleira Expo
            this.dataLista.Columns[11].Visible = false; // Corredor Dep
            this.dataLista.Columns[12].Visible = false; // Prateleira Dep
            this.dataLista.Columns[8].Visible = false; // Quant Atual
            this.dataLista.Columns[13].Visible = false; // Quant Ideal

            // Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Tipo";
            this.dataLista.Columns[2].HeaderText = "Código";
            this.dataLista.Columns[3].HeaderText = "Descrição";
            this.dataLista.Columns[5].HeaderText = "Categoria";
            this.dataLista.Columns[6].HeaderText = "Unidade";
            this.dataLista.Columns[7].HeaderText = "Preço de Venda";

            //Formato das Colunas
            this.dataLista.Columns[7].DefaultCellStyle.Format = "c";
        }
        
        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.dataLista.DataSource = NProduto.Buscar_Produto_Pesquisa_Preco(this.txtBuscar.Text);
            this.FormataGrid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Descrição";
        }

        // Buscar pelo codigo
        private void BuscarCodigo()
        {
            this.dataLista.DataSource = NProduto.Buscar_Produto_Pesquisa_Preco_Codigo(this.txtBuscar.Text);
            this.FormataGrid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Código";
        }

        private void FRM_Buscar_Produto_Pesquisa_Preco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Pesquisar_Preco frm = FRM_Pesquisar_Preco.GetInstancia();

            string descricao = this.dataLista.CurrentRow.Cells[3].Value.ToString();
            string tipo = this.dataLista.CurrentRow.Cells[1].Value.ToString();
            string estoque_atual = this.dataLista.CurrentRow.Cells[8].Value.ToString();
            string corredor_expo = this.dataLista.CurrentRow.Cells[9].Value.ToString();
            string prateleira_expo = this.dataLista.CurrentRow.Cells[10].Value.ToString();
            string corredor_dep = this.dataLista.CurrentRow.Cells[11].Value.ToString();
            string prateleira_dep = this.dataLista.CurrentRow.Cells[12].Value.ToString();
            decimal preco_venda = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[7].Value);
            byte[] imagem = (byte[])this.dataLista.CurrentRow.Cells[4].Value;
            decimal quant_ideal = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[13].Value);

            frm.SetProduto(descricao, tipo, estoque_atual, corredor_expo, prateleira_expo, corredor_dep, prateleira_dep, preco_venda, imagem, quant_ideal);
            this.Close();

            if (Convert.ToDecimal(estoque_atual) < quant_ideal)
            {
                this.MensagemAlerta("Estoque abaixo do ideal.");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Descrição"))
            {
                this.BuscarNome();
            }
            else if (this.cbBuscar.Text.Equals("Código"))
            {
                this.BuscarCodigo();
            }
        }
    }
}
