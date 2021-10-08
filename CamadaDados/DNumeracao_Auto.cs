using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DNumeracao_Auto
    {
        private int _IdNumeracao_Auto;

        // Variaveis Vendas
        private int _Inicio_Venda;
        private int _Atual_Venda;
        private string _Estado_Venda;

        // Variaveis OS
        private int _Inicio_OS;
        private int _Atual_OS;
        private string _Estado_OS;
        
        // Variaveis Orçamento
        private int _Inicio_Orcamento;
        private int _Atual_Orcamento;
        private string _Estado_Orcamento;

        public int IdNumeracao_Auto
        {
            get
            {
                return _IdNumeracao_Auto;
            }

            set
            {
                _IdNumeracao_Auto = value;
            }
        }

        public int Inicio_Venda
        {
            get
            {
                return _Inicio_Venda;
            }

            set
            {
                _Inicio_Venda = value;
            }
        }

        public int Atual_Venda
        {
            get
            {
                return _Atual_Venda;
            }

            set
            {
                _Atual_Venda = value;
            }
        }

        public string Estado_Venda
        {
            get
            {
                return _Estado_Venda;
            }

            set
            {
                _Estado_Venda = value;
            }
        }

        public int Inicio_OS
        {
            get
            {
                return _Inicio_OS;
            }

            set
            {
                _Inicio_OS = value;
            }
        }

        public int Atual_OS
        {
            get
            {
                return _Atual_OS;
            }

            set
            {
                _Atual_OS = value;
            }
        }

        public string Estado_OS
        {
            get
            {
                return _Estado_OS;
            }

            set
            {
                _Estado_OS = value;
            }
        }

        public int Inicio_Orcamento
        {
            get
            {
                return _Inicio_Orcamento;
            }

            set
            {
                _Inicio_Orcamento = value;
            }
        }

        public int Atual_Orcamento
        {
            get
            {
                return _Atual_Orcamento;
            }

            set
            {
                _Atual_Orcamento = value;
            }
        }

        public string Estado_Orcamento
        {
            get
            {
                return _Estado_Orcamento;
            }

            set
            {
                _Estado_Orcamento = value;
            }
        }

        public DNumeracao_Auto()
        {

        }


        public DNumeracao_Auto(int idnumeracao_auto, int inicio_venda, int atual_venda, string estado_venda, int inicio_os, int atual_os, string estado_os, int inicio_orcamento, int atual_orcamento, string estado_orcamento)
        {
            this.IdNumeracao_Auto = idnumeracao_auto;
            this.Inicio_Venda = inicio_venda;
            this.Atual_Venda = atual_venda;
            this.Estado_Venda = estado_venda;

            this.Inicio_OS = inicio_os;
            this.Atual_OS = atual_os;
            this.Estado_OS = estado_os;

            this.Inicio_Orcamento = inicio_orcamento;
            this.Atual_Orcamento = atual_orcamento;
            this.Estado_Orcamento = estado_orcamento;
        }

        
        //Metodo Editar Numeração Automática - VENDAS
        public string Editar_Num_Auto_Venda(DNumeracao_Auto Numeracao_Auto)
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
                SqlCmd.CommandText = "speditar_num_auto_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Numeracao_Auto.IdNumeracao_Auto;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParInicio_Venda = new SqlParameter();
                ParInicio_Venda.ParameterName = "@inicio_venda";
                ParInicio_Venda.SqlDbType = SqlDbType.Int;
                ParInicio_Venda.Value = Numeracao_Auto.Inicio_Venda;
                SqlCmd.Parameters.Add(ParInicio_Venda);

                SqlParameter ParAtual_Venda = new SqlParameter();
                ParAtual_Venda.ParameterName = "@atual_venda";
                ParAtual_Venda.SqlDbType = SqlDbType.Int;
                ParAtual_Venda.Value = Numeracao_Auto.Atual_Venda;
                SqlCmd.Parameters.Add(ParAtual_Venda);

                SqlParameter ParEstado_Venda = new SqlParameter();
                ParEstado_Venda.ParameterName = "@estado_venda";
                ParEstado_Venda.SqlDbType = SqlDbType.VarChar;
                ParEstado_Venda.Size = 3;
                ParEstado_Venda.Value = Numeracao_Auto.Estado_Venda;
                SqlCmd.Parameters.Add(ParEstado_Venda);

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


        //Metodo Editar Numeração Automática - OS
        public string Editar_Num_Auto_OS(DNumeracao_Auto Numeracao_Auto)
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
                SqlCmd.CommandText = "speditar_num_auto_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Numeracao_Auto.IdNumeracao_Auto;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParInicio_OS = new SqlParameter();
                ParInicio_OS.ParameterName = "@inicio_os";
                ParInicio_OS.SqlDbType = SqlDbType.Int;
                ParInicio_OS.Value = Numeracao_Auto.Inicio_OS;
                SqlCmd.Parameters.Add(ParInicio_OS);

                SqlParameter ParAtual_OS = new SqlParameter();
                ParAtual_OS.ParameterName = "@atual_os";
                ParAtual_OS.SqlDbType = SqlDbType.Int;
                ParAtual_OS.Value = Numeracao_Auto.Atual_OS;
                SqlCmd.Parameters.Add(ParAtual_OS);

                SqlParameter ParEstado_OS = new SqlParameter();
                ParEstado_OS.ParameterName = "@estado_os";
                ParEstado_OS.SqlDbType = SqlDbType.VarChar;
                ParEstado_OS.Size = 3;
                ParEstado_OS.Value = Numeracao_Auto.Estado_OS;
                SqlCmd.Parameters.Add(ParEstado_OS);

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


        //Metodo Editar Numeração Automática - ORCAMENTO
        public string Editar_Num_Auto_Orcamento(DNumeracao_Auto Numeracao_Auto)
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
                SqlCmd.CommandText = "speditar_num_auto_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParInicio_Orcamento = new SqlParameter();
                ParInicio_Orcamento.ParameterName = "@inicio_orcamento";
                ParInicio_Orcamento.SqlDbType = SqlDbType.Int;
                ParInicio_Orcamento.Value = Numeracao_Auto.Inicio_Orcamento;
                SqlCmd.Parameters.Add(ParInicio_Orcamento);

                SqlParameter ParAtual_Orcamento = new SqlParameter();
                ParAtual_Orcamento.ParameterName = "@atual_orcamento";
                ParAtual_Orcamento.SqlDbType = SqlDbType.Int;
                ParAtual_Orcamento.Value = Numeracao_Auto.Atual_Orcamento;
                SqlCmd.Parameters.Add(ParAtual_Orcamento);

                SqlParameter ParEstado_Orcamento = new SqlParameter();
                ParEstado_Orcamento.ParameterName = "@estado_orcamento";
                ParEstado_Orcamento.SqlDbType = SqlDbType.VarChar;
                ParEstado_Orcamento.Size = 3;
                ParEstado_Orcamento.Value = Numeracao_Auto.Estado_Orcamento;
                SqlCmd.Parameters.Add(ParEstado_Orcamento);

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
        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("numeracao_auto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_num_auto";
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

        //Metodo Mostrar Inicio Numeração Automatica LIVRO CAIXA
        public DataTable Mostrar_Num_Auto_Livro_Caixa()
        {
            DataTable DtResultado = new DataTable("numeracao_auto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_num_auto_livro_caixa";
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


        //Metodo Mostrar Inicio Numeração Automatica VENDA
        public DataTable Mostrar_Num_Auto_Venda()
        {
            DataTable DtResultado = new DataTable("numeracao_auto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_num_auto_venda";
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


        //Metodo Mostrar Inicio Numeração Automatica OS
        public DataTable Mostrar_Num_Auto_OS()
        {
            DataTable DtResultado = new DataTable("numeracao_auto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_num_auto_os";
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


        //Metodo Mostrar Inicio Numeração Automatica - ORÇAMENTO
        public DataTable Mostrar_Num_Auto_Orcamento()
        {
            DataTable DtResultado = new DataTable("numeracao_auto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_num_auto_orcamento";
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
