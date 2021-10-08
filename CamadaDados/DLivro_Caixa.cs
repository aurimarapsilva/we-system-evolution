using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DLivro_Caixa
    {
        private int _Id;
        private DateTime _Data;
        private string _Historico;
        private string _Num_Doc;
        private decimal _Credito;
        private decimal _Debito;

        //Get Set Numeração Automática LIVRO CAIXA - CRÉDITO
        private int _Atual_Livro_Caixa_Credito;

        //Get Set Numeração Automática LIVRO CAIXA - DEBITO
        private int _Atual_Livro_Caixa_Debito;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
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

        public string Historico
        {
            get
            {
                return _Historico;
            }

            set
            {
                _Historico = value;
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

        public decimal Credito
        {
            get
            {
                return _Credito;
            }

            set
            {
                _Credito = value;
            }
        }

        public decimal Debito
        {
            get
            {
                return _Debito;
            }

            set
            {
                _Debito = value;
            }
        }

        public int Atual_Livro_Caixa_Credito
        {
            get
            {
                return _Atual_Livro_Caixa_Credito;
            }

            set
            {
                _Atual_Livro_Caixa_Credito = value;
            }
        }

        public int Atual_Livro_Caixa_Debito
        {
            get
            {
                return _Atual_Livro_Caixa_Debito;
            }

            set
            {
                _Atual_Livro_Caixa_Debito = value;
            }
        }



        //Construtor vazio
        public DLivro_Caixa()
        {

        }

        //Construtor com parametros 
        public DLivro_Caixa(int id, DateTime data, string historico, string num_doc, decimal credito, decimal debito)
        {
            this.Id = id;
            this.Data = data;
            this.Historico = historico;
            this.Num_Doc = num_doc;
            this.Credito = credito;
            this.Debito = debito;
        }

        //Metodo Atualizar Numeração Automática - LIVRO CAIXA Crédito
        public string Atualizar_Num_Auto_Livro_Caixa_Credito(DLivro_Caixa Livro_Caixa)
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
                SqlCmd.CommandText = "spatualizar_num_auto_livro_caixa_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNum_Auto = new SqlParameter();
                ParNum_Auto.ParameterName = "@atual_livro_caixa_credito";
                ParNum_Auto.SqlDbType = SqlDbType.Int;
                ParNum_Auto.Value = Livro_Caixa.Atual_Livro_Caixa_Credito;
                SqlCmd.Parameters.Add(ParNum_Auto);

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


        //Metodo Atualizar Numeração Automática - LIVRO CAIXA Debito
        public string Atualizar_Num_Auto_Livro_Caixa_Debito(DLivro_Caixa Livro_Caixa)
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
                SqlCmd.CommandText = "spatualizar_num_auto_livro_caixa_debito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNum_Auto = new SqlParameter();
                ParNum_Auto.ParameterName = "@atual_livro_caixa_debito";
                ParNum_Auto.SqlDbType = SqlDbType.Int;
                ParNum_Auto.Value = Livro_Caixa.Atual_Livro_Caixa_Debito;
                SqlCmd.Parameters.Add(ParNum_Auto);

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

        //Metodo Inserir 
        public string Inserir(DLivro_Caixa Livro_Caixa)
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
                SqlCmd.CommandText = "spinserir_livro_caixa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Livro_Caixa.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParHistorico = new SqlParameter();
                ParHistorico.ParameterName = "@historico";
                ParHistorico.SqlDbType = SqlDbType.VarChar;
                ParHistorico.Size = 90;
                ParHistorico.Value = Livro_Caixa.Historico;
                SqlCmd.Parameters.Add(ParHistorico);

                SqlParameter ParNum_Doc = new SqlParameter();
                ParNum_Doc.ParameterName = "@num_doc";
                ParNum_Doc.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc.Size = 70;
                ParNum_Doc.Value = Livro_Caixa.Num_Doc;
                SqlCmd.Parameters.Add(ParNum_Doc);
                
                SqlParameter ParCredito = new SqlParameter();
                ParCredito.ParameterName = "@credito";
                ParCredito.SqlDbType = SqlDbType.Decimal;
                ParCredito.Precision = 7;
                ParCredito.Scale = 2;
                ParCredito.Value = Livro_Caixa.Credito;
                SqlCmd.Parameters.Add(ParCredito);

                SqlParameter ParDebito = new SqlParameter();
                ParDebito.ParameterName = "@debito";
                ParDebito.SqlDbType = SqlDbType.Decimal;
                ParDebito.Precision = 7;
                ParDebito.Scale = 2;
                ParDebito.Value = Livro_Caixa.Debito;
                SqlCmd.Parameters.Add(ParDebito);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";
                
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
        public string Excluir(DLivro_Caixa Livro_Caixa)
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
                SqlCmd.CommandText = "spdeletar_livro_caixa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDelete = new SqlParameter();
                ParDelete.ParameterName = "@id";
                ParDelete.SqlDbType = SqlDbType.Int;
                ParDelete.Value = Livro_Caixa.Id;
                SqlCmd.Parameters.Add(ParDelete);


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


        //Metodo Excluir 
        public string Excluir_UseNumDoc(DLivro_Caixa Livro_Caixa)
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
                SqlCmd.CommandText = "spdeletar_livro_caixa_UseNumDoc";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParDelete_Num_Doc = new SqlParameter();
                ParDelete_Num_Doc.ParameterName = "@use_num_doc";
                ParDelete_Num_Doc.SqlDbType = SqlDbType.VarChar;
                ParDelete_Num_Doc.Size = 20;
                ParDelete_Num_Doc.Value = Livro_Caixa.Num_Doc;
                SqlCmd.Parameters.Add(ParDelete_Num_Doc);


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


        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("livro_caixa");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_livro_caixa";
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


        //Método Buscar por Datas
        public DataTable BuscarData(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("livro_caixa");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_registro_livro_caixa_data";
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

    }
}
