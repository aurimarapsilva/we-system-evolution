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
    public partial class FRM_Assistente_Impressao_Ordem_Serviço : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Assistente_Impressao_Ordem_Serviço _Instancia;

        public static FRM_Assistente_Impressao_Ordem_Serviço GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Assistente_Impressao_Ordem_Serviço();
            }
            return _Instancia;
        }

        // Metodo e Variaveis Pegar Dados O.S. - IMPRESSÃO O.S. PREENCHIDA
        private string IdOS = "";
        private string Tipo_OS = "";
        public void Set_OS_Prenchida(string idos, string tipo_os, string num_os)
        {
            this.IdOS = idos;
            this.Tipo_OS = tipo_os;
            this.TXB_Num_OS.Text = num_os;
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

        public FRM_Assistente_Impressao_Ordem_Serviço()
        {
            InitializeComponent();
            this.CB_Tipo_OS.SelectedIndex = 0;
        }

        private void TXB_Num_OS_TextChanged(object sender, EventArgs e)
        {
            if (this.TXB_Num_OS.Text.Equals(""))
            {
                this.BTN_Imprimir.Enabled = false;
            }
            else
            {
                this.BTN_Imprimir.Enabled = true;
            }
        }

        private void FRM_Printer_Tipo_Ordem_Serviço_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Imprimir_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo_OS.Text.Equals("OS - Em Branco"))
            {
                FRM_Imprimir_OS_Em_Branco frm = FRM_Imprimir_OS_Em_Branco.GetInstancia();
                frm.Show();
            }
            else if (this.CB_Tipo_OS.Text.Equals("OS - Preenchida"))
            {
                if (this.IdOS != "" && this.Tipo_OS != "" && this.TXB_Num_OS.Text != "")
                {
                    if (this.Tipo_OS.Equals("ELETRO-ELETRÔNICOS"))
                    {
                        FRM_Ordem_Servico_Preenchida_Eletro_Print_Master frm = FRM_Ordem_Servico_Preenchida_Eletro_Print_Master.GetInstancia();
                        frm.IdOS = Convert.ToInt32(this.IdOS);
                        frm.ShowDialog();
                    }
                    else
                    {
                        FRM_Ordem_Servico_Preenchida_Automotivo_Print_Master frm = FRM_Ordem_Servico_Preenchida_Automotivo_Print_Master.GetInstancia();
                        frm.IdOS = Convert.ToInt32(this.IdOS);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    this.MensagemErro("Selecione uma O.S.");
                }
            }
            else if (this.CB_Tipo_OS.Text.Equals("Página Anexo - Prod. e Serviços"))
            {
                if (this.IdOS != "" && this.Tipo_OS != "" && this.TXB_Num_OS.Text != "")
                {
                    if (this.Tipo_OS.Equals("ELETRO-ELETRÔNICOS"))
                    {
                        FRM_Ordem_Servico_Eletro_Pagina_Anexo frm = FRM_Ordem_Servico_Eletro_Pagina_Anexo.GetInstancia();
                        frm.IdOS = Convert.ToInt32(this.IdOS);
                        frm.ShowDialog();
                    }
                    else
                    {
                        FRM_Ordem_Servico_Automotivo_Pagina_Anexo frm = FRM_Ordem_Servico_Automotivo_Pagina_Anexo.GetInstancia();
                        frm.IdOS = Convert.ToInt32(this.IdOS);
                        frm.ShowDialog();
                    }
                }
                else
                {
                    this.MensagemErro("Selecione uma O.S.");
                }
            }
        }

        private void CB_Tipo_OS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo_OS.Text.Equals("OS - Preenchida") || this.CB_Tipo_OS.Text.Equals("Página Anexo - Prod. e Serviços"))
            {
                this.BTN_Imprimir.Enabled = false;
                this.BTN_Buscar_OS.Enabled = true;

                FRM_Buscar_OS frm = FRM_Buscar_OS.GetInstancia();
                frm.Show();
            }
            else if (this.CB_Tipo_OS.Text.Equals("OS - Em Branco"))
            {
                this.BTN_Imprimir.Enabled = true;
                this.BTN_Buscar_OS.Enabled = false;
            }
        }

        private void BTN_Buscar_OS_Click(object sender, EventArgs e)
        {
            FRM_Buscar_OS frm = FRM_Buscar_OS.GetInstancia();
            frm.Show();
        }
    }
}
