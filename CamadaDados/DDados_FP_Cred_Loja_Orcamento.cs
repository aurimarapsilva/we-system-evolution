using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDados_FP_Cred_Loja_Orcamento
    {
        private int _ID;
        private int _IdOrcamento;
        private int _Num_Parcela;
        private decimal _Valor;
        private DateTime _Vencimento;

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

        public int Num_Parcela
        {
            get
            {
                return _Num_Parcela;
            }

            set
            {
                _Num_Parcela = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return _Valor;
            }

            set
            {
                _Valor = value;
            }
        }

        public DateTime Vencimento
        {
            get
            {
                return _Vencimento;
            }

            set
            {
                _Vencimento = value;
            }
        }

        public DDados_FP_Cred_Loja_Orcamento()
        {

        }

        public DDados_FP_Cred_Loja_Orcamento(int id, int idorcamento, int num_parcela, decimal valor, DateTime vencimento)
        {
            this.ID = id;
            this.IdOrcamento = idorcamento;
            this.Num_Parcela = num_parcela;
            this.Valor = valor;
            this.Vencimento = vencimento;
        }

        //Metodo Inserir 
        public string Inserir(DDados_FP_Cred_Loja_Orcamento Dados_FP_Cred_Loja_Orcamento)
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
                SqlCmd.CommandText = "spinserir_dados_fp_cred_loja_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idorcamento_dados_fp_cred_loja";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOrcamento = new SqlParameter();
                ParIdOrcamento.ParameterName = "@idorcamento";
                ParIdOrcamento.SqlDbType = SqlDbType.Int;
                ParIdOrcamento.Value = Dados_FP_Cred_Loja_Orcamento.IdOrcamento;
                SqlCmd.Parameters.Add(ParIdOrcamento);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Dados_FP_Cred_Loja_Orcamento.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Dados_FP_Cred_Loja_Orcamento.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Dados_FP_Cred_Loja_Orcamento.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);
                
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
            DataTable DtResultado = new DataTable("orcamento_dados_fp_cred_loja");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_dados_fp_cred_loja_orcamento";
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
