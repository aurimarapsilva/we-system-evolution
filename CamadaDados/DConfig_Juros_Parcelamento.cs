using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_Juros_Parcelamento
    {
        private int _IdConfig_Juros_Parcelamento;
        private decimal _Juros_ao_Mes_Card_Cred;
        private decimal _Juros_ao_Mes_Cred_Loja;
        private string _Habilitar;

        public int IdConfig_Juros_Parcelamento
        {
            get
            {
                return _IdConfig_Juros_Parcelamento;
            }

            set
            {
                _IdConfig_Juros_Parcelamento = value;
            }
        }

        public decimal Juros_ao_Mes_Card_Cred
        {
            get
            {
                return _Juros_ao_Mes_Card_Cred;
            }

            set
            {
                _Juros_ao_Mes_Card_Cred = value;
            }
        }

        public decimal Juros_ao_Mes_Cred_Loja
        {
            get
            {
                return _Juros_ao_Mes_Cred_Loja;
            }

            set
            {
                _Juros_ao_Mes_Cred_Loja = value;
            }
        }

        public string Habilitar
        {
            get
            {
                return _Habilitar;
            }

            set
            {
                _Habilitar = value;
            }
        }

        public DConfig_Juros_Parcelamento()
        {

        }

        public DConfig_Juros_Parcelamento(int idconfig_juros_parcelamento, decimal juros_ao_mes_card_cred, decimal juros_ao_mes_cred_loja, string habilitar)
        {
            this.IdConfig_Juros_Parcelamento = idconfig_juros_parcelamento;
            this.Juros_ao_Mes_Card_Cred = juros_ao_mes_card_cred;
            this.Juros_ao_Mes_Cred_Loja = juros_ao_mes_cred_loja;
            this.Habilitar = habilitar;
        }


        //Metodo Editar 
        public string Editar(DConfig_Juros_Parcelamento Config_Juros_Parcelamento)
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
                SqlCmd.CommandText = "speditar_config_juros_parcelamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParJuros_ao_Mes_Card_Cred = new SqlParameter();
                ParJuros_ao_Mes_Card_Cred.ParameterName = "@juros_ao_mes_card_cred";
                ParJuros_ao_Mes_Card_Cred.SqlDbType = SqlDbType.Decimal;
                ParJuros_ao_Mes_Card_Cred.Precision = 3;
                ParJuros_ao_Mes_Card_Cred.Scale = 2;
                ParJuros_ao_Mes_Card_Cred.Value = Config_Juros_Parcelamento.Juros_ao_Mes_Card_Cred;
                SqlCmd.Parameters.Add(ParJuros_ao_Mes_Card_Cred);

                SqlParameter ParJuros_ao_Mes_Cred_Loja = new SqlParameter();
                ParJuros_ao_Mes_Cred_Loja.ParameterName = "@juros_ao_mes_cred_loja";
                ParJuros_ao_Mes_Cred_Loja.SqlDbType = SqlDbType.Decimal;
                ParJuros_ao_Mes_Cred_Loja.Precision = 3;
                ParJuros_ao_Mes_Cred_Loja.Scale = 2;
                ParJuros_ao_Mes_Cred_Loja.Value = Config_Juros_Parcelamento.Juros_ao_Mes_Cred_Loja;
                SqlCmd.Parameters.Add(ParJuros_ao_Mes_Cred_Loja);

                SqlParameter ParHabilitar = new SqlParameter();
                ParHabilitar.ParameterName = "@habilitar";
                ParHabilitar.SqlDbType = SqlDbType.VarChar;
                ParHabilitar.Size = 3;
                ParHabilitar.Value = Config_Juros_Parcelamento.Habilitar;
                SqlCmd.Parameters.Add(ParHabilitar);

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
            DataTable DtResultado = new DataTable("config_juros_parcelamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_juros_parcelamento";
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
