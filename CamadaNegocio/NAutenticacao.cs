using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NAutenticacao
    {
        //Medoto Editar
        public static string Editar(int id, string autentication_key)
        {
            DAutenticacao Obj = new DAutenticacao();
            Obj.IdAutenticacao = id;
            Obj.Autentication_Key = autentication_key;
            return Obj.Editar(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int id)
        {
            DAutenticacao Obj = new DAutenticacao();
            Obj.IdAutenticacao = id;
            return Obj.Excluir(Obj);
        }


        //Método Mostrar Autenticacao - APENAS VENCIDAS
        public static DataTable Mostrar_Autenticacao(string data_atual)
        {
            DAutenticacao Obj = new DAutenticacao();
            return Obj.Mostrar(data_atual);
        }


        //Método Mostrar Autenticacao - TUDO
        public static DataTable Mostrar_Tudo()
        {
            DAutenticacao Obj = new DAutenticacao();
            return Obj.Mostrar_Tudo();
        }
    }
}
