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
    public partial class FRM_Config_Cartao_Debito : Form
    {
        private bool eNovo = false;
        private bool eAlterar = false;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Config_Cartao_Debito _Instancia;

        public static FRM_Config_Cartao_Debito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Config_Cartao_Debito();
            }
            return _Instancia;
        }

        public FRM_Config_Cartao_Debito()
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
            this.TXB_Id.Text = string.Empty;
            this.TXB_Bandeira.Text = string.Empty;
            this.TXB_Prazo_Compensacao.Text = string.Empty;
            this.TXB_Taxa.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Id.ReadOnly = !valor;
            this.TXB_Bandeira.Enabled = valor;
            this.TXB_Prazo_Compensacao.ReadOnly = !valor;
            this.TXB_Taxa.ReadOnly = !valor;

            if (valor)
            {
                this.TXB_Bandeira.BackColor = Color.LemonChiffon;
                this.TXB_Prazo_Compensacao.BackColor = Color.LemonChiffon;
                this.TXB_Taxa.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Bandeira.BackColor = Color.WhiteSmoke;
                this.TXB_Prazo_Compensacao.BackColor = Color.WhiteSmoke;
                this.TXB_Taxa.BackColor = Color.WhiteSmoke;
            }
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo || this.eAlterar)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }

        //Metodo ocultar colunas do Grid
        private void Formato_Grid()
        {
            // Ocultar Colunas
            this.DGV_Config_Atual.Columns[0].Visible = false;

            // Nome das Colunas
            this.DGV_Config_Atual.Columns[1].HeaderText = "Bandeira";
            this.DGV_Config_Atual.Columns[2].HeaderText = "Prazo Compensação";
            this.DGV_Config_Atual.Columns[3].HeaderText = "Taxa";
        }

        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.DGV_Config_Atual.DataSource = NConfig_Cartao_Debito.Mostrar();
            this.Formato_Grid();
            LB_Total_Registros.Text = Convert.ToString(DGV_Config_Atual.Rows.Count);
        }

        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eAlterar)
            {
                this.TXB_Bandeira.BackColor = Color.LemonChiffon;
                this.TXB_Prazo_Compensacao.BackColor = Color.LemonChiffon;
                this.TXB_Taxa.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Bandeira.BackColor = Color.WhiteSmoke;
                this.TXB_Prazo_Compensacao.BackColor = Color.WhiteSmoke;
                this.TXB_Taxa.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Config_Cartao_Debito_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eAlterar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Bandeira.Text == string.Empty || this.TXB_Prazo_Compensacao.Text == string.Empty || this.TXB_Taxa.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NConfig_Cartao_Debito.Inserir(this.TXB_Bandeira.Text, Convert.ToInt32(this.TXB_Prazo_Compensacao.Text), Convert.ToDecimal(this.TXB_Taxa.Text));
                    }
                    else
                    {
                        resp = NConfig_Cartao_Debito.Editar(Convert.ToInt32(this.TXB_Id.Text), this.TXB_Bandeira.Text, Convert.ToInt32(this.TXB_Prazo_Compensacao.Text), Convert.ToDecimal(this.TXB_Taxa.Text));
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro Atualizado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.eAlterar = false;
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

        private void DGV_Config_Atual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TXB_Id.Text = Convert.ToString(this.DGV_Config_Atual.CurrentRow.Cells["idconfig_cartao_debito"].Value);
            this.TXB_Bandeira.Text = Convert.ToString(this.DGV_Config_Atual.CurrentRow.Cells["bandeira"].Value);
            this.TXB_Prazo_Compensacao.Text = Convert.ToString(this.DGV_Config_Atual.CurrentRow.Cells["prazo_compensacao"].Value);
            this.TXB_Taxa.Text = Convert.ToString(this.DGV_Config_Atual.CurrentRow.Cells["taxa"].Value);

            this.BTN_Editar.Enabled = true;
            this.BTN_Novo.Enabled = false;
            this.BTN_Cancelar.Enabled = true;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eAlterar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void FRM_Config_Cartao_Debito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            this.eAlterar = true;
            this.botoes();
            this.Habilitar(true);
        }

        private void configuraçãoAutomáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Detalhe_Config_Cartao_Debito frm = FRM_Detalhe_Config_Cartao_Debito.GetInstancia();
            frm.ShowDialog();
        }

        private void TXB_Prazo_Compensacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TXB_Taxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
