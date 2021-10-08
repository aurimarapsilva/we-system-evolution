using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DRemetente
    {
        private int _IdRemetente;
        private byte[] _Logo;
        private string _Telefone;
        private string _Email;
        private string _Url;
        private string _Categoria_Empresa;
        private decimal _Aliquota;

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

        public byte[] Logo
        {
            get
            {
                return _Logo;
            }

            set
            {
                _Logo = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string Url
        {
            get
            {
                return _Url;
            }

            set
            {
                _Url = value;
            }
        }

        public string Categoria_Empresa
        {
            get
            {
                return _Categoria_Empresa;
            }

            set
            {
                _Categoria_Empresa = value;
            }
        }

        public decimal Aliquota
        {
            get
            {
                return _Aliquota;
            }

            set
            {
                _Aliquota = value;
            }
        }

        public DRemetente()
        {

        }

        public DRemetente(int idremetente, byte[] logo, string telefone, string email, string url, string categoria_empresa, decimal aliquota)
        {
            this.IdRemetente = idremetente;
            this.Logo = logo;
            this.Telefone = telefone;
            this.Email = email;
            this.Url = url;
            this.Categoria_Empresa = categoria_empresa;
            this.Aliquota = aliquota;
        }


        //Metodo Editar
        public string Editar(DRemetente Remetente)
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
                SqlCmd.CommandText = "speditar_remetente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = Remetente.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParLogo = new SqlParameter();
                ParLogo.ParameterName = "@logo";
                ParLogo.SqlDbType = SqlDbType.Image;
                ParLogo.Value = Remetente.Logo;
                SqlCmd.Parameters.Add(ParLogo);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 17;
                ParTelefone.Value = Remetente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Remetente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 150;
                ParUrl.Value = Remetente.Url;
                SqlCmd.Parameters.Add(ParUrl);

                SqlParameter ParCategoria_Empresa = new SqlParameter();
                ParCategoria_Empresa.ParameterName = "@categoria_empresa";
                ParCategoria_Empresa.SqlDbType = SqlDbType.VarChar;
                ParCategoria_Empresa.Size = 5;
                ParCategoria_Empresa.Value = Remetente.Categoria_Empresa;
                SqlCmd.Parameters.Add(ParCategoria_Empresa);

                SqlParameter ParAliquota = new SqlParameter();
                ParAliquota.ParameterName = "@aliquota";
                ParAliquota.SqlDbType = SqlDbType.Decimal;
                ParAliquota.Precision = 5;
                ParAliquota.Scale = 2;
                ParAliquota.Value = Remetente.Aliquota;
                SqlCmd.Parameters.Add(ParAliquota);

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


        // Metodo Atualizar Status da Licença - BLOQUEADO
        public string Atualizar_Status_Licença_Bloqueado()
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
                SqlCmd.CommandText = "spatualizar_status_licenca_bloqueado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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


        // Metodo Atualizar Status da Licença - DESATIVADO
        public string Atualizar_Status_Licença_Desativado(string Data_Atual)
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
                SqlCmd.CommandText = "spatualizar_status_licenca_desativado";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Atual = new SqlParameter();
                ParData_Atual.ParameterName = "@dataatual";
                ParData_Atual.SqlDbType = SqlDbType.VarChar;
                ParData_Atual.Size = 20;
                ParData_Atual.Value = Data_Atual;
                SqlCmd.Parameters.Add(ParData_Atual);

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


        // Metodo Atualizar Status da Licença - ATIVO
        public string Atualizar_Status_Licença_Ativo()
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
                SqlCmd.CommandText = "spatualizar_status_licenca_ativo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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
            DataTable DtResultado = new DataTable("remetente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_remetente";
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
