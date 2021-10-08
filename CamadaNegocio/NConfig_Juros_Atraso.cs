using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_Juros_Atraso
    {
        // Editar
        public static string Editar(decimal juros_diario, decimal multa, string habilitar)
        {
            DConfig_Juros_Atraso Obj = new DConfig_Juros_Atraso();
            Obj.Juros_Diario = juros_diario;
            Obj.Multa = multa;
            Obj.Habilitar = habilitar;
            return Obj.Editar(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_Juros_Atraso().Mostrar();
        }
    }
}
