using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FRM_Backup_Restauracao_DB : Form
    {
        private DataTable TBL_Dados_Config_Backup;
        private string Local_Seguro = "";
        private string Arquivo_Backup_FullName = "";
        private string Arquivo_Backup_Name = "";

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Backup_Restauracao_DB _Instancia;

        public static FRM_Backup_Restauracao_DB GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Backup_Restauracao_DB();
            }
            return _Instancia;
        }

        private void BuscaArquivos(DirectoryInfo dir)
        {
            // lista arquivos do diretorio corrente
            foreach (FileInfo file in dir.GetFiles())
            {
                CB_Backups.Items.Add(file.Name);
            }
        }
        

        private void Config_Backup()
        {
            this.TBL_Dados_Config_Backup = NInfo_Config_Backup.Mostrar();
            this.Local_Seguro = this.TBL_Dados_Config_Backup.Rows[0][1].ToString();
        }

        public FRM_Backup_Restauracao_DB()
        {
            InitializeComponent();
        }

        private void BTN_Backup_Click(object sender, EventArgs e)
        {
            try
            {
                //Executando backup de banco de dados
                var server = new Microsoft.SqlServer.Management.Smo.Server(TXB_Servidor.Text);
                var backup = new Microsoft.SqlServer.Management.Smo.Backup();
                backup.Database = TXB_Database.Text;
                backup.Incremental = false;
                string nomeArquivoBackup = string.Format("{0}_{1:yyyyMMdd_HHmm}.bak", TXB_Database.Text, DateTime.Now);
                backup.Devices.AddDevice(nomeArquivoBackup, Microsoft.SqlServer.Management.Smo.DeviceType.File);
                backup.SqlBackup(server);

                // Copiar Backup para local seguro expecificado na configuração de backup
                File.Copy("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup, this.Local_Seguro+"\\"+nomeArquivoBackup, true);

                // Deletar arquivo da pasta padrão de bkp do SQL
                File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + nomeArquivoBackup);

                // Mensagens e finalização
                MessageBox.Show(string.Format("Backup '{0}' concluído com sucesso.", nomeArquivoBackup), "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void FRM_Backup_Restauracao_DB_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            if (this.Arquivo_Backup_Name != "")
            {
                File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\" + this.Arquivo_Backup_Name);
            }
        }

        private void BTN_Restauracao_Click(object sender, EventArgs e)
        {
            var server = new Microsoft.SqlServer.Management.Smo.Server(TXB_Servidor.Text);
            var restore = new Microsoft.SqlServer.Management.Smo.Restore();
            restore.Database = TXB_Database.Text;
            restore.Devices.AddDevice(CB_Backups.Text, Microsoft.SqlServer.Management.Smo.DeviceType.File);
            server.KillAllProcesses(TXB_Database.Text);
            restore.SqlRestore(server);
            MessageBox.Show(string.Format("Backup '{0}' restaurado com sucesso.", CB_Backups.Text), "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     
        private void FRM_Backup_Restauracao_DB_Load(object sender, EventArgs e)
        {
            this.Config_Backup();

            string ComputerName = SystemInformation.ComputerName;
            if (ComputerName != "SERVIDOR")
            {
                MessageBox.Show("Não é possível efetuar backup do banco de dados através de um terminal. Dirija-se até o servidor", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        

        private void BTN_Local_Backup_Click(object sender, EventArgs e)
        {
            OpenFileDialog local = new OpenFileDialog();
            local.Filter = "Arquivo BAK|*.bak";
            DialogResult result = local.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Selecionando arquivo de backup
                this.Arquivo_Backup_FullName = local.FileName;
                this.Arquivo_Backup_Name = Path.GetFileName(local.FileName);

                // Copiando backup para diretorio padrão do sql 
                File.Copy(this.Arquivo_Backup_FullName, "C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\"+this.Arquivo_Backup_Name, true);

                // Mostrar conteudo do diretorio poadrao sql no combobox
                DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\Backup");
                this.BuscaArquivos(dirInfo);
                this.CB_Backups.Enabled = true;
                this.CB_Backups.SelectedIndex = 0;
            }
        }

        private void CB_Backups_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.BTN_Restauracao.Enabled = true;
        }
    }
}

