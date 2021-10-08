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
    public partial class FRM_Buscar_Produto_Venda : Form
    {
        public decimal Quant_Solicitada = 0;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Produto_Venda _Instancia;

        public static FRM_Buscar_Produto_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Produto_Venda();
            }
            return _Instancia;
        }

        private void Nome_Col_Grid()
        {
            // Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Tipo";
            this.dataLista.Columns[2].HeaderText = "Descrição";
            this.dataLista.Columns[3].HeaderText = "Categoria";
            this.dataLista.Columns[4].HeaderText = "Unid. de Medida";
            this.dataLista.Columns[5].HeaderText = "Preço de Venda";
        }
        
        private void Formato_Grid()
        {
            // Ocultar Coluns
            this.dataLista.Columns[0].Visible = false; // ID
            this.dataLista.Columns[6].Visible = false; // Quant Atual
            this.dataLista.Columns[7].Visible = false; // Quant Ideal
            this.dataLista.Columns[8].Visible = false; // Preço Custo

            // Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Tipo";
            this.dataLista.Columns[2].HeaderText = "Descrição";
            this.dataLista.Columns[3].HeaderText = "Categoria";
            this.dataLista.Columns[4].HeaderText = "Unid. de Medida";
            this.dataLista.Columns[5].HeaderText = "Preço de Venda";
        }

   
        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.dataLista.DataSource = NVenda.Buscar_Produtos_Disp_Venda(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Descrição";
        }

        // Buscar pelo codigo
        private void BuscarCodigo()
        {
            this.dataLista.DataSource = NVenda.Buscar_Produtos_Disp_Venda_Codigo(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Código";
        }

        public FRM_Buscar_Produto_Venda()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        private void FRM_Buscar_Produto_Venda_Load(object sender, EventArgs e)
        {
            this.TopLevel = true;
            this.TopMost = true;
            this.BringToFront();
            this.Activate();
            this.Focus();
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

        private void FRM_Buscar_Produto_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Quant_Solicitada = 0;
        }

        private void dataLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void FRM_Buscar_Produto_Venda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.dataLista.Rows.Count > 0)
            {
                decimal Quant_Atual_Estoque = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[6].Value);
                string Tipo_Mercadoria = this.dataLista.CurrentRow.Cells[1].Value.ToString();
                string Unid_Medida = this.dataLista.CurrentRow.Cells[4].Value.ToString();

                if (Tipo_Mercadoria == "PRODUTO" && Quant_Atual_Estoque < this.Quant_Solicitada)
                {
                    MessageBox.Show("A quantidade atual no estoque é insuficiente.\n\nQuantidade disponível:   " + Quant_Atual_Estoque.ToString() + " " + Unid_Medida, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    int par1 = Convert.ToInt32(this.dataLista.CurrentRow.Cells[0].Value);
                    string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[2].Value);
                    decimal par3 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[5].Value);
                    decimal par4 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[8].Value);
                    string par5 = Convert.ToString(this.dataLista.CurrentRow.Cells[1].Value);
                    decimal par6 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[6].Value);
                    decimal par7 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[7].Value);

                    FRM_Caixa frm = FRM_Caixa.GetInstancia();

                    frm.SetProduto(par1, par2, par3, par4, par5, par6, par7);

                    int index = frm.dataListaDetalhes.CurrentRow.Index;
                    frm.dataListaDetalhes.CurrentCell = frm.dataListaDetalhes.Rows[index].Cells[4];

                    this.Close();
                }
            }
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal Quant_Atual_Estoque = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[6].Value);
            string Tipo_Mercadoria = this.dataLista.CurrentRow.Cells[1].Value.ToString();
            string Unid_Medida = this.dataLista.CurrentRow.Cells[4].Value.ToString();

            if (Tipo_Mercadoria == "PRODUTO" && Quant_Atual_Estoque < this.Quant_Solicitada)
            {
                MessageBox.Show("A quantidade atual no estoque é insuficiente.\n\nQuantidade disponível:   " + Quant_Atual_Estoque.ToString() + " " + Unid_Medida, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                int par1 = Convert.ToInt32(this.dataLista.CurrentRow.Cells[0].Value);
                string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[2].Value);
                decimal par3 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[5].Value);
                decimal par4 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[8].Value);
                string par5 = Convert.ToString(this.dataLista.CurrentRow.Cells[1].Value);
                decimal par6 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[6].Value);
                decimal par7 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[7].Value);

                FRM_Caixa frm = FRM_Caixa.GetInstancia();

                frm.SetProduto(par1, par2, par3, par4, par5, par6, par7);

                int index = frm.dataListaDetalhes.CurrentRow.Index;
                frm.dataListaDetalhes.CurrentCell = frm.dataListaDetalhes.Rows[index].Cells[4];

                this.Close();
            }
        }

        
        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
