using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDados_FP_Card_Deb_Orcamento
    {
        //Medoto Inserir
        public static string Inserir(int idorcamento, string bandeira)
        {
            DDados_FP_Card_Deb_Orcamento Obj = new DDados_FP_Card_Deb_Orcamento();
            Obj.IdOrcamento = idorcamento;
            Obj.Bandeira = bandeira;
            return Obj.Inserir(Obj);
        }

        //Método Mostrar Dados 
        public static DataTable Mostrar(int idorcamento)
        {
            return new DDados_FP_Card_Deb_Orcamento().Mostrar(idorcamento);
        }
    }
}
