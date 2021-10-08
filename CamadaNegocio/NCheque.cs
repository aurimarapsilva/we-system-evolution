using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCheque
    {
        // Inserir
        public static string Inserir(int idremetente, DateTime data, string banco_emissor, string nome_titular, string num_cheque, int idvenda, int idguiche_atendimento, int idfuncionario, string num_parcela, decimal valor, DateTime depositar_dia, string estado)
        {
            DCheque Obj = new DCheque();
            Obj.IdRemetente = idremetente;
            Obj.Data = data;
            Obj.Banco_Emissor = banco_emissor;
            Obj.Nome_Titular = nome_titular;
            Obj.Num_Cheque = num_cheque;
            Obj.IdVenda = idvenda;
            Obj.IdGuiche_Atendimento = idguiche_atendimento;
            Obj.IdFuncionario = idfuncionario;
            Obj.Num_parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Depositar_Dia = depositar_dia;
            Obj.Estado = estado;
            return Obj.Inserir(Obj);
        }

        // Metodo Atualizar Status - DEPOSITADO
        public static string Atualizar_Status_Depositado(int id)
        {
            DCheque Obj = new DCheque();
            Obj.IdCheque = id;
            return Obj.Atualizar_Status_Depositado(Obj);
        }


        // Metodo Atualizar Status - DEVOLVIDO
        public static string Atualizar_Status_Devolvido(int id)
        {
            DCheque Obj = new DCheque();
            Obj.IdCheque = id;
            return Obj.Atualizar_Status_Devolvido(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DCheque Obj = new DCheque();
            Obj.IdCheque = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DCheque().Mostrar();
        }


        //Metodo Buscar Cheque Depositar Hoje
        public static DataTable Buscar_Depositar_Hoje(string data_atual)
        {
            return new DCheque().Buscar_Depositar_Hoje(data_atual);
        }

        //Metodo Buscar Cheque Depositado
        public static DataTable Buscar_Depositado()
        {
            return new DCheque().Buscar_Depositado();
        }


        //Metodo Buscar Cheque Aguardando
        public static DataTable Buscar_Aguardando()
        {
            return new DCheque().Buscar_Aguardando();
        }


        //Metodo Buscar Cheque Devolvido
        public static DataTable Buscar_Devolvido()
        {
            return new DCheque().Buscar_Devolvido();
        }
    }
}
