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
    public partial class FRM_Venda : Form
    {
        private bool eNovo;
        private decimal totalPago = 0;
        private DataTable dtDetalhe;
        private string idvenda = "";

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Venda _Instancia;

        public static FRM_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Venda();
            }
            return _Instancia;
        }


        public FRM_Venda()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.btnBuscar, "Pesquisar");
            this.ttMensagem.SetToolTip(this.chkSelecionar, "Marque para Selecionar um registro");
            this.ttMensagem.SetToolTip(this.btnDeletar, "Deletar");
            this.ttMensagem.SetToolTip(this.btnImprimir, "Imprimir");

            this.txtId.Enabled = false;
            this.txtCliente.Enabled = false;
            this.txtFuncionario.Enabled = false;
            this.dtData.Enabled = false;
            this.txtComprovante.Enabled = false;
            this.txtNum_Comprovante.Enabled = false;
            this.TXB_Recebimento.Enabled = false;
            this.TXB_Valor_Entrada.Enabled = false;

            this.TXB_TotalPagar.ReadOnly = true;
            this.TXB_TotalPagar.BackColor = Color.WhiteSmoke;
            this.TXB_TotalPagar.ForeColor = Color.Green;

            this.TXB_Valor_Entrada.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Entrada.ForeColor = Color.Green;

            this.BTN_Sair.Enabled = false;
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


        //Limpar campos
        private void Limpar()
        {
            this.txtId.Text = string.Empty;
            this.txtComprovante.Text = string.Empty;
            this.txtNum_Comprovante.Text = string.Empty;
            this.txtCliente.Text = string.Empty;
            this.txtFuncionario.Text = string.Empty;
            this.TXB_Recebimento.Text = string.Empty;
            this.TXB_Valor_Entrada.Text = string.Empty;
            this.TXB_Juros_Card_Cred.Text = string.Empty;
            this.TXB_Juros_Cred_Loja.Text = string.Empty;
            this.TXB_Comissao_Paga.Text = string.Empty;
            this.TXB_TotalPagar.Text = "R$ 0,00";

            // Limpar Grid - dataListaDetalhes
            if(this.dataListaDetalhes.DataSource != null)
            {
                this.dataListaDetalhes.DataSource = null;
            }
            else
            {
                this.dataListaDetalhes.Rows.Clear();
            }


            // Limpar Grid - DGV_Formas_Pagamento
            if (this.DGV_Formas_Pagamento.DataSource != null)
            {
                this.DGV_Formas_Pagamento.DataSource = null;
            }
            else
            {
                this.DGV_Formas_Pagamento.Rows.Clear();
            }
        }


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.BTN_Sair.Enabled = true;
            }
            else
            {
                this.BTN_Sair.Enabled = false;
            }
        }


        //Metodo ocultar colunas do Grid
        private void FormatoColunas()
        {
            // Ocultar Colunas
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[3].Visible = false;
            this.dataLista.Columns[4].Visible = false;
            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[6].Visible = false;
            this.dataLista.Columns[7].Visible = false;
            this.dataLista.Columns[9].Visible = false;
            this.dataLista.Columns[10].Visible = false;
            this.dataLista.Columns[11].Visible = false;

            //Nome das Colunas
            this.dataLista.Columns[1].HeaderText = "Nº";

            // Formato Moeda
            this.dataLista.Columns[8].DefaultCellStyle.Format = "c";
        }


        //Metodo Alterar nome das coluns do Grid
        private void Exibicão_dataLista()
        {
            this.dataLista.Columns[2].HeaderText = "Data";
        }

        // Mostrar no Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NVenda.Mostrar();
            this.FormatoColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);

            // Mostrar Modo de exibição
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        // Buscar por Datas
        private void BuscarData()
        {
            this.dataLista.DataSource = NVenda.BuscarData(this.dtInicial.Value.ToString("dd/MM/yyyy"), this.dtFinal.Value.ToString("dd/MM/yyyy"));
            this.FormatoColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);

            // Mostrar Modo de exibição
            this.LB_Modo_Exibicao.Text = "Data";
        }

        // Mostrar Detalhes Entrada
        private void MostrarDetalheVenda()
        {
            this.dataListaDetalhes.DataSource = NVenda.MostrarDetalhes(txtId.Text);
            
        }

        // Mostrar Formas de Pagamento - VENDA
        private void Mostrar_Formas_Pagamento()
        {
            this.DGV_Formas_Pagamento.DataSource = NVenda.Mostrar_Formas_Pagamento_Venda(txtId.Text);

            // Ocultar Colunas
            this.DGV_Formas_Pagamento.Columns[0].Visible = false;
            this.DGV_Formas_Pagamento.Columns[1].Visible = false;

            // Nome da Coluna
            this.DGV_Formas_Pagamento.Columns[2].HeaderText = "Forma";
            this.DGV_Formas_Pagamento.Columns[3].HeaderText = "Valor Primário";
            this.DGV_Formas_Pagamento.Columns[4].HeaderText = "Valor Final";

            // Formato da Coluna
            this.DGV_Formas_Pagamento.Columns[3].DefaultCellStyle.Format = "c";
            this.DGV_Formas_Pagamento.Columns[4].DefaultCellStyle.Format = "c";

            this.Mostrar_Taxa_Juros_Parcel();
        }


        //Metodo tamanho das colunas do Grid - dataLista
        private void TamanhoColunas()
        {
            this.dataLista.Columns[2].Width = 90;
        }

      
        private void Mostrar_Taxa_Juros_Parcel()
        {
            DataTable Dados_Juros_Parcelamento = NConfig_Juros_Parcelamento.Mostrar();
            decimal Taxa_Card_Cred = Convert.ToDecimal(Dados_Juros_Parcelamento.Rows[0][1]);
            decimal Taxa_Cred_Loja = Convert.ToDecimal(Dados_Juros_Parcelamento.Rows[0][2]);
            string Status = Dados_Juros_Parcelamento.Rows[0][3].ToString();

            if (Status.Equals("SIM"))
            {
                foreach (DataGridViewRow row in DGV_Formas_Pagamento.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals("Cartão de Crédito") && Taxa_Card_Cred > 0)
                    {
                        this.TXB_Juros_Card_Cred.Text = Taxa_Card_Cred.ToString() + "% a.m.";
                    }
                    if (row.Cells[2].Value.ToString().Equals("Crediário da Loja") && Taxa_Cred_Loja > 0)
                    {
                        this.TXB_Juros_Cred_Loja.Text = Taxa_Cred_Loja.ToString() + "% a.m.";
                    }
                }
            }
        }

        private void FRM_Venda_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.botoes();
            this.txtId.ReadOnly = true;
            this.TamanhoColunas();
            this.Exibicão_dataLista();
            
        }

        private void FRM_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

    
        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.botoes();
            this.Limpar();
            this.totalPago = 0;
        }

     
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarData();
        }

     
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente Deseja deletar este Registro?", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {

                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NVenda.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("Ok"))
                            {
                                this.MensagemOk("Registro anulado com sucesso");

                                if (Convert.ToString(this.dataLista.CurrentRow.Cells[8].Value) == "A Vista")
                                {
                                    Codigo = Convert.ToString(this.dataLista.CurrentRow.Cells[5].Value);
                                    Resp = NLivro_Caixa.Excluir_UseNumDoc(Codigo);
                                }

                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.chkSelecionar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkSelecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelecionar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
                this.btnImprimir.Enabled = true;
                this.btnDeletar.Enabled = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
                this.btnImprimir.Enabled = false;
                this.btnDeletar.Enabled = false;

                foreach (DataGridViewRow _row in this.dataLista.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }


        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.botoes();
            this.Limpar();
        }

        private void dataListaDetalhes_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Formato de moeda 
            this.dataListaDetalhes.Columns[2].DefaultCellStyle.Format = "c";
            this.dataListaDetalhes.Columns[3].DefaultCellStyle.Format = "c";

            //Cor da Fonte
            this.dataListaDetalhes.Columns[0].DefaultCellStyle.ForeColor = Color.Black;
            this.dataListaDetalhes.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            this.dataListaDetalhes.Columns[2].DefaultCellStyle.ForeColor = Color.Black;
            this.dataListaDetalhes.Columns[3].DefaultCellStyle.ForeColor = Color.Black;

            //Tamanho das Colunas
            this.dataListaDetalhes.Columns[1].Width = 420;

            //Nome das Colunas
            this.dataListaDetalhes.Columns[0].HeaderText = "Quant.";
            this.dataListaDetalhes.Columns[2].HeaderText = "Preço";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            bool chave = false;
            foreach (DataGridViewRow row in dataLista.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    chave = true;
                    this.idvenda = row.Cells[1].Value.ToString();
                }
            }
            if (chave)
            {
                DataTable Dados_Parcelamento = NVenda.Mostrar_Formas_Pagamento_Venda(this.idvenda);

                bool trava = false;
                foreach (DataRow linha in Dados_Parcelamento.Rows)
                {
                    if (linha[2].ToString().Equals("Crediário da Loja"))
                    {
                        trava = true;
                    }
                }
                if (trava)
                {
                    FRM_Comp_Venda_Parcelado_Listagem frm = new FRM_Comp_Venda_Parcelado_Listagem();
                    frm.IdVenda = Convert.ToInt32(this.idvenda);
                    frm.ShowDialog();
                }
                else
                {
                    FRM_Comp_Venda_Demais_Formas_Pgto_Listagem frm = new FRM_Comp_Venda_Demais_Formas_Pgto_Listagem();
                    frm.IdVenda = Convert.ToInt32(this.idvenda);
                    frm.ShowDialog();
                }
            }
            else
            {
                this.MensagemErro("Selecione um registro");
            }
        }

        private void LB_Modo_Exibicao_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Modo_Exibicao.Text == "Mostrar Tudo")
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
            decimal valor;
            decimal entrada;
            decimal comissao_paga;

            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idvenda"].Value);
            this.txtCliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nome_completo"].Value);
            this.txtFuncionario.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Funcionário"].Value);
            this.dtData.Value = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            this.txtComprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprovante"].Value);
            this.txtNum_Comprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_comprovante"].Value);
            this.TXB_Recebimento.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["recebimento"].Value);

            entrada = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["valor_entrada"].Value);
            this.TXB_Valor_Entrada.Text = entrada.ToString("C");

            comissao_paga = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["comissao_paga"].Value);
            this.TXB_Comissao_Paga.Text = comissao_paga.ToString("C");

            valor = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["total"].Value);
            this.TXB_TotalPagar.Text = valor.ToString("C");

            this.MostrarDetalheVenda();
            this.Mostrar_Formas_Pagamento();
            this.BTN_Sair.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
