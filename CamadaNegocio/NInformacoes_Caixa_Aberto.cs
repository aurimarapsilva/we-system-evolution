using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NInformacoes_Caixa_Aberto
    {
        //Medoto Inserir
        public static string Inserir(int idguiche_atendimento, string nome_guiche, int idfuncionario, string nome_funcionario, DateTime data_aberto, string hora_aberto, decimal valor_inicial_caixa)
        {
            DInformacoes_Caixa_Aberto Obj = new DInformacoes_Caixa_Aberto();
            Obj.Idguiche_Atendimento = idguiche_atendimento;
            Obj.Nome_Guiche = nome_guiche;
            Obj.Idfuncionario = idfuncionario;
            Obj.Nome_Funcionario = nome_funcionario;
            Obj.Data_Aberto = data_aberto;
            Obj.Hora_Aberto = hora_aberto;
            Obj.Valor_Inicial_Caixa = valor_inicial_caixa;
            return Obj.Inserir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar(string idfuncionario)
        {
            DInformacoes_Caixa_Aberto Obj = new DInformacoes_Caixa_Aberto();
            return Obj.Mostrar(idfuncionario); 
        }
    }
}
