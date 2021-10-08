using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DInformacoes_Caixa_Aberto
    {
        private int _Idinformacoes_Caixa_Aberto;
        private int _Idguiche_Atendimento;
        private string _Nome_Guiche;
        private int _Idfuncionario;
        private string _Nome_Funcionario;
        private DateTime _Data_Aberto;
        private string _Hora_Aberto;
        private decimal _Valor_Inicial_Caixa;

        public int Idinformacoes_Caixa_Aberto
        {
            get
            {
                return _Idinformacoes_Caixa_Aberto;
            }

            set
            {
                _Idinformacoes_Caixa_Aberto = value;
            }
        }

        public int Idguiche_Atendimento
        {
            get
            {
                return _Idguiche_Atendimento;
            }

            set
            {
                _Idguiche_Atendimento = value;
            }
        }

        public string Nome_Guiche
        {
            get
            {
                return _Nome_Guiche;
            }

            set
            {
                _Nome_Guiche = value;
            }
        }

        public int Idfuncionario
        {
            get
            {
                return _Idfuncionario;
            }

            set
            {
                _Idfuncionario = value;
            }
        }

        public string Nome_Funcionario
        {
            get
            {
                return _Nome_Funcionario;
            }

            set
            {
                _Nome_Funcionario = value;
            }
        }

        public DateTime Data_Aberto
        {
            get
            {
                return _Data_Aberto;
            }

            set
            {
                _Data_Aberto = value;
            }
        }

        public string Hora_Aberto
        {
            get
            {
                return _Hora_Aberto;
            }

            set
            {
                _Hora_Aberto = value;
            }
        }

        public decimal Valor_Inicial_Caixa
        {
            get
            {
                return _Valor_Inicial_Caixa;
            }

            set
            {
                _Valor_Inicial_Caixa = value;
            }
        }

        public DInformacoes_Caixa_Aberto()
        {

        }

        public DInformacoes_Caixa_Aberto(int idinformacoes_caixa_aberto, int idguiche_atendimento, string nome_guiche, int idfuncionario, string nome_funcionario, DateTime data_aberto, string hora_aberto, decimal valor_inicial_caixa)
        {
            this.Idinformacoes_Caixa_Aberto = idinformacoes_caixa_aberto;
            this.Idguiche_Atendimento = idguiche_atendimento;
            this.Nome_Guiche = nome_guiche;
            this.Idfuncionario = idfuncionario;
            this.Nome_Funcionario = nome_funcionario;
            this.Data_Aberto = data_aberto;
            this.Hora_Aberto = hora_aberto;
            this.Valor_Inicial_Caixa = valor_inicial_caixa;
        }

        //Metodo Inserir 
        public string Inserir(DInformacoes_Caixa_Aberto Informacoes_Caixa_Aberto)
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
                SqlCmd.CommandText = "spinserir_informacoes_caixa_aberto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idinformacoes_caixa_aberto";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParIdguiche_Atendimento = new SqlParameter();
                ParIdguiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdguiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdguiche_Atendimento.Value = Informacoes_Caixa_Aberto.Idguiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdguiche_Atendimento);
                
                SqlParameter ParNome_Guiche = new SqlParameter();
                ParNome_Guiche.ParameterName = "@nome_guiche";
                ParNome_Guiche.SqlDbType = SqlDbType.VarChar;
                ParNome_Guiche.Size = 50;
                ParNome_Guiche.Value = Informacoes_Caixa_Aberto.Nome_Guiche;
                SqlCmd.Parameters.Add(ParNome_Guiche);

                SqlParameter ParIdfuncionario = new SqlParameter();
                ParIdfuncionario.ParameterName = "@idfuncionario";
                ParIdfuncionario.SqlDbType = SqlDbType.Int;
                ParIdfuncionario.Value = Informacoes_Caixa_Aberto.Idfuncionario;
                SqlCmd.Parameters.Add(ParIdfuncionario);

                SqlParameter ParNome_Funcionario = new SqlParameter();
                ParNome_Funcionario.ParameterName = "@nome_funcionario";
                ParNome_Funcionario.SqlDbType = SqlDbType.VarChar;
                ParNome_Funcionario.Size = 80;
                ParNome_Funcionario.Value = Informacoes_Caixa_Aberto.Nome_Funcionario;
                SqlCmd.Parameters.Add(ParNome_Funcionario);

                SqlParameter ParData_Aberto = new SqlParameter();
                ParData_Aberto.ParameterName = "@data_aberto";
                ParData_Aberto.SqlDbType = SqlDbType.Date;
                ParData_Aberto.Value = Informacoes_Caixa_Aberto.Data_Aberto;
                SqlCmd.Parameters.Add(ParData_Aberto);

                SqlParameter ParHora_Aberto = new SqlParameter();
                ParHora_Aberto.ParameterName = "@hora_aberto";
                ParHora_Aberto.SqlDbType = SqlDbType.VarChar;
                ParHora_Aberto.Size = 7;
                ParHora_Aberto.Value = Informacoes_Caixa_Aberto.Hora_Aberto;
                SqlCmd.Parameters.Add(ParHora_Aberto);

                SqlParameter ParValor_Inicial_Caixa = new SqlParameter();
                ParValor_Inicial_Caixa.ParameterName = "@valor_inicial_caixa";
                ParValor_Inicial_Caixa.SqlDbType = SqlDbType.Decimal;
                ParValor_Inicial_Caixa.Precision = 7;
                ParValor_Inicial_Caixa.Scale = 2;
                ParValor_Inicial_Caixa.Value = Informacoes_Caixa_Aberto.Valor_Inicial_Caixa;
                SqlCmd.Parameters.Add(ParValor_Inicial_Caixa);

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


        //Método Fechar Caixa Somente uma vez por dia  
        public DataTable Mostrar(string Idfuncionario)
        {
            DataTable DtResultado = new DataTable("informacoes_caixa_aberto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_informacoes_caixa_aberto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdfuncionario = new SqlParameter();
                ParIdfuncionario.ParameterName = "@idfuncionario";
                ParIdfuncionario.SqlDbType = SqlDbType.VarChar;
                ParIdfuncionario.Size = 20;
                ParIdfuncionario.Value = Idfuncionario;
                SqlCmd.Parameters.Add(ParIdfuncionario);

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
