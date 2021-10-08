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
    public partial class FRM_Config_Orcamento : Form
    {
        private bool eAlterar = false;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Config_Orcamento _Instancia;

        public static FRM_Config_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Config_Orcamento();
            }
            return _Instancia;
        }

        public FRM_Config_Orcamento()
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
            this.TXB_Texto.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Texto.ReadOnly = !valor;
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
            DataTable TBL_Config_Orcamento = NConfig_Orcamento.Mostrar();
            this.TXB_Texto.Text = TBL_Config_Orcamento.Rows[0][1].ToString();
        }

        private void FRM_Config_Orcamento_Load(object sender, EventArgs e)
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

        private void FRM_Config_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
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
                    resp = NConfig_Orcamento.Editar(this.TXB_Texto.Text);
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
