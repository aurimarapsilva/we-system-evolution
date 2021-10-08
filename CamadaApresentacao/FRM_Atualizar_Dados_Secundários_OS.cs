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
    public partial class FRM_Atualizar_Dados_Secundários_OS : Form
    {
        // Declarando Variaveis
        public bool eAtualizar = false;
        private DataTable dtProd_Serv;
        private decimal totalPago = 0;
        public string IdOS;    // Variavel para receber Id da OS

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Atualizar_Dados_Secundários_OS _Instancia;

        public static FRM_Atualizar_Dados_Secundários_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Atualizar_Dados_Secundários_OS();
            }
            return _Instancia;
        }

        public FRM_Atualizar_Dados_Secundários_OS()
        {
            InitializeComponent();
            this.TXB_Total_Geral.ReadOnly = true;
            this.TXB_Total_Geral.BackColor = Color.WhiteSmoke;
            this.TXB_Total_Geral.ForeColor = Color.Green;

            this.DGV_Select_Prod_Cod_Barra.Visible = false;

            
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
            this.TXB_Total_Geral.Text = "R$ 0,00";
            this.totalPago = 0;

            // Limpar Grid - DGV_Atualizador
            if (this.DGV_Atualizador.DataSource != null)
            {
                this.DGV_Atualizador.DataSource = null;
            }
            else
            {
                this.DGV_Atualizador.Rows.Clear();
            }
        }

        private void Limpar_Tudo()
        {
            this.TXB_Total_Geral.Text = "R$ 0,00";
            
            // Limpar Grid - DGV_Atualizador
            if (this.DGV_Atualizador.DataSource != null)
            {
                this.DGV_Atualizador.DataSource = null;
            }
            else
            {
                this.DGV_Atualizador.Rows.Clear();
            }
        }

        private void Encerrando_OPeracao()
        {
            this.botoes();
            this.Limpar();
            this.eAtualizar = false;
            this.totalPago = 0;
        } 


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eAtualizar)
            {
                this.BTN_Salvar.Enabled = true;
                this.BTN_Sair.Enabled = true;
            }
            else
            {
                this.BTN_Salvar.Enabled = false;
                this.BTN_Sair.Enabled = false;
            }
        }

        
        private void CriarTabela()
        {
            this.dtProd_Serv = new DataTable("Detalhe");
            this.dtProd_Serv.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.dtProd_Serv.Columns.Add("quant", System.Type.GetType("System.Decimal"));
            this.dtProd_Serv.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtProd_Serv.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.dtProd_Serv.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));

            this.DGV_Atualizador.DataSource = this.dtProd_Serv;

            //Ocultar Coluna do Grid
            this.DGV_Atualizador.Columns[1].Visible = false;

            //definir tamanho do Grid
            this.DGV_Atualizador.Columns[3].Width = 400;

            //Formatar Grid
            this.DGV_Atualizador.Columns[4].DefaultCellStyle.Format = "c";
            this.DGV_Atualizador.Columns[5].DefaultCellStyle.Format = "c";
        }

        //Metodo criar linha no Grid - dataListaDetalhes ao iniciar
        private void CriarLinha()
        {
            DataRow row = this.dtProd_Serv.NewRow();
            this.dtProd_Serv.Rows.Add(row);
        }

        // Metodo Pegar Prosutos para OS
        public void SetProduto(int idproduto, string descricao, decimal preco_venda)
        {
            bool salvar = true;
            foreach (DataGridViewRow linha in DGV_Atualizador.Rows)
            {
                if (linha.Cells[1].Value.Equals(idproduto))
                {
                    salvar = false;
                   
                    MessageBox.Show("Este produto ou serviço já foi adicionado a lista.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DGV_Atualizador.CurrentRow.Cells[3].ReadOnly = false;
                }
            }
            if (salvar)
            {
                if (this.DGV_Atualizador.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    this.DGV_Atualizador.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Atualizador.CurrentRow.Cells[2].Value = 1;
                    this.DGV_Atualizador.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Atualizador.CurrentRow.Cells[4].Value = preco_venda;
                }
                else
                {
                    this.DGV_Atualizador.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Atualizador.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Atualizador.CurrentRow.Cells[4].Value = preco_venda;
                }
            }
        }


        // Mostrar Produtos pelo Codigode Barras
        public void Selecionar_Produto_Codigo_Barra()
        {
            this.DGV_Select_Prod_Cod_Barra.DataSource = NProduto.Selecionar_Produto_Codigo_Barra_Venda(Convert.ToString(this.DGV_Atualizador.CurrentRow.Cells[3].Value));
        }


        private void MoveNext()
        {
            if (this.DGV_Atualizador.CurrentRow.Cells[2].Selected)
            {
                int index = this.DGV_Atualizador.CurrentRow.Index;

                this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[3];
            }
            else if (this.DGV_Atualizador.CurrentRow.Cells[3].Selected)
            {
                int index = this.DGV_Atualizador.CurrentRow.Index;

                this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[4];
            }
            else if (this.DGV_Atualizador.CurrentRow.Cells[4].Selected)
            {
                int index = this.DGV_Atualizador.CurrentRow.Index;

                this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[5];
            }
            else if (this.DGV_Atualizador.CurrentRow.Cells[5].Selected)
            {
                this.CriarLinha();

                int index = this.DGV_Atualizador.CurrentRow.Index + 1;
                this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[2];
            }
        }

        private void FRM_Atualizar_Dados_Secundários_OS_Load(object sender, EventArgs e)
        {
            this.CriarTabela();
            this.CriarLinha();
            
            int index = this.DGV_Atualizador.CurrentRow.Index;
            this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[2];

            TXB_Total_Geral.BackColor = Color.White;
            TXB_Total_Geral.ForeColor = Color.Red;
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            this.DGV_Atualizador.Focus();
            try
            {
                string resp = "";
                if (this.eAtualizar)
                {
                    // Selecionando ultima linha antes de salvar
                    int ultima_linha = this.DGV_Atualizador.Rows.Count - 1;
                    this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[ultima_linha].Cells[2];

                    // Excluir ultima linha em branco, caso haja
                    if (DGV_Atualizador.Rows.Count > 1 && DGV_Atualizador.CurrentRow.Cells[3].Value.ToString() == "" && DGV_Atualizador.CurrentRow.Cells[4].Value.ToString() == "" && DGV_Atualizador.CurrentRow.Cells[5].Value.ToString() == "")
                    {
                        int index = DGV_Atualizador.CurrentRow.Index;
                        DataGridViewRow row = DGV_Atualizador.Rows[index];
                        DGV_Atualizador.Rows.Remove(row);
                    }

                    for (int i = 0; i <= this.DGV_Atualizador.Rows.Count - 1; i++)
                    {
                        // Capturando Dados
                        int idproduto = Convert.ToInt32(this.DGV_Atualizador.Rows[i].Cells[1].Value);
                        decimal quant = Convert.ToDecimal(this.DGV_Atualizador.Rows[i].Cells[2].Value);
                        decimal preco_venda = Convert.ToDecimal(this.DGV_Atualizador.Rows[i].Cells[4].Value);

                        // Efetuar atualização
                        resp = NDetalhe_OS.Inserir(Convert.ToInt32(this.IdOS), idproduto, quant, preco_venda);
                    } 
                }
               
                if (resp.Equals("Ok"))
                {
                    this.MensagemOk("Atualização efetuada com sucesso");
                }
                else
                {
                    this.MensagemErro(resp);
                }
                this.Limpar_Tudo();
                this.eAtualizar = false;
                this.botoes();

                FRM_OS frm = FRM_OS.GetInstancia();
                frm.Mostrar();
                frm.MostrarDetalhes();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DGV_Atualizador_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.MoveNext();
            this.DGV_Atualizador.CurrentRow.Cells[2].ReadOnly = false;
        }

        private void FRM_Atualizar_Dados_Secundários_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            FRM_OS frm = FRM_OS.GetInstancia();
            frm.MostrarDetalhes();
            frm.Mostrar();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Limpar_Tudo();
            this.eAtualizar = false;
            this.botoes();

            FRM_OS frm = FRM_OS.GetInstancia();
            frm.Mostrar();

            this.Close();
        }

        private void FRM_Atualizar_Dados_Secundários_OS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && this.DGV_Atualizador.CurrentRow.Cells[3].Selected)
            {
                this.DGV_Atualizador.CurrentRow.Cells[3].ReadOnly = true;

                FRM_Buscar_Produto_Atualizar_OS frm = FRM_Buscar_Produto_Atualizar_OS.GetInstancia();
                frm.txtBuscar.Text = this.DGV_Atualizador.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();
            }


            if (this.DGV_Atualizador.CurrentRow.Cells[4].Selected && Convert.ToString(this.DGV_Atualizador.CurrentRow.Cells[1].Value) != "" && Convert.ToString(this.DGV_Atualizador.CurrentRow.Cells[3].Value) != "")
            {
                decimal cell1 = Convert.ToDecimal(DGV_Atualizador.CurrentRow.Cells[2].Value);

                decimal cell2 = Convert.ToDecimal(DGV_Atualizador.CurrentRow.Cells[4].Value);

                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    DGV_Atualizador.CurrentRow.Cells[5].Value = cell1 * cell2;

                    string valor = "";
                    this.totalPago = 0;

                    if (Convert.ToString(DGV_Atualizador.CurrentRow.Cells[5].Value) != "")
                    {
                        valor = DGV_Atualizador.CurrentRow.Cells[5].Value.ToString();

                        if (!valor.Equals(""))
                        {
                            for (int i = 0; i <= DGV_Atualizador.RowCount - 1; i++)
                            {
                                if (Convert.ToString(DGV_Atualizador.Rows[i].Cells[5].Value) != "")
                                {
                                    this.totalPago += Convert.ToDecimal(DGV_Atualizador.Rows[i].Cells[5].Value);
                                }
                            }
                            TXB_Total_Geral.Text = this.totalPago.ToString("C");
                        }
                    }
                }
            }
        }

        private void DGV_Atualizador_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Selecionar_Produto_Codigo_Barra();

            if (this.DGV_Select_Prod_Cod_Barra.Rows.Count == 1)
            {
                if (this.DGV_Atualizador.CurrentRow.Cells[3].Selected && e.KeyCode == Keys.Enter)
                {
                    // Pegando Dados
                    int idproduto = Convert.ToInt32(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[0].Value);
                    string descricao = Convert.ToString(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[1].Value);
                    decimal preco_venda = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[2].Value);

                    string valor;

                    bool salvar = true;
                    foreach (DataGridViewRow linha in DGV_Atualizador.Rows)
                    {
                        if (linha.Cells[1].Value.Equals(idproduto))
                        {
                            salvar = false;
                            int row_atual = linha.Index;
                            decimal qtd = Convert.ToDecimal(DGV_Atualizador.Rows[row_atual].Cells[2].Value);
                            DGV_Atualizador.Rows[row_atual].Cells[2].Value = qtd + 1;
                            decimal qtd_atual = Convert.ToDecimal(DGV_Atualizador.Rows[row_atual].Cells[2].Value);
                            decimal novo_subtotal = qtd_atual * preco_venda;
                            this.totalPago = 0;
                            DGV_Atualizador.Rows[row_atual].Cells[5].Value = novo_subtotal;
                            for (int i = 0; i <= DGV_Atualizador.RowCount - 1; i++)
                            {
                                if (Convert.ToString(DGV_Atualizador.Rows[i].Cells[5].Value) != "")
                                {
                                    this.totalPago += Convert.ToDecimal(DGV_Atualizador.Rows[i].Cells[5].Value);
                                }
                            }
                            TXB_Total_Geral.Text = this.totalPago.ToString("C");
                            DGV_Atualizador.CurrentRow.Cells[3].Value = "";
                        }
                    }
                    if (salvar)
                    {
                        // Exibindo Dados no Grid Atualizador Conforme situação
                        if (this.DGV_Atualizador.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            this.DGV_Atualizador.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Atualizador.CurrentRow.Cells[2].Value = 1;
                            this.DGV_Atualizador.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Atualizador.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        else
                        {
                            this.DGV_Atualizador.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Atualizador.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Atualizador.CurrentRow.Cells[4].Value = preco_venda;
                        }

                        int index = this.DGV_Atualizador.CurrentRow.Index;
                        this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[4];

                        if (DGV_Atualizador.CurrentRow.Cells[4].Selected)
                        {
                            decimal cell1 = Convert.ToDecimal(DGV_Atualizador.CurrentRow.Cells[2].Value);

                            decimal cell2 = Convert.ToDecimal(DGV_Atualizador.CurrentRow.Cells[4].Value);

                            if (cell1.ToString() != "" && cell2.ToString() != "")
                            {
                                DGV_Atualizador.CurrentRow.Cells[5].Value = cell1 * cell2;

                                valor = "";
                                this.totalPago = 0;

                                if (Convert.ToString(DGV_Atualizador.CurrentRow.Cells[5].Value) != "")
                                {
                                    valor = DGV_Atualizador.CurrentRow.Cells[5].Value.ToString();

                                    if (!valor.Equals(""))
                                    {
                                        for (int i = 0; i <= DGV_Atualizador.RowCount - 1; i++)
                                        {
                                            if (Convert.ToString(DGV_Atualizador.Rows[i].Cells[5].Value) != "")
                                            {
                                                this.totalPago += Convert.ToDecimal(DGV_Atualizador.Rows[i].Cells[5].Value);
                                            }
                                        }
                                        TXB_Total_Geral.Text = this.totalPago.ToString("C");

                                        this.CriarLinha();
                                        index = this.DGV_Atualizador.CurrentRow.Index + 1;
                                        this.DGV_Atualizador.CurrentCell = this.DGV_Atualizador.Rows[index].Cells[2];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

       
        private void DGV_Atualizador_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nome das Colunas
            this.DGV_Atualizador.Columns[2].HeaderText = "Quant";
            this.DGV_Atualizador.Columns[3].HeaderText = "Descrição";
            this.DGV_Atualizador.Columns[4].HeaderText = "Valor Unit.";
            this.DGV_Atualizador.Columns[5].HeaderText = "Subtotal";
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.DGV_Atualizador.CurrentRow.Cells[2].Selected && this.eAtualizar)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void DGV_Atualizador_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
        }
    }
}
