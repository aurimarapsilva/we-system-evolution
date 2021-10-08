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
    public partial class FRM_Buscar_Orcamento : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Orcamento _Instancia;

        public static FRM_Buscar_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Orcamento();
            }
            return _Instancia;
        }

        public FRM_Buscar_Orcamento()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        // Metoido de Formatação de Grid
        private void Formato_Grid()
        {
            // Ocultar Colunas
            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[6].Visible = false;
            this.dataLista.Columns[7].Visible = false;

            // Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Nº";
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "Cliente";
            this.dataLista.Columns[4].HeaderText = "Telefone";

            // Formato Moeda
            this.dataLista.Columns[8].DefaultCellStyle.Format = "c";
        }


        // Metodo Mostrar Orçamento
        private void Mostrar()
        {
            this.dataLista.DataSource = NOrcamento.Mostrar();
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        
        // Metodo Buscar por Cliente
        private void Buscar_Cliente()
        {
            this.dataLista.DataSource = NOrcamento.Buscar_Orcamento_Cliente(this.txtBuscar.Text);
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cliente";
        }

       
        // Metodo Buscar por Numero / ID do Orçamento 
        private void Buscar_Numero()
        {
            this.dataLista.DataSource = NOrcamento.Buscar_Orcamento_Num(this.txtBuscar.Text);
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(this.dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Número";
        }

        private void FRM_Buscar_Orcamento_Load(object sender, EventArgs e)
        {
            this.Mostrar();
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

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();
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

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Nº do Orçamento"))
            {
                this.Buscar_Numero();
            }
            else if (this.cbBuscar.Text.Equals("Nome do Cliente"))
            {
                this.Buscar_Cliente();
            }
            this.txtBuscar.Text = string.Empty;
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();

            int idorcamento = Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value);

            frm.Importar_Orcamento(idorcamento);

            this.Close();
        }

        private void FRM_Buscar_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
