using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFornecedor
    {
        private int _Id;
        private string _Empresa;
        private string _Contato;
        private string _Setor_Comercial;
        private string _Doc_Principal;
        private string _Num_Doc_Principal;
        private string _Doc_Secundario;
        private string _Num_Doc_Secundario;
        private string _Endereco;
        private string _Bairro;
        private string _Cidade;
        private string _Cep;
        private string _Uf;
        private string _Telefone;
        private string _Whatsapp;
        private string _Email;
        private string _Url;
        private string _TextoBuscar;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Empresa
        {
            get
            {
                return _Empresa;
            }

            set
            {
                _Empresa = value;
            }
        }

        public string Contato
        {
            get
            {
                return _Contato;
            }

            set
            {
                _Contato = value;
            }
        }

        public string Setor_Comercial
        {
            get
            {
                return _Setor_Comercial;
            }

            set
            {
                _Setor_Comercial = value;
            }
        }

        public string Doc_Principal
        {
            get
            {
                return _Doc_Principal;
            }

            set
            {
                _Doc_Principal = value;
            }
        }

        public string Num_Doc_Principal
        {
            get
            {
                return _Num_Doc_Principal;
            }

            set
            {
                _Num_Doc_Principal = value;
            }
        }

        public string Doc_Secundario
        {
            get
            {
                return _Doc_Secundario;
            }

            set
            {
                _Doc_Secundario = value;
            }
        }

        public string Num_Doc_Secundario
        {
            get
            {
                return _Num_Doc_Secundario;
            }

            set
            {
                _Num_Doc_Secundario = value;
            }
        }

        public string Endereco
        {
            get
            {
                return _Endereco;
            }

            set
            {
                _Endereco = value;
            }
        }

        public string Bairro
        {
            get
            {
                return _Bairro;
            }

            set
            {
                _Bairro = value;
            }
        }

        public string Cidade
        {
            get
            {
                return _Cidade;
            }

            set
            {
                _Cidade = value;
            }
        }

        public string Cep
        {
            get
            {
                return _Cep;
            }

            set
            {
                _Cep = value;
            }
        }

        public string Uf
        {
            get
            {
                return _Uf;
            }

            set
            {
                _Uf = value;
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

        public string Whatsapp
        {
            get
            {
                return _Whatsapp;
            }

            set
            {
                _Whatsapp = value;
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

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }


        //Construtor vazio
        public DFornecedor()
        {

        }

        //Construtor com parametros 
        public DFornecedor(int id, string empresa, string contato, string setor_comercial, string doc_principal, string num_doc_principal, string doc_secundario, string num_doc_secundario, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string whatsapp, string email, string url, string textobuscar)
        {
            this.Id = id;
            this.Empresa = empresa;
            this.Contato = contato;
            this.Setor_Comercial = setor_comercial;
            this.Doc_Principal = doc_principal;
            this.Num_Doc_Principal = num_doc_principal;
            this.Doc_Secundario = doc_secundario;
            this.Num_Doc_Secundario = num_doc_secundario;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Uf = uf;
            this.Telefone = telefone;
            this.Whatsapp = whatsapp;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }


        //Metodo Inserir 
        public string Inserir(DFornecedor Fornecedor)
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
                SqlCmd.CommandText = "spinserir_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParEmpresa = new SqlParameter();
                ParEmpresa.ParameterName = "@empresa";
                ParEmpresa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa.Size = 100;
                ParEmpresa.Value = Fornecedor.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa);

                SqlParameter ParContato = new SqlParameter();
                ParContato.ParameterName = "@contato";
                ParContato.SqlDbType = SqlDbType.VarChar;
                ParContato.Size = 50;
                ParContato.Value = Fornecedor.Contato;
                SqlCmd.Parameters.Add(ParContato);

                SqlParameter ParSetorComercial = new SqlParameter();
                ParSetorComercial.ParameterName = "@setor_comercial";
                ParSetorComercial.SqlDbType = SqlDbType.VarChar;
                ParSetorComercial.Size = 50;
                ParSetorComercial.Value = Fornecedor.Setor_Comercial;
                SqlCmd.Parameters.Add(ParSetorComercial);


                SqlParameter ParDoc_Principal = new SqlParameter();
                ParDoc_Principal.ParameterName = "@doc_principal";
                ParDoc_Principal.SqlDbType = SqlDbType.VarChar;
                ParDoc_Principal.Size = 4;
                ParDoc_Principal.Value = Fornecedor.Doc_Principal;
                SqlCmd.Parameters.Add(ParDoc_Principal);

                SqlParameter ParNum_Doc_Principal = new SqlParameter();
                ParNum_Doc_Principal.ParameterName = "@num_doc_principal";
                ParNum_Doc_Principal.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc_Principal.Size = 20;
                ParNum_Doc_Principal.Value = Fornecedor.Num_Doc_Principal;
                SqlCmd.Parameters.Add(ParNum_Doc_Principal);

                SqlParameter ParDoc_Secundario = new SqlParameter();
                ParDoc_Secundario.ParameterName = "@doc_secundario";
                ParDoc_Secundario.SqlDbType = SqlDbType.VarChar;
                ParDoc_Secundario.Size = 4;
                ParDoc_Secundario.Value = Fornecedor.Doc_Secundario;
                SqlCmd.Parameters.Add(ParDoc_Secundario);

                SqlParameter ParNum_Doc_Secundario = new SqlParameter();
                ParNum_Doc_Secundario.ParameterName = "@num_doc_secundario";
                ParNum_Doc_Secundario.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc_Secundario.Size = 20;
                ParNum_Doc_Secundario.Value = Fornecedor.Num_Doc_Secundario;
                SqlCmd.Parameters.Add(ParNum_Doc_Secundario);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Fornecedor.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Fornecedor.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Fornecedor.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 10;
                ParCep.Value = Fornecedor.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Fornecedor.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 16;
                ParTelefone.Value = Fornecedor.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParWhatsapp = new SqlParameter();
                ParWhatsapp.ParameterName = "@whatsapp";
                ParWhatsapp.SqlDbType = SqlDbType.VarChar;
                ParWhatsapp.Size = 17;
                ParWhatsapp.Value = Fornecedor.Whatsapp;
                SqlCmd.Parameters.Add(ParWhatsapp);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Fornecedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Fornecedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

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


        //Metodo Editar
        public string Editar(DFornecedor Fornecedor)
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
                SqlCmd.CommandText = "speditar_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Fornecedor.Id;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParEmpresa = new SqlParameter();
                ParEmpresa.ParameterName = "@empresa";
                ParEmpresa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa.Size = 100;
                ParEmpresa.Value = Fornecedor.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa);

                SqlParameter ParContato = new SqlParameter();
                ParContato.ParameterName = "@contato";
                ParContato.SqlDbType = SqlDbType.VarChar;
                ParContato.Size = 50;
                ParContato.Value = Fornecedor.Contato;
                SqlCmd.Parameters.Add(ParContato);

                SqlParameter ParSetorComercial = new SqlParameter();
                ParSetorComercial.ParameterName = "@setor_comercial";
                ParSetorComercial.SqlDbType = SqlDbType.VarChar;
                ParSetorComercial.Size = 50;
                ParSetorComercial.Value = Fornecedor.Setor_Comercial;
                SqlCmd.Parameters.Add(ParSetorComercial);


                SqlParameter ParDoc_Principal = new SqlParameter();
                ParDoc_Principal.ParameterName = "@doc_principal";
                ParDoc_Principal.SqlDbType = SqlDbType.VarChar;
                ParDoc_Principal.Size = 4;
                ParDoc_Principal.Value = Fornecedor.Doc_Principal;
                SqlCmd.Parameters.Add(ParDoc_Principal);

                SqlParameter ParNum_Doc_Principal = new SqlParameter();
                ParNum_Doc_Principal.ParameterName = "@num_doc_principal";
                ParNum_Doc_Principal.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc_Principal.Size = 20;
                ParNum_Doc_Principal.Value = Fornecedor.Num_Doc_Principal;
                SqlCmd.Parameters.Add(ParNum_Doc_Principal);

                SqlParameter ParDoc_Secundario = new SqlParameter();
                ParDoc_Secundario.ParameterName = "@doc_secundario";
                ParDoc_Secundario.SqlDbType = SqlDbType.VarChar;
                ParDoc_Secundario.Size = 4;
                ParDoc_Secundario.Value = Fornecedor.Doc_Secundario;
                SqlCmd.Parameters.Add(ParDoc_Secundario);

                SqlParameter ParNum_Doc_Secundario = new SqlParameter();
                ParNum_Doc_Secundario.ParameterName = "@num_doc_secundario";
                ParNum_Doc_Secundario.SqlDbType = SqlDbType.VarChar;
                ParNum_Doc_Secundario.Size = 20;
                ParNum_Doc_Secundario.Value = Fornecedor.Num_Doc_Secundario;
                SqlCmd.Parameters.Add(ParNum_Doc_Secundario);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Fornecedor.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Fornecedor.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Fornecedor.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 10;
                ParCep.Value = Fornecedor.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Fornecedor.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 16;
                ParTelefone.Value = Fornecedor.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParWhatsapp = new SqlParameter();
                ParWhatsapp.ParameterName = "@whatsapp";
                ParWhatsapp.SqlDbType = SqlDbType.VarChar;
                ParWhatsapp.Size = 17;
                ParWhatsapp.Value = Fornecedor.Whatsapp;
                SqlCmd.Parameters.Add(ParWhatsapp);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Fornecedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Fornecedor.Url;
                SqlCmd.Parameters.Add(ParUrl);

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


        //Metodo Excluir 
        public string Excluir(DFornecedor Fornecedor)
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
                SqlCmd.CommandText = "spdeletar_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Fornecedor.Id;
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
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_fornecedor";
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


        //Metodo Buscar pela Empresa
        public DataTable BuscarEmpresa(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fornecedor_empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Fornecedor.TextoBuscar;
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


        //Metodo Buscar pelo Nº Doc Principal 
        public DataTable BuscarDocPrincipal(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fornecedor_doc_principal";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Fornecedor.TextoBuscar;
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


        //Metodo Buscar pelo Nº Doc Secundario 
        public DataTable BuscarDocSecundario(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fornecedor_doc_secundario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Fornecedor.TextoBuscar;
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
    }
}
