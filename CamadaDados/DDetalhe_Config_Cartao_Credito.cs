using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Config_Cartao_Credito
    {
        private int _IdDetalhe_Config_Cartao_Credito;
        private string _Compensacao_Auto;

        public int IdDetalhe_Config_Cartao_Credito
        {
            get
            {
                return _IdDetalhe_Config_Cartao_Credito;
            }

            set
            {
                _IdDetalhe_Config_Cartao_Credito = value;
            }
        }

        public string Compensacao_Auto
        {
            get
            {
                return _Compensacao_Auto;
            }

            set
            {
                _Compensacao_Auto = value;
            }
        }

        
        public DDetalhe_Config_Cartao_Credito()
        {

        }


        public DDetalhe_Config_Cartao_Credito(int iddetalhe_config_cartao_credito, string compensacao_auto)
        {
            this.IdDetalhe_Config_Cartao_Credito = iddetalhe_config_cartao_credito;
            this.Compensacao_Auto = compensacao_auto;
        }


        //Metodo Editar 
        public string Editar(DDetalhe_Config_Cartao_Credito Detalhe_Config_Cartao_Credito)
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
                SqlCmd.CommandText = "speditar_detalhe_config_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_config_cartao_credito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Config_Cartao_Credito.IdDetalhe_Config_Cartao_Credito;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParCompensacao_Auto = new SqlParameter();
                ParCompensacao_Auto.ParameterName = "@compensacao_auto";
                ParCompensacao_Auto.SqlDbType = SqlDbType.VarChar;
                ParCompensacao_Auto.Size = 3;
                ParCompensacao_Auto.Value = Detalhe_Config_Cartao_Credito.Compensacao_Auto;
                SqlCmd.Parameters.Add(ParCompensacao_Auto);

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
            DataTable DtResultado = new DataTable("detalhe_config_cartao_credito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhe_config_cartao_credito";
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
