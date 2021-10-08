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
    public partial class FRM_Inserir_Fab_Venc : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Inserir_Fab_Venc _Instancia;

        public static FRM_Inserir_Fab_Venc GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Inserir_Fab_Venc();
            }
            return _Instancia;
        }

        public FRM_Inserir_Fab_Venc()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHK_Habilitar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Habilitar.Checked)
            {
                this.DTP_Fabricacao.Enabled = true;
                this.DTP_Vencimento.Enabled = true;
            }
            else
            {
                this.DTP_Fabricacao.Enabled = false;
                this.DTP_Vencimento.Enabled = false;
            }
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Tem certeza que os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                FRM_Entrada frm = FRM_Entrada.GetInstancia();
                DateTime Antecipacao_Venc = this.DTP_Vencimento.Value.AddDays(-30);
                frm.SetFab_Venc(this.DTP_Fabricacao.Value.ToString("dd/MM/yyyy"), this.DTP_Vencimento.Value.ToString("dd/MM/yyyy"), Antecipacao_Venc, this.CHK_Habilitar.Checked);
                this.Close();
            }
        }

        private void FRM_Inserir_Fab_Venc_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
