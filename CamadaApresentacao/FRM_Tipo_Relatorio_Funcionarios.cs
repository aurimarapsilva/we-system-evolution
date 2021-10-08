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
    public partial class FRM_Tipo_Relatorio_Funcionarios : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Funcionarios _Instancia;

        public static FRM_Tipo_Relatorio_Funcionarios GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Funcionarios();
            }
            return _Instancia;
        }

        private void Combo_Funcionario()
        {
            this.CB_Funcionarios.DataSource = NFuncionario.Mostrar();
            this.CB_Funcionarios.ValueMember = "idfuncionario";
            this.CB_Funcionarios.DisplayMember = "usuario";
        }

        public FRM_Tipo_Relatorio_Funcionarios()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Funcionário específico"))
            {
                this.CB_Funcionarios.Enabled = true;
                this.Combo_Funcionario();
            }
            else if (this.CB_Tipo.Text.Equals("Funcionário específico - comissões"))
            {
                this.CB_Funcionarios.Enabled = true;
                this.Combo_Funcionario();
                this.DTP_Data_Inicial.Enabled = true;
                this.DTP_Data_Final.Enabled = true;
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - comissões"))
            {
                this.DTP_Data_Inicial.Enabled = true;
                this.DTP_Data_Final.Enabled = true;
            }
            else
            {
                this.CB_Funcionarios.Enabled = false;
                this.CB_Funcionarios.Text = string.Empty;
                this.DTP_Data_Inicial.Enabled = false;
                this.DTP_Data_Final.Enabled = false;
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Tipo_Relatorio_Funcionarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Dez mais produtivos - visão geral"))
            {
                FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral frm = FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Dez menos produtivos - visão geral"))
            {
                FRM_Funcionarios_Dez_Menos_Produtivos_Visao_Geral frm = FRM_Funcionarios_Dez_Menos_Produtivos_Visao_Geral.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Funcionário específico"))
            {
                FRM_Funcionario_Especifico frm = FRM_Funcionario_Especifico.GetInstancia();
                frm.IdFuncionario = Convert.ToInt32(this.CB_Funcionarios.SelectedValue);
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Funcionário específico - comissões"))
            {
                FRM_Funcionario_Especifico_Comissoes_Receber frm = FRM_Funcionario_Especifico_Comissoes_Receber.GetInstancia();
                frm.IdFuncionario = Convert.ToInt32(this.CB_Funcionarios.SelectedValue);
                frm.Data_Inicial = this.DTP_Data_Inicial.Value.ToString("dd/MM/yyyy");
                frm.Data_Final = this.DTP_Data_Final.Value.ToString("dd/MM/yyyy");
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - comissões"))
            {
                FRM_Funcionarios_Listagem_Geal_Comissoes_Receber frm = FRM_Funcionarios_Listagem_Geal_Comissoes_Receber.GetInstancia();
                frm.Data_Inicial = this.DTP_Data_Inicial.Value.ToString("dd/MM/yyyy");
                frm.Data_Final = this.DTP_Data_Final.Value.ToString("dd/MM/yyyy");
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - detalhado"))
            {
                FRM_Funcionarios_Listagem_Geral_Detalhado frm = FRM_Funcionarios_Listagem_Geral_Detalhado.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - resumido"))
            {
                FRM_Funcionarios_Listagem_Geral_Resumido frm = FRM_Funcionarios_Listagem_Geral_Resumido.GetInstancia();
                frm.ShowDialog();
            }
        }
    }
}
