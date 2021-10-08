using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCliente
    {
        //Medoto Inserir
        public static string Inserir(string nome_completo, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, decimal limite_credito)
        {
            DCliente Obj = new DCliente();
            Obj.Nome_Completo = nome_completo;
            Obj.Foto = foto;
            Obj.Sexo = sexo;
            Obj.Data_Nasc = data_nasc;
            Obj.Num_Rg = num_rg;
            Obj.Num_Cpf = num_cpf;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Limite_Credito = limite_credito;
         
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int id, string nome_completo, byte[] foto, string sexo, DateTime data_nasc, string num_rg, string num_cpf, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string celular, string email, decimal limite_credito)
        {
            DCliente Obj = new DCliente();
            Obj.Id = id;
            Obj.Nome_Completo = nome_completo;
            Obj.Foto = foto;
            Obj.Sexo = sexo;
            Obj.Data_Nasc = data_nasc;
            Obj.Num_Rg = num_rg;
            Obj.Num_Cpf = num_cpf;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Limite_Credito = limite_credito;

            return Obj.Editar(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DCliente Obj = new DCliente();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }


        //Metodo Buscar pelo Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }


        //Metodo Buscar pelo RG
        public static DataTable BuscarRG(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRG(Obj);
        }


        //Metodo Buscar pelo CPF
        public static DataTable BuscarCPF(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarCPF(Obj);
        }
    }
}
