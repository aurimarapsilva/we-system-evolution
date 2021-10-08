using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NTecnico
    {
        //Medoto Inserir
        public static string Inserir(string nome_completo)
        {
            DTecnico Obj = new DTecnico();
            Obj.Nome_Completo = nome_completo;
            return Obj.Inserir(Obj);
        }

        //Medoto Editar
        public static string Editar(int id, string nome_completo)
        {
            DTecnico Obj = new DTecnico();
            Obj.Id = id;
            Obj.Nome_Completo = nome_completo;
            return Obj.Editar(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int id)
        {
            DTecnico Obj = new DTecnico();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DTecnico().Mostrar();
        }

        //Metodo Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DTecnico Obj = new DTecnico();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
