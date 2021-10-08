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
    public partial class FRM_Livro_Caixa : Form
    {
        private DataTable DT_Num_Auto_LC;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Livro_Caixa _Instancia;

        public static FRM_Livro_Caixa GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Livro_Caixa();
            }
            return _Instancia;
        }


        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        //Metodo Formata Grid - dataLista
        private void FormataGrid()
        {
            // Ocultar colunas
            this.dataLista.Columns[0].Visible = false; // Coluna de Seleção
            this.dataLista.Columns[1].Visible = false; // Coluna Id

            //Tamanho das Colunas
            this.dataLista.Columns[2].Width = 80;
            this.dataLista.Columns[3].Width = 345;
            this.dataLista.Columns[4].Width = 155;
            this.dataLista.Columns[5].Width = 110;
            this.dataLista.Columns[6].Width = 110;
            this.dataLista.Columns[7].Width = 110;

            //Nome das Colunas
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "Historico";
            this.dataLista.Columns[4].HeaderText = "Nº do Documento";
            this.dataLista.Columns[5].HeaderText = "Crédito";
            this.dataLista.Columns[6].HeaderText = "Debito";

            //Formato das Colunas
            this.dataLista.Columns[5].DefaultCellStyle.Format = "c";
            this.dataLista.Columns[6].DefaultCellStyle.Format = "c";
            this.dataLista.Columns[7].DefaultCellStyle.Format = "c";

            //Cor da coluna
            this.dataLista.Columns[5].DefaultCellStyle.ForeColor = Color.Green;
            this.dataLista.Columns[6].DefaultCellStyle.ForeColor = Color.Red;

        }


        // Buscar por Datas
        private void BuscarData()
        {
            this.dataLista.DataSource = NLivro_Caixa.BuscarData(this.DT_Data_Inicial.Value.ToString("dd/MM/yyyy"), this.DT_Data_Final.Value.ToString("dd/MM/yyyy"));
            this.FormataGrid();
            this.Saldo();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }


        public void Saldo()
        {
            try
            {
                decimal valorTotal = 0;
                string valor = "";

                if (dataLista.CurrentRow.Cells[7].Value != null)
                {
                    valor = dataLista.CurrentRow.Cells[7].Value.ToString();

                    if (!valor.Equals(""))
                    {
                        for (int i = 0; i <= dataLista.RowCount - 1; i++)
                        {
                            if (dataLista.Rows[i].Cells[7].Value != null)

                                valorTotal += Convert.ToDecimal(dataLista.Rows[i].Cells[7].Value);
                        }
                     
                        LB_Saldo.Text = "Saldo Atual: " + valorTotal.ToString("C");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum registro encontrado", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.dataLista.DataSource = NLivro_Caixa.Mostrar();
            this.FormataGrid();

            //Mostrar total de registros
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }


        //Metodo Numeração Automática - Parte 1
        public int Auxiliar_NA_Credito;    //Variavel Auxiliar Crédito
        public int Auxiliar_NA_Debito;    //Variavel Auxiliar Debito

        private void Numeracao_Automatica()
        {
            this.DT_Num_Auto_LC = NNumeracao_Auto.Mostrar_Num_Auto_Livro_Caixa();
            this.Auxiliar_NA_Credito = Convert.ToInt32(this.DT_Num_Auto_LC.Rows[0][3]);
            this.Auxiliar_NA_Debito = Convert.ToInt32(this.DT_Num_Auto_LC.Rows[0][4]);
        }


        public FRM_Livro_Caixa()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.BTN_Buscar, "Pesquisar");
        }

        private void FRM_Livro_Caixa_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Numeracao_Automatica();
        }
        
        private void FRM_Livro_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void dataLista_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            this.Saldo();
            
        }
        
        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            this.BuscarData();
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NLivro_Caixa.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("Ok"))
                            {
                                this.MensagemOk("A exclusão foi realizada com sucesso");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.CHK_Selecionar.Checked = false;
                    this.Mostrar();
                    this.Saldo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Lançar_Credito_Click(object sender, EventArgs e)
        {
            FRM_Lancar_Credito frm = FRM_Lancar_Credito.GetInstancia();
           
            frm.Show();
            frm.eNovo = true;

            string Config_Num_Auto = this.DT_Num_Auto_LC.Rows[0][5].ToString();

            if (Config_Num_Auto == "SIM")
            {
                //Incrementando para gerar novo número de venda
                Auxiliar_NA_Credito++;

                //passado novo numero de venda para o TextBox
                frm.TXB_Num_Doc.Text = "CRED" + Convert.ToString(Auxiliar_NA_Credito);
            }
        }

        private void BTN_Lançar_Debito_Click(object sender, EventArgs e)
        {
            FRM_Lancar_Debito frm = FRM_Lancar_Debito.GetInstancia();

            frm.Show();
            frm.eNovo = true;

            string Config_Num_Auto = this.DT_Num_Auto_LC.Rows[0][6].ToString();

            if (Config_Num_Auto == "SIM")
            {
                //Incrementando para gerar novo número de venda
                Auxiliar_NA_Debito++;

                //passado novo numero de venda para o TextBox
                frm.TXB_Num_Doc.Text = "DEB" + Convert.ToString(Auxiliar_NA_Debito);
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Selecionar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
                this.BTN_Deletar.Enabled = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;
            }
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Livro_Caixa frm = FRM_Tipo_Relatorio_Livro_Caixa.GetInstancia();
            frm.Show();
        }
    }
}
