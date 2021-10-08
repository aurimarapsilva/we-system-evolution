using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDetalhe_Config_Cartao_Debito
    {
        //Medoto Editar
        public static string Editar(int iddetalhe_config_cartao_debito, string compensacao_auto)
        {
            DDetalhe_Config_Cartao_Debito Obj = new DDetalhe_Config_Cartao_Debito();
            Obj.IdDetalhe_Config_Cartao_Debito = iddetalhe_config_cartao_debito;
            Obj.Compensacao_Auto = compensacao_auto;
            return Obj.Editar(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DDetalhe_Config_Cartao_Debito().Mostrar();
        }
    }
}
