using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCartao_Credito
    {
        private int _IdCartao_Credito;
        private string _Bandeira;
        private DateTime _Data;
        private int _IdVenda;
        private int _IdGuiche_Atendimento;
        private int _IdFuncionario;
        private string _Num_parcela;
        private decimal _Valor;
        private decimal _Valor_Liquido;
        private DateTime _Data_Compensacao;

        public int IdCartao_Credito
        {
            get
            {
                return _IdCartao_Credito;
            }

            set
            {
                _IdCartao_Credito = value;
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

        public int IdGuiche_Atendimento
        {
            get
            {
                return _IdGuiche_Atendimento;
            }

            set
            {
                _IdGuiche_Atendimento = value;
            }
        }

        public int IdFuncionario
        {
            get
            {
                return _IdFuncionario;
            }

            set
            {
                _IdFuncionario = value;
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

        public decimal Valor_Liquido
        {
            get
            {
                return _Valor_Liquido;
            }

            set
            {
                _Valor_Liquido = value;
            }
        }

        public DateTime Data_Compensacao
        {
            get
            {
                return _Data_Compensacao;
            }

            set
            {
                _Data_Compensacao = value;
            }
        }

        

        public DCartao_Credito()
        {

        }

        public DCartao_Credito(int idcartao_credito, string bandeira, DateTime data, int idvenda, int idguiche_atendimento, int idfuncionario, string num_parcela, decimal valor, decimal valor_liquido, DateTime data_compensacao)
        {
            this.IdCartao_Credito = idcartao_credito;
            this.Bandeira = bandeira;
            this.Data = data;
            this.IdVenda = idvenda;
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.IdFuncionario = idfuncionario;
            this.Num_parcela = num_parcela;
            this.Valor = valor;
            this.Valor_Liquido = valor_liquido;
            this.Data_Compensacao = data_compensacao;
        }

        //Metodo Inserir 
        public string Inserir(DCartao_Credito Cartao_Credito)
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
                SqlCmd.CommandText = "spinserir_controle_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcartao_credito";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
               
                SqlParameter ParBandeira = new SqlParameter();
                ParBandeira.ParameterName = "@bandeira";
                ParBandeira.SqlDbType = SqlDbType.VarChar;
                ParBandeira.Size = 20;
                ParBandeira.Value = Cartao_Credito.Bandeira;
                SqlCmd.Parameters.Add(ParBandeira);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Cartao_Credito.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Cartao_Credito.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);

                SqlParameter ParIdGuiche_Atendimento = new SqlParameter();
                ParIdGuiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdGuiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdGuiche_Atendimento.Value = Cartao_Credito.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdGuiche_Atendimento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Cartao_Credito.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNum_parcela = new SqlParameter();
                ParNum_parcela.ParameterName = "@num_parcela";
                ParNum_parcela.SqlDbType = SqlDbType.VarChar;
                ParNum_parcela.Size = 20;
                ParNum_parcela.Value = Cartao_Credito.Num_parcela;
                SqlCmd.Parameters.Add(ParNum_parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Cartao_Credito.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParValor_Liquido = new SqlParameter();
                ParValor_Liquido.ParameterName = "@valor_liquido";
                ParValor_Liquido.SqlDbType = SqlDbType.Decimal;
                ParValor_Liquido.Precision = 7;
                ParValor_Liquido.Scale = 2;
                ParValor_Liquido.Value = Cartao_Credito.Valor_Liquido;
                SqlCmd.Parameters.Add(ParValor_Liquido);

                SqlParameter ParData_Compensacao = new SqlParameter();
                ParData_Compensacao.ParameterName = "@data_compensacao";
                ParData_Compensacao.SqlDbType = SqlDbType.Date;
                ParData_Compensacao.Value = Cartao_Credito.Data_Compensacao;
                SqlCmd.Parameters.Add(ParData_Compensacao);

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

        //Metodo Excluir 
        public string Excluir(DCartao_Credito Cartao_Credito)
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
                SqlCmd.CommandText = "spdeletar_cartao_credito";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cartao_Credito.IdCartao_Credito;
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


        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("cartao_credito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cartao_credito";
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

        //Metodo Mostrar Cartao Credito Compensar
        public DataTable Mostrar_Cartao_Credito_Compensar(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("cartao_credito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cartao_credito_para_compensar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Cartao Credito por Datas
        public DataTable Buscar_Datas(string Data_Inicial, string Data_Final)
        {
            DataTable DtResultado = new DataTable("cartao_credito");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cartao_credito_datas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Inicial = new SqlParameter();
                ParData_Inicial.ParameterName = "@datainicial";
                ParData_Inicial.SqlDbType = SqlDbType.VarChar;
                ParData_Inicial.Size = 20;
                ParData_Inicial.Value = Data_Inicial;
                SqlCmd.Parameters.Add(ParData_Inicial);

                SqlParameter ParData_Final = new SqlParameter();
                ParData_Final.ParameterName = "@datafinal";
                ParData_Final.SqlDbType = SqlDbType.VarChar;
                ParData_Final.Size = 20;
                ParData_Final.Value = Data_Final;
                SqlCmd.Parameters.Add(ParData_Final);

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
