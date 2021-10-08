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
    public partial class FRM_Funcionario_Especifico_Comissoes_Receber : Form
    {
        private int _IdFuncionario;
        private string _Data_Inicial;
        private string _Data_Final;

        public int IdFuncionario
        {
            get
            {
                return _IdFuncionario;
            }

            set
            {
                _IdFuncionario = value;
            }
        }

        public string Data_Inicial
        {
            get
            {
                return _Data_Inicial;
            }

            set
            {
                _Data_Inicial = value;
            }
        }

        public string Data_Final
        {
            get
            {
                return _Data_Final;
            }

            set
            {
                _Data_Final = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Funcionario_Especifico_Comissoes_Receber _Instancia;

        public static FRM_Funcionario_Especifico_Comissoes_Receber GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Funcionario_Especifico_Comissoes_Receber();
            }
            return _Instancia;
        }

        public FRM_Funcionario_Especifico_Comissoes_Receber()
        {
            InitializeComponent();
        }

        private void FRM_Funcionario_Especifico_Comissoes_Receber_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Funcionarios.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Funcionarios.RPT_Cabecalho_Geral);
                this.rPT_Funcionario_EspecificoTableAdapter.Fill(this.dS_Funcionarios.RPT_Funcionario_Especifico, this.IdFuncionario);
                this.rPT_Funcionario_Financeiro_Comissao_PagarTableAdapter.Fill(this.dS_Funcionarios.RPT_Funcionario_Financeiro_Comissao_Pagar, this.IdFuncionario, Convert.ToDateTime(this.Data_Inicial), Convert.ToDateTime(this.Data_Final));

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Funcionario_Especifico_Comissoes_Receber_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
