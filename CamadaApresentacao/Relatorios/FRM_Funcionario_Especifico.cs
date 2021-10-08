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
    public partial class FRM_Funcionario_Especifico : Form
    {
        private int _IdFuncionario;

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

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Funcionario_Especifico _Instancia;

        public static FRM_Funcionario_Especifico GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Funcionario_Especifico();
            }
            return _Instancia;
        }

        public FRM_Funcionario_Especifico()
        {
            InitializeComponent();
        }
        
        private void FRM_Funcionario_Especifico_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Funcionarios.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Funcionarios.RPT_Cabecalho_Geral);
                this.rPT_Funcionario_EspecificoTableAdapter.Fill(this.dS_Funcionarios.RPT_Funcionario_Especifico, this.IdFuncionario);
                this.rPT_Funcionario_ProdutividadeTableAdapter.Fill(this.dS_Funcionarios.RPT_Funcionario_Produtividade, this.IdFuncionario);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Funcionario_Especifico_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
