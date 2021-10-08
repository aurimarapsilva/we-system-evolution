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
    public partial class FRM_Contas_Pagar : Form
    {
        private bool eNovo;
        DataTable dtparc;
        DataTable TBL_Analise_Vencimento;

        private int col0;
        private decimal col1;
        private DateTime col2;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Contas_Pagar _Instancia;

        public static FRM_Contas_Pagar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Contas_Pagar();
            }
            return _Instancia;
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
            this.dtparc.Columns.Add("num_parcela", System.Type.GetType("System.Int32"));
            this.dtparc.Columns.Add("valor", System.Type.GetType("System.Decimal"));
            this.dtparc.Columns.Add("vencimento", System.Type.GetType("System.DateTime"));
            this.dtparc.Columns.Add("estado", System.Type.GetType("System.String"));
            this.dtparc.Columns.Add("obs", System.Type.GetType("System.String"));
            this.dtparc.Columns.Add("idfornecedor", System.Type.GetType("System.Int32"));
        }

        public FRM_Contas_Pagar()
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
            this.TXB_Credor_Nao_Cadastrado.Text = string.Empty;
            this.TXB_Valor_Total.Text = string.Empty;
            this.CB_Fornecedor.Text = string.Empty;
            this.DGV_Parcelas.DataSource = null;
        }


        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.DT_Data_Inicial.Enabled = valor;
            this.TXB_Num_Doc.ReadOnly = !valor;
            this.CB_Qtd_Parc.Enabled = valor;
            this.CHK_Configuracao.Enabled = valor;
            this.CB_Fornecedor.Enabled = valor;
            this.TXB_Credor_Nao_Cadastrado.ReadOnly = !valor;
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
            this.DGV_Contas_Pagar.DataSource = NContas_Pagar.Mostrar();
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Pagar.Rows.Count);

            // Ocultar Colunas
            this.DGV_Contas_Pagar.Columns[1].Visible = false;
            this.DGV_Contas_Pagar.Columns[2].Visible = false;
            this.DGV_Contas_Pagar.Columns[4].Visible = false;
            this.DGV_Contas_Pagar.Columns[5].Visible = false;

            // Nome da Colunas
            this.DGV_Contas_Pagar.Columns[1].HeaderText = "Nº";
            this.DGV_Contas_Pagar.Columns[2].HeaderText = "ID Entrada";
            this.DGV_Contas_Pagar.Columns[3].HeaderText = "Data de Entrada";
            this.DGV_Contas_Pagar.Columns[4].HeaderText = "Credor Cadastrado";
            this.DGV_Contas_Pagar.Columns[5].HeaderText = "Credor não Cadastrado";
            this.DGV_Contas_Pagar.Columns[6].HeaderText = "Nº do Documento";
            this.DGV_Contas_Pagar.Columns[7].HeaderText = "Valor Total";
            this.DGV_Contas_Pagar.Columns[8].HeaderText = "Parcelado em:";

            // Formato da coluna
            this.DGV_Contas_Pagar.Columns[7].DefaultCellStyle.Format = "c";

            // Mostrar Modo de exibição
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Mostrar Detalhes Contas Receber
        public void MostrarDetalheParcelas()
        {
            this.DGV_Parcelas.DataSource = NContas_Pagar.MostrarDetalhes(TXB_Id.Text);
            LB_Total_Parcelas.Text = "Total de parcelas: " + Convert.ToString(DGV_Parcelas.Rows.Count);

            // Ocultar Colunas
            this.DGV_Parcelas.Columns[0].Visible = false;
            this.DGV_Parcelas.Columns[1].Visible = false;
            this.DGV_Parcelas.Columns[2].Visible = false;
            this.DGV_Parcelas.Columns[8].Visible = false;

            // Nome Coluna
            this.DGV_Parcelas.Columns[6].HeaderText = "Status";
            this.DGV_Parcelas.Columns[7].HeaderText = "Obs.";
        }


        // Metodo Buscar Pelo Nome do Fornecedor
        private void Buscar_Pelo_Credor()
        {
            this.DGV_Contas_Pagar.DataSource = NContas_Pagar.Buscar_Pelo_Credor(this.TXB_Buscar.Text);
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Pagar.Rows.Count);

            // Mostrar Coluna com o nome do devedor conforme situação
            foreach (DataGridViewRow row in DGV_Contas_Pagar.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    this.DGV_Contas_Pagar.Columns[1].Visible = false;
                    this.DGV_Contas_Pagar.Columns[2].Visible = false;
                    this.DGV_Contas_Pagar.Columns[4].Visible = true;
                    this.DGV_Contas_Pagar.Columns[5].Visible = false;
                }
                else
                {
                    this.DGV_Contas_Pagar.Columns[1].Visible = false;
                    this.DGV_Contas_Pagar.Columns[2].Visible = false;
                    this.DGV_Contas_Pagar.Columns[4].Visible = false;
                    this.DGV_Contas_Pagar.Columns[5].Visible = true;
                }
            }

            // Mostrar Modo de exibição
            this.LB_Modo_Exibicao.Text = "Credor";
        }


        // Metodo Pesquisa Específica
        public void Pesquisa_Especifica(string data_inicial, string data_final, string credor)
        {
            this.DGV_Contas_Pagar.DataSource = NContas_Pagar.Pesquisa_Especifica(data_inicial, data_final, credor);
            this.LB_Total_Registros.Text = Convert.ToString(DGV_Contas_Pagar.Rows.Count);

            // Mostrar Coluna com o nome do devedor conforme situação
            foreach (DataGridViewRow row in DGV_Contas_Pagar.Rows)
            {
                if (row.Cells[4].Value.ToString() != "")
                {
                    this.DGV_Contas_Pagar.Columns[1].Visible = false;
                    this.DGV_Contas_Pagar.Columns[2].Visible = false;
                    this.DGV_Contas_Pagar.Columns[4].Visible = true;
                    this.DGV_Contas_Pagar.Columns[5].Visible = false;
                }
                else
                {
                    this.DGV_Contas_Pagar.Columns[1].Visible = false;
                    this.DGV_Contas_Pagar.Columns[2].Visible = false;
                    this.DGV_Contas_Pagar.Columns[4].Visible = false;
                    this.DGV_Contas_Pagar.Columns[5].Visible = true;
                }
            }
        }


        //  >>>>>>>>> VARIAVEIS E METODOS PARA QUITAR CONTAS <<<<<<<<

        // ------- VARIAVEIS --------
        private decimal total_geral_debitos = 0;
        private DataTable TBL_Dados_Fornecedor;
        private int idfornecedor;

        // ------- Uso Externo ------
        private bool Key = false;
        private decimal Total_Restante = 0;
        private decimal Total_Pago = 0;

        // ------- Uso Interno ------ 
        private bool Key_Interna = false;
        private decimal Total_Restante_Interno = 0;
        private decimal Total_Pago_Interno = 0;
        private decimal Total_Todas_Parcelas = 0;

        // ------- METODOS --------
        // Calcular total geral devido pelo cliente
        private void Calcular_Total_Geral_Debitos()
        {
            for (int i = 0; i <= this.DGV_Contas_Pagar.Rows.Count - 1; i++)
            {
                if (this.DGV_Contas_Pagar.Rows.Count > 0)
                {
                    this.total_geral_debitos += Convert.ToDecimal(this.DGV_Contas_Pagar.Rows[i].Cells[7].Value);
                    this.label11.Visible = true;
                    this.LB_Valor_Total.Visible = true;
                    this.LB_Valor_Total.Text = this.total_geral_debitos.ToString("C");
                }
            }
        }


        public void Calcular_Pagamento_Externo(decimal total_pago, bool Pagamento_Parcial, decimal VALOR_CONTA, string NUM_DOC, string NOME_CREDOR, string NOME_CREDOR_NÃO_CADASTRADO, int IDREGISTRO)
        {
            string resp = "";

            if (this.Key)
            {
                if (Pagamento_Parcial)
                {
                    // Obtendo valor recebido
                    this.Total_Pago = total_pago;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Calculando  valor restante
                    this.Total_Restante = Valor_Conta - this.Total_Pago;

                    // Obtendo número do documento
                    string Numero_Documento = NUM_DOC;

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", Numero_Documento + "A", Convert.ToDecimal("0,00"), this.Total_Pago);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();
                        
                        if (NOME_CREDOR != "")
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = NOME_CREDOR;

                            // Obtendo id do fornecdor
                            this.TBL_Dados_Fornecedor = NFornecedor.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Fornecedor.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.idfornecedor = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = this.idfornecedor;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Cadastrado(Data_Atual, Nome_Devedor, "R - " + Numero_Documento, "1 X", this.Total_Restante, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = NOME_CREDOR_NÃO_CADASTRADO;

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = 0;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R - " + Numero_Documento, "1 X", this.Total_Restante, this.dtparc);
                        }


                        // Excluir Registros quitados
                        resp = NContas_Pagar.ExcluirTudo(IDREGISTRO);

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
                    this.Total_Pago = total_pago;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Obtendo número do documento
                    string Numero_Documento = NUM_DOC;

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", Numero_Documento + "A", Convert.ToDecimal("0,00"), this.Total_Pago);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Excluir Registros quitados
                        resp = NContas_Pagar.ExcluirTudo(IDREGISTRO);

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
                if (Pagamento_Parcial)
                {
                    this.Total_Pago = total_pago;
                    this.Total_Restante = this.total_geral_debitos - this.Total_Pago;

                    // Capturando números dos documentos quitados
                    string num_doc = "";
                    string num_doc_2 = "";
                    for (int i = 0; i <= DGV_Contas_Pagar.Rows.Count - 1; i++)
                    {
                        num_doc = num_doc + DGV_Contas_Pagar.Rows[i].Cells[6].Value.ToString() + "A, ";
                        num_doc_2 = num_doc_2 + DGV_Contas_Pagar.Rows[i].Cells[6].Value.ToString() + ",";
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", num_doc, Convert.ToDecimal("0,00"), this.Total_Pago);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();

                        bool chave = false;
                        // Criando novo registro de debito com o valor restante
                        foreach (DataGridViewRow row in DGV_Contas_Pagar.Rows)
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
                            string Nome_Devedor = this.DGV_Contas_Pagar.Rows[0].Cells[4].Value.ToString();

                            // Obtendo id do fornecedor
                            this.TBL_Dados_Fornecedor = NFornecedor.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Fornecedor.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.idfornecedor = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = this.idfornecedor;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc_2, "1 X", this.Total_Restante, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Pagar.Rows[0].Cells[5].Value.ToString();

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = 0;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc_2, "1 X", this.Total_Restante, this.dtparc);
                        }


                        // Excluir Registros quitados
                        for (int i = 0; i <= DGV_Contas_Pagar.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Contas_Pagar.Rows[i].Cells[1].Value);

                            resp = NContas_Pagar.ExcluirTudo(id);
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
                    this.Total_Pago = total_pago;

                    // Capturando números dos documentos quitados
                    string num_doc = "";
                    for (int i = 0; i <= DGV_Contas_Pagar.Rows.Count - 1; i++)
                    {
                        num_doc = num_doc + DGV_Contas_Pagar.Rows[i].Cells[6].Value.ToString() + "A, ";
                    }

                    // inserindo recebimentos no livro caixa
                    string Data = DateTime.Now.ToString("dd/MM/yyyy");
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", num_doc, Convert.ToDecimal("0,00"), this.Total_Pago);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Excluir Registros quitados
                        for (int i = 0; i <= DGV_Contas_Pagar.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Contas_Pagar.Rows[i].Cells[1].Value);

                            resp = NContas_Pagar.ExcluirTudo(id);
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


        public void Calcular_Pagamento_Interno(decimal total_pago, bool Pagamento_Parcial, decimal VALOR_CONTA, string NUM_PARC, int IDFORNECEDOR, int IDPARCELA)
        {
            string resp = "";

            if (this.Key_Interna)  // --- QUITAR SOMENTE A PARCELA SELECIONADA -----
            {
                if (Pagamento_Parcial) // COM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Pago_Interno = total_pago;

                    // Obtendo valor da total da conta a ser recebida parcialmente
                    decimal Valor_Conta = VALOR_CONTA;

                    // Calculando  valor restante
                    this.Total_Restante_Interno = Valor_Conta - this.Total_Pago_Interno;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = NUM_PARC;
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
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", docFinal, Convert.ToDecimal("0,00"), this.Total_Pago_Interno);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Criando nova parcela com o valor restante
                        DateTime Data_Atual = DateTime.Now;
                        DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                        int idfornecedor = IDFORNECEDOR;

                        // Criar Parcela
                        resp = NContas_Pagar.Inserir_Parcela(Convert.ToInt32(this.TXB_Id.Text), Convert.ToInt32(num_parc), this.Total_Restante_Interno, Data_Vencimento, "A VENCER", "RESTO", idfornecedor);
                        
                        // Excluir parcela quitada
                        resp = NContas_Pagar.ExcluirParcelas(IDPARCELA);


                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                       /* this.LB_Valor_Total.Text = "R$ 0,00";
                        this.label11.Visible = false;
                        this.LB_Valor_Total.Visible = false;*/
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
                else // SEM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Pago_Interno = total_pago;
                    
                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = NUM_PARC;
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
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", docFinal, Convert.ToDecimal("0,00"), this.Total_Pago_Interno);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        // Verificar se há uma parcela ou mais para definir tipo de deleção 
                        if (this.DGV_Parcelas.Rows.Count > 1)
                        {
                            // Excluir somente a parcela 
                            resp = NContas_Pagar.ExcluirParcelas(IDPARCELA);
                        }
                        else
                        {
                            // Excluir somente a parcela 
                            resp = NContas_Pagar.ExcluirParcelas(IDPARCELA);

                            // Excluir registro principal
                            int idcontas_pagar = Convert.ToInt32(this.TXB_Id.Text);
                            resp = NContas_Pagar.ExcluirTudo(idcontas_pagar);

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
                        /* this.LB_Valor_Total.Text = "R$ 0,00";
                         this.label11.Visible = false;
                         this.LB_Valor_Total.Visible = false;*/
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
            else  // -------------     QUITAR TODAS AS PARCELAS DE UMA SÓ VEZ -------
            {
                if (Pagamento_Parcial) // COM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Pago_Interno = total_pago;
                    
                    // Calculando  valor restante
                    this.Total_Restante_Interno = this.Total_Todas_Parcelas - this.Total_Pago_Interno;

                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = "";
                    string letra_parcela = "";
                    string docFinal = "";
                    string docFinal2 = "";

                    for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                    {
                        num_parc = DGV_Parcelas.Rows[i].Cells[3].Value.ToString();

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
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", docFinal, Convert.ToDecimal("0,00"), this.Total_Pago_Interno);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");

                        this.CriarTabela();

                        if (this.DGV_Contas_Pagar.CurrentRow.Cells[4].Value.ToString() != "")
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Pagar.Rows[0].Cells[4].Value.ToString();

                            // Obtendo id do fornecedor
                            this.TBL_Dados_Fornecedor = NFornecedor.Mostrar();
                            foreach (DataRow Registro in TBL_Dados_Fornecedor.Rows)
                            {
                                if (Registro[1].ToString().Equals(Nome_Devedor))
                                {
                                    this.idfornecedor = Convert.ToInt32(Registro[0]);
                                }
                            }

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante_Interno;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = this.idfornecedor;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc + docFinal2, "1 X", this.Total_Restante_Interno, this.dtparc);
                        }
                        else
                        {
                            DateTime Data_Atual = DateTime.Now;
                            DateTime Data_Vencimento = Data_Atual.AddMonths(1);
                            string Nome_Devedor = this.DGV_Contas_Pagar.Rows[0].Cells[5].Value.ToString();

                            DataRow linha = dtparc.NewRow();
                            linha["num_parcela"] = 1;
                            linha["valor"] = this.Total_Restante;
                            linha["vencimento"] = Data_Vencimento;
                            linha["estado"] = "A VENCER";
                            linha["obs"] = "RESTO";
                            linha["idfornecedor"] = 0;
                            this.dtparc.Rows.Add(linha);

                            NContas_Pagar.Inserir_Credor_Nao_Cadastrado(Data_Atual, Nome_Devedor, "R - " + num_doc + docFinal2, "1 X", this.Total_Restante, this.dtparc);
                        }

                        // Excluir todas as parcelas quitados
                        for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);

                            resp = NContas_Pagar.ExcluirParcelas(id);
                        }

                        // Excluir registro principal
                        resp = NContas_Pagar.ExcluirTudo(Convert.ToInt32(this.TXB_Id.Text));

                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        /* this.LB_Valor_Total.Text = "R$ 0,00";
                         this.label11.Visible = false;
                         this.LB_Valor_Total.Visible = false;*/
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
                else  // SEM RESTO
                {
                    // Obtendo valor recebido
                    this.Total_Pago_Interno = total_pago;
                    
                    // Capturando números dos documentos quitados
                    string num_doc = this.TXB_Num_Doc.Text;
                    string num_parc = "";
                    string letra_parcela = "";
                    string docFinal = "";
                    string docFinal2 = "";

                    for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                    {
                        num_parc = DGV_Parcelas.Rows[i].Cells[3].Value.ToString();

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
                    resp = NLivro_Caixa.Inserir(Convert.ToDateTime(Data), "PAGAMENTO DE CONTAS", docFinal, Convert.ToDecimal("0,00"), this.Total_Pago_Interno);

                    if (resp.Equals("Ok"))
                    {
                        MensagemOk("Operação efetuada com êxito.");
                        
                        // Excluir todas as parcelas quitados
                        for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                        {
                            int id = Convert.ToInt32(DGV_Parcelas.Rows[i].Cells[1].Value);

                            resp = NContas_Pagar.ExcluirParcelas(id);
                        }

                        // Excluir registro principal
                        resp = NContas_Pagar.ExcluirTudo(Convert.ToInt32(this.TXB_Id.Text));

                        // Limpar Variaveis
                        // Vriaveis do metodo
                        num_doc = "";
                        num_parc = "";
                        letra_parcela = "";
                        docFinal = "";

                        // Variaveis do Form
                        this.total_geral_debitos = 0;
                        /* this.LB_Valor_Total.Text = "R$ 0,00";
                         this.label11.Visible = false;
                         this.LB_Valor_Total.Visible = false;*/
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
        }


        private void Calcular_Total_Parcelas()
        {
            if (this.DGV_Parcelas.DataSource != null & this.DGV_Parcelas.Rows.Count > 0)
            {
                this.Total_Todas_Parcelas = 0;
                for (int i = 0; i <= DGV_Parcelas.Rows.Count - 1; i++)
                {
                    this.Total_Todas_Parcelas += Convert.ToDecimal(this.DGV_Parcelas.Rows[i].Cells[4].Value);
                }
            }
        }

        private void ComboFornecedor()
        {
            CB_Fornecedor.DataSource = NFornecedor.Mostrar();
            CB_Fornecedor.ValueMember = "Idfornecedor";
            CB_Fornecedor.DisplayMember = "empresa";
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


        private void FRM_Contas_Pagar_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.ComboFornecedor();
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();

            if (this.DGV_Contas_Pagar.Rows.Count > 0)
            {
                this.DGV_Contas_Pagar.Focus();
                this.DGV_Contas_Pagar.CurrentCell = this.DGV_Contas_Pagar.Rows[0].Cells[3];
            }
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            try
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
                    Opcao = MessageBox.Show("Realmente deseja apagar os registros?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.OK)
                    {
                        int Codigo;
                        string Resp = "";

                        // Se houver somente uma parcela: Excluir a parcela e o registro principal
                        if (this.DGV_Parcelas.Rows.Count == 1)
                        {
                            // Excluir Parcela
                            Resp = NContas_Pagar.ExcluirParcelas(Convert.ToInt32(IdParcela));

                            // Excluir Registro Principal
                            Codigo = Convert.ToInt32(this.TXB_Id.Text);
                            Resp = NContas_Pagar.ExcluirTudo(Codigo);
                            
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
                            Resp = NContas_Pagar.ExcluirParcelas(Convert.ToInt32(IdParcela));
                            
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
                }
                else
                {
                    this.MensagemErro("Selecione uma conta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Contas_Pagar_FormClosed(object sender, FormClosedEventArgs e)
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

        private void CHKB_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKB_Selecionar.Checked)
            {
                this.DGV_Parcelas.Columns[0].Visible = true;

                this.Key_Interna = true;
                this.BTN_Quitar_Internamente.Enabled = true;
                this.Calcular_Total_Parcelas();
                this.BTN_Deletar.Enabled = true;
            }
            else
            {
                this.DGV_Parcelas.Columns[0].Visible = false;

                this.Key_Interna = false;
                this.BTN_Quitar_Internamente.Enabled = false;
                this.BTN_Deletar.Enabled = false;

                foreach (DataGridViewRow _row in DGV_Parcelas.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
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
                this.CB_Fornecedor.Visible = true;
                this.TXB_Credor_Nao_Cadastrado.Visible = false;
            }
            else
            {
                this.CB_Fornecedor.Visible = false;
                this.TXB_Credor_Nao_Cadastrado.Visible = true;
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
                        if (this.TXB_Credor_Nao_Cadastrado.Text == string.Empty)
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

                                    row["num_parcela"] = col0;
                                    row["valor"] = col1;
                                    row["vencimento"] = col2;
                                    row["estado"] = "A VENCER";
                                    row["obs"] = "";
                                    row["idfornecedor"] = Convert.ToInt32(this.CB_Fornecedor.SelectedValue);
                                    this.dtparc.Rows.Add(row);
                                }

                                if (this.CHK_Configuracao.Checked)
                                {
                                    resp = NContas_Pagar.Inserir_Credor_Cadastrado(this.DT_Data_Inicial.Value, this.CB_Fornecedor.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                                }
                                else
                                {
                                    resp = NContas_Pagar.Inserir_Credor_Nao_Cadastrado(this.DT_Data_Inicial.Value, this.TXB_Credor_Nao_Cadastrado.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
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

                                row["num_parcela"] = col0;
                                row["valor"] = col1;
                                row["vencimento"] = col2;
                                row["estado"] = "A VENCER";
                                row["obs"] = "";
                                row["idfornecedor"] = Convert.ToInt32(this.CB_Fornecedor.SelectedValue);
                                this.dtparc.Rows.Add(row);
                            }

                            if (this.CHK_Configuracao.Checked)
                            {
                                resp = NContas_Pagar.Inserir_Credor_Cadastrado(this.DT_Data_Inicial.Value, this.CB_Fornecedor.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
                            }
                            else
                            {
                                resp = NContas_Pagar.Inserir_Credor_Nao_Cadastrado(this.DT_Data_Inicial.Value, this.TXB_Credor_Nao_Cadastrado.Text, this.TXB_Num_Doc.Text, this.CB_Qtd_Parc.Text, Convert.ToDecimal(this.TXB_Valor_Total.Text), this.dtparc);
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

     
        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.DGV_Contas_Pagar.Columns[0].Visible = true;

                this.BTN_Ver_Origem.Enabled = true;

                this.Key = true;
                this.BTN_Quitar_Externamente.Enabled = true;
            }
            else
            {
                this.DGV_Contas_Pagar.Columns[0].Visible = false;

                this.BTN_Ver_Origem.Enabled = false;

                this.Key = false;
                this.BTN_Quitar_Externamente.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Contas_Pagar.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void BTN_Ver_Origem_Click(object sender, EventArgs e)
        {
            try
            {
                bool chave = false;
                string IdEntrada = "";

                foreach (DataGridViewRow row in DGV_Contas_Pagar.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        IdEntrada = row.Cells[2].Value.ToString();
                    }
                }
                if (chave && IdEntrada != "")
                {
                    FRM_Ver_Entrada_Origem_Contas_Pagar frm = FRM_Ver_Entrada_Origem_Contas_Pagar.GetInstancia();
                    frm.identrada = IdEntrada;
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

        private void BTN_Pesquisar_Credor_Click(object sender, EventArgs e)
        {
            this.Buscar_Pelo_Credor();
            this.TXB_Buscar.Text = string.Empty;
        }

        private void TXB_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BTN_Pesquisar_Credor.Enabled = true;
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

            if (this.BTN_Pesquisar_Credor.Enabled)
            {
                this.BTN_Pesquisar_Credor.Enabled = false;
            }
        }

        private void BTN_Pesquisa_Mista_Click(object sender, EventArgs e)
        {
            FRM_Pesquisa_Especifica_Contas_Pagar frm = FRM_Pesquisa_Especifica_Contas_Pagar.GetInstancia();
            frm.Show();
        }

        private void DGV_Contas_Pagar_SelectionChanged(object sender, EventArgs e)
        {
            this.label9.Text = "";
            this.label9.Visible = false;
        }

        
        private void DGV_Contas_Pagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Contas_Pagar.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)DGV_Contas_Pagar.Rows[e.RowIndex].Cells["Select"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void DGV_Contas_Pagar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToString(DGV_Contas_Pagar.CurrentRow.Cells[4].Value) != "")
            {
                // Tornar Visivel
                this.CB_Fornecedor.Visible = true;
                this.TXB_Credor_Nao_Cadastrado.Visible = false;

                decimal valor;
                this.TXB_Id.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["idcontas_pagar"].Value);
                this.TXB_Num_Doc.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["num_doc"].Value);
                this.CB_Fornecedor.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["fornecedor_nome"].Value);
                this.CB_Qtd_Parc.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["total_parcelas"].Value);

                valor = Convert.ToDecimal(this.DGV_Contas_Pagar.CurrentRow.Cells["valor_total"].Value);
                this.TXB_Valor_Total.Text = valor.ToString("C");

                this.MostrarDetalheParcelas();
            }
            else
            {
                decimal valor;

                // Tornar Visivel
                this.CB_Fornecedor.Visible = false;
                this.TXB_Credor_Nao_Cadastrado.Visible = true;

                this.TXB_Id.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["idcontas_pagar"].Value);
                this.TXB_Num_Doc.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["num_doc"].Value);
                this.TXB_Credor_Nao_Cadastrado.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["credor_nao_cadastrado"].Value);
                this.CB_Qtd_Parc.Text = Convert.ToString(this.DGV_Contas_Pagar.CurrentRow.Cells["total_parcelas"].Value);

                valor = Convert.ToDecimal(this.DGV_Contas_Pagar.CurrentRow.Cells["valor_total"].Value);
                this.TXB_Valor_Total.Text = valor.ToString("C");

                this.MostrarDetalheParcelas();
            }



            this.BTN_Novo.Enabled = false;
            this.BTN_Fechar.Enabled = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void DGV_Contas_Pagar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Capturando Dados
            string IdContas_Pagar = this.DGV_Contas_Pagar.CurrentRow.Cells[1].Value.ToString();
            this.TBL_Analise_Vencimento = NContas_Pagar.MostrarDetalhes(IdContas_Pagar);

            DateTime Data_Atual = DateTime.Now;

            // Analisar se há parcela vencida
            foreach (DataRow row in TBL_Analise_Vencimento.Rows)
            {
                if (row[5].ToString().Equals("VENCIDA"))
                {
                    this.label9.Visible = true;
                    this.label9.Text = "HÁ PARCELA(S) VENCIDA(S)";
                }
            }
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Contas_Pagar frm = FRM_Tipo_Relatorio_Contas_Pagar.GetInstancia();
            frm.Show();
        }

        private void BTN_Quitar_Externamente_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja quitar?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                if (this.Key)
                {
                    bool Trava = false;
                    decimal Valor = 0;
                    decimal VALOR_CONTA = 0;
                    string NUM_DOC = "";
                    string NOME_CREDOR = "";
                    string NOME_CREDOR_NAO_CADASTRADO = "";
                    int IDREGISTRO = 0;

                    foreach (DataGridViewRow Index in DGV_Contas_Pagar.Rows)
                    {
                        if (Convert.ToBoolean(Index.Cells[0].Value))
                        {
                            Trava = true;
                            Valor = Convert.ToDecimal(Index.Cells[7].Value);
                            VALOR_CONTA = Convert.ToDecimal(Index.Cells[7].Value);
                            NUM_DOC = Index.Cells[6].Value.ToString();
                            NOME_CREDOR = Index.Cells[4].Value.ToString();
                            NOME_CREDOR_NAO_CADASTRADO = Index.Cells[5].Value.ToString();
                            IDREGISTRO = Convert.ToInt32(Index.Cells[1].Value);
                        }
                    }
                    if (Trava)
                    {
                        if (this.DGV_Contas_Pagar.CurrentRow.Cells[8].Value.ToString() != "1 X")
                        {
                            MensagemErro("Não é possível realizar esta operação, pois pode haver contas parcelas em mais de uma vez. Dê um clique duplo sobre a(s) conta(s) com mais de uma parcela para mais detalhes.");
                        }
                        else
                        {
                            // Obtendo valor recebido e restante
                            FRM_Pagar_Contas_Externo frm = FRM_Pagar_Contas_Externo.GetInstancia();
                            frm.Valor_Atualizado = Valor;
                            frm.Valor_Coanta = VALOR_CONTA;
                            frm.Num_Doc = NUM_DOC;
                            frm.Nome_Credor = NOME_CREDOR;
                            frm.Nome_Credor_Nao_Cadastrado = NOME_CREDOR_NAO_CADASTRADO;
                            frm.IdRegistro = IDREGISTRO;
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
                    foreach (DataGridViewRow row in DGV_Contas_Pagar.Rows)
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
                        FRM_Pagar_Contas_Externo frm = FRM_Pagar_Contas_Externo.GetInstancia();
                        frm.Valor_Atualizado = this.total_geral_debitos;
                        frm.Show();
                    }
                }
            }
        }

        private void BTN_Quitar_Internamente_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja quitar?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                if (this.Key_Interna)
                {
                    bool Trava = false;
                    decimal Valor = 0;
                    decimal VALOR_CONTA = 0;
                    string NUM_PARC = "";
                    int IDFORNECEDOR = 0;
                    int IDPARCELA = 0;

                    foreach (DataGridViewRow linha in DGV_Parcelas.Rows)
                    {
                        if (Convert.ToBoolean(linha.Cells[0].Value))
                        {
                            Trava = true;
                            Valor = Convert.ToDecimal(linha.Cells[4].Value);
                            VALOR_CONTA = Convert.ToDecimal(linha.Cells[4].Value);
                            NUM_PARC = linha.Cells[3].Value.ToString();
                            IDFORNECEDOR = Convert.ToInt32(linha.Cells[8].Value);
                            IDPARCELA = Convert.ToInt32(linha.Cells[1].Value);
                        }
                    }
                    if (Trava)
                    {
                        FRM_Pagar_Contas_Interno frm = FRM_Pagar_Contas_Interno.GetInstancia();
                        frm.Valor_Atualizado = Valor;
                        frm.Valor_Conta = VALOR_CONTA;
                        frm.Num_Parc = NUM_PARC;
                        frm.IdFornecedor = IDFORNECEDOR;
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
                    FRM_Pagar_Contas_Interno frm = FRM_Pagar_Contas_Interno.GetInstancia();
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
                    this.BTN_Quitar_Internamente.Enabled = true;
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
                this.BTN_Quitar_Internamente.Enabled = false;

                foreach (DataGridViewRow _row in DGV_Parcelas.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
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
