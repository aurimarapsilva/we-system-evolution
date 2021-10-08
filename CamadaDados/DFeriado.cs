using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFeriado
    {
        private int _IdFeriado;
        private DateTime _Feriado;

        public int IdFeriado
        {
            get
            {
                return _IdFeriado;
            }

            set
            {
                _IdFeriado = value;
            }
        }

        public DateTime Feriado
        {
            get
            {
                return _Feriado;
            }

            set
            {
                _Feriado = value;
            }
        }

        public DFeriado()
        {

        }

        public DFeriado(int idferiado, DateTime feriado)
        {
            this.IdFeriado = idferiado;
            this.Feriado = feriado;
        }


        //Metodo Atualizar base de dados
        public string Atualizar_Base_Dados(DFeriado Feriado)
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
                SqlCmd.CommandText = "spatualizar_dados_tblferiado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idferiado";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Feriado.IdFeriado;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParFeriado = new SqlParameter();
                ParFeriado.ParameterName = "@feriado";
                ParFeriado.SqlDbType = SqlDbType.Date;
                ParFeriado.Value = Feriado.Feriado;
                SqlCmd.Parameters.Add(ParFeriado);
                
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


        //Metodo Mostrar Feriado
        public DataTable Mostrar_Feriado()
        {
            DataTable DtResultado = new DataTable("feriado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_feriado";
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


        //Metodo Buscar Feriado
        public DataTable Buscar_Feriado(string Data)
        {
            DataTable DtResultado = new DataTable("feriado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_feriado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.VarChar;
                ParData.Size = 20;
                ParData.Value = Data;
                SqlCmd.Parameters.Add(ParData);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Atualizar detalhe feriado
        public string Atualizar_Detalhe_Feriado(DateTime Atualizar)
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
                SqlCmd.CommandText = "spatualizar_detalhe_feriado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParAtualizar = new SqlParameter();
                ParAtualizar.ParameterName = "@atualizar";
                ParAtualizar.SqlDbType = SqlDbType.Date;
                ParAtualizar.Value = Atualizar;
                SqlCmd.Parameters.Add(ParAtualizar);

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

        //Metodo Mostrar Detalhe Feriado
        public DataTable Mostrar_Detalhe_Feriado()
        {
            DataTable DtResultado = new DataTable("detalhe_feriado");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhe_feriado";
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
