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
    public partial class FRM_Entrada : Form
    {
        private bool eNovo;
        private DataTable dtDetalhe;
        public decimal totalPago = 0;
        public int IdFuncionario;

        //Variaveis para receber conteudo do Grid - frmVer_Produto_Entrada
        public int IdProduto;
        public string Produto;
        public decimal Preco_Custo;

        //variaveis para receber conteudo do Grid - FRM_Entrada dataListaDetalhes
        private decimal Quant;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Entrada _Instancia;

        public static FRM_Entrada GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Entrada();
            }
            return _Instancia;
        }

        public FRM_Entrada()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.cbFornecedor, "Selecione o Fornecedor");
            this.ttMensagem.SetToolTip(this.cbTipo_Comprovante, "Selecione o tipo de conprovante");
            this.ttMensagem.SetToolTip(this.txtNum_Comprovante, "Informe o número do comprovante");
            this.ComboFornecedor();
            this.CB_Tipo_Compra.SelectedIndex = 0;
            this.DGV_Select_Prod_Cod_Barra.Visible = false;
            this.TXB_TotalPagar.BackColor = Color.WhiteSmoke;
            this.TXB_TotalPagar.ForeColor = Color.Green;
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
            this.txtNum_Comprovante.Text = string.Empty;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            this.CriarTabela();
        }


        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.dtData.Enabled = valor;
            this.cbFornecedor.Enabled = valor;
            this.cbTipo_Comprovante.Enabled = valor;
            this.txtNum_Comprovante.ReadOnly = !valor;
            this.CB_Tipo_Compra.Enabled = valor;
            this.CHK_Selecionar.Enabled = valor;

            if (valor)
            {
                this.txtNum_Comprovante.BackColor = Color.White;
                this.dataListaDetalhes.BackgroundColor = Color.White;
            }
            else
            {
                this.txtNum_Comprovante.BackColor = Color.WhiteSmoke;
                this.dataListaDetalhes.BackgroundColor = Color.White;
            }
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        //Metodo Formatação das Colunas
        private void FormatoColunas()
        {
            // Ocultar colunas
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;

            // Nome das Coluna
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "Fornecedor";
            this.dataLista.Columns[4].HeaderText = "Tipo de Comprovante";
            this.dataLista.Columns[5].HeaderText = "Nº do Comprovante";
            this.dataLista.Columns[6].HeaderText = "Status";
            this.dataLista.Columns[7].HeaderText = "Tipo de Compra";
            this.dataLista.Columns[8].HeaderText = "Funcionário";

            //Formato Moeda
            this.dataLista.Columns[9].DefaultCellStyle.Format = "c";
        }

        // Mostrar no Grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NEntrada.Mostrar();
            this.FormatoColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        // Buscar por Datas
        private void BuscarData()
        {
            this.dataLista.DataSource = NEntrada.BuscarData(this.dtInicial.Value.ToString("dd/MM/yyyy"), this.dtFinal.Value.ToString("dd/MM/yyyy"));
            this.FormatoColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        // Mostrar Detalhes Entrada
        private void MostrarDetalheEntrada()
        {
            // Fonte de dados
            this.dataListaDetalhes.DataSource = NEntrada.MostrarDetalhes(txtId.Text);

            // Ocultar Colunas
            this.dataListaDetalhes.Columns[1].Visible = false;

            // Tamanho das Colunas
            this.dataListaDetalhes.Columns[3].Width = 510;
        }


        // Mostrar Produtos pelo Codigode Barras
        public void Selecionar_Produto_Codigo_Barra()
        {
            if (this.eNovo)
            {
                this.DGV_Select_Prod_Cod_Barra.DataSource = NProduto.Selecionar_Produto_Codigo_Barra_Entrada(Convert.ToString(this.dataListaDetalhes.CurrentRow.Cells[3].Value));
            }
        }


        private void MoveNext()
        {
            if (this.eNovo)
            {
                if (this.dataListaDetalhes.CurrentRow.Cells[2].Selected)
                {
                    int index = this.dataListaDetalhes.CurrentRow.Index;

                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
                }
                else if (this.dataListaDetalhes.CurrentRow.Cells[3].Selected)
                {
                    int index = this.dataListaDetalhes.CurrentRow.Index;

                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[4];
                }
                else if (this.dataListaDetalhes.CurrentRow.Cells[4].Selected)
                {
                    // Calculando qual é a ultima linha do grid
                    int ultima_linha = this.dataListaDetalhes.Rows.Count - 1;

                    // Fazendo analise de situação
                    if (this.dataListaDetalhes.Rows[ultima_linha].Cells[2].Value.ToString() == "" && this.dataListaDetalhes.Rows[ultima_linha].Cells[3].Value.ToString() == "" && this.dataListaDetalhes.Rows[ultima_linha].Cells[4].Value.ToString() == "" && this.dataListaDetalhes.Rows[ultima_linha].Cells[5].Value.ToString() == "")
                    {
                        // Remover ultima linha vazia para não atrapalhar os calculos
                        this.dataListaDetalhes.Rows.RemoveAt(ultima_linha);

                        // Efetuando Calculos
                        string valor = "";
                        decimal cell1 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[2].Value);

                        decimal cell2 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[4].Value);

                        if (cell1.ToString() != "" && cell2.ToString() != "")
                        {
                            dataListaDetalhes.CurrentRow.Cells[5].Value = cell1 * cell2;

                            valor = "";
                            this.totalPago = 0;

                            if (Convert.ToString(dataListaDetalhes.CurrentRow.Cells[5].Value) != "")
                            {
                                valor = dataListaDetalhes.CurrentRow.Cells[5].Value.ToString();

                                if (!valor.Equals(""))
                                {
                                    for (int i = 0; i <= dataListaDetalhes.RowCount - 1; i++)
                                    {
                                        if (Convert.ToString(dataListaDetalhes.Rows[i].Cells[5].Value) != "")
                                        {
                                            this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                        }
                                    }
                                    TXB_TotalPagar.Text = this.totalPago.ToString("C");

                                    int linha = this.dataListaDetalhes.CurrentRow.Index;
                                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[linha].Cells[5];
                                }
                            }
                        }
                    }
                    else
                    {
                        // Efetuando Calculos
                        if (this.dataListaDetalhes.CurrentRow.Cells[2].Value.ToString() != "" && this.dataListaDetalhes.CurrentRow.Cells[4].Value.ToString() != "")
                        {
                            string valor = "";
                            decimal cell1 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[2].Value);

                            decimal cell2 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[4].Value);

                            if (cell1.ToString() != "" && cell2.ToString() != "")
                            {
                                dataListaDetalhes.CurrentRow.Cells[5].Value = cell1 * cell2;

                                valor = "";
                                this.totalPago = 0;

                                if (Convert.ToString(dataListaDetalhes.CurrentRow.Cells[5].Value) != "")
                                {
                                    valor = dataListaDetalhes.CurrentRow.Cells[5].Value.ToString();

                                    if (!valor.Equals(""))
                                    {
                                        for (int i = 0; i <= dataListaDetalhes.RowCount - 1; i++)
                                        {
                                            if (Convert.ToString(dataListaDetalhes.Rows[i].Cells[5].Value) != "")
                                            {
                                                this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                            }
                                        }
                                        TXB_TotalPagar.Text = this.totalPago.ToString("C");

                                        int linha = this.dataListaDetalhes.CurrentRow.Index;
                                        this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[linha].Cells[5];
                                    }
                                }
                            }
                        }
                    }
                }
                else if (this.dataListaDetalhes.CurrentRow.Cells[5].Selected)
                {
                    this.CriarLinha();

                    int index = this.dataListaDetalhes.CurrentRow.Index + 1;
                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
                }
            }
        }


        public void Deletar_Mais_1_Item(decimal quant_deletar, int Linha_Atual, decimal Quant_Atual, decimal Valor_Item_Deletado, decimal Subtotal_Atual)
        {
            decimal valor_item_deletado = 0;
            decimal valor_atualizado = 0;
            decimal subtotal_atual = 0;
            decimal subtotal_deletado = 0;
            decimal quant_atual = 0;

            // Capturando quantidade atual
            quant_atual = Quant_Atual;

            // Capturando valor unitario do item a ser deletado
            valor_item_deletado = Valor_Item_Deletado;

            // Capturando subtotal atual
            subtotal_atual = Subtotal_Atual;

            // Calculando novo total
            // Inicio
            subtotal_deletado = quant_deletar * valor_item_deletado;

            // Atualizar valores da linha do grid
            this.dataListaDetalhes.Rows[Linha_Atual].Cells[2].Value = quant_atual - quant_deletar;
            this.dataListaDetalhes.Rows[Linha_Atual].Cells[5].Value = subtotal_atual - subtotal_deletado;

            // Final
            valor_atualizado = this.totalPago - subtotal_deletado;
            this.totalPago = valor_atualizado;

            // Mostrando novo total
            this.TXB_TotalPagar.Text = totalPago.ToString("C");

            // Selecionar ultima linha
            int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[3];
        }

        private void ComboFornecedor()
        {
            cbFornecedor.DataSource = NFornecedor.Mostrar();
            cbFornecedor.ValueMember = "Idfornecedor";
            cbFornecedor.DisplayMember = "empresa";
        }

        
        //Metodo criar linha no Grid - dataListaDetalhes ao iniciar
        private void CriarLinha()
        {
            DataRow row = this.dtDetalhe.NewRow();
            this.dtDetalhe.Rows.Add(row);
        }


        //Metodo tamanho das colunas do Grid - dataLista
        private void TamanhoColunas()
        {
            this.dataLista.Columns[2].Width = 90;
            this.dataLista.Columns[3].Width = 230;
            this.dataLista.Columns[4].Width = 120;
            this.dataLista.Columns[5].Width = 120;
            this.dataLista.Columns[6].Width = 93;
            this.dataLista.Columns[7].Width = 93;
        }


        // Metodo Pegar Prosutos para entrada
        public void SetProduto(int idproduto, string descricao, decimal preco_custo)
        {
            if (this.dataListaDetalhes.CurrentRow.Cells[2].Value.ToString() == "") 
            {
                this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                this.dataListaDetalhes.CurrentRow.Cells[2].Value = 1;
                this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_custo;
            }
            else
            {
                this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_custo;
            }
        }


        public void SetFab_Venc(string fabricacao, string vencimento, DateTime antecipacao_venc, bool habilitado)
        {
            if (habilitado)
            {
                this.dataListaDetalhes.CurrentRow.Cells[6].Value = fabricacao;
                this.dataListaDetalhes.CurrentRow.Cells[7].Value = vencimento;
                this.dataListaDetalhes.CurrentRow.Cells[8].Value = antecipacao_venc;
            }
            else
            {
                this.dataListaDetalhes.CurrentRow.Cells[6].Value = "INDETERMINADA";
                this.dataListaDetalhes.CurrentRow.Cells[7].Value = "INDETERMINADA";
                this.dataListaDetalhes.CurrentRow.Cells[8].Value = antecipacao_venc;
            }
        }


        private void FRM_Entrada_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.cbTipo_Comprovante.SelectedIndex = 0;
            this.txtId.ReadOnly = true;
            this.TamanhoColunas();
        }

        private void FRM_Entrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Produto frm = FRM_Produto.GetInstancia();
            frm.Mostrar();

            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja deletar os registros?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {

                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NEntrada.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("Ok"))
                            {
                                this.MensagemOk("Registro deletado com sucesso");

                                if (Convert.ToString(this.dataLista.CurrentRow.Cells[7].Value) == "A Vista")
                                {
                                    Codigo = Convert.ToString(this.dataLista.CurrentRow.Cells[5].Value);
                                    Resp = NLivro_Caixa.Excluir_UseNumDoc(Codigo);
                                }
                            }
                            else
                            {
                                this.MensagemErro("Não é possível excluir esta entrada, pois há contas a pagar referentes a mesma.");
                            }
                        }
                    }
                    this.chkAnular.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void chkAnular_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAnular.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }


        private void CriarTabela()
        {
            this.dtDetalhe = new DataTable("Detalhe");
            this.dtDetalhe.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("quant", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("preco_custo", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("fabricacao", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("vencimento", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("antecipacao_venc", System.Type.GetType("System.DateTime"));

            //Adicionar Fonte de Dados ao Grid
            this.dataListaDetalhes.DataSource = this.dtDetalhe;

            // Ocultar Colunas
            this.dataListaDetalhes.Columns[1].Visible = false;
            this.dataListaDetalhes.Columns[6].Visible = false;
            this.dataListaDetalhes.Columns[7].Visible = false;
            this.dataListaDetalhes.Columns[8].Visible = false;

            // Tamanho das Colunas
            this.dataListaDetalhes.Columns[3].Width = 510;
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo)
            {
                this.txtNum_Comprovante.BackColor = Color.LemonChiffon;
                this.dataListaDetalhes.BackgroundColor = Color.LemonChiffon;
            }
            else
            {
                this.txtNum_Comprovante.BackColor = Color.WhiteSmoke;
                this.dataListaDetalhes.BackgroundColor = Color.White;
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.dataListaDetalhes.Focus();
            this.eNovo = true;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.totalPago = 0;
            this.CriarTabela();
            this.CriarLinha();

            int index = this.dataListaDetalhes.CurrentRow.Index;
            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtNum_Comprovante.Text == string.Empty || this.dataListaDetalhes.Rows.Count == 0)
                {
                    this.MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eNovo)
                    {
                        // Selecionando ultima linha antes de salvar
                        int ultima_linha = this.dataListaDetalhes.Rows.Count - 1;
                        this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[ultima_linha].Cells[2];

                        // Excluir ultima linha em branco, caso haja
                        if (dataListaDetalhes.Rows.Count > 1 && dataListaDetalhes.CurrentRow.Cells[3].Value.ToString() == "" && dataListaDetalhes.CurrentRow.Cells[4].Value.ToString() == "" && dataListaDetalhes.CurrentRow.Cells[5].Value.ToString() == "")
                        {
                            int index = dataListaDetalhes.CurrentRow.Index;
                            DataGridViewRow row = dataListaDetalhes.Rows[index];
                            dataListaDetalhes.Rows.Remove(row);
                        }

                        // Executar Metodo de Salvar
                        resp = NEntrada.Inserir(1, dtData.Value, Convert.ToInt32(cbFornecedor.SelectedValue),
                            "EMITIDO", cbTipo_Comprovante.Text, txtNum_Comprovante.Text, CB_Tipo_Compra.Text, this.IdFuncionario, dtDetalhe);
                    }


                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");

                            // Se a compra for A Vista
                            if (this.CB_Tipo_Compra.Text == "A Vista")
                            {
                                // Se a compra for realizada: Inserir no LIVRO CAIXA
                                resp = NLivro_Caixa.Inserir(dtData.Value, "COMPRA DE MERCADORIAS", txtNum_Comprovante.Text, Convert.ToDecimal("0,00"), totalPago);
                            }
                        }

                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                    if (resp.Equals("Ok"))
                    {
                        if (this.CB_Tipo_Compra.Text == "Parcelado")
                        {
                            FRM_Gerar_Contas_Pagar frm = FRM_Gerar_Contas_Pagar.GetInstancia();
                            frm.eNovo = true;
                            frm.idfornecedor = Convert.ToInt32(this.cbFornecedor.SelectedValue);
                            frm.fornecedor_nome = this.cbFornecedor.Text;
                            frm.TXB_Num_Doc.Text = this.txtNum_Comprovante.Text;
                            frm.DT_Vencimento.Value = this.dtData.Value;
                            frm.TXB_Valor.Text = this.totalPago.ToString();
                            frm.Show();
                        }
                    }

                    this.eNovo = false;

                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                    this.Alerta_Campos_Obrigatorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarData();
        }

        private void dataListaDetalhes_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.MoveNext();
        }

        private void dataListaDetalhes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.eNovo)
            {
                // Nome das Colunas
                this.dataListaDetalhes.Columns[2].HeaderText = "Quant";
                this.dataListaDetalhes.Columns[3].HeaderText = "Descrição";
                this.dataListaDetalhes.Columns[4].HeaderText = "Valor Unit.";
                this.dataListaDetalhes.Columns[5].HeaderText = "Subtotal";
                this.dataListaDetalhes.Columns[6].HeaderText = "Fabricação";
                this.dataListaDetalhes.Columns[7].HeaderText = "Vencimento";

                // Formato Moeda 
                this.dataListaDetalhes.Columns[4].DefaultCellStyle.Format = "c";
                this.dataListaDetalhes.Columns[5].DefaultCellStyle.Format = "c";
            }
            else
            {
                // Nome das Colunas
                this.dataListaDetalhes.Columns[2].HeaderText = "Quant";
                this.dataListaDetalhes.Columns[3].HeaderText = "Descrição";
                this.dataListaDetalhes.Columns[4].HeaderText = "Fabricação";
                this.dataListaDetalhes.Columns[5].HeaderText = "Vencimento";
                this.dataListaDetalhes.Columns[6].HeaderText = "Valor Unit.";
                this.dataListaDetalhes.Columns[7].HeaderText = "Subtotal";

                // Formato Moeda 
                this.dataListaDetalhes.Columns[6].DefaultCellStyle.Format = "c";
                this.dataListaDetalhes.Columns[7].DefaultCellStyle.Format = "c";
            }
        }

        private void dataListaDetalhes_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Selecionar_Produto_Codigo_Barra();

            if (this.DGV_Select_Prod_Cod_Barra.Rows.Count == 1)
            {
                if (this.dataListaDetalhes.CurrentRow.Cells[3].Selected && e.KeyCode == Keys.Enter && this.eNovo)
                {
                    // Pegando Dados
                    int idproduto = Convert.ToInt32(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[0].Value);
                    string descricao = Convert.ToString(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[1].Value);
                    decimal preco_venda = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[2].Value);

                    string valor;

                    bool salvar = true;
                    foreach (DataGridViewRow linha in dataListaDetalhes.Rows)
                    {
                        if (linha.Cells[1].Value.Equals(idproduto))
                        {
                            salvar = false;
                            int row_atual = linha.Index;
                            decimal qtd = Convert.ToDecimal(dataListaDetalhes.Rows[row_atual].Cells[2].Value);
                            dataListaDetalhes.Rows[row_atual].Cells[2].Value = qtd + 1;
                            decimal qtd_atual = Convert.ToDecimal(dataListaDetalhes.Rows[row_atual].Cells[2].Value);
                            decimal novo_subtotal = qtd_atual * preco_venda;
                            this.totalPago = 0;
                            dataListaDetalhes.Rows[row_atual].Cells[5].Value = novo_subtotal;
                            for (int i = 0; i <= dataListaDetalhes.RowCount - 1; i++)
                            {
                                if (Convert.ToString(dataListaDetalhes.Rows[i].Cells[5].Value) != "")
                                {
                                    this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                }
                            }
                            TXB_TotalPagar.Text = this.totalPago.ToString("C");
                            dataListaDetalhes.CurrentRow.Cells[3].Value = "";
                        }
                    }
                    if (salvar)
                    {
                        // Exibindo Dados no Grid Atualizador Conforme situação
                        if (this.dataListaDetalhes.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                            this.dataListaDetalhes.CurrentRow.Cells[2].Value = 1;
                            this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                            this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        else
                        {
                            this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                            this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                            this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        

                        int index = this.dataListaDetalhes.CurrentRow.Index;
                        this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[4];
                    }

                    FRM_Inserir_Fab_Venc Fab_Venc = FRM_Inserir_Fab_Venc.GetInstancia();
                    Fab_Venc.Show();
                }
            }
        }

        private void FRM_Entrada_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                try
                {
                    string resp = "";
                    if (this.txtNum_Comprovante.Text == string.Empty || this.dataListaDetalhes.Rows.Count == 0)
                    {
                        this.MensagemErro("Preencha todos os campos obrigatórios.");
                        this.Alerta_Campos_Obrigatorios();
                    }
                    else
                    {
                        if (this.eNovo)
                        {
                            // Selecionando ultima linha antes de salvar
                            int ultima_linha = this.dataListaDetalhes.Rows.Count - 1;
                            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[ultima_linha].Cells[2];

                            // Excluir ultima linha em branco, caso haja
                            if (dataListaDetalhes.Rows.Count > 1 && dataListaDetalhes.CurrentRow.Cells[3].Value.ToString() == "" && dataListaDetalhes.CurrentRow.Cells[4].Value.ToString() == "" && dataListaDetalhes.CurrentRow.Cells[5].Value.ToString() == "")
                            {
                                int index = dataListaDetalhes.CurrentRow.Index;
                                DataGridViewRow row = dataListaDetalhes.Rows[index];
                                dataListaDetalhes.Rows.Remove(row);
                            }

                            // Executar Metodo de Salvar
                            resp = NEntrada.Inserir(1, dtData.Value, Convert.ToInt32(cbFornecedor.SelectedValue),
                                "EMITIDO", cbTipo_Comprovante.Text, txtNum_Comprovante.Text, CB_Tipo_Compra.Text, this.IdFuncionario, dtDetalhe);
                        }


                        if (resp.Equals("Ok"))
                        {
                            if (this.eNovo)
                            {
                                this.MensagemOk("Registro salvo com sucesso");

                                // Se a compra for A Vista
                                if (this.CB_Tipo_Compra.Text == "A Vista")
                                {
                                    // Se a compra for realizada: Inserir no LIVRO CAIXA
                                    resp = NLivro_Caixa.Inserir(dtData.Value, "COMPRA DE MERCADORIAS", txtNum_Comprovante.Text, Convert.ToDecimal("0,00"), totalPago);
                                }
                            }

                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }
                        if (resp.Equals("Ok"))
                        {
                            if (this.CB_Tipo_Compra.Text == "Parcelado")
                            {
                                FRM_Gerar_Contas_Pagar frm = FRM_Gerar_Contas_Pagar.GetInstancia();
                                frm.eNovo = true;
                                frm.idfornecedor = Convert.ToInt32(this.cbFornecedor.SelectedValue);
                                frm.fornecedor_nome = this.cbFornecedor.Text;
                                frm.TXB_Num_Doc.Text = this.txtNum_Comprovante.Text;
                                frm.DT_Vencimento.Value = this.dtData.Value;
                                frm.TXB_Valor.Text = this.totalPago.ToString();
                                frm.Show();
                            }
                        }

                        this.eNovo = false;

                        this.botoes();
                        this.Limpar();
                        this.Mostrar();
                        this.Alerta_Campos_Obrigatorios();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else if (e.KeyCode == Keys.Insert && this.dataListaDetalhes.CurrentRow.Cells[3].Selected)
            {
                this.dataListaDetalhes.CurrentRow.Cells[3].ReadOnly = true;

                FRM_Ver_Produto_Entrada frm = FRM_Ver_Produto_Entrada.GetInstancia();
                frm.txtBuscar.Text = this.dataListaDetalhes.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.Delete && this.BTN_Deletar_Item.Enabled)
            {
                try
                {
                    foreach (DataGridViewRow row in dataListaDetalhes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            decimal valor_item_deletado = 0;
                            decimal valor_atualizado = 0;
                            decimal subtotal_atualizado = 0;

                            DialogResult Opcao;
                            Opcao = MessageBox.Show("Realmente deseja deletar intem(s) da lista?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Opcao == DialogResult.Yes)
                            {
                                decimal quant_atual = Convert.ToDecimal(this.dataListaDetalhes.CurrentRow.Cells[2].Value);
                                if (quant_atual == 1)
                                {
                                    // Pegando Valor do item a ser deletado
                                    valor_item_deletado = Convert.ToDecimal(this.dataListaDetalhes.CurrentRow.Cells[4].Value);

                                    // Calculando novo total
                                    valor_atualizado = this.totalPago - valor_item_deletado;
                                    this.totalPago = valor_atualizado;

                                    // Mostrando novo total
                                    this.TXB_TotalPagar.Text = this.totalPago.ToString("C");

                                    // Deletar item
                                    int total_registros = this.dataListaDetalhes.Rows.Count - 1;
                                    int index = dataListaDetalhes.CurrentRow.Index;

                                    if (index == total_registros)
                                    {
                                        this.dataListaDetalhes.Rows[index].Cells[2].Value = "";
                                        this.dataListaDetalhes.Rows[index].Cells[3].Value = "";
                                        this.dataListaDetalhes.Rows[index].Cells[4].Value = "";
                                        this.dataListaDetalhes.Rows[index].Cells[5].Value = "";
                                    }
                                    else
                                    {
                                        DataGridViewRow linha = dataListaDetalhes.Rows[index];
                                        dataListaDetalhes.Rows.Remove(linha);
                                    }

                                    // Selecionar ultima linha
                                    int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
                                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[3];

                                    this.dataListaDetalhes.Focus();
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else if (quant_atual > 1)
                                {
                                    FRM_Deletar_Mais_1_Item_Entrada frm = FRM_Deletar_Mais_1_Item_Entrada.GetInstancia();
                                    frm.ShowDialog();
                                }
                            }
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message + erro.StackTrace);
                }
            }
        }

        private void BTN_Deletar_Item_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataListaDetalhes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        decimal valor_item_deletado = 0;
                        decimal valor_atualizado = 0;
                        decimal subtotal_atualizado = 0;

                        DialogResult Opcao;
                        Opcao = MessageBox.Show("Realmente deseja deletar intem(s) da lista?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Opcao == DialogResult.Yes)
                        {
                            decimal quant_atual = Convert.ToDecimal(row.Cells[2].Value);
                            if (quant_atual == 1)
                            {
                                // Pegando Valor do item a ser deletado
                                valor_item_deletado = Convert.ToDecimal(row.Cells[4].Value);

                                // Calculando novo total
                                valor_atualizado = this.totalPago - valor_item_deletado;
                                this.totalPago = valor_atualizado;

                                // Mostrando novo total
                                this.TXB_TotalPagar.Text = this.totalPago.ToString("C");

                                // Deletar item
                                int total_registros = this.dataListaDetalhes.Rows.Count - 1;
                                int index = row.Index;

                                if (index == total_registros)
                                {
                                    DataGridViewRow linha = dataListaDetalhes.Rows[index];
                                    dataListaDetalhes.Rows.Remove(linha);

                                    this.CriarLinha();
                                }
                                else
                                {
                                    DataGridViewRow linha = dataListaDetalhes.Rows[index];
                                    dataListaDetalhes.Rows.Remove(linha);
                                }

                                // Selecionar ultima linha
                                int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
                                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[3];

                                this.dataListaDetalhes.Focus();
                                this.CHK_Selecionar.Checked = false;
                            }
                            else if (quant_atual > 1)
                            {
                                FRM_Deletar_Mais_1_Item_Entrada frm = FRM_Deletar_Mais_1_Item_Entrada.GetInstancia();
                                frm.linha_atual = row.Index;
                                frm.quant_atual = Convert.ToDecimal(row.Cells[2].Value);
                                frm.valor_item_deletado = Convert.ToDecimal(row.Cells[4].Value);
                                frm.subtotal_atual = Convert.ToDecimal(row.Cells[5].Value);
                                frm.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void dataListaDetalhes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListaDetalhes.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)dataListaDetalhes.Rows[e.RowIndex].Cells["Selecionar"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.dataListaDetalhes.Columns[0].Visible = true;
                this.BTN_Deletar_Item.Enabled = true;

            }
            else
            {
                this.dataListaDetalhes.Columns[0].Visible = false;
                this.BTN_Deletar_Item.Enabled = false;

                foreach (DataGridViewRow _row in this.dataListaDetalhes.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal valor;

            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["identrada"].Value);
            this.cbFornecedor.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["fornecedor"].Value);
            this.dtData.Value = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            this.cbTipo_Comprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprovante"].Value);
            this.txtNum_Comprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_comprovante"].Value);
            this.CB_Tipo_Compra.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_compra"].Value);
            valor = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["total"].Value);

            this.TXB_TotalPagar.Text = valor.ToString("C");

            this.MostrarDetalheEntrada();
            this.btnCancelar.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }
    }
}
