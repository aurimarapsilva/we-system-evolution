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
    public partial class FRM_Config_Nivel_Acesso : Form
    {
        private bool eNovo = false;
        private bool eAlterar = false;
        
        private string btn_listagem_vendas = "NÃO", btn_backup = "NÃO", btn_configuracoes = "NÃO", btn_licenciamento = "NÃO", btn_desbloquear = "NÃO", btn_caixa = "NÃO", btn_clientes = "NÃO", btn_estoque = "NÃO", btn_fornecedores = "NÃO", btn_funcionarios = "NÃO", btn_livro_caixa = "NÃO", btn_contas_receber = "NÃO", btn_contas_pagar = "NÃO", btn_outras_financas = "NÃO", btn_os = "NÃO", btn_relatorios = "NÃO", deletar_item_venda = "NÃO", deletar_conta_receber = "NÃO", inserir_conta_receber = "NÃO";
       
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Config_Nivel_Acesso _Instancia;
        
        public static FRM_Config_Nivel_Acesso GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Config_Nivel_Acesso();
            }
            return _Instancia;
        }

        
        public FRM_Config_Nivel_Acesso()
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


        private void Habilitar(bool valor)
        {
            this.TXB_Nivel_Acesso.ReadOnly = !valor;
            this.CHK_Listagem_Vendas.Enabled = valor;
            this.CHK_Backup.Enabled = valor;
            this.CHK_Licenciamento.Enabled = valor;
            this.CHK_Desbloquear_Sistema.Enabled = valor;
            this.CHK_Caixa.Enabled = valor;
            this.CHK_Clientes.Enabled = valor;
            this.CHK_Estoque.Enabled = valor;
            this.CHK_Fornecedores.Enabled = valor;
            this.CHK_Livro_Caixa.Enabled = valor;
            this.CHK_Contas_Receber.Enabled = valor;
            this.CHK_Contas_Pagar.Enabled = valor;
            this.CHK_Outras_Financas.Enabled = valor;
            this.CHK_Ordem_Servico.Enabled = valor;
            this.CHK_Relatorios.Enabled = valor;
            this.CHK_Deletar_Item_Venda.Enabled = valor;
            this.CHK_Deletar_Conta_Receber.Enabled = valor;
            this.CHK_Inserir_Contas_Receber.Enabled = valor;

            if (valor)
            {
                this.TXB_Nivel_Acesso.BackColor = Color.White;
            }
            else
            {
                this.TXB_Nivel_Acesso.BackColor = Color.WhiteSmoke;
            }
        }


        private void Limpar()
        {
            this.TXB_Id.Text = string.Empty;
            this.TXB_Nivel_Acesso.Text = string.Empty;
            this.CHK_Listagem_Vendas.Checked = false;
            this.CHK_Backup.Checked = false;
            this.CHK_Configuracoes.Checked = false;
            this.CHK_Licenciamento.Checked = false;
            this.CHK_Desbloquear_Sistema.Checked = false;
            this.CHK_Caixa.Checked = false;
            this.CHK_Clientes.Checked = false;
            this.CHK_Estoque.Checked = false;
            this.CHK_Fornecedores.Checked = false;
            this.CHK_Funcionarios.Checked = false;
            this.CHK_Livro_Caixa.Checked = false;
            this.CHK_Contas_Receber.Checked = false;
            this.CHK_Contas_Pagar.Checked = false;
            this.CHK_Outras_Financas.Checked = false;
            this.CHK_Ordem_Servico.Checked = false;
            this.CHK_Relatorios.Checked = false;
            this.CHK_Deletar_Item_Venda.Checked = false;
            this.CHK_Deletar_Conta_Receber.Checked = false;
            this.CHK_Inserir_Contas_Receber.Checked = false;
        }

        private void Botoes()
        {
            if (this.eNovo || this.eAlterar)
            {
                this.BTN_Novo.Enabled = false;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.BTN_Novo.Enabled = true;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = true;
            }
        }

        private void Mostrar_Config_Atual()
        {
            // Obtendo dados
            this.DGV_Config_Atual.DataSource = NNivel_Acesso.Mostrar();

            // Ocultando Colunas
            this.DGV_Config_Atual.Columns[0].Visible = false;
            this.DGV_Config_Atual.Columns[2].Visible = false;
            this.DGV_Config_Atual.Columns[3].Visible = false;
            this.DGV_Config_Atual.Columns[4].Visible = false;
            this.DGV_Config_Atual.Columns[5].Visible = false;
            this.DGV_Config_Atual.Columns[6].Visible = false;
            this.DGV_Config_Atual.Columns[7].Visible = false;
            this.DGV_Config_Atual.Columns[8].Visible = false;
            this.DGV_Config_Atual.Columns[9].Visible = false;
            this.DGV_Config_Atual.Columns[10].Visible = false;
            this.DGV_Config_Atual.Columns[11].Visible = false;
            this.DGV_Config_Atual.Columns[12].Visible = false;
            this.DGV_Config_Atual.Columns[13].Visible = false;
            this.DGV_Config_Atual.Columns[14].Visible = false;
            this.DGV_Config_Atual.Columns[15].Visible = false;
            this.DGV_Config_Atual.Columns[16].Visible = false;
            this.DGV_Config_Atual.Columns[17].Visible = false;
            this.DGV_Config_Atual.Columns[18].Visible = false;
            this.DGV_Config_Atual.Columns[19].Visible = false;
            this.DGV_Config_Atual.Columns[20].Visible = false;

            // Nome das Colunas
            this.DGV_Config_Atual.Columns[1].HeaderText = "Nível de Acesso";

            // Tamanho da Coluna
            this.DGV_Config_Atual.Columns[1].Width = 180;
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eAlterar)
            {
                this.TXB_Nivel_Acesso.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Nivel_Acesso.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Config_Nivel_Acesso_Load(object sender, EventArgs e)
        {
            this.Mostrar_Config_Atual();
            this.Botoes();
            this.Habilitar(false);
        }

        
        private void CHK_Listagem_Vendas_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Listagem_Vendas.Checked)
            {
                this.btn_listagem_vendas = "SIM";
            }
            else
            {
                this.btn_listagem_vendas = "NÃO";
            }
        }

        private void DGV_Config_Atual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Repassando Parametros
            this.TXB_Id.Text = DGV_Config_Atual.CurrentRow.Cells[0].Value.ToString();
            this.TXB_Nivel_Acesso.Text = DGV_Config_Atual.CurrentRow.Cells[1].Value.ToString();

            if (this.DGV_Config_Atual.CurrentRow.Cells[2].Value.ToString().Equals("SIM"))
            {
                this.CHK_Listagem_Vendas.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[3].Value.ToString().Equals("SIM"))
            {
                this.CHK_Backup.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[4].Value.ToString().Equals("SIM"))
            {
                this.CHK_Configuracoes.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[5].Value.ToString().Equals("SIM"))
            {
                this.CHK_Licenciamento.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[6].Value.ToString().Equals("SIM"))
            {
                this.CHK_Desbloquear_Sistema.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[7].Value.ToString().Equals("SIM"))
            {
                this.CHK_Caixa.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[8].Value.ToString().Equals("SIM"))
            {
                this.CHK_Clientes.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[9].Value.ToString().Equals("SIM"))
            {
                this.CHK_Estoque.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[10].Value.ToString().Equals("SIM"))
            {
                this.CHK_Fornecedores.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[11].Value.ToString().Equals("SIM"))
            {
                this.CHK_Funcionarios.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[12].Value.ToString().Equals("SIM"))
            {
                this.CHK_Livro_Caixa.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[13].Value.ToString().Equals("SIM"))
            {
                this.CHK_Contas_Receber.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[14].Value.ToString().Equals("SIM"))
            {
                this.CHK_Contas_Pagar.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[15].Value.ToString().Equals("SIM"))
            {
                this.CHK_Outras_Financas.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[16].Value.ToString().Equals("SIM"))
            {
                this.CHK_Ordem_Servico.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[17].Value.ToString().Equals("SIM"))
            {
                this.CHK_Relatorios.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[18].Value.ToString().Equals("SIM"))
            {
                this.CHK_Deletar_Item_Venda.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[19].Value.ToString().Equals("SIM"))
            {
                this.CHK_Deletar_Conta_Receber.Checked = true;
            }
            if (this.DGV_Config_Atual.CurrentRow.Cells[20].Value.ToString().Equals("SIM"))
            {
                this.CHK_Inserir_Contas_Receber.Checked = true;
            }

            this.BTN_Editar.Enabled = true;
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eAlterar = false;
            this.Botoes();
            this.Limpar();
            this.Habilitar(true);
            this.TXB_Nivel_Acesso.Focus();
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eAlterar = true;
            this.Botoes();
            this.Habilitar(true);
        }

        private void CHK_Deletar_Item_Venda_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Deletar_Item_Venda.Checked)
            {
                this.deletar_item_venda = "SIM";
            }
            else
            {
                this.deletar_item_venda = "NÃO";
            }
        }

        private void CHK_Deletar_Conta_Receber_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Deletar_Conta_Receber.Checked)
            {
                this.deletar_conta_receber = "SIM";
            }
            else
            {
                this.deletar_conta_receber = "NÃO";
            }
        }

        private void CHK_Inserir_Contas_Receber_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Inserir_Contas_Receber.Checked)
            {
                this.inserir_conta_receber = "SIM";
            }
            else
            {
                this.inserir_conta_receber = "NÃO";
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eAlterar = false;
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TXB_Nivel_Acesso.Text == string.Empty)
                {
                    this.MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    string resp = "";
                    if (this.eNovo)
                    {
                        resp = NNivel_Acesso.Inserir(this.TXB_Nivel_Acesso.Text.ToUpper(), this.btn_listagem_vendas, this.btn_backup, this.btn_configuracoes, this.btn_licenciamento, this.btn_desbloquear, this.btn_caixa, this.btn_clientes, this.btn_estoque, this.btn_fornecedores, this.btn_funcionarios, this.btn_livro_caixa, this.btn_contas_receber, this.btn_contas_pagar, this.btn_outras_financas, this.btn_os, this.btn_relatorios, this.deletar_item_venda, this.deletar_conta_receber, this.inserir_conta_receber);
                    }
                    else
                    {
                        resp = NNivel_Acesso.Editar(Convert.ToInt32(this.TXB_Id.Text), this.TXB_Nivel_Acesso.Text.ToUpper(), this.btn_listagem_vendas, this.btn_backup, this.btn_configuracoes, this.btn_licenciamento, this.btn_desbloquear, this.btn_caixa, this.btn_clientes, this.btn_estoque, this.btn_fornecedores, this.btn_funcionarios, this.btn_livro_caixa, this.btn_contas_receber, this.btn_contas_pagar, this.btn_outras_financas, this.btn_os, this.btn_relatorios, this.deletar_item_venda, this.deletar_conta_receber, this.inserir_conta_receber);
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Nível de acesso inserido com sucesso.");

                            this.eNovo = false;
                            this.eAlterar = false;
                            this.Habilitar(false);
                            this.Botoes();
                            this.Limpar();
                            this.Mostrar_Config_Atual();
                            this.Alerta_Campos_Obrigatorios();
                        }
                        else
                        {
                            this.MensagemOk("Nível de acesso alterado com sucesso.");

                            this.eNovo = false;
                            this.eAlterar = false;
                            this.Habilitar(false);
                            this.Botoes();
                            this.Limpar();
                            this.Mostrar_Config_Atual();
                            this.Alerta_Campos_Obrigatorios();
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                }
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message + Erro.StackTrace);
            }
        }

        private void FRM_Config_Nivel_Acesso_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void CHK_Backup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Backup.Checked)
            {
                this.btn_backup = "SIM";
            }
            else
            {
                this.btn_backup = "NÃO";
            }
        }

        private void CHK_Configuracoes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Configuracoes.Checked)
            {
                this.btn_configuracoes = "SIM";
            }
            else
            {
                this.btn_configuracoes = "NÃO";
            }
        }

        private void CHK_Licenciamento_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Licenciamento.Checked)
            {
                this.btn_licenciamento = "SIM";
            }
            else
            {
                this.btn_licenciamento = "NÃO";
            }
        }

        private void CHK_Desbloquear_Sistema_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Desbloquear_Sistema.Checked)
            {
                this.btn_desbloquear = "SIM";
            }
            else
            {
                this.btn_desbloquear = "NÃO";
            }
        }

        private void CHK_Caixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Caixa.Checked)
            {
                this.btn_caixa = "SIM";
            }
            else
            {
                this.btn_caixa = "NÃO";
            }
        }

        private void CHK_Clientes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Clientes.Checked)
            {
                this.btn_clientes = "SIM";
            }
            else
            {
                this.btn_clientes = "NÃO";
            }
        }

        private void CHK_Estoque_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Estoque.Checked)
            {
                this.btn_estoque = "SIM";
            }
            else
            {
                this.btn_estoque = "NÃO";
            }
        }

        private void CHK_Fornecedores_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Fornecedores.Checked)
            {
                this.btn_fornecedores = "SIM";
            }
            else
            {
                this.btn_fornecedores = "NÃO";
            }
        }

        private void CHK_Funcionarios_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Funcionarios.Checked)
            {
                this.btn_funcionarios = "SIM";
            }
            else
            {
                this.btn_funcionarios = "NÃO";
            }
        }

        private void CHK_Livro_Caixa_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Livro_Caixa.Checked)
            {
                this.btn_livro_caixa = "SIM";
            }
            else
            {
                this.btn_livro_caixa = "NÃO";
            }
        }

        private void CHK_Contas_Receber_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Contas_Receber.Checked)
            {
                this.btn_contas_receber = "SIM";
            }
            else
            {
                this.btn_contas_receber = "NÃO";
            }
        }

        private void CHK_Contas_Pagar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Contas_Pagar.Checked)
            {
                this.btn_contas_pagar = "SIM";
            }
            else
            {
                this.btn_contas_pagar = "NÃO";
            }
        }

        private void CHK_Outras_Financas_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Outras_Financas.Checked)
            {
                this.btn_outras_financas = "SIM";
            }
            else
            {
                this.btn_outras_financas = "NÃO";
            }
        }

        private void CHK_Ordem_Servico_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Ordem_Servico.Checked)
            {
                this.btn_os = "SIM";
            }
            else
            {
                this.btn_os = "NÃO";
            }
        }

        private void CHK_Relatorios_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Relatorios.Checked)
            {
                this.btn_relatorios = "SIM";
            }
            else
            {
                this.btn_relatorios = "NÃO";
            }
        }
    }
}
