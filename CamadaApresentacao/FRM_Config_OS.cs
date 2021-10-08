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
    public partial class FRM_Config_OS : Form
    {
        private bool eAlterar = false;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Config_OS _Instancia;

        public static FRM_Config_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Config_OS();
            }
            return _Instancia;
        }

        public FRM_Config_OS()
        {
            InitializeComponent();
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
            this.TXB_Texto1.Text = string.Empty;
            this.TXB_Texto2.Text = string.Empty;
            this.TXB_Texto2.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Texto1.ReadOnly = !valor;
            this.TXB_Texto2.ReadOnly = !valor;
            this.TXB_Texto3.ReadOnly = !valor; ;
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eAlterar)
            {
                this.Habilitar(true);
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }

        // MOstrar Config Atual
        private void Mostrar_Config_Atual()
        {
            DataTable TBL_Config_OS = NConfig_OS.Mostrar();
            this.TXB_Texto1.Text = TBL_Config_OS.Rows[0][1].ToString();
            this.TXB_Texto2.Text = TBL_Config_OS.Rows[0][2].ToString();
            this.TXB_Texto3.Text = TBL_Config_OS.Rows[0][3].ToString();
        }

        private void FRM_Config_OS_Load(object sender, EventArgs e)
        {
            this.Mostrar_Config_Atual();
            this.Habilitar(false);
            this.botoes();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eAlterar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
        }

        private void FRM_Config_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            this.eAlterar = true;
            this.botoes();
            this.Habilitar(true);
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.eAlterar)
                {
                    resp = NConfig_OS.Editar(this.TXB_Texto1.Text, this.TXB_Texto2.Text, this.TXB_Texto3.Text);
                }
                if (resp.Equals("Ok"))
                {
                    this.MensagemOk("Atualização realizada com sucesso.");
                }
                else
                {
                    this.MensagemErro(resp);
                }

                this.eAlterar = false;
                this.botoes();
                this.Limpar();
                this.Mostrar_Config_Atual();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
