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
    public partial class FRM_Tipo_Relatorio_Clientes : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Clientes _Instancia;

        public static FRM_Tipo_Relatorio_Clientes GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Clientes();
            }
            return _Instancia;
        }

        private void Combo_Cliente()
        {
            this.CB_Cliente.DataSource = NCliente.Mostrar();
            this.CB_Cliente.ValueMember = "idcliente";
            this.CB_Cliente.DisplayMember = "nome_completo";
        }

        public FRM_Tipo_Relatorio_Clientes()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Tipo_Relatorio_Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Cliente específico"))
            {
                FRM_Cliente_Especifico frm = FRM_Cliente_Especifico.GetInstancia();
                frm.IdCliente = Convert.ToInt32(this.CB_Cliente.SelectedValue);
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Cliente específico - divida atual"))
            {
                FRM_Clientes_LIstagem_Especifica_Divida_Atual frm = FRM_Clientes_LIstagem_Especifica_Divida_Atual.GetInstancia();
                frm.IdCliente = Convert.ToInt32(this.CB_Cliente.SelectedValue);
                frm.ShowDialog();
            }
            else if (this.CB_Tipo.Text.Equals("Listagem geral - detalhado"))
            {
                FRM_Clientes_LIstagem_Geral_Detalhado frm = FRM_Clientes_LIstagem_Geral_Detalhado.GetInstancia();
                frm.ShowDialog();
            }
            else 
            {
                FRM_Clientes_LIstagem_Geral_Resumida frm = FRM_Clientes_LIstagem_Geral_Resumida.GetInstancia();
                frm.ShowDialog();
            }
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Cliente específico - divida atual") || this.CB_Tipo.Text.Equals("Cliente específico"))
            {
                this.CB_Cliente.Enabled = true;
                this.Combo_Cliente();
            }
            else
            {
                this.CB_Cliente.Enabled = false;
                this.CB_Cliente.Text = string.Empty;
            }
        }
    }
}
