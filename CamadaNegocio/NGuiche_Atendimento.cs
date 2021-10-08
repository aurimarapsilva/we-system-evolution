using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NGuiche_Atendimento
    {
        //Medoto Inserir
        public static string Inserir(string nome)
        {
            DGuiche_Atendimento Obj = new DGuiche_Atendimento();
            Obj.Nome = nome;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int id, string nome)
        {
            DGuiche_Atendimento Obj = new DGuiche_Atendimento();
            Obj.IdGuiche_Atendimento = id;
            Obj.Nome = nome;
            return Obj.Editar(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int id)
        {
            DGuiche_Atendimento Obj = new DGuiche_Atendimento();
            Obj.IdGuiche_Atendimento = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DGuiche_Atendimento().Mostrar();
        }


        //Metodo Buscar pelo nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DGuiche_Atendimento Obj = new DGuiche_Atendimento();
            return Obj.BuscarNome(textobuscar);
        }
    }
}
