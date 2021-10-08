using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCheque
    {
        private int _IdCheque;
        private int _IdRemetente;
        private DateTime _Data;
        private string _Banco_Emissor;
        private string _Nome_Titular;
        private string _Num_Cheque;
        private int _IdVenda;
        private int _IdGuiche_Atendimento;
        private int _IdFuncionario;
        private string _Num_parcela;
        private decimal _Valor;
        private DateTime _Depositar_Dia;
        private string _Estado;

        public int IdCheque
        {
            get
            {
                return _IdCheque;
            }

            set
            {
                _IdCheque = value;
            }
        }

        public int IdRemetente
        {
            get
            {
                return _IdRemetente;
            }

            set
            {
                _IdRemetente = value;
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

        public DCheque()
        {

        }

        public DCheque(int idcheque, int idremetente, DateTime data, string banco_emissor, string nome_titular, string num_cheque, int idvenda, int idguiche_atendimento, int idfuncionario, string num_parcela, decimal valor, DateTime depositar_dia, string estado)
        {
            this.IdCheque = idcheque;
            this.IdRemetente = idremetente;
            this.Data = data;
            this.Banco_Emissor = banco_emissor;
            this.Nome_Titular = nome_titular;
            this.Num_Cheque = num_cheque;
            this.IdVenda = idvenda;
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.IdFuncionario = idfuncionario;
            this.Num_parcela = num_parcela;
            this.Valor = valor;
            this.Depositar_Dia = depositar_dia;
            this.Estado = estado;
        }

        //Metodo Inserir 
        public string Inserir(DCheque Cheque)
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
                SqlCmd.CommandText = "spinserir_controle_cheque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcheque";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = Cheque.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Cheque.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParBanco_Emissor = new SqlParameter();
                ParBanco_Emissor.ParameterName = "@banco_emissor";
                ParBanco_Emissor.SqlDbType = SqlDbType.VarChar;
                ParBanco_Emissor.Size = 20;
                ParBanco_Emissor.Value = Cheque.Banco_Emissor;
                SqlCmd.Parameters.Add(ParBanco_Emissor);

                SqlParameter ParNome_Titular = new SqlParameter();
                ParNome_Titular.ParameterName = "@nome_titular";
                ParNome_Titular.SqlDbType = SqlDbType.VarChar;
                ParNome_Titular.Size = 20;
                ParNome_Titular.Value = Cheque.Nome_Titular;
                SqlCmd.Parameters.Add(ParNome_Titular);

                SqlParameter ParNum_Cheque = new SqlParameter();
                ParNum_Cheque.ParameterName = "@num_cheque";
                ParNum_Cheque.SqlDbType = SqlDbType.VarChar;
                ParNum_Cheque.Size = 20;
                ParNum_Cheque.Value = Cheque.Num_Cheque;
                SqlCmd.Parameters.Add(ParNum_Cheque);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Cheque.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);

                SqlParameter ParIdGuiche_Atendimento = new SqlParameter();
                ParIdGuiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdGuiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdGuiche_Atendimento.Value = Cheque.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdGuiche_Atendimento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Cheque.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNum_parcela = new SqlParameter();
                ParNum_parcela.ParameterName = "@num_parcela";
                ParNum_parcela.SqlDbType = SqlDbType.VarChar;
                ParNum_parcela.Size = 20;
                ParNum_parcela.Value = Cheque.Num_parcela;
                SqlCmd.Parameters.Add(ParNum_parcela);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Cheque.Valor;
                SqlCmd.Parameters.Add(ParValor);

                SqlParameter ParDepositar_Dia = new SqlParameter();
                ParDepositar_Dia.ParameterName = "@depositar_dia";
                ParDepositar_Dia.SqlDbType = SqlDbType.Date;
                ParDepositar_Dia.Value = Cheque.Depositar_Dia;
                SqlCmd.Parameters.Add(ParDepositar_Dia);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 10;
                ParEstado.Value = Cheque.Estado;
                SqlCmd.Parameters.Add(ParEstado);

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


        // Metodo Atualizar Status - DEPOSITADO
        public string Atualizar_Status_Depositado(DCheque Cheque)
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
                SqlCmd.CommandText = "spatualizar_status_cheque_depositado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcheque";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cheque.IdCheque;
                SqlCmd.Parameters.Add(ParId);
                
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


        // Metodo Atualizar Status - DEVOLVIDO
        public string Atualizar_Status_Devolvido(DCheque Cheque)
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
                SqlCmd.CommandText = "spatualizar_status_cheque_devolvido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcheque";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cheque.IdCheque;
                SqlCmd.Parameters.Add(ParId);

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
        public string Excluir(DCheque Cheque)
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
                SqlCmd.CommandText = "spdeletar_cheque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cheque.IdCheque;
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
            DataTable DtResultado = new DataTable("cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cheque";
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


        //Metodo Buscar Cheque - DEPOSITAR HOJE
        public DataTable Buscar_Depositar_Hoje(string Data_Atual)
        {
            DataTable DtResultado = new DataTable("cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cheque_depositar_hoje";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Atual = new SqlParameter();
                ParData_Atual.ParameterName = "@dataatual ";
                ParData_Atual.SqlDbType = SqlDbType.VarChar;
                ParData_Atual.Size = 20;
                ParData_Atual.Value = Data_Atual;
                SqlCmd.Parameters.Add(ParData_Atual);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Cheque - DEPOSITAADO
        public DataTable Buscar_Depositado()
        {
            DataTable DtResultado = new DataTable("cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cheque_depositado";
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


        //Metodo Buscar Cheque - AGUARDANDO
        public DataTable Buscar_Aguardando()
        {
            DataTable DtResultado = new DataTable("cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cheque_aguardando";
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


        //Metodo Buscar Cheque - DEVOLVIDO
        public DataTable Buscar_Devolvido()
        {
            DataTable DtResultado = new DataTable("cheque");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cheque_devolvido";
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
