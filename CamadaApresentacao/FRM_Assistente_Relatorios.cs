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
    public partial class FRM_Assistente_Relatorios : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Assistente_Relatorios _Instancia;

        public static FRM_Assistente_Relatorios GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Assistente_Relatorios();
            }
            return _Instancia;
        }

        public FRM_Assistente_Relatorios()
        {
            InitializeComponent();
        }

        private void FRM_Assistente_Relatorios_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Clientes_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Clientes frm = FRM_Tipo_Relatorio_Clientes.GetInstancia();
            frm.Show();
        }

        private void BTN_Estoque_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Estoque frm = FRM_Tipo_Relatorio_Estoque.GetInstancia();
            frm.Show();
        }

        private void BTN_Fornecedores_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Fornecedores frm = FRM_Tipo_Relatorio_Fornecedores.GetInstancia();
            frm.Show();
        }

        private void BTN_Livro_Caixa_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Livro_Caixa frm = FRM_Tipo_Relatorio_Livro_Caixa.GetInstancia();
            frm.Show();
        }

        private void BTN_Funcionarios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Funcionarios frm = FRM_Tipo_Relatorio_Funcionarios.GetInstancia();
            frm.Show();
        }

        private void BTN_Contas_Receber_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Contas_Receber frm = FRM_Tipo_Relatorio_Contas_Receber.GetInstancia();
            frm.Show();
        }

        private void BTN_Contas_Pagar_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Contas_Pagar frm = FRM_Tipo_Relatorio_Contas_Pagar.GetInstancia();
            frm.Show();
        }

        private void BTN_Cartao_Credito_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Cartao_Credito frm = FRM_Tipo_Relatorio_Cartao_Credito.GetInstancia();
            frm.Show();
        }

        private void BTN_Cartao_Debito_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Cartao_Debito frm = FRM_Tipo_Relatorio_Cartao_Debito.GetInstancia();
            frm.Show();
        }

        private void BTN_Cheque_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Cheque frm = FRM_Tipo_Relatorio_Cheque.GetInstancia();
            frm.Show();
        }
    }
}
