using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DContas_Pagar
    {
        private int _IdContas_Pagar;
        private int _IdEntrada;
        private DateTime _Data_Entrada;
        private string _Fornecedor_Nome;
        private string _Credor_Nao_Cadastrado;
        private string _Num_Doc;
        private string _Total_Parcelas;
        private decimal _Valor_Total;

        public int IdContas_Pagar
        {
            get
            {
                return _IdContas_Pagar;
            }

            set
            {
                _IdContas_Pagar = value;
            }
        }

        public int IdEntrada
        {
            get
            {
                return _IdEntrada;
            }

            set
            {
                _IdEntrada = value;
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

        public string Fornecedor_Nome
        {
            get
            {
                return _Fornecedor_Nome;
            }

            set
            {
                _Fornecedor_Nome = value;
            }
        }

        public string Credor_Nao_Cadastrado
        {
            get
            {
                return _Credor_Nao_Cadastrado;
            }

            set
            {
                _Credor_Nao_Cadastrado = value;
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

        

        public DContas_Pagar()
        {

        }


        public DContas_Pagar(int idcontas_pagar, int identrada, DateTime data_entrada, string fornecedor_nome, string credor_nao_cadastrado, string num_doc, string total_parcelas, decimal valor_total)
        {
            this.IdContas_Pagar = idcontas_pagar;
            this.IdEntrada = identrada;
            this.Data_Entrada = data_entrada;
            this.Fornecedor_Nome = fornecedor_nome;
            this.Credor_Nao_Cadastrado = credor_nao_cadastrado;
            this.Num_Doc = num_doc;
            this.Total_Parcelas = total_parcelas;
            this.Valor_Total = valor_total;
        }


        //Metodo Inserir Apos Entrada
        public string Inserir_Contas_Pagar_Apos_Entrada(DContas_Pagar Contas_Pagar, List<DDetalhe_Contas_Pagar> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_pagar_apos_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_pagar";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdEntrada = new SqlParameter();
                ParIdEntrada.ParameterName = "@identrada";
                ParIdEntrada.SqlDbType = SqlDbType.Int;
                ParIdEntrada.Value = Contas_Pagar.IdEntrada;
                SqlCmd.Parameters.Add(ParIdEntrada);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Pagar.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParFornecedor_Nome = new SqlParameter();
                ParFornecedor_Nome.ParameterName = "@fornecedor_nome";
                ParFornecedor_Nome.SqlDbType = SqlDbType.VarChar;
                ParFornecedor_Nome.Size = 50;
                ParFornecedor_Nome.Value = Contas_Pagar.Fornecedor_Nome;
                SqlCmd.Parameters.Add(ParFornecedor_Nome);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Pagar.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Pagar.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Pagar.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Pagar = Convert.ToInt32(SqlCmd.Parameters["@idcontas_pagar"].Value);

                    foreach (DDetalhe_Contas_Pagar detCP in Detalhe)
                    {
                        detCP.IdContas_Pagar = this.IdContas_Pagar;

                        //Chamar método inserir no detalhes entrada
                        resp = detCP.Inserir_Tudo(detCP, ref SqlCon, ref SqlTra);

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


        //Metodo Inserir Credor Cadastrado
        public string Inserir_Credor_Cadastrado(DContas_Pagar Contas_Pagar, List<DDetalhe_Contas_Pagar> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_pagar_credor_cadastrado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_pagar";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Pagar.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParFornecedor_Nome = new SqlParameter();
                ParFornecedor_Nome.ParameterName = "@fornecedor_nome";
                ParFornecedor_Nome.SqlDbType = SqlDbType.VarChar;
                ParFornecedor_Nome.Size = 50;
                ParFornecedor_Nome.Value = Contas_Pagar.Fornecedor_Nome;
                SqlCmd.Parameters.Add(ParFornecedor_Nome);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Pagar.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Pagar.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Pagar.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Pagar = Convert.ToInt32(SqlCmd.Parameters["@idcontas_pagar"].Value);

                    foreach (DDetalhe_Contas_Pagar detCP in Detalhe)
                    {
                        detCP.IdContas_Pagar = this.IdContas_Pagar;

                        //Chamar método inserir no detalhes entrada
                        resp = detCP.Inserir_Tudo(detCP, ref SqlCon, ref SqlTra);

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


        //Metodo Inserir Credor Não Cadastrado
        public string Inserir_Credor_Nao_Cadastrado(DContas_Pagar Contas_Pagar, List<DDetalhe_Contas_Pagar> Detalhe)
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
                SqlCmd.CommandText = "spinserir_contas_pagar_credor_nao_cadastrado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcontas_pagar";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.Date;
                ParData_Entrada.Value = Contas_Pagar.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParCredor_Nao_Cadastrado = new SqlParameter();
                ParCredor_Nao_Cadastrado.ParameterName = "@credor_nao_cadastrado";
                ParCredor_Nao_Cadastrado.SqlDbType = SqlDbType.VarChar;
                ParCredor_Nao_Cadastrado.Size = 50;
                ParCredor_Nao_Cadastrado.Value = Contas_Pagar.Credor_Nao_Cadastrado;
                SqlCmd.Parameters.Add(ParCredor_Nao_Cadastrado);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 20;
                ParNum_Doc.Value = Contas_Pagar.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);

                SqlParameter ParTotal_Parcelas = new SqlParameter();
                ParTotal_Parcelas.ParameterName = "@total_parcelas";
                ParTotal_Parcelas.SqlDbType = SqlDbType.VarChar;
                ParTotal_Parcelas.Size = 4;
                ParTotal_Parcelas.Value = Contas_Pagar.Total_Parcelas;
                SqlCmd.Parameters.Add(ParTotal_Parcelas);

                SqlParameter ParValor_Total = new SqlParameter();
                ParValor_Total.ParameterName = "@valor_total";
                ParValor_Total.SqlDbType = SqlDbType.Decimal;
                ParValor_Total.Precision = 7;
                ParValor_Total.Scale = 2;
                ParValor_Total.Value = Contas_Pagar.Valor_Total;
                SqlCmd.Parameters.Add(ParValor_Total);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdContas_Pagar = Convert.ToInt32(SqlCmd.Parameters["@idcontas_pagar"].Value);

                    foreach (DDetalhe_Contas_Pagar detCP in Detalhe)
                    {
                        detCP.IdContas_Pagar = this.IdContas_Pagar;

                        //Chamar método inserir no detalhes entrada
                        resp = detCP.Inserir_Tudo(detCP, ref SqlCon, ref SqlTra);

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
        public string Excluir(DContas_Pagar Contas_Pagar)
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
                SqlCmd.CommandText = "spdeletar_contas_pagar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Contas_Pagar.IdContas_Pagar;
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
            DataTable DtResultado = new DataTable("contas_pagar");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_contas_pagar";
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
            DataTable DtResultado = new DataTable("detalhe_contas_pagar");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_contas_pagar";
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


        //Método Buscar Pelo Nome do Fornecedor
        public DataTable Buscar_Pelo_Credor(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("contas_pagar");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_contas_pagar_credor";
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
        public DataTable Pesquisa_Especifica(string Data_Inicial, string Data_Final, string Credor)
        {
            DataTable DtResultado = new DataTable("contas_pagar");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_contas_pagar_pesquisa_especifica";
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

                SqlParameter ParCredor = new SqlParameter();
                ParCredor.ParameterName = "@credor";
                ParCredor.SqlDbType = SqlDbType.VarChar;
                ParCredor.Size = 50;
                ParCredor.Value = Credor;
                SqlCmd.Parameters.Add(ParCredor);

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
            DataTable DtResultado = new DataTable("detalhe_contas_pagar");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_parcelas_vencidas_contas_pagar";
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
    }
}
