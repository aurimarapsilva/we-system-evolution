using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DForma_Pagamento
    {
        private int _IdPagamento;
        private int _IdVenda;
        private string _Forma;
        private decimal _Valor_Primario;
        private decimal _Valor_Final;

        public int IdPagamento
        {
            get
            {
                return _IdPagamento;
            }

            set
            {
                _IdPagamento = value;
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

        public string Forma
        {
            get
            {
                return _Forma;
            }

            set
            {
                _Forma = value;
            }
        }

        public decimal Valor_Primario
        {
            get
            {
                return _Valor_Primario;
            }

            set
            {
                _Valor_Primario = value;
            }
        }

        public decimal Valor_Final
        {
            get
            {
                return _Valor_Final;
            }

            set
            {
                _Valor_Final = value;
            }
        }

        public DForma_Pagamento()
        {

        }

        public DForma_Pagamento(int idpagamento, int idvenda, string forma, decimal valor_primario, decimal valor_final)
        {
            this.IdPagamento = idpagamento;
            this.IdVenda = idvenda;
            this.Forma = forma;
            this.Valor_Primario = valor_primario;
            this.Valor_Final = valor_final;
        }

        //Método Inserir
        public string Inserir(DForma_Pagamento Forma_Pagamento,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_forma_pgto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idpagamento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Forma_Pagamento.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);

                SqlParameter ParForma = new SqlParameter();
                ParForma.ParameterName = "@forma";
                ParForma.SqlDbType = SqlDbType.VarChar;
                ParForma.Size = 30;
                ParForma.Value = Forma_Pagamento.Forma;
                SqlCmd.Parameters.Add(ParForma);

                SqlParameter ParValor_Primario = new SqlParameter();
                ParValor_Primario.ParameterName = "@valor_primario";
                ParValor_Primario.SqlDbType = SqlDbType.Decimal;
                ParValor_Primario.Precision = 7;
                ParValor_Primario.Scale = 2;
                ParValor_Primario.Value = Forma_Pagamento.Valor_Primario;
                SqlCmd.Parameters.Add(ParValor_Primario);

                SqlParameter ParValor_Final = new SqlParameter();
                ParValor_Final.ParameterName = "@valor_final";
                ParValor_Final.SqlDbType = SqlDbType.Decimal;
                ParValor_Final.Precision = 7;
                ParValor_Final.Scale = 2;
                ParValor_Final.Value = Forma_Pagamento.Valor_Final;
                SqlCmd.Parameters.Add(ParValor_Final);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            
            return resp;
        }
    }
}
