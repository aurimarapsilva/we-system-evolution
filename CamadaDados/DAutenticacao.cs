using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DAutenticacao
    {
        private int _IdAutenticacao;
        private string _Autentication_Key;

        public int IdAutenticacao
        {
            get
            {
                return _IdAutenticacao;
            }

            set
            {
                _IdAutenticacao = value;
            }
        }

        public string Autentication_Key
        {
            get
            {
                return _Autentication_Key;
            }

            set
            {
                _Autentication_Key = value;
            }
        }

        public DAutenticacao()
        {

        }


        public DAutenticacao(int idautenticacao, string autentication_key)
        {
            this.IdAutenticacao = idautenticacao;
            this.Autentication_Key = autentication_key;
        }


        //Metodo Editar 
        public string Editar(DAutenticacao Autenticacao)
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
                SqlCmd.CommandText = "speditar_autenticacao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idautenticacao";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Autenticacao.IdAutenticacao;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParAutentication_Key = new SqlParameter();
                ParAutentication_Key.ParameterName = "@autentication_key";
                ParAutentication_Key.SqlDbType = SqlDbType.VarChar;
                ParAutentication_Key.Size = 20;
                ParAutentication_Key.Value = Autenticacao.Autentication_Key;
                SqlCmd.Parameters.Add(ParAutentication_Key);

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


        //Metodo Excluir 
        public string Excluir(DAutenticacao Autenticacao)
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
                SqlCmd.CommandText = "spdeletar_autenticacao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Autenticacao.IdAutenticacao;
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
        public DataTable Mostrar(string Data_Atual)
        {
            DataTable DtResultado = new DataTable("autenticacao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_autenticacao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Inicial = new SqlParameter();
                ParData_Inicial.ParameterName = "@dataatual";
                ParData_Inicial.SqlDbType = SqlDbType.VarChar;
                ParData_Inicial.Size = 20;
                ParData_Inicial.Value = Data_Atual;
                SqlCmd.Parameters.Add(ParData_Inicial);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Mostrar 
        public DataTable Mostrar_Tudo()
        {
            DataTable DtResultado = new DataTable("autenticacao");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_autenticacao_tudo";
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
