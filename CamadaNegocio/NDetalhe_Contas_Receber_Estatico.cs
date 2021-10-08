using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDetalhe_Contas_Receber_Estatico
    {
        //Medoto Inserir
        public static string Inserir(int idvenda, int idcliente, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs)
        {
            DDetalhe_Contas_Receber_Estatico Obj = new DDetalhe_Contas_Receber_Estatico();
            Obj.IdVenda = idvenda;
            Obj.IdCliente = idcliente;
            Obj.Num_Parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Vencimento = vencimento;
            Obj.Estado = estado;
            Obj.Obs = obs;
            return Obj.Inserir(Obj);
        }
    }
}
