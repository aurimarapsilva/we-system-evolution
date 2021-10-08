using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NFuncionario
    {
        //Medoto Inserir
        public static string Inserir(string nome, string sobrenome, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string cargo, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, int nivel_acesso, string usuario, string senha, decimal comissao, string tipo_comissao, decimal salario)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Foto = foto;
            Obj.Sexo = sexo;
            Obj.Data_Nasc = data_nasc;
            Obj.Num_Rg = num_rg;
            Obj.Num_Cpf = num_cpf;
            Obj.Cargo = cargo;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Nivel_Acesso = nivel_acesso;
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            Obj.Comissao = comissao;
            Obj.Tipo_Comissao = tipo_comissao;
            Obj.Salario = salario;
            return Obj.Inserir(Obj);
        }

        //Medoto Editar
        public static string Editar(int id, string nome, string sobrenome, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string cargo, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, int nivel_acesso, string usuario, string senha, decimal comissao, string tipo_comissao, decimal salario)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.Id = id;
            Obj.Nome = nome;
            Obj.Sobrenome = sobrenome;
            Obj.Foto = foto;
            Obj.Sexo = sexo;
            Obj.Data_Nasc = data_nasc;
            Obj.Num_Rg = num_rg;
            Obj.Num_Cpf = num_cpf;
            Obj.Cargo = cargo;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Nivel_Acesso = nivel_acesso;
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            Obj.Comissao = comissao;
            Obj.Tipo_Comissao = tipo_comissao;
            Obj.Salario = salario;
            return Obj.Editar(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DFuncionario().Mostrar();
        }


        //Metodo Buscar pelo Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }


        //Metodo Buscar pelo RG
        public static DataTable BuscarRG(string textobuscar)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRG(Obj);
        }


        //Metodo Buscar pelo CPF
        public static DataTable BuscarCPF(string textobuscar)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCPF(Obj);
        }

        //Metodo Buscar pelo ID
        public static DataTable Buscar_ID(string textobuscar)
        {
            DFuncionario Obj = new DFuncionario();
            return Obj.Buscar_ID(textobuscar);
        }

        //Metodo Login
        public static DataTable Login(string usuario, string senha)
        {
            DFuncionario Obj = new DFuncionario();
            Obj.Usuario = usuario;
            Obj.Senha = senha;
            return Obj.login(Obj);
        }


        //Metodo Requerimento de permissão
        public static DataTable Requerimento_Permissão(string senha)
        {
            DFuncionario Obj = new DFuncionario();
            return Obj.Requerimento_Permissao(senha);
        }


        //Metodo Mostrar Tudo
        public static DataTable Mostrar_Tudo()
        {
            return new DFuncionario().Mostrar_Tudo();
        }
    }
}
