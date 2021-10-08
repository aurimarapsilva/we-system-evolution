using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DContas_Receber
    {
        private int _IdContas_Receber;
        private int _IdVenda;
        private DateTime _Data_Entrada;
        private string _Cliente_Nome;
        private string _Devedor_Nao_Cadastrado;
        private string _Num_Doc;
        private string _Total_Parcelas;
        private decimal _Valor_Total;
        private decimal _Valor_Total_Atualizado;

        public int IdContas_Receber
        {
            get
            {
                return _IdContas_Receber;
            }

            set
            {
                _IdContas_Receber = value;
            }
        }

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

        public DateTime Data_Entrada
        {
            get
            {
                return _Data_Entrada;
            }

            set
            {
                _Data_Entrada = value;
            }
        }

        public string Cliente_Nome
        {
            get
            {
                return _Cliente_Nome;
            }

            set
            {
                _Cliente_Nome = value;
            }
        }

        public string Devedor_Nao_Cadastrado
        {
            get
            {
                return _Devedor_Nao_Cadastrado;
            }

            set
            {
                _Devedor_Nao_Cadastrado = value;
            }
        }

        public string Num_Doc
        {
            get
            {
                return _Num_Doc;
            }

            set
            {
                _Num_Doc = value;
            }
        }

        public string Total_Parcelas
        {
            get
            {
                return _Total_Parcelas;
            }

            set
            {
                _Total_Parcelas = value;
            }
        }

        public decimal Valor_Total
        {
            get
            {
                return _Valor_Total;
            }

            set
            {
                _Valor_Total = value;
            }
        }

        public decimal Valor_Total_Atualizado
        {
            get
            {
                return _Valor_Total_Atualizado;
            }

            set
            {
                _Valor_Total_Atualizado = value;
            }
        }

        public DContas_Receber()
        {

        }


        public DContas_Receber(int idcontas_receber, int idvenda, DateTime data_entrada, string cliente_nome, string devedor_nao_cadastrado, string num_doc, string total_parcelas, decimal valor_total, decimal valor_total_atualizado)
        {
            this.IdContas_Receber = idcontas_receber;
            this.IdVenda = idvenda;
            this.Data_Entrada = data_entrada;
            this.Cliente_Nome = cliente_nome;
            this.Devedor_Nao_Cadastrado = devedor_nao_cadastrado;
            this.Num_Doc = num_doc;
            this.Total_Parcelas = total_parcelas;
            this.Valor_Total = valor_total;
            this.Valor_Total_Atualizado = valor_total_atualizado;
        }


        //Metodo Inserir Contas Receber Após Venda
        public string Inserir_Contas_Receber_Apos_Venda(DContas_Receber Contas_Receber, List<DDetalhe_Contas_Receber> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_receber_apos_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_receber";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Contas_Receber.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Receber.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParCliente_Nome = new SqlParameter();
                ParCliente_Nome.ParameterName = "@cliente_nome";
                ParCliente_Nome.SqlDbType = SqlDbType.VarChar;
                ParCliente_Nome.Size = 50;
                ParCliente_Nome.Value = Contas_Receber.Cliente_Nome;
                SqlCmd.Parameters.Add(ParCliente_Nome);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Receber.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Receber.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Receber.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);

                SqlParameter ParValor_Total_Atualizado = new SqlParameter();
                ParValor_Total_Atualizado.ParameterName = "@valor_total_atualizado";
                ParValor_Total_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Total_Atualizado.Precision = 7;
                ParValor_Total_Atualizado.Scale = 2;
                ParValor_Total_Atualizado.Value = Contas_Receber.Valor_Total_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Total_Atualizado);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Receber = Convert.ToInt32(SqlCmd.Parameters["@idcontas_receber"].Value);

                    foreach (DDetalhe_Contas_Receber detCR in Detalhe)
                    {
                        detCR.IdContas_Receber = this.IdContas_Receber;

                        //Chamar método inserir no detalhes entrada
                        resp = detCR.Inserir_Tudo(detCR, ref SqlCon, ref SqlTra);

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


        //Metodo Inserir Contas Receber Após Venda
        public string Inserir_Devedor_Cadastrado(DContas_Receber Contas_Receber, List<DDetalhe_Contas_Receber> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_receber_devedor_cadastrado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_receber";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Receber.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParCliente_Nome = new SqlParameter();
                ParCliente_Nome.ParameterName = "@cliente_nome";
                ParCliente_Nome.SqlDbType = SqlDbType.VarChar;
                ParCliente_Nome.Size = 50;
                ParCliente_Nome.Value = Contas_Receber.Cliente_Nome;
                SqlCmd.Parameters.Add(ParCliente_Nome);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Receber.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Receber.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Receber.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);

                SqlParameter ParValor_Total_Atualizado = new SqlParameter();
                ParValor_Total_Atualizado.ParameterName = "@valor_total_atualizado";
                ParValor_Total_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Total_Atualizado.Precision = 7;
                ParValor_Total_Atualizado.Scale = 2;
                ParValor_Total_Atualizado.Value = Contas_Receber.Valor_Total_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Total_Atualizado);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Receber = Convert.ToInt32(SqlCmd.Parameters["@idcontas_receber"].Value);

                    foreach (DDetalhe_Contas_Receber detCR in Detalhe)
                    {
                        detCR.IdContas_Receber = this.IdContas_Receber;

                        //Chamar método inserir no detalhes entrada
                        resp = detCR.Inserir_Tudo(detCR, ref SqlCon, ref SqlTra);

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


        //Metodo Inserir Devedor Não Cadastrado
        public string Inserir_Devedor_Nao_Cadastrado(DContas_Receber Contas_Receber, List<DDetalhe_Contas_Receber> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_receber_devedor_nao_cadastrado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_receber";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Receber.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParDevedor_Nao_Cadastrado = new SqlParameter();
                ParDevedor_Nao_Cadastrado.ParameterName = "@devedor_nao_cadastrado";
                ParDevedor_Nao_Cadastrado.SqlDbType = SqlDbType.VarChar;
                ParDevedor_Nao_Cadastrado.Size = 50;
                ParDevedor_Nao_Cadastrado.Value = Contas_Receber.Devedor_Nao_Cadastrado;
                SqlCmd.Parameters.Add(ParDevedor_Nao_Cadastrado);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Receber.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Receber.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Receber.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);

                SqlParameter ParValor_Total_Atualizado = new SqlParameter();
                ParValor_Total_Atualizado.ParameterName = "@valor_total_atualizado";
                ParValor_Total_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Total_Atualizado.Precision = 7;
                ParValor_Total_Atualizado.Scale = 2;
                ParValor_Total_Atualizado.Value = Contas_Receber.Valor_Total_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Total_Atualizado);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Receber = Convert.ToInt32(SqlCmd.Parameters["@idcontas_receber"].Value);

                    foreach (DDetalhe_Contas_Receber detCR in Detalhe)
                    {
                        detCR.IdContas_Receber = this.IdContas_Receber;

                        //Chamar método inserir no detalhes entrada
                        resp = detCR.Inserir_Tudo(detCR, ref SqlCon, ref SqlTra);

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
        public string Excluir(DContas_Receber Contas_Receber)
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
                SqlCmd.CommandText = "spdeletar_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Contas_Receber.IdContas_Receber;
                SqlCmd.Parameters.Add(ParId);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A exclusão não foi feita";

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

        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_contas_receber";
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


        //Método Mostrar Detalhes
        public DataTable MostrarDetalhes(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_contas_receber";
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


        //Método Buscar Pelo Nome Cliente
        public DataTable Buscar_Pelo_Cliente(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_contas_receber_devedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
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


        //Método Pesquisa Específica
        public DataTable Pesquisa_Especifica(string Data_Inicial, string Data_Final, string Devedor)
        {
            DataTable DtResultado = new DataTable("contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_contas_receber_pesquisa_especifica";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Inicial = new SqlParameter();
                ParData_Inicial.ParameterName = "@datainicial";
                ParData_Inicial.SqlDbType = SqlDbType.VarChar;
                ParData_Inicial.Size = 50;
                ParData_Inicial.Value = Data_Inicial;
                SqlCmd.Parameters.Add(ParData_Inicial);

                SqlParameter ParData_Final = new SqlParameter();
                ParData_Final.ParameterName = "@datafinal";
                ParData_Final.SqlDbType = SqlDbType.VarChar;
                ParData_Final.Size = 50;
                ParData_Final.Value = Data_Final;
                SqlCmd.Parameters.Add(ParData_Final);

                SqlParameter ParDevedor = new SqlParameter();
                ParDevedor.ParameterName = "@devedor";
                ParDevedor.SqlDbType = SqlDbType.VarChar;
                ParDevedor.Size = 50;
                ParDevedor.Value = Devedor;
                SqlCmd.Parameters.Add(ParDevedor);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        //Método Buscar Parcelas Vencidas 
        public DataTable Buscar_Parcelas_Vencidas(string Data_Atual)
        {
            DataTable DtResultado = new DataTable("detalhe_contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_parcelas_vencidas_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Atual = new SqlParameter();
                ParData_Atual.ParameterName = "@dataatual";
                ParData_Atual.SqlDbType = SqlDbType.VarChar;
                ParData_Atual.Size = 20;
                ParData_Atual.Value = Data_Atual;
                SqlCmd.Parameters.Add(ParData_Atual);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Atualizar Valor Total Contas Receber
        public string Atualizar_Valor_Total_Contas_Receber(DContas_Receber Contas_Receber)
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
                SqlCmd.CommandText = "spatualizar_valor_total_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Contas_Receber.IdContas_Receber;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParValor_Total_Atualizado = new SqlParameter();
                ParValor_Total_Atualizado.ParameterName = "@valor_total_atualizado";
                ParValor_Total_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Total_Atualizado.Precision = 7;
                ParValor_Total_Atualizado.Scale = 2;
                ParValor_Total_Atualizado.Value = Contas_Receber.Valor_Total_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Total_Atualizado);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A edição não foi feita";

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


        //Metodo Mostrar Todos Registros
        public DataTable Mostrar_Todos_Registros()
        {
            DataTable DtResultado = new DataTable("contas_receber");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_contas_receber_tudo";
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
    }
}
