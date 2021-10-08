using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_Orcamento
    {
        //Medoto Editar
        public static string Editar(string texto)
        {
            DConfig_Orcamento Obj = new DConfig_Orcamento();
            Obj.Texto = texto;
            return Obj.Editar(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_Orcamento().Mostrar();
        }
    }
}
