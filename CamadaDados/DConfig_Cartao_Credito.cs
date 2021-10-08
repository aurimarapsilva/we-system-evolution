using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_Cartao_Credito
    {
        private int _IdConfig_Cartao_Credito;
        private string _Bandeira;
        private int _Prazo_Compens_1_Parc;
        private int _Prazo_Compens_Demais_Parc;
        private decimal _Taxa;
        

        public int IdConfig_Cartao_Credito
        {
            get
            {
                return _IdConfig_Cartao_Credito;
            }

            set
            {
                _IdConfig_Cartao_Credito = value;
            }
        }

        public string Bandeira
        {
            get
            {
                return _Bandeira;
            }

            set
            {
                _Bandeira = value;
            }
        }

        public int Prazo_Compens_1_Parc
        {
            get
            {
                return _Prazo_Compens_1_Parc;
            }

            set
            {
                _Prazo_Compens_1_Parc = value;
            }
        }

        public int Prazo_Compens_Demais_Parc
        {
            get
            {
                return _Prazo_Compens_Demais_Parc;
            }

            set
            {
                _Prazo_Compens_Demais_Parc = value;
            }
        }

        public decimal Taxa
        {
            get
            {
                return _Taxa;
            }

            set
            {
                _Taxa = value;
            }
        }


        

        public DConfig_Cartao_Credito()
        {

        }


        public DConfig_Cartao_Credito(int idconfig_cartao_credito, string bandeira, int prazo_compens_1_parc, int prazo_compens_demais_parc, decimal taxa)
        {
            this.IdConfig_Cartao_Credito = idconfig_cartao_credito;
            this.Bandeira = bandeira;
            this.Prazo_Compens_1_Parc = prazo_compens_1_parc;
            this.Prazo_Compens_Demais_Parc = prazo_compens_demais_parc;
            this.Taxa = taxa;
        }


        //Metodo Inserir 
        public string Inserir(DConfig_Cartao_Credito Config_Cartao_Credito)
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
                SqlCmd.CommandText = "spinserir_config_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idconfig_cartao_credito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Config_Cartao_Credito.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParPrazo_Compens_1_Parc = new SqlParameter();
                ParPrazo_Compens_1_Parc.ParameterName = "@prazo_compens_1_parc";
                ParPrazo_Compens_1_Parc.SqlDbType = SqlDbType.Int;
                ParPrazo_Compens_1_Parc.Value = Config_Cartao_Credito.Prazo_Compens_1_Parc;
                SqlCmd.Parameters.Add(ParPrazo_Compens_1_Parc);

                SqlParameter ParPrazo_Compens_Demais_Parc = new SqlParameter();
                ParPrazo_Compens_Demais_Parc.ParameterName = "@prazo_compens_demais_parc";
                ParPrazo_Compens_Demais_Parc.SqlDbType = SqlDbType.Int;
                ParPrazo_Compens_Demais_Parc.Value = Config_Cartao_Credito.Prazo_Compens_Demais_Parc;
                SqlCmd.Parameters.Add(ParPrazo_Compens_Demais_Parc);

                SqlParameter ParTaxa = new SqlParameter();
                ParTaxa.ParameterName = "@taxa";
                ParTaxa.SqlDbType = SqlDbType.Decimal;
                ParTaxa.Precision = 5;
                ParTaxa.Scale = 2;
                ParTaxa.Value = Config_Cartao_Credito.Taxa;
                SqlCmd.Parameters.Add(ParTaxa);

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
        public string Editar(DConfig_Cartao_Credito Config_Cartao_Credito)
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
                SqlCmd.CommandText = "speditar_config_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idconfig_cartao_credito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Config_Cartao_Credito.IdConfig_Cartao_Credito;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Config_Cartao_Credito.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParPrazo_Compens_1_Parc = new SqlParameter();
                ParPrazo_Compens_1_Parc.ParameterName = "@prazo_compens_1_parc";
                ParPrazo_Compens_1_Parc.SqlDbType = SqlDbType.Int;
                ParPrazo_Compens_1_Parc.Value = Config_Cartao_Credito.Prazo_Compens_1_Parc;
                SqlCmd.Parameters.Add(ParPrazo_Compens_1_Parc);

                SqlParameter ParPrazo_Compens_Demais_Parc = new SqlParameter();
                ParPrazo_Compens_Demais_Parc.ParameterName = "@prazo_compens_demais_parc";
                ParPrazo_Compens_Demais_Parc.SqlDbType = SqlDbType.Int;
                ParPrazo_Compens_Demais_Parc.Value = Config_Cartao_Credito.Prazo_Compens_Demais_Parc;
                SqlCmd.Parameters.Add(ParPrazo_Compens_Demais_Parc);

                SqlParameter ParTaxa = new SqlParameter();
                ParTaxa.ParameterName = "@taxa";
                ParTaxa.SqlDbType = SqlDbType.Decimal;
                ParTaxa.Precision = 5;
                ParTaxa.Scale = 2;
                ParTaxa.Value = Config_Cartao_Credito.Taxa;
                SqlCmd.Parameters.Add(ParTaxa);

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
            DataTable DtResultado = new DataTable("config_cartao_credito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_cartao_credito";
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
