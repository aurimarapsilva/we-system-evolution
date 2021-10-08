using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDinheiro
    {
        private int _IdDinheiro;
        private DateTime _Data;
        private int _IdVenda;
        private int _IdGuiche_Atendimento;
        private int _IdFuncionario;
        private string _Historico;
        private decimal _Valor;

        public int IdDinheiro
        {
            get
            {
                return _IdDinheiro;
            }

            set
            {
                _IdDinheiro = value;
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

        public string Historico
        {
            get
            {
                return _Historico;
            }

            set
            {
                _Historico = value;
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

        public DDinheiro()
        {

        }

        public DDinheiro(int iddinheiro, DateTime data, int idvenda, int idguiche_atendimento, int idfuncionario, string historico, decimal valor)
        {
            this.IdDinheiro = iddinheiro;
            this.Data = data;
            this.IdVenda = idvenda;
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.IdFuncionario = idfuncionario;
            this.Historico = historico;
            this.Valor = valor;
        }

        //Metodo Inserir 
        public string Inserir(DDinheiro Dinheiro)
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
                SqlCmd.CommandText = "spinserir_controle_dinheiro";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddinheiro";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Dinheiro.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParIdVenda = new SqlParameter();
                ParIdVenda.ParameterName = "@idvenda";
                ParIdVenda.SqlDbType = SqlDbType.Int;
                ParIdVenda.Value = Dinheiro.IdVenda;
                SqlCmd.Parameters.Add(ParIdVenda);

                SqlParameter ParIdGuiche_Atendimento = new SqlParameter();
                ParIdGuiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdGuiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdGuiche_Atendimento.Value = Dinheiro.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdGuiche_Atendimento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Dinheiro.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParHistorico = new SqlParameter();
                ParHistorico.ParameterName = "@historico";
                ParHistorico.SqlDbType = SqlDbType.VarChar;
                ParHistorico.Size = 20;
                ParHistorico.Value = Dinheiro.Historico;
                SqlCmd.Parameters.Add(ParHistorico);

                SqlParameter ParValor = new SqlParameter();
                ParValor.ParameterName = "@valor";
                ParValor.SqlDbType = SqlDbType.Decimal;
                ParValor.Precision = 7;
                ParValor.Scale = 2;
                ParValor.Value = Dinheiro.Valor;
                SqlCmd.Parameters.Add(ParValor);
                
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
    }
}
