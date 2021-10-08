using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDados_FP_Cheque_Orcamento
    {
        // Inserir
        public static string Inserir(int idorcamento, DateTime data, string banco_emissor, string nome_titular, string num_cheque, string num_parcela, decimal valor, DateTime depositar_dia)
        {
            DDados_FP_Cheque_Orcamento Obj = new DDados_FP_Cheque_Orcamento();
            Obj.IdOrcamento = idorcamento;
            Obj.Data = data;
            Obj.Banco_Emissor = banco_emissor;
            Obj.Nome_Titular = nome_titular;
            Obj.Num_Cheque = num_cheque;
            Obj.Num_parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Depositar_Dia = depositar_dia;
            return Obj.Inserir(Obj);
        }

        //Método Mostrar Dados Forma PGTO
        public static DataTable Mostrar(int idorcamento)
        {
            return new DDados_FP_Cheque_Orcamento().Mostrar(idorcamento);
        }
    }
}
