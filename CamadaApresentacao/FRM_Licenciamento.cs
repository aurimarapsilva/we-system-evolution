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
    public partial class FRM_Licenciamento : Form
    {
        private DataTable TBL_Dados_Licenciamento;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Licenciamento _Instancia;

        public static FRM_Licenciamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Licenciamento();
            }
            return _Instancia;
        }

        public FRM_Licenciamento()
        {
            InitializeComponent();
        }

        private void Mostrar_Dados()
        {
            this.TBL_Dados_Licenciamento = NRemetente.Mostrar();

        
            this.LB_Bairro.Text = this.TBL_Dados_Licenciamento.Rows[0][7].ToString();
            this.LB_Cidde.Text = this.TBL_Dados_Licenciamento.Rows[0][8].ToString();
            this.LB_Uf.Text = this.TBL_Dados_Licenciamento.Rows[0][10].ToString();
            this.LB_Cep.Text = this.TBL_Dados_Licenciamento.Rows[0][9].ToString();

            this.LB_Licenciado_Para.Text = this.TBL_Dados_Licenciamento.Rows[0][2].ToString();
            this.LB_Cnpj.Text = this.TBL_Dados_Licenciamento.Rows[0][4].ToString();
            this.LB_Ie.Text = this.TBL_Dados_Licenciamento.Rows[0][5].ToString();
            this.LB_Endereco.Text = this.TBL_Dados_Licenciamento.Rows[0][6].ToString();
            this.LB_Telefone.Text = this.TBL_Dados_Licenciamento.Rows[0][11].ToString();
            this.LB_Email.Text = this.TBL_Dados_Licenciamento.Rows[0][12].ToString();

            DateTime Adesao = Convert.ToDateTime(this.TBL_Dados_Licenciamento.Rows[0][16]);
            DateTime Termino = Convert.ToDateTime(this.TBL_Dados_Licenciamento.Rows[0][17]);

            this.LB_Adesão.Text = Adesao.ToString("dd/MM/yyyy");
            this.LB_Termino.Text = Termino.ToString("dd/MM/yyyy");
            this.LB_Status.Text = this.TBL_Dados_Licenciamento.Rows[0][18].ToString();
        }

        private void FRM_Licenciamento_Load(object sender, EventArgs e)
        {
            this.Mostrar_Dados();
        }

        private void FRM_Licenciamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Autenticar_Mensalidade_Click(object sender, EventArgs e)
        {
            FRM_Autenticar_Mensalidade frm = FRM_Autenticar_Mensalidade.GetInstancia();
            frm.ShowDialog();
        }
    }
}
