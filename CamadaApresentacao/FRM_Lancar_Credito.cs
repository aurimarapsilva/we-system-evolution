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
    public partial class FRM_Lancar_Credito : Form
    {
        public bool eNovo;
        public int Num_Doc;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Lancar_Credito _Instancia;

        public static FRM_Lancar_Credito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Lancar_Credito();
            }
            return _Instancia;
        }
        
        public FRM_Lancar_Credito()
        {
            InitializeComponent();
            this.TXB_Num_Doc.ReadOnly = true;
        }

        private void FRM_Lancar_Credito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
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


        //Metodo Limpar Campos
        private void Limpar()
        {
            //Limpar TextBox
            this.DT_Data_Receb.Text = string.Empty;
            this.TXB_Historico.Text = string.Empty;
            this.TXB_Num_Doc.Text = string.Empty;
            this.TXB_Valor.Text = string.Empty;
        }


        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.DT_Data_Receb.Enabled = valor;
            this.TXB_Historico.ReadOnly = !valor;
            this.TXB_Valor.ReadOnly = !valor;
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.Habilitar(true);
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_Livro_Caixa frm = FRM_Livro_Caixa.GetInstancia();
                string resp = "";

                if (this.eNovo)
                {
                    resp = NLivro_Caixa.Inserir(this.DT_Data_Receb.Value, this.TXB_Historico.Text, this.TXB_Num_Doc.Text, Convert.ToDecimal(this.TXB_Valor.Text), Convert.ToDecimal("0,00"));
                }

                if (resp.Equals("Ok"))
                {
                    this.MensagemOk("Registro salvo com sucesso");

                    //Atualizar Configurações de Numeração Automática - LIVRO CAIXA Crédito
                    resp = NLivro_Caixa.Atualizar_Num_Auto_Livro_Caixa_Credito(frm.Auxiliar_NA_Credito);
                }
                else
                {
                    this.MensagemErro(resp);
                }

                frm.Mostrar();
                frm.Saldo();

                this.eNovo = false;
                this.botoes();
                this.Limpar();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Close();
        }

        private void FRM_Lancar_Credito_Load(object sender, EventArgs e)
        {
            
        }

        private void TXB_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
