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
    public partial class FRM_Buscar_OS_Pronto : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_OS_Pronto _Instancia;

        public static FRM_Buscar_OS_Pronto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_OS_Pronto();
            }
            return _Instancia;
        }

        public FRM_Buscar_OS_Pronto()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        // Metodo Formatodo Grid
        private void Formato_Grid()
        {
            // Ocultar Colunas
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;
            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[6].Visible = false;
            this.dataLista.Columns[8].Visible = false;
            this.dataLista.Columns[9].Visible = false;
            this.dataLista.Columns[10].Visible = false;
            this.dataLista.Columns[11].Visible = false;
            this.dataLista.Columns[12].Visible = false;
            this.dataLista.Columns[13].Visible = false;
            this.dataLista.Columns[14].Visible = false;
            this.dataLista.Columns[15].Visible = false;
            this.dataLista.Columns[17].Visible = false;
            this.dataLista.Columns[19].Visible = false;
            this.dataLista.Columns[20].Visible = false;
            this.dataLista.Columns[21].Visible = false;
            this.dataLista.Columns[22].Visible = false;
            this.dataLista.Columns[23].Visible = false;
            this.dataLista.Columns[24].Visible = false;
            this.dataLista.Columns[25].Visible = false;
            this.dataLista.Columns[26].Visible = false; // Diagnostico
            this.dataLista.Columns[27].Visible = false; // Autorização
            this.dataLista.Columns[30].Visible = false;
            this.dataLista.Columns[31].Visible = false;
            this.dataLista.Columns[32].Visible = false;
            this.dataLista.Columns[33].Visible = false;

            // Nome das colunas
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "OS";
            this.dataLista.Columns[4].HeaderText = "Tipo";
            this.dataLista.Columns[7].HeaderText = "Cliente";
            this.dataLista.Columns[16].HeaderText = "Equipamento";
            this.dataLista.Columns[18].HeaderText = "Marca";
            this.dataLista.Columns[28].HeaderText = "Status Geral";
            this.dataLista.Columns[29].HeaderText = "Entrada em:";
        }

        public void Mostrar()
        {
            this.dataLista.DataSource = NOS.Buscar_OS_Pronta();
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        // Buscar pelo Nome do Cliente
        private void Buscar_Pelo_Cliente()
        {
            this.dataLista.DataSource = NOS.Buscar_OS_Pronta_Pelo_Cliente(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cliente";
        }


        // Buscar pelo Nº da OS
        private void Buscar_Pelo_Num_OS()
        {
            this.dataLista.DataSource = NOS.Buscar_OS_Pronta_Pelo_Numero(this.txtBuscar.Text);
            this.Formato_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nº da OS";
        }

        private void FRM_Buscar_OS_Pronto_Load(object sender, EventArgs e)
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

        private void FRM_Buscar_OS_Pronto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Nº da OS"))
            {
                this.Buscar_Pelo_Num_OS();
            }
            else if (this.cbBuscar.Text.Equals("Nome do Cliente"))
            {
                this.Buscar_Pelo_Cliente();
            }
            this.txtBuscar.Text = string.Empty;
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

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();

            int idos = Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value);

            frm.Importar_OS(idos);
            this.Close();
        }
    }
}
