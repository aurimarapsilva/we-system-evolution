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
    public partial class FRM_Opcoes_Atualizar_OS : Form
    {
        //Declarando Variaveis
        public string idos;
        public string num_os; 

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Opcoes_Atualizar_OS _Instancia;

        public static FRM_Opcoes_Atualizar_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Opcoes_Atualizar_OS();
            }
            return _Instancia;
        }

        public FRM_Opcoes_Atualizar_OS()
        {
            InitializeComponent();
            this.CB_Opcoes.SelectedIndex = 0;
        }

        private void FRM_Opcoes_Atualizar_OS_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Opcoes.Text == "DADOS PRIMÁRIOS")
            {
                FRM_OS frm = FRM_OS.GetInstancia();
                frm.eEditar = true;
                frm.Habilitar(true);
                frm.botoes();
                frm.Bloquear();
                this.Close();
            }
            else
            {
                FRM_Atualizar_Dados_Secundários_OS frm = FRM_Atualizar_Dados_Secundários_OS.GetInstancia();
                frm.IdOS = this.idos;
                frm.eAtualizar = true;
                frm.ShowDialog();
                this.Close();
            }
        }

        private void FRM_Opcoes_Atualizar_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
