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
    public partial class FRM_Config_Juros_Parcelamento : Form
    {
        private bool eAlterar = false;
        private DataTable TBL_Config;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Config_Juros_Parcelamento _Instancia;

        public static FRM_Config_Juros_Parcelamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Config_Juros_Parcelamento();
            }
            return _Instancia;
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
            this.CB_Habilitar.Text = string.Empty;
            this.TXB_Juros_Card_Cred.Text = string.Empty;
            this.TXB_Juros_Cred_Loja.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.CB_Habilitar.Enabled = valor;
            this.TXB_Juros_Card_Cred.ReadOnly = !valor;
            this.TXB_Juros_Cred_Loja.ReadOnly = !valor;
            
            if (valor)
            {
                this.CB_Habilitar.BackColor = Color.White;
                this.TXB_Juros_Card_Cred.BackColor = Color.White;
                this.TXB_Juros_Cred_Loja.BackColor = Color.White;
            }
            else
            {
                this.CB_Habilitar.BackColor = Color.WhiteSmoke;
                this.TXB_Juros_Card_Cred.BackColor = Color.WhiteSmoke;
                this.TXB_Juros_Cred_Loja.BackColor = Color.WhiteSmoke;
            }
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
                this.BTN_Editar.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }

        private void Mostrar_Config_atual()
        {
            this.TBL_Config = NConfig_Juros_Parcelamento.Mostrar();

            this.TXB_Juros_Card_Cred.Text = this.TBL_Config.Rows[0][1].ToString();
            this.TXB_Juros_Cred_Loja.Text = this.TBL_Config.Rows[0][2].ToString();
            this.CB_Habilitar.Text = this.TBL_Config.Rows[0][3].ToString();
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eAlterar)
            {
                this.CB_Habilitar.BackColor = Color.LemonChiffon;
                this.TXB_Juros_Card_Cred.BackColor = Color.LemonChiffon;
                this.TXB_Juros_Cred_Loja.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.CB_Habilitar.BackColor = Color.WhiteSmoke;
                this.TXB_Juros_Card_Cred.BackColor = Color.WhiteSmoke;
                this.TXB_Juros_Cred_Loja.BackColor = Color.WhiteSmoke;
            }
        }


        public FRM_Config_Juros_Parcelamento()
        {
            InitializeComponent();
        }

        private void FRM_Config_Juros_Parcelamento_Load(object sender, EventArgs e)
        {
            this.botoes();
            this.Mostrar_Config_atual();
        }

        private void FRM_Config_Juros_Parcelamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
            this.Close();
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
                if (this.CB_Habilitar.Text == string.Empty || this.TXB_Juros_Card_Cred.Text == string.Empty || this.TXB_Juros_Cred_Loja.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eAlterar)
                    {
                        resp = NConfig_Juros_Parcelamento.Editar(Convert.ToDecimal(this.TXB_Juros_Card_Cred.Text), Convert.ToDecimal(this.TXB_Juros_Cred_Loja.Text), this.CB_Habilitar.Text);
                    }

                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Configuração Atualizada com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eAlterar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar_Config_atual();
                    this.Alerta_Campos_Obrigatorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CB_Habilitar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Habilitar.Text.Equals("NÃO"))
            {
                this.TXB_Juros_Card_Cred.Text = "0,00";
                this.TXB_Juros_Cred_Loja.Text = "0,00";
                this.TXB_Juros_Card_Cred.ReadOnly = true;
                this.TXB_Juros_Cred_Loja.ReadOnly = true;
            }
            else
            {
                this.TXB_Juros_Card_Cred.ReadOnly = false;
                this.TXB_Juros_Cred_Loja.ReadOnly = false;
            }
        }

        private void TXB_Juros_Card_Cred_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TXB_Juros_Cred_Loja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
