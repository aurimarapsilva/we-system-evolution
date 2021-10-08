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
    public partial class FRM_Pesquisa_Especifica_Contas_Pagar : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Pesquisa_Especifica_Contas_Pagar _Instancia;

        public static FRM_Pesquisa_Especifica_Contas_Pagar GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Pesquisa_Especifica_Contas_Pagar();
            }
            return _Instancia;
        }

        public FRM_Pesquisa_Especifica_Contas_Pagar()
        {
            InitializeComponent();
        }

        private void FRM_Pesquisa_Especifica_Contas_Pagar_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Continuar_Click(object sender, EventArgs e)
        {
            FRM_Contas_Pagar frm = FRM_Contas_Pagar.GetInstancia();
            frm.Pesquisa_Especifica(this.DTP_Data_Inicial.Text, this.DTP_Data_Final.Text, this.TXB_Nome_Fornecedor.Text);
            frm.LB_Modo_Exibicao.Text = "Específico";
            this.Close();
        }
    }
}
