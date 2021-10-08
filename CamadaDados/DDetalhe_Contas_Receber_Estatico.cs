using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Contas_Receber_Estatico
    {
        private int _IdDetalhe_Contas_Receber_Estatico;
        private int _IdVenda;
        private int _IdCliente;
        private int _Num_Parcela;
        private decimal _Valor;
        private DateTime _Vencimento;
        private string _Estado;
        private string _Obs;

        public int IdDetalhe_Contas_Receber_Estatico
        {
            get
            {
                return _IdDetalhe_Contas_Receber_Estatico;
            }

            set
            {
                _IdDetalhe_Contas_Receber_Estatico = value;
            }
        }

        public int IdVenda
        {
            get
            {
                return _IdVenda;
            }

            set
            {
                _IdVenda = value;
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

        
        public DDetalhe_Contas_Receber_Estatico()
        {

        }


        public DDetalhe_Contas_Receber_Estatico(int iddetalhe_contas_receber_estatico, int idvenda, int idcliente, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs)
        {
            this.IdDetalhe_Contas_Receber_Estatico = iddetalhe_contas_receber_estatico;
            this.IdVenda = idvenda;
            this.IdCliente = idcliente;
            this.Num_Parcela = num_parcela;
            this.Valor = valor;
            this.Vencimento = vencimento;
            this.Estado = estado;
            this.Obs = obs;
        }


        //Método Inserir Somente Parcela
        public string Inserir(DDetalhe_Contas_Receber_Estatico Detalhe_Contas_Receber_Estatico)
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
                SqlCmd.CommandText = "spinserir_detalhe_contas_receber_estatico";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_contas_receber_estatico";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Detalhe_Contas_Receber_Estatico.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);
                
                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Detalhe_Contas_Receber_Estatico.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParNum_Parcela = new SqlParameter();
                ParNum_Parcela.ParameterName = "@num_parcela";
                ParNum_Parcela.SqlDbType = SqlDbType.Int;
                ParNum_Parcela.Value = Detalhe_Contas_Receber_Estatico.Num_Parcela;
                SqlCmd.Parameters.Add(ParNum_Parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Detalhe_Contas_Receber_Estatico.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.Date;
                ParVencimento.Value = Detalhe_Contas_Receber_Estatico.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 8;
                ParEstado.Value = Detalhe_Contas_Receber_Estatico.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParObs = new SqlParameter();
                ParObs.ParameterName = "@obs";
                ParObs.SqlDbType = SqlDbType.VarChar;
                ParObs.Size = 5;
                ParObs.Value = Detalhe_Contas_Receber_Estatico.Obs;
                SqlCmd.Parameters.Add(ParObs);

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
    }
}
