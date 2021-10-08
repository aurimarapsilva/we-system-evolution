using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCartao_Debito
    {
        // Inserir
        public static string Inserir(string bandeira, DateTime data, int idvenda, int idguiche_atendimento, int idfuncionario, string num_parcela, decimal valor, decimal valor_liquido, DateTime data_compensacao)
        {
            DCartao_Debito Obj = new DCartao_Debito();
            Obj.Bandeira = bandeira;
            Obj.Data = data;
            Obj.IdVenda = idvenda;
            Obj.IdGuiche_Atendimento = idguiche_atendimento;
            Obj.IdFuncionario = idfuncionario;
            Obj.Num_parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Valor_Liquido = valor_liquido;
            Obj.Data_Compensacao = data_compensacao;
            return Obj.Inserir(Obj);
        }

        //Medoto Deletar
        public static string Excluir(int id)
        {
            DCartao_Debito Obj = new DCartao_Debito();
            Obj.IdCartao_Debito = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DCartao_Debito().Mostrar();
        }


        //Método Mostrar Cartao Credito Compensar
        public static DataTable Mostrar_Cartao_Debito_Compensar(string Data_Atual)
        {
            DCartao_Debito Obj = new DCartao_Debito();
            return Obj.Mostrar_Cartao_Debito_Compensar(Data_Atual);
        }


        //Método Buscar por Datas
        public static DataTable Buscar_Datas(string Data_Inicial, string Data_Final)
        {
            DCartao_Debito Obj = new DCartao_Debito();
            return Obj.Buscar_Datas(Data_Inicial, Data_Final);
        }
    }
}
