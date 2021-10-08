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
    public partial class FRM_Tipo_Relatorio_Fornecedores : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Fornecedores _Instancia;

        public static FRM_Tipo_Relatorio_Fornecedores GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Fornecedores();
            }
            return _Instancia;
        }

        private void Combo_Fornecedor()
        {
            this.CB_Fornecedores.DataSource = NFornecedor.Mostrar();
            this.CB_Fornecedores.ValueMember = "idfornecedor";
            this.CB_Fornecedores.DisplayMember = "empresa";
        }

        public FRM_Tipo_Relatorio_Fornecedores()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Tipo_Relatorio_Fornecedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Fornecedor específico"))
            {
                FRM_Fornecedor_Especifico frm = FRM_Fornecedor_Especifico.GetInstancia();
                frm.IdFornecedor = Convert.ToInt32(this.CB_Fornecedores.SelectedValue);
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Fornecedor específico - divida atual"))
            {
                FRM_Fornecedor_Especifico_Divida_Atual frm = FRM_Fornecedor_Especifico_Divida_Atual.GetInstancia();
                frm.IdFornecedor = Convert.ToInt32(this.CB_Fornecedores.SelectedValue);
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - detalhado"))
            {
                FRM_Fornecedores_Listagem_Geral_Detalhado frm = FRM_Fornecedores_Listagem_Geral_Detalhado.GetInstancia();
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - resumido"))
            {
                FRM_Fornecedores_Listagem_Geral_Resumido frm = FRM_Fornecedores_Listagem_Geral_Resumido.GetInstancia();
                frm.ShowDialog();
            }
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Fornecedor específico - divida atual") || this.CB_Tipo.Text.Equals("Fornecedor específico"))
            {
                this.CB_Fornecedores.Enabled = true;
                this.Combo_Fornecedor();
            }
            else
            {
                this.CB_Fornecedores.Enabled = false;
                this.CB_Fornecedores.Text = string.Empty;
            }
        }
    }
}
