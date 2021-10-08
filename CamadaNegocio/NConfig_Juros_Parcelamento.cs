using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_Juros_Parcelamento
    {
        // Editar
        public static string Editar(decimal juros_ao_mes_card_cred, decimal juros_ao_mes_cred_loja, string habilitar)
        {
            DConfig_Juros_Parcelamento Obj = new DConfig_Juros_Parcelamento();
            Obj.Juros_ao_Mes_Card_Cred = juros_ao_mes_card_cred;
            Obj.Juros_ao_Mes_Cred_Loja = juros_ao_mes_cred_loja;
            Obj.Habilitar = habilitar;
            return Obj.Editar(Obj);
        }
        
        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_Juros_Parcelamento().Mostrar();
        }
    }
}
