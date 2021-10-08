using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NRemetente
    {
        //Medoto Editar
        public static string Editar(int idremetente,  byte[] logo, string telefone, string email, string url, string categoria_empresa, decimal aliquota)
        {
            DRemetente Obj = new DRemetente();
            Obj.IdRemetente = idremetente;
            Obj.Logo = logo;
            Obj.Telefone = telefone;
            Obj.Email = email;
            Obj.Url = url;
            Obj.Categoria_Empresa = categoria_empresa;
            Obj.Aliquota = aliquota;
            return Obj.Editar(Obj);
        }

        //Metodo Atualizar Status da Licença - BLOQUEADO
        public static string Atualizar_Status_Licença_Bloqueado()
        {
            return new DRemetente().Atualizar_Status_Licença_Bloqueado();
        }


        //Metodo Atualizar Status da Licença - DESATIVADO
        public static string Atualizar_Status_Licença_Desativado(string data_atual)
        {
            return new DRemetente().Atualizar_Status_Licença_Desativado(data_atual);
        }


        //Metodo Atualizar Status da Licença - ATIVO
        public static string Atualizar_Status_Licença_Ativo()
        {
            return new DRemetente().Atualizar_Status_Licença_Ativo();
        }

        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DRemetente().Mostrar();
        }
    }
}
