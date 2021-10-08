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
    public partial class FRM_Selecionar_Configuracoes : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Selecionar_Configuracoes _Instancia;

        public static FRM_Selecionar_Configuracoes GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Selecionar_Configuracoes();
            }
            return _Instancia;
        }

        public FRM_Selecionar_Configuracoes()
        {
            InitializeComponent();
            this.CB_Opcoes.SelectedIndex = 0;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Opcoes.Text.Equals("Backup"))
            {
                FRM_Info_Config_Backup frm = FRM_Info_Config_Backup.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Cartão de Crédito"))
            {
                FRM_Config_Cartao_Credito frm = FRM_Config_Cartao_Credito.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Cartão de Debito"))
            {
                FRM_Config_Cartao_Debito frm = FRM_Config_Cartao_Debito.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Geral"))
            {
                FRM_Configuracoes_gerais frm = FRM_Configuracoes_gerais.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Juros de Atraso"))
            {
                FRM_Config_Juros_Atraso frm = FRM_Config_Juros_Atraso.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Juros de Parcelamento"))
            {
                FRM_Config_Juros_Parcelamento frm = FRM_Config_Juros_Parcelamento.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Nível de Acesso"))
            {
                FRM_Config_Nivel_Acesso frm = FRM_Config_Nivel_Acesso.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Opcoes.Text.Equals("Numeração Automática"))
            {
                FRM_Numeracao_Auto frm = FRM_Numeracao_Auto.GetInstancia();
                frm.Show();
            }
            else if (this.CB_Opcoes.Text.Equals("Orçamento"))
            {
                FRM_Config_Orcamento frm = FRM_Config_Orcamento.GetInstancia();
                frm.Show();
            }
            else 
            {
                FRM_Config_OS frm = FRM_Config_OS.GetInstancia();
                frm.Show();
            }

            this.Close();
        }

        private void FRM_Selecionar_Configuracoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
