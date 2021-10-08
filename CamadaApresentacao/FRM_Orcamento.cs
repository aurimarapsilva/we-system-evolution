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
    public partial class FRM_Orcamento : Form
    {
        public bool eNovo;
        public int IdFuncionario;
        private decimal totalPago = 0;
        public string Entrada_Dineheiro = "";
        public decimal Valor_Entrada = 0;
        private DataTable TBL_Produtos;
        private DataTable TBL_Pagamento;

        public FRM_Orcamento()
        {
            InitializeComponent();
            this.CB_Buscar.SelectedIndex = 0;
        }

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Orcamento _Instancia;

        public static FRM_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Orcamento();
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

        // Metoido de Formatação de Grid
        private void Formato_Grid()
        {
            // Ocultar Colunas
            this.DGV_Dados.Columns[5].Visible = false;
            this.DGV_Dados.Columns[6].Visible = false;
            this.DGV_Dados.Columns[7].Visible = false;

            // Nome das Colunas
            this.DGV_Dados.Columns[1].HeaderText = "Nº";
            this.DGV_Dados.Columns[2].HeaderText = "Data";
            this.DGV_Dados.Columns[3].HeaderText = "Cliente";
            this.DGV_Dados.Columns[4].HeaderText = "Telefone";

            // Formato Moeda
            this.DGV_Dados.Columns[8].DefaultCellStyle.Format = "c";
        }


        // Metodo Mostrar Orçamento
        private void Mostrar()
        {
            this.DGV_Dados.DataSource = NOrcamento.Mostrar();
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        // Metodo Mostrar Detalhes (Produtos)
        private void Mostrar_Detalhes()
        {
            this.DGV_Produtos_Servicos.DataSource = NOrcamento.Mostrar_Produtos_Orcamento(Convert.ToInt32(this.TXB_Id.Text));

            //Ocultar Coluna do Grid
            this.DGV_Produtos_Servicos.Columns[1].Visible = false;

            //definir tamanho do Grid
            this.DGV_Produtos_Servicos.Columns[3].Width = 410;

            //Formatar Grid
            this.DGV_Produtos_Servicos.Columns[4].DefaultCellStyle.Format = "c";
            this.DGV_Produtos_Servicos.Columns[5].DefaultCellStyle.Format = "c";
        }

        // Mostrar Formas de Pagamento
        private void Mostrar_Formas_Pagamento()
        {
            this.DGV_Formas_Pagamento.DataSource = NOrcamento.Mostrar_Formas_Pgto_Orcamento(Convert.ToInt32(this.TXB_Id.Text));

            // Ocultar Colunas
            this.DGV_Formas_Pagamento.Columns[0].Visible = false;
            this.DGV_Formas_Pagamento.Columns[1].Visible = false;
            this.DGV_Formas_Pagamento.Columns[5].Visible = false;

            // Nome da Coluna
            this.DGV_Formas_Pagamento.Columns[2].HeaderText = "Forma";
            this.DGV_Formas_Pagamento.Columns[3].HeaderText = "Valor Primário";
            this.DGV_Formas_Pagamento.Columns[4].HeaderText = "Valor Final";

            // Formato da Coluna
            this.DGV_Formas_Pagamento.Columns[3].DefaultCellStyle.Format = "c";
            this.DGV_Formas_Pagamento.Columns[4].DefaultCellStyle.Format = "c";
        }

        // Metodo Buscar por Cliente
        private void Buscar_Cliente()
        {
            this.DGV_Dados.DataSource = NOrcamento.Buscar_Orcamento_Cliente(this.TXB_Buscar.Text);
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cliente";
        }
        
        // Metodo Buscar por Datas
        private void Buscar_Datas()
        {
            this.DGV_Dados.DataSource = NOrcamento.Buscar_Orcamento_Data(this.dtInicial.Text, this.dtFinal.Text);
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Datas";
        }

        // Metodo Buscar por Numero / ID do Orçamento 
        private void Buscar_Numero()
        {
            this.DGV_Dados.DataSource = NOrcamento.Buscar_Orcamento_Num(this.TXB_Buscar.Text);
            this.Formato_Grid();
            this.lblTotal.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Número";
        }


        // Criar Tabela - PRODUTOS DO ORÇAMENTO
        public void CriarTabela()
        {
            this.TBL_Produtos = new DataTable("Detalhe");
            this.TBL_Produtos.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.TBL_Produtos.Columns.Add("quant", System.Type.GetType("System.Decimal"));
            this.TBL_Produtos.Columns.Add("produto", System.Type.GetType("System.String"));
            this.TBL_Produtos.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.TBL_Produtos.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            
            this.DGV_Produtos_Servicos.DataSource = this.TBL_Produtos;

            //Ocultar Coluna do Grid
            this.DGV_Produtos_Servicos.Columns[0].Visible = false;
            this.DGV_Produtos_Servicos.Columns[1].Visible = false;

            //definir tamanho do Grid
            this.DGV_Produtos_Servicos.Columns[3].Width = 410;

            //Formatar Grid
            this.DGV_Produtos_Servicos.Columns[4].DefaultCellStyle.Format = "c";
            this.DGV_Produtos_Servicos.Columns[5].DefaultCellStyle.Format = "c";
        }

        // Metodo Criar Linha Grid Produtos
        public void CriarLinha()
        {
            DataRow row = this.TBL_Produtos.NewRow();
            this.TBL_Produtos.Rows.Add(row);

            this.CriarTabela_FP();
        }

        // Metodo Passar para proxima celular do grid
        private void MoveNext()
        {
            if (this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Selected)
            {
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;

                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
            else if (this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Selected)
            {
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;

                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[4];
            }
            else if (this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Selected)
            {
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;

                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[5];
            }
            else if (this.DGV_Produtos_Servicos.CurrentRow.Cells[5].Selected)
            {
                this.CriarLinha();

                int index = this.DGV_Produtos_Servicos.CurrentRow.Index + 1;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[2];
            }
        }


        // Criar tabela - FORMAS DE PAGAMENTO DO ORÇAMENTO
        public void CriarTabela_FP()
        {
            this.TBL_Pagamento = new DataTable("Pagamento");
            this.TBL_Pagamento.Columns.Add("forma", System.Type.GetType("System.String"));
            this.TBL_Pagamento.Columns.Add("valor_primario", System.Type.GetType("System.Decimal"));
            this.TBL_Pagamento.Columns.Add("valor_final", System.Type.GetType("System.Decimal"));
            this.TBL_Pagamento.Columns.Add("qtd_parcelas", System.Type.GetType("System.String"));

            this.DGV_Formas_Pagamento.DataSource = this.TBL_Pagamento;

            // Ocultas Colunas
            this.DGV_Formas_Pagamento.Columns[3].Visible = false;

            // Nome das Colunas
            this.DGV_Formas_Pagamento.Columns[0].HeaderText = "Forma";
            this.DGV_Formas_Pagamento.Columns[1].HeaderText = "Valor Primário";
            this.DGV_Formas_Pagamento.Columns[2].HeaderText = "Valor Final";

            //definir tamanho do Grid
            this.DGV_Formas_Pagamento.Columns[0].Width = 110;
            this.DGV_Formas_Pagamento.Columns[1].Width = 95;
            this.DGV_Formas_Pagamento.Columns[2].Width = 95;

            //Formatar Grid
            this.DGV_Formas_Pagamento.Columns[1].DefaultCellStyle.Format = "c";
            this.DGV_Formas_Pagamento.Columns[2].DefaultCellStyle.Format = "c";
        }


        // Metodo Limpar
        private void Limpar()
        {
            this.TXB_Id.Text = string.Empty;
            this.TXB_Numero.Text = string.Empty;
            this.DT_Data.Text = string.Empty;
            this.TXB_Numero.Text = string.Empty;
            this.TXB_Cliente.Text = string.Empty; 
            this.TXB_Telefone.Text = string.Empty;
            this.TXB_Total.Text = string.Empty;
            this.TXB_Valor_Entrada.Text = string.Empty;
            this.Entrada_Dineheiro = string.Empty;
            this.Valor_Entrada = 0;
            this.DGV_Produtos_Servicos.DataSource = null;
            this.DGV_Formas_Pagamento.DataSource = null;
        }

        // Metodo Habilitar
        private void Habilitar(bool valor)
        {
            this.DT_Data.Enabled = valor;
            this.TXB_Cliente.ReadOnly = !valor;
            this.TXB_Telefone.ReadOnly = !valor;
            this.DGV_Produtos_Servicos.ReadOnly = !valor;

            if (valor)
            {
                this.TXB_Cliente.BackColor = Color.White;
                this.TXB_Telefone.BackColor = Color.White;
                this.DGV_Produtos_Servicos.BackgroundColor = Color.White;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.White;
            }
            else
            {
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.TXB_Telefone.BackColor = Color.WhiteSmoke;
                this.DGV_Produtos_Servicos.BackgroundColor = Color.White;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.White;
            }
        }

        //Habilitar os Botões
        public void botoes()
        {
            if (this.eNovo)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
                this.BTN_Sair.Enabled = true;
                this.CHK_Selecionar_Item.Enabled = true;

                this.BTN_Dinheiro.Enabled = true;
                this.BTN_Cartao_Credito.Enabled = true;
                this.BTN_Cartao_Debito.Enabled = true;
                this.BTN_Crediario_Loja.Enabled = true;
                this.BTN_Cheque.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
                this.BTN_Sair.Enabled = true;
                this.CHK_Selecionar_Item.Enabled = false;

                this.BTN_Dinheiro.Enabled = false; 
                this.BTN_Cartao_Credito.Enabled = false;
                this.BTN_Cartao_Debito.Enabled = false;
                this.BTN_Crediario_Loja.Enabled = false;
                this.BTN_Cheque.Enabled = false;
            }
        }

        // Mostrar Produtos pelo Codigode Barras
        public void Selecionar_Produto_Codigo_Barra()
        {
            this.DGV_Select_Prod_Cod_Barra.DataSource = NProduto.Selecionar_Produto_Codigo_Barra_Venda(Convert.ToString(this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value));
        }

        // Metodo Pegar Prosutos para Venda
        public void SetProduto(int idproduto, string descricao, decimal preco_venda)
        {
            bool salvar = true;
            foreach (DataGridViewRow linha in DGV_Produtos_Servicos.Rows)
            {
                if (linha.Cells[1].Value.Equals(idproduto))
                {
                    salvar = false;
                 
                    MessageBox.Show("Este produto ou serviço já foi adicionado a lista.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[3].ReadOnly = false;
                }
            }
            if (salvar)
            {
                if (this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Value = 1;
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Value = preco_venda;
                }
                else
                {
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Value = preco_venda;
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

            // PREÇO DE VENDA -----------------------------------------------------------------------
            // Calculando novo total
            // Inicio
            subtotal_deletado = quant_deletar * valor_item_deletado;

            // Atualizar valores da linha do grid
            this.DGV_Produtos_Servicos.Rows[Linha_Atual].Cells[2].Value = quant_atual - quant_deletar;
            this.DGV_Produtos_Servicos.Rows[Linha_Atual].Cells[5].Value = subtotal_atual - subtotal_deletado;

            // Final
            valor_atualizado = this.totalPago - subtotal_deletado;
            this.totalPago = valor_atualizado;

            // Mostrando novo total
            this.TXB_Total.Text = totalPago.ToString("C");

            // Selecionar ultima linha
            int total_registros_atualizado = this.DGV_Produtos_Servicos.Rows.Count - 1;
            this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[total_registros_atualizado].Cells[2];
        }

        // >>>>> DADOS DE ENTRADA EM DINHEIRO  - METODOS E VARIAVEIS<<<<<
        private bool Dados_Entrada = false;

        // -- obter Informações da entrada em dinherio
        public void Set_Entrada_Dinheiro(string entrada, decimal valor_entrada)
        {
            try
            {
                this.Entrada_Dineheiro = entrada;
                this.Valor_Entrada = valor_entrada;
                this.TXB_Valor_Entrada.Text = this.Valor_Entrada.ToString("C");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }



        // >>>>> PGTO CARTÃO DE CRÉDITO - VARIAVEIS E METODOS <<<<<
        // --- VARIAVEIS
        private int IdOrcamento;
        private string Bandeira = "";
        private decimal Valor_Parcelas = 0;
        private int Qtd_Parcelas;
        private decimal Taxa = 0;

        // --- METODOS
        // Add Informações do cartão de Credito
        public void Adicionar_Informacoes_Cartao_Credito()
        {
            decimal valor = 0;
            valor = this.totalPago - this.Valor_Entrada;

            // Abrir Onformações do Cartão de Crédito
            FRM_Informacoes_Cartao_Credito_Orcamento frm = FRM_Informacoes_Cartao_Credito_Orcamento.GetInstancia();
            frm.Valor_Produtos_Servicos = valor; // valor total em produtos  - valor entrada
            frm.Show();
        }

        // Add Dados ao Grid Formas de pagamento
        public void Add_Dados_Grid_Forma_Pgto_Cartao_Credito(decimal VALOR_PRIMARIO, decimal VALOR_FINAL, int QTD_PARCELAS)
        {
            // Informando Tipo de Recebimento
            this.TXB_Forma_Pagamento.Text = "Cartão de Crédito";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.TBL_Pagamento.NewRow();
            row["forma"] = "Cartão de Crédito";
            row["valor_primario"] = VALOR_PRIMARIO;
            row["valor_final"] = VALOR_FINAL;
            row["qtd_parcelas"] = QTD_PARCELAS;
            this.TBL_Pagamento.Rows.Add(row);
        }

        // Capturar dados do cartao de credito
        public void Set_Dados_Card_Cred(string bandeira, decimal valor_parcelas, int qtd_parcelas)
        {
            this.Bandeira = bandeira;
            this.Valor_Parcelas = valor_parcelas;
            this.Qtd_Parcelas = qtd_parcelas;
        }



        // >>>>> PGTO CREDIÁRIO DA LOJA - VARIAVEIS E METODOS <<<<<
        // --- VARIAVEIS
        private DataTable TBL_Info_Crediario_Loja;
        private int Num_Parcela;
        private decimal Valor = 0;
        private DateTime Vencimento;

        // Add Informações do cartão de Credito
        public void Adicionar_Informacoes_Crediario_Loja()
        {
            decimal valor = 0;
            valor = this.totalPago - this.Valor_Entrada;

            // Abrir Onformações do Crediário da Loja
            FRM_Informacoes_Crediario_Loja_Orcamento frm = FRM_Informacoes_Crediario_Loja_Orcamento.GetInstancia();
            frm.Valor_Produtos_Servicos = valor; // valor total em produtos  - valor entrada
            frm.Data = this.DT_Data.Value;
            frm.Show();
        }

        // Add Dados ao Grid Formas de pagamento
        public void Add_Dados_Grid_Forma_Pgto_Crediario_Loja(decimal VALOR_PRIMARIO, decimal VALOR_FINAL, int QTD_PARCELAS)
        {
            // Informando Tipo de Recebimento
            this.TXB_Forma_Pagamento.Text = "Crediário da Loja";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.TBL_Pagamento.NewRow();
            row["forma"] = "Crediário da Loja";
            row["valor_primario"] = VALOR_PRIMARIO;
            row["valor_final"] = VALOR_FINAL;
            row["qtd_parcelas"] = QTD_PARCELAS;
            this.TBL_Pagamento.Rows.Add(row);
        }

        private void Criar_Tabela_Info_Crediario_Loja()
        {
            this.TBL_Info_Crediario_Loja = new DataTable("Parcelas_Cred_Loja");
            this.TBL_Info_Crediario_Loja.Columns.Add("num_parcela", System.Type.GetType("System.Int32")); // Num Parcela
            this.TBL_Info_Crediario_Loja.Columns.Add("valor", System.Type.GetType("System.Decimal")); // Valor
            this.TBL_Info_Crediario_Loja.Columns.Add("vencimento", System.Type.GetType("System.DateTime")); // Vencimento
        }

        public void Gerar_Parcelas(decimal Valor, int Quant_Parcela, DateTime Data)
        {
            this.Criar_Tabela_Info_Crediario_Loja();

            int contador = 0;

            for (int i = 0; i < Quant_Parcela; i++)
            {
                contador++;

                DataRow row = this.TBL_Info_Crediario_Loja.NewRow();
                row["num_parcela"] = contador;
                row["valor"] = Valor / Quant_Parcela;
                row["vencimento"] = Data.AddMonths(contador);
                this.TBL_Info_Crediario_Loja.Rows.Add(row);
            }

            // Exibir Parcelas Geradas
            FRM_Informacoes_Crediario_Loja_Orcamento frm = FRM_Informacoes_Crediario_Loja_Orcamento.GetInstancia();
            DataGridView Grid = frm.DGV_Parcelamento;
            Grid.DataSource = this.TBL_Info_Crediario_Loja;

            // Formatando Colunas do Grid
            // Nome das Coluns
            Grid.Columns[0].HeaderText = "Nº da Parcela";
            Grid.Columns[1].HeaderText = "Valor";
            Grid.Columns[2].HeaderText = "Vencimento";

            // Formato de dados
            Grid.Columns[1].DefaultCellStyle.Format = "c";
            Grid.Columns[2].DefaultCellStyle.Format = "d";
        }



        // >>>>> PGTO CHEQUE - VARIAVEIS E METODOS
        private DataTable TBL_Dados_Pagamento_Cheque;

        private void Criar_Tabela_Pgto_Cheque()
        {
            this.TBL_Dados_Pagamento_Cheque = new DataTable("Cheque");
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("data", System.Type.GetType("System.DateTime"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("banco_emissor", System.Type.GetType("System.String"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("titular", System.Type.GetType("System.String"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("num_cheque", System.Type.GetType("System.String"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("num_parcela", System.Type.GetType("System.String"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("valor_parcela", System.Type.GetType("System.Decimal"));
            this.TBL_Dados_Pagamento_Cheque.Columns.Add("data_depositar", System.Type.GetType("System.DateTime"));
        }

        public void SetDados_Pagamento_Cheque(DateTime Data, string Banco_Emissor, string Titular, string Num_Cheque, string Num_Parcela, decimal Valor_Parcela, DateTime Data_Depositar)
        {
            // Criando e adicionado dados na linha
            DataRow row = this.TBL_Dados_Pagamento_Cheque.NewRow();
            row["data"] = Data;
            row["banco_emissor"] = Banco_Emissor;
            row["titular"] = Titular;
            row["num_cheque"] = Num_Cheque;
            row["num_parcela"] = Num_Parcela;
            row["valor_parcela"] = Valor_Parcela;
            row["data_depositar"] = Data_Depositar;
            this.TBL_Dados_Pagamento_Cheque.Rows.Add(row);
        }

        // Variaveis para pegar os dados da tabela
        private DateTime Data_Entrada_Cheque;
        private string banco_emissor_cheque = "";
        private string nome_titular_cheque = "";
        private string num_cheque = "";
        private string num_parcela_cheque = "";
        private decimal valor_cheque;
        private DateTime depositar_dia;

        // Adicionar dados de forma de pagamento = CHEQUE
        public void Adicionar_Informacoes_Cheque()
        {
            decimal valor = 0;
            valor = this.totalPago - this.Valor_Entrada;

            // Criar tabela para armazenar os dados temporariamente
            this.Criar_Tabela_Pgto_Cheque();

            // Abrir Informações do Cheque
            FRM_Informacoes_Cheque_Orcamento frm = FRM_Informacoes_Cheque_Orcamento.GetInstancia();
            frm.Valor_Total = valor; // valor total em produtos  - valor entrada
            frm.DTP_Data.Value = this.DT_Data.Value;
            frm.Show();
        }

        // Add Dados ao Grid Formas de pagamento
        public void Add_Dados_Grid_Forma_Pgto_Cheque(decimal VALOR_PRIMARIO, decimal VALOR_FINAL, int QTD_PARCELAS)
        {
            // Informando Tipo de Recebimento
            this.TXB_Forma_Pagamento.Text = "Cheque";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.TBL_Pagamento.NewRow();
            row["forma"] = "Cheque";
            row["valor_primario"] = VALOR_PRIMARIO;
            row["valor_final"] = VALOR_FINAL;
            row["qtd_parcelas"] = QTD_PARCELAS;
            this.TBL_Pagamento.Rows.Add(row);
        }



        // >>>> PGTO CARTÃO DEBITO - VARIAVEIS E METODOS
        public string bandeira_cartao_debito = "";


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo)
            {
                this.TXB_Cliente.BackColor = Color.LemonChiffon;
                this.TXB_Telefone.BackColor = Color.LemonChiffon;
                this.DGV_Produtos_Servicos.BackgroundColor = Color.LemonChiffon;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.TXB_Telefone.BackColor = Color.WhiteSmoke;
                this.DGV_Produtos_Servicos.BackgroundColor = Color.White;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.White;
            }
        }


        // imprimir Orçamento
        private void Imprimir()
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Deseja imprimir este orçamento agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                FRM_Orcamentos frm = FRM_Orcamentos.GetInstancia();
                frm.IdOrcamento = this.IdOrcamento;
                frm.ShowDialog();
            }
        }


        //Metodo Numeração Automática 
        private int Auxiliar_NA;    //Variavel Auxiliar
        private DataTable DT_Num_Auto;  // Tabela de daods
        private void Numeracao_Automatica()
        {
            this.DT_Num_Auto = NNumeracao_Auto.Mostrar_Num_Auto_Orcamento();
            this.Auxiliar_NA = Convert.ToInt32(this.DT_Num_Auto.Rows[0][2]);
        }

        private void FRM_Orcamento_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.Numeracao_Automatica();
        }

        private void DGV_Produtos_Servicos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nome das Colunas
            this.DGV_Produtos_Servicos.Columns[2].HeaderText = "Quant";
            this.DGV_Produtos_Servicos.Columns[3].HeaderText = "Descrição";
            this.DGV_Produtos_Servicos.Columns[4].HeaderText = "Valor Unit.";
            this.DGV_Produtos_Servicos.Columns[5].HeaderText = "Subtotal";
        }

        private void DGV_Produtos_Servicos_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.MoveNext();
            this.DGV_Produtos_Servicos.CurrentRow.Cells[3].ReadOnly = false;
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.TXB_Cliente.Focus();
            this.CriarTabela();
            this.CriarLinha();
            this.CriarTabela_FP();

            this.TXB_Total.BackColor = Color.WhiteSmoke;
            this.TXB_Total.ForeColor = Color.Red;
            this.TXB_Valor_Entrada.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Entrada.ForeColor = Color.Green;

            this.TXB_Total.Text = "R$ 0,00";
            this.TXB_Valor_Entrada.Text = "R$ 0,00";

            string Config_Num_Auto = this.DT_Num_Auto.Rows[0][3].ToString();

            if (Config_Num_Auto == "SIM")
            {
                //Incrementando para gerar novo número de venda
                Auxiliar_NA++;

                //passado novo numero de venda para o TextBox
                this.TXB_Numero.Text = Convert.ToString(Auxiliar_NA);
            }
        }


        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.CriarTabela();
            this.CriarTabela_FP();
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Todos os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                try
                {
                    string resp = "";
                    if (this.TXB_Cliente.Text == string.Empty || this.TXB_Telefone.Text == string.Empty || this.DGV_Produtos_Servicos.Rows.Count == 0 || this.DGV_Formas_Pagamento.Rows.Count == 0)
                    {
                        this.MensagemErro("Preencha todos os campos obrigatórios.");
                        this.Alerta_Campos_Obrigatorios();
                    }
                    else
                    {
                        if (this.eNovo)
                        {
                            // Selecionando ultima linha antes de salvar
                            int ultima_linha = this.DGV_Produtos_Servicos.Rows.Count - 1;
                            this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[ultima_linha].Cells[2];

                            // Excluir ultima linha em branco, caso haja
                            if (DGV_Produtos_Servicos.Rows.Count > 1 && DGV_Produtos_Servicos.CurrentRow.Cells[3].Value.ToString() == "" && DGV_Produtos_Servicos.CurrentRow.Cells[4].Value.ToString() == "" && DGV_Produtos_Servicos.CurrentRow.Cells[5].Value.ToString() == "")
                            {
                                int index = DGV_Produtos_Servicos.CurrentRow.Index;
                                DataGridViewRow row = DGV_Produtos_Servicos.Rows[index];
                                DGV_Produtos_Servicos.Rows.Remove(row);
                            }

                            resp = NOrcamento.Inserir(this.DT_Data.Value, this.TXB_Cliente.Text.Trim().ToUpper(), this.TXB_Telefone.Text, this.Entrada_Dineheiro, this.Valor_Entrada, this.TXB_Forma_Pagamento.Text, this.IdFuncionario, Convert.ToInt32(this.TXB_Numero.Text), this.TBL_Produtos, this.TBL_Pagamento);
                        }
                        if (resp.Equals("Ok"))
                        {
                            if (this.eNovo)
                            {
                                this.MensagemOk("Orçamento gerado e gravado com sucesso.");

                                // IDORÇAMENTO
                                DataTable Dados_Orcamento = NOrcamento.Mostrar();
                                this.IdOrcamento = Convert.ToInt32(Dados_Orcamento.Rows[0][0]);

                                // INSERIR DADOS VITAIS SOBRE FORMA DE PAGAMENTO
                                foreach (DataGridViewRow l in DGV_Formas_Pagamento.Rows)
                                {
                                    if (l.Cells[0].Value.Equals("Cartão de Crédito"))
                                    {
                                        resp = NDados_FP_Card_Cred_Orcamento.Inserir(this.IdOrcamento, this.Bandeira, this.Valor_Parcelas, this.Qtd_Parcelas);
                                    }
                                    else if (l.Cells[0].Value.Equals("Crediário da Loja"))
                                    {
                                        for (int i = 0; i <= TBL_Info_Crediario_Loja.Rows.Count - 1; i++)
                                        {
                                            this.Num_Parcela = Convert.ToInt32(this.TBL_Info_Crediario_Loja.Rows[i][0]);
                                            this.Valor = Convert.ToDecimal(this.TBL_Info_Crediario_Loja.Rows[i][1]);
                                            this.Vencimento = Convert.ToDateTime(this.TBL_Info_Crediario_Loja.Rows[i][2]);

                                            resp = NDados_FP_Cred_Loja_Orcamento.Inserir(this.IdOrcamento, this.Num_Parcela, this.Valor, this.Vencimento);
                                        }
                                    }
                                    else if (l.Cells[0].Value.Equals("Cheque"))
                                    {
                                        for (int i = 0; i <= TBL_Dados_Pagamento_Cheque.Rows.Count - 1; i++)
                                        {
                                            this.Data_Entrada_Cheque = Convert.ToDateTime(this.TBL_Dados_Pagamento_Cheque.Rows[i][0]);
                                            this.banco_emissor_cheque = this.TBL_Dados_Pagamento_Cheque.Rows[i][1].ToString();
                                            this.nome_titular_cheque = this.TBL_Dados_Pagamento_Cheque.Rows[i][2].ToString();
                                            this.num_cheque = this.TBL_Dados_Pagamento_Cheque.Rows[i][3].ToString();
                                            this.num_parcela_cheque = this.TBL_Dados_Pagamento_Cheque.Rows[i][4].ToString();
                                            this.valor_cheque = Convert.ToDecimal(this.TBL_Dados_Pagamento_Cheque.Rows[i][5]);
                                            this.depositar_dia = Convert.ToDateTime(this.TBL_Dados_Pagamento_Cheque.Rows[i][6]);

                                            resp = NDados_FP_Cheque_Orcamento.Inserir(this.IdOrcamento, this. Data_Entrada_Cheque, this.banco_emissor_cheque, this.nome_titular_cheque, this.num_cheque, this.num_parcela_cheque, this.valor_cheque, this.depositar_dia);
                                        }
                                    }
                                    else if (l.Cells[0].Value.Equals("Cartão de Debito"))
                                    {
                                        resp = NDados_FP_Card_Deb_Orcamento.Inserir(this.IdOrcamento, this.bandeira_cartao_debito);
                                    }
                                }

                                // Imprimir orçamento
                                this.Imprimir();
                            }            
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }
                        this.eNovo = false;
                        this.Habilitar(false);
                        this.botoes();
                        this.Limpar();
                        this.Mostrar();
                        this.Alerta_Campos_Obrigatorios();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void DGV_Produtos_Servicos_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Selecionar_Produto_Codigo_Barra();

            if (this.DGV_Select_Prod_Cod_Barra.Rows.Count == 1)
            {
                if (this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Selected && e.KeyCode == Keys.Enter)
                {
                    // Pegando Dados
                    int idproduto = Convert.ToInt32(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[0].Value);
                    string descricao = Convert.ToString(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[1].Value);
                    decimal preco_venda = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[2].Value);
                    decimal quant_atual_estoque = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[3].Value);
                    string unidade_medida = this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[4].Value.ToString();
                    string tipo_mercadoria = this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[5].Value.ToString();
                    decimal quant_ideal = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[6].Value);
                    decimal preco_custo = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[7].Value);

                    string valor;

                    bool salvar = true;
                    foreach (DataGridViewRow linha in DGV_Produtos_Servicos.Rows)
                    {
                        if (linha.Cells[1].Value.Equals(idproduto))
                        {
                            salvar = false;

                            // Capturando linha a ser atualizada
                            int row_atual = linha.Index;

                            // Capturando quantidade atual
                            decimal qtd = Convert.ToDecimal(DGV_Produtos_Servicos.Rows[row_atual].Cells[2].Value);

                            if (tipo_mercadoria == "PRODUTO" && quant_atual_estoque < qtd + 1)
                            {
                                this.MensagemErro("A quantidade atual no estoque é insuficiente.\n\nQuantidade disponível:   " + quant_atual_estoque.ToString() + " " + unidade_medida);
                                this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = "";

                                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
                            }
                            else
                            {
                                // inserindo quantidade atualizada
                                DGV_Produtos_Servicos.Rows[row_atual].Cells[2].Value = qtd + 1;

                                // Tranferindo quantidade atualizada para variavel
                                decimal qtd_atual = Convert.ToDecimal(DGV_Produtos_Servicos.Rows[row_atual].Cells[2].Value);

                                // Capturando preço de venda atual
                                decimal preco_venda_atual = Convert.ToDecimal(DGV_Produtos_Servicos.Rows[row_atual].Cells[4].Value);

                                // Analisando situação
                                if (preco_venda_atual == preco_venda)
                                {
                                    // Calculando novo subtotal
                                    decimal novo_subtotal = qtd_atual * preco_venda;
                                    this.totalPago = 0;
                                    DGV_Produtos_Servicos.Rows[row_atual].Cells[5].Value = novo_subtotal;
                                }
                                else
                                {
                                    // Calculando novo subtotal
                                    decimal novo_subtotal = qtd_atual * preco_venda_atual;
                                    this.totalPago = 0;
                                    DGV_Produtos_Servicos.Rows[row_atual].Cells[5].Value = novo_subtotal;
                                }

                                // Calculando novo total geral
                                for (int i = 0; i <= DGV_Produtos_Servicos.RowCount - 1; i++)
                                {
                                    if (Convert.ToString(DGV_Produtos_Servicos.Rows[i].Cells[5].Value) != "")
                                    {
                                        this.totalPago += Convert.ToDecimal(DGV_Produtos_Servicos.Rows[i].Cells[5].Value);
                                    }
                                }
                                TXB_Total.Text = this.totalPago.ToString("C");
                                DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = "";
                            }
                        }
                    }
                    if (salvar)
                    {
                        bool Trava = true;
                        if (this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Value = 1;
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        else
                        {
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        if (Trava)
                        {
                            int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                            this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[4];

                            if (DGV_Produtos_Servicos.CurrentRow.Cells[4].Selected)
                            {
                                decimal cell1 = Convert.ToDecimal(DGV_Produtos_Servicos.CurrentRow.Cells[2].Value);

                                decimal cell2 = Convert.ToDecimal(DGV_Produtos_Servicos.CurrentRow.Cells[4].Value);
                                
                                if (cell1.ToString() != "" && cell2.ToString() != "")
                                {
                                    DGV_Produtos_Servicos.CurrentRow.Cells[5].Value = cell1 * cell2;
                                    
                                    valor = "";
                                    this.totalPago = 0;

                                    if (Convert.ToString(DGV_Produtos_Servicos.CurrentRow.Cells[5].Value) != "")
                                    {
                                        valor = DGV_Produtos_Servicos.CurrentRow.Cells[5].Value.ToString();

                                        if (!valor.Equals(""))
                                        {
                                            for (int i = 0; i <= DGV_Produtos_Servicos.RowCount - 1; i++)
                                            {
                                                if (Convert.ToString(DGV_Produtos_Servicos.Rows[i].Cells[5].Value) != "")
                                                {
                                                    this.totalPago += Convert.ToDecimal(DGV_Produtos_Servicos.Rows[i].Cells[5].Value);
                                                }
                                            }
                                            TXB_Total.Text = this.totalPago.ToString("C");

                                            this.CriarLinha();
                                            index = this.DGV_Produtos_Servicos.CurrentRow.Index + 1;
                                            this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[2];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FRM_Orcamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Selected)
            {
                this.DGV_Produtos_Servicos.CurrentRow.Cells[3].ReadOnly = true;

                FRM_Buscar_Produto_Orcamento frm = FRM_Buscar_Produto_Orcamento.GetInstancia();
                frm.txtBuscar.Text = this.DGV_Produtos_Servicos.CurrentRow.Cells[3].Value.ToString();
                
                frm.ShowDialog();
            }

            if (this.eNovo && this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Selected && Convert.ToString(this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Value) != "" && Convert.ToString(this.DGV_Produtos_Servicos.CurrentRow.Cells[4].Value) != "")
            {
                decimal cell1 = Convert.ToDecimal(DGV_Produtos_Servicos.CurrentRow.Cells[2].Value);

                decimal cell2 = Convert.ToDecimal(DGV_Produtos_Servicos.CurrentRow.Cells[4].Value);

                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    DGV_Produtos_Servicos.CurrentRow.Cells[5].Value = cell1 * cell2;
                   
                    string valor = "";
                    this.totalPago = 0;

                    if (Convert.ToString(DGV_Produtos_Servicos.CurrentRow.Cells[5].Value) != "")
                    {
                        valor = DGV_Produtos_Servicos.CurrentRow.Cells[5].Value.ToString();

                        if (!valor.Equals(""))
                        {
                            for (int i = 0; i <= DGV_Produtos_Servicos.RowCount - 1; i++)
                            {
                                if (Convert.ToString(DGV_Produtos_Servicos.Rows[i].Cells[5].Value) != "")
                                {
                                    this.totalPago += Convert.ToDecimal(DGV_Produtos_Servicos.Rows[i].Cells[5].Value);
                                }
                            }
                            TXB_Total.Text = this.totalPago.ToString("C");
                        }
                    }
                }
            }
        }

        private void DGV_Produtos_Servicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Produtos_Servicos.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Produtos_Servicos.Rows[e.RowIndex].Cells["Selecionar"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void CHK_Selecionar_Item_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar_Item.Checked)
            {
                this.DGV_Produtos_Servicos.Columns[0].Visible = true;
                this.BTN_Deletar_Item.Enabled = true;

            }
            else
            {
                this.DGV_Produtos_Servicos.Columns[0].Visible = false;
                this.BTN_Deletar_Item.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Produtos_Servicos.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void BTN_Deletar_Item_Click(object sender, EventArgs e)
        {
            try
            {
                bool chave = false;
                int Linha_Atual = 0;
                decimal Quant_Atual = 0;
                decimal Valor_Item_Deletado = 0;
                decimal Subtotal_Atual = 0;
               
                foreach (DataGridViewRow row in DGV_Produtos_Servicos.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        Linha_Atual = row.Index;
                        Quant_Atual = Convert.ToDecimal(row.Cells[2].Value);
                        Valor_Item_Deletado = Convert.ToDecimal(row.Cells[4].Value);
                        Subtotal_Atual = Convert.ToDecimal(row.Cells[5].Value);
                    }
                }
                if (chave)
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja deletar intem(s) da lista?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.Yes)
                    {
                        decimal valor_item_deletado = 0;
                        decimal valor_atualizado = 0;
                        
                        decimal quant_atual = Quant_Atual;
                        if (quant_atual == 1)
                        {
                            // Pegando Valor do item a ser deletado
                            valor_item_deletado = Valor_Item_Deletado;

                            // Calculando novo total
                            valor_atualizado = this.totalPago - valor_item_deletado;
                            this.totalPago = valor_atualizado;

                            // Mostrando novo total
                            this.TXB_Total.Text = this.totalPago.ToString("C");

                            // Deletar item
                            int total_registros = this.DGV_Produtos_Servicos.Rows.Count - 1;

                            if (Linha_Atual == total_registros)
                            {
                                DataGridViewRow linha = DGV_Produtos_Servicos.Rows[Linha_Atual];
                                DGV_Produtos_Servicos.Rows.Remove(linha);

                                this.CriarLinha();
                            }
                            else
                            {
                                DataGridViewRow linha = DGV_Produtos_Servicos.Rows[Linha_Atual];
                                DGV_Produtos_Servicos.Rows.Remove(linha);
                            }

                            // Selecionar ultima linha
                            int total_registros_atualizado = this.DGV_Produtos_Servicos.Rows.Count - 1;
                            this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[total_registros_atualizado].Cells[2];

                            this.DGV_Produtos_Servicos.Focus();
                            this.CHK_Selecionar.Checked = false;
                        }
                        else if (quant_atual > 1)
                        {
                            FRM_Deletar_Mais_1_Item_Orcamento frm = FRM_Deletar_Mais_1_Item_Orcamento.GetInstancia();
                            frm.linha_atual = Linha_Atual;
                            frm.quant_atual = Quant_Atual;
                            frm.valor_item_deletado = Valor_Item_Deletado;
                            frm.subtotal_atual = Subtotal_Atual;
                            frm.ShowDialog();
                        }
                    }
                }
                else
                {
                    this.MensagemErro("Selecione um item.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void BTN_Dinheiro_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0 && this.eNovo)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Informando Tipo de Recebimento
                    this.TXB_Forma_Pagamento.Text = "Dinheiro";

                    // Adicionar dados ao grid de formas de pagamento
                    DataRow row = this.TBL_Pagamento.NewRow();
                    row["forma"] = "Dinheiro";
                    row["valor_primario"] = this.totalPago;
                    row["valor_final"] = this.totalPago;
                    row["qtd_parcelas"] = 1;
                    this.TBL_Pagamento.Rows.Add(row);
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
        }

        private void BTN_Cartao_Credito_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0 && this.eNovo)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Adicionar dados de pagamento
                    FRM_Entrada_em_Dinheiro_Card_Cred_Orcamento frm = FRM_Entrada_em_Dinheiro_Card_Cred_Orcamento.GetInstancia();
                    frm.Show();
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
        }

        private void BTN_Crediario_Loja_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0 && this.eNovo)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Adicionar dados de pagamento
                    FRM_Entrada_em_Dinheiro_Cred_Loja_Orcamento frm = FRM_Entrada_em_Dinheiro_Cred_Loja_Orcamento.GetInstancia();
                    frm.Show();
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
        }

        private void BTN_Cheque_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0 && this.eNovo)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Adicionar dados de pagamento
                    FRM_Entrada_em_Dinheiro_Cheque_Orcamento frm = FRM_Entrada_em_Dinheiro_Cheque_Orcamento.GetInstancia();
                    frm.Show();
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
        }

        private void BTN_Cartão_Debito_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0 && this.eNovo)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Informando Tipo de Recebimento
                    this.TXB_Forma_Pagamento.Text = "Cartão de Debito";

                    // Adicionar dados ao grid de formas de pagamento
                    DataRow row = this.TBL_Pagamento.NewRow();
                    row["forma"] = "Cartão de Debito";
                    row["valor_primario"] = this.totalPago;
                    row["valor_final"] = this.totalPago;
                    row["qtd_parcelas"] = 1;
                    this.TBL_Pagamento.Rows.Add(row);

                    // Solicitar Informações do cartão
                    FRM_Informacoes_Cartao_Debito_Orcamento frm = FRM_Informacoes_Cartao_Debito_Orcamento.GetInstancia();
                    frm.Show();
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.DGV_Produtos_Servicos.CurrentRow.Index;
                this.DGV_Produtos_Servicos.CurrentCell = this.DGV_Produtos_Servicos.Rows[index].Cells[3];
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Selecionar.Checked)
            {
                this.DGV_Dados.Columns[0].Visible = true;
                this.BTN_Deletar.Enabled = true;
                this.BTN_Imprimir.Enabled = true;
            }
            else
            {
                this.DGV_Dados.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;
                this.BTN_Imprimir.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Dados.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void DGV_Dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Dados.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Dados.Rows[e.RowIndex].Cells["Select"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo = "";
                    string Resp = "";
                    bool chave = false;

                    foreach (DataGridViewRow row in DGV_Dados.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            chave = true;
                        }
                    }
                    if (chave)
                    {
                        Resp = NOrcamento.Excluir(Convert.ToInt32(Codigo));

                        if (Resp.Equals("Ok"))
                        {
                            this.MensagemOk("A exclusão foi realizada com sucesso");
                        }
                        else
                        {
                            this.MensagemErro(Resp);
                        }
                    }
                    else
                    {
                        this.MensagemErro("Selecione um registro.");
                    }
                    this.CHK_Selecionar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscar_Datas_Click(object sender, EventArgs e)
        {
            this.Buscar_Datas();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.CB_Buscar.Text.Equals("Nº do Orçamento"))
            {
                this.Buscar_Numero();
            }
            else if (this.CB_Buscar.Text.Equals("Nome do Cliente"))
            {
                this.Buscar_Cliente();
            }
            this.TXB_Buscar.Text = string.Empty;
        }

        private void CB_Buscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TXB_Buscar.Text = string.Empty;
            this.TXB_Buscar.Focus();
        }

        private void TXB_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (this.TXB_Buscar.Text.Equals(""))
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

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void DGV_Dados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TXB_Id.Text = this.DGV_Dados.CurrentRow.Cells["idorcamento"].Value.ToString();
            this.TXB_Numero.Text = this.DGV_Dados.CurrentRow.Cells["numero"].Value.ToString();
            this.DT_Data.Text = this.DGV_Dados.CurrentRow.Cells["data"].Value.ToString();
            this.TXB_Cliente.Text = this.DGV_Dados.CurrentRow.Cells["cliente"].Value.ToString();
            this.TXB_Telefone.Text = this.DGV_Dados.CurrentRow.Cells["telefone"].Value.ToString();

            this.TXB_Total.BackColor = Color.WhiteSmoke;
            this.TXB_Total.ForeColor = Color.Red;
            this.TXB_Valor_Entrada.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Entrada.ForeColor = Color.Green;

            decimal total = Convert.ToDecimal(this.DGV_Dados.CurrentRow.Cells["Total"].Value);
            this.TXB_Total.Text = total.ToString("C");

            decimal entrada = Convert.ToDecimal(this.DGV_Dados.CurrentRow.Cells["valor_entrada"].Value);
            this.TXB_Valor_Entrada.Text = entrada.ToString("C");

            this.TXB_Forma_Pagamento.Text = this.DGV_Dados.CurrentRow.Cells["forma_pagamento"].Value.ToString();
            
            this.Mostrar_Detalhes();
            this.Mostrar_Formas_Pagamento();
            this.BTN_Cancelar.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void FRM_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.DGV_Produtos_Servicos.CurrentRow.Cells[2].Selected && this.eNovo)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void DGV_Produtos_Servicos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
        }

        private void TXB_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (this.CHK_Celular.Checked) // Usar Celular
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (TXB_Telefone.TextLength)
                    {
                        case 0:
                            this.TXB_Telefone.Text = "(31) ";
                            this.TXB_Telefone.SelectionStart = 5;
                            break;
                        case 10:
                            this.TXB_Telefone.Text += " - ";
                            this.TXB_Telefone.SelectionStart = 13;
                            break;
                    }
                }
            }
            else // Usar Tel. Fixo
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (TXB_Telefone.TextLength)
                    {
                        case 0:
                            this.TXB_Telefone.Text = "(31) ";
                            this.TXB_Telefone.SelectionStart = 5;
                            break;
                        case 9:
                            this.TXB_Telefone.Text += " - ";
                            this.TXB_Telefone.SelectionStart = 12;
                            break;
                    }
                }
            }
        }

        private void CHK_Celular_CheckedChanged(object sender, EventArgs e)
        {
            this.TXB_Telefone.Text = string.Empty;
            this.TXB_Telefone.Focus();

            if (this.CHK_Celular.Checked)
            {
                this.TXB_Telefone.MaxLength = 17; // Usar Celular
            }
            else
            {
                this.TXB_Telefone.MaxLength = 16; // Usar Tel. Fixo
            }
        }

        private void BTN_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = 0;
                bool chave = false;
                foreach (DataGridViewRow row in DGV_Dados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        ID = Convert.ToInt32(row.Cells[1].Value);
                        chave = true;
                    }
                }
                if (chave)
                {
                    FRM_Orcamentos frm = FRM_Orcamentos.GetInstancia();
                    frm.IdOrcamento = ID;
                    frm.ShowDialog();
                }
                else
                {
                    this.MensagemErro("Selecione um registro.");
                }
                this.CHK_Selecionar.Checked = false;
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
