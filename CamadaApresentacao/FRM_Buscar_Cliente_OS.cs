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
    public partial class FRM_Buscar_Cliente_OS : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Buscar_Cliente_OS _Instancia;

        public static FRM_Buscar_Cliente_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Buscar_Cliente_OS();
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
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
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


        public FRM_Buscar_Cliente_OS()
        {
            InitializeComponent();
            this.cbBuscar.SelectedIndex = 0;
        }

        private void FRM_Buscar_Cliente_OS_Load(object sender, EventArgs e)
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

        private void FRM_Buscar_Cliente_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_OS frm = FRM_OS.GetInstancia();

            int par1 = Convert.ToInt32(this.dataLista.CurrentRow.Cells[0].Value);
            string par2 = Convert.ToString(this.dataLista.CurrentRow.Cells[1].Value);
            string par3 = Convert.ToString(this.dataLista.CurrentRow.Cells[6].Value);
            string par4 = Convert.ToString(this.dataLista.CurrentRow.Cells[5].Value);
            string par5 = Convert.ToString(this.dataLista.CurrentRow.Cells[7].Value);
            string par6 = Convert.ToString(this.dataLista.CurrentRow.Cells[8].Value);
            string par7 = Convert.ToString(this.dataLista.CurrentRow.Cells[9].Value);
            string par8 = Convert.ToString(this.dataLista.CurrentRow.Cells[10].Value);
            string par9 = Convert.ToString(this.dataLista.CurrentRow.Cells[11].Value);
            string par10 = Convert.ToString(this.dataLista.CurrentRow.Cells[13].Value);

            frm.SetCliente(par1, par2, par3, par4, par5, par6, par7, par8, par9, par10);

            this.Hide();
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

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            FRM_Atalho_Novo_Cliente_OS frm = FRM_Atalho_Novo_Cliente_OS.GetInstancia();
            frm.eNovo = true;
            frm.Show();
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
