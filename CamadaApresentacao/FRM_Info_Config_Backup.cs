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
    public partial class FRM_Info_Config_Backup : Form
    {
        private bool eEditar = false;
        private DataTable TBL_Dados_Config;
        
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Info_Config_Backup _Instancia;

        public static FRM_Info_Config_Backup GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Info_Config_Backup();
            }
            return _Instancia;
        }

        public FRM_Info_Config_Backup()
        {
            InitializeComponent();
            this.TT_Mensagem.SetToolTip(this.BTN_Selecionar_Local, "Selecionar local");
        }

        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        //Limpar campos
        private void Limpar()
        {
            this.TXB_Local.Text = string.Empty;
            this.TXB_Intervalo.Text = string.Empty;
            this.CB_Habilitar.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Local.ReadOnly = !valor;
            this.TXB_Intervalo.ReadOnly = !valor;
            this.CB_Habilitar.Enabled = valor;

            if (valor)
            {
                this.TXB_Local.BackColor = Color.White;
                this.TXB_Intervalo.BackColor = Color.White;
                this.CB_Habilitar.BackColor = Color.White;
            }
            else
            {
                this.TXB_Local.BackColor = Color.WhiteSmoke;
                this.TXB_Intervalo.BackColor = Color.WhiteSmoke;
                this.CB_Habilitar.BackColor = Color.WhiteSmoke;
            }
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eEditar)
            {
                this.Habilitar(true);
                this.BTN_Selecionar_Local.Enabled = true;
                this.BTN_Alterar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Selecionar_Local.Enabled = false;
                this.BTN_Alterar.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }


        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.TBL_Dados_Config = NInfo_Config_Backup.Mostrar();
            this.TXB_Id.Text = TBL_Dados_Config.Rows[0][0].ToString();
            this.TXB_Local.Text = TBL_Dados_Config.Rows[0][1].ToString();
            this.TXB_Intervalo.Text = TBL_Dados_Config.Rows[0][3].ToString();
            this.CB_Habilitar.Text = TBL_Dados_Config.Rows[0][5].ToString();
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eEditar)
            {
                this.TXB_Local.BackColor = Color.LemonChiffon;
                this.TXB_Intervalo.BackColor = Color.LemonChiffon;
                this.CB_Habilitar.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Local.BackColor = Color.WhiteSmoke;
                this.TXB_Intervalo.BackColor = Color.WhiteSmoke;
                this.CB_Habilitar.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Info_Config_Backup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Selecionar_Local_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog local = new FolderBrowserDialog();
            DialogResult result = local.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.TXB_Local.Text = local.SelectedPath;
            }
        }

        private void FRM_Info_Config_Backup_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.BTN_Alterar.Focus();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eEditar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Close();
            this.Alerta_Campos_Obrigatorios();
        }

       
        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Local.Text == string.Empty || this.TXB_Intervalo.Text == string.Empty || this.CB_Habilitar.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eEditar)
                    {
                        resp = NInfo_Config_Backup.Editar_Usuario(Convert.ToInt32(this.TXB_Id.Text), this.TXB_Local.Text, Convert.ToInt32(this.TXB_Intervalo.Text), this.CB_Habilitar.Text);
                    }
                  
                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Configuração alterada com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                    this.Alerta_Campos_Obrigatorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Alterar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
        }

        private void TXB_Intervalo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
