using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDetalhe_OS
    {
        // Inserir
        public static string Inserir(int idos, int idproduto, decimal quant, decimal preco_venda)
        {
            DDetalhe_OS Obj = new DDetalhe_OS();
            Obj.IdOS = idos;
            Obj.IdProduto = idproduto;
            Obj.Quant = quant;
            Obj.Preco_Venda = preco_venda;

            return Obj.Inserir_DetalheOS(Obj);
        }
    }
}
