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
    public partial class FRM_Solicitar_Permissao_Deletar_Item_Venda : Form
    {
        private bool Permissao_Concedida = false;
        private DataTable TBL_Dados_Funcionarios;
        public int linha_atual;
        public decimal quant_atual = 0;
        public decimal valor_item_deletado = 0;
        public decimal subtotal_atual = 0;
        public decimal preco_custo_item_deletado = 0;
        public decimal subtotal_custo_atual = 0;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Solicitar_Permissao_Deletar_Item_Venda _Instancia;

        public static FRM_Solicitar_Permissao_Deletar_Item_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Solicitar_Permissao_Deletar_Item_Venda();
            }
            return _Instancia;
        }

        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public FRM_Solicitar_Permissao_Deletar_Item_Venda()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Permissao_Concedida = false;
            this.TXB_Senha.Text = string.Empty;

            FRM_Caixa frm = FRM_Caixa.GetInstancia();
            frm.CHK_Selecionar.Checked = false;

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
                    FRM_Caixa frm = FRM_Caixa.GetInstancia();

                    this.Permissao_Concedida = true;
                    frm.Deletar_Item_Permissao_FALSE(Permissao_Concedida, this.linha_atual, this.quant_atual, this.valor_item_deletado, this.subtotal_atual, this.preco_custo_item_deletado, this.subtotal_custo_atual);

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

        private void FRM_Solicitar_Permissao_Deletar_Item_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
