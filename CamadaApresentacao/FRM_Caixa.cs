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
    public partial class FRM_Caixa : Form
    {
        public bool chave = true;
        public bool eNovo;
        private bool Atualizador_Constante = true;
        private DataTable dtDetalhe;
        public DataTable dtFormas_Pgto;
        public decimal totalPago = 0;
        private DataTable DT_Dados;
        private DataTable DT_Num_Auto;
        private DataTable DT_Limite_Credito_Usado;
        private DataTable TBL_Dados_Feriados;
        private DataTable TBL_Config_Cartao_Debito;
        private decimal limite_usado = 0;
        public decimal resto_limite = 0;
        private decimal limite = 0;
        public decimal limite_uso_externo = 0;
        public string PERMISSAO_DELETAR_ITEM_LISTA = "NÃO";

        // Variaveis para abertura e fechamento da caixa & Inserir no Controle de Cartão Credito
        public int idguiche_atendimento;
        public string nome_guiche;
        public string Nome_Funcionario = "";
        public int idfuncionario;
        private int idvenda;
        public string Data_Caixa_Aberto = "";
        public string Hora_Caixa_Aberto = "";
        public decimal valor_inicial_caixa;

        // >>>>>>>  VARIAVEIS METODOS - CARTÃO DE CRÉDITO <<<<<<<<<
        // --- Variavies ---
        public decimal taxa_cartao_credito;
        public decimal valor_cartao_credito;
        private decimal valor_liquido_cartao_credito;
        public string bandeira_cartao_credito = "";
        public int quant_parcelas_cartao_credito;
        private double Prazo_Primeira_Pac;
        private double Prazo_Demais_Parc;
        private DataTable TBL_Info_Config_Cartao_Credito;

        // --- Medotos ---
        // Adicionar dados de forma de pagamento = CARTÃO DE CRÉDITO
        public void Adicionar_Informacoes_Cartao_Credito()
        {
            if (this.Dados_Entrada)
            {
                decimal valor = 0;
                valor = this.totalPago - this.Valor_Entrada;

                // Abrir Onformações do Cartão de Crédito
                FRM_Informacoes_Cartao_Credito frm = FRM_Informacoes_Cartao_Credito.GetInstancia();
                frm.Valor_Produtos_Servicos = valor; // valor total em produtos  - valor entrada
                frm.Show();
            }
            else
            {
                // Abrir Onformações do Crediario da Loja
                FRM_Informacoes_Cartao_Credito frm = FRM_Informacoes_Cartao_Credito.GetInstancia();
                frm.Valor_Produtos_Servicos = this.totalPago; // valor total em produtos
                frm.Show();
            }
        }
        
        public void Adicionar_Dados_Grid_Formas_Pgto_Card_Cred(decimal Valor_Primario, decimal Valor_Final)
        {
            // Informando Tipo de Recebimento
            this.TXB_Recebimento.Text = "Cartão de Crédito";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.dtFormas_Pgto.NewRow();
            row["forma"] = "Cartão de Crédito";
            row["valor_primario"] = Valor_Primario;
            row["valor_final"] = Valor_Final;
            this.dtFormas_Pgto.Rows.Add(row);
        }


        // >>>>>> CARTÃO DE DEBITO <<<<<<<<<
        private decimal valor_cartao_debito;
        public int prazo_compensacao_cartao_debito;
        public decimal taxa_cartao_debito;
        public string bandeira_cartao_debito = "";

        // >>>>> VENDA NO CREDIARIO DA LOJA <<<<<
        // --- Variaveis ---
        private DataTable TBL_Info_Crediario_Loja;

        private decimal Valor_Entrada = 0;
        private bool Dados_Entrada = false;

        // --- Metodos ---
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
            FRM_Informacoes_Crediario_Loja frm = FRM_Informacoes_Crediario_Loja.GetInstancia();
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


        public void Gerar_Parcelas_Multiformas(decimal Valor, int Quant_Parcela, DateTime Data)
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
            FRM_Informacoes_Crediario_Loja_Multiformas frm = FRM_Informacoes_Crediario_Loja_Multiformas.GetInstancia();
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

        private DataTable TBL_Detalhe_Contas_Receber;
        private void CriarTabela_Detalhe_Contas_Receber()
        {
            this.TBL_Detalhe_Contas_Receber = new DataTable("Detalhe_Contas_Receber");
            this.TBL_Detalhe_Contas_Receber.Columns.Add("idcliente", System.Type.GetType("System.Int32"));
            this.TBL_Detalhe_Contas_Receber.Columns.Add("num_parcela", System.Type.GetType("System.Int32"));
            this.TBL_Detalhe_Contas_Receber.Columns.Add("valor", System.Type.GetType("System.Decimal"));
            this.TBL_Detalhe_Contas_Receber.Columns.Add("vencimento", System.Type.GetType("System.DateTime"));
            this.TBL_Detalhe_Contas_Receber.Columns.Add("estado", System.Type.GetType("System.String"));
            this.TBL_Detalhe_Contas_Receber.Columns.Add("obs", System.Type.GetType("System.String"));
        }


        public void Set_Detalhe_Recebimento(string detalhe, decimal valor_entrada)
        {
            this.TXB_Entrada_Dinheiro.Text = detalhe;
            this.Valor_Entrada = valor_entrada;

            try
            {
                if (this.Valor_Entrada > 0)
                {
                    this.LB_Entrada.Visible = true;
                    this.TXB_Entrada_Dinheiro.Visible = true;
                    this.LB_Vaslor_Entrada.Visible = true;
                    this.TXB_Valor_Entrada.Visible = true;

                    this.TXB_Valor_Entrada.Text = this.Valor_Entrada.ToString();

                    // Há dados de entrada - Subtrair entrada do valor a ser lançado no contas a receber
                    this.Dados_Entrada = true;
                }
                else
                {
                    this.LB_Entrada.Visible = false;
                    this.TXB_Entrada_Dinheiro.Visible = false;
                    this.LB_Vaslor_Entrada.Visible = false;
                    this.TXB_Valor_Entrada.Visible = false;

                    this.TXB_Valor_Entrada.Text = string.Empty;

                    // Não há dados de entrada - Não subtrair entrada do valor a ser lançado no contas a receber
                    this.Dados_Entrada = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        // Adicionar dados de forma de pagamento = CRED. DA LODA
        public void Adicionar_Informacoes_Crediario_Loja()
        {
            if (this.Dados_Entrada)
            {
                decimal valor = 0;
                valor = this.totalPago - this.Valor_Entrada;
                
                // Abrir Onformações do Crediario da Loja
                FRM_Informacoes_Crediario_Loja frm = FRM_Informacoes_Crediario_Loja.GetInstancia();
                frm.Valor_Produtos_Servicos = valor; // valor total em produtos  - valor entrada
                frm.Data = this.dtData.Value;
                frm.Show();
            }
            else
            {
                // Abrir Onformações do Crediario da Loja
                FRM_Informacoes_Crediario_Loja frm = FRM_Informacoes_Crediario_Loja.GetInstancia();
                frm.Valor_Produtos_Servicos = this.totalPago; // valor total em produtos
                frm.Data = this.dtData.Value;
                frm.Show();
            }
        }

        public void Adicionar_Dados_Grid_Formas_Pgto_Cred_Loja(decimal Valor_Primario, decimal Valor_Final)
        {
            // Informando Tipo de Recebimento
            this.TXB_Recebimento.Text = "Crediário da Loja";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.dtFormas_Pgto.NewRow();
            row["forma"] = "Crediário da Loja";
            row["valor_primario"] = Valor_Primario;
            row["valor_final"] = Valor_Final;

            this.dtFormas_Pgto.Rows.Add(row);
        }

        // Variaveis e Metodos para inserir controle de cheque apos a venda
        private DataTable TBL_Dados_Pagamento_Cheque;

        public void Criar_Tabela_Pgto_Cheque()
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
        private string num_parcela = "";
        private decimal valor_cheque;
        private DateTime depositar_dia;

        // Adicionar dados de forma de pagamento = CHEQUE
        public void Adicionar_Informacoes_Cheque()
        {
            if (this.Dados_Entrada)
            {
                decimal valor = 0;
                valor = this.totalPago - this.Valor_Entrada;

                // Criar tabela para armazenar os dados temporariamente
                this.Criar_Tabela_Pgto_Cheque();

                // Abrir Informações do Cheque
                FRM_Informacoes_Cheque frm = FRM_Informacoes_Cheque.GetInstancia();
                frm.Valor_Total = valor; // valor total em produtos  - valor entrada
                frm.DTP_Data.Value = this.dtData.Value;
                frm.Show();
            }
            else
            {
                // Criar tabela para armazenar os dados temporariamente
                this.Criar_Tabela_Pgto_Cheque();

                // Abrir Onformações do Cheque
                FRM_Informacoes_Cheque frm = FRM_Informacoes_Cheque.GetInstancia();
                frm.Valor_Total = this.totalPago; // valor total em produtos
                frm.DTP_Data.Value = this.dtData.Value;
                frm.Show();
            }
        }


        public void Adicionar_Dados_Grid_Formas_Pgto_Cheque(decimal Valor_Primario, decimal Valor_Final)
        {
            // Informando Tipo de Recebimento
            this.TXB_Recebimento.Text = "Cheque";

            // Adicionar dados ao grid de formas de pagamento
            DataRow row = this.dtFormas_Pgto.NewRow();
            row["forma"] = "Cheque";
            row["valor_primario"] = Valor_Primario;
            row["valor_final"] = Valor_Final;
            this.dtFormas_Pgto.Rows.Add(row);
        }


        // Variaveis e Metodos para inserir controle de dinheiro apos a venda
        private decimal valor_dinheiro;
        private string historico_dinheiro = "VENDAS";
        
        //Variaveis para receber conteudo do Grid - frmVer_Produto_Entrada
        public int IdProduto;
        public string Produto;
        public decimal Preco_Venda;

        // Variavel para receber IdRemetente
        private int idremetente;

        // Variavel para deletar item (Quando a quantidade for maior que 1)
        public decimal quant_deletar = 0; 

        // Dados do Remetente
        private void Dados_Remetente()
        {
            // Recupernado dados
            this.DT_Dados = NRemetente.Mostrar();

            // Adicionado dados a variavel para gerar venda
            this.idremetente = Convert.ToInt32(this.DT_Dados.Rows[0][0]);
        }


        //Metodo Numeração Automática 
        private int Auxiliar_NA;    //Variavel Auxiliar

        private void Numeracao_Automatica()
        {
            this.DT_Num_Auto = NNumeracao_Auto.Mostrar_Num_Auto_Venda();
            this.Auxiliar_NA = Convert.ToInt32(this.DT_Num_Auto.Rows[0][2]);
        }


        // Mostrar Produtos pelo Codigode Barras
        public void Selecionar_Produto_Codigo_Barra()
        {
            this.DGV_Select_Prod_Cod_Barra.DataSource = NProduto.Selecionar_Produto_Codigo_Barra_Venda(Convert.ToString(this.dataListaDetalhes.CurrentRow.Cells[3].Value));
        }


        private void MoveNext()
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
                int index = this.dataListaDetalhes.CurrentRow.Index;

                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[5];
            }
            else if (this.dataListaDetalhes.CurrentRow.Cells[5].Selected)
            {
                this.CriarLinha();

                int index = this.dataListaDetalhes.CurrentRow.Index + 1;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
            }
        }

        public void Deletar_Mais_1_Item(decimal quant_deletar, int Linha_Atual, decimal Quant_Atual, decimal Valor_Item_Deletado, decimal Subtotal_Atual, decimal Preco_Custo_Item_Deletado, decimal Subtotal_Custo_Atual)
        {
            decimal valor_item_deletado = 0;
            decimal valor_atualizado = 0;
            decimal subtotal_atual = 0;
            decimal subtotal_deletado = 0;
            decimal quant_atual = 0;

            // VARIAVEIS P/ CALCULOS DE CUSTO
            decimal preco_custo_item_deletado = 0;
            decimal subtotal_custo_atual = 0;
            decimal subtotal_custo_deletado = 0;

            // Capturando quantidade atual
            quant_atual = Quant_Atual;

            // Capturando valor unitario do item a ser deletado
            valor_item_deletado = Valor_Item_Deletado;

            // Capturando subtotal atual
            subtotal_atual = Subtotal_Atual;

            // CAPTURANDO PREÇO CUSTO 
            preco_custo_item_deletado = Preco_Custo_Item_Deletado;

            // CAPTURANDO SUBTOTAL CUSTO ATUAL
            subtotal_custo_atual = Subtotal_Custo_Atual;

            // PREÇO DE VENDA -----------------------------------------------------------------------
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


            // PREÇO DE CUSTO ------------------------------------------------------------------------
            // Inicio
            subtotal_custo_deletado = quant_deletar * preco_custo_item_deletado;

            // Fim - Atualizar valor no grid
            this.dataListaDetalhes.Rows[Linha_Atual].Cells[7].Value = subtotal_custo_atual - subtotal_custo_deletado;
            
            // Selecionar ultima linha
            int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[2];
        }

        private void Deletar_Item_Permissao_TRUE(int Linha_Atual, decimal Quant_Atual, decimal Valor_Item_Deletado, decimal Subtotal_Atual, decimal Preco_Custo_Item_Deletado, decimal Subtotal_Custo_Atual)
        {
            decimal valor_item_deletado = 0;
            decimal valor_atualizado = 0;
            decimal subtotal_atualizado = 0;

            decimal quant_atual = Quant_Atual;
            if (quant_atual == 1)
            {
                // Pegando Valor do item a ser deletado
                valor_item_deletado = Valor_Item_Deletado;

                // Calculando novo total
                valor_atualizado = this.totalPago - valor_item_deletado;
                this.totalPago = valor_atualizado;

                // Mostrando novo total
                this.TXB_TotalPagar.Text = this.totalPago.ToString("C");

                // Deletar item
                int total_registros = this.dataListaDetalhes.Rows.Count - 1;
                
                if (Linha_Atual == total_registros)
                {
                    DataGridViewRow linha = dataListaDetalhes.Rows[Linha_Atual];
                    dataListaDetalhes.Rows.Remove(linha);

                    this.CriarLinha();
                }
                else
                {
                    DataGridViewRow linha = dataListaDetalhes.Rows[Linha_Atual];
                    dataListaDetalhes.Rows.Remove(linha);
                }

                // Selecionar ultima linha
                int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[2];

                this.dataListaDetalhes.Focus();
                this.CHK_Selecionar.Checked = false;
            }
            else if (quant_atual > 1)
            {
                FRM_Deletar_mais_1_Item_Venda frm = FRM_Deletar_mais_1_Item_Venda.GetInstancia();
                frm.linha_atual = Linha_Atual;
                frm.quant_atual = Quant_Atual;
                frm.valor_item_deletado = Valor_Item_Deletado;
                frm.subtotal_atual = Subtotal_Atual;
                frm.preco_custo_item_deletado = Preco_Custo_Item_Deletado;
                frm.subtotal_custo_atual = Subtotal_Custo_Atual;
                frm.Show();
            }
        }


        public void Deletar_Item_Permissao_FALSE(bool Permitido, int Linha_Atual, decimal Quant_Atual, decimal Valor_Item_Deletado, decimal Subtotal_Atual, decimal Preco_Custo_Item_Deletado, decimal Subtotal_Custo_Atual)
        {
            if (Permitido)
            {
                decimal valor_item_deletado = 0;
                decimal valor_atualizado = 0;
                decimal subtotal_atualizado = 0;

                decimal quant_atual = Quant_Atual;
                if (quant_atual == 1)
                {
                    // Pegando Valor do item a ser deletado
                    valor_item_deletado = Valor_Item_Deletado;

                    // Calculando novo total
                    valor_atualizado = this.totalPago - valor_item_deletado;
                    this.totalPago = valor_atualizado;

                    // Mostrando novo total
                    this.TXB_TotalPagar.Text = this.totalPago.ToString("C");

                    // Deletar item
                    int total_registros = this.dataListaDetalhes.Rows.Count - 1;
                   
                    if (Linha_Atual == total_registros)
                    {
                        DataGridViewRow linha = dataListaDetalhes.Rows[Linha_Atual];
                        dataListaDetalhes.Rows.Remove(linha);

                        this.CriarLinha();
                    }
                    else
                    {
                        DataGridViewRow linha = dataListaDetalhes.Rows[Linha_Atual];
                        dataListaDetalhes.Rows.Remove(linha);
                    }

                    // Selecionar ultima linha
                    int total_registros_atualizado = this.dataListaDetalhes.Rows.Count - 1;
                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[total_registros_atualizado].Cells[2];

                    this.dataListaDetalhes.Focus();
                    this.CHK_Selecionar.Checked = false;
                }
                else if (quant_atual > 1)
                {
                    FRM_Deletar_mais_1_Item_Venda frm = FRM_Deletar_mais_1_Item_Venda.GetInstancia();
                    frm.linha_atual = Linha_Atual;
                    frm.quant_atual = Quant_Atual;
                    frm.valor_item_deletado = Valor_Item_Deletado;
                    frm.subtotal_atual = Subtotal_Atual;
                    frm.preco_custo_item_deletado = Preco_Custo_Item_Deletado;
                    frm.subtotal_custo_atual = Subtotal_Custo_Atual;
                    frm.Show();
                }
            }
        }

        // Calcular Proximo dia util
        private DateTime diaUtil(DateTime dt)
        {
            while (true)
            {
                if (dt.DayOfWeek == DayOfWeek.Saturday)
                {
                    if (this.prazo_compensacao_cartao_debito == 1)
                    {
                        dt = dt.AddDays(2);
                        return diaUtil(dt);
                    }
                    else
                    {
                        dt = dt.AddDays((2) + (this.prazo_compensacao_cartao_debito - 1));
                        return diaUtil(dt);
                    }
                }
                else if (dt.DayOfWeek == DayOfWeek.Sunday)
                {
                    if (this.prazo_compensacao_cartao_debito == 1)
                    {
                        dt = dt.AddDays(1);
                        return diaUtil(dt);
                    }
                    else
                    {
                        dt = dt.AddDays((1) + (this.prazo_compensacao_cartao_debito - 1));
                        return diaUtil(dt);
                    }
                }
                else if (Feriado(dt) == true)
                {
                    if (this.prazo_compensacao_cartao_debito == 1)
                    {
                        dt = dt.AddDays(1);
                        return diaUtil(dt);
                    }
                    else
                    {
                        dt = dt.AddDays((1) + (this.prazo_compensacao_cartao_debito - 1));
                        return diaUtil(dt);
                    }
                }
                else return dt;
            }
        }

        public bool Feriado(DateTime data)
        {
            this.TBL_Dados_Feriados = NFeriado.Buscar_Feriado(data.ToString("dd/MM/yyyy"));
            
            if (this.TBL_Dados_Feriados.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Obter Dados para calcular comissão do funcionario
        private decimal Comissao_funcionario = 0;
        private string Tipo_comisao_funcionario = "";

        private void Dados_Comissão_Funcionario(string idfuncionario)
        {
            DataTable TBL_Dados_Funcionario = NFuncionario.Buscar_ID(idfuncionario);
            this.Comissao_funcionario = Convert.ToDecimal(TBL_Dados_Funcionario.Rows[0][22]);
            this.Tipo_comisao_funcionario = TBL_Dados_Funcionario.Rows[0][23].ToString();
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Caixa _Instancia;

        public static FRM_Caixa GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Caixa();
            }
            return _Instancia;
        }

        public FRM_Caixa()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.BTN_Selecionar_Cliente, "Clique para selecionar o cliente");
           
            this.DGV_Select_Prod_Cod_Barra.Visible = false;
            this.GB_Efetuar_Venda.Visible = false;
         
            this.TXB_TotalPagar.BackColor = Color.WhiteSmoke;
            this.TXB_TotalPagar.ForeColor = Color.Red;

            this.TXB_Troco.BackColor = Color.WhiteSmoke;
            this.TXB_Troco.ForeColor = Color.Green;
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

        //Mostrar mensagem de Erro
        private void MensagemAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        //Limpar campos
        private void Limpar()
        {
            this.txtId.Text = string.Empty;
            this.dtData.Text = string.Empty;
            this.TXB_IdCliente.Text = "0";
            this.TXB_Nome_Cliente.Text = "CONSUMIDOR";
            this.txtNum_Comprovante.Text = string.Empty;
            this.totalPago = 0;
            this.limite = 0;
            this.limite_usado = 0;
            this.resto_limite = 0;
            this.TXB_TotalPagar.Text = "R$ 0,00";
            this.TXB_Troco.Text = string.Empty;
            this.TXT_Recebido.Text = string.Empty;
            this.TXB_Recebimento.Text = string.Empty;
            this.TXB_Entrada_Dinheiro.Text = string.Empty;
            this.Valor_Entrada = 0;
            this.TXB_Valor_Entrada.Text = string.Empty;
        }


        //Habilitar os textBox
        public void Habilitar(bool valor)
        {
            this.dtData.Enabled = valor;
            this.cbTipo_Comprovante.Enabled = valor;
        }

        //Habilitar os Botões
        public void botoes()
        {
            if (this.eNovo)
            {
                this.Habilitar(true);
                this.btnSalvar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnSalvar.Enabled = false;
            }
        }

      
        // Mostrar Detalhes Entrada
        private void MostrarDetalheEntrada()
        {
            this.dataListaDetalhes.DataSource = NVenda.MostrarDetalhes(txtId.Text);
        }
        
        
        // Metodo Pegar Prosutos para Venda
        public void SetProduto(int idproduto, string descricao, decimal preco_venda, decimal preco_custo, string tipo, decimal estoque_atual, decimal estoque_ideal)
        {
            bool salvar = true;
            foreach (DataGridViewRow linha in dataListaDetalhes.Rows)
            {
                if (linha.Cells[1].Value.Equals(idproduto))
                {
                    salvar = false;
                    this.chave = false;

                    MessageBox.Show("Este produto ou serviço já foi adicionado a lista.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.dataListaDetalhes.CurrentRow.Cells[3].ReadOnly = false;
                }
            }
            if (salvar)
            {
                if (this.dataListaDetalhes.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                    this.dataListaDetalhes.CurrentRow.Cells[2].Value = 1;
                    this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                    this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                    this.dataListaDetalhes.CurrentRow.Cells[6].Value = preco_custo;
                    this.dataListaDetalhes.CurrentRow.Cells[8].Value = tipo;
                }
                else
                {
                    this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                    this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                    this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                    this.dataListaDetalhes.CurrentRow.Cells[6].Value = preco_custo;
                    this.dataListaDetalhes.CurrentRow.Cells[8].Value = tipo;
                }
                
                if (estoque_atual < estoque_ideal)
                {
                    this.MensagemAlerta("Estoque abaixo do ideal.");
                }
            }
        }


        // Metodo Pegar Cliente para Venda
        public void SetCliente(string idcliente, string nome_completo, decimal limite_credito)
        {
            this.TXB_IdCliente.Text = idcliente;
            this.TXB_Nome_Cliente.Text = nome_completo;
            this.limite = limite_credito;
        }

        public void Analise_Credito()
        {
            this.DT_Limite_Credito_Usado = NVenda.Limite_Credito_Usado(this.TXB_IdCliente.Text);
            
            if (DT_Limite_Credito_Usado.Rows.Count >= 1)
            {
                for (int i = 0; i <= this.DT_Limite_Credito_Usado.Rows.Count - 1; i++)
                {
                    if (this.DT_Limite_Credito_Usado.Rows[i][2].ToString() != "")
                    {
                        this.limite_usado += Convert.ToDecimal(this.DT_Limite_Credito_Usado.Rows[i][2]);
                    }
                }
            }

            // RESTA DO LIMITE DE CREDITO
            this.resto_limite = this.limite - this.limite_usado;
        }

        private bool Imprimir = false;

        public void Imprimir_Comprovante_Crediario_Loja(int idvenda, bool imprimir)
        {
            if (imprimir)
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja imprimir o comprovante de venda?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcao == DialogResult.Yes)
                {
                    FRM_Comp_Venda_Parcelado_Guiche frm = new FRM_Comp_Venda_Parcelado_Guiche();
                    frm.IdVenda = idvenda;
                    frm.Show();
                }
            }
        }
        
        private void Imprimir_Comprovante_Demais_Formas_Pgto(int idvenda, bool imprimir)
        {
            if (imprimir)
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Deseja imprimir o comprovante de venda?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcao == DialogResult.Yes)
                {
                    FRM_Comp_Venda_Demais_Formas_Pgto_Guiche frm = new FRM_Comp_Venda_Demais_Formas_Pgto_Guiche();
                    frm.IdVenda = idvenda;
                    frm.Show();
                }
            }
        }

        // Metodo Seletor de Comprovante a ser impresso
        private void Impressao_Comrpovante(int idvenda, bool imprimir)
        {
            bool chave = false;
            foreach (DataGridViewRow l in DGV_Formas_Pagamento.Rows)
            {
                if (l.Cells[0].Value.Equals("Crediário da Loja"))
                {
                    chave = true;
                }
            }
            if (chave)
            {
                this.Imprimir_Comprovante_Crediario_Loja(idvenda, imprimir);
            }
            else
            {
                this.Imprimir_Comprovante_Demais_Formas_Pgto(idvenda, imprimir);
            }
        }



        // >>>>> IMPORTAÇÃO DE O.S. - Metodo e variaveis <<<<<
        private int ID_OS_Importada = 0;
        private bool Importacao_OS = false;
        public void Importar_OS(int IDOS)
        {
            try
            {
                bool item_no_import = false;
                decimal subtotal_itens_removidos = 0;

                // Quardando temporariamente ID OS Importada
                this.ID_OS_Importada = IDOS;

                // Obtendo dados 
                DataTable TBL_Dados_Principais_OS = NOS.Buscar_OS_Pronta_ID(IDOS);
                DataTable TBL_Dados_Secundarios_OS = NOS.MostrarDetalhes_Import_Caixa(IDOS);

                if (TBL_Dados_Principais_OS.Rows.Count > 0)
                {
                    this.Importacao_OS = true;
                    this.CHK_Venda_Rapida.Checked = false;
                    this.TXB_IdCliente.Text = TBL_Dados_Principais_OS.Rows[0][5].ToString();
                    this.TXB_Nome_Cliente.Text = TBL_Dados_Principais_OS.Rows[0][6].ToString();
                }
                if (TBL_Dados_Secundarios_OS.Rows.Count > 0)
                {
                    // Excluir Linhas Existentes
                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                    {
                        int linha = dataListaDetalhes.Rows[i].Index;
                        DataGridViewRow row = dataListaDetalhes.Rows[linha];
                        dataListaDetalhes.Rows.Remove(row);
                    }


                    // Importando Dados dos Produtos / Serviços da OS para o caixa
                    // VARIAVEIS 
                    int idproduto = 0;
                    decimal quant = 0;
                    string produto = "";
                    decimal preco_venda = 0;
                    decimal subtotal = 0;
                    decimal preco_custo = 0;
                    decimal subtotal_custo = 0;
                    string tipo_produto = "";

                    decimal qtd_disponivel = 0;

                    for (int i = 0; i <= TBL_Dados_Secundarios_OS.Rows.Count - 1; i++)
                    {
                        idproduto = Convert.ToInt32(TBL_Dados_Secundarios_OS.Rows[i][0]);
                        quant = Convert.ToDecimal(TBL_Dados_Secundarios_OS.Rows[i][1]);
                        produto = Convert.ToString(TBL_Dados_Secundarios_OS.Rows[i][2]);
                        preco_venda = Convert.ToDecimal(TBL_Dados_Secundarios_OS.Rows[i][3]);
                        subtotal = Convert.ToDecimal(TBL_Dados_Secundarios_OS.Rows[i][4]);
                        preco_custo = Convert.ToDecimal(TBL_Dados_Secundarios_OS.Rows[i][5]);
                        subtotal_custo = Convert.ToDecimal(TBL_Dados_Secundarios_OS.Rows[i][6]);
                        tipo_produto = Convert.ToString(TBL_Dados_Secundarios_OS.Rows[i][7]);

                        DataTable TBL_Produto_Disponivel = NProduto.Buscar_ID_import(idproduto);
                        if (TBL_Produto_Disponivel.Rows.Count == 1)
                        {
                            qtd_disponivel = Convert.ToDecimal(TBL_Produto_Disponivel.Rows[0]["quant_atual"]);
                            if (qtd_disponivel >= quant)
                            {
                                DataRow row = this.dtDetalhe.NewRow();
                                row["idproduto"] = idproduto;
                                row["quant"] = quant;
                                row["produto"] = produto;
                                row["preco_venda"] = preco_venda;
                                row["subtotal"] = subtotal;
                                row["preco_custo"] = preco_custo;
                                row["subtotal_custo"] = subtotal_custo;
                                row["tipo_produto"] = tipo_produto;
                                this.dtDetalhe.Rows.Add(row);
                            }
                            else
                            {
                                if (tipo_produto.Equals("SERVIÇO"))
                                {
                                    DataRow row = this.dtDetalhe.NewRow();
                                    row["idproduto"] = idproduto;
                                    row["quant"] = quant;
                                    row["produto"] = produto;
                                    row["preco_venda"] = preco_venda;
                                    row["subtotal"] = subtotal;
                                    row["preco_custo"] = preco_custo;
                                    row["subtotal_custo"] = subtotal_custo;
                                    row["tipo_produto"] = tipo_produto;
                                    this.dtDetalhe.Rows.Add(row);
                                }
                                else
                                {
                                    DataRow row = this.dtDetalhe.NewRow();
                                    row["idproduto"] = idproduto;
                                    row["quant"] = qtd_disponivel;
                                    row["produto"] = produto;
                                    row["preco_venda"] = preco_venda;
                                    row["subtotal"] = subtotal;
                                    row["preco_custo"] = preco_custo;
                                    row["subtotal_custo"] = subtotal_custo;
                                    row["tipo_produto"] = tipo_produto;
                                    this.dtDetalhe.Rows.Add(row);

                                    subtotal_itens_removidos += (subtotal) - (qtd_disponivel * preco_venda);
                                }
                            }
                        }
                        else
                        {
                            item_no_import = true;
                            subtotal_itens_removidos += subtotal;
                        }
                    }

                    // Calculando Total Geral
                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                    {
                        this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                        this.TXB_TotalPagar.Text = this.totalPago.ToString("C");
                    }
                }
                this.MensagemOk("Importação realizada com sucesso.");
                if (item_no_import)
                {
                    this.MensagemAlerta("Alguns itens deste orçamento não foram importados ou foram parcialmente, pois não há quantidade suficiente no estoque.");
                    this.CriarTabela_FP();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Atualizar status geral da O.S. importada
        private void Atualizar_Status_OS_Importada()
        {
            if (this.Importacao_OS && this.ID_OS_Importada > 0)
            {
                string resp = "";
                string Data_Retirada = DateTime.Now.ToString("dd/MM/yyyy  HH:mm");

                resp = NOS.Atualizar_Status_OS_Importada(this.ID_OS_Importada, Data_Retirada);
            }
        }



        // >>>>> IMPORTAÇÃO DE ORÇAMENTO - Metodos e Variaveis <<<<<
        private int ID_Orcamento_Importado = 0;
        private bool Importacao_Orcamento = false;

        public void Importar_Orcamento(int IDORCAMENTO)
        {
            try
            {
                bool item_no_import = false;
                decimal subtotal_itens_removidos = 0;

                // Quardando temporariamente ID Orçamento Importado
                this.ID_Orcamento_Importado = IDORCAMENTO;

                // Obtendo dados 
                DataTable TBL_Dados_Principais_Orcamento = NOrcamento.Buscar_ID(IDORCAMENTO);
                DataTable TBL_Dados_Produtos_Orcamento = NOrcamento.Mostrar_Produtos_Orcamento_import_Caixa(IDORCAMENTO);
                DataTable TBL_Dados_Pagamento_Orcamento = NOrcamento.Mostrar_Formas_Pgto_Orcamento(IDORCAMENTO);
                
                if (TBL_Dados_Principais_Orcamento.Rows.Count > 0)
                {
                    this.Importacao_Orcamento = true;
                    this.BTN_Selecionar_Cliente.Enabled = true;

                    string entrada_dinheiro = TBL_Dados_Principais_Orcamento.Rows[0][4].ToString();
                    decimal valor_entrada = Convert.ToDecimal(TBL_Dados_Principais_Orcamento.Rows[0][5]);

                    this.Set_Detalhe_Recebimento(entrada_dinheiro, valor_entrada);
                }
                if (TBL_Dados_Produtos_Orcamento.Rows.Count > 0)
                {
                    this.Importacao_Orcamento = true;

                    // Excluir Linhas Existentes
                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                    {
                        int linha = dataListaDetalhes.Rows[i].Index;
                        DataGridViewRow row = dataListaDetalhes.Rows[linha];
                        dataListaDetalhes.Rows.Remove(row);
                    }

                    // Importando Dados dos Produtos / Serviços da OS para o caixa
                    // VARIAVEIS 
                    int idproduto = 0;
                    decimal quant = 0;
                    string produto = "";
                    decimal preco_venda = 0;
                    decimal subtotal = 0;
                    decimal preco_custo = 0;
                    decimal subtotal_custo = 0;
                    string tipo_produto = "";

                    decimal qtd_disponivel = 0;
                    
                    for (int i = 0; i <= TBL_Dados_Produtos_Orcamento.Rows.Count - 1; i++)
                    {
                        idproduto = Convert.ToInt32(TBL_Dados_Produtos_Orcamento.Rows[i][0]);
                        quant = Convert.ToDecimal(TBL_Dados_Produtos_Orcamento.Rows[i][1]);
                        produto = Convert.ToString(TBL_Dados_Produtos_Orcamento.Rows[i][2]);
                        preco_venda = Convert.ToDecimal(TBL_Dados_Produtos_Orcamento.Rows[i][3]);
                        subtotal = Convert.ToDecimal(TBL_Dados_Produtos_Orcamento.Rows[i][4]);
                        preco_custo = Convert.ToDecimal(TBL_Dados_Produtos_Orcamento.Rows[i][5]);
                        subtotal_custo = Convert.ToDecimal(TBL_Dados_Produtos_Orcamento.Rows[i][6]);
                        tipo_produto = Convert.ToString(TBL_Dados_Produtos_Orcamento.Rows[i][7]);

                        DataTable TBL_Produto_Disponivel = NProduto.Buscar_ID_import(idproduto);
                        if (TBL_Produto_Disponivel.Rows.Count == 1)
                        {
                            qtd_disponivel = Convert.ToDecimal(TBL_Produto_Disponivel.Rows[0]["quant_atual"]);
                            if (qtd_disponivel >= quant)
                            {
                                DataRow row = this.dtDetalhe.NewRow();
                                row["idproduto"] = idproduto;
                                row["quant"] = quant;
                                row["produto"] = produto;
                                row["preco_venda"] = preco_venda;
                                row["subtotal"] = subtotal;
                                row["preco_custo"] = preco_custo;
                                row["subtotal_custo"] = subtotal_custo;
                                row["tipo_produto"] = tipo_produto;
                                this.dtDetalhe.Rows.Add(row);
                            }
                            else
                            {
                                if (tipo_produto.Equals("SERVIÇO"))
                                {
                                    DataRow row = this.dtDetalhe.NewRow();
                                    row["idproduto"] = idproduto;
                                    row["quant"] = quant;
                                    row["produto"] = produto;
                                    row["preco_venda"] = preco_venda;
                                    row["subtotal"] = subtotal;
                                    row["preco_custo"] = preco_custo;
                                    row["subtotal_custo"] = subtotal_custo;
                                    row["tipo_produto"] = tipo_produto;
                                    this.dtDetalhe.Rows.Add(row);
                                }
                                else
                                {
                                    DataRow row = this.dtDetalhe.NewRow();
                                    row["idproduto"] = idproduto;
                                    row["quant"] = qtd_disponivel;
                                    row["produto"] = produto;
                                    row["preco_venda"] = preco_venda;
                                    row["subtotal"] = subtotal;
                                    row["preco_custo"] = preco_custo;
                                    row["subtotal_custo"] = subtotal_custo;
                                    row["tipo_produto"] = tipo_produto;
                                    this.dtDetalhe.Rows.Add(row);

                                    subtotal_itens_removidos += (subtotal) - (qtd_disponivel* preco_venda);
                                }
                            }
                        }
                        else
                        {
                            item_no_import = true;
                            subtotal_itens_removidos += subtotal;
                        }
                    }

                    // Calculando Total Geral
                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                    {
                        this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                        this.TXB_TotalPagar.Text = this.totalPago.ToString("C");
                    }
                }
                if (TBL_Dados_Pagamento_Orcamento.Rows.Count > 0)
                {
                    // Informando Tipo de Recebimento
                    this.TXB_Recebimento.Text = TBL_Dados_Pagamento_Orcamento.Rows[0][2].ToString();

                    // Adicionar dados ao grid de formas de pagamento
                    DataRow row = this.dtFormas_Pgto.NewRow();
                    row["forma"] = TBL_Dados_Pagamento_Orcamento.Rows[0][2].ToString();
                    row["valor_primario"] = Convert.ToDecimal(TBL_Dados_Pagamento_Orcamento.Rows[0][3]);
                    row["valor_final"] = Convert.ToDecimal(TBL_Dados_Pagamento_Orcamento.Rows[0][4]);
                    this.dtFormas_Pgto.Rows.Add(row);

                    if (this.TXB_Recebimento.Text.Equals("Crediário da Loja") || this.TXB_Recebimento.Text.Equals("Cheque"))
                    {
                        this.CHK_Venda_Rapida.Checked = false;
                        this.TXB_IdCliente.Text = string.Empty;
                        this.TXB_Nome_Cliente.Text = string.Empty;
                    }
                    else
                    {
                        this.CHK_Venda_Rapida.Checked = true;
                        this.TXB_IdCliente.Text = "0";
                        this.TXB_Nome_Cliente.Text = "CONSUMIDOR";
                    }

                    // Adicionando informações as variaveis e tabelas de Pagamento
                    foreach (DataGridViewRow linha in DGV_Formas_Pagamento.Rows)
                    {
                        if (linha.Cells[0].Value.Equals("Cartão de Crédito"))
                        {
                            DataTable TBL_Dados_FP_Card_Cred_Orcamento = NDados_FP_Card_Cred_Orcamento.Mostrar(IDORCAMENTO);
                            this.bandeira_cartao_credito = TBL_Dados_FP_Card_Cred_Orcamento.Rows[0][0].ToString();
                            this.valor_cartao_credito = Convert.ToDecimal(TBL_Dados_FP_Card_Cred_Orcamento.Rows[0][1]);
                            this.quant_parcelas_cartao_credito = Convert.ToInt32(TBL_Dados_FP_Card_Cred_Orcamento.Rows[0][2]);
                        }
                        else if (linha.Cells[0].Value.Equals("Cartão de Debito"))
                        {
                            DataTable TBL_Dados_FP_Card_Deb_Orcamento = NDados_FP_Card_Deb_Orcamento.Mostrar(IDORCAMENTO);
                            this.bandeira_cartao_debito = TBL_Dados_FP_Card_Deb_Orcamento.Rows[0][0].ToString();
                        }
                        else if (linha.Cells[0].Value.Equals("Cheque"))
                        {
                            this.TBL_Dados_Pagamento_Cheque = NDados_FP_Cheque_Orcamento.Mostrar(IDORCAMENTO);
                        }
                        else if (linha.Cells[0].Value.Equals("Crediário da Loja"))
                        {
                            this.TBL_Info_Crediario_Loja = NDados_FP_Cred_Loja_Orcamento.Mostrar(IDORCAMENTO);
                        }
                        else if (linha.Cells[0].Value.Equals("Dinheiro"))
                        {
                            // Mostrar Calculador de troco
                            this.LB_Recebido.Visible = true;
                            this.TXT_Recebido.Visible = true;
                            this.LB_Troco.Visible = true;
                            this.TXB_Troco.Visible = true;
                        }
                    }
                }
                this.MensagemOk("Importação realizada com sucesso.");
                if (item_no_import)
                {
                    this.MensagemAlerta("Alguns itens deste orçamento não foram importados ou foram parcialmente, pois não há quantidade suficiente no estoque.");
                    this.CriarTabela_FP();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        // Metodo para Deletar Orçamento Importado
        private void Deletar_Orcamento_Importado()
        {
            if (this.Importacao_Orcamento && this.ID_Orcamento_Importado > 0)
            {
                string resp = "";
                
                resp = NOrcamento.Excluir(this.ID_Orcamento_Importado);
            }
        }


        // Metodo Entrada em Dinheiro e Venda a Vista
        private bool Lancar_Caixa = false;
        private void Lancamento_Livro_Caixa_VendaAVista_Entrada(bool lancar_caixa)
        {
            if (lancar_caixa)
            {
                string resp = "";
                if (this.TXB_Entrada_Dinheiro.Text.Equals("SIM") && this.Valor_Entrada > 0)
                {
                    // Capturando Dados
                    DateTime Data = dtData.Value; // Data

                    // Executando inserção
                    resp = NLivro_Caixa.Inserir(Data, "ENTRADA REF. VENDA Nº " + this.txtNum_Comprovante.Text, this.txtNum_Comprovante.Text, this.Valor_Entrada, Convert.ToDecimal("0,00"));
                }
                else
                {
                    foreach (DataGridViewRow LNH in DGV_Formas_Pagamento.Rows)
                    {
                        if (LNH.Cells[0].Value.Equals("Dinheiro"))
                        {
                            // Capturando Dados
                            DateTime Data = dtData.Value; // Data
                            decimal valor_a_vista = Convert.ToDecimal(LNH.Cells[2].Value);

                            // Executando inserção
                            resp = NLivro_Caixa.Inserir(Data, "VENDA A VISTA", this.txtNum_Comprovante.Text, valor_a_vista, Convert.ToDecimal("0,00"));
                        }
                    }
                }
            }
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios_Ativado()
        {
            if (this.eNovo )
            {
                this.TXB_IdCliente.BackColor = Color.LemonChiffon;
                this.TXB_Nome_Cliente.BackColor = Color.LemonChiffon;
                this.dataListaDetalhes.BackgroundColor = Color.LemonChiffon;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_IdCliente.BackColor = Color.WhiteSmoke;
                this.TXB_Nome_Cliente.BackColor = Color.WhiteSmoke;
                this.dataListaDetalhes.BackgroundColor = Color.White;
                this.DGV_Formas_Pagamento.BackgroundColor = Color.White;
            }
        }
        
        private void Alerta_Campos_Obrigatorios_Desativado()
        {
            this.TXB_IdCliente.BackColor = Color.White;
            this.TXB_Nome_Cliente.BackColor = Color.White;
            this.dataListaDetalhes.BackgroundColor = Color.White;
            this.DGV_Formas_Pagamento.BackgroundColor = Color.White;
        }

        private void FRM_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            this.BTN_Importar_OS.Enabled = false;
            this.limite = 0;
            this.limite_usado = 0;
            this.resto_limite = 0;
            this.Importacao_OS = false;
            this.ID_OS_Importada = 0;
            this.Importacao_Orcamento = false;
            this.ID_Orcamento_Importado = 0;
            this.Alerta_Campos_Obrigatorios_Desativado();
        }

        private void FRM_Caixa_Load(object sender, EventArgs e)
        {
            this.txtId.Visible = false;
          //  this.Numeracao_Automatica();
            this.Dados_Remetente();
        }


        // Tabela Detalhe Vendas (Produtos)
        public void CriarTabela()
        {
            this.dtDetalhe = new DataTable("Detalhe");
            this.dtDetalhe.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("quant", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("preco_custo", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("subtotal_custo", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("tipo_produto", System.Type.GetType("System.String"));

            this.dataListaDetalhes.DataSource = this.dtDetalhe;
            
            //Ocultar Coluna do Grid
            this.dataListaDetalhes.Columns[1].Visible = false;
            this.dataListaDetalhes.Columns[6].Visible = false;
            this.dataListaDetalhes.Columns[7].Visible = false;
            this.dataListaDetalhes.Columns[8].Visible = false;

            //definir tamanho do Grid
            this.dataListaDetalhes.Columns[3].Width = 510;

            //Formatar Grid
            this.dataListaDetalhes.Columns[4].DefaultCellStyle.Format = "c";
            this.dataListaDetalhes.Columns[5].DefaultCellStyle.Format = "c";
        }


        //Metodo criar linha no Grid - dataListaDetalhes ao iniciar
        public void CriarLinha()
        {
            DataRow row = this.dtDetalhe.NewRow();
            this.dtDetalhe.Rows.Add(row);

            this.CriarTabela_FP();
        }


        // Tabela Formas de Pagamento
        public void CriarTabela_FP()
        {
            this.dtFormas_Pgto = new DataTable("Pagamento");
            this.dtFormas_Pgto.Columns.Add("forma", System.Type.GetType("System.String"));
            this.dtFormas_Pgto.Columns.Add("valor_primario", System.Type.GetType("System.Decimal"));
            this.dtFormas_Pgto.Columns.Add("valor_final", System.Type.GetType("System.Decimal"));

            this.DGV_Formas_Pagamento.DataSource = this.dtFormas_Pgto;

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

        private void btnNova_Venda_Click(object sender, EventArgs e)
        {
            this.Dados_Comissão_Funcionario(this.idfuncionario.ToString());

            FRM_Abrir_Caixa frm = FRM_Abrir_Caixa.GetInstancia();
            frm.IdFuncionario = this.idfuncionario;
            frm.nome_funcionario = this.Nome_Funcionario;
            frm.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.GB_Efetuar_Venda.Visible = false;
            this.eNovo = false;
            this.totalPago = 0;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.LB_Cx_Livre.Visible = false;
            this.btnNova_Venda.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Todos os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                this.Atualizador_Constante = false;
                this.dataListaDetalhes.Focus();
                try
                {
                    string resp = "";
                    if (this.TXB_IdCliente.Text == string.Empty || this.TXB_Nome_Cliente.Text == string.Empty || this.txtNum_Comprovante.Text == "" || this.DGV_Formas_Pagamento.Rows.Count == 0 || this.dataListaDetalhes.Rows.Count == 0)
                    {
                        MensagemErro("Preencha todos os campos obrigatórios.");
                        this.Alerta_Campos_Obrigatorios_Ativado();
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

                            // Executar Calculo de Comissão do Funcionario
                            decimal comissão_paga = 0;
                            if (this.Tipo_comisao_funcionario.Equals("Lucro da Venda"))
                            {
                                decimal Total_Venda = 0;
                                decimal Custo_Total_Venda = 0;
                                decimal Lucro_Total_Venda = 0;
                                for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                                {
                                    Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                    Custo_Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[7].Value);
                                }
                                Lucro_Total_Venda = Total_Venda - Custo_Total_Venda;
                                comissão_paga = (Lucro_Total_Venda * this.Comissao_funcionario) / (100);
                            }
                            else
                            {
                                decimal Total_Venda = 0;
                                for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                                {
                                    Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                }
                                comissão_paga = (Total_Venda * this.Comissao_funcionario) / (100);
                            }

                            // Executar Metodo Salvar
                            resp = NVenda.Inserir(idremetente, this.idguiche_atendimento, dtData.Value, Convert.ToInt32(TXB_IdCliente.Text), idfuncionario,
                                cbTipo_Comprovante.Text, txtNum_Comprovante.Text, this.TXB_Recebimento.Text, this.TXB_Entrada_Dinheiro.Text, this.Valor_Entrada, comissão_paga, dtDetalhe, dtFormas_Pgto);
                        }

                        if (resp.Equals("Ok"))
                        {
                            if (this.eNovo)
                            {
                                this.MensagemOk("Registro salvo com sucesso");

                                // Atualizar Status OS Importada, caso haja
                                this.Atualizar_Status_OS_Importada();

                                // Deletar Orçamento Importado, caso haja
                                this.Deletar_Orcamento_Importado();

                                // IDVENDA
                                DataTable Dados_Venda = NVenda.Mostrar();
                                this.idvenda = Convert.ToInt32(Dados_Venda.Rows[0][0]);

                                foreach (DataGridViewRow l in DGV_Formas_Pagamento.Rows)
                                {
                                    if (l.Cells[0].Value.Equals("Cartão de Crédito"))
                                    {
                                        // Declarando Variaveis
                                        string num_parcela = "";
                                        int contador = 0;

                                        // Capturando Dados Necessarios
                                        this.TBL_Info_Config_Cartao_Credito = NConfig_Cartao_Credito.Mostrar();
                                        DateTime Data_Compensacao = this.dtData.Value;

                                        // Prazo de Compensação e taxa
                                        foreach (DataRow line in TBL_Info_Config_Cartao_Credito.Rows)
                                        {
                                            if (line[1].ToString().Equals(this.bandeira_cartao_credito))
                                            {
                                                this.Prazo_Primeira_Pac = Convert.ToInt32(line[2]);
                                                this.Prazo_Demais_Parc = Convert.ToInt32(line[3]);
                                                this.taxa_cartao_credito = Convert.ToDecimal(line[4]);
                                            }
                                        }

                                        // Pré - Operação
                                        this.valor_liquido_cartao_credito = this.valor_cartao_credito - (this.valor_cartao_credito * this.taxa_cartao_credito / 100);

                                        // Executando Operação
                                        contador++;

                                        num_parcela = contador.ToString() + " / " + this.quant_parcelas_cartao_credito.ToString();
                                        Data_Compensacao = Data_Compensacao.AddDays(this.Prazo_Primeira_Pac);

                                        resp = NCartao_Credito.Inserir(this.bandeira_cartao_credito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_credito, this.valor_liquido_cartao_credito, Data_Compensacao);

                                        for (int i = 0; i < this.quant_parcelas_cartao_credito - 1; i++)
                                        {
                                            contador++;

                                            num_parcela = contador.ToString() + " / " + this.quant_parcelas_cartao_credito.ToString();
                                            Data_Compensacao = Data_Compensacao.AddDays(this.Prazo_Demais_Parc);

                                            resp = NCartao_Credito.Inserir(this.bandeira_cartao_credito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_credito, this.valor_liquido_cartao_credito, Data_Compensacao);
                                        }

                                        // Entrada em Dinheiro ou Venda a Vista
                                        this.Lancar_Caixa = true;

                                        // Imprimir Comprovante
                                        this.Imprimir = true;
                                    }
                                    else if (l.Cells[0].Value.Equals("Cartão de Debito"))
                                    {
                                        DataTable TBL_Config_Cartao_Debito = NConfig_Cartao_Debito.Mostrar();

                                        // Prazo de Compensação e taxa
                                        foreach (DataRow R in TBL_Config_Cartao_Debito.Rows)
                                        {
                                            if (R[1].ToString().Equals(this.bandeira_cartao_debito))
                                            {
                                                this.prazo_compensacao_cartao_debito = Convert.ToInt32(R[2]);
                                                this.taxa_cartao_debito = Convert.ToDecimal(R[3]);
                                            }
                                        }

                                        DateTime Data_Compensacao = this.diaUtil(this.dtData.Value);
                                        DateTime Data_Compensacao2 = this.dtData.Value.AddDays(this.prazo_compensacao_cartao_debito);

                                        // Numero da parcela
                                        string num_parcela = "1 / 1";

                                        // Obtendo valor 
                                        this.valor_cartao_debito = Convert.ToDecimal(l.Cells[2].Value);

                                        // Calculando valor liquido
                                        decimal valor_liquido = this.valor_cartao_debito - (this.valor_cartao_debito * this.taxa_cartao_debito / 100);

                                        if (this.dtData.Value.ToString("dd/MM/yyyy") == Data_Compensacao.ToString("dd/MM/yyyy"))
                                        {
                                            resp = NCartao_Debito.Inserir(this.bandeira_cartao_debito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_debito, valor_liquido, Data_Compensacao2);
                                        }
                                        else
                                        {
                                            resp = NCartao_Debito.Inserir(this.bandeira_cartao_debito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_debito, valor_liquido, Data_Compensacao);
                                        }

                                        // Imprimir Comprovante
                                        this.Imprimir = true;
                                    }
                                    else if (l.Cells[0].Value.Equals("Cheque"))
                                    {
                                        for (int i = 0; i <= TBL_Dados_Pagamento_Cheque.Rows.Count - 1; i++)
                                        {
                                            // Pegando dados da tabela
                                            this.Data_Entrada_Cheque = Convert.ToDateTime(TBL_Dados_Pagamento_Cheque.Rows[i][0]);
                                            this.banco_emissor_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][1].ToString();
                                            this.nome_titular_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][2].ToString();
                                            this.num_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][3].ToString();
                                            this.num_parcela = TBL_Dados_Pagamento_Cheque.Rows[i][4].ToString();
                                            this.valor_cheque = Convert.ToDecimal(TBL_Dados_Pagamento_Cheque.Rows[i][5]);
                                            this.depositar_dia = Convert.ToDateTime(TBL_Dados_Pagamento_Cheque.Rows[i][6]);

                                            // Executando inserção no controle de cheque
                                            resp = NCheque.Inserir(this.idremetente, this.Data_Entrada_Cheque, this.banco_emissor_cheque, this.nome_titular_cheque, this.num_cheque, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cheque, this.depositar_dia, "AGUARDANDO");
                                        }

                                        // Entrada em Dinheiro ou Venda a Vista
                                        this.Lancar_Caixa = true;

                                        // Imprimir Comprovante
                                        this.Imprimir = true;
                                    }
                                    else if (l.Cells[0].Value.Equals("Dinheiro"))
                                    {
                                        // Capturando Dados
                                        DateTime Data = dtData.Value; // Data 
                                        this.valor_dinheiro = Convert.ToDecimal(l.Cells[2].Value); // Valor

                                        // Inserir registro para fechamento de caixa
                                        resp = NDinheiro.Inserir(Data, this.idvenda, this.idguiche_atendimento, this.idfuncionario, this.historico_dinheiro, this.valor_dinheiro);

                                        // Entrada em Dinheiro ou Venda a Vista
                                        this.Lancar_Caixa = true;

                                        // Imprimir Comprovante
                                        this.Imprimir = true;
                                    }
                                    else if (l.Cells[0].Value.Equals("Crediário da Loja"))
                                    {
                                        this.CriarTabela_Detalhe_Contas_Receber();
                                        decimal Valor_Conta_Receber = Convert.ToDecimal(l.Cells[2].Value);
                                        int Quant_Parcelas = this.TBL_Info_Crediario_Loja.Rows.Count;
                                        int num_parcela = 0;
                                        decimal valor = 0;
                                        DateTime vencimento;

                                        for (int i = 0; i <= TBL_Info_Crediario_Loja.Rows.Count - 1; i++)
                                        {
                                            num_parcela = Convert.ToInt32(TBL_Info_Crediario_Loja.Rows[i][0]);  //num_parcela
                                            valor = Convert.ToDecimal(TBL_Info_Crediario_Loja.Rows[i][1]);  //valor
                                            vencimento = Convert.ToDateTime(TBL_Info_Crediario_Loja.Rows[i][2]);   //vencimento

                                            DataRow row = this.TBL_Detalhe_Contas_Receber.NewRow();
                                            row["idcliente"] = Convert.ToInt32(this.TXB_IdCliente.Text);
                                            row["num_parcela"] = num_parcela;
                                            row["valor"] = valor;
                                            row["vencimento"] = vencimento;
                                            row["estado"] = "A VENCER";
                                            row["obs"] = "";
                                            this.TBL_Detalhe_Contas_Receber.Rows.Add(row);
                                        }

                                        resp = NContas_Receber.Inserir_Contas_Receber_Apos_Venda(this.idvenda, this.dtData.Value, this.TXB_Nome_Cliente.Text, this.txtNum_Comprovante.Text, Quant_Parcelas.ToString() + " X", Valor_Conta_Receber, this.TBL_Detalhe_Contas_Receber);

                                        if (resp.Equals("Ok"))
                                        {
                                            for (int i = 0; i <= TBL_Info_Crediario_Loja.Rows.Count - 1; i++)
                                            {
                                                int num_parc = Convert.ToInt32(TBL_Info_Crediario_Loja.Rows[i][0]);  //num_parcela
                                                decimal vlr = Convert.ToDecimal(TBL_Info_Crediario_Loja.Rows[i][1]);  //valor
                                                DateTime venc = Convert.ToDateTime(TBL_Info_Crediario_Loja.Rows[i][2]);   //vencimento

                                                resp = NDetalhe_Contas_Receber_Estatico.Inserir(this.idvenda, Convert.ToInt32(this.TXB_IdCliente.Text), num_parc, vlr, venc, "A VENCER", "");
                                            }
                                        }

                                        // Entrada em Dinheiro ou Venda a Vista
                                        this.Lancar_Caixa = true;

                                        // Imprimir Comprovante
                                        this.Imprimir = true;
                                    }
                                }

                                // Executar lançamento de entrada em dinheiro ou venda a vista, caso haja
                                this.Lancamento_Livro_Caixa_VendaAVista_Entrada(this.Lancar_Caixa);

                                // Executar Metodo de impressão de comprovante
                                this.Impressao_Comrpovante(this.idvenda, this.Imprimir);
                            }
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.Limpar();
                        this.CriarTabela();
                        this.CriarTabela_FP();
                        this.CriarLinha();
                        this.CHK_Venda_Rapida.Checked = true;
                        this.CHK_Usar_Uma_foma_Pgto.Checked = true;
                        this.Importacao_OS = false;
                        this.ID_OS_Importada = 0;
                        this.Importacao_Orcamento = false;
                        this.ID_Orcamento_Importado = 0;

                        // Ocultar Calculador de troco
                        this.LB_Recebido.Visible = false;
                        this.TXT_Recebido.Visible = false;
                        this.LB_Troco.Visible = false;
                        this.TXB_Troco.Visible = false;

                        int linha = this.dataListaDetalhes.CurrentRow.Index;
                        this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[linha].Cells[2];

                        this.Atualizador_Constante = true;
                        this.Alerta_Campos_Obrigatorios_Desativado();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void dataListaDetalhes_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.MoveNext();
            this.dataListaDetalhes.CurrentRow.Cells[3].ReadOnly = false;
        }

        private void dataListaDetalhes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nome das Colunas
            this.dataListaDetalhes.Columns[2].HeaderText = "Quant";
            this.dataListaDetalhes.Columns[3].HeaderText = "Descrição";
            this.dataListaDetalhes.Columns[4].HeaderText = "Valor Unit.";
            this.dataListaDetalhes.Columns[5].HeaderText = "Subtotal";
        }

        private void BTN_Contas_Receber_Click(object sender, EventArgs e)
        {
            FRM_Contas_Receber frm = FRM_Contas_Receber.GetInstancia();
            frm.TopMost = true;
            frm.Show();
        }

        private void btnContas_Pagar_Click(object sender, EventArgs e)
        {
            FRM_Contas_Pagar frm = FRM_Contas_Pagar.GetInstancia();
            frm.TopMost = true;
            frm.Show();
        }

        private void TXT_Recebido_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Recebido.Text != "")
            {
                decimal total_pagar = this.totalPago;
                decimal recebido = Convert.ToDecimal(TXT_Recebido.Text);
                decimal troco = recebido - total_pagar;
                this.TXB_Troco.Text = troco.ToString("C");
            }
            else
            {
                this.TXB_Troco.Text = string.Empty;
            }
        }

        private void dataListaDetalhes_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Selecionar_Produto_Codigo_Barra();

            if (this.DGV_Select_Prod_Cod_Barra.Rows.Count == 1)
            {
                if (this.dataListaDetalhes.CurrentRow.Cells[3].Selected && e.KeyCode == Keys.Enter)
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
                    foreach (DataGridViewRow linha in dataListaDetalhes.Rows)
                    {
                        if (linha.Cells[1].Value.Equals(idproduto))
                        {
                            salvar = false;

                            // Capturando linha a ser atualizada
                            int row_atual = linha.Index;

                            // Capturando quantidade atual
                            decimal qtd = Convert.ToDecimal(dataListaDetalhes.Rows[row_atual].Cells[2].Value);
                            
                            if (tipo_mercadoria == "PRODUTO" && quant_atual_estoque < qtd + 1)
                            {
                                this.MensagemErro("A quantidade atual no estoque é insuficiente.\n\nQuantidade disponível:   " + quant_atual_estoque.ToString() + " " + unidade_medida);
                                this.dataListaDetalhes.CurrentRow.Cells[3].Value = "";

                                int index = this.dataListaDetalhes.CurrentRow.Index;
                                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
                            }
                            else
                            {
                                // inserindo quantidade atualizada
                                dataListaDetalhes.Rows[row_atual].Cells[2].Value = qtd + 1;

                                // Tranferindo quantidade atualizada para variavel
                                decimal qtd_atual = Convert.ToDecimal(dataListaDetalhes.Rows[row_atual].Cells[2].Value);

                                // Capturando preço de venda atual
                                decimal preco_venda_atual = Convert.ToDecimal(dataListaDetalhes.Rows[row_atual].Cells[4].Value);

                                // Analisando situação
                                if (preco_venda_atual == preco_venda)
                                {
                                    // Calculando novo subtotal
                                    decimal novo_subtotal = qtd_atual * preco_venda;
                                    this.totalPago = 0;
                                    dataListaDetalhes.Rows[row_atual].Cells[5].Value = novo_subtotal;

                                    // Calculando novo SUBTOTAL-CUSTO
                                    if (dataListaDetalhes.Rows[row_atual].Cells[8].Value.Equals("SERVIÇO"))
                                    {
                                        decimal novo_subtotal_custo = qtd_atual * preco_venda;
                                        dataListaDetalhes.Rows[row_atual].Cells[7].Value = novo_subtotal_custo;
                                    }
                                    else
                                    {
                                        decimal novo_subtotal_custo = qtd_atual * preco_custo;
                                        dataListaDetalhes.Rows[row_atual].Cells[7].Value = novo_subtotal_custo;
                                    }
                                }
                                else
                                {
                                    // Calculando novo subtotal
                                    decimal novo_subtotal = qtd_atual * preco_venda_atual;
                                    this.totalPago = 0;
                                    dataListaDetalhes.Rows[row_atual].Cells[5].Value = novo_subtotal;

                                    // Calculando novo SUBTOTAL-CUSTO
                                    if (dataListaDetalhes.Rows[row_atual].Cells[8].Value.Equals("SERVIÇO"))
                                    {
                                        decimal novo_subtotal_custo = qtd_atual * preco_venda_atual;
                                        dataListaDetalhes.Rows[row_atual].Cells[7].Value = novo_subtotal_custo;
                                    }
                                    else
                                    {
                                        decimal novo_subtotal_custo = qtd_atual * preco_custo;
                                        dataListaDetalhes.Rows[row_atual].Cells[7].Value = novo_subtotal_custo;
                                    }
                                }
                                
                                // Calculando novo total geral
                                for (int i = 0; i <= dataListaDetalhes.RowCount - 1; i++)
                                {
                                    if (Convert.ToString(dataListaDetalhes.Rows[i].Cells[5].Value) != "")
                                    {
                                        this.totalPago += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                    }
                                }
                                TXB_TotalPagar.Text = this.totalPago.ToString("C");
                                dataListaDetalhes.CurrentRow.Cells[3].Value = "";

                                if (quant_atual_estoque < quant_ideal)
                                {
                                    this.MensagemAlerta("Estoque abaixo do ideal.");
                                }
                            }
                        }
                    }
                    if (salvar)
                    {
                        bool Trava = true;
                        if (this.dataListaDetalhes.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                            this.dataListaDetalhes.CurrentRow.Cells[2].Value = 1;
                            this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                            this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                            this.dataListaDetalhes.CurrentRow.Cells[6].Value = preco_custo;
                            this.dataListaDetalhes.CurrentRow.Cells[8].Value = tipo_mercadoria;

                            if (quant_atual_estoque < quant_ideal)
                            {
                                this.MensagemAlerta("Estoque abaixo do ideal.");
                            }
                        }
                        else
                        {
                            decimal quant_solicitada = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[2].Value);
                            if (tipo_mercadoria == "PRODUTO" && quant_atual_estoque < quant_solicitada)
                            {
                                Trava = false;
                                this.MensagemErro("A quantidade atual no estoque é insuficiente.\n\nQuantidade disponível:   " + quant_atual_estoque.ToString() + " " + unidade_medida);
                                this.dataListaDetalhes.CurrentRow.Cells[2].Value = quant_atual_estoque;
                                this.dataListaDetalhes.CurrentRow.Cells[3].Value = "";

                                int index = this.dataListaDetalhes.CurrentRow.Index;
                                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
                            }
                            else
                            {
                                this.dataListaDetalhes.CurrentRow.Cells[1].Value = idproduto;
                                this.dataListaDetalhes.CurrentRow.Cells[3].Value = descricao;
                                this.dataListaDetalhes.CurrentRow.Cells[4].Value = preco_venda;
                                this.dataListaDetalhes.CurrentRow.Cells[6].Value = preco_custo;
                                this.dataListaDetalhes.CurrentRow.Cells[8].Value = tipo_mercadoria;

                                if (quant_atual_estoque < quant_ideal)
                                {
                                    this.MensagemAlerta("Estoque abaixo do ideal.");
                                }
                            }
                        }
                        if (Trava)
                        {
                            int index = this.dataListaDetalhes.CurrentRow.Index;
                            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[4];

                            if (dataListaDetalhes.CurrentRow.Cells[4].Selected)
                            {
                                decimal cell1 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[2].Value);

                                decimal cell2 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[4].Value);

                                decimal cell3 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[6].Value);

                                if (cell1.ToString() != "" && cell2.ToString() != "")
                                {
                                    if (dataListaDetalhes.CurrentRow.Cells[8].Value.Equals("SERVIÇO"))
                                    {
                                        dataListaDetalhes.CurrentRow.Cells[5].Value = cell1 * cell2;
                                        dataListaDetalhes.CurrentRow.Cells[7].Value = cell1 * cell2;
                                    }
                                    else
                                    {
                                        dataListaDetalhes.CurrentRow.Cells[5].Value = cell1 * cell2;
                                        dataListaDetalhes.CurrentRow.Cells[7].Value = cell1 * cell3;
                                    }
                                    
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

                                            this.CriarLinha();
                                            index = this.dataListaDetalhes.CurrentRow.Index + 1;
                                            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FRM_Caixa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Todos os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    this.Atualizador_Constante = false;
                    this.dataListaDetalhes.Focus();
                    try
                    {
                        string resp = "";
                        if (this.TXB_IdCliente.Text == string.Empty || this.TXB_Nome_Cliente.Text == string.Empty || this.txtNum_Comprovante.Text == "" || this.DGV_Formas_Pagamento.Rows.Count == 0 || this.dataListaDetalhes.Rows.Count == 0)
                        {
                            MensagemErro("Preencha todos os campos obrigatórios.");
                            this.Alerta_Campos_Obrigatorios_Ativado();
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

                                // Executar Calculo de Comissão do Funcionario
                                decimal comissão_paga = 0;
                                if (this.Tipo_comisao_funcionario.Equals("Lucro da Venda"))
                                {
                                    decimal Total_Venda = 0;
                                    decimal Custo_Total_Venda = 0;
                                    decimal Lucro_Total_Venda = 0;
                                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                                    {
                                        Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                        Custo_Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[7].Value);
                                    }
                                    Lucro_Total_Venda = Total_Venda - Custo_Total_Venda;
                                    comissão_paga = (Lucro_Total_Venda * this.Comissao_funcionario) / (100);
                                }
                                else
                                {
                                    decimal Total_Venda = 0;
                                    for (int i = 0; i <= dataListaDetalhes.Rows.Count - 1; i++)
                                    {
                                        Total_Venda += Convert.ToDecimal(dataListaDetalhes.Rows[i].Cells[5].Value);
                                    }
                                    comissão_paga = (Total_Venda * this.Comissao_funcionario) / (100);
                                }

                                // Executar Metodo Salvar
                                resp = NVenda.Inserir(idremetente, this.idguiche_atendimento, dtData.Value, Convert.ToInt32(TXB_IdCliente.Text), idfuncionario,
                                    cbTipo_Comprovante.Text, txtNum_Comprovante.Text, this.TXB_Recebimento.Text, this.TXB_Entrada_Dinheiro.Text, this.Valor_Entrada, comissão_paga, dtDetalhe, dtFormas_Pgto);
                            }

                            if (resp.Equals("Ok"))
                            {
                                if (this.eNovo)
                                {
                                    this.MensagemOk("Registro salvo com sucesso");

                                    // Atualizar Status OS Importada, caso haja
                                    this.Atualizar_Status_OS_Importada();

                                    // Deletar Orçamento Importado, caso haja
                                    this.Deletar_Orcamento_Importado();

                                    // IDVENDA
                                    DataTable Dados_Venda = NVenda.Mostrar();
                                    this.idvenda = Convert.ToInt32(Dados_Venda.Rows[0][0]);

                                    foreach (DataGridViewRow l in DGV_Formas_Pagamento.Rows)
                                    {
                                        if (l.Cells[0].Value.Equals("Cartão de Crédito"))
                                        {
                                            // Declarando Variaveis
                                            string num_parcela = "";
                                            int contador = 0;

                                            // Capturando Dados Necessarios
                                            this.TBL_Info_Config_Cartao_Credito = NConfig_Cartao_Credito.Mostrar();
                                            DateTime Data_Compensacao = this.dtData.Value;

                                            // Prazo de Compensação e taxa
                                            foreach (DataRow line in TBL_Info_Config_Cartao_Credito.Rows)
                                            {
                                                if (line[1].ToString().Equals(this.bandeira_cartao_credito))
                                                {
                                                    this.Prazo_Primeira_Pac = Convert.ToInt32(line[2]);
                                                    this.Prazo_Demais_Parc = Convert.ToInt32(line[3]);
                                                    this.taxa_cartao_credito = Convert.ToDecimal(line[4]);
                                                }
                                            }

                                            // Pré - Operação
                                            this.valor_liquido_cartao_credito = this.valor_cartao_credito - (this.valor_cartao_credito * this.taxa_cartao_credito / 100);

                                            // Executando Operação
                                            contador++;

                                            num_parcela = contador.ToString() + " / " + this.quant_parcelas_cartao_credito.ToString();
                                            Data_Compensacao = Data_Compensacao.AddDays(this.Prazo_Primeira_Pac);

                                            resp = NCartao_Credito.Inserir(this.bandeira_cartao_credito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_credito, this.valor_liquido_cartao_credito, Data_Compensacao);

                                            for (int i = 0; i < this.quant_parcelas_cartao_credito - 1; i++)
                                            {
                                                contador++;

                                                num_parcela = contador.ToString() + " / " + this.quant_parcelas_cartao_credito.ToString();
                                                Data_Compensacao = Data_Compensacao.AddDays(this.Prazo_Demais_Parc);

                                                resp = NCartao_Credito.Inserir(this.bandeira_cartao_credito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_credito, this.valor_liquido_cartao_credito, Data_Compensacao);
                                            }

                                            // Entrada em Dinheiro ou Venda a Vista
                                            this.Lancar_Caixa = true;

                                            // Imprimir Comprovante
                                            this.Imprimir = true;
                                        }
                                        else if (l.Cells[0].Value.Equals("Cartão de Debito"))
                                        {
                                            DataTable TBL_Config_Cartao_Debito = NConfig_Cartao_Debito.Mostrar();

                                            // Prazo de Compensação e taxa
                                            foreach (DataRow R in TBL_Config_Cartao_Debito.Rows)
                                            {
                                                if (R[1].ToString().Equals(this.bandeira_cartao_debito))
                                                {
                                                    this.prazo_compensacao_cartao_debito = Convert.ToInt32(R[2]);
                                                    this.taxa_cartao_debito = Convert.ToDecimal(R[3]);
                                                }
                                            }

                                            DateTime Data_Compensacao = this.diaUtil(this.dtData.Value);
                                            DateTime Data_Compensacao2 = this.dtData.Value.AddDays(this.prazo_compensacao_cartao_debito);

                                            // Numero da parcela
                                            string num_parcela = "1 / 1";

                                            // Obtendo valor 
                                            this.valor_cartao_debito = Convert.ToDecimal(l.Cells[2].Value);

                                            // Calculando valor liquido
                                            decimal valor_liquido = this.valor_cartao_debito - (this.valor_cartao_debito * this.taxa_cartao_debito / 100);

                                            if (this.dtData.Value.ToString("dd/MM/yyyy") == Data_Compensacao.ToString("dd/MM/yyyy"))
                                            {
                                                resp = NCartao_Debito.Inserir(this.bandeira_cartao_debito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_debito, valor_liquido, Data_Compensacao2);
                                            }
                                            else
                                            {
                                                resp = NCartao_Debito.Inserir(this.bandeira_cartao_debito, this.dtData.Value, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cartao_debito, valor_liquido, Data_Compensacao);
                                            }

                                            // Imprimir Comprovante
                                            this.Imprimir = true;
                                        }
                                        else if (l.Cells[0].Value.Equals("Cheque"))
                                        {
                                            for (int i = 0; i <= TBL_Dados_Pagamento_Cheque.Rows.Count - 1; i++)
                                            {
                                                // Pegando dados da tabela
                                                this.Data_Entrada_Cheque = Convert.ToDateTime(TBL_Dados_Pagamento_Cheque.Rows[i][0]);
                                                this.banco_emissor_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][1].ToString();
                                                this.nome_titular_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][2].ToString();
                                                this.num_cheque = TBL_Dados_Pagamento_Cheque.Rows[i][3].ToString();
                                                this.num_parcela = TBL_Dados_Pagamento_Cheque.Rows[i][4].ToString();
                                                this.valor_cheque = Convert.ToDecimal(TBL_Dados_Pagamento_Cheque.Rows[i][5]);
                                                this.depositar_dia = Convert.ToDateTime(TBL_Dados_Pagamento_Cheque.Rows[i][6]);

                                                // Executando inserção no controle de cheque
                                                resp = NCheque.Inserir(this.idremetente, this.Data_Entrada_Cheque, this.banco_emissor_cheque, this.nome_titular_cheque, this.num_cheque, this.idvenda, this.idguiche_atendimento, this.idfuncionario, num_parcela, this.valor_cheque, this.depositar_dia, "AGUARDANDO");
                                            }

                                            // Entrada em Dinheiro ou Venda a Vista
                                            this.Lancar_Caixa = true;

                                            // Imprimir Comprovante
                                            this.Imprimir = true;
                                        }
                                        else if (l.Cells[0].Value.Equals("Dinheiro"))
                                        {
                                            // Capturando Dados
                                            DateTime Data = dtData.Value; // Data 
                                            this.valor_dinheiro = Convert.ToDecimal(l.Cells[2].Value); // Valor

                                            // Inserir registro para fechamento de caixa
                                            resp = NDinheiro.Inserir(Data, this.idvenda, this.idguiche_atendimento, this.idfuncionario, this.historico_dinheiro, this.valor_dinheiro);

                                            // Entrada em Dinheiro ou Venda a Vista
                                            this.Lancar_Caixa = true;

                                            // Imprimir Comprovante
                                            this.Imprimir = true;
                                        }
                                        else if (l.Cells[0].Value.Equals("Crediário da Loja"))
                                        {
                                            this.CriarTabela_Detalhe_Contas_Receber();
                                            decimal Valor_Conta_Receber = Convert.ToDecimal(l.Cells[2].Value);
                                            int Quant_Parcelas = this.TBL_Info_Crediario_Loja.Rows.Count;
                                            int num_parcela = 0;
                                            decimal valor = 0;
                                            DateTime vencimento;

                                            for (int i = 0; i <= TBL_Info_Crediario_Loja.Rows.Count - 1; i++)
                                            {
                                                num_parcela = Convert.ToInt32(TBL_Info_Crediario_Loja.Rows[i][0]);  //num_parcela
                                                valor = Convert.ToDecimal(TBL_Info_Crediario_Loja.Rows[i][1]);  //valor
                                                vencimento = Convert.ToDateTime(TBL_Info_Crediario_Loja.Rows[i][2]);   //vencimento

                                                DataRow row = this.TBL_Detalhe_Contas_Receber.NewRow();
                                                row["idcliente"] = Convert.ToInt32(this.TXB_IdCliente.Text);
                                                row["num_parcela"] = num_parcela;
                                                row["valor"] = valor;
                                                row["vencimento"] = vencimento;
                                                row["estado"] = "A VENCER";
                                                row["obs"] = "";
                                                this.TBL_Detalhe_Contas_Receber.Rows.Add(row);
                                            }

                                            resp = NContas_Receber.Inserir_Contas_Receber_Apos_Venda(this.idvenda, this.dtData.Value, this.TXB_Nome_Cliente.Text, this.txtNum_Comprovante.Text, Quant_Parcelas.ToString() + " X", Valor_Conta_Receber, this.TBL_Detalhe_Contas_Receber);

                                            if (resp.Equals("Ok"))
                                            {
                                                for (int i = 0; i <= TBL_Info_Crediario_Loja.Rows.Count - 1; i++)
                                                {
                                                    int num_parc = Convert.ToInt32(TBL_Info_Crediario_Loja.Rows[i][0]);  //num_parcela
                                                    decimal vlr = Convert.ToDecimal(TBL_Info_Crediario_Loja.Rows[i][1]);  //valor
                                                    DateTime venc = Convert.ToDateTime(TBL_Info_Crediario_Loja.Rows[i][2]);   //vencimento

                                                    resp = NDetalhe_Contas_Receber_Estatico.Inserir(this.idvenda, Convert.ToInt32(this.TXB_IdCliente.Text), num_parc, vlr, venc, "A VENCER", "");
                                                }
                                            }

                                            // Entrada em Dinheiro ou Venda a Vista
                                            this.Lancar_Caixa = true;

                                            // Imprimir Comprovante
                                            this.Imprimir = true;
                                        }
                                    }

                                    // Executar lançamento de entrada em dinheiro ou venda a vista, caso haja
                                    this.Lancamento_Livro_Caixa_VendaAVista_Entrada(this.Lancar_Caixa);

                                    // Executar Metodo de impressão de comprovante
                                    this.Impressao_Comrpovante(this.idvenda, this.Imprimir);
                                }
                            }
                            else
                            {
                                this.MensagemErro(resp);
                            }

                            this.Limpar();
                            this.CriarTabela();
                            this.CriarTabela_FP();
                            this.CriarLinha();
                            this.CHK_Venda_Rapida.Checked = true;
                            this.CHK_Usar_Uma_foma_Pgto.Checked = true;
                            this.Importacao_OS = false;
                            this.ID_OS_Importada = 0;
                            this.Importacao_Orcamento = false;
                            this.ID_Orcamento_Importado = 0;

                            // Ocultar Calculador de troco
                            this.LB_Recebido.Visible = false;
                            this.TXT_Recebido.Visible = false;
                            this.LB_Troco.Visible = false;
                            this.TXB_Troco.Visible = false;

                            int linha = this.dataListaDetalhes.CurrentRow.Index;
                            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[linha].Cells[2];

                            this.Atualizador_Constante = true;
                            this.Alerta_Campos_Obrigatorios_Desativado();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
            }
            else if (e.KeyCode == Keys.Insert && this.dataListaDetalhes.CurrentRow.Cells[3].Selected)
            {
                this.dataListaDetalhes.CurrentRow.Cells[3].ReadOnly = true;

                FRM_Buscar_Produto_Venda frm = FRM_Buscar_Produto_Venda.GetInstancia();
                frm.txtBuscar.Text = this.dataListaDetalhes.CurrentRow.Cells[3].Value.ToString();
                frm.Quant_Solicitada = Convert.ToDecimal(this.dataListaDetalhes.CurrentRow.Cells[2].Value);
                
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.Delete && this.BTN_Deletar_Item.Enabled)
            {
                try
                {
                    bool chave = false;
                    int Linha_Atual = 0;
                    decimal Quant_Atual = 0;
                    decimal Valor_Item_Deletado = 0;
                    decimal Subtotal_Atual = 0;
                    decimal Preco_Custo_Item_Deletado = 0;
                    decimal Subtotal_Custo_Atual = 0;

                    foreach (DataGridViewRow row in dataListaDetalhes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            chave = true;
                            Linha_Atual = row.Index;
                            Quant_Atual = Convert.ToDecimal(row.Cells[2].Value);
                            Valor_Item_Deletado = Convert.ToDecimal(row.Cells[4].Value);
                            Subtotal_Atual = Convert.ToDecimal(row.Cells[5].Value);
                            Preco_Custo_Item_Deletado = Convert.ToDecimal(row.Cells[6].Value);
                            Subtotal_Custo_Atual = Convert.ToDecimal(row.Cells[7].Value);
                        }
                    }
                    if (chave)
                    {
                        DialogResult Opcao;
                        Opcao = MessageBox.Show("Realmente deseja deletar intem(s) da lista?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Opcao == DialogResult.Yes)
                        {
                            if (this.PERMISSAO_DELETAR_ITEM_LISTA == "SIM")
                            {
                                this.Deletar_Item_Permissao_TRUE(Linha_Atual, Quant_Atual, Valor_Item_Deletado, Subtotal_Atual, Preco_Custo_Item_Deletado, Subtotal_Custo_Atual);
                            }
                            else
                            {
                                FRM_Solicitar_Permissao_Deletar_Item_Venda Solicitar_Permissao = FRM_Solicitar_Permissao_Deletar_Item_Venda.GetInstancia();
                                Solicitar_Permissao.linha_atual = Linha_Atual;
                                Solicitar_Permissao.quant_atual = Quant_Atual;
                                Solicitar_Permissao.valor_item_deletado = Valor_Item_Deletado;
                                Solicitar_Permissao.subtotal_atual = Subtotal_Atual;
                                Solicitar_Permissao.preco_custo_item_deletado = Preco_Custo_Item_Deletado;
                                Solicitar_Permissao.subtotal_custo_atual = Subtotal_Custo_Atual;
                                Solicitar_Permissao.Show();
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


            if (this.dataListaDetalhes.CurrentRow.Cells[4].Selected && Convert.ToString(this.dataListaDetalhes.CurrentRow.Cells[2].Value) != "" && Convert.ToString(this.dataListaDetalhes.CurrentRow.Cells[4].Value) != "")
            {
                decimal cell1 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[2].Value);

                decimal cell2 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[4].Value);

                decimal cell3 = Convert.ToDecimal(dataListaDetalhes.CurrentRow.Cells[6].Value);

                if (cell1.ToString() != "" && cell2.ToString() != "")
                {
                    dataListaDetalhes.CurrentRow.Cells[5].Value = cell1 * cell2;
                    dataListaDetalhes.CurrentRow.Cells[7].Value = cell1 * cell3;

                    string valor = "";
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
                        }
                    }
                }
            }
        }

        private void CHK_Venda_Rapida_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Importacao_OS == false && this.Importacao_Orcamento == false)
            {
                if (this.CHK_Venda_Rapida.Checked)
                {
                    this.BTN_Selecionar_Cliente.Enabled = false;

                    this.TXB_IdCliente.Text = "0";
                    this.TXB_Nome_Cliente.Text = "CONSUMIDOR";

                    this.CriarTabela_FP();
                    this.TXB_Recebimento.Text = string.Empty;
                }
                else
                {
                    this.BTN_Selecionar_Cliente.Enabled = true;

                    this.TXB_IdCliente.Text = string.Empty;
                    this.TXB_Nome_Cliente.Text = string.Empty;

                    // Abrir form para selecionar cliente
                    this.limite = 0;
                    this.limite_usado = 0;
                    this.resto_limite = 0;

                    FRM_Buscar_Cliente_Venda frm = FRM_Buscar_Cliente_Venda.GetInstancia();
                    frm.Show();
                }
            }
        }
        
        private void TXB_IdCliente_TextChanged(object sender, EventArgs e)
        {
            
            //this.Analise_Credito();
        }

        private void BTN_Selecionar_Cliente_Click(object sender, EventArgs e)
        {
            this.limite = 0;
            this.limite_usado = 0;
            this.resto_limite = 0;

            FRM_Buscar_Cliente_Venda frm = FRM_Buscar_Cliente_Venda.GetInstancia();
            frm.Show();
        }

     
        private void CHK_Multiformas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Usar_Uma_foma_Pgto.Checked)
            {
                this.BTN_Cartao_Credito.Enabled = true;
                this.BTN_Cartão_Debito.Enabled = true;
                this.BTN_Crediario_Loja.Enabled = true;
                this.BTN_Cheque.Enabled = true;
                this.BTN_Dinheiro.Enabled = true;

                this.BTN_Multiformas.Enabled = false;
            }
            else
            {
                this.BTN_Cartao_Credito.Enabled = false;
                this.BTN_Cartão_Debito.Enabled = false;
                this.BTN_Crediario_Loja.Enabled = false;
                this.BTN_Cheque.Enabled = false;
                this.BTN_Dinheiro.Enabled = false;

                this.BTN_Multiformas.Enabled = true;
            }
        }

        private void BTN_Cartao_Credito_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Solicitar informações sobre entrada em dinheiro
                    FRM_Entrada_em_Dinheiro_Card_Cred entrada = FRM_Entrada_em_Dinheiro_Card_Cred.GetInstancia();
                    entrada.Show();
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.dataListaDetalhes.CurrentRow.Index;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
            }
        }

        private void BTN_Cartão_Debito_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Informando Tipo de Recebimento
                    this.TXB_Recebimento.Text = "Cartão de Debito";

                    // Adicionar dados ao grid de formas de pagamento
                    DataRow row = this.dtFormas_Pgto.NewRow();
                    row["forma"] = "Cartão de Debito";
                    row["valor_primario"] = this.totalPago;
                    row["valor_final"] = this.totalPago;
                    this.dtFormas_Pgto.Rows.Add(row);

                    // Solicitar Informações do cartão
                    FRM_Informacoes_Cartao_Debito frm = FRM_Informacoes_Cartao_Debito.GetInstancia();
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
                int index = this.dataListaDetalhes.CurrentRow.Index;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
            }
        }

        private void BTN_Dinheiro_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0)
            {
                if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                {
                    // Mostrar Calculador de troco
                    this.LB_Recebido.Visible = true;
                    this.TXT_Recebido.Visible = true;
                    this.LB_Troco.Visible = true;
                    this.TXB_Troco.Visible = true;

                    // Informando Tipo de Recebimento
                    this.TXB_Recebimento.Text = "Dinheiro";

                    // Adicionar dados ao grid de formas de pagamento
                    DataRow row = this.dtFormas_Pgto.NewRow();
                    row["forma"] = "Dinheiro";
                    row["valor_primario"] = this.totalPago;
                    row["valor_final"] = this.totalPago;
                    this.dtFormas_Pgto.Rows.Add(row);
                }
                else
                {
                    this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                }
            }
            else
            {
                this.MensagemErro("Não há produtos!");
                int index = this.dataListaDetalhes.CurrentRow.Index;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
            }
        }

        private void BTN_Excluir_Click(object sender, EventArgs e)
        {
            this.CriarTabela_FP();
            this.TXB_Recebimento.Text = string.Empty;

            // Ocultar Calculador de troco
            this.LB_Recebido.Visible = false;
            this.TXT_Recebido.Visible = false;
            this.LB_Troco.Visible = false;
            this.TXB_Troco.Visible = false;
        }

        private void TXB_Recebimento_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void BTN_Multiformas_Click(object sender, EventArgs e)
        {
            if (this.totalPago > 0)
            {
                FRM_Formas_Pgto_Venda frm = FRM_Formas_Pgto_Venda.GetInstancia();
                frm.Data = this.dtData.Value;
                frm.limite_credito_cliente = this.limite;
                frm.resto_limite_cliente = this.resto_limite;
                frm.eAdicionar = true;
                frm.Valor_Total = this.totalPago;
                frm.ShowDialog();
            }
            else
            {
                this.MensagemErro("Não existem produtos ou serviços na lista.");
                this.dataListaDetalhes.Focus();
                int index = this.dataListaDetalhes.CurrentRow.Index;
                this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
            }
        }

        private void BTN_Cheque_Click(object sender, EventArgs e)
        {
            if (this.CHK_Venda_Rapida.Checked)
            {
                this.MensagemErro("Não é possível efetuar venda no cheque com o modo VENDA RÁPIDA ativo.");
            }
            else
            {
                if (this.totalPago > 0)
                {
                    if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                    {
                        FRM_Entrada_em_Dinheiro_Cheque entrada = FRM_Entrada_em_Dinheiro_Cheque.GetInstancia();
                        entrada.Show();
                    }
                    else
                    {
                        this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                    }
                }
                else
                {
                    this.MensagemErro("Não há produtos!");
                    int index = this.dataListaDetalhes.CurrentRow.Index;
                    this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[3];
                }
            }
        }

        private void BTN_Fechar_Caixa_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja fechar o caixa agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                FRM_Fechar_Caixa frm = FRM_Fechar_Caixa.GetInstancia();
                frm.eFechar = true;
                frm.IdGuiche = this.idguiche_atendimento;
                frm.IdFuncionario = this.idfuncionario;
                frm.TXB_Nome_Guiche.Text = this.nome_guiche;
                frm.TXB_Data.Text = this.Data_Caixa_Aberto;
                frm.TXB_Hora_Aberto.Text = this.Hora_Caixa_Aberto;
                frm.TXB_Hora_Fechado.Text = DateTime.Now.ToString("HH : mm");
                frm.Valor_Inicial_Caixa = this.valor_inicial_caixa;
                frm.LB_Funcionario.Text = this.Nome_Funcionario;
                frm.Show();
                
                this.Close();
            }
        }

        private void BTN_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Atualizador_Timer_Tick(object sender, EventArgs e)
        {
            if (this.Atualizador_Constante)
            {
                this.Numeracao_Automatica();
                string Config_Num_Auto = this.DT_Num_Auto.Rows[0][3].ToString();

                if (Config_Num_Auto == "SIM")
                {
                    //Incrementando para gerar novo número de venda
                    Auxiliar_NA++;

                    //passado novo numero de venda para o TextBox
                    this.txtNum_Comprovante.Text = Convert.ToString(Auxiliar_NA);
                }
            }
        }

        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                decimal Preco_Custo_Item_Deletado = 0;
                decimal Subtotal_Custo_Atual = 0;

                foreach (DataGridViewRow row in dataListaDetalhes.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        Linha_Atual = row.Index;
                        Quant_Atual = Convert.ToDecimal(row.Cells[2].Value);
                        Valor_Item_Deletado = Convert.ToDecimal(row.Cells[4].Value);
                        Subtotal_Atual = Convert.ToDecimal(row.Cells[5].Value);
                        Preco_Custo_Item_Deletado = Convert.ToDecimal(row.Cells[6].Value);
                        Subtotal_Custo_Atual = Convert.ToDecimal(row.Cells[7].Value);
                    }
                }
                if (chave)
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja deletar intem(s) da lista?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.Yes)
                    {
                        if (this.PERMISSAO_DELETAR_ITEM_LISTA == "SIM")
                        {
                            this.Deletar_Item_Permissao_TRUE(Linha_Atual, Quant_Atual, Valor_Item_Deletado, Subtotal_Atual, Preco_Custo_Item_Deletado, Subtotal_Custo_Atual);
                        }
                        else
                        {
                            FRM_Solicitar_Permissao_Deletar_Item_Venda Solicitar_Permissao = FRM_Solicitar_Permissao_Deletar_Item_Venda.GetInstancia();
                            Solicitar_Permissao.linha_atual = Linha_Atual;
                            Solicitar_Permissao.quant_atual = Quant_Atual;
                            Solicitar_Permissao.valor_item_deletado = Valor_Item_Deletado;
                            Solicitar_Permissao.subtotal_atual = Subtotal_Atual;
                            Solicitar_Permissao.preco_custo_item_deletado = Preco_Custo_Item_Deletado;
                            Solicitar_Permissao.subtotal_custo_atual = Subtotal_Custo_Atual;
                            Solicitar_Permissao.Show();
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

       
        private void BTN_Crediario_Loja_Click(object sender, EventArgs e)
        {
            if (this.CHK_Venda_Rapida.Checked)
            {
                this.MensagemErro("Não é possível efetuar venda no crediário da loja com o modo VENDA RÁPIDA ativo.");
            }
            else
            {
                bool chave = true;
                if (this.limite > 0)
                {
                    if (this.totalPago > resto_limite)
                    {
                        chave = false;
                        MessageBox.Show("Não é possivel efetuar essa venda no crediário da loja." + "    " + "\n Limite de crédito insuficiente.\n\n Limite disponivel: " + this.resto_limite.ToString("C"), "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Excluir Formas de pagamento
                        this.CriarTabela_FP();
                        this.TXB_Recebimento.Text = string.Empty;

                        // Ocultar Calculador de troco
                        this.LB_Recebido.Visible = false;
                        this.TXT_Recebido.Visible = false;
                        this.LB_Troco.Visible = false;
                        this.TXB_Troco.Visible = false;
                    }
                }
                if (chave)
                {
                    if (this.totalPago > 0)
                    {
                        if (this.DGV_Formas_Pagamento.Rows.Count == 0)
                        {
                            // Solicitar informações sobre entrada em dinheiro
                            FRM_Entrada_em_Dinheiro_Cred_Loja entrada = FRM_Entrada_em_Dinheiro_Cred_Loja.GetInstancia();
                            entrada.Show();
                        }
                        else
                        {
                            this.MensagemErro("Na configuração atual não é possivel adicionar mais de uma forma de pagamento.\nDesmarque a caixa *USAR SOMENTE UMA FORMA DE PAGAMENTO* para fazer o que deseja.");
                        }
                    }
                    else
                    {
                        this.MensagemErro("Não existem produtos ou serviços na lista.");
                        this.dataListaDetalhes.Focus();
                        int index = this.dataListaDetalhes.CurrentRow.Index;
                        this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[index].Cells[2];
                    }
                }
            }
        }

        private void BTN_Cancelar_Venda_Click(object sender, EventArgs e)
        {
            this.dataListaDetalhes.Focus();
            this.Limpar();
            this.CriarTabela();
            this.CriarTabela_FP();
            this.CriarLinha();
            this.CHK_Venda_Rapida.Checked = true;
            this.CHK_Usar_Uma_foma_Pgto.Checked = true;
            this.Importacao_OS = false;
            this.ID_OS_Importada = 0;
            this.Importacao_Orcamento = false;
            this.ID_Orcamento_Importado = 0;

            // Ocultar Calculador de troco
            this.LB_Recebido.Visible = false;
            this.TXT_Recebido.Visible = false;
            this.LB_Troco.Visible = false;
            this.TXB_Troco.Visible = false;

            int linha = this.dataListaDetalhes.CurrentRow.Index;
            this.dataListaDetalhes.CurrentCell = this.dataListaDetalhes.Rows[linha].Cells[2];

            this.Alerta_Campos_Obrigatorios_Desativado();
        }

        private void BTN_Pesquisar_Preco_Click(object sender, EventArgs e)
        {
            FRM_Pesquisar_Preco frm = FRM_Pesquisar_Preco.GetInstancia();
            frm.Show();
        }

        private void BTN_Novo_Guiche_Click(object sender, EventArgs e)
        {
            FRM_Guiche_Atendimento frm = FRM_Guiche_Atendimento.GetInstancia();
            frm.Show();
        }

        private void BTN_informacoes_Click(object sender, EventArgs e)
        {
            FRM_Caixa_Operacao_Dia frm = FRM_Caixa_Operacao_Dia.GetInstancia();
            frm.Show();
        }

        private void BTN_Importar_OS_Click(object sender, EventArgs e)
        {
            FRM_Buscar_OS_Pronto frm = FRM_Buscar_OS_Pronto.GetInstancia();
            frm.Show();
        }

        private void BTN_Importar_Orcamento_Click(object sender, EventArgs e)
        {
            FRM_Buscar_Orcamento frm = FRM_Buscar_Orcamento.GetInstancia();
            frm.Show();
        }


        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataListaDetalhes.CurrentRow.Cells[2].Selected && this.eNovo)
            {
                if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
                {
                    e.Handled = true;
                }
            }
        }

        private void dataListaDetalhes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewTextBoxEditingControl)
            {
                e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
            }
        }

        private void TXT_Recebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
