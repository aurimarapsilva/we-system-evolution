using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_OS
    {
        //Medoto Editar
        public static string Editar(string clausula1, string clausula2, string clausula3)
        {
            DConfig_OS Obj = new DConfig_OS();
            Obj.Clausula1 = clausula1;
            Obj.Clausula2 = clausula2;
            Obj.Clausula3 = clausula3;
            return Obj.Editar(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_OS().Mostrar();
        }
    }
}
