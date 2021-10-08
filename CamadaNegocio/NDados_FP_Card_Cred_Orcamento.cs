using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDados_FP_Card_Cred_Orcamento
    {
        //Medoto Inserir
        public static string Inserir(int idorcamento, string bandeira, decimal valor_parcelas, int qtd_parcelas)
        {
            DDados_FP_Card_Cred_Orcamento Obj = new DDados_FP_Card_Cred_Orcamento();
            Obj.IdOrcamento = idorcamento;
            Obj.Bandeira = bandeira;
            Obj.Valor_Parcelas = valor_parcelas;
            Obj.Qtd_Parcelas = qtd_parcelas;
            return Obj.Inserir(Obj);
        }

        //Método Mostrar Dados 
        public static DataTable Mostrar(int idorcamento)
        {
            return new DDados_FP_Card_Cred_Orcamento().Mostrar(idorcamento);
        }
    }
}
