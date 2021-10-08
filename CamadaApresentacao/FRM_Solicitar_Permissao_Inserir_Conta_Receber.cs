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
    public partial class FRM_Solicitar_Permissao_Inserir_Conta_Receber : Form
    {
        private bool Permissao_Concedida = false;
        private DataTable TBL_Dados_Funcionarios;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Solicitar_Permissao_Inserir_Conta_Receber _Instancia;

        public static FRM_Solicitar_Permissao_Inserir_Conta_Receber GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Solicitar_Permissao_Inserir_Conta_Receber();
            }
            return _Instancia;
        }

        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public FRM_Solicitar_Permissao_Inserir_Conta_Receber()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Permissao_Concedida = false;
            this.TXB_Senha.Text = string.Empty;

            this.Close();
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            if (this.TXB_Senha.Text == string.Empty)
            {
                this.MensagemErro("Insira a senha.");
                this.TXB_Senha.Focus();
            }
            else
            {
                this.TBL_Dados_Funcionarios = NFuncionario.Requerimento_Permissão(this.TXB_Senha.Text);

                if (this.TBL_Dados_Funcionarios.Rows.Count == 1)
                {
                    FRM_Contas_Receber frm = FRM_Contas_Receber.GetInstancia();

                    this.Permissao_Concedida = true;
                    frm.Inserir_Permissao_FALSE(Permissao_Concedida);

                    this.Close();
                }
                else
                {
                    this.Permissao_Concedida = false;
                    this.MensagemErro("Senha Inválida. Tente novamente.");
                    this.TXB_Senha.Text = string.Empty;
                    this.TXB_Senha.Focus();
                }
            }
        }

        private void FRM_Solicitar_Permissao_Inserir_Conta_Receber_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
