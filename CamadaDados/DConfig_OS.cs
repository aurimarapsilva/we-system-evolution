using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_OS
    {
        private string _Clausula1;
        private string _Clausula2;
        private string _Clausula3;

        public string Clausula1
        {
            get
            {
                return _Clausula1;
            }

            set
            {
                _Clausula1 = value;
            }
        }

        public string Clausula2
        {
            get
            {
                return _Clausula2;
            }

            set
            {
                _Clausula2 = value;
            }
        }

        public string Clausula3
        {
            get
            {
                return _Clausula3;
            }

            set
            {
                _Clausula3 = value;
            }
        }

        public DConfig_OS()
        {

        }

        public DConfig_OS(string clausula1, string clausula2, string clausula3)
        {
            this.Clausula1 = clausula1;
            this.Clausula2 = clausula2;
            this.Clausula3 = clausula3;
        }

        //Metodo Editar 
        public string Editar(DConfig_OS Config_OS)
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
                SqlCmd.CommandText = "speditar_config_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParClausula1 = new SqlParameter();
                ParClausula1.ParameterName = "@clausula1";
                ParClausula1.SqlDbType = SqlDbType.VarChar;
                ParClausula1.Size = 500;
                ParClausula1.Value = Config_OS.Clausula1;
                SqlCmd.Parameters.Add(ParClausula1);

                SqlParameter ParClausula2 = new SqlParameter();
                ParClausula2.ParameterName = "@clausula2";
                ParClausula2.SqlDbType = SqlDbType.VarChar;
                ParClausula2.Size = 500;
                ParClausula2.Value = Config_OS.Clausula2;
                SqlCmd.Parameters.Add(ParClausula2);

                SqlParameter ParClausula3 = new SqlParameter();
                ParClausula3.ParameterName = "@clausula3";
                ParClausula3.SqlDbType = SqlDbType.VarChar;
                ParClausula3.Size = 500;
                ParClausula3.Value = Config_OS.Clausula3;
                SqlCmd.Parameters.Add(ParClausula3);

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


        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("config_os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_os";
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
