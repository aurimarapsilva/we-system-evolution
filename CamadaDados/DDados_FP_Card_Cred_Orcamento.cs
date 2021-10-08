using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDados_FP_Card_Cred_Orcamento
    {
        private int _ID;
        private int _IdOrcamento;
        private string _Bandeira;
        private decimal _Valor_Parcelas;
        private int _Qtd_Parcelas;
       
        public int ID
        {
            get
            {
                return _ID;
            }

            set
            {
                _ID = value;
            }
        }

        public int IdOrcamento
        {
            get
            {
                return _IdOrcamento;
            }

            set
            {
                _IdOrcamento = value;
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

        public decimal Valor_Parcelas
        {
            get
            {
                return _Valor_Parcelas;
            }

            set
            {
                _Valor_Parcelas = value;
            }
        }

        public int Qtd_Parcelas
        {
            get
            {
                return _Qtd_Parcelas;
            }

            set
            {
                _Qtd_Parcelas = value;
            }
        }


        public DDados_FP_Card_Cred_Orcamento()
        {

        }

        public DDados_FP_Card_Cred_Orcamento(int id, int idorcamento, string bandeira, decimal valor_parcelas, int qtd_parcelas)
        {
            this.ID = id;
            this.IdOrcamento = idorcamento;
            this.Bandeira = bandeira;
            this.Valor_Parcelas = valor_parcelas;
            this.Qtd_Parcelas = qtd_parcelas;
        }

        //Metodo Inserir 
        public string Inserir(DDados_FP_Card_Cred_Orcamento Dados_FP_Card_Cred_Orcamento)
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
                SqlCmd.CommandText = "spinserir_dados_fp_card_cred_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idorcamento_dados_fp_card_cred";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOrcamento = new SqlParameter();
                ParIdOrcamento.ParameterName = "@idorcamento";
                ParIdOrcamento.SqlDbType = SqlDbType.Int;
                ParIdOrcamento.Value = Dados_FP_Card_Cred_Orcamento.IdOrcamento;
                SqlCmd.Parameters.Add(ParIdOrcamento);

                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Dados_FP_Card_Cred_Orcamento.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParValor_Parcelas = new SqlParameter();
                ParValor_Parcelas.ParameterName = "@valor_parcelas";
                ParValor_Parcelas.SqlDbType = SqlDbType.Decimal;
                ParValor_Parcelas.Precision = 7;
                ParValor_Parcelas.Scale = 2;
                ParValor_Parcelas.Value = Dados_FP_Card_Cred_Orcamento.Valor_Parcelas;
                SqlCmd.Parameters.Add(ParValor_Parcelas);

                SqlParameter ParQtd_Parcelas = new SqlParameter();
                ParQtd_Parcelas.ParameterName = "@qtd_parcelas";
                ParQtd_Parcelas.SqlDbType = SqlDbType.Int;
                ParQtd_Parcelas.Value = Dados_FP_Card_Cred_Orcamento.Qtd_Parcelas;
                SqlCmd.Parameters.Add(ParQtd_Parcelas);
                
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


        //Método Mostrar 
        public DataTable Mostrar(int IDORCAMENTO)
        {
            DataTable DtResultado = new DataTable("orcamento_dados_fp_card_cred");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_dados_fp_card_cred_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDORCAMENTO = new SqlParameter();
                ParIDORCAMENTO.ParameterName = "@idorcamento";
                ParIDORCAMENTO.SqlDbType = SqlDbType.Int;
                ParIDORCAMENTO.Value = IDORCAMENTO;
                SqlCmd.Parameters.Add(ParIDORCAMENTO);

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
