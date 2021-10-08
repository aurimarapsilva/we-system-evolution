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
    public partial class FRM_Tarefas_OS_Em_Branco : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tarefas_OS_Em_Branco _Instancia;

        public static FRM_Tarefas_OS_Em_Branco GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tarefas_OS_Em_Branco();
            }
            return _Instancia;
        }

        private void Combo_OS()
        {
            this.CB_OS.DataSource = NOS.Mostrar_OS_Em_Branco();
            this.CB_OS.ValueMember = "idos";
            this.CB_OS.DisplayMember = "num_os";
        }

        public FRM_Tarefas_OS_Em_Branco()
        {
            InitializeComponent();
            this.Combo_OS();
        }

        private void CB_Acao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Acao.Text.Equals(""))
            {
                this.BTN_Continuar.Enabled = false; 
            }
            else
            {
                this.BTN_Continuar.Enabled = true;
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Continuar_Click(object sender, EventArgs e)
        {
            FRM_OS frm = FRM_OS.GetInstancia();
            frm.Tarefas_OS_Em_Branco(this.CB_Acao.Text, Convert.ToString(this.CB_OS.SelectedValue), this.CB_OS.Text);
            this.Close();
        }

        private void FRM_Tarefas_OS_Em_Branco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
