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
    public partial class FRM_Contas_Receber : Form
    {
        private bool eNovo;
        DataTable dtparc;
        DataTable TBL_Analise_Vencimento;
        DataTable TBL_Dados_Cliente;
        private DataTable TBL_Nivel_Acesso;
        public string PERMISSAO_DELETAR_CONTA_RECEBER = "NÃO";
        public string PERMISSAO_INSERIR_CONTA_RECEBER = "NÃO";

        // Variaveis para metodo de recebimentoo - EXTERNO
        private decimal total_geral_debitos = 0;
        private decimal Total_Restante = 0;
        private decimal Total_Recebido = 0;

        // Variaveis para metodo de recebimentoo - INTERNO
        private decimal Total_Todas_Parcelas = 0;
        private decimal Total_Restante_Interno = 0;
        private decimal Total_Recebido_Interno = 0;
        private bool Key = false;
        private bool Key_Interna = false;
        private int IdCliente;
        private int col0;
        private decimal col1;
        private DateTime col2;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Contas_Receber _Instancia;

        public static FRM_Contas_Receber GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Contas_Receber();
            }
            return _Instancia;
        }

        public FRM_Contas_Receber()
        {
            InitializeComponent();
            this.TT_Mensagem.SetToolTip(this.BTN_Deletar, "Deletar");
            this.TXB_Id.ReadOnly = true;
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


        //Metodo Limpar Campos
        private void Limpar()
        {
            //Limpar TextBox
            this.TXB_Id.Text = string.Empty;
            this.TXB_Num_Doc.Text = string.Empty;
            this.TXB_Devedor_Nao_Cadastrado.Text = string.Empty;
            this.TXB_Valor_Total.Text = string.Empty;
            this.TXB_Valor_Atualizado.Text = string.Empty;
            this.CB_Cliente.Text = string.Empty;
            
            this.DGV_Parcelas.DataSource = null;
        }


        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.DT_Data_Inicial.Enabled = valor;
            this.TXB_Num_Doc.ReadOnly = !valor;
            this.CB_Qtd_Parc.Enabled = valor;
            this.CHK_Configuracao.Enabled = valor;
            this.TXB_Devedor_Nao_Cadastrado.ReadOnly = !valor;
            this.TXB_Valor_Total.ReadOnly = !valor;

            if (valor)
            {
                this.TXB_Num_Doc.BackColor = Color.White;
                this.TXB_Valor_Total.BackColor = Color.White;
                this.CB_Qtd_Parc.BackColor = Color.White;
                this.DGV_Parcelas.BackgroundColor = Color.White;
            }
            else
            {
                this.TXB_Num_Doc.BackColor = Color.WhiteSmoke;
                this.TXB_Valor_Total.BackColor = Color.WhiteSmoke;
                this.CB_Qtd_Parc.BackColor = Color.WhiteSmoke;
                this.DGV_Parcelas.BackgroundColor = Color.White;
            }
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Fechar.Enabled = true;
                this.BTN_Gerar_Parcelas.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Fechar.Enabled = false;
                this.BTN_Gerar_Parcelas.Enabled = false;
            }
        }


        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.DGV_Contas_Receber.DataSource = NContas_Receber.Mostrar();
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Receber.Rows.Count);

            // Ocultar Colunas
            this.DGV_Contas_Receber.Columns[1].Visible = false;
            this.DGV_Contas_Receber.Columns[2].Visible = false;
            this.DGV_Contas_Receber.Columns[4].Visible = false;
            this.DGV_Contas_Receber.Columns[5].Visible = false;
            this.DGV_Contas_Receber.Columns[9].Visible = false;

            // Nome da Colunas
            this.DGV_Contas_Receber.Columns[1].HeaderText = "Nº";
            this.DGV_Contas_Receber.Columns[2].HeaderText = "Cód. da Venda";
            this.DGV_Contas_Receber.Columns[3].HeaderText = "Data de Entrada";
            this.DGV_Contas_Receber.Columns[4].HeaderText = "Cliente Cadastrado";
            this.DGV_Contas_Receber.Columns[5].HeaderText = "Cliente não Cadastrado";
            this.DGV_Contas_Receber.Columns[6].HeaderText = "Nº do Documento";
            this.DGV_Contas_Receber.Columns[7].HeaderText = "Valor Total";
            this.DGV_Contas_Receber.Columns[8].HeaderText = "Parcelado em:";

            // Formato Moeda
            this.DGV_Contas_Receber.Columns[7].DefaultCellStyle.Format = "c";

            // Mostrar Modo de exibição
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Mostrar Detalhes Contas Receber
        public void MostrarDetalheParcelas()
        {
            this.DGV_Parcelas.DataSource = NContas_Receber.MostrarDetalhes(TXB_Id.Text);
            LB_Total_Parcelas.Text = "Total de parcelas: " + Convert.ToString(DGV_Parcelas.Rows.Count);

            // Ocultar Colunas
            this.DGV_Parcelas.Columns[0].Visible = false;
            this.DGV_Parcelas.Columns[1].Visible = false;
            this.DGV_Parcelas.Columns[2].Visible = false;
            this.DGV_Parcelas.Columns[3].Visible = false;
            
            // Nome Coluna
            this.DGV_Parcelas.Columns[7].HeaderText = "Status";
            this.DGV_Parcelas.Columns[8].HeaderText = "Obs.";
            this.DGV_Parcelas.Columns[9].HeaderText = "Valor Atualizado";

            // Formato Coluna Avulsa
            this.DGV_Parcelas.Columns[9].DefaultCellStyle.Format = "c";
        }


        // Metodo Buscar Pelo Nome do Cliente
        private void Buscar_Pelo_Devedor()
        {
            this.DGV_Contas_Receber.DataSource = NContas_Receber.Buscar_Pelo_Cliente(this.TXB_Buscar.Text);
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Receber.Rows.Count);

            // Mostrar Coluna com o nome do devedor conforme situação
            foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    this.DGV_Contas_Receber.Columns[1].Visible = false;
                    this.DGV_Contas_Receber.Columns[2].Visible = false;
                    this.DGV_Contas_Receber.Columns[4].Visible = true;
                    this.DGV_Contas_Receber.Columns[5].Visible = false;
                }
                else
                {
                    this.DGV_Contas_Receber.Columns[1].Visible = false;
                    this.DGV_Contas_Receber.Columns[2].Visible = false;
                    this.DGV_Contas_Receber.Columns[4].Visible = false;
                    this.DGV_Contas_Receber.Columns[5].Visible = true;
                }
            }
        }


        // Metodo Pesquisa Específica
        public void Pesquisa_Especifica(string data_inicial, string data_final, string devedor)
        {
            this.DGV_Contas_Receber.DataSource = NContas_Receber.Pesquisa_Especifica(data_inicial, data_final, devedor);
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Receber.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Específico";

            // Mostrar Coluna com o nome do devedor conforme situação
            foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    this.DGV_Contas_Receber.Columns[1].Visible = false;
                    this.DGV_Contas_Receber.Columns[2].Visible = false;
                    this.DGV_Contas_Receber.Columns[4].Visible = true;
                    this.DGV_Contas_Receber.Columns[5].Visible = false;
                }
                else
                {
                    this.DGV_Contas_Receber.Columns[1].Visible = false;
                    this.DGV_Contas_Receber.Columns[2].Visible = false;
                    this.DGV_Contas_Receber.Columns[4].Visible = false;
                    this.DGV_Contas_Receber.Columns[5].Visible = true;
                }
            }
        }


        // Calcular total geral devido pelo cliente
        private void Calcular_Total_Geral_Debitos()
        {
            for (int i = 0; i <= this.DGV_Contas_Receber.Rows.Count - 1; i++)
            {
                if (this.DGV_Contas_Receber.Rows.Count > 0)
                {
                    this.total_geral_debitos += Convert.ToDecimal(this.DGV_Contas_Receber.Rows[i].Cells[9].Value);
                    this.label11.Visible = true;
                    this.LB_Valor_Total.Visible = true;
                    this.LB_Valor_Total.Text = this.total_geral_debitos.ToString("C");
                }
            }
        }


        public void Calcular_Recebimento_Externo(decimal total_recebido, bool Recebimento_Parcial, decimal VALOR_CONTA, string NUM_DOC, string NOME_CLIENTE, string NOME_CLIENTE_NAO_CADASTRADO, int IDREGISTRO)
        {
            string resp = "";
            
            if (this.Key)
            {
                if (Recebimento_Parcial)
                {
                    // Obtendo valor recebido
                    this.Total_Recebido = total_recebido;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Calculando  valor restante
                    this.Total_Restante = Valor_Conta - this.Total_Recebido;

                    // Obtendo número do documento
                    string Numero_Documento = NUM_DOC;

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", Numero_Documento + "A", this.Total_Recebido, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();

                        // Criando novo registro de debito com o valor restante
                        if (NOME_CLIENTE != "")
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = NOME_CLIENTE;

                            // Obtendo id do cliente
                            this.TBL_Dados_Cliente = NCliente.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Cliente.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.IdCliente = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = this.IdCliente;
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Cadastrado(Data_Atual, Nome_Devedor, "R" + Numero_Documento, "1 X", this.Total_Restante, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = NOME_CLIENTE_NAO_CADASTRADO;

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = 0; // No caso de ser um cliente não cadastrado o ID = 0
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R" + Numero_Documento, "1 X", this.Total_Restante, this.dtparc);
                        }

                        // Excluir Registros quitados
                        resp = NContas_Receber.ExcluirTudo(IDREGISTRO);

                        // Limpar Variaveis 
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.CHK_Selecionar.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
                else
                {
                    // Obtendo valor recebido
                    this.Total_Recebido = total_recebido;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Obtendo número do documento
                    string Numero_Documento = NUM_DOC;

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", Numero_Documento + "A", this.Total_Recebido, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");
                        
                        // Excluir Registro quitado
                        resp = NContas_Receber.ExcluirTudo(IDREGISTRO);

                        // Limpar Variaveis 
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.CHK_Selecionar.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
            }
            else if (this.LB_Modo_Exibicao.Text == "Específico")
            {
                if (Recebimento_Parcial)
                {
                    // Obtendo valor recebido
                    this.Total_Recebido = total_recebido;
                    this.Total_Restante = this.total_geral_debitos - this.Total_Recebido;

                    // Capturando números dos documentos quitados
                    string num_doc = "";
                    string num_doc_2 = "";
                    for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                    {
                        num_doc = num_doc + DGV_Contas_Receber.Rows[i].Cells[6].Value.ToString() + "A, ";
                        num_doc_2 = num_doc_2 + DGV_Contas_Receber.Rows[i].Cells[6].Value.ToString() + ",";
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", num_doc, this.Total_Recebido, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();

                        bool chave = false;
                        // Criando novo registro de debito com o valor restante
                        foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
                        {
                            if (row.Cells[4].Value.ToString() != "")
                            {
                                chave = true;
                            }
                        }
                        if (chave)
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Receber.Rows[0].Cells[4].Value.ToString();

                            // Obtendo id do cliente
                            this.TBL_Dados_Cliente = NCliente.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Cliente.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.IdCliente = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = this.IdCliente;
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc_2, "1 X", this.Total_Restante, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Receber.Rows[0].Cells[5].Value.ToString();

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = 0; // No caso de ser um cliente não cadastrado o ID = 0
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc_2, "1 X", this.Total_Restante, this.dtparc);
                        }


                        // Excluir Registros quitados
                        for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Contas_Receber.Rows[i].Cells[1].Value);

                            resp = NContas_Receber.ExcluirTudo(id);
                        }

                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.CHK_Selecionar.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
                else
                {
                    // Obtendo valor recebido
                    this.Total_Recebido = total_recebido;
                    
                    // Capturando números dos documentos quitados
                    string num_doc = "";
                    for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                    {
                        num_doc = num_doc + DGV_Contas_Receber.Rows[i].Cells[6].Value.ToString() + "A, ";
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", num_doc, this.Total_Recebido, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Excluir Registros quitados
                        for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Contas_Receber.Rows[i].Cells[1].Value);

                            resp = NContas_Receber.ExcluirTudo(id);
                        }

                        // Limpar Variaveis
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.CHK_Selecionar.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
            }
        }


        public void Calcular_Recebimento_Interno(decimal total_recebido, bool Recebimento_Parcial, decimal VALOR_CONTA, string NUM_PARCELA, int IDCLIENTE, int IDPARCELA)
        {
            string resp = "";

            if (this.Key_Interna)   // QUITAR SOMENTE A PARCELA SELECIONADA
            {
                if (Recebimento_Parcial)
                {
                    // Obtendo valor recebido
                    this.Total_Recebido_Interno = total_recebido;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Calculando  valor restante
                    this.Total_Restante_Interno = Valor_Conta - this.Total_Recebido_Interno;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = NUM_PARCELA;
                    string letra_parcela = "";
                    string docFinal = "";

                    if (num_parc.Equals("1"))
                    {
                        letra_parcela = "A";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("2"))
                    {
                        letra_parcela = "B";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("3"))
                    {
                        letra_parcela = "C";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("4"))
                    {
                        letra_parcela = "D";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("5"))
                    {
                        letra_parcela = "E";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("6"))
                    {
                        letra_parcela = "F";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("7"))
                    {
                        letra_parcela = "G";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("8"))
                    {
                        letra_parcela = "H";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("9"))
                    {
                        letra_parcela = "I";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("10"))
                    {
                        letra_parcela = "J";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("11"))
                    {
                        letra_parcela = "K";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("12"))
                    {
                        letra_parcela = "L";
                        docFinal = num_doc + letra_parcela;
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", docFinal, this.Total_Recebido_Interno, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Criando nova parcela com o valor restante
                        DateTime Data_Atual = DateTime.Now;
                        DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                        int idcliente = IDCLIENTE;

                        // Criar Parcela
                        resp = NContas_Receber.Inserir_Parcela(Convert.ToInt32(this.TXB_Id.Text), idcliente, Convert.ToInt32(num_parc), this.Total_Restante_Interno, Data_Vencimento, "A VENCER", "RESTO");
                        

                        // Excluir parcela quitada
                        resp = NContas_Receber.ExcluirParcelas(IDPARCELA);
                        

                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.MostrarDetalheParcelas();
                        this.CHKB_Selecionar.Checked = false;
                        this.CHK_Selecionar_Tudo.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
                else // QUITAR TOTAL
                {
                    // Obtendo valor recebido
                    this.Total_Recebido_Interno = total_recebido;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = NUM_PARCELA;
                    string letra_parcela = "";
                    string docFinal = "";

                    if (num_parc.Equals("1"))
                    {
                        letra_parcela = "A";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("2"))
                    {
                        letra_parcela = "B";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("3"))
                    {
                        letra_parcela = "C";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("4"))
                    {
                        letra_parcela = "D";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("5"))
                    {
                        letra_parcela = "E";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("6"))
                    {
                        letra_parcela = "F";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("7"))
                    {
                        letra_parcela = "G";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("8"))
                    {
                        letra_parcela = "H";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("9"))
                    {
                        letra_parcela = "I";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("10"))
                    {
                        letra_parcela = "J";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("11"))
                    {
                        letra_parcela = "K";
                        docFinal = num_doc + letra_parcela;
                    }
                    else if (num_parc.Equals("12"))
                    {
                        letra_parcela = "L";
                        docFinal = num_doc + letra_parcela;
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", docFinal, this.Total_Recebido_Interno, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Verificar se há uma parcela ou mais para definir tipo de deleção 
                        if (this.DGV_Parcelas.Rows.Count > 1)
                        {
                            // Excluir somente a parcela
                            resp = NContas_Receber.ExcluirParcelas(IDPARCELA);
                        }
                        else
                        {
                            // Excluir a parcela
                            resp = NContas_Receber.ExcluirParcelas(IDPARCELA);

                            // Excluir registro principal
                            int idcontas_receber = Convert.ToInt32(this.TXB_Id.Text);
                            resp = NContas_Receber.ExcluirTudo(idcontas_receber);

                            this.tabControl1.SelectedIndex = 0;
                        }
                        
                    
                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.MostrarDetalheParcelas();
                        this.CHKB_Selecionar.Checked = false;
                        this.CHK_Selecionar_Tudo.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
            }
            else // -------------     QUITAR TODAS AS PARCELAS DE UMA SÓ VEZ -------
            {
                if (Recebimento_Parcial)  // COM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Recebido_Interno = total_recebido;

                    // Calculando valor restante
                    this.Total_Restante_Interno = this.Total_Todas_Parcelas - this.Total_Recebido_Interno;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = "";
                    string letra_parcela = "";
                    string docFinal = "";
                    string docFinal2 = "";

                    for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                    {
                        num_parc = DGV_Parcelas.Rows[i].Cells[4].Value.ToString();

                        if (num_parc.Equals("1"))
                        {
                            letra_parcela = "A";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";   // Número de documento para inserir no caixa 
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("2"))
                        {
                            letra_parcela = "B";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("3"))
                        {
                            letra_parcela = "C";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("4"))
                        {
                            letra_parcela = "D";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("5"))
                        {
                            letra_parcela = "E";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("6"))
                        {
                            letra_parcela = "F";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("7"))
                        {
                            letra_parcela = "G";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("8"))
                        {
                            letra_parcela = "H";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("9"))
                        {
                            letra_parcela = "I";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("10"))
                        {
                            letra_parcela = "J";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("11"))
                        {
                            letra_parcela = "K";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                        else if (num_parc.Equals("12"))
                        {
                            letra_parcela = "L";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                            docFinal2 = docFinal2 + letra_parcela + ",";  // Número de documento para criar uma nova parcela
                        }
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", docFinal, this.Total_Recebido_Interno, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();
                        
                        // Criando novo registro de debito com o valor restante
                        if (this.DGV_Contas_Receber.CurrentRow.Cells[4].Value.ToString() != "")  // Verificar se cliente cadastrado ou não
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Receber.CurrentRow.Cells[4].Value.ToString();

                            // Obtendo id do cliente
                            this.TBL_Dados_Cliente = NCliente.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Cliente.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.IdCliente = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = this.IdCliente;
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante_Interno;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc + docFinal2, "1 X", this.Total_Restante_Interno, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Receber.CurrentRow.Cells[5].Value.ToString();

                            DataRow linha = dtparc.NewRow();
                            linha["idcliente"] = 0; // No caso de ser um cliente não cadastrado o ID = 0
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante_Interno;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            this.dtparc.Rows.Add(linha);

                            NContas_Receber.Inserir_Devedor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc + docFinal2, "1 X", this.Total_Restante_Interno, this.dtparc);
                        }
                       
                        

                        // Excluir todas as parcelas quitados
                        for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);

                            resp = NContas_Receber.ExcluirParcelas(id);
                        }

                        // Excluir registro principal
                        resp = NContas_Receber.ExcluirTudo(Convert.ToInt32(this.TXB_Id.Text));

                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.MostrarDetalheParcelas();
                        this.tabControl1.SelectedIndex = 0;
                        this.CHKB_Selecionar.Checked = false;
                        this.CHK_Selecionar_Tudo.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
                else     // SEM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Recebido_Interno = total_recebido;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = "";
                    string letra_parcela = "";
                    string docFinal = "";

                    for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                    {
                        num_parc = DGV_Parcelas.Rows[i].Cells[4].Value.ToString();

                        if (num_parc.Equals("1"))
                        {
                            letra_parcela = "A";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("2"))
                        {
                            letra_parcela = "B";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("3"))
                        {
                            letra_parcela = "C";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("4"))
                        {
                            letra_parcela = "D";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("5"))
                        {
                            letra_parcela = "E";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("6"))
                        {
                            letra_parcela = "F";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("7"))
                        {
                            letra_parcela = "G";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("8"))
                        {
                            letra_parcela = "H";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("9"))
                        {
                            letra_parcela = "I";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("10"))
                        {
                            letra_parcela = "J";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("11"))
                        {
                            letra_parcela = "K";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                        else if (num_parc.Equals("12"))
                        {
                            letra_parcela = "L";
                            docFinal = docFinal + num_doc + letra_parcela + ", ";
                        }
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", docFinal, this.Total_Recebido_Interno, Convert.ToDecimal("0,00"));

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Excluir todas as parcelas quitados
                        for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);

                            resp = NContas_Receber.ExcluirParcelas(id);
                        }

                        // Excluir registro principal
                        resp = NContas_Receber.ExcluirTudo(Convert.ToInt32(this.TXB_Id.Text));

                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;
                        this.Mostrar();
                        this.MostrarDetalheParcelas();
                        this.tabControl1.SelectedIndex = 0;
                        this.CHKB_Selecionar.Checked = false;
                        this.CHK_Selecionar_Tudo.Checked = false;
                    }
                    else
                    {
                        MensagemErro("A operação não foi efetuada com êxito");
                    }
                }
            }
        }

        private void Calcular_Total_Parcelas()
        {
            if (this.DGV_Parcelas.DataSource != null & this.DGV_Parcelas.Rows.Count > 0)
            {
                this.Total_Todas_Parcelas = 0;
                for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                {
                    this.Total_Todas_Parcelas += Convert.ToDecimal(this.DGV_Parcelas.Rows[i].Cells[9].Value);
                }
            }
        }
        
        private void Deletar_Permissao_TRUE(string IdParcela)
        {
            try
            {
                int Codigo;
                string Resp = "";

                // Se houver somente uma parcela: Excluir a parcela e o registro principal
                if (this.DGV_Parcelas.Rows.Count == 1)
                {
                    // Excluir Parcela
                    Resp = NContas_Receber.ExcluirParcelas(Convert.ToInt32(IdParcela));

                    // Excluir Registro Principal
                    Codigo = Convert.ToInt32(this.TXB_Id.Text);
                    Resp = NContas_Receber.ExcluirTudo(Convert.ToInt32(Codigo));

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
                    // Excluir Parcela
                    Resp = NContas_Receber.ExcluirParcelas(Convert.ToInt32(IdParcela));

                    if (Resp.Equals("Ok"))
                    {
                        this.MensagemOk("A exclusão foi realizada com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(Resp);
                    }
                }

                this.CHKB_Selecionar.Checked = false;
                this.MostrarDetalheParcelas();
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        public void Deletar_Permissao_FALSE(bool Permitido, string IdParcela)
        {
            if (Permitido)
            {
                try
                {
                    int Codigo;
                    string Resp = "";

                    // Se houver somente uma parcela: Excluir a parcela e o registro principal
                    if (this.DGV_Parcelas.Rows.Count == 1)
                    {
                        // Excluir Parcela
                        Resp = NContas_Receber.ExcluirParcelas(Convert.ToInt32(IdParcela));

                        // Excluir Registro Principal
                        Codigo = Convert.ToInt32(this.TXB_Id.Text);
                        Resp = NContas_Receber.ExcluirTudo(Convert.ToInt32(Codigo));

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
                        // Excluir Parcela
                        Resp = NContas_Receber.ExcluirParcelas(Convert.ToInt32(IdParcela));

                        if (Resp.Equals("Ok"))
                        {
                            this.MensagemOk("A exclusão foi realizada com sucesso");
                        }
                        else
                        {
                            this.MensagemErro(Resp);
                        }
                    }

                    this.CHKB_Selecionar.Checked = false;
                    this.MostrarDetalheParcelas();
                    this.Mostrar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }


        private void Inserir_Permissao_TRUE()
        {
            this.CriarTabela();
            this.CB_Qtd_Parc.SelectedIndex = 0;
            this.CHKB_Selecionar.Enabled = false;
            this.DGV_Parcelas.Columns[0].Visible = false;
            this.BTN_Deletar.Enabled = false;


            this.eNovo = true;
            this.botoes();
            this.Habilitar(true);
            this.TXB_Num_Doc.Focus();
        }

        public void Inserir_Permissao_FALSE(bool Permitido)
        {
            if (Permitido)
            {
                this.CriarTabela();
                this.CB_Qtd_Parc.SelectedIndex = 0;
                this.CHKB_Selecionar.Enabled = false;
                this.DGV_Parcelas.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;


                this.eNovo = true;
                this.botoes();
                this.Habilitar(true);
                this.TXB_Num_Doc.Focus();
            }
        }

        //CLASSSE PARCELAS E SUAS PROPRIEDADES
        public class Parcela
        {
            public int num_parcela { get; set; }
            public decimal valor { get; set; }
            public DateTime vencimento { get; set; }
        }

        private void CriarTabela()
        {
            this.dtparc = new DataTable("Gerar");
            this.dtparc.Columns.Add("idcliente", System.Type.GetType("System.Int32"));
            this.dtparc.Columns.Add("num_parcela", System.Type.GetType("System.Int32"));
            this.dtparc.Columns.Add("valor", System.Type.GetType("System.Decimal"));
            this.dtparc.Columns.Add("vencimento", System.Type.GetType("System.DateTime"));
            this.dtparc.Columns.Add("estado", System.Type.GetType("System.String"));
            this.dtparc.Columns.Add("obs", System.Type.GetType("System.String"));
        }

        private void ComboCliente()
        {
            CB_Cliente.DataSource = NCliente.Mostrar();
            CB_Cliente.ValueMember = "Idcliente";
            CB_Cliente.DisplayMember = "nome_completo";
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo)
            {
                this.TXB_Num_Doc.BackColor = Color.LemonChiffon;
                this.TXB_Valor_Total.BackColor = Color.LemonChiffon;
                this.CB_Qtd_Parc.BackColor = Color.LemonChiffon;
                this.DGV_Parcelas.BackgroundColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Num_Doc.BackColor = Color.WhiteSmoke;
                this.TXB_Valor_Total.BackColor = Color.WhiteSmoke;
                this.CB_Qtd_Parc.BackColor = Color.WhiteSmoke;
                this.DGV_Parcelas.BackgroundColor = Color.White;
            }
        }


        private void FRM_Contas_Reb_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.ComboCliente();
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();

            if (this.DGV_Contas_Receber.Rows.Count > 0)
            {
                this.DGV_Contas_Receber.Focus();
                this.DGV_Contas_Receber.CurrentCell = this.DGV_Contas_Receber.Rows[0].Cells[3];
            }
        }

     
        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            bool chave = false;
            string IdParcela = "";

            foreach (DataGridViewRow row in DGV_Parcelas.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    chave = true;
                    IdParcela = row.Cells[1].Value.ToString();
                }
            }
            if (chave)
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar esta parcela?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    if (this.PERMISSAO_DELETAR_CONTA_RECEBER == "SIM")
                    {
                        this.Deletar_Permissao_TRUE(IdParcela);
                    }
                    else
                    {
                        FRM_Solicitar_Permissao_Deletar_Conta_Receber Solicitar_Permissao = FRM_Solicitar_Permissao_Deletar_Conta_Receber.GetInstancia();
                        Solicitar_Permissao.idparcela = IdParcela;
                        Solicitar_Permissao.Show();
                    }
                }
            }
            else
            {
                this.MensagemErro("Selecione uma parcela.");
            }
        }

        private void FRM_Contas_Reb_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Fechar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
            this.Close();
        }

        private void CHKB_Selecionar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CHKB_Selecionar.Checked)
            {
                if (this.DGV_Parcelas.Rows.Count > 0)
                {
                    this.DGV_Parcelas.Columns[0].Visible = true;
                    this.BTN_Deletar.Enabled = true;

                    this.Key_Interna = true;
                    this.BTN_Quitar_Tudo_Interno.Enabled = true;
                    this.Calcular_Total_Parcelas();
                }
                else
                {
                    CHKB_Selecionar.Checked = false;
                    this.MensagemErro("Não há registros");
                }
            }
            else
            {
                this.DGV_Parcelas.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;

                this.Key_Interna = false;
                this.BTN_Quitar_Tudo_Interno.Enabled = false;

                foreach (DataGridViewRow _row in DGV_Parcelas.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        

        private void DGV_Contas_Receber_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Contas_Receber.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)DGV_Contas_Receber.Rows[e.RowIndex].Cells["Select"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void DGV_Parcelas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Parcelas.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)DGV_Parcelas.Rows[e.RowIndex].Cells["Selecionar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void CHK_Configuracao_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Configuracao.Checked)
            {
                this.CB_Cliente.Visible = true;
                this.TXB_Devedor_Nao_Cadastrado.Visible = false;
            }
            else
            {
                this.CB_Cliente.Visible = false;
                this.TXB_Devedor_Nao_Cadastrado.Visible = true;
            }
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Num_Doc.Text == string.Empty || this.TXB_Valor_Total.Text == string.Empty || this.CB_Qtd_Parc.Text == string.Empty || this.DGV_Parcelas.Rows.Count == 0)
                {
                    this.MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.CHK_Configuracao.Checked == false)
                    {
                        if (this.TXB_Devedor_Nao_Cadastrado.Text == string.Empty)
                        {
                            this.MensagemErro("Preencha todos os campos.");
                        }
                        else
                        {
                            if (this.eNovo)
                            {
                                for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                                {
                                    this.col0 = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);  //num_parcela
                                    this.col1 = Convert.ToDecimal(DGV_Parcelas.Rows[i].Cells[2].Value);  //valor
                                    this.col2 = Convert.ToDateTime(DGV_Parcelas.Rows[i].Cells[3].Value);   //vencimento


                                    DataRow row = dtparc.NewRow();

                                    row["idcliente"] = Convert.ToInt32(this.CB_Cliente.SelectedValue);
                                    row["num_parcela"] = col0;
                                    row["valor"] = col1;
                                    row["vencimento"] = col2;
                                    row["estado"] = "A VENCER";
                                    row["obs"] = "";
                                    this.dtparc.Rows.Add(row);

                                }

                                if (this.CHK_Configuracao.Checked)
                                {
                                    resp = NContas_Receber.Inserir_Devedor_Cadastrado(this.DT_Data_Inicial.Value, this.CB_Cliente.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                                }
                                else
                                {
                                    resp = NContas_Receber.Inserir_Devedor_Nao_Cadastrado(this.DT_Data_Inicial.Value, this.TXB_Devedor_Nao_Cadastrado.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                                }

                            }

                            if (resp.Equals("Ok"))
                            {
                                this.MensagemOk("Registro salvo com sucesso");
                            }
                            else
                            {
                                this.MensagemErro(resp);
                            }

                            this.eNovo = false;
                            this.botoes();
                            this.Limpar();
                            this.Close();
                        }
                    }
                    else
                    {
                        if (this.eNovo)
                        {
                            for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                            {
                                this.col0 = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);  //num_parcela
                                this.col1 = Convert.ToDecimal(DGV_Parcelas.Rows[i].Cells[2].Value);  //valor
                                this.col2 = Convert.ToDateTime(DGV_Parcelas.Rows[i].Cells[3].Value);   //vencimento


                                DataRow row = dtparc.NewRow();

                                row["idcliente"] = Convert.ToInt32(this.CB_Cliente.SelectedValue);
                                row["num_parcela"] = col0;
                                row["valor"] = col1;
                                row["vencimento"] = col2;
                                row["estado"] = "A VENCER";
                                row["obs"] = "";
                                this.dtparc.Rows.Add(row);

                            }

                            if (this.CHK_Configuracao.Checked)
                            {
                                resp = NContas_Receber.Inserir_Devedor_Cadastrado(this.DT_Data_Inicial.Value, this.CB_Cliente.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                            }
                            else
                            {
                                resp = NContas_Receber.Inserir_Devedor_Nao_Cadastrado(this.DT_Data_Inicial.Value, this.TXB_Devedor_Nao_Cadastrado.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                            }

                        }

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.eNovo = false;
                        this.botoes();
                        this.Limpar();
                        this.Alerta_Campos_Obrigatorios();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Gerar_Parcelas_Click(object sender, EventArgs e)
        {
            if (this.TXB_Valor_Total.Text == string.Empty)
            {
                this.MensagemErro("Insira o valor total.");
            }
            else
            {
                string escolha = CB_Qtd_Parc.SelectedItem.ToString();

                switch (escolha)
                {
                    case "1 X":
                        CalcularParcela(1);
                        break;

                    case "2 X":
                        CalcularParcela(2);
                        break;

                    case "3 X":
                        CalcularParcela(3);
                        break;

                    case "4 X":
                        CalcularParcela(4);
                        break;

                    case "5 X":
                        CalcularParcela(5);
                        break;

                    case "6 X":
                        CalcularParcela(6);
                        break;

                    case "7 X":
                        CalcularParcela(7);
                        break;

                    case "8 X":
                        CalcularParcela(8);
                        break;

                    case "9 X":
                        CalcularParcela(9);
                        break;

                    case "10 X":
                        CalcularParcela(10);
                        break;

                    case "11 X":
                        CalcularParcela(11);
                        break;

                    case "12 X":
                        CalcularParcela(12);
                        break;
                }
            }
        }

        private void CalcularParcela(int qtdeParcela)
        {
            DateTime DataVencimento = DT_Data_Inicial.Value;
            decimal ValorTotal = Convert.ToDecimal(TXB_Valor_Total.Text.ToString());

            int totalParcelas = qtdeParcela;

            int contador = 0;

            List<Parcela> lista = new List<Parcela>();
            for (int i = 0; i < totalParcelas; i++)
            {
                contador++;

                var parcela = new Parcela();
                parcela.num_parcela = contador;
                parcela.valor = ValorTotal / qtdeParcela;
                parcela.vencimento = DataVencimento.AddMonths(contador);

                lista.Add(parcela);
            }

            DGV_Parcelas.AutoGenerateColumns = false;
            DGV_Parcelas.DataSource = null;
            DGV_Parcelas.DataSource = lista;
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            if (this.PERMISSAO_INSERIR_CONTA_RECEBER == "SIM")
            {
                this.Inserir_Permissao_TRUE();
            }
            else
            {
                FRM_Solicitar_Permissao_Inserir_Conta_Receber frm = FRM_Solicitar_Permissao_Inserir_Conta_Receber.GetInstancia();
                frm.Show();
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                if (this.DGV_Contas_Receber.Rows.Count > 0)
                {
                    this.DGV_Contas_Receber.Columns[0].Visible = true;

                    this.BTN_Ver_Origem.Enabled = true;

                    this.Key = true;
                    this.BTN_Quitar_Externamente.Enabled = true;
                }
                else
                {
                    this.CHK_Selecionar.Checked = false;
                    this.MensagemErro("Não há registros.");
                }
            }
            else
            {
                this.DGV_Contas_Receber.Columns[0].Visible = false;

                this.BTN_Ver_Origem.Enabled = false;

                this.Key = false;
                this.BTN_Quitar_Externamente.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Contas_Receber.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
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

            if (this.LB_Modo_Exibicao.Text == "Específico")
            {
                this.Calcular_Total_Geral_Debitos();
                this.BTN_Quitar_Externamente.Enabled = true;
            }
            else
            {
                this.BTN_Quitar_Externamente.Enabled = false;
            }
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
          
            this.label11.Visible = false;
            this.LB_Valor_Total.Visible = false;
            this.total_geral_debitos = 0;

            if (this.BTN_Pesquisar_Devedor.Enabled)
            {
                this.BTN_Pesquisar_Devedor.Enabled = false;
            }
        }

        private void BTN_Pesquisa_Mista_Click(object sender, EventArgs e)
        {
            FRM_Pesquisa_Especifica_Contas_Receber frm = FRM_Pesquisa_Especifica_Contas_Receber.GetInstancia();
            frm.Show();
        }

        private void BTN_Pesquisar_Devedor_Click(object sender, EventArgs e)
        {
            this.Buscar_Pelo_Devedor();
            this.LB_Modo_Exibicao.Text = "Cliente";
            this.TXB_Buscar.Text = string.Empty;
        }

        private void BTN_Quitar_Tudo_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja quitar todas estas contas?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                try
                {
                    string resp = "";
                    bool chave = true;
                    foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
                    {
                        if (row.Cells[8].Value.ToString() != "1 X")
                        {
                            chave = false;
                            MensagemErro("Não é possível quitar tudo, pois pode haver contas parcelas em mais de uma vez. Dê um clique duplo sobre a(s) conta(s) com mais de uma parcela para mais detalhes.");
                        }
                    }
                    if (chave && this.total_geral_debitos > 0)
                    {
                        // Capturando números dos documentos quitados
                        string num_doc = "";
                        for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                        {
                            num_doc = num_doc + DGV_Contas_Receber.Rows[i].Cells[6].Value.ToString() + "A, ";
                        }
                        
                        // inserindo recebimentos no livro caixa
                        string Data = DateTime.Now.ToString("dd/MM/yyyy");
                        resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "RECEBIMENTO DE CONTAS", num_doc, this.total_geral_debitos, Convert.ToDecimal("0,00"));

                        if (resp.Equals("Ok"))
                        {
                            MensagemOk("Operação efetuada com êxito.");

                            // Excluir Registros quitados
                            for (int i = 0; i <= DGV_Contas_Receber.Rows.Count - 1; i++)
                            {
                                int id = Convert.ToInt32(DGV_Contas_Receber.Rows[i].Cells[1].Value);

                                resp = NContas_Receber.ExcluirTudo(id);
                            }

                            this.total_geral_debitos = 0;
                            this.LB_Valor_Total.Text = "R$ 0,00";
                            this.label11.Visible = false;
                            this.LB_Valor_Total.Visible = false;
                            this.Mostrar();
                        }
                        else
                        {
                            MensagemErro("A operação não foi efetuada com êxito");
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message + erro.StackTrace);
                }
            }
        }

        private void BTN_Ver_Origem_Click(object sender, EventArgs e)
        {
            try
            {
                bool chave = false;
                string IdVenda = "";

                foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        IdVenda = row.Cells[2].Value.ToString();
                    }
                }
                if (chave && IdVenda != "")
                {
                    FRM_Ver_Venda_Origem_Contas_Receber frm = FRM_Ver_Venda_Origem_Contas_Receber.GetInstancia();
                    frm.idvenda = IdVenda;
                    frm.Show();
                }
                else
                {
                    MensagemErro("Não é possível exibir a origem, pois não há um registro selecionado ou a conta é avulsa.");

                    if (this.CHK_Selecionar.Checked)
                    {
                        this.CHK_Selecionar.Checked = false;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void DGV_Contas_Receber_SelectionChanged(object sender, EventArgs e)
        {
            this.label9.Text = "";
            this.label9.Visible = false;
        }

        private void TXB_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BTN_Pesquisar_Devedor.Enabled = true;
        }

        private void BTN_Quitar_Externamente_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja quitar estas contas?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                if (this.Key)
                {
                    bool Trava = false;
                    decimal Valor = 0;
                    decimal VALOR_CONTA = 0;
                    string NUM_DOC = "";
                    string NOME_CLIENTE = "";
                    string NOME_CLIENTE_NAO_CADASTRADO = "";
                    int IDREGISTRO = 0;

                    foreach (DataGridViewRow Index in DGV_Contas_Receber.Rows)
                    {
                        if (Convert.ToBoolean(Index.Cells[0].Value))
                        {
                            Trava = true;
                            Valor = Convert.ToDecimal(Index.Cells[9].Value);
                            VALOR_CONTA = Convert.ToDecimal(Index.Cells[9].Value);
                            NUM_DOC = Index.Cells[6].Value.ToString();
                            NOME_CLIENTE = Index.Cells[4].Value.ToString();
                            NOME_CLIENTE_NAO_CADASTRADO = Index.Cells[5].Value.ToString();
                            IDREGISTRO = Convert.ToInt32(Index.Cells[1].Value);
                        }
                    }
                    if (Trava)
                    {
                        if (this.DGV_Contas_Receber.CurrentRow.Cells[8].Value.ToString() != "1 X")
                        {
                            MensagemErro("Não é possível realizar esta operação, pois pode haver contas parcelas em mais de uma vez. Dê um clique duplo sobre a(s) conta(s) com mais de uma parcela para mais detalhes.");
                        }
                        else
                        {
                            // Obtendo valor recebido e restante
                            FRM_Receber_Contas_Externo frm = FRM_Receber_Contas_Externo.GetInstancia();
                            frm.Valor_Atualizado = Valor;
                            frm.Valor_Conta = VALOR_CONTA;
                            frm.Num_Doc = NUM_DOC;
                            frm.Nome_Cliente = NOME_CLIENTE;
                            frm.Nome_Cliente_Nao_Cadastrado = NOME_CLIENTE_NAO_CADASTRADO;
                            frm.Idregistro = IDREGISTRO;
                            frm.Show();
                        }
                    }
                    else
                    {
                        this.MensagemErro("Selecione uma conta.");
                    }
                }
                else if (this.LB_Modo_Exibicao.Text == "Específico")
                {
                    bool chave = true;
                    foreach (DataGridViewRow row in DGV_Contas_Receber.Rows)
                    {
                        if (row.Cells[8].Value.ToString() != "1 X")
                        {
                            chave = false;
                            MensagemErro("Não é possível realizar esta operação, pois pode haver contas parcelas em mais de uma vez. Dê um clique duplo sobre a(s) conta(s) com mais de uma parcela para mais detalhes.");
                        }
                    }
                    if (chave && this.total_geral_debitos > 0)
                    {
                        // Obtendo valor recebido e restante
                        FRM_Receber_Contas_Externo frm = FRM_Receber_Contas_Externo.GetInstancia();
                        frm.Valor_Atualizado = this.total_geral_debitos;
                        frm.Show();
                    }
                }
            }
        }

        private void BTN_Quitar_Tudo_Interno_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja quitar estas contas?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                if (this.Key_Interna)
                {
                    bool Trava = false;
                    decimal Valor = 0;
                    decimal VALOR_CONTA = 0;
                    string NUM_PARCELA = "";
                    int IDCLIENTE = 0;
                    int IDPARCELA = 0;

                    foreach (DataGridViewRow linha in DGV_Parcelas.Rows)
                    {
                        if (Convert.ToBoolean(linha.Cells[0].Value))
                        {
                            Trava = true;
                            Valor = Convert.ToDecimal(linha.Cells[9].Value);
                            VALOR_CONTA = Convert.ToDecimal(linha.Cells[9].Value);
                            NUM_PARCELA = linha.Cells[4].Value.ToString();
                            IDCLIENTE = Convert.ToInt32(linha.Cells[3].Value);
                            IDPARCELA = Convert.ToInt32(linha.Cells[1].Value);
                        }
                    }
                    if (Trava)
                    {
                        FRM_Receber_Contas_Interno frm = FRM_Receber_Contas_Interno.GetInstancia();
                        frm.Valor_Atualizado = Valor;
                        frm.Valor_Conta = VALOR_CONTA;
                        frm.Num_Parcela = NUM_PARCELA;
                        frm.IdCliente = IDCLIENTE;
                        frm.IdParcela = IDPARCELA;
                        frm.Show();
                    }
                    else
                    {
                        this.MensagemErro("Selecione uma parcela.");
                    }
                }
                else
                {
                    FRM_Receber_Contas_Interno frm = FRM_Receber_Contas_Interno.GetInstancia();
                    frm.Valor_Atualizado = this.Total_Todas_Parcelas;
                    frm.Show();
                }
            }
        }

        private void CHK_Selecionar_Tudo_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Selecionar_Tudo.Checked)
            {
                if (this.DGV_Parcelas.Rows.Count > 0)
                {
                    this.BTN_Quitar_Tudo_Interno.Enabled = true;
                    this.Calcular_Total_Parcelas();
                }
                else
                {
                    this.CHK_Selecionar_Tudo.Checked = false;
                    this.MensagemErro("Não há parcelas");
                }
            }
            else
            {
                this.BTN_Quitar_Tudo_Interno.Enabled = false;
            }
        }

        private void DGV_Contas_Receber_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(DGV_Contas_Receber.CurrentRow.Cells[4].Value) != "")
            {
                // Tornar Visivel
                this.CB_Cliente.Visible = true;
                this.TXB_Devedor_Nao_Cadastrado.Visible = false;

                decimal valor;
                decimal valor_atualizado;
                this.TXB_Id.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["idcontas_receber"].Value);
                this.TXB_Num_Doc.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["num_doc"].Value);
                this.CB_Cliente.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["cliente_nome"].Value);
                this.CB_Qtd_Parc.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["total_parcelas"].Value);

                valor = Convert.ToDecimal(this.DGV_Contas_Receber.CurrentRow.Cells["valor_total"].Value);
                this.TXB_Valor_Total.Text = valor.ToString("C");

                valor_atualizado = Convert.ToDecimal(this.DGV_Contas_Receber.CurrentRow.Cells["valor_total_atualizado"].Value);
                this.TXB_Valor_Atualizado.Text = valor_atualizado.ToString("C");

                this.MostrarDetalheParcelas();
            }
            else
            {
                // Tornar Visivel
                this.CB_Cliente.Visible = false;
                this.TXB_Devedor_Nao_Cadastrado.Visible = true;

                decimal valor;
                decimal valor_atualizado;
                this.TXB_Id.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["idcontas_receber"].Value);
                this.TXB_Num_Doc.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["num_doc"].Value);
                this.TXB_Devedor_Nao_Cadastrado.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["devedor_nao_cadastrado"].Value);
                this.CB_Qtd_Parc.Text = Convert.ToString(this.DGV_Contas_Receber.CurrentRow.Cells["total_parcelas"].Value);

                valor = Convert.ToDecimal(this.DGV_Contas_Receber.CurrentRow.Cells["valor_total"].Value);
                this.TXB_Valor_Total.Text = valor.ToString("C");

                valor_atualizado = Convert.ToDecimal(this.DGV_Contas_Receber.CurrentRow.Cells["valor_total_atualizado"].Value);
                this.TXB_Valor_Atualizado.Text = valor_atualizado.ToString("C");

                this.MostrarDetalheParcelas();
            }

            this.BTN_Novo.Enabled = false;
            this.BTN_Fechar.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void DGV_Contas_Receber_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Capturando Dados
            string IdContas_Receber = this.DGV_Contas_Receber.CurrentRow.Cells[1].Value.ToString();
            this.TBL_Analise_Vencimento = NContas_Receber.MostrarDetalhes(IdContas_Receber);

            DateTime Data_Atual = DateTime.Now;

            // Analisar se há parcela vencida
            foreach (DataRow row in TBL_Analise_Vencimento.Rows)
            {
                if (row[6].ToString().Equals("VENCIDA"))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "HÁ PARCELA(S) VENCIDA(S)";
                }
            }
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Contas_Receber frm = FRM_Tipo_Relatorio_Contas_Receber.GetInstancia();
            frm.Show();
        }

        private void TXB_Valor_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
