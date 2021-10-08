using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCaixa_Operacao_Dia
    {
        // Inserir
        public static string Inserir(int idguiche_atendimento, string nome_guiche, int idfuncionario, string nome_funcionario, DateTime data, string aberto, string fechado, decimal valor_inicial, decimal entrada_cartao_credito, decimal entrada_cheque, decimal entrada_cartao_debito, decimal entrada_crediario_loja, decimal entrada_dinheiro, decimal entrada_total)
        {
            DCaixa_Operacao_Dia Obj = new DCaixa_Operacao_Dia();
            Obj.IdGuiche_Atendimento = idguiche_atendimento;
            Obj.Nome_Guiche = nome_guiche;
            Obj.IdFuncionario = idfuncionario;
            Obj.Nome_Funcionario = nome_funcionario;
            Obj.Data = data;
            Obj.Aberto = aberto;
            Obj.Fechado = fechado;
            Obj.Valor_Inicial = valor_inicial;
            Obj.Entrada_Cartao_Credito = entrada_cartao_credito;
            Obj.Entrada_Cheque = entrada_cheque;
            Obj.Entrada_Cartao_Debito = entrada_cartao_debito;
            Obj.Entrada_Crediario_Loja = entrada_crediario_loja;
            Obj.Entrada_Dinheiro = entrada_dinheiro;
            Obj.Entrada_Total = entrada_total;
            return Obj.Inserir(Obj);
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            DCaixa_Operacao_Dia Obj = new DCaixa_Operacao_Dia();
            return Obj.Mostrar();
        }

        //Metodo Pesquisar por Caixa
        public static DataTable BuscarCaixa(string textobuscar)
        {
            DCaixa_Operacao_Dia Obj = new DCaixa_Operacao_Dia();
            return Obj.BuscarCaixa(textobuscar);
        }

        //Metodo Pesquisar por Funcionario
        public static DataTable BuscarFuncionario(string textobuscar)
        {
            DCaixa_Operacao_Dia Obj = new DCaixa_Operacao_Dia();
            return Obj.BuscarFuncionario(textobuscar);
        }

        //Metodo Pesquisar por Funcionario
        public static DataTable BuscarDatas(string textobuscar, string textobuscar2)
        {
            DCaixa_Operacao_Dia Obj = new DCaixa_Operacao_Dia();
            return Obj.BuscarDatas(textobuscar, textobuscar2);
        }
    }
}
