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
    public partial class FRM_Abrir_Caixa : Form
    {
        public int IdFuncionario;
        public string nome_funcionario = "";
        private DataTable TBL_Verificacao;
        private DataTable TBL_Recuperacao_Dados_Caixa;
        private string Data_Atual;

        private string data_atual = "";
        private  string hora_atual = "";

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Abrir_Caixa _Instancia;

        public static FRM_Abrir_Caixa GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Abrir_Caixa();
            }
            return _Instancia;
        }

        private void ComboGuiche()
        {
            this.CB_Guiche_Atendimento.DataSource = NGuiche_Atendimento.Mostrar();
            this.CB_Guiche_Atendimento.ValueMember = "idguiche_atendimento";
            this.CB_Guiche_Atendimento.DisplayMember = "nome";
        }

        public FRM_Abrir_Caixa()
        {
            InitializeComponent();
            this.ComboGuiche();
        }

        private void FRM_Abrir_Caixa_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Abrir_Click(object sender, EventArgs e)
        {
            if (this.TBL_Verificacao.Rows.Count == 1)
            {
                MessageBox.Show("O usuário logado já operou o caixa selecionado na data atual.\nNão é possível opera-lo novamente.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (this.TXB_Valor_Inicial.Text == string.Empty)
                {
                    MessageBox.Show("Preencha todos os campos.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (this.TBL_Recuperacao_Dados_Caixa.Rows.Count == 1)
                    {
                        // Abrir Caixa
                        FRM_Caixa frm = FRM_Caixa.GetInstancia();
                        DataGridView Grid = frm.dataListaDetalhes;

                        frm.btnNova_Venda.Enabled = false;
                        frm.eNovo = true;
                        frm.idguiche_atendimento = Convert.ToInt32(this.CB_Guiche_Atendimento.SelectedValue);
                        frm.nome_guiche = this.CB_Guiche_Atendimento.Text;
                        frm.Data_Caixa_Aberto = this.data_atual;
                        frm.Hora_Caixa_Aberto = this.hora_atual;
                        frm.valor_inicial_caixa = Convert.ToDecimal(this.TXB_Valor_Inicial.Text);
                        frm.GB_Efetuar_Venda.Visible = true;
                        Grid.Focus();
                        frm.Habilitar(false);
                        frm.botoes();
                        frm.CriarTabela();
                        frm.CriarTabela_FP();
                        frm.CriarLinha();
                        frm.cbTipo_Comprovante.SelectedIndex = 0;
                        frm.LB_Cx_Livre.Visible = true;
                        frm.LB_Cx_Livre.Text = frm.nome_guiche;
                        frm.LB_Operador.Visible = true;
                        frm.LB_Operador.Text = this.nome_funcionario;
                        frm.BTN_Importar_OS.Enabled = true;
                        frm.BTN_Importar_Orcamento.Enabled = true;

                        int index = Grid.CurrentRow.Index;
                        Grid.CurrentCell = Grid.Rows[index].Cells[2];
                        
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        // Declarando Variaveis
                        string resp = "";
                        this.data_atual = DateTime.Now.ToString("dd/MM/yyyy");
                        this.hora_atual = DateTime.Now.ToString("HH : mm");

                        // Salvando Informações do caixa que está sendo aberto
                        resp = NInformacoes_Caixa_Aberto.Inserir(Convert.ToInt32(this.CB_Guiche_Atendimento.SelectedValue), this.CB_Guiche_Atendimento.Text, this.IdFuncionario, this.nome_funcionario, Convert.ToDateTime(this.data_atual), this.hora_atual, Convert.ToDecimal(this.TXB_Valor_Inicial.Text));

                        // Abrir Caixa
                        FRM_Caixa frm = FRM_Caixa.GetInstancia();
                        DataGridView Grid = frm.dataListaDetalhes;

                        frm.btnNova_Venda.Enabled = false;
                        frm.eNovo = true;
                        frm.idguiche_atendimento = Convert.ToInt32(this.CB_Guiche_Atendimento.SelectedValue);
                        frm.nome_guiche = this.CB_Guiche_Atendimento.Text;
                        frm.Data_Caixa_Aberto = this.data_atual;
                        frm.Hora_Caixa_Aberto = this.hora_atual;
                        frm.valor_inicial_caixa = Convert.ToDecimal(this.TXB_Valor_Inicial.Text);
                        frm.GB_Efetuar_Venda.Visible = true;
                        Grid.Focus();
                        frm.Habilitar(false);
                        frm.botoes();
                        frm.CriarTabela();
                        frm.CriarTabela_FP();
                        frm.CriarLinha();
                        frm.cbTipo_Comprovante.SelectedIndex = 0;
                        frm.LB_Cx_Livre.Visible = true;
                        frm.LB_Cx_Livre.Text = frm.nome_guiche;
                        frm.LB_Operador.Visible = true;
                        frm.LB_Operador.Text = this.nome_funcionario;
                        frm.BTN_Importar_OS.Enabled = true;
                        frm.BTN_Importar_Orcamento.Enabled = true;

                        int index = Grid.CurrentRow.Index;
                        Grid.CurrentCell = Grid.Rows[index].Cells[2];

                        frm.Show();
                        this.Close();
                    }
                }
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Abrir_Caixa_Load(object sender, EventArgs e)
        {
            this.Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");
            this.TBL_Verificacao = NVenda.Fechar_Caixa_Somente_Uma_Vez(Convert.ToString(this.CB_Guiche_Atendimento.SelectedValue), this.Data_Atual, Convert.ToString(IdFuncionario));

            this.TBL_Recuperacao_Dados_Caixa = NInformacoes_Caixa_Aberto.Mostrar(Convert.ToString(this.IdFuncionario));

            // Em caso de queda de energia recuperar dados da abertura do Caixa
            if (this.TBL_Recuperacao_Dados_Caixa.Rows.Count == 1)
            {
                DateTime data = Convert.ToDateTime(this.TBL_Recuperacao_Dados_Caixa.Rows[0][5]);
                this.data_atual = data.ToString("dd/MM/yyyy"); 
                this.hora_atual = this.TBL_Recuperacao_Dados_Caixa.Rows[0][6].ToString();
                this.CB_Guiche_Atendimento.SelectedValue = this.TBL_Recuperacao_Dados_Caixa.Rows[0][1].ToString();
                this.CB_Guiche_Atendimento.Enabled = false;
                this.TXB_Valor_Inicial.Text = this.TBL_Recuperacao_Dados_Caixa.Rows[0][7].ToString();
                this.TXB_Valor_Inicial.ReadOnly = true;
            }
        }

        private void CB_Guiche_Atendimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");
            this.TBL_Verificacao = NVenda.Fechar_Caixa_Somente_Uma_Vez(Convert.ToString(this.CB_Guiche_Atendimento.SelectedValue), this.Data_Atual, Convert.ToString(IdFuncionario));
        }

        private void TXB_Valor_Inicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
