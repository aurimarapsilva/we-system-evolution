using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCliente
    {
        private int _Id;
        private string _Nome_Completo;
        private byte[] _Foto;
        private string _Sexo;
        private DateTime _Data_Nasc;
        private string _Num_Rg;
        private string _Num_Cpf;
        private string _Endereco;
        private string _Bairro;
        private string _Cidade;
        private string _Cep;
        private string _Uf;
        private string _Telefone;
        private string _Celular;
        private string _Email;
        private decimal _Limite_Credito;
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

        public string Nome_Completo
        {
            get
            {
                return _Nome_Completo;
            }

            set
            {
                _Nome_Completo = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return _Foto;
            }

            set
            {
                _Foto = value;
            }
        }

        public string Sexo
        {
            get
            {
                return _Sexo;
            }

            set
            {
                _Sexo = value;
            }
        }

        public DateTime Data_Nasc
        {
            get
            {
                return _Data_Nasc;
            }

            set
            {
                _Data_Nasc = value;
            }
        }

        public string Num_Rg
        {
            get
            {
                return _Num_Rg;
            }

            set
            {
                _Num_Rg = value;
            }
        }

        public string Num_Cpf
        {
            get
            {
                return _Num_Cpf;
            }

            set
            {
                _Num_Cpf = value;
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

        public string Celular
        {
            get
            {
                return _Celular;
            }

            set
            {
                _Celular = value;
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

        public decimal Limite_Credito
        {
            get
            {
                return _Limite_Credito;
            }

            set
            {
                _Limite_Credito = value;
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
        public DCliente()
        {

        }

        //Construtor com parametros 
        public DCliente(int id, string nome_completo, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, decimal limite_credito, string textobuscar)
        {
            this.Id = id;
            this.Nome_Completo = nome_completo;
            this.Foto = foto;
            this.Sexo = sexo;
            this.Data_Nasc = data_nasc;
            this.Num_Rg = num_rg;
            this.Num_Cpf = num_cpf;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Uf = uf;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Limite_Credito = limite_credito;
            this.TextoBuscar = textobuscar;
        }


        //Metodo Inserir 
        public string Inserir(DCliente Cliente)
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
                SqlCmd.CommandText = "spinserir_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNome_Completo = new SqlParameter();
                ParNome_Completo.ParameterName = "@nome_completo";
                ParNome_Completo.SqlDbType = SqlDbType.VarChar;
                ParNome_Completo.Size = 70;
                ParNome_Completo.Value = Cliente.Nome_Completo;
                SqlCmd.Parameters.Add(ParNome_Completo);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Cliente.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDataNasc = new SqlParameter();
                ParDataNasc.ParameterName = "@data_nasc";
                ParDataNasc.SqlDbType = SqlDbType.Date;
                ParDataNasc.Value = Cliente.Data_Nasc;
                SqlCmd.Parameters.Add(ParDataNasc);

                SqlParameter ParNumRg = new SqlParameter();
                ParNumRg.ParameterName = "@num_rg";
                ParNumRg.SqlDbType = SqlDbType.VarChar;
                ParNumRg.Size = 15;
                ParNumRg.Value = Cliente.Num_Rg;
                SqlCmd.Parameters.Add(ParNumRg);

                SqlParameter ParNum_Cpf = new SqlParameter();
                ParNum_Cpf.ParameterName = "@num_cpf";
                ParNum_Cpf.SqlDbType = SqlDbType.VarChar;
                ParNum_Cpf.Size = 16;
                ParNum_Cpf.Value = Cliente.Num_Cpf;
                SqlCmd.Parameters.Add(ParNum_Cpf);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Cliente.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 12;
                ParCep.Value = Cliente.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Cliente.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 16;
                ParTelefone.Value = Cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.VarChar;
                ParCelular.Size = 17;
                ParCelular.Value = Cliente.Celular;
                SqlCmd.Parameters.Add(ParCelular);
                
                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParLimite_Credito = new SqlParameter();
                ParLimite_Credito.ParameterName = "@limite_credito";
                ParLimite_Credito.SqlDbType = SqlDbType.Decimal;
                ParLimite_Credito.Precision = 7;
                ParLimite_Credito.Scale = 2;
                ParLimite_Credito.Value = Cliente.Limite_Credito;
                SqlCmd.Parameters.Add(ParLimite_Credito);

                
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
        public string Editar(DCliente Cliente)
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
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cliente.Id;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNome_Completo = new SqlParameter();
                ParNome_Completo.ParameterName = "@nome_completo";
                ParNome_Completo.SqlDbType = SqlDbType.VarChar;
                ParNome_Completo.Size = 70;
                ParNome_Completo.Value = Cliente.Nome_Completo;
                SqlCmd.Parameters.Add(ParNome_Completo);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Cliente.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Cliente.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDataNasc = new SqlParameter();
                ParDataNasc.ParameterName = "@data_nasc";
                ParDataNasc.SqlDbType = SqlDbType.Date;
                ParDataNasc.Value = Cliente.Data_Nasc;
                SqlCmd.Parameters.Add(ParDataNasc);

                SqlParameter ParNumRg = new SqlParameter();
                ParNumRg.ParameterName = "@num_rg";
                ParNumRg.SqlDbType = SqlDbType.VarChar;
                ParNumRg.Size = 11;
                ParNumRg.Value = Cliente.Num_Rg;
                SqlCmd.Parameters.Add(ParNumRg);

                SqlParameter ParNum_Cpf = new SqlParameter();
                ParNum_Cpf.ParameterName = "@num_cpf";
                ParNum_Cpf.SqlDbType = SqlDbType.VarChar;
                ParNum_Cpf.Size = 11;
                ParNum_Cpf.Value = Cliente.Num_Cpf;
                SqlCmd.Parameters.Add(ParNum_Cpf);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Cliente.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 8;
                ParCep.Value = Cliente.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Cliente.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 10;
                ParTelefone.Value = Cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.VarChar;
                ParCelular.Size = 11;
                ParCelular.Value = Cliente.Celular;
                SqlCmd.Parameters.Add(ParCelular);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParLimite_Credito = new SqlParameter();
                ParLimite_Credito.ParameterName = "@limite_credito";
                ParLimite_Credito.SqlDbType = SqlDbType.Money;
                ParLimite_Credito.Value = Cliente.Limite_Credito;
                SqlCmd.Parameters.Add(ParLimite_Credito);

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
        public string Excluir(DCliente Cliente)
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
                SqlCmd.CommandText = "spdeletar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Cliente.Id;
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
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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


        //Metodo Buscar por Nome
        public DataTable BuscarNome(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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


        //Metodo Buscar pelo RG
        public DataTable BuscarRG(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_rg";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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


        //Metodo Buscar pelo CPF
        public DataTable BuscarCPF(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente_cpf";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
