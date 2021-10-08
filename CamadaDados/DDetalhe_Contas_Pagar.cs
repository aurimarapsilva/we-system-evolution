using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Contas_Pagar
    {
        private int _IdDetalhe_Contas_Pagar;
        private int _IdContas_Pagar;
        private int _Num_Parcela;
        private decimal _Valor;
        private DateTime _Vencimento;
        private string _Estado;
        private string _Obs;
        private int _IdFornecedor;

        public int IdDetalhe_Contas_Pagar
        {
            get
            {
                return _IdDetalhe_Contas_Pagar;
            }

            set
            {
                _IdDetalhe_Contas_Pagar = value;
            }
        }

        public int IdContas_Pagar
        {
            get
            {
                return _IdContas_Pagar;
            }

            set
            {
                _IdContas_Pagar = value;
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

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Obs
        {
            get
            {
                return _Obs;
            }

            set
            {
                _Obs = value;
            }
        }

        public int IdFornecedor
        {
            get
            {
                return _IdFornecedor;
            }

            set
            {
                _IdFornecedor = value;
            }
        }

        public DDetalhe_Contas_Pagar()
        {

        }


        public DDetalhe_Contas_Pagar(int iddetalhe_contas_pagar, int idcontas_pagar, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs, int idfornecedor)
        {
            this.IdDetalhe_Contas_Pagar = iddetalhe_contas_pagar;
            this.IdContas_Pagar = idcontas_pagar;
            this.Num_Parcela = num_parcela;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Estado = estado;
            this.Obs = obs;
            this.IdFornecedor = idfornecedor;
        }


        //Método Inserir Tudo
        public string Inserir_Tudo(DDetalhe_Contas_Pagar Detalhe_Contas_Pagar,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_detalhe_contas_pagar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_contas_pagar";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdContas_Pagar = new SqlParameter();
                ParIdContas_Pagar.ParameterName = "@idcontas_pagar";
                ParIdContas_Pagar.SqlDbType = SqlDbType.Int;
                ParIdContas_Pagar.Value = Detalhe_Contas_Pagar.IdContas_Pagar;
                SqlCmd.Parameters.Add(ParIdContas_Pagar);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Detalhe_Contas_Pagar.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Detalhe_Contas_Pagar.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Detalhe_Contas_Pagar.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 8;
                ParEstado.Value = Detalhe_Contas_Pagar.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParObs = new SqlParameter();
                ParObs.ParameterName = "@obs";
                ParObs.SqlDbType = SqlDbType.VarChar;
                ParObs.Size = 5;
                ParObs.Value = Detalhe_Contas_Pagar.Obs;
                SqlCmd.Parameters.Add(ParObs);

                SqlParameter ParIdFornecedor = new SqlParameter();
                ParIdFornecedor.ParameterName = "@idfornecedor";
                ParIdFornecedor.SqlDbType = SqlDbType.Int;
                ParIdFornecedor.Value = Detalhe_Contas_Pagar.IdFornecedor;
                SqlCmd.Parameters.Add(ParIdFornecedor);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";
                
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            
            return resp;
        }


        //Método Inserir Parcela
        public string Inserir_Parcela(DDetalhe_Contas_Pagar Detalhe_Contas_Pagar)
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
                SqlCmd.CommandText = "spinserir_detalhe_contas_pagar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_contas_pagar";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdContas_Pagar = new SqlParameter();
                ParIdContas_Pagar.ParameterName = "@idcontas_pagar";
                ParIdContas_Pagar.SqlDbType = SqlDbType.Int;
                ParIdContas_Pagar.Value = Detalhe_Contas_Pagar.IdContas_Pagar;
                SqlCmd.Parameters.Add(ParIdContas_Pagar);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Detalhe_Contas_Pagar.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Detalhe_Contas_Pagar.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Detalhe_Contas_Pagar.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 8;
                ParEstado.Value = Detalhe_Contas_Pagar.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParObs = new SqlParameter();
                ParObs.ParameterName = "@obs";
                ParObs.SqlDbType = SqlDbType.VarChar;
                ParObs.Size = 5;
                ParObs.Value = Detalhe_Contas_Pagar.Obs;
                SqlCmd.Parameters.Add(ParObs);

                SqlParameter ParIdFornecedor = new SqlParameter();
                ParIdFornecedor.ParameterName = "@idfornecedor";
                ParIdFornecedor.SqlDbType = SqlDbType.Int;
                ParIdFornecedor.Value = Detalhe_Contas_Pagar.IdFornecedor;
                SqlCmd.Parameters.Add(ParIdFornecedor);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";

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


        //Metodo Excluir 
        public string Excluir(DDetalhe_Contas_Pagar Detalhe_Contas_Pagar)
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
                SqlCmd.CommandText = "spdeletar_detalhe_contas_pagar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Contas_Pagar.IdDetalhe_Contas_Pagar;
                SqlCmd.Parameters.Add(ParId);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A exclusão não foi feita";

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


        //Metodo Atualizar Status Detalhe Contas Pagar
        public string Atualizar_Status_Parcelas_Contas_Pagar(DDetalhe_Contas_Pagar Detalhe_Contas_Pagar)
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
                SqlCmd.CommandText = "spatualizar_status_detalhe_contas_pagar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Contas_Pagar.IdDetalhe_Contas_Pagar;
                SqlCmd.Parameters.Add(ParId);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A edição não foi feita";

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
    }
}
