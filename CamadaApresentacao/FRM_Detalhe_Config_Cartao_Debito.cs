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
    public partial class FRM_Detalhe_Config_Cartao_Debito : Form
    {
        private bool eAlterar = false;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Detalhe_Config_Cartao_Debito _Instancia;

        public static FRM_Detalhe_Config_Cartao_Debito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Detalhe_Config_Cartao_Debito();
            }
            return _Instancia;
        }

        public FRM_Detalhe_Config_Cartao_Debito()
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
            this.CB_Compensar_Auto.Text = string.Empty;

        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.CB_Compensar_Auto.Enabled = valor;
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eAlterar)
            {
                this.Habilitar(true);
                this.BTN_Alterar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Alterar.Enabled = true;
                this.BTN_Salvar.Enabled = false;
            }
        }


        // Mostrar 
        private void Mostrar()
        {
            this.DGV_Config_Atual.DataSource = NDetalhe_Config_Cartao_Debito.Mostrar();

            // Ocultar Colunas
            this.DGV_Config_Atual.Columns[0].Visible = false;

            // Nome das Colunas 
            this.DGV_Config_Atual.Columns[1].HeaderText = "Compensar Automáticamente";
        }

        private void FRM_Detalhe_Config_Cartao_Debito_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BTN_Alterar_Click(object sender, EventArgs e)
        {
            this.eAlterar = true;
            this.botoes();
            this.Habilitar(true);
            this.CB_Compensar_Auto.SelectedIndex = 0;
            this.TXB_Id.Text = this.DGV_Config_Atual.Rows[0].Cells[0].Value.ToString();
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Id.Text == string.Empty || this.CB_Compensar_Auto.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                }
                else
                {
                    if (this.eAlterar)
                    {
                        resp = NDetalhe_Config_Cartao_Debito.Editar(Convert.ToInt32(this.TXB_Id.Text), this.CB_Compensar_Auto.Text);
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
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.eAlterar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Close();
        }

        private void FRM_Detalhe_Config_Cartao_Debito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
