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
    public partial class FRM_Buscar_Produto_OS : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Produto_OS _Instancia;

        public static FRM_Buscar_Produto_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Produto_OS();
            }
            return _Instancia;
        }

        private void Formato_Grid()
        {
            // Ocultar Colunas
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

        public FRM_Buscar_Produto_OS()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        private void FRM_Buscar_Produto_OS_Load(object sender, EventArgs e)
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

        private void FRM_Buscar_Produto_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_OS frm = FRM_OS.GetInstancia();

            int par1 = Convert.ToInt32(this.dataLista.CurrentRow.Cells[0].Value);
            string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[2].Value);
            decimal par3 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[5].Value);

            frm.SetProduto(par1, par2, par3);

            int index = frm.DGV_Prod_Serv.CurrentRow.Index;
            frm.DGV_Prod_Serv.CurrentCell = frm.DGV_Prod_Serv.Rows[index].Cells[4];

            this.Close();
        }
    }
}
