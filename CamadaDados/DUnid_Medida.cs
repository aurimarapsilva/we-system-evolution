using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DUnid_Medida
    {
        private int _Idunid_medida;
        private string _Unidade;
        private string _TextoBuscar;

        public int Idunid_medida
        {
            get
            {
                return _Idunid_medida;
            }

            set
            {
                _Idunid_medida = value;
            }
        }

        public string Unidade
        {
            get
            {
                return _Unidade;
            }

            set
            {
                _Unidade = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        //Construtor vazio

        public DUnid_Medida()
        {

        }

        //Construtor com parametros
        public DUnid_Medida(int idunid_medida, string unidade, string textobuscar)
        {
            this.Idunid_medida = idunid_medida;
            this.Unidade = unidade;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Inserir 
        public string Inserir(DUnid_Medida Unid_Medida)
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
                SqlCmd.CommandText = "spinserir_unid_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);


                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@unidade";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 5;
                ParNome.Value = Unid_Medida.Unidade;
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
        public string Editar(DUnid_Medida Unid_Medida)
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
                SqlCmd.CommandText = "speditar_unid_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Unid_Medida.Idunid_medida;
                SqlCmd.Parameters.Add(ParId);


                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@unidade";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 3;
                ParNome.Value = Unid_Medida.Unidade;
                SqlCmd.Parameters.Add(ParNome);

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
        public string Excluir(DUnid_Medida Unid_Medida)
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
                SqlCmd.CommandText = "spdeletar_unid_medida";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Unid_Medida.Idunid_medida;
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
            DataTable DtResultado = new DataTable("unid_medida");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_unid_medida";
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

        //Metodo Buscar Nome 
        public DataTable BuscarNome(DUnid_Medida Unid_Medida)
        {
            DataTable DtResultado = new DataTable("unid_medida");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_unid_medida_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Unid_Medida.TextoBuscar;
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
