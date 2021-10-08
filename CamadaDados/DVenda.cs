using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DVenda
    {
        public int _IdVenda;
        private int _IdRemetente;
        private int _IdGuiche_Atendimento;
        private DateTime _Data;
        private int _IdCliente;
        private int _idFuncionario;
        private string _Tipo_comprovante;
        private string _Num_Comprovante;
        private string _Recebimento;
        private string _Detalhe_Recebimento;
        private decimal _Valor_Entrada;
        private decimal _Comissao_Paga;

        public int IdVenda
        {
            get
            {
                return _IdVenda;
            }

            set
            {
                _IdVenda = value;
            }
        }

        public int IdRemetente
        {
            get
            {
                return _IdRemetente;
            }

            set
            {
                _IdRemetente = value;
            }
        }

        public int IdGuiche_Atendimento
        {
            get
            {
                return _IdGuiche_Atendimento;
            }

            set
            {
                _IdGuiche_Atendimento = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }

            set
            {
                _IdCliente = value;
            }
        }

        public int IdFuncionario
        {
            get
            {
                return _idFuncionario;
            }

            set
            {
                _idFuncionario = value;
            }
        }

        public string Tipo_comprovante
        {
            get
            {
                return _Tipo_comprovante;
            }

            set
            {
                _Tipo_comprovante = value;
            }
        }

        public string Num_Comprovante
        {
            get
            {
                return _Num_Comprovante;
            }

            set
            {
                _Num_Comprovante = value;
            }
        }

        public string Recebimento
        {
            get
            {
                return _Recebimento;
            }

            set
            {
                _Recebimento = value;
            }
        }

        public string Detalhe_Recebimento
        {
            get
            {
                return _Detalhe_Recebimento;
            }

            set
            {
                _Detalhe_Recebimento = value;
            }
        }

        public decimal Valor_Entrada
        {
            get
            {
                return _Valor_Entrada;
            }

            set
            {
                _Valor_Entrada = value;
            }
        }

        public decimal Comissao_Paga
        {
            get
            {
                return _Comissao_Paga;
            }

            set
            {
                _Comissao_Paga = value;
            }
        }

        public DVenda()
        {

        }


        public DVenda(int idvenda, int idremetente, int idguiche_atendimento,  DateTime data, int idcliente, int idfuncionario, string tipo_comprovante, string num_comprovante, string recebimento, string detalhe_recebimento, decimal valor_entrada, decimal comissao_paga)
        {
            this.IdVenda = idvenda;
            this.IdRemetente = idremetente;
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.Data = data;
            this.IdCliente = idcliente;
            this.IdFuncionario = idfuncionario;
            this.Tipo_comprovante = tipo_comprovante;
            this.Num_Comprovante = num_comprovante;
            this.Recebimento = recebimento;
            this.Detalhe_Recebimento = detalhe_recebimento;
            this.Valor_Entrada = valor_entrada;
            this.Comissao_Paga = comissao_paga;
        }


        //Método Abater estoque
        public string DiminuirEstoque(int idproduto, decimal quant)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdiminuir_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = idproduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter Parquant = new SqlParameter();
                Parquant.ParameterName = "@quant";
                Parquant.SqlDbType = SqlDbType.Decimal;
                Parquant.Precision = 10;
                Parquant.Scale = 3;
                Parquant.Value = quant;
                SqlCmd.Parameters.Add(Parquant);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A atualização não foi feita";
                
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }



        //Metodo Atualizar Numeração Automática - VENDAS
        public string Atualizar_Num_Auto_Venda(int atual_venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spatualizar_num_auto_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@atual_venda";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = atual_venda;
                SqlCmd.Parameters.Add(ParIdProduto);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A atualização não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Método Inserir
        public string Inserir(DVenda Venda, List<DDetalhe_Venda> DV, List<DForma_Pagamento> FP)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction();


                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idvenda";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = Venda.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParIdGuiche_Atendimento = new SqlParameter();
                ParIdGuiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdGuiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdGuiche_Atendimento.Value = Venda.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdGuiche_Atendimento);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Venda.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venda.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Venda.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParTipoComprovante = new SqlParameter();
                ParTipoComprovante.ParameterName = "@tipo_comprovante";
                ParTipoComprovante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprovante.Size = 20;
                ParTipoComprovante.Value = Venda.Tipo_comprovante;
                SqlCmd.Parameters.Add(ParTipoComprovante);

                SqlParameter ParNum_Comprovante = new SqlParameter();
                ParNum_Comprovante.ParameterName = "@num_comprovante";
                ParNum_Comprovante.SqlDbType = SqlDbType.VarChar;
                ParNum_Comprovante.Size = 20;
                ParNum_Comprovante.Value = Venda.Num_Comprovante;
                SqlCmd.Parameters.Add(ParNum_Comprovante);

                SqlParameter ParRecebimento = new SqlParameter();
                ParRecebimento.ParameterName = "@recebimento";
                ParRecebimento.SqlDbType = SqlDbType.VarChar;
                ParRecebimento.Size = 20;
                ParRecebimento.Value = Venda.Recebimento;
                SqlCmd.Parameters.Add(ParRecebimento);

                SqlParameter ParDetalhe_Recebimento = new SqlParameter();
                ParDetalhe_Recebimento.ParameterName = "@detalhe_recebimento";
                ParDetalhe_Recebimento.SqlDbType = SqlDbType.VarChar;
                ParDetalhe_Recebimento.Size = 3;
                ParDetalhe_Recebimento.Value = Venda.Detalhe_Recebimento;
                SqlCmd.Parameters.Add(ParDetalhe_Recebimento);

                SqlParameter ParValor_Entrada = new SqlParameter();
                ParValor_Entrada.ParameterName = "@valor_entrada";
                ParValor_Entrada.SqlDbType = SqlDbType.Decimal;
                ParValor_Entrada.Precision = 7;
                ParValor_Entrada.Scale = 2;
                ParValor_Entrada.Value = Venda.Valor_Entrada;
                SqlCmd.Parameters.Add(ParValor_Entrada);

                SqlParameter ParComissao_Paga = new SqlParameter();
                ParComissao_Paga.ParameterName = "@comissao_paga";
                ParComissao_Paga.SqlDbType = SqlDbType.Decimal;
                ParComissao_Paga.Precision = 7;
                ParComissao_Paga.Scale = 2;
                ParComissao_Paga.Value = Venda.Comissao_Paga;
                SqlCmd.Parameters.Add(ParComissao_Paga);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdVenda = Convert.ToInt32(SqlCmd.Parameters["@idvenda"].Value);

                    // Inserir tabela detalhe_venda
                    foreach (DDetalhe_Venda detV in DV)
                    {
                        detV.IdVenda = this.IdVenda;

                        //Chamar método inserir no detalhes entrada
                        resp = detV.Inserir(detV, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Ok"))
                        {
                            break;
                        }
                        else
                        {
                            resp = Atualizar_Num_Auto_Venda(Convert.ToInt32(this.Num_Comprovante));
                        }
                    }

                    // Inserir tabela pagamento
                    foreach (DForma_Pagamento forma in FP)
                    {
                        forma.IdVenda = this.IdVenda;

                        //Chamar método inserir no detalhes entrada
                        resp = forma.Inserir(forma, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Ok"))
                        {
                            break;
                        }
                    }
                }
                if (resp.Equals("Ok"))
                {
                    SqlTra.Commit();     //Só a partir do comit os dados são salvos com uma transação
                }
                else
                {
                    SqlTra.Rollback();   //Roolback cancela toda a transação, nada é salvo!!
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Excluir 
        public string Excluir(DVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Venda.IdVenda;
                SqlCmd.Parameters.Add(ParId);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A exclusão não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Método Mostrar - VENDA
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        // Método: LIMITE DE CREDITO USADO
        public DataTable Limite_Credito_Usado(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "mostrar_limite_credito_usado";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);
                
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }



        //Método Buscar por Datas
        public DataTable BuscarData(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venda_data";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Metodo Buscar Produtos Disponiveis para Venda - POR DESCRIÇÃO
        public DataTable Buscar_Produtos_Disp_Venda(string textobuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disponivel_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Produtos Disponiveis para Venda - POR CÓDIGO
        public DataTable Buscar_Produtos_Disp_Venda_Codigo(string textobuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disponivel_venda_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Detalhes
        public DataTable MostrarDetalhes(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Mostrar Formas de Pagamento - VENDA
        public DataTable Mostrar_Formas_Pagamento_Venda(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("pagamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_formas_pgto_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Mostrar Resultado para fechar dia
        public DataTable Mostrar_Resultado_Fechar_Dia(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Resultado para fechamento do dia - CARTÃO DE CRÉDITO
        public DataTable Mostrar_Resultado_Dia_Cartao_Credito(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Resultado para fechamento do dia - CARTÃO DE DEBITO       
        public DataTable Mostrar_Resultado_Dia_Cartao_Debito(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia_cartao_debito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Resultado para fechamento do dia - CHEQUE     
        public DataTable Mostrar_Resultado_Dia_Cheque(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia_cheque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Resultado para fechamento do dia - CREDIÁRIO DA LOJA    
        public DataTable Mostrar_Resultado_Dia_Crediario_Loja(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia_crediario_loja";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Resultado para fechamento do dia - DINHEIRO    
        public DataTable Mostrar_Resultado_Dia_Dinheiro(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_resultado_fechamento_dia_dinheiro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Fechar Caixa Somente uma vez por dia  
        public DataTable Fechar_Caixa_Somente_Uma_Vez(string TextoBuscar, string TextoBuscar2, string TextoBuscar3)
        {
            DataTable DtResultado = new DataTable("caixa_operacao_dia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spfechar_caixa_somente_uma_vez";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlParameter ParTextoBuscar3 = new SqlParameter();
                ParTextoBuscar3.ParameterName = "@textobuscar3";
                ParTextoBuscar3.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar3.Size = 20;
                ParTextoBuscar3.Value = TextoBuscar3;
                SqlCmd.Parameters.Add(ParTextoBuscar3);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Mostrar Vendas que contenham produtos com quant atual abaixo de 0
        public DataTable Vendas_Quant_Atual_Abaixo_Zero()
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_vendas_quant_atual_abaixo_zero";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Venda pelo ID
        public DataTable Mostrar_Venda_Pelo_ID(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("venda");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venda_pelo_id";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
