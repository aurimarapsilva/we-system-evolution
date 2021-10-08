using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_Orcamento
    {
        private string _Texto;

        public string Texto
        {
            get
            {
                return _Texto;
            }

            set
            {
                _Texto = value;
            }
        }

        public DConfig_Orcamento()
        {

        }

        public DConfig_Orcamento(string texto)
        {
            this.Texto = texto;
        }

        //Metodo Editar 
        public string Editar(DConfig_Orcamento Config_Orcamento)
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
                SqlCmd.CommandText = "speditar_config_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParTexto = new SqlParameter();
                ParTexto.ParameterName = "@texto";
                ParTexto.SqlDbType = SqlDbType.VarChar;
                ParTexto.Size = 500;
                ParTexto.Value = Config_Orcamento.Texto;
                SqlCmd.Parameters.Add(ParTexto);
                
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
            DataTable DtResultado = new DataTable("config_orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_orcamento";
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
