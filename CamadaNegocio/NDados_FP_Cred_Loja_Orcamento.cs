using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDados_FP_Cred_Loja_Orcamento
    {
        //Medoto Inserir
        public static string Inserir(int idorcamento, int num_parcela, decimal valor, DateTime vencimento)
        {
            DDados_FP_Cred_Loja_Orcamento Obj = new DDados_FP_Cred_Loja_Orcamento();
            Obj.IdOrcamento = idorcamento;
            Obj.Num_Parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Vencimento = vencimento;
            return Obj.Inserir(Obj);
        }

        //Método Mostrar Dados Forma PGTO
        public static DataTable Mostrar(int idorcamento)
        {
            return new DDados_FP_Cred_Loja_Orcamento().Mostrar(idorcamento);
        }
    }
}
