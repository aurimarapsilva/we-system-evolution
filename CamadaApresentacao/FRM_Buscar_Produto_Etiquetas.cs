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
    public partial class FRM_Buscar_Produto_Etiquetas : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Produto_Etiquetas _Instancia;

        public static FRM_Buscar_Produto_Etiquetas GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Produto_Etiquetas();
            }
            return _Instancia;
        }

        public FRM_Buscar_Produto_Etiquetas()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        //Metodo para Formtar Grid
        private void FormataGrid()
        {
            // Ocultar colunas do Grid
            this.dataLista.Columns[1].Visible = false;
            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[6].Visible = false;
            this.dataLista.Columns[8].Visible = false;
            this.dataLista.Columns[10].Visible = false; // Preço Custo
            this.dataLista.Columns[12].Visible = false; // Fabricação
            this.dataLista.Columns[13].Visible = false; // Venciemnto
            this.dataLista.Columns[14].Visible = false; // Corredor Exposição
            this.dataLista.Columns[15].Visible = false; // Prateleira Exposição
            this.dataLista.Columns[16].Visible = false; // Corredor Deposito
            this.dataLista.Columns[17].Visible = false; // Prateleira Deposito
            this.dataLista.Columns[18].Visible = false; //Quant. Atual
            this.dataLista.Columns[19].Visible = false; // Quant. Ideal
            this.dataLista.Columns[20].Visible = false; // ID Fornecedor
            this.dataLista.Columns[21].Visible = false; // Fornecedor
            this.dataLista.Columns[22].Visible = false;
            this.dataLista.Columns[23].Visible = false;

            // Nome das Colunas
            this.dataLista.Columns[2].HeaderText = "Tipo";
            this.dataLista.Columns[3].HeaderText = "Código";
            this.dataLista.Columns[4].HeaderText = "Descrição";
            this.dataLista.Columns[7].HeaderText = "Categoria";
            this.dataLista.Columns[9].HeaderText = "Unidade";
            this.dataLista.Columns[11].HeaderText = "Preço de Venda";

            //Formato das Colunas
            this.dataLista.Columns[11].DefaultCellStyle.Format = "c";
        }



        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.dataLista.DataSource = NProduto.Mostrar();
            this.FormataGrid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }
        
        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.dataLista.DataSource = NProduto.BuscarNome(this.txtBuscar.Text);
            this.FormataGrid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Descrição";
        }

        // Buscar pelo nome 
        private void BuscarCodigo()
        {
            this.dataLista.DataSource = NProduto.BuscarCodigo(this.txtBuscar.Text);
            this.FormataGrid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Código";
        }

        private void FRM_Buscar_Produto_Etiquetas_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Etiquetas frm = FRM_Etiquetas.GetInstancia();

            string idproduto = this.dataLista.CurrentRow.Cells[1].Value.ToString();

            frm.SetProduto(idproduto);
            this.Close();
        }

        private void FRM_Buscar_Produto_Etiquetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals(""))
            {
                this.BTN_Pesquisar.Enabled = false;
            }
            else
            {
                this.BTN_Pesquisar.Enabled = true;
            }
        }

        private void LB_Modo_Exibicao_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Modo_Exibicao.Text.Equals("Mostrar Tudo"))
            {
                this.BTN_Mostrar_Tudo.Visible = false;
            }
            else
            {
                this.BTN_Mostrar_Tudo.Visible = true;
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Descrição"))
            {
                this.BuscarNome();
            }
            else if (this.cbBuscar.Text.Equals("Código"))
            {
                this.BuscarCodigo();
            }
            this.txtBuscar.Text = string.Empty;
        }
    }
}
