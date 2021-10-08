using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NInfo_Config_Backup
    {
        //Medoto Inserir
        public static string Inserir_Automatico(DateTime data_ultimo_bkp, DateTime data_proximo_bkp)
        {
            DInfo_Config_Backup Obj = new DInfo_Config_Backup();
            Obj.Data_Ultimo_BKP = data_ultimo_bkp;
            Obj.Data_Proximo_BKP = data_proximo_bkp;
            return Obj.Inserir_Automatico(Obj);
        }

        //Medoto Editar Usuario
        public static string Editar_Usuario(int idinfo_config_backup, string diretorio, int intervalo_bkp, string bkp_auto)
        {
            DInfo_Config_Backup Obj = new DInfo_Config_Backup();
            Obj.IdInfo_Config_Backup = idinfo_config_backup;
            Obj.Diretorio = diretorio;
            Obj.Intervalo_BKP = intervalo_bkp;
            Obj.BKP_Auto = bkp_auto;
            return Obj.Editar_Usuario(Obj);
        }


        //Medoto Editar Automatico
        public static string Editar_Automatico(DateTime data_ultimo_bkp, DateTime data_proximo_bkp)
        {
            DInfo_Config_Backup Obj = new DInfo_Config_Backup();
            Obj.Data_Ultimo_BKP = data_ultimo_bkp;
            Obj.Data_Proximo_BKP = data_proximo_bkp;
            return Obj.Editar_Automatico(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DInfo_Config_Backup().Mostrar();
        }
    }
}
