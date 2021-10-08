using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_Cartao_Debito
    {
        //Medoto Inserir
        public static string Inserir(string bandeira, int prazo_compensacao, decimal taxa)
        {
            DConfig_Cartao_Debito Obj = new DConfig_Cartao_Debito();
            Obj.Bandeira = bandeira;
            Obj.Prazo_Compensacao = prazo_compensacao;
            Obj.Taxa = taxa;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int idconfig_cartao_debito, string bandeira, int prazo_compensacao, decimal taxa)
        {
            DConfig_Cartao_Debito Obj = new DConfig_Cartao_Debito();
            Obj.IdConfig_Cartao_Debito = idconfig_cartao_debito;
            Obj.Bandeira = bandeira;
            Obj.Prazo_Compensacao = prazo_compensacao;
            Obj.Taxa = taxa;
            return Obj.Editar(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_Cartao_Debito().Mostrar();
        }
    }
}
