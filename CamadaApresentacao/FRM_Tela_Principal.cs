using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.IO;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FRM_Tela_Principal : Form
    {
        // METODO DATA ATUAL
        private DateTime Data_Atual;
        
        // VERICAR CONEXAO COM A INTERNET
        private bool Status_Geral_Rede;


         [DllImport("wininet.dll")]
        private extern static Boolean InternetGetConnectedState(out int Description, int ReservedValue);
        
        private void Verificar_Conexao()
        {
            // TESSTE DE CONEXÃO
             int Description;
             this.Status_Geral_Rede = InternetGetConnectedState(out Description, 0);
        }

        private void Data_Certa()
        {
            // Verificar conexão para decidir melhor origem da data atual
            this.Verificar_Conexao();

            // Decidindo fonte para data atual
            if (this.Status_Geral_Rede)
            {
                this.Data_Atual = DateTime.Now;  // Data da Internet
                DateTime Data_PC = DateTime.Now;  // Data do Computador

                // Verificar se a data do computador esta correta
                if (this.Data_Atual.ToString("dd/MM/yyyy") != Data_PC.ToString("dd/MM/yyyy"))
                {
                    MessageBox.Show("A data deste computador está incorreta. Recomendamos o ajuste da mesma.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Data do Computador
                this.Data_Atual = DateTime.Now;
            }
        }


        private DataTable TBL_Info_Detalhe_Contas_receber;
        private DataTable TBL_Info_Detalhe_Contas_Pagar;
        private DataTable TBL_Info_Config_Cartao_Credito;
        private DataTable TBL_Dados_Cartao_Credito_Compensar;
        private DataTable TBL_Status_Config_Cartao_Credito;
        private DataTable TBL_Dados_Cartao_Debito_Compensar;
        private DataTable TBL_Status_Config_Cartao_Debito;
        private DataTable TBL_Gestao_Usuario;

        // Variaveis Metodo Autenticação
        private DataTable TBL_Status_Licenca;
        private DataTable TBL_Dados_Autenticacao;
        private bool Chave_Autenticacao = true;
        private bool Bloquear = false;
        private bool Atualizar = false;
        private bool Encerrar_Contrato = false;

        // Variaveis Compensacao Automatica de Cartao de Credito
        private decimal Valor_Compensar_Cartao_Credito = 0;
        private string Num_Documento = "";

        // Variaveis Compensacao Automatica de Cartao de Debito
        private decimal Valor_Compensar_Cartao_Debito = 0;
        private string Num_Doc_Compensacao_cartao_debito = "";

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tela_Principal _Instancia;

        public static FRM_Tela_Principal GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tela_Principal();
            }
            return _Instancia;
        }


        // DATA E HORA ATUAL DA INTERNET
        public static DateTime GetNetworkTime()
        {
            //Servidor nacional para melhor latência
            const string ntpServer = "a.ntp.br";

            // Tamanho da mensagem NTP - 16 bytes (RFC 2030)
            var ntpData = new byte[48];

            //Indicador de Leap (ver RFC), Versão e Modo
            ntpData[0] = 0x1B; //LI = 0 (sem warnings), VN = 3 (IPv4 apenas), Mode = 3 (modo cliente)

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;

            //123 é a porta padrão do NTP
            var ipEndPoint = new IPEndPoint(addresses[0], 123);
            //NTP usa UDP
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            socket.Connect(ipEndPoint);

            //Caso NTP esteja bloqueado, ao menos nao trava o app
            socket.ReceiveTimeout = 3000;

            socket.Send(ntpData);
            socket.Receive(ntpData);
            socket.Close();

            //Offset para chegar no campo "Transmit Timestamp" (que é
            //o do momento da saída do servidor, em formato 64-bit timestamp
            const byte serverReplyTime = 40;

            //Pegando os segundos
            ulong intPart = BitConverter.ToUInt32(ntpData, serverReplyTime);

            //e a fração de segundos
            ulong fractPart = BitConverter.ToUInt32(ntpData, serverReplyTime + 4);

            //Passando de big-endian pra little-endian
            intPart = SwapEndianness(intPart);
            fractPart = SwapEndianness(fractPart);

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);

            //Tempo em **UTC**
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }

        // stackoverflow.com/a/3294698/162671
        static uint SwapEndianness(ulong x)
        {
            return (uint)(((x & 0x000000ff) << 24) +
                           ((x & 0x0000ff00) << 8) +
                           ((x & 0x00ff0000) >> 8) +
                           ((x & 0xff000000) >> 24));
        }



        // Variavel para receber dados do livro caixa
        private DataTable DT_Livro_Caixa;

        // Numeração automática para lançar crédito no caixa para 1º uso
        private DataTable DT_Num_Auto_LC;
        public int Auxiliar_NA_Credito;    //Variavel Auxiliar Crédito

        private void Numeracao_Automatica()
        {
            this.DT_Num_Auto_LC = NNumeracao_Auto.Mostrar_Num_Auto_Livro_Caixa();
            this.Auxiliar_NA_Credito = Convert.ToInt32(this.DT_Num_Auto_LC.Rows[0][3]);
        }

        private void Atualizacao_Apos_Deletar_Entrada()
        {
            DataTable Info_Produtos = NProduto.Quant_Atual_Abaixo_Zero();
            DataTable Info_Vendas = NVenda.Vendas_Quant_Atual_Abaixo_Zero();

            if (Info_Produtos.Rows.Count > 0)
            {
                string resp = "";
                int IdUltima_Venda = Convert.ToInt32(Info_Vendas.Rows[0][0]);
                resp = NVenda.Excluir(IdUltima_Venda);
            }
        }


        private void Atualizar_Detalhe_Contas_Receber()
        {
            string resp = "";
            DateTime data_atual = DateTime.Now;
            this.TBL_Info_Detalhe_Contas_receber = NContas_Receber.Buscar_Parcelas_Vencidas(data_atual.ToString("dd/MM/yyyy"));

            bool chave = true;
            foreach (DataRow row in TBL_Info_Detalhe_Contas_receber.Rows)
            {
                if (row[6].ToString() == "VENCIDA")
                {
                    chave = false;
                }
            }

            if (chave && this.TBL_Info_Detalhe_Contas_receber.Rows.Count > 0)
            {
                for (int i = 0; i <= this.TBL_Info_Detalhe_Contas_receber.Rows.Count - 1; i++)
                {
                    int id = Convert.ToInt32(this.TBL_Info_Detalhe_Contas_receber.Rows[i][0]);

                    resp = NContas_Receber.Atualizar_Status_Parcelas(id);
                }

                
                DialogResult Opcao;
                Opcao = MessageBox.Show("Foram detectadas contas a receber vencidas. Deseja ver um relatório com todos os detalhes?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcao == DialogResult.Yes)
                {
                    FRM_Contas_Receber_Vencidas frm = FRM_Contas_Receber_Vencidas.GetInstancia();
                    frm.ShowDialog();
                }
            }
        }


        // Calcular Proximo dia util
        private int DIAS_ATRASO = 0;
        private int diaUtil(DateTime vencimento, int dias_atraso)
        {
            this.DIAS_ATRASO = dias_atraso;

            if (vencimento.DayOfWeek == DayOfWeek.Sunday)
            {
                this.DIAS_ATRASO--;
                return DIAS_ATRASO;
            }
            else if (Feriado(vencimento) == true)
            {
                this.DIAS_ATRASO--;
                return DIAS_ATRASO;
            }
            return DIAS_ATRASO;
        }

        public bool Feriado(DateTime data)
        {
            DataTable TBL_Dados_Feriados = NFeriado.Buscar_Feriado(data.ToString("dd/MM/yyyy"));

            if (TBL_Dados_Feriados.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // CONTAS A RECEBER - Calculando juros de parcelas vencidas
        private decimal Valor_Atualizado = 0;
        private void Calcular_Juros_Atraso(decimal VALOR_ORIGINAL, string VENCIMENTO)
        {
            // Obtendo dados da configuração de juros de atraso
            DataTable TBL_Dados_Juros_Atraso = NConfig_Juros_Atraso.Mostrar();
            decimal Taxa_Juros_Diario = Convert.ToDecimal(TBL_Dados_Juros_Atraso.Rows[0][1]);
            decimal Multa = Convert.ToDecimal(TBL_Dados_Juros_Atraso.Rows[0][2]);
            string Status = TBL_Dados_Juros_Atraso.Rows[0][3].ToString();
            string Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");

            if (Status.Equals("SIM"))
            {
                // Calculando tempo de atraso
                TimeSpan Calculo = Convert.ToDateTime(Data_Atual) - Convert.ToDateTime(VENCIMENTO);
                int Atraso = Calculo.Days;
                
                int Atraso_Total = this.diaUtil(Convert.ToDateTime(VENCIMENTO), Atraso);

                // Calculando valor dos juros
                decimal Valor_Juros = (VALOR_ORIGINAL * Taxa_Juros_Diario / 100);
                decimal Total_Juros = Valor_Juros * Atraso_Total;

                // Calculando valor da multa
                decimal Valor_Multa = (VALOR_ORIGINAL * Multa / 100);

                // Calculando valor atualizado
                this.Valor_Atualizado = VALOR_ORIGINAL + Total_Juros + Valor_Multa;
            }
        }


        private DataTable TBL_Contas_Receber_Registros_Atualizados;
        private void CriarTabela_Registros_Alterados()
        {
            this.TBL_Contas_Receber_Registros_Atualizados = new DataTable("Alterados");
            this.TBL_Contas_Receber_Registros_Atualizados.Columns.Add("idregistro", System.Type.GetType("System.Int32"));
        }
        
        // Atualizar Valor Total Contas a Receber apos atualizar valor das parcelas
        private decimal Valor_Total_Atualizado_Contas_Receber = 0;
        private void Atualizar_Valor_Total_Contas_Receber()
        {
            string resp = "";
            int IDContas_Receber = 0;
            
            for (int i = 0; i <= TBL_Contas_Receber_Registros_Atualizados.Rows.Count - 1; i++)
            {
                IDContas_Receber = Convert.ToInt32(TBL_Contas_Receber_Registros_Atualizados.Rows[i][0]);
                DataTable TBL_Parcelas = NContas_Receber.MostrarDetalhes(IDContas_Receber.ToString());

                for (int w = 0; w <= TBL_Parcelas.Rows.Count - 1; w++)
                {
                    this.Valor_Total_Atualizado_Contas_Receber += Convert.ToDecimal(TBL_Parcelas.Rows[w][8]);
                }
                resp = NContas_Receber.Atualizar_Valor_Total_Contas_Receber(IDContas_Receber, this.Valor_Total_Atualizado_Contas_Receber);
                this.Valor_Total_Atualizado_Contas_Receber = 0;
            }
        }

        
        // CONTAS A RECEBER - Atualizar valor parcelas vencidas
        private void Atualizar_Valor_Parcelas_Vencidas()
        {
            string resp = "";
            DateTime data_atual = DateTime.Now;
            DataTable TBL_Parcelas_Vencidas = NContas_Receber.Buscar_Parcelas_Vencidas(data_atual.ToString("dd/MM/yyyy"));

            if (TBL_Parcelas_Vencidas.Rows.Count > 0)
            {
                int IdParcela = 0;
                int IdRegistro_Pai = 0;
                decimal Valor_Original = 0;
                string Vencimento = "";

                // Obtendo dados da configuração de juros de atraso
                DataTable TBL_Dados_Juros_Atraso = NConfig_Juros_Atraso.Mostrar();
                string Status = TBL_Dados_Juros_Atraso.Rows[0][3].ToString();

                if (Status.Equals("SIM"))
                {
                    this.CriarTabela_Registros_Alterados();

                    for (int i = 0; i <= TBL_Parcelas_Vencidas.Rows.Count - 1; i++)
                    {
                        // Obtendo Dados
                        IdParcela = Convert.ToInt32(TBL_Parcelas_Vencidas.Rows[i][0]);
                        IdRegistro_Pai = Convert.ToInt32(TBL_Parcelas_Vencidas.Rows[i][1]);
                        Valor_Original = Convert.ToDecimal(TBL_Parcelas_Vencidas.Rows[i][4]);
                        Vencimento = TBL_Parcelas_Vencidas.Rows[i][5].ToString();

                        // Salvar temporariamente os IDs das contas a receber atualizados
                        bool trava = true;
                        foreach (DataRow R in this.TBL_Contas_Receber_Registros_Atualizados.Rows)
                        {
                            // Verificar se o registro já existe
                            if (R[0].ToString() == IdRegistro_Pai.ToString())
                            {
                                trava = false;
                            }
                        }
                        if (trava)
                        {
                            // Executar
                            DataRow linha = this.TBL_Contas_Receber_Registros_Atualizados.NewRow();
                            linha["idregistro"] = IdRegistro_Pai;
                            this.TBL_Contas_Receber_Registros_Atualizados.Rows.Add(linha);
                        }
                        
                        // Executando calculo de juros de atraso
                        this.Calcular_Juros_Atraso(Valor_Original, Vencimento);

                        // Atualizando parcelas vencidas
                        resp = NContas_Receber.Atualizar_Valor_Detalhe_Contas_Receber(IdParcela, this.Valor_Atualizado);
                    }
                    this.Atualizar_Valor_Total_Contas_Receber();
                }
            }
        }


        private void Atualizar_Detalhe_Contas_Pagar()
        {
            string resp = "";
            DateTime data_atual = DateTime.Now;
            this.TBL_Info_Detalhe_Contas_Pagar = NContas_Pagar.Buscar_Parcelas_Vencidas(data_atual.ToString("dd/MM/yyyy"));

            bool chave = true;
            foreach (DataRow row in TBL_Info_Detalhe_Contas_Pagar.Rows)
            {
                if (row[6].ToString() == "VENCIDA")
                {
                    chave = false;
                }
            }

            if (chave && this.TBL_Info_Detalhe_Contas_Pagar.Rows.Count > 0)
            {
                for (int i = 0; i <= this.TBL_Info_Detalhe_Contas_Pagar.Rows.Count - 1; i++)
                {
                    int id = Convert.ToInt32(this.TBL_Info_Detalhe_Contas_Pagar.Rows[i][0]);

                    resp = NContas_Pagar.Atualizar_Status_Parcelas(id);
                }
            }
        }


        private void Compensacao_Automatica_Cartao_Credito()
        {
            this.TBL_Status_Config_Cartao_Credito = NDetalhe_Config_Cartao_Credito.Mostrar();
            string Config_Atual = this.TBL_Status_Config_Cartao_Credito.Rows[0][1].ToString();
            if (Config_Atual == "SIM")
            {
                try
                {
                    // Obtendo Dados Necessarios
                    DateTime data_atual = DateTime.Now;
                    this.TBL_Dados_Cartao_Credito_Compensar = NCartao_Credito.Mostrar_Cartao_Credito_Compensar(data_atual.ToString("dd/MM/yyyy"));
                    this.TBL_Info_Config_Cartao_Credito = NConfig_Cartao_Credito.Mostrar();

                    // Executando Operação
                    if (this.TBL_Dados_Cartao_Credito_Compensar.Rows.Count > 0)
                    {
                        string resp_livro_Caixa = "";
                        for (int i = 0; i <= this.TBL_Dados_Cartao_Credito_Compensar.Rows.Count - 1; i++)
                        {
                            string resp = "";
                            // Capturando valor da compensação
                            this.Valor_Compensar_Cartao_Credito += Convert.ToDecimal(this.TBL_Dados_Cartao_Credito_Compensar.Rows[i][5]);
                            this.Num_Documento = this.Num_Documento + "V" + this.TBL_Dados_Cartao_Credito_Compensar.Rows[i][1].ToString() + " - P" + this.TBL_Dados_Cartao_Credito_Compensar.Rows[i][4].ToString() + ", ";

                            // Excluir contas compensadas
                            int id = Convert.ToInt32(this.TBL_Dados_Cartao_Credito_Compensar.Rows[i][0]);
                            resp = NCartao_Credito.Excluir(id);
                        }

                        // Inserir compensação no livro caixa
                        resp_livro_Caixa = NLivro_Caixa.Inserir(Convert.ToDateTime(Data_Atual), "COMPENSAÇÃO DE CARTÃO DE CRÉDITO", this.Num_Documento, Valor_Compensar_Cartao_Credito, Convert.ToDecimal("0,00"));

                        // Confirmando Processo Bem Sucedido
                        MessageBox.Show("Compensação automática de cartão de crédito efetuada com êxito.\nValores disponíveis no livro caixa", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Houve um erro na compensação automática de cartão de crédito.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Compensacao_Automatica_Cartao_Debito()
        {
            this.TBL_Status_Config_Cartao_Debito = NDetalhe_Config_Cartao_Debito.Mostrar();
            string Config_Atual = this.TBL_Status_Config_Cartao_Debito.Rows[0][1].ToString();
            if (Config_Atual == "SIM")
            {
                try
                {
                    // Obtendo Dados Necessarios
                    DateTime data_atual = DateTime.Now;
                    this.TBL_Dados_Cartao_Debito_Compensar = NCartao_Debito.Mostrar_Cartao_Debito_Compensar(data_atual.ToString("dd/MM/yyyy"));

                    // Executando Operação
                    if (this.TBL_Dados_Cartao_Debito_Compensar.Rows.Count > 0)
                    {
                        string resp_livro_Caixa = "";
                        for (int i = 0; i <= this.TBL_Dados_Cartao_Debito_Compensar.Rows.Count - 1; i++)
                        {
                            string resp = "";
                            // Capturando valor da compensação
                            this.Valor_Compensar_Cartao_Debito += Convert.ToDecimal(this.TBL_Dados_Cartao_Debito_Compensar.Rows[i][5]);
                            this.Num_Doc_Compensacao_cartao_debito = this.Num_Doc_Compensacao_cartao_debito + "V" + this.TBL_Dados_Cartao_Debito_Compensar.Rows[i][1].ToString() + ", ";

                            // Excluir contas compensadas
                            int id = Convert.ToInt32(this.TBL_Dados_Cartao_Debito_Compensar.Rows[i][0]);
                            resp = NCartao_Debito.Excluir(id);
                        }

                        // Inserir compensação no livro caixa
                        resp_livro_Caixa = NLivro_Caixa.Inserir(Convert.ToDateTime(Data_Atual), "COMPENSAÇÃO DE CARTÃO DE DEBITO", this.Num_Doc_Compensacao_cartao_debito, this.Valor_Compensar_Cartao_Debito, Convert.ToDecimal("0,00"));

                        // Confirmando Processo Bem Sucedido
                        MessageBox.Show("Compensação automática de cartão de debito efetuada com êxito.\nValores disponíveis no livro caixa", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception Erro)
                {
                    MessageBox.Show("Houve um erro na compensação automática de cartão de crédito.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Bloquear_Sistema()
        {
            if (this.Bloquear)
            {
                // Alerta de Bloqueio
                MessageBox.Show("                       >>>>> SISTEMA BLOQUEADO <<<<< \n\nPara mais informações ligue para WE Automação: (31) 98315 1472 | 98581 8801", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Bloquear
                this.BTN_Listagem_Vendas.Enabled = false;
                this.BTN_Listagem_Vendas.Visible = false;
                this.BTN_Backup.Enabled = false;
                this.BTN_Backup.Visible = false;
                this.BTN_Configuracoes.Enabled = false;
                this.BTN_Configuracoes.Visible = false;
                this.BTN_Licenciamento.Enabled = false;
                this.BTN_Licenciamento.Visible = false;
                this.BTN_Etiquetas.Enabled = false;
                this.BTN_Etiquetas.Visible = false;
                this.btnCaixa.Enabled = false;
                this.btnCaixa.Visible = false;
                this.BTN_Clientes.Enabled = false;
                this.BTN_Clientes.Visible = false;
                this.BTN_Estoque.Enabled = false;
                this.BTN_Estoque.Visible = false;
                this.BTN_Fornecedores.Enabled = false;
                this.BTN_Fornecedores.Visible = false;
                this.BTN_Funcionarios.Enabled = false;
                this.BTN_Funcionarios.Visible = false;
                this.BTN_Caixa.Enabled = false;
                this.BTN_Caixa.Visible = false;
                this.BTN_Contas_Receber.Enabled = false;
                this.BTN_Contas_Receber.Visible = false;
                this.btnContas_Pagar.Enabled = false;
                this.btnContas_Pagar.Visible = false;
                this.BTN_Outras_Financas.Enabled = false;
                this.BTN_Outras_Financas.Visible = false;
                this.BTN_OS.Enabled = false;
                this.BTN_OS.Visible = false;
                this.BTN_Pesquisar_Preco.Enabled = false;
                this.BTN_Pesquisar_Preco.Visible = false;
                this.BTN_Relatorio.Enabled = false;
                this.BTN_Relatorio.Visible = false;
                this.BTN_Orcamento.Enabled = false;
                this.BTN_Orcamento.Visible = false;
                this.BTN_Desbloquear.Enabled = true;
                this.BTN_Desbloquear.Visible = true;
            }
            else
            {
                // Liberar
                this.BTN_Listagem_Vendas.Enabled = true;
                this.BTN_Listagem_Vendas.Visible = true;
                this.BTN_Backup.Enabled = true;
                this.BTN_Backup.Visible = true;
                this.BTN_Configuracoes.Enabled = true;
                this.BTN_Configuracoes.Visible = true;
                this.BTN_Licenciamento.Enabled = true;
                this.BTN_Licenciamento.Visible = true;
                this.BTN_Etiquetas.Enabled = true;
                this.BTN_Etiquetas.Visible = true;
                this.btnCaixa.Enabled = true;
                this.btnCaixa.Visible = true;
                this.BTN_Clientes.Enabled = true;
                this.BTN_Clientes.Visible = true;
                this.BTN_Estoque.Enabled = true;
                this.BTN_Estoque.Visible = true;
                this.BTN_Fornecedores.Enabled = true;
                this.BTN_Fornecedores.Visible = true;
                this.BTN_Funcionarios.Enabled = true;
                this.BTN_Funcionarios.Visible = true;
                this.BTN_Caixa.Enabled = true;
                this.BTN_Caixa.Visible = true;
                this.BTN_Contas_Receber.Enabled = true;
                this.BTN_Contas_Receber.Visible = true; 
                this.btnContas_Pagar.Enabled = true;
                this.btnContas_Pagar.Visible = true;
                this.BTN_Outras_Financas.Enabled = true;
                this.BTN_Outras_Financas.Visible = true;
                this.BTN_OS.Enabled = true;
                this.BTN_OS.Visible = true;
                this.BTN_Pesquisar_Preco.Enabled = true;
                this.BTN_Pesquisar_Preco.Visible = true;
                this.BTN_Relatorio.Enabled = true;
                this.BTN_Relatorio.Visible = true;
                this.BTN_Orcamento.Enabled = true;
                this.BTN_Orcamento.Visible = true;
                this.BTN_Desbloquear.Enabled = false;
                this.BTN_Desbloquear.Visible = false;
            }
        }


        private void Bloquear_Sistema_Sem_Variavel()
        {
            // Bloquear
            this.BTN_Listagem_Vendas.Enabled = false;
            this.BTN_Listagem_Vendas.Visible = false;
            this.BTN_Backup.Enabled = false;
            this.BTN_Backup.Visible = false;
            this.BTN_Configuracoes.Enabled = false;
            this.BTN_Configuracoes.Visible = false;
            this.BTN_Licenciamento.Enabled = false;
            this.BTN_Licenciamento.Visible = false;
            this.BTN_Etiquetas.Enabled = false;
            this.BTN_Etiquetas.Visible = false;
            this.btnCaixa.Enabled = false;
            this.btnCaixa.Visible = false;
            this.BTN_Clientes.Enabled = false;
            this.BTN_Clientes.Visible = false;
            this.BTN_Estoque.Enabled = false;
            this.BTN_Estoque.Visible = false;
            this.BTN_Fornecedores.Enabled = false;
            this.BTN_Fornecedores.Visible = false;
            this.BTN_Funcionarios.Enabled = false;
            this.BTN_Funcionarios.Visible = false;
            this.BTN_Caixa.Enabled = false;
            this.BTN_Caixa.Visible = false;
            this.BTN_Contas_Receber.Enabled = false;
            this.BTN_Contas_Receber.Visible = false;
            this.btnContas_Pagar.Enabled = false;
            this.btnContas_Pagar.Visible = false;
            this.BTN_Outras_Financas.Enabled = false;
            this.BTN_Outras_Financas.Visible = false;
            this.BTN_OS.Enabled = false;
            this.BTN_OS.Visible = false;
            this.BTN_Pesquisar_Preco.Enabled = false;
            this.BTN_Pesquisar_Preco.Visible = false;
            this.BTN_Relatorio.Enabled = false;
            this.BTN_Relatorio.Visible = false;
            this.BTN_Orcamento.Enabled = false;
            this.BTN_Orcamento.Visible = false;
            this.BTN_Desbloquear.Enabled = false;
            this.BTN_Desbloquear.Visible = false;
        }


        private void Atualizar_Status_Licenca_Bloqueado()
        {
            if (Atualizar)
            {
                string resp = "";
                resp = NRemetente.Atualizar_Status_Licença_Bloqueado();
            }
        }


        private void Atualizar_Status_Licenca_Expirada()
        {
            string resp = "";
            resp = NRemetente.Atualizar_Status_Licença_Desativado(this.Data_Atual.ToString("dd/MM/yyyy"));
        }



        private void Autenticacao()
        {
            this.TBL_Status_Licenca = NRemetente.Mostrar();

            /*if (this.Status_Geral_Rede == false)
            {
                this.Bloquear_Sistema_Sem_Variavel();
                MessageBox.Show("Não há conexão com a internet. Conecte-se por favor.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }*/
            if (this.TBL_Status_Licenca.Rows[0][18].ToString().Equals("DESATIVADO"))
            {
                // Bloquear
                this.Bloquear_Sistema_Sem_Variavel();

                // Alerta de Bloqueio
                MessageBox.Show("                       >>>>> SUA LICENÇA EXPIROU. <<<<< \n\nContrate uma nova licença e continue aproveitando as facilidades deste software.\n\nWE System Evolution, um produto WE Automação.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.TBL_Status_Licenca.Rows[0][18].ToString().Equals("BLOQUEADO"))
            {
                this.Bloquear = true;
                this.Bloquear_Sistema();
            }
            else
            {
                this.TBL_Dados_Autenticacao = NAutenticacao.Mostrar_Autenticacao(this.Data_Atual.ToString("dd/MM/yyyy"));

                if (this.TBL_Dados_Autenticacao.Rows.Count > 0)
                {
                    foreach (DataRow row in TBL_Dados_Autenticacao.Rows)
                    {
                        string resp = "";

                        // MENSALIDADE 1
                        if (row[1].ToString().Equals("1"))
                        {
                            if (row[3].ToString().Equals("DR70N3HVJ62GCMU"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                               
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 2
                        if (row[1].ToString().Equals("2"))
                        {
                            if (row[3].ToString().Equals("5XL1FTH9BP40E8A"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                               
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 3
                        if (row[1].ToString().Equals("3"))
                        {
                            if (row[3].ToString().Equals("F6T9NB2PJXE8MAI"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 4
                        if (row[1].ToString().Equals("4"))
                        {
                            if (row[3].ToString().Equals("P4IXLET8A2KS1OW"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                               
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 5
                        if (row[1].ToString().Equals("5"))
                        {
                            if (row[3].ToString().Equals("QE5SM1H9WPDL8V4"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 6
                        if (row[1].ToString().Equals("6"))
                        {
                            if (row[3].ToString().Equals("1O3HWKDS7JR0NV2"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 7
                        if (row[1].ToString().Equals("7"))
                        {
                            if (row[3].ToString().Equals("CRF6N2VJXEMUIQ5"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 8
                        if (row[1].ToString().Equals("8"))
                        {
                            if (row[3].ToString().Equals("GVC4R6K0MU3QY9B"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 9
                        if (row[1].ToString().Equals("9"))
                        {
                            if (row[3].ToString().Equals("9B2P4JXLET8AIKS"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                               
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 10
                        if (row[1].ToString().Equals("10"))
                        {
                            if (row[3].ToString().Equals("TH8AP4XL0EGOWKS"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 11
                        if (row[1].ToString().Equals("11"))
                        {
                            if (row[3].ToString().Equals("RF6N2VJXCEMUIQ1"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }


                        // MENSALIDADE 12
                        if (row[1].ToString().Equals("12"))
                        {
                            if (row[3].ToString().Equals("MA1I9WQE5SDLHP4"))
                            {
                                // Desbloquar
                                this.Bloquear = false;

                                // Atualizar status da licença
                                this.Atualizar = false;

                                // Excluir mensalidade autenticada
                                int id = Convert.ToInt32(row[0]);
                                resp = NAutenticacao.Excluir(id);
                            }
                            else
                            {
                                
                                // Bloquear
                                this.Bloquear = true;

                                // Atualizar status da licença
                                this.Atualizar = true;
                            }
                        }
                    }
                    this.Bloquear_Sistema();
                    this.Atualizar_Status_Licenca_Bloqueado();
                }
            }
        }


        //Codificação de Niveis/Restrição de acesso.  Parte 1
        public int idfuncionario;
        public string Nome = "";
        public string Sobrenome = "";
        public string IdNivel_Acesso = "";
        public string Nivel_Acesso = "";


        //Codificação de Niveis/Restrição de acesso.  Parte 3
        private void GestaoUsuario()
        {
            // Instanciando
            FRM_Caixa caixa = FRM_Caixa.GetInstancia();
            FRM_Contas_Receber contas_receber = FRM_Contas_Receber.GetInstancia();

            // Obtendo dados
            this.TBL_Gestao_Usuario = NNivel_Acesso.Mostrar_Pelo_ID(IdNivel_Acesso);

            // Declarando variaveis
            bool btn_listagem_vendas = false, btn_backup = false, btn_configuracoes = false, btn_licenciamento = false, btn_desbloquear = false, btn_caixa = false, btn_clientes = false, btn_estoque = false, btn_fornecedores = false, btn_funcionarios = false, btn_livro_caixa = false, btn_contas_receber = false, btn_contas_pagar = false, btn_outras_financas = false, btn_os = false, btn_relatorios = false;

            // Repassando Parametros
            // PERMISSÕES PRINCIPAIS
            if (this.TBL_Gestao_Usuario.Rows[0][2].ToString().Equals("SIM"))
            {
                btn_listagem_vendas = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][3].ToString().Equals("SIM"))
            {
                btn_backup = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][4].ToString().Equals("SIM"))
            {
                btn_configuracoes = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][5].ToString().Equals("SIM"))
            {
                btn_licenciamento = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][6].ToString().Equals("SIM"))
            {
                btn_desbloquear = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][7].ToString().Equals("SIM"))
            {
                btn_caixa = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][8].ToString().Equals("SIM"))
            {
                btn_clientes = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][9].ToString().Equals("SIM"))
            {
                btn_estoque = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][10].ToString().Equals("SIM"))
            {
                btn_fornecedores = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][11].ToString().Equals("SIM"))
            {
                btn_funcionarios = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][12].ToString().Equals("SIM"))
            {
                btn_livro_caixa = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][13].ToString().Equals("SIM"))
            {
                btn_contas_receber = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][14].ToString().Equals("SIM"))
            {
                btn_contas_pagar = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][15].ToString().Equals("SIM"))
            {
                btn_outras_financas = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][16].ToString().Equals("SIM"))
            {
                btn_os = true;
            }
            if (this.TBL_Gestao_Usuario.Rows[0][17].ToString().Equals("SIM"))
            {
                btn_relatorios = true;
            }

            // OUTRAS PERMISSÕES
            if (this.TBL_Gestao_Usuario.Rows[0][18].ToString().Equals("SIM"))
            {
                caixa.PERMISSAO_DELETAR_ITEM_LISTA = "SIM";
            }
            if (this.TBL_Gestao_Usuario.Rows[0][19].ToString().Equals("SIM"))
            {
                contas_receber.PERMISSAO_DELETAR_CONTA_RECEBER = "SIM";
            }
            if (this.TBL_Gestao_Usuario.Rows[0][20].ToString().Equals("SIM"))
            {
                contas_receber.PERMISSAO_INSERIR_CONTA_RECEBER = "SIM";
            }


            // Execuando controle de acesso conforme configuração
            //TELA PRINCIPAL
            this.BTN_Listagem_Vendas.Enabled = btn_listagem_vendas;
            this.BTN_Backup.Enabled = btn_backup;
            this.BTN_Configuracoes.Enabled = btn_configuracoes;
            this.BTN_Licenciamento.Enabled = btn_licenciamento;
            this.BTN_Desbloquear.Enabled = btn_desbloquear;
            this.btnCaixa.Enabled = btn_caixa;
            this.BTN_Clientes.Enabled = btn_clientes;
            this.BTN_Estoque.Enabled = btn_estoque;
            this.BTN_Fornecedores.Enabled = btn_fornecedores;
            this.BTN_Funcionarios.Enabled = btn_funcionarios;
            this.BTN_Caixa.Enabled = btn_livro_caixa;
            this.BTN_Contas_Receber.Enabled = btn_contas_receber;
            this.btnContas_Pagar.Enabled = btn_contas_pagar;
            this.BTN_Outras_Financas.Enabled = btn_outras_financas;
            this.BTN_OS.Enabled = btn_os;
            this.BTN_Relatorio.Enabled = btn_relatorios;

            // CAIXA
            caixa.BTN_Contas_Receber.Enabled = btn_contas_receber;
            caixa.btnContas_Pagar.Enabled = btn_contas_pagar;
        }


        // METODO DE BACKUP AUTOMATICO
        private DataTable TBL_Config_Backup;
        private string Local_Seguro;
        private void Backup_Automatico()
        {
            this.TBL_Config_Backup = NInfo_Config_Backup.Mostrar();
            string ComputerName = SystemInformation.ComputerName;
            string Data_Ultimo_Backup = this.TBL_Config_Backup.Rows[0][2].ToString();
            int Intervalo = Convert.ToInt32(this.TBL_Config_Backup.Rows[0][3]);
            this.Local_Seguro = this.TBL_Config_Backup.Rows[0][1].ToString();
            string Backup_Automatico = this.TBL_Config_Backup.Rows[0][5].ToString();
            string resp = "";

            DateTime Data_atual = DateTime.Now;
            DateTime Data_Proximo_Backup = Data_atual.AddDays(Intervalo);

            if (Backup_Automatico == "SIM" && ComputerName == "SERVIDOR")
            {
                if (Data_Ultimo_Backup == "")
                {
                                                      // EXECUTANDO BACKUP
                    //Executando backup de banco de dados
                    var server = new Microsoft.SqlServer.Management.Smo.Server("SERVIDOR\\SQLEXPRESS");
                    var backup = new Microsoft.SqlServer.Management.Smo.Backup();
                    backup.Database = "DB_WE";
                    backup.Incremental = false;
                    string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmm}.bak", "DB_WE", DateTime.Now);
                    backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
                    backup.SqlBackup(server);

                    // Copiar Backup para local seguro expecificado na configuração de backup
                    File.Copy("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup, this.Local_Seguro + "\\" + nomeArquivoBackup, true);

                    // Deletar arquivo da pasta padrão de bkp do SQL
                    File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup);

                    // INSERINDO DATAS DO PRIMEIRO BACKUP AUTOMATICO
                    resp = NInfo_Config_Backup.Editar_Automatico(Data_atual, Data_Proximo_Backup);

                    // Mensagens de finalização
                    MessageBox.Show("Backup automático efetuado com sucesso.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DateTime Proximo_Backup = Convert.ToDateTime(this.TBL_Config_Backup.Rows[0][4]);
                    if (Convert.ToDateTime(Proximo_Backup.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(Data_atual.ToString("dd/MM/yyyy")))
                    {
                                                       // EXECUTANDO BACKUP
                        //Executando backup de banco de dados
                        var server = new Microsoft.SqlServer.Management.Smo.Server("SERVIDOR\\SQLEXPRESS");
                        var backup = new Microsoft.SqlServer.Management.Smo.Backup();
                        backup.Database = "DB_WE";
                        backup.Incremental = false;
                        string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmm}.bak", "DB_WE", DateTime.Now);
                        backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
                        backup.SqlBackup(server);

                        // Copiar Backup para local seguro expecificado na configuração de backup
                        File.Copy("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup, this.Local_Seguro + "\\" + nomeArquivoBackup, true);

                        // Deletar arquivo da pasta padrão de bkp do SQL
                        File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup);
                        
                                             // INSERINDO DATAS DO PRIMEIRO BACKUP AUTOMATICO
                        resp = NInfo_Config_Backup.Editar_Automatico(Data_atual, Data_Proximo_Backup);

                        // Mensagens de finalização
                        MessageBox.Show("Backup automático efetuado com sucesso.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



        // METODO ATUALIZAR BASE DE DADOS DE FERIADOS
        private DataTable TBL_Feriados;
        private DataTable TBL_Detalhe_feriado;
        private void Atualizar_Dados_Feriados()
        {
            this.TBL_Feriados = NFeriado.Mostrar_Feriado();

            this.TBL_Detalhe_feriado = NFeriado.Mostrar_Detalhe_Feriado();
            DateTime Data_atualizacao_Dados = Convert.ToDateTime(this.TBL_Detalhe_feriado.Rows[0][1]);

            DateTime Data_Atual = DateTime.Now;
            string resp = "";

            if (Convert.ToDateTime(Data_atualizacao_Dados.ToString("dd/MM/yyyy")) <= Convert.ToDateTime(Data_Atual.ToString("dd/MM/yyyy")))
            {
                // Atualizando data de atualização dos dados
                DateTime Nova_Data_atualizacao_Dados = Data_atualizacao_Dados.AddYears(1);
                resp = NFeriado.Atualizar_Detalhe_Feriado(Nova_Data_atualizacao_Dados);

                // Atualizando feriados
                for (int i = 0; i <= TBL_Feriados.Rows.Count - 1; i++)
                {
                    // Obtendo dados
                    int idferiado = Convert.ToInt32(TBL_Feriados.Rows[i][0]);
                    DateTime feriado = Convert.ToDateTime(TBL_Feriados.Rows[i][1]);
                    DateTime feriado_atualizado = feriado.AddYears(1);

                    // Executando atualização
                    resp = NFeriado.Atualizar_Base_Dados(idferiado, feriado_atualizado);
                }

                if (resp.Equals("Ok"))
                {
                    MessageBox.Show("Atualização de feriados concluida com sucesso.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(resp);
                }
            }
        }


        private void Inicio_Livro_Caixa()
        {
            this.DT_Livro_Caixa = NLivro_Caixa.Mostrar();
        }

        public FRM_Tela_Principal()
        {
            InitializeComponent();
        }

        private void FRM_Tela_Principal_Load(object sender, EventArgs e)
        {
            this.Data_Certa();
            this.GestaoUsuario();
            this.Atualizar_Status_Licenca_Expirada();
            this.Autenticacao();

            this.Atualizar_Valor_Parcelas_Vencidas();
            this.Atualizar_Detalhe_Contas_Receber();
            this.Atualizar_Detalhe_Contas_Pagar();
            this.Compensacao_Automatica_Cartao_Credito();
            this.Compensacao_Automatica_Cartao_Debito();
            this.Atualizar_Dados_Feriados();

            LB_Nome.Text = Nome + " " + Sobrenome;
            LB_Acesso.Text = Nivel_Acesso;
           
            this.Inicio_Livro_Caixa();
            if (this.DT_Livro_Caixa.Rows.Count == 0 && this.Chave_Autenticacao)
            {
                FRM_Lancar_Credito_Primeiro_Uso frm = FRM_Lancar_Credito_Primeiro_Uso.GetInstancia();
                frm.eNovo = true;
                this.Numeracao_Automatica();

                string Config_Num_Auto = this.DT_Num_Auto_LC.Rows[0][5].ToString();

                if (Config_Num_Auto == "SIM")
                {
                    //Incrementando para gerar novo número de venda
                    Auxiliar_NA_Credito++;

                    //passado novo numero de venda para o TextBox
                    frm.TXB_Num_Doc.Text = "CRED" + Convert.ToString(Auxiliar_NA_Credito);
                }
                
                frm.ShowDialog();
            }
        }

        private void BTN_Estoque_Click(object sender, EventArgs e)
        {

            FRM_Produto frm = FRM_Produto.GetInstancia();
            frm.idfuncionario = this.idfuncionario;
            frm.Show();
        }

        private void BTN_Fornecedores_Click(object sender, EventArgs e)
        {
            FRM_Fornecedor frm = FRM_Fornecedor.GetInstancia();
            frm.Show();
        }

        private void BTN_Funcionarios_Click(object sender, EventArgs e)
        {
           FRM_Funcionario frm = FRM_Funcionario.GetInstancia();
            frm.Show();
        }
        

        private void BTN_Clientes_Click(object sender, EventArgs e)
        {
            FRM_Cliente frm = FRM_Cliente.GetInstancia();
            frm.Show();
        }

        private void btnNova_Venda_Click(object sender, EventArgs e)
        {
            FRM_Venda frm = FRM_Venda.GetInstancia();
            frm.Show();
        }

        private void BTN_Caixa_Click(object sender, EventArgs e)
        {
            FRM_Livro_Caixa frm = FRM_Livro_Caixa.GetInstancia();
            frm.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();
            frm.idfuncionario = this.idfuncionario;
            frm.Nome_Funcionario = this.Nome + " " + this.Sobrenome;
            frm.Show();
        }
        
        private void BTN_Contas_Receber_Click(object sender, EventArgs e)
        {
            FRM_Contas_Receber frm = FRM_Contas_Receber.GetInstancia();
            frm.Show();
        }
        
        private void btnContas_Pagar_Click(object sender, EventArgs e)
        {
            FRM_Contas_Pagar frm = FRM_Contas_Pagar.GetInstancia();
            frm.Show();
        }
        
        private void BTN_Relatorio_Click(object sender, EventArgs e)
        {
            FRM_Assistente_Relatorios frm = FRM_Assistente_Relatorios.GetInstancia();
            frm.Show();
        }

        private void FRM_Tela_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Backup_Automatico();
        }

        private void BTN_OS_Click(object sender, EventArgs e)
        {
            FRM_OS frm = FRM_OS.GetInstancia();
            frm.Show();
        }
        
        private void Time_Atualizacao_Apos_Deletar_Entrada_Tick(object sender, EventArgs e)
        {
            this.Atualizacao_Apos_Deletar_Entrada();

            // Instanciando
            FRM_Caixa caixa = FRM_Caixa.GetInstancia();
            FRM_Contas_Receber contas_receber = FRM_Contas_Receber.GetInstancia();

            // Obtendo dados
            DataTable TBL_Dados_Nivel_Acesso = new DataTable();
            TBL_Dados_Nivel_Acesso = NNivel_Acesso.Mostrar_Pelo_ID(this.IdNivel_Acesso);

            if (TBL_Dados_Nivel_Acesso.Rows.Count > 0)
            {
                // Declarando variaveis
                bool btn_listagem_vendas = false, btn_backup = false, btn_configuracoes = false, btn_licenciamento = false, btn_desbloquear = false, btn_caixa = false, btn_clientes = false, btn_estoque = false, btn_fornecedores = false, btn_funcionarios = false, btn_livro_caixa = false, btn_contas_receber = false, btn_contas_pagar = false, btn_outras_financas = false, btn_os = false, btn_relatorios = false;

                // Repassando Parametros
                // PERMISSÕES PRINCIPAIS
                if (TBL_Dados_Nivel_Acesso.Rows[0][2].ToString().Equals("SIM"))
                {
                    btn_listagem_vendas = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][3].ToString().Equals("SIM"))
                {
                    btn_backup = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][4].ToString().Equals("SIM"))
                {
                    btn_configuracoes = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][5].ToString().Equals("SIM"))
                {
                    btn_licenciamento = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][6].ToString().Equals("SIM"))
                {
                    btn_desbloquear = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][7].ToString().Equals("SIM"))
                {
                    btn_caixa = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][8].ToString().Equals("SIM"))
                {
                    btn_clientes = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][9].ToString().Equals("SIM"))
                {
                    btn_estoque = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][10].ToString().Equals("SIM"))
                {
                    btn_fornecedores = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][11].ToString().Equals("SIM"))
                {
                    btn_funcionarios = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][12].ToString().Equals("SIM"))
                {
                    btn_livro_caixa = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][13].ToString().Equals("SIM"))
                {
                    btn_contas_receber = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][14].ToString().Equals("SIM"))
                {
                    btn_contas_pagar = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][15].ToString().Equals("SIM"))
                {
                    btn_outras_financas = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][16].ToString().Equals("SIM"))
                {
                    btn_os = true;
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][17].ToString().Equals("SIM"))
                {
                    btn_relatorios = true;
                }

                // OUTRAS PERMISSÕES
                if (TBL_Dados_Nivel_Acesso.Rows[0][18].ToString().Equals("SIM"))
                {
                    caixa.PERMISSAO_DELETAR_ITEM_LISTA = "SIM";
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][19].ToString().Equals("SIM"))
                {
                    contas_receber.PERMISSAO_DELETAR_CONTA_RECEBER = "SIM";
                }
                if (TBL_Dados_Nivel_Acesso.Rows[0][20].ToString().Equals("SIM"))
                {
                    contas_receber.PERMISSAO_INSERIR_CONTA_RECEBER = "SIM";
                }


                // Execuando controle de acesso conforme configuração
                //TELA PRINCIPAL
                this.BTN_Listagem_Vendas.Enabled = btn_listagem_vendas;
                this.BTN_Backup.Enabled = btn_backup;
                this.BTN_Configuracoes.Enabled = btn_configuracoes;
                this.BTN_Licenciamento.Enabled = btn_licenciamento;
                this.BTN_Desbloquear.Enabled = btn_desbloquear;
                this.btnCaixa.Enabled = btn_caixa;
                this.BTN_Clientes.Enabled = btn_clientes;
                this.BTN_Estoque.Enabled = btn_estoque;
                this.BTN_Fornecedores.Enabled = btn_fornecedores;
                this.BTN_Funcionarios.Enabled = btn_funcionarios;
                this.BTN_Caixa.Enabled = btn_livro_caixa;
                this.BTN_Contas_Receber.Enabled = btn_contas_receber;
                this.btnContas_Pagar.Enabled = btn_contas_pagar;
                this.BTN_Outras_Financas.Enabled = btn_outras_financas;
                this.BTN_OS.Enabled = btn_os;
                this.BTN_Relatorio.Enabled = btn_relatorios;

                // CAIXA
                caixa.BTN_Contas_Receber.Enabled = btn_contas_receber;
                caixa.btnContas_Pagar.Enabled = btn_contas_pagar;
            }
        }

        private void BTN_Outras_Financas_Click(object sender, EventArgs e)
        {
            FRM_Selecionar_Controle_Financas frm = FRM_Selecionar_Controle_Financas.GetInstancia();
            frm.Show();
        }

        private void BTN_Listagem_Vendas_Click(object sender, EventArgs e)
        {
            FRM_Venda frm = FRM_Venda.GetInstancia();
            frm.Show();
        }

        private void BTN_Backup_Click(object sender, EventArgs e)
        {
            FRM_Backup_Restauracao_DB frm = FRM_Backup_Restauracao_DB.GetInstancia();
            frm.ShowDialog();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_Configuracoes_Click(object sender, EventArgs e)
        {
            FRM_Selecionar_Configuracoes frm = FRM_Selecionar_Configuracoes.GetInstancia();
            frm.ShowDialog();
        }

        private void BTN_Desbloquear_Click(object sender, EventArgs e)
        {
            FRM_Desbloquear_Sistema frm = FRM_Desbloquear_Sistema.GetInstancia();
            frm.data_atual = this.Data_Atual;
            frm.ShowDialog();
        }

        private void BTN_Licenciamento_Click(object sender, EventArgs e)
        {
            FRM_Licenciamento frm = FRM_Licenciamento.GetInstancia();
            frm.ShowDialog();
        }

        private void BTN_Pesquisar_Preco_Click(object sender, EventArgs e)
        {
            FRM_Pesquisar_Preco frm = FRM_Pesquisar_Preco.GetInstancia();
            frm.Show();
        }

        private void BTN_Etiquetas_Click(object sender, EventArgs e)
        {
            FRM_Etiquetas frm = FRM_Etiquetas.GetInstancia();
            frm.Show();
        }

        private void BTN_Orcamento_Click(object sender, EventArgs e)
        {
            FRM_Orcamento frm = FRM_Orcamento.GetInstancia();
            frm.IdFuncionario = this.idfuncionario;
            frm.Show();
        }
    }
}
