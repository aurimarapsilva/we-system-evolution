using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NLivro_Caixa
    {
        //Medoto Atualizar Numeração Automática - LIVRO CAIXA Crédito
        public static string Atualizar_Num_Auto_Livro_Caixa_Credito(int atual_livro_caixa_credito)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            Obj.Atual_Livro_Caixa_Credito = atual_livro_caixa_credito;
          
            return Obj.Atualizar_Num_Auto_Livro_Caixa_Credito(Obj);
        }


        //Medoto Atualizar Numeração Automática - LIVRO CAIXA Debito
        public static string Atualizar_Num_Auto_Livro_Caixa_Debito(int atual_livro_caixa_debito)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            Obj.Atual_Livro_Caixa_Debito = atual_livro_caixa_debito;

            return Obj.Atualizar_Num_Auto_Livro_Caixa_Debito(Obj);
        }

        //Medoto Inserir
        public static string Inserir(DateTime data, string historico, string num_doc, decimal credito, decimal debito)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            Obj.Data = data;
            Obj.Historico = historico;
            Obj.Num_Doc = num_doc;
            Obj.Credito = credito;
            Obj.Debito = debito;
            return Obj.Inserir(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }


        //Medoto Deletar Usando Número do Documento
        public static string Excluir_UseNumDoc(string use_num_doc)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            Obj.Num_Doc = use_num_doc;
            return Obj.Excluir_UseNumDoc(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DLivro_Caixa().Mostrar();
        }


        //Método Buscar por Data
        public static DataTable BuscarData(string textobuscar, string textobuscar2)
        {
            DLivro_Caixa Obj = new DLivro_Caixa();
            return Obj.BuscarData(textobuscar, textobuscar2);
        }
    }
}
