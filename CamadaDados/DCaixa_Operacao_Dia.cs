using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCaixa_Operacao_Dia
    {
        private int IdCaixa_Operacao_Dia;
        private int _IdGuiche_Atendimento;
        private string _Nome_Guiche;
        private int _IdFuncionario;
        private string _Nome_Funcionario;
        private DateTime _Data;
        private string _Aberto;
        private string _Fechado;
        private decimal _Valor_Inicial;
        private decimal _Entrada_Cartao_Credito;
        private decimal _Entrada_Cheque;
        private decimal _Entrada_Cartao_Debito;
        private decimal _Entrada_Crediario_Loja;
        private decimal _Entrada_Dinheiro;
        private decimal _Entrada_Total;

        public int IdCaixa_Operacao_Dia1
        {
            get
            {
                return IdCaixa_Operacao_Dia;
            }

            set
            {
                IdCaixa_Operacao_Dia = value;
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

        public string Aberto
        {
            get
            {
                return _Aberto;
            }

            set
            {
                _Aberto = value;
            }
        }

        public string Fechado
        {
            get
            {
                return _Fechado;
            }

            set
            {
                _Fechado = value;
            }
        }

        public decimal Valor_Inicial
        {
            get
            {
                return _Valor_Inicial;
            }

            set
            {
                _Valor_Inicial = value;
            }
        }

        public decimal Entrada_Cartao_Credito
        {
            get
            {
                return _Entrada_Cartao_Credito;
            }

            set
            {
                _Entrada_Cartao_Credito = value;
            }
        }

        public decimal Entrada_Cheque
        {
            get
            {
                return _Entrada_Cheque;
            }

            set
            {
                _Entrada_Cheque = value;
            }
        }

        public decimal Entrada_Cartao_Debito
        {
            get
            {
                return _Entrada_Cartao_Debito;
            }

            set
            {
                _Entrada_Cartao_Debito = value;
            }
        }

        public decimal Entrada_Crediario_Loja
        {
            get
            {
                return _Entrada_Crediario_Loja;
            }

            set
            {
                _Entrada_Crediario_Loja = value;
            }
        }

        public decimal Entrada_Dinheiro
        {
            get
            {
                return _Entrada_Dinheiro;
            }

            set
            {
                _Entrada_Dinheiro = value;
            }
        }

        public decimal Entrada_Total
        {
            get
            {
                return _Entrada_Total;
            }

            set
            {
                _Entrada_Total = value;
            }
        }

        
        public DCaixa_Operacao_Dia()
        {

        }

        public DCaixa_Operacao_Dia(int idcaixa_operacao_dia, int idguiche_atendimento, string nome_guiche, int idfuncionario, string nome_funcionario, DateTime data, string aberto, string fechado, decimal valor_inicial, decimal entrada_cartao_credito, decimal entrada_cheque, decimal entrada_cartao_debito, decimal entrada_crediario_loja, decimal entrada_dinheiro, decimal entrada_total)
        {
            this.IdCaixa_Operacao_Dia1 = idcaixa_operacao_dia;
            this.IdGuiche_Atendimento = idguiche_atendimento;
            this.Nome_Guiche = nome_guiche;
            this.IdFuncionario = idfuncionario;
            this.Nome_Funcionario = nome_funcionario;
            this.Data = data;
            this.Aberto = aberto;
            this.Fechado = fechado;
            this.Valor_Inicial = valor_inicial;
            this.Entrada_Cartao_Credito = entrada_cartao_credito;
            this.Entrada_Cheque = entrada_cheque;
            this.Entrada_Cartao_Debito = entrada_cartao_debito;
            this.Entrada_Crediario_Loja = entrada_crediario_loja;
            this.Entrada_Dinheiro = entrada_dinheiro;
            this.Entrada_Total = entrada_total;
        }


        //Metodo Inserir 
        public string Inserir(DCaixa_Operacao_Dia Caixa_Operacao_Dia)
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
                SqlCmd.CommandText = "spinserir_caixa_operacao_dia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idcaixa_operacao_dia";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdGuiche_Atendimento = new SqlParameter();
                ParIdGuiche_Atendimento.ParameterName = "@idguiche_atendimento";
                ParIdGuiche_Atendimento.SqlDbType = SqlDbType.Int;
                ParIdGuiche_Atendimento.Value = Caixa_Operacao_Dia.IdGuiche_Atendimento;
                SqlCmd.Parameters.Add(ParIdGuiche_Atendimento);

                SqlParameter ParNome_Guiche = new SqlParameter();
                ParNome_Guiche.ParameterName = "@nome_guiche";
                ParNome_Guiche.SqlDbType = SqlDbType.VarChar;
                ParNome_Guiche.Size = 50;
                ParNome_Guiche.Value = Caixa_Operacao_Dia.Nome_Guiche;
                SqlCmd.Parameters.Add(ParNome_Guiche);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Caixa_Operacao_Dia.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNome_Funcionario = new SqlParameter();
                ParNome_Funcionario.ParameterName = "@nome_funcionario";
                ParNome_Funcionario.SqlDbType = SqlDbType.VarChar;
                ParNome_Funcionario.Size = 80;
                ParNome_Funcionario.Value = Caixa_Operacao_Dia.Nome_Funcionario;
                SqlCmd.Parameters.Add(ParNome_Funcionario);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Caixa_Operacao_Dia.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParAberto = new SqlParameter();
                ParAberto.ParameterName = "@aberto";
                ParAberto.SqlDbType = SqlDbType.VarChar;
                ParAberto.Size = 7;
                ParAberto.Value = Caixa_Operacao_Dia.Aberto;
                SqlCmd.Parameters.Add(ParAberto);

                SqlParameter ParFechado = new SqlParameter();
                ParFechado.ParameterName = "@fechado";
                ParFechado.SqlDbType = SqlDbType.VarChar;
                ParFechado.Size = 7;
                ParFechado.Value = Caixa_Operacao_Dia.Fechado;
                SqlCmd.Parameters.Add(ParFechado);

                SqlParameter ParValor_Inicial = new SqlParameter();
                ParValor_Inicial.ParameterName = "@valor_inicial";
                ParValor_Inicial.SqlDbType = SqlDbType.Decimal;
                ParValor_Inicial.Precision = 7;
                ParValor_Inicial.Scale = 2;
                ParValor_Inicial.Value = Caixa_Operacao_Dia.Valor_Inicial;
                SqlCmd.Parameters.Add(ParValor_Inicial);

                SqlParameter ParEntrada_Cartao_Credito = new SqlParameter();
                ParEntrada_Cartao_Credito.ParameterName = "@entrada_cartao_credito";
                ParEntrada_Cartao_Credito.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Cartao_Credito.Precision = 7;
                ParEntrada_Cartao_Credito.Scale = 2;
                ParEntrada_Cartao_Credito.Value = Caixa_Operacao_Dia.Entrada_Cartao_Credito;
                SqlCmd.Parameters.Add(ParEntrada_Cartao_Credito);

                SqlParameter ParEntrada_Cheque = new SqlParameter();
                ParEntrada_Cheque.ParameterName = "@entrada_cheque";
                ParEntrada_Cheque.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Cheque.Precision = 7;
                ParEntrada_Cheque.Scale = 2;
                ParEntrada_Cheque.Value = Caixa_Operacao_Dia.Entrada_Cheque;
                SqlCmd.Parameters.Add(ParEntrada_Cheque);

                SqlParameter ParEntrada_Cartao_Debito = new SqlParameter();
                ParEntrada_Cartao_Debito.ParameterName = "@entrada_cartao_debito";
                ParEntrada_Cartao_Debito.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Cartao_Debito.Precision = 7;
                ParEntrada_Cartao_Debito.Scale = 2;
                ParEntrada_Cartao_Debito.Value = Caixa_Operacao_Dia.Entrada_Cartao_Debito;
                SqlCmd.Parameters.Add(ParEntrada_Cartao_Debito);

                SqlParameter ParEntrada_Crediario_Loja = new SqlParameter();
                ParEntrada_Crediario_Loja.ParameterName = "@entrada_crediario_loja";
                ParEntrada_Crediario_Loja.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Crediario_Loja.Precision = 7;
                ParEntrada_Crediario_Loja.Scale = 2;
                ParEntrada_Crediario_Loja.Value = Caixa_Operacao_Dia.Entrada_Crediario_Loja;
                SqlCmd.Parameters.Add(ParEntrada_Crediario_Loja);

                SqlParameter ParEntrada_Dinheiro = new SqlParameter();
                ParEntrada_Dinheiro.ParameterName = "@entrada_dinheiro";
                ParEntrada_Dinheiro.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Dinheiro.Precision = 7;
                ParEntrada_Dinheiro.Scale = 2;
                ParEntrada_Dinheiro.Value = Caixa_Operacao_Dia.Entrada_Dinheiro;
                SqlCmd.Parameters.Add(ParEntrada_Dinheiro);

                SqlParameter ParEntrada_Total = new SqlParameter();
                ParEntrada_Total.ParameterName = "@entrada_total";
                ParEntrada_Total.SqlDbType = SqlDbType.Decimal;
                ParEntrada_Total.Precision = 7;
                ParEntrada_Total.Scale = 2;
                ParEntrada_Total.Value = Caixa_Operacao_Dia.Entrada_Total;
                SqlCmd.Parameters.Add(ParEntrada_Total);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi inserido";

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
            DataTable DtResultado = new DataTable("caixa_operacao_dia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_caixa_operacao_dia_geral";
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

        //Metodo Pesquisar por Caixa
        public DataTable BuscarCaixa(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("caixa_operacao_dia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_caixa_operacao_dia_por_caixa";
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

        //Metodo Pesquisar por Funcionario
        public DataTable BuscarFuncionario(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("caixa_operacao_dia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_caixa_operacao_dia_por_funcionario";
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

        //Metodo Pesquisar por Datas
        public DataTable BuscarDatas(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("caixa_operacao_dia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_caixa_operacao_dia_por_datas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);
                
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
