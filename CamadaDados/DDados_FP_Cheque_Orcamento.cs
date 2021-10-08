using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDados_FP_Cheque_Orcamento
    {
        private int _ID;
        private int _IdOrcamento;
        private DateTime _Data;
        private string _Banco_Emissor;
        private string _Nome_Titular;
        private string _Num_Cheque;
        private string _Num_parcela;
        private decimal _Valor;
        private DateTime _Depositar_Dia;

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

        public DateTime Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }

        public string Banco_Emissor
        {
            get
            {
                return _Banco_Emissor;
            }

            set
            {
                _Banco_Emissor = value;
            }
        }

        public string Nome_Titular
        {
            get
            {
                return _Nome_Titular;
            }

            set
            {
                _Nome_Titular = value;
            }
        }

        public string Num_Cheque
        {
            get
            {
                return _Num_Cheque;
            }

            set
            {
                _Num_Cheque = value;
            }
        }

        public string Num_parcela
        {
            get
            {
                return _Num_parcela;
            }

            set
            {
                _Num_parcela = value;
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

        public DateTime Depositar_Dia
        {
            get
            {
                return _Depositar_Dia;
            }

            set
            {
                _Depositar_Dia = value;
            }
        }

        public DDados_FP_Cheque_Orcamento()
        {

        }

        public DDados_FP_Cheque_Orcamento(int id, int idorcamento, DateTime data, string banco_emissor, string nome_titular, string num_cheque, string num_parcela, decimal valor, DateTime depositar_dia)
        {
            this.ID = id;
            this.IdOrcamento = idorcamento;
            this.Data = data;
            this.Banco_Emissor = banco_emissor;
            this.Nome_Titular = nome_titular;
            this.Num_Cheque = num_cheque;
            this.Num_parcela = num_parcela;
            this.Valor = valor;
            this.Depositar_Dia = depositar_dia;
        }

        //Metodo Inserir 
        public string Inserir(DDados_FP_Cheque_Orcamento Dados_FP_Cheque_Orcamento)
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
                SqlCmd.CommandText = "spinserir_dados_fp_cheque_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idorcamento_dados_fp_cheque";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOrcamento = new SqlParameter();
                ParIdOrcamento.ParameterName = "@idorcamento";
                ParIdOrcamento.SqlDbType = SqlDbType.Int;
                ParIdOrcamento.Value = Dados_FP_Cheque_Orcamento.IdOrcamento;
                SqlCmd.Parameters.Add(ParIdOrcamento);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Dados_FP_Cheque_Orcamento.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParBanco_Emissor = new SqlParameter();
                ParBanco_Emissor.ParameterName = "@banco_emissor";
                ParBanco_Emissor.SqlDbType = SqlDbType.VarChar;
                ParBanco_Emissor.Size = 20;
                ParBanco_Emissor.Value = Dados_FP_Cheque_Orcamento.Banco_Emissor;
                SqlCmd.Parameters.Add(ParBanco_Emissor);

                SqlParameter ParNome_Titular = new SqlParameter();
                ParNome_Titular.ParameterName = "@nome_titular";
                ParNome_Titular.SqlDbType = SqlDbType.VarChar;
                ParNome_Titular.Size = 20;
                ParNome_Titular.Value = Dados_FP_Cheque_Orcamento.Nome_Titular;
                SqlCmd.Parameters.Add(ParNome_Titular);

                SqlParameter ParNum_Cheque = new SqlParameter();
                ParNum_Cheque.ParameterName = "@num_cheque";
                ParNum_Cheque.SqlDbType = SqlDbType.VarChar;
                ParNum_Cheque.Size = 20;
                ParNum_Cheque.Value = Dados_FP_Cheque_Orcamento.Num_Cheque;
                SqlCmd.Parameters.Add(ParNum_Cheque);

                SqlParameter ParNum_parcela = new SqlParameter();
                ParNum_parcela.ParameterName = "@num_parcela";
                ParNum_parcela.SqlDbType = SqlDbType.VarChar;
                ParNum_parcela.Size = 20;
                ParNum_parcela.Value = Dados_FP_Cheque_Orcamento.Num_parcela;
                SqlCmd.Parameters.Add(ParNum_parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Dados_FP_Cheque_Orcamento.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParDepositar_Dia = new SqlParameter();
                ParDepositar_Dia.ParameterName = "@depositar_dia";
                ParDepositar_Dia.SqlDbType = SqlDbType.Date;
                ParDepositar_Dia.Value = Dados_FP_Cheque_Orcamento.Depositar_Dia;
                SqlCmd.Parameters.Add(ParDepositar_Dia);

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
            DataTable DtResultado = new DataTable("orcamento_dados_fp_cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_dados_fp_cheque_orcamento";
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
