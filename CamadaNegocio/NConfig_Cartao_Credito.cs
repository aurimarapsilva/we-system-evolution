using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NConfig_Cartao_Credito
    {
        //Medoto Inserir
        public static string Inserir(string bandeira, int prazo_compens_1_parc, int prazo_compens_demais_parc, decimal taxa)
        {
            DConfig_Cartao_Credito Obj = new DConfig_Cartao_Credito();
            Obj.Bandeira = bandeira;
            Obj.Prazo_Compens_1_Parc = prazo_compens_1_parc;
            Obj.Prazo_Compens_Demais_Parc = prazo_compens_demais_parc;
            Obj.Taxa = taxa;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int idconfig_cartao_credito, string bandeira, int prazo_compens_1_parc, int prazo_compens_demais_parc, decimal taxa)
        {
            DConfig_Cartao_Credito Obj = new DConfig_Cartao_Credito();
            Obj.IdConfig_Cartao_Credito = idconfig_cartao_credito;
            Obj.Bandeira = bandeira;
            Obj.Prazo_Compens_1_Parc = prazo_compens_1_parc;
            Obj.Prazo_Compens_Demais_Parc = prazo_compens_demais_parc;
            Obj.Taxa = taxa;
            return Obj.Editar(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DConfig_Cartao_Credito().Mostrar();
        }
    }
}
