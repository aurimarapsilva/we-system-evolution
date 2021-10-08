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
    public partial class FRM_Buscar_Cliente_Venda : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Cliente_Venda _Instancia;

        public static FRM_Buscar_Cliente_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Cliente_Venda();
            }
            return _Instancia;
        }

        //Metodo ocultar colunas do Grid
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[2].Visible = false;
            this.dataLista.Columns[3].Visible = false;
            this.dataLista.Columns[4].Visible = false;
            this.dataLista.Columns[12].Visible = false;
            this.dataLista.Columns[14].Visible = false;
        }

        //Alterar nome exibido no data lista    
        private void Exibicao_DataLista()
        {
            this.dataLista.Columns[1].HeaderText = "Nome Completo";
            this.dataLista.Columns[5].HeaderText = "RG";
            this.dataLista.Columns[6].HeaderText = "CPF";
            this.dataLista.Columns[7].HeaderText = "Endereço";
            this.dataLista.Columns[8].HeaderText = "Bairro";
            this.dataLista.Columns[9].HeaderText = "Cidade";
            this.dataLista.Columns[10].HeaderText = "CEP";
            this.dataLista.Columns[11].HeaderText = "UF";
            this.dataLista.Columns[13].HeaderText = "Celular";
            this.dataLista.Columns[15].HeaderText = "Limite de Crédito";
        }

        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.dataLista.DataSource = NCliente.Mostrar();
            this.ocultarColunas();
            this.Exibicao_DataLista();
            lblTotal.Text = "Total de egistros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCliente.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            this.Exibicao_DataLista();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nome";
        }


        // Buscar pelo RG
        private void BuscarRG()
        {
            this.dataLista.DataSource = NCliente.BuscarRG(this.txtBuscar.Text);
            this.ocultarColunas();
            this.Exibicao_DataLista();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "RG";
        }


        // Buscar pelo RG
        private void BuscarCPF()
        {
            this.dataLista.DataSource = NCliente.BuscarCPF(this.txtBuscar.Text);
            this.ocultarColunas();
            this.Exibicao_DataLista();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "CPF";
        }

        public FRM_Buscar_Cliente_Venda()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        private void FRM_Buscar_Cliente_Venda_Load(object sender, EventArgs e)
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

        private void FRM_Buscar_Cliente_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FRM_Buscar_Cliente_Venda_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && this.txtBuscar.Text != "")
            {
                FRM_Caixa frm = FRM_Caixa.GetInstancia();

                string par1 = Convert.ToString(this.dataLista.CurrentRow.Cells[0].Value);
                string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[1].Value);
                decimal par3 = Convert.ToDecimal(this.dataLista.CurrentRow.Cells[15].Value);

                frm.SetCliente(par1, par2, par3);
                frm.Analise_Credito();

                this.Close();
            }
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();

            string par1 = Convert.ToString(dataLista.CurrentRow.Cells[0].Value);
            string par2 = Convert.ToString(dataLista.CurrentRow.Cells[1].Value);
            decimal par3 = Convert.ToDecimal(dataLista.CurrentRow.Cells[15].Value);

            frm.SetCliente(par1, par2, par3);
            frm.Analise_Credito();
            
            this.Close();
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();

            if (this.cbBuscar.Text.Equals("CPF"))
            {
                this.txtBuscar.MaxLength = 14;
            }
            else
            {
                this.txtBuscar.MaxLength = 32767;
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

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Nome"))
            {
                this.BuscarNome();
            }
            else if (this.cbBuscar.Text.Equals("RG"))
            {
                this.BuscarRG();
            }
            else
            {
                this.BuscarCPF();
            }
            this.txtBuscar.Text = string.Empty;
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            FRM_Atalho_Novo_Cliente_Venda frm = FRM_Atalho_Novo_Cliente_Venda.GetInstancia();
            frm.eNovo = true;
            frm.Show();
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbBuscar.Text.Equals("CPF"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtBuscar.TextLength)
                    {
                        case 0:
                            this.txtBuscar.Text = "";
                            break;
                        case 3:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 5;
                            break;
                        case 7:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 9;
                            break;
                        case 11:
                            this.txtBuscar.Text += "-";
                            this.txtBuscar.SelectionStart = 13;
                            break;
                    }
                }
            }
        }
    }
}
