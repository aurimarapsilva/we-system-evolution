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
    public partial class FRM_Selecionar_Controle_Financas : Form
    {
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Selecionar_Controle_Financas _Instancia;

        public static FRM_Selecionar_Controle_Financas GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Selecionar_Controle_Financas();
            }
            return _Instancia;
        }

        public FRM_Selecionar_Controle_Financas()
        {
            InitializeComponent();
            this.CB_Opcoes.SelectedIndex = 0;
        }

        private void FRM_Selecionar_Controle_Financas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Opcoes.Text.Equals("CONTROLE DE CARTÃO DE CRÉDITO"))
            {
                FRM_Controle_Cartao_Credito frm = FRM_Controle_Cartao_Credito.GetInstancia();
                frm.ShowDialog();
                this.Close();
            }
            else if (this.CB_Opcoes.Text.Equals("CONTROLE DE CARTÃO DE DEBITO"))
            {
                FRM_Controle_Cartao_Debito frm = FRM_Controle_Cartao_Debito.GetInstancia();
                frm.ShowDialog();
                this.Close();
            }
            else
            {
                FRM_Controle_Cheque frm = FRM_Controle_Cheque.GetInstancia();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
