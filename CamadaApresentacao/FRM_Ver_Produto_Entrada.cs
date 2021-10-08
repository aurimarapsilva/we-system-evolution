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
    public partial class FRM_Ver_Produto_Entrada : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Ver_Produto_Entrada _Instancia;

        public static FRM_Ver_Produto_Entrada GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Ver_Produto_Entrada();
            }
            return _Instancia;
        }


        //Alterar nome exibido no data lista    
        private void Formato_Grid()
        {
            // Ocultar Colunas
            this.dataLista.Columns[0].Visible = false;

            // Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Tipo";
            this.dataLista.Columns[2].HeaderText = "Descrição";
            this.dataLista.Columns[3].HeaderText = "Categoria";
            this.dataLista.Columns[4].HeaderText = "Unid. de Medida";
            this.dataLista.Columns[5].HeaderText = "Preço de Custo";
        }

        
        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.dataLista.DataSource = NEntrada.Mostrar_Produtos_Disp_Entrada(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        // Buscar pelo codigo
        private void BuscarCodigo()
        {
            this.dataLista.DataSource = NEntrada.Mostrar_Produtos_Disp_Entrada_Codigo(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }


        public FRM_Ver_Produto_Entrada()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        private void FRM_Ver_Produto_Entrada_Load(object sender, EventArgs e)
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

        private void FRM_Ver_Produto_Entrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            if (this.dataLista.Rows.Count == 0)
            {
                FRM_Entrada frm = FRM_Entrada.GetInstancia();
                DataGridView Grid = frm.dataListaDetalhes;

                Grid.CurrentRow.Cells[3].ReadOnly = false;
            }
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Entrada frm = FRM_Entrada.GetInstancia();
            FRM_Inserir_Fab_Venc Fab_Venc = FRM_Inserir_Fab_Venc.GetInstancia();

            int par1 = Convert.ToInt32(this.dataLista.CurrentRow.Cells[0].Value);
            string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[2].Value);
            decimal par3 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[5].Value);

            frm.SetProduto(par1, par2, par3);

            int index = frm.dataListaDetalhes.CurrentRow.Index;
            frm.dataListaDetalhes.CurrentCell = frm.dataListaDetalhes.Rows[index].Cells[4];

            this.Close();
            Fab_Venc.Show();
        }
    }
}
