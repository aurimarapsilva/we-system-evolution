using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NTipo_Produto
    {
        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DTipo_Produto().Mostrar();
        }
    }
}
