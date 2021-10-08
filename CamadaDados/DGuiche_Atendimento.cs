using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DGuiche_Atendimento
    {
        private int _IdGuiche_Atendimento;
        private string _Nome;

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

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }
        
        public DGuiche_Atendimento()
        {

        }

        public DGuiche_Atendimento(int idguiche_atendimento, string nome)
        {
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.Nome = nome;
        }


        //Metodo Inserir 
        public string Inserir(DGuiche_Atendimento Guiche_Atendimento)
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
                SqlCmd.CommandText = "spinserir_guiche_atendimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idguiche_atendimento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);


                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 20;
                ParNome.Value = Guiche_Atendimento.Nome;
                SqlCmd.Parameters.Add(ParNome);
                
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


        //Metodo Editar 
        public string Editar(DGuiche_Atendimento Guiche_Atendimento)
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
                SqlCmd.CommandText = "speditar_guiche_atendimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idguiche_atendimento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Guiche_Atendimento.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 20;
                ParNome.Value = Guiche_Atendimento.Nome;
                SqlCmd.Parameters.Add(ParNome);

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
        public string Excluir(DGuiche_Atendimento Guiche_Atendimento)
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
                SqlCmd.CommandText = "spdeletar_guiche_atendimento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Guiche_Atendimento.IdGuiche_Atendimento;
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
            DataTable DtResultado = new DataTable("guiche_atendimento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_guiche_atendimento";
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

        //Metodo Mostrar 
        public DataTable BuscarNome(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("guiche_atendimento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_guiche_atendimento_nome";
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
