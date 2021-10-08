using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NUnid_Medida
    {
        //Medoto Inserir
        public static string Inserir(string unidade)
        {
            DUnid_Medida Obj = new CamadaDados.DUnid_Medida();
            Obj.Unidade = unidade;
            return Obj.Inserir(Obj);
        }

        //Medoto Editar
        public static string Editar(int idunid_medida, string unidade)
        {
            DUnid_Medida Obj = new CamadaDados.DUnid_Medida();
            Obj.Idunid_medida = idunid_medida;
            Obj.Unidade = unidade;
            return Obj.Editar(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int idunid_medida)
        {
            DUnid_Medida Obj = new CamadaDados.DUnid_Medida();
            Obj.Idunid_medida = idunid_medida;
            return Obj.Excluir(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DUnid_Medida().Mostrar();
        }


        //Metodo Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DUnid_Medida Obj = new DUnid_Medida();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
