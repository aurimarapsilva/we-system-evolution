using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_Juros_Atraso
    {
        private int _IdConfig_Juros_Atrso;
        private decimal _Juros_Diario;
        private decimal _Multa;
        private string _Habilitar;

        public int IdConfig_Juros_Atrso
        {
            get
            {
                return _IdConfig_Juros_Atrso;
            }

            set
            {
                _IdConfig_Juros_Atrso = value;
            }
        }

        public decimal Juros_Diario
        {
            get
            {
                return _Juros_Diario;
            }

            set
            {
                _Juros_Diario = value;
            }
        }

        public decimal Multa
        {
            get
            {
                return _Multa;
            }

            set
            {
                _Multa = value;
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

        public DConfig_Juros_Atraso()
        {

        }

        public DConfig_Juros_Atraso(int idconfig_juros_atraso, decimal juros_diario, decimal multa, string habilitar)
        {
            this.IdConfig_Juros_Atrso = idconfig_juros_atraso;
            this.Juros_Diario = juros_diario;
            this.Multa = multa;
            this.Habilitar = habilitar;
        }


        //Metodo Editar 
        public string Editar(DConfig_Juros_Atraso Config_Juros_Atraso)
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
                SqlCmd.CommandText = "speditar_config_juros_atraso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParJuros_Diario = new SqlParameter();
                ParJuros_Diario.ParameterName = "@juros_diario";
                ParJuros_Diario.SqlDbType = SqlDbType.Decimal;
                ParJuros_Diario.Precision = 3;
                ParJuros_Diario.Scale = 2;
                ParJuros_Diario.Value = Config_Juros_Atraso.Juros_Diario;
                SqlCmd.Parameters.Add(ParJuros_Diario);

                SqlParameter ParMulta = new SqlParameter();
                ParMulta.ParameterName = "@multa";
                ParMulta.SqlDbType = SqlDbType.Decimal;
                ParMulta.Precision = 3;
                ParMulta.Scale = 2;
                ParMulta.Value = Config_Juros_Atraso.Multa;
                SqlCmd.Parameters.Add(ParMulta);

                SqlParameter ParHabilitar = new SqlParameter();
                ParHabilitar.ParameterName = "@habilitar";
                ParHabilitar.SqlDbType = SqlDbType.VarChar;
                ParHabilitar.Size = 3;
                ParHabilitar.Value = Config_Juros_Atraso.Habilitar;
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
            DataTable DtResultado = new DataTable("config_juros_atraso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_juros_atraso";
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
