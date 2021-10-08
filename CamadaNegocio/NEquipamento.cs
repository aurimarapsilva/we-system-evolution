using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NEquipamento
    {
        //Medoto Inserir
        public static string Inserir(string nome)
        {
            DEquipamento Obj = new DEquipamento();
            Obj.Nome = nome;
            return Obj.Inserir(Obj);
        }

        //Medoto Editar
        public static string Editar(int id, string nome)
        {
            DEquipamento Obj = new DEquipamento();
            Obj.Id = id;
            Obj.Nome = nome;
            return Obj.Editar(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int id)
        {
            DEquipamento Obj = new DEquipamento();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DEquipamento().Mostrar();
        }

        //Metodo Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DEquipamento Obj = new DEquipamento();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
