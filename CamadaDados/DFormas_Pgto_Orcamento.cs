using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFormas_Pgto_Orcamento
    {
        private int _IdFormas_Pgto_Orcamento;
        private int _IdOrcamento;
        private string _Forma;
        private decimal _Valor_Primario;
        private decimal _Valor_Final;
        private int _Qtd_Parcelas;

        public int IdFormas_Pgto_Orcamento
        {
            get
            {
                return _IdFormas_Pgto_Orcamento;
            }

            set
            {
                _IdFormas_Pgto_Orcamento = value;
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

        public DFormas_Pgto_Orcamento()
        {

        }

        public DFormas_Pgto_Orcamento(int idformas_pgto_orcamento, int idorcamento, string forma, decimal valor_primario, decimal valor_final, int qtd_parcelas)
        {
            this.IdFormas_Pgto_Orcamento = idformas_pgto_orcamento;
            this.IdOrcamento = idorcamento;
            this.Forma = forma;
            this.Valor_Primario = valor_primario;
            this.Valor_Final = valor_final;
            this.Qtd_Parcelas = qtd_parcelas;
        }


        //Método Inserir
        public string Inserir(DFormas_Pgto_Orcamento Formas_Pgto_Orcamento,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_formas_pgto_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idformas_pgto_orcamento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOrcamento = new SqlParameter();
                ParIdOrcamento.ParameterName = "@idorcamento";
                ParIdOrcamento.SqlDbType = SqlDbType.Int;
                ParIdOrcamento.Value = Formas_Pgto_Orcamento.IdOrcamento;
                SqlCmd.Parameters.Add(ParIdOrcamento);

                SqlParameter ParForma = new SqlParameter();
                ParForma.ParameterName = "@forma";
                ParForma.SqlDbType = SqlDbType.VarChar;
                ParForma.Size = 30;
                ParForma.Value = Formas_Pgto_Orcamento.Forma;
                SqlCmd.Parameters.Add(ParForma);

                SqlParameter ParValor_Primario = new SqlParameter();
                ParValor_Primario.ParameterName = "@valor_primario";
                ParValor_Primario.SqlDbType = SqlDbType.Decimal;
                ParValor_Primario.Precision = 7;
                ParValor_Primario.Scale = 2;
                ParValor_Primario.Value = Formas_Pgto_Orcamento.Valor_Primario;
                SqlCmd.Parameters.Add(ParValor_Primario);

                SqlParameter ParValor_Final = new SqlParameter();
                ParValor_Final.ParameterName = "@valor_final";
                ParValor_Final.SqlDbType = SqlDbType.Decimal;
                ParValor_Final.Precision = 7;
                ParValor_Final.Scale = 2;
                ParValor_Final.Value = Formas_Pgto_Orcamento.Valor_Final;
                SqlCmd.Parameters.Add(ParValor_Final);

                SqlParameter ParQtd_Parcelas = new SqlParameter();
                ParQtd_Parcelas.ParameterName = "@qtd_parcelas";
                ParQtd_Parcelas.SqlDbType = SqlDbType.Int;
                ParQtd_Parcelas.Value = Formas_Pgto_Orcamento.Qtd_Parcelas;
                SqlCmd.Parameters.Add(ParQtd_Parcelas);

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
