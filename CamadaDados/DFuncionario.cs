using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFuncionario
    {
        private int _Id;
        private string _Nome;
        private string _Sobrenome;
        private byte[] _Foto;
        private string _Sexo;
        private DateTime _Data_Nasc;
        private string _Num_Rg;
        private string _Num_Cpf;
        private string _Cargo;
        private string _Endereco;
        private string _Bairro;
        private string _Cidade;
        private string _Cep;
        private string _Uf;
        private string _Telefone;
        private string _Celular;
        private string _Email;
        private int _Nivel_Acesso;
        private string _Usuario;
        private string _Senha;
        private decimal _Comissao;
        private string _Tipo_Comissao;
        private decimal _Salario;
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

        public string Nome
        {
            get
            {
                return _Nome;
            }

            set
            {
                _Nome = value;
            }
        }

        public string Sobrenome
        {
            get
            {
                return _Sobrenome;
            }

            set
            {
                _Sobrenome = value;
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

        public string Cargo
        {
            get
            {
                return _Cargo;
            }

            set
            {
                _Cargo = value;
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

        public int Nivel_Acesso
        {
            get
            {
                return _Nivel_Acesso;
            }

            set
            {
                _Nivel_Acesso = value;
            }
        }

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }

            set
            {
                _Senha = value;
            }
        }

        public decimal Comissao
        {
            get
            {
                return _Comissao;
            }

            set
            {
                _Comissao = value;
            }
        }

        public string Tipo_Comissao
        {
            get
            {
                return _Tipo_Comissao;
            }

            set
            {
                _Tipo_Comissao = value;
            }
        }

        public decimal Salario
        {
            get
            {
                return _Salario;
            }

            set
            {
                _Salario = value;
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
        public DFuncionario()
        {

        }

        //Construtor com parametros 
        public DFuncionario(int id, string nome, string sobrenome, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string cargo, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, int nivel_acesso, string usuario, string senha, decimal comissao, string tipo_comissao, decimal salario, string textobuscar)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Foto = foto;
            this.Sexo = sexo;
            this.Data_Nasc = data_nasc;
            this.Num_Rg = num_rg;
            this.Num_Cpf = num_cpf;
            this.Cargo = cargo;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Cep = cep;
            this.Uf = uf;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Nivel_Acesso = nivel_acesso;
            this.Usuario = usuario;
            this.Senha = senha;
            this.Comissao = comissao;
            this.Tipo_Comissao = tipo_comissao;
            this.Salario = salario;
            this.TextoBuscar = textobuscar;
        }


        //Metodo Inserir 
        public string Inserir(DFuncionario Funcionario)
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
                SqlCmd.CommandText = "spinserir_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 20;
                ParNome.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSobrenome = new SqlParameter();
                ParSobrenome.ParameterName = "@sobrenome";
                ParSobrenome.SqlDbType = SqlDbType.VarChar;
                ParSobrenome.Size = 50;
                ParSobrenome.Value = Funcionario.Sobrenome;
                SqlCmd.Parameters.Add(ParSobrenome);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Funcionario.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDataNasc = new SqlParameter();
                ParDataNasc.ParameterName = "@data_nasc";
                ParDataNasc.SqlDbType = SqlDbType.Date;
                ParDataNasc.Value = Funcionario.Data_Nasc;
                SqlCmd.Parameters.Add(ParDataNasc);

                SqlParameter ParNumRg = new SqlParameter();
                ParNumRg.ParameterName = "@num_rg";
                ParNumRg.SqlDbType = SqlDbType.VarChar;
                ParNumRg.Size = 15;
                ParNumRg.Value = Funcionario.Num_Rg;
                SqlCmd.Parameters.Add(ParNumRg);

                SqlParameter ParNum_Cpf = new SqlParameter();
                ParNum_Cpf.ParameterName = "@num_cpf";
                ParNum_Cpf.SqlDbType = SqlDbType.VarChar;
                ParNum_Cpf.Size = 14;
                ParNum_Cpf.Value = Funcionario.Num_Cpf;
                SqlCmd.Parameters.Add(ParNum_Cpf);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Funcionario.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Funcionario.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 10;
                ParCep.Value = Funcionario.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Funcionario.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 16;
                ParTelefone.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.VarChar;
                ParCelular.Size = 17;
                ParCelular.Value = Funcionario.Celular;
                SqlCmd.Parameters.Add(ParCelular);


                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParNivel_Acesso = new SqlParameter();
                ParNivel_Acesso.ParameterName = "@idnivel_acesso";
                ParNivel_Acesso.SqlDbType = SqlDbType.Int;
                ParNivel_Acesso.Value = Funcionario.Nivel_Acesso;
                SqlCmd.Parameters.Add(ParNivel_Acesso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParComissao = new SqlParameter();
                ParComissao.ParameterName = "@comissao";
                ParComissao.SqlDbType = SqlDbType.Decimal;
                ParComissao.Precision = 3;
                ParComissao.Scale = 2;
                ParComissao.Value = Funcionario.Comissao;
                SqlCmd.Parameters.Add(ParComissao);

                SqlParameter ParTipo_Comissao = new SqlParameter();
                ParTipo_Comissao.ParameterName = "@tipo_comissao";
                ParTipo_Comissao.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comissao.Size = 14;
                ParTipo_Comissao.Value = Funcionario.Tipo_Comissao;
                SqlCmd.Parameters.Add(ParTipo_Comissao);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@salario";
                ParSalario.SqlDbType = SqlDbType.Decimal;
                ParSalario.Precision = 7;
                ParSalario.Scale = 2;
                ParSalario.Value = Funcionario.Salario;
                SqlCmd.Parameters.Add(ParSalario);

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
        public string Editar(DFuncionario Funcionario)
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
                SqlCmd.CommandText = "speditar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Funcionario.Id;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 20;
                ParNome.Value = Funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParSobrenome = new SqlParameter();
                ParSobrenome.ParameterName = "@sobrenome";
                ParSobrenome.SqlDbType = SqlDbType.VarChar;
                ParSobrenome.Size = 50;
                ParSobrenome.Value = Funcionario.Sobrenome;
                SqlCmd.Parameters.Add(ParSobrenome);

                SqlParameter ParFoto = new SqlParameter();
                ParFoto.ParameterName = "@foto";
                ParFoto.SqlDbType = SqlDbType.Image;
                ParFoto.Value = Funcionario.Foto;
                SqlCmd.Parameters.Add(ParFoto);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = Funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParDataNasc = new SqlParameter();
                ParDataNasc.ParameterName = "@data_nasc";
                ParDataNasc.SqlDbType = SqlDbType.DateTime;
                ParDataNasc.Value = Funcionario.Data_Nasc;
                SqlCmd.Parameters.Add(ParDataNasc);

                SqlParameter ParNumRg = new SqlParameter();
                ParNumRg.ParameterName = "@num_rg";
                ParNumRg.SqlDbType = SqlDbType.VarChar;
                ParNumRg.Size = 15;
                ParNumRg.Value = Funcionario.Num_Rg;
                SqlCmd.Parameters.Add(ParNumRg);

                SqlParameter ParNum_Cpf = new SqlParameter();
                ParNum_Cpf.ParameterName = "@num_cpf";
                ParNum_Cpf.SqlDbType = SqlDbType.VarChar;
                ParNum_Cpf.Size = 14;
                ParNum_Cpf.Value = Funcionario.Num_Cpf;
                SqlCmd.Parameters.Add(ParNum_Cpf);

                SqlParameter ParCargo = new SqlParameter();
                ParCargo.ParameterName = "@cargo";
                ParCargo.SqlDbType = SqlDbType.VarChar;
                ParCargo.Size = 50;
                ParCargo.Value = Funcionario.Cargo;
                SqlCmd.Parameters.Add(ParCargo);

                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 100;
                ParEndereco.Value = Funcionario.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = Funcionario.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = Funcionario.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 10;
                ParCep.Value = Funcionario.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParUf = new SqlParameter();
                ParUf.ParameterName = "@uf";
                ParUf.SqlDbType = SqlDbType.VarChar;
                ParUf.Size = 2;
                ParUf.Value = Funcionario.Uf;
                SqlCmd.Parameters.Add(ParUf);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 16;
                ParTelefone.Value = Funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParCelular = new SqlParameter();
                ParCelular.ParameterName = "@celular";
                ParCelular.SqlDbType = SqlDbType.VarChar;
                ParCelular.Size = 17;
                ParCelular.Value = Funcionario.Celular;
                SqlCmd.Parameters.Add(ParCelular);


                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParNivel_Acesso = new SqlParameter();
                ParNivel_Acesso.ParameterName = "@idnivel_acesso";
                ParNivel_Acesso.SqlDbType = SqlDbType.Int;
                ParNivel_Acesso.Value = Funcionario.Nivel_Acesso;
                SqlCmd.Parameters.Add(ParNivel_Acesso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParComissao = new SqlParameter();
                ParComissao.ParameterName = "@comissao";
                ParComissao.SqlDbType = SqlDbType.Decimal;
                ParComissao.Precision = 3;
                ParComissao.Scale = 2;
                ParComissao.Value = Funcionario.Comissao;
                SqlCmd.Parameters.Add(ParComissao);

                SqlParameter ParTipo_Comissao = new SqlParameter();
                ParTipo_Comissao.ParameterName = "@tipo_comissao";
                ParTipo_Comissao.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comissao.Size = 14;
                ParTipo_Comissao.Value = Funcionario.Tipo_Comissao;
                SqlCmd.Parameters.Add(ParTipo_Comissao);

                SqlParameter ParSalario = new SqlParameter();
                ParSalario.ParameterName = "@salario";
                ParSalario.SqlDbType = SqlDbType.Decimal;
                ParSalario.Precision = 7;
                ParSalario.Scale = 2;
                ParSalario.Value = Funcionario.Salario;
                SqlCmd.Parameters.Add(ParSalario);

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
        public string Excluir(DFuncionario Funcionario)
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
                SqlCmd.CommandText = "spdeletar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Funcionario.Id;
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
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_funcionario";
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
        public DataTable BuscarNome(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_funcionario_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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
        public DataTable BuscarRG(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_funcionario_rg";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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
        public DataTable BuscarCPF(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_funcionario_cpf";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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

        //Metodo Buscar pelo ID
        public DataTable Buscar_ID(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_funcionario_id";
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

        //Metodo login
        public DataTable login(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Requerimento de Permissão
        public DataTable Requerimento_Permissao(string Senha)
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sprequerimento_permissao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 20;
                ParSenha.Value = Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Mostrar Tudo
        public DataTable Mostrar_Tudo()
        {
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_funcionario_tudo";
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
