using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NFornecedor
    {
        //Medoto Inserir
        public static string Inserir(string empresa, string contato, string setor_comercial, string doc_principal, string num_doc_principal, string doc_secundario, string num_doc_secundario, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string whatsapp, string email, string url)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.Empresa = empresa;
            Obj.Contato = contato;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Doc_Principal = doc_principal;
            Obj.Num_Doc_Principal = num_doc_principal;
            Obj.Doc_Secundario = doc_secundario;
            Obj.Num_Doc_Secundario = num_doc_secundario;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Whatsapp = whatsapp;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int id, string empresa, string contato, string setor_comercial, string doc_principal, string num_doc_principal, string doc_secundario, string num_doc_secundario, string endereco, string bairro, string cidade, string cep, string uf, string telefone, string whatsapp, string email, string url)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.Id = id;
            Obj.Empresa = empresa;
            Obj.Contato = contato;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Doc_Principal = doc_principal;
            Obj.Num_Doc_Principal = num_doc_principal;
            Obj.Doc_Secundario = doc_secundario;
            Obj.Num_Doc_Secundario = num_doc_secundario;
            Obj.Endereco = endereco;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Cep = cep;
            Obj.Uf = uf;
            Obj.Telefone = telefone;
            Obj.Whatsapp = whatsapp;
            Obj.Email = email;
            Obj.Url = url;
            return Obj.Editar(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DFornecedor().Mostrar();
        }


        //Metodo Buscar pela empresa
        public static DataTable BuscarEmpresa(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarEmpresa(Obj);
        }


        //Metodo Buscar pelo Nº Doc Principal
        public static DataTable BuscarDocPrincipal(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDocPrincipal(Obj);
        }


        //Metodo Buscar pelo Nº Doc Secundario
        public static DataTable BuscarDocSecundario(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarDocSecundario(Obj);
        }
    }
}
