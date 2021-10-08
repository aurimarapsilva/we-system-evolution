using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FRM_Login : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Login _Instancia;

        public static FRM_Login GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Login();
            }
            return _Instancia;
        }

        public FRM_Login()
        {
            InitializeComponent();
            lblHora.Text = DateTime.Now.ToString();
            this.RestaurarDBPadraoCasoNaoExista();
            this.Primeiro_Uso();
            this.ComboUsuario();
        }


        public void ComboUsuario()
        {
            CB_Usuario.DataSource = NFuncionario.Mostrar();
            CB_Usuario.ValueMember = "Idfuncionario";
            CB_Usuario.DisplayMember = "usuario";
        }

        private void Primeiro_Uso()
        {
            DataTable Dados = NFuncionario.Mostrar();
            if (Dados.Rows.Count == 0)
            {
                FRM_Primeiro_Uso frm = new FRM_Primeiro_Uso();
                frm.ShowDialog();
                this.Hide();
            }
        }


        private bool VerificaSeBancoJaExiste()
        {
            bool retorno = false;

            try
            {
                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        comm.CommandText = "SELECT 1 FROM SYS.DATABASES WHERE NAME LIKE 'DB_WE'";
                        var valor = comm.ExecuteScalar();

                        if (valor != null && valor != DBNull.Value && Convert.ToInt32(valor).Equals(1))
                        {
                            retorno = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retorno;
        }


        private void DescobrirDiretoriosPadrao(out string diretorioDados, out string diretorioLog, out string diretorioBackup)
        {
            using (var connection = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
            {
                var serverConnection = new Microsoft.SqlServer.Management.Common.ServerConnection(connection);
                var server = new Microsoft.SqlServer.Management.Smo.Server(serverConnection);
                diretorioDados = !string.IsNullOrWhiteSpace(server.Settings.DefaultFile) ? server.Settings.DefaultFile : (!string.IsNullOrWhiteSpace(server.DefaultFile) ? server.DefaultFile : server.MasterDBPath);
                diretorioLog = !string.IsNullOrWhiteSpace(server.Settings.DefaultLog) ? server.Settings.DefaultLog : (!string.IsNullOrWhiteSpace(server.DefaultLog) ? server.DefaultLog : server.MasterDBLogPath);
                diretorioBackup = !string.IsNullOrWhiteSpace(server.Settings.BackupDirectory) ? server.Settings.BackupDirectory : server.BackupDirectory;
            }
        }


        private void RestaurarDBPadrao()
        {
            try
            {
                string diretorioDados, diretorioLog, diretorioBackup;
                DescobrirDiretoriosPadrao(out diretorioDados, out diretorioLog, out diretorioBackup);

                using (var conn = new System.Data.SqlClient.SqlConnection(@"Server=.\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
                {
                    conn.Open();
                    using (var comm = conn.CreateCommand())
                    {
                        var caminhoCompletoBackup = System.IO.Path.Combine(diretorioBackup, "DBTemplate.bak");
                        var caminhoCompletoDados = System.IO.Path.Combine(diretorioDados, "DB_WE.mdf");
                        var caminhoCompletoLog = System.IO.Path.Combine(diretorioLog, "DB_WE_Log.ldf");
                        System.IO.File.Copy("DBTemplate.bak", caminhoCompletoBackup, true);
                        comm.CommandText =
                            @"RESTORE DATABASE DB_WE " +
                            @"FROM DISK = N'" + caminhoCompletoBackup + "' " +
                            @"WITH FILE = 1, " +
                            @"MOVE N'DB_WE' TO N'" + caminhoCompletoDados + "', " +
                            @"MOVE N'DB_WE_LOG' TO N'" + caminhoCompletoLog + "', " +
                            @"NOUNLOAD, REPLACE, STATS = 10";
                        comm.ExecuteNonQuery();
                        System.IO.File.Delete("C:\\Program Files\\Microsoft SQL Server\\MSSQL12.SQLEXPRESS\\MSSQL\\Backup\\DBTemplate.bak");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RestaurarDBPadraoCasoNaoExista()
        {
            try
            {
                string ComputerName = SystemInformation.ComputerName;
                if (ComputerName == "SERVIDOR")
                {
                    var bancoExiste = VerificaSeBancoJaExiste();

                    if (!bancoExiste)
                    {
                        RestaurarDBPadrao();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable Dados = NFuncionario.Login(CB_Usuario.Text, txtSenha.Text);
            if (Dados.Rows.Count == 0)
            {
                MessageBox.Show("Usuário e/ou senha não encontrados. Tente novamente!", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSenha.Text = string.Empty;
                this.txtSenha.Focus();
            }
            else
            {
                //Instanciando a Tela principal após passar no login.
                FRM_Tela_Principal frm = new FRM_Tela_Principal();

                //Codificação de Niveis/Restrição de acesso.  Parte 2
                frm.idfuncionario = Convert.ToInt32(Dados.Rows[0][0]);
                frm.Nome = Dados.Rows[0][1].ToString();
                frm.Sobrenome = Dados.Rows[0][2].ToString();
                frm.IdNivel_Acesso = Dados.Rows[0][3].ToString();
                frm.Nivel_Acesso = Dados.Rows[0][4].ToString();

                frm.Show();
                this.Hide();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.txtSenha.Text = string.Empty;
        }

        private void FRM_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
