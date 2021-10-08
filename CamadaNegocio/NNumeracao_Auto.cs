using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NNumeracao_Auto
    {
        //Medoto Editar Numeração Automática - VENDAS
        public static string Editar_Num_Auto_Venda(int id, int inicio_venda, int atual_venda, string estado_venda)
        {
            DNumeracao_Auto Obj = new DNumeracao_Auto();
            Obj.IdNumeracao_Auto = id;
            Obj.Inicio_Venda = inicio_venda;
            Obj.Atual_Venda = atual_venda;
            Obj.Estado_Venda = estado_venda;
            return Obj.Editar_Num_Auto_Venda(Obj);
        }


        //Medoto Editar Numeração Automática - OS
        public static string Editar_Num_Auto_OS(int id, int inicio_os, int atual_os, string estado_os)
        {
            DNumeracao_Auto Obj = new DNumeracao_Auto();
            Obj.IdNumeracao_Auto = id;
            Obj.Inicio_OS = inicio_os;
            Obj.Atual_OS = atual_os;
            Obj.Estado_OS = estado_os;
            return Obj.Editar_Num_Auto_OS(Obj);
        }

        //Medoto Editar Numeração Automática - ORÇAMENTO
        public static string Editar_Num_Auto_Orcamento(int inicio_orcamento, int atual_orcamento, string estado_orcamento)
        {
            DNumeracao_Auto Obj = new DNumeracao_Auto();
            Obj.Inicio_Orcamento = inicio_orcamento;
            Obj.Atual_Orcamento = atual_orcamento;
            Obj.Estado_Orcamento = estado_orcamento;
            return Obj.Editar_Num_Auto_Orcamento(Obj);
        }

        //Metodo Mostrar 
        public static DataTable Mostrar()
        {
            return new DNumeracao_Auto().Mostrar();
        }


        //Metodo Mostrar Inicio Numeração Automatica LIVRO CAIXA
        public static DataTable Mostrar_Num_Auto_Livro_Caixa()
        {
            return new DNumeracao_Auto().Mostrar_Num_Auto_Livro_Caixa();
        }

        
        //Metodo Mostrar Inicio Numeração Automatica VENDA
        public static DataTable Mostrar_Num_Auto_Venda()
        {
            return new DNumeracao_Auto().Mostrar_Num_Auto_Venda();
        }

        //Metodo Mostrar Inicio Numeração Automatica OS
        public static DataTable Mostrar_Num_Auto_OS()
        {
            return new DNumeracao_Auto().Mostrar_Num_Auto_OS();
        }

        //Metodo Mostrar Inicio Numeração Automatica - ORÇAMENTO
        public static DataTable Mostrar_Num_Auto_Orcamento()
        {
            return new DNumeracao_Auto().Mostrar_Num_Auto_Orcamento();
        }
    }
}
