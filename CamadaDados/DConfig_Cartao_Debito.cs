using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DConfig_Cartao_Debito
    {
        private int _IdConfig_Cartao_Debito;
        private string _Bandeira;
        private int _Prazo_Compensacao;
        private decimal _Taxa;

        public int IdConfig_Cartao_Debito
        {
            get
            {
                return _IdConfig_Cartao_Debito;
            }

            set
            {
                _IdConfig_Cartao_Debito = value;
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

        public int Prazo_Compensacao
        {
            get
            {
                return _Prazo_Compensacao;
            }

            set
            {
                _Prazo_Compensacao = value;
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


        public DConfig_Cartao_Debito()
        {

        }

        public DConfig_Cartao_Debito(int idconfig_cartao_debito, string bandeira, int prazo_compensacao, decimal taxa)
        {
            this.IdConfig_Cartao_Debito = idconfig_cartao_debito;
            this.Bandeira = bandeira;
            this.Prazo_Compensacao = prazo_compensacao;
            this.Taxa = taxa;
        }


        //Metodo Inserir 
        public string Inserir(DConfig_Cartao_Debito Config_Cartao_Debito)
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
                SqlCmd.CommandText = "spinserir_config_cartao_debito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idconfig_cartao_debito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Config_Cartao_Debito.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParPrazo_Compensacao = new SqlParameter();
                ParPrazo_Compensacao.ParameterName = "@prazo_compensacao";
                ParPrazo_Compensacao.SqlDbType = SqlDbType.Int;
                ParPrazo_Compensacao.Value = Config_Cartao_Debito.Prazo_Compensacao;
                SqlCmd.Parameters.Add(ParPrazo_Compensacao);
                
                SqlParameter ParTaxa = new SqlParameter();
                ParTaxa.ParameterName = "@taxa";
                ParTaxa.SqlDbType = SqlDbType.Decimal;
                ParTaxa.Precision = 5;
                ParTaxa.Scale = 2;
                ParTaxa.Value = Config_Cartao_Debito.Taxa;
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
        public string Editar(DConfig_Cartao_Debito Config_Cartao_Debito)
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
                SqlCmd.CommandText = "speditar_config_cartao_debito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idconfig_cartao_debito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Config_Cartao_Debito.IdConfig_Cartao_Debito;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Config_Cartao_Debito.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParPrazo_Compensacao = new SqlParameter();
                ParPrazo_Compensacao.ParameterName = "@prazo_compensacao";
                ParPrazo_Compensacao.SqlDbType = SqlDbType.Int;
                ParPrazo_Compensacao.Value = Config_Cartao_Debito.Prazo_Compensacao;
                SqlCmd.Parameters.Add(ParPrazo_Compensacao);

                SqlParameter ParTaxa = new SqlParameter();
                ParTaxa.ParameterName = "@taxa";
                ParTaxa.SqlDbType = SqlDbType.Decimal;
                ParTaxa.Precision = 5;
                ParTaxa.Scale = 2;
                ParTaxa.Value = Config_Cartao_Debito.Taxa;
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
            DataTable DtResultado = new DataTable("config_cartao_debito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_config_cartao_debito";
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
