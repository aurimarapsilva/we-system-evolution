using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;


namespace CamadaNegocio
{
    public class NFeriado
    {
        //Medoto Base de Dados de Feriados
        public static string Atualizar_Base_Dados(int idferiado, DateTime feriado)
        {
            DFeriado Obj = new DFeriado();
            Obj.IdFeriado = idferiado;
            Obj.Feriado = feriado;
            return Obj.Atualizar_Base_Dados(Obj);
        }

        //Metodo Mostrar Feriado
        public static DataTable Mostrar_Feriado()
        {
            return new DFeriado().Mostrar_Feriado();
        }

        //Metodo Buscar Feriado
        public static DataTable Buscar_Feriado(string data)
        {
            DFeriado Obj = new DFeriado();
            return Obj.Buscar_Feriado(data);
        }



        // Atualizar Detalhe Feriado
        public static string Atualizar_Detalhe_Feriado(DateTime atualizar)
        {
            DFeriado Obj = new DFeriado();
            return Obj.Atualizar_Detalhe_Feriado(atualizar);
        }

        // Mostrar Detalhe Feriado
        public static DataTable Mostrar_Detalhe_Feriado()
        {
            return new DFeriado().Mostrar_Detalhe_Feriado();
        }
    }
}
