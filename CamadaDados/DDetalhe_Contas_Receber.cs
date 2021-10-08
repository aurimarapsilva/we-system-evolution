using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Contas_Receber
    {
        private int _IdDetalhe_Contas_Receber;
        private int _IdContas_Receber;
        private int _IdCliente;
        private int _Num_Parcela;
        private decimal _Valor;
        private DateTime _Vencimento;
        private string _Estado;
        private string _Obs;
        private decimal _Valor_Atualizado;

        public int IdDetalhe_Contas_Receber
        {
            get
            {
                return _IdDetalhe_Contas_Receber;
            }

            set
            {
                _IdDetalhe_Contas_Receber = value;
            }
        }

        public int IdContas_Receber
        {
            get
            {
                return _IdContas_Receber;
            }

            set
            {
                _IdContas_Receber = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }

            set
            {
                _IdCliente = value;
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

        public decimal Valor_Atualizado
        {
            get
            {
                return _Valor_Atualizado;
            }

            set
            {
                _Valor_Atualizado = value;
            }
        }

        public DDetalhe_Contas_Receber()
        {

        }


        public DDetalhe_Contas_Receber(int iddetalhe_contas_receber, int idcontas_receber, int idcliente, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs, decimal valor_atualizado)
        {
            this.IdDetalhe_Contas_Receber = iddetalhe_contas_receber;
            this.IdContas_Receber = idcontas_receber;
            this.IdCliente = idcliente;
            this.Num_Parcela = num_parcela;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Estado = estado;
            this.Obs = obs;
            this.Valor_Atualizado = valor_atualizado;
        }


        //Método Inserir Tudo Junto
        public string Inserir_Tudo(DDetalhe_Contas_Receber Detalhe_Contas_Receber,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_detalhe_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_contas_receber";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdContas_Receber = new SqlParameter();
                ParIdContas_Receber.ParameterName = "@idcontas_receber";
                ParIdContas_Receber.SqlDbType = SqlDbType.Int;
                ParIdContas_Receber.Value = Detalhe_Contas_Receber.IdContas_Receber;
                SqlCmd.Parameters.Add(ParIdContas_Receber);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Detalhe_Contas_Receber.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Detalhe_Contas_Receber.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Detalhe_Contas_Receber.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Detalhe_Contas_Receber.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 8;
                ParEstado.Value = Detalhe_Contas_Receber.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParObs = new SqlParameter();
                ParObs.ParameterName = "@obs";
                ParObs.SqlDbType = SqlDbType.VarChar;
                ParObs.Size = 5;
                ParObs.Value = Detalhe_Contas_Receber.Obs;
                SqlCmd.Parameters.Add(ParObs);

                SqlParameter ParValor_Atualizado = new SqlParameter();
                ParValor_Atualizado.ParameterName = "@valor_atualizado";
                ParValor_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Atualizado.Precision = 7;
                ParValor_Atualizado.Scale = 2;
                ParValor_Atualizado.Value = Detalhe_Contas_Receber.Valor_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Atualizado);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }


            return resp;

        }


        //Método Inserir Somente Parcela
        public string Inserir_Parcela(DDetalhe_Contas_Receber Detalhe_Contas_Receber)
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
                SqlCmd.CommandText = "spinserir_detalhe_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_contas_receber";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdContas_Receber = new SqlParameter();
                ParIdContas_Receber.ParameterName = "@idcontas_receber";
                ParIdContas_Receber.SqlDbType = SqlDbType.Int;
                ParIdContas_Receber.Value = Detalhe_Contas_Receber.IdContas_Receber;
                SqlCmd.Parameters.Add(ParIdContas_Receber);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Detalhe_Contas_Receber.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Detalhe_Contas_Receber.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Detalhe_Contas_Receber.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Detalhe_Contas_Receber.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 8;
                ParEstado.Value = Detalhe_Contas_Receber.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParObs = new SqlParameter();
                ParObs.ParameterName = "@obs";
                ParObs.SqlDbType = SqlDbType.VarChar;
                ParObs.Size = 5;
                ParObs.Value = Detalhe_Contas_Receber.Obs;
                SqlCmd.Parameters.Add(ParObs);

                SqlParameter ParValor_Atualizado = new SqlParameter();
                ParValor_Atualizado.ParameterName = "@valor_atualizado";
                ParValor_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Atualizado.Precision = 7;
                ParValor_Atualizado.Scale = 2;
                ParValor_Atualizado.Value = Detalhe_Contas_Receber.Valor_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Atualizado);

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
        public string Excluir(DDetalhe_Contas_Receber Detalhe_Contas_Receber)
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
                SqlCmd.CommandText = "spdeletar_detalhe_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Contas_Receber.IdDetalhe_Contas_Receber;
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


        //Metodo Atualizar Status Detalhe Contas Receber
        public string Atualizar_Status_Parcelas_Contas_Receber(DDetalhe_Contas_Receber Detalhe_Contas_Receber)
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
                SqlCmd.CommandText = "spatualizar_status_detalhe_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Contas_Receber.IdDetalhe_Contas_Receber;
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


        //Metodo Atualizar Valor Detalhe Contas Receber
        public string Atualizar_Valor_Detalhe_Contas_Receber(DDetalhe_Contas_Receber Detalhe_Contas_Receber)
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
                SqlCmd.CommandText = "spatualizar_valor_detalhe_contas_receber";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Detalhe_Contas_Receber.IdDetalhe_Contas_Receber;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParValor_Atualizado = new SqlParameter();
                ParValor_Atualizado.ParameterName = "@valor_atualizado";
                ParValor_Atualizado.SqlDbType = SqlDbType.Decimal;
                ParValor_Atualizado.Precision = 7;
                ParValor_Atualizado.Scale = 2;
                ParValor_Atualizado.Value = Detalhe_Contas_Receber.Valor_Atualizado;
                SqlCmd.Parameters.Add(ParValor_Atualizado);

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
