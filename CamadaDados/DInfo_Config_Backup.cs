using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DInfo_Config_Backup
    {
        private int _IdInfo_Config_Backup;
        private string _Diretorio;
        private DateTime _Data_Ultimo_BKP;
        private int _Intervalo_BKP;
        private DateTime _Data_Proximo_BKP;
        private string _BKP_Auto;

        public int IdInfo_Config_Backup
        {
            get
            {
                return _IdInfo_Config_Backup;
            }

            set
            {
                _IdInfo_Config_Backup = value;
            }
        }

        public string Diretorio
        {
            get
            {
                return _Diretorio;
            }

            set
            {
                _Diretorio = value;
            }
        }

        public DateTime Data_Ultimo_BKP
        {
            get
            {
                return _Data_Ultimo_BKP;
            }

            set
            {
                _Data_Ultimo_BKP = value;
            }
        }

        public int Intervalo_BKP
        {
            get
            {
                return _Intervalo_BKP;
            }

            set
            {
                _Intervalo_BKP = value;
            }
        }

        public DateTime Data_Proximo_BKP
        {
            get
            {
                return _Data_Proximo_BKP;
            }

            set
            {
                _Data_Proximo_BKP = value;
            }
        }

        public string BKP_Auto
        {
            get
            {
                return _BKP_Auto;
            }

            set
            {
                _BKP_Auto = value;
            }
        }

        public DInfo_Config_Backup()
        {

        }

        public DInfo_Config_Backup(int idinfo_config_backup, string diretorio, DateTime data_ultimo_bkp, int intervalo_bkp, DateTime data_proximo_bkp, string bkp_auto)
        {
            this.IdInfo_Config_Backup = idinfo_config_backup;
            this.Diretorio = diretorio;
            this.Data_Ultimo_BKP = data_ultimo_bkp;
            this.Intervalo_BKP = intervalo_bkp;
            this.Data_Proximo_BKP = data_proximo_bkp;
            this.BKP_Auto = bkp_auto;
        }


        //Metodo Inserir Datas BKP Automatico
        public string Inserir_Automatico(DInfo_Config_Backup Info_Config_Backup)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_config_bkp_auto_datas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idinfo_config_backup";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParData_Ultimo_BKP = new SqlParameter();
                ParData_Ultimo_BKP.ParameterName = "@data_ultimo_bkp";
                ParData_Ultimo_BKP.SqlDbType = SqlDbType.Date;
                ParData_Ultimo_BKP.Value = Info_Config_Backup.Data_Ultimo_BKP;
                SqlCmd.Parameters.Add(ParData_Ultimo_BKP);

                SqlParameter ParData_Proximo_BKP = new SqlParameter();
                ParData_Proximo_BKP.ParameterName = "@data_proximo_bkp";
                ParData_Proximo_BKP.SqlDbType = SqlDbType.Date;
                ParData_Proximo_BKP.Value = Info_Config_Backup.Data_Proximo_BKP;
                SqlCmd.Parameters.Add(ParData_Proximo_BKP);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Editar Configuração BKP - USUÁRIO
        public string Editar_Usuario(DInfo_Config_Backup Info_Config_Backup)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_info_config_backup_usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idinfo_config_backup";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Info_Config_Backup.IdInfo_Config_Backup;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParDiretorio = new SqlParameter();
                ParDiretorio.ParameterName = "@diretorio";
                ParDiretorio.SqlDbType = SqlDbType.VarChar;
                ParDiretorio.Size = 1500;
                ParDiretorio.Value = Info_Config_Backup.Diretorio;
                SqlCmd.Parameters.Add(ParDiretorio);

                SqlParameter ParIntervalo_BKP = new SqlParameter();
                ParIntervalo_BKP.ParameterName = "@intervalo_bkp";
                ParIntervalo_BKP.SqlDbType = SqlDbType.Int;
                ParIntervalo_BKP.Value = Info_Config_Backup.Intervalo_BKP;
                SqlCmd.Parameters.Add(ParIntervalo_BKP);

                SqlParameter ParBKP_Auto = new SqlParameter();
                ParBKP_Auto.ParameterName = "@bkp_auto";
                ParBKP_Auto.SqlDbType = SqlDbType.VarChar;
                ParBKP_Auto.Size = 3;
                ParBKP_Auto.Value = Info_Config_Backup.BKP_Auto;
                SqlCmd.Parameters.Add(ParBKP_Auto);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A edição não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Editar Datas BKP Automatico
        public string Editar_Automatico(DInfo_Config_Backup Info_Config_Backup)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_config_bkp_auto_datas";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParData_Ultimo_BKP = new SqlParameter();
                ParData_Ultimo_BKP.ParameterName = "@data_ultimo_bkp";
                ParData_Ultimo_BKP.SqlDbType = SqlDbType.Date;
                ParData_Ultimo_BKP.Value = Info_Config_Backup.Data_Ultimo_BKP;
                SqlCmd.Parameters.Add(ParData_Ultimo_BKP);

                SqlParameter ParData_Proximo_BKP = new SqlParameter();
                ParData_Proximo_BKP.ParameterName = "@data_proximo_bkp";
                ParData_Proximo_BKP.SqlDbType = SqlDbType.Date;
                ParData_Proximo_BKP.Value = Info_Config_Backup.Data_Proximo_BKP;
                SqlCmd.Parameters.Add(ParData_Proximo_BKP);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("info_config_backup");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_info_config_backup";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
