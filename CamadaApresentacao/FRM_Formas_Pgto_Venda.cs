using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{
    public partial class FRM_Formas_Pgto_Venda : Form
    {
        public bool eAdicionar = false;
        public DateTime Data;
        public decimal Valor_Total;
        private decimal valor;
        public decimal limite_credito_cliente = 0;
        public decimal resto_limite_cliente = 0;
        private decimal valor_atual_adicionar = 0;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Formas_Pgto_Venda _Instancia;

        public static FRM_Formas_Pgto_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Formas_Pgto_Venda();
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
            this.TXB_Valor.Text = string.Empty;
        }

        public void Atualizar_Valores()
        {
            FRM_Caixa frm = FRM_Caixa.GetInstancia();

            int linha = frm.DGV_Formas_Pagamento.Rows.Count;
            this.valor = Convert.ToDecimal(frm.DGV_Formas_Pagamento.Rows[linha - 1].Cells[1].Value);

            decimal total_restante = this.Valor_Total - valor;
            this.Valor_Total = total_restante;
            this.LB_Valor_Total.Text = total_restante.ToString("C");

            this.Limpar();
        }


        public FRM_Formas_Pgto_Venda()
        {
            InitializeComponent();
            this.CB_Formas_Pgto.SelectedIndex = 0;
        }

        private void FRM_Formas_Pgto_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            this.limite_credito_cliente = 0;
            this.resto_limite_cliente = 0;

            FRM_Caixa frm = FRM_Caixa.GetInstancia();

            if (this.Valor_Total > 0)
            {
                this.MensagemErro("A operação não foi concluída com êxito");
                frm.CriarTabela_FP();
                frm.TXB_Recebimento.Text = string.Empty;
            }
            
            DataGridView Formas_PGTO = frm.DGV_Formas_Pagamento;
            if (Formas_PGTO.Rows.Count > 1)
            {
                // Adicionando informações: forma de pagamento
                frm.TXB_Recebimento.Text = "Multiformas";

                // Adicionando Informações: Entrada em Dinheiro ou Venda a Vista
                foreach (DataGridViewRow line in Formas_PGTO.Rows)
                {
                    if (line.Cells[0].Value.Equals("Dinheiro"))
                    {
                        decimal valor_entrada = Convert.ToDecimal(line.Cells[2].Value);
                        frm.Set_Detalhe_Recebimento("SIM", valor_entrada);
                    }
                }
            }
            else if (Formas_PGTO.Rows.Count == 1)
            {
                // Adicionando informação de forma de pagamento
                frm.TXB_Recebimento.Text = this.CB_Formas_Pgto.Text;
            }
        }

        private void BTN_Adicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (eAdicionar)
                {
                    FRM_Caixa frm = FRM_Caixa.GetInstancia();

                    bool salvar = true;
                    foreach (DataRow linha in frm.dtFormas_Pgto.Rows)
                    {
                        if (linha["forma"].ToString() == this.CB_Formas_Pgto.Text)
                        {
                            salvar = false;
                            this.MensagemErro("Esta forma de pagamento já foi adicionada");
                            this.TXB_Valor.Text = string.Empty;
                            this.TXB_Valor.Focus();
                        }
                    }
                    if (salvar)
                    {
                        if (this.Valor_Total == 0)
                        {
                            MessageBox.Show("A inserção está completa.\nClique em sair para continuar.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (frm.CHK_Venda_Rapida.Checked && this.CB_Formas_Pgto.Text.Equals("Crediário da Loja"))
                            {
                                this.MensagemErro("Não é possível efetuar venda no crediário da loja com o modo VENDA RÁPIDA ativo.");

                                // Excluir Formas de pagamento
                                frm.CriarTabela_FP();
                                frm.TXB_Recebimento.Text = string.Empty;

                                // Ocultar Calculador de troco
                                frm.LB_Recebido.Visible = false;
                                frm.TXT_Recebido.Visible = false;
                                frm.LB_Troco.Visible = false;
                                frm.TXB_Troco.Visible = false;

                                this.Close();
                            }
                            else if (frm.CHK_Venda_Rapida.Checked && this.CB_Formas_Pgto.Text.Equals("Cheque"))
                            {
                                this.MensagemErro("Não é possível efetuar venda no cheque com o modo VENDA RÁPIDA ativo.");

                                // Excluir Formas de pagamento
                                frm.CriarTabela_FP();
                                frm.TXB_Recebimento.Text = string.Empty;

                                // Ocultar Calculador de troco
                                frm.LB_Recebido.Visible = false;
                                frm.TXT_Recebido.Visible = false;
                                frm.LB_Troco.Visible = false;
                                frm.TXB_Troco.Visible = false;

                                this.Close();
                            }
                            else
                            {
                                bool chave = true;
                                if (this.limite_credito_cliente > 0 && this.CB_Formas_Pgto.Text.Equals("Crediário da Loja"))
                                {
                                    if (Convert.ToDecimal(this.TXB_Valor.Text) > Convert.ToDecimal(this.resto_limite_cliente))
                                    {
                                        chave = false;
                                        MessageBox.Show("Não é possivel efetuar essa venda no crediário da loja." + "    " + "\n Limite de crédito insuficiente.\n\n Limite disponivel: " + this.resto_limite_cliente.ToString("C"), "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        
                                    }
                                }
                                if (chave)
                                {
                                    if (this.TXB_Valor.Text == string.Empty)
                                    {
                                        this.MensagemErro("informe o valor.");
                                    }
                                    else
                                    {
                                        if (this.CB_Formas_Pgto.Text == "Cartão de Crédito")
                                        {
                                            // Solicitar Informações do cartão
                                            FRM_Informacoes_Cartao_Credito_Multiformas info_card_cred_multiformas = FRM_Informacoes_Cartao_Credito_Multiformas.GetInstancia();
                                            info_card_cred_multiformas.Valor_Produtos_Servicos = Convert.ToDecimal(this.TXB_Valor.Text);
                                            info_card_cred_multiformas.Show();
                                        }
                                        else if (this.CB_Formas_Pgto.Text == "Cartão de Debito")
                                        {
                                            DataRow row = frm.dtFormas_Pgto.NewRow();
                                            row["forma"] = this.CB_Formas_Pgto.Text;
                                            row["valor_primario"] = Convert.ToDecimal(this.TXB_Valor.Text);
                                            row["valor_final"] = Convert.ToDecimal(this.TXB_Valor.Text);
                                            frm.dtFormas_Pgto.Rows.Add(row);

                                            int linha = frm.DGV_Formas_Pagamento.Rows.Count;
                                            this.valor = Convert.ToDecimal(frm.DGV_Formas_Pagamento.Rows[linha - 1].Cells[1].Value);

                                            decimal total_restante = this.Valor_Total - valor;
                                            this.Valor_Total = total_restante;
                                            this.LB_Valor_Total.Text = total_restante.ToString("C");

                                            this.Limpar();

                                            // Solicitar Informações do cartão
                                            FRM_Informacoes_Cartao_Debito info_card_deb = FRM_Informacoes_Cartao_Debito.GetInstancia();
                                            info_card_deb.Show();
                                        }
                                        else if (this.CB_Formas_Pgto.Text == "Cheque")
                                        {
                                            // Solicitar Informações do cheque
                                            FRM_Informacoes_Cheque_Multiformas info_cheque_multiformas = FRM_Informacoes_Cheque_Multiformas.GetInstancia();
                                            info_cheque_multiformas.Valor_Total = Convert.ToDecimal(this.TXB_Valor.Text);
                                            info_cheque_multiformas.DTP_Data.Value = this.Data;
                                            info_cheque_multiformas.Show();
                                        }
                                        else if (this.CB_Formas_Pgto.Text == "Crediário da Loja")
                                        {
                                            // Instanciar tabela para armazenar os dados dos cheque(s)
                                            frm.Criar_Tabela_Pgto_Cheque();

                                            // Solicitar Informações do cheque
                                            FRM_Informacoes_Crediario_Loja_Multiformas info_cred_loja_multiformas = FRM_Informacoes_Crediario_Loja_Multiformas.GetInstancia();
                                            info_cred_loja_multiformas.Valor_Produtos_Servicos = Convert.ToDecimal(this.TXB_Valor.Text);
                                            info_cred_loja_multiformas.Data = this.Data;
                                            info_cred_loja_multiformas.Show();
                                        }
                                        else if (this.CB_Formas_Pgto.Text == "Dinheiro")
                                        {
                                            DataRow row = frm.dtFormas_Pgto.NewRow();
                                            row["forma"] = this.CB_Formas_Pgto.Text;
                                            row["valor_primario"] = Convert.ToDecimal(this.TXB_Valor.Text);
                                            row["valor_final"] = Convert.ToDecimal(this.TXB_Valor.Text);
                                            frm.dtFormas_Pgto.Rows.Add(row);

                                            int linha = frm.DGV_Formas_Pagamento.Rows.Count;
                                            this.valor = Convert.ToDecimal(frm.DGV_Formas_Pagamento.Rows[linha - 1].Cells[1].Value);

                                            decimal total_restante = this.Valor_Total - valor;
                                            this.Valor_Total = total_restante;
                                            this.LB_Valor_Total.Text = total_restante.ToString("C");

                                            this.Limpar();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.eAdicionar = false;
            this.Close();
        }

        private void FRM_Formas_Pgto_Venda_Load(object sender, EventArgs e)
        {
            this.LB_Valor_Total.Text = this.Valor_Total.ToString("C");
        }

        private void CB_Formas_Pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TXB_Valor.Focus();
        }

        private void LB_Valor_Total_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Valor_Total.Text.Equals("R$ 0,00"))
            {
                this.MensagemOk("Etapa concluída com sucesso.");
                this.Close();
            }
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
