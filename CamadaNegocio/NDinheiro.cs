using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NDinheiro
    {
        // Inserir
        public static string Inserir(DateTime data, int idvenda, int idguiche_atendimento, int idfuncionario, string historico, decimal valor)
        {
            DDinheiro Obj = new DDinheiro();
            Obj.Data = data;
            Obj.IdVenda = idvenda;
            Obj.IdGuiche_Atendimento = idguiche_atendimento;
            Obj.IdFuncionario = idfuncionario;
            Obj.Historico = historico;
            Obj.Valor = valor;
            return Obj.Inserir(Obj);
        }
    }
}
