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
    public partial class FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral _Instancia;

        public static FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral();
            }
            return _Instancia;
        }

        public FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral()
        {
            InitializeComponent();
        }

        private void FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Funcionarios.RPT_Funcionarios_Dez_Mais_Produtivos'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Funcionarios_Dez_Mais_ProdutivosTableAdapter.Fill(this.dS_Funcionarios.RPT_Funcionarios_Dez_Mais_Produtivos);
                // TODO: esta linha de código carrega dados na tabela 'dS_Funcionarios.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Funcionarios.RPT_Cabecalho_Geral);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Funcionarios_Dez_Mais_Produtivos_Visao_Geral_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
