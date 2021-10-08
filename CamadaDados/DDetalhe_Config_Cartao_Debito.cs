using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Config_Cartao_Debito
    {
        private int _IdDetalhe_Config_Cartao_Debito;
        private string _Compensacao_Auto;

        public int IdDetalhe_Config_Cartao_Debito
        {
            get
            {
                return _IdDetalhe_Config_Cartao_Debito;
            }

            set
            {
                _IdDetalhe_Config_Cartao_Debito = value;
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


        public DDetalhe_Config_Cartao_Debito()
        {

        }

        public DDetalhe_Config_Cartao_Debito(int iddetalhe_config_cartao_debito, string compensacao_auto)
        {
            this.IdDetalhe_Config_Cartao_Debito = iddetalhe_config_cartao_debito;
            this.Compensacao_Auto = compensacao_auto;
        }


        //Metodo Editar 
        public string Editar(DDetalhe_Config_Cartao_Debito Detalhe_Config_Cartao_Debito)
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
                SqlCmd.CommandText = "speditar_detalhe_config_cartao_debito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_config_cartao_debito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Config_Cartao_Debito.IdDetalhe_Config_Cartao_Debito;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParCompensacao_Auto = new SqlParameter();
                ParCompensacao_Auto.ParameterName = "@compensacao_auto";
                ParCompensacao_Auto.SqlDbType = SqlDbType.VarChar;
                ParCompensacao_Auto.Size = 3;
                ParCompensacao_Auto.Value = Detalhe_Config_Cartao_Debito.Compensacao_Auto;
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
            DataTable DtResultado = new DataTable("detalhe_config_cartao_debito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhe_config_cartao_debito";
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
