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
    public partial class FRM_Estoque_Vencimento_Produtos : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Estoque_Vencimento_Produtos _Instancia;

        public static FRM_Estoque_Vencimento_Produtos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Estoque_Vencimento_Produtos();
            }
            return _Instancia;
        }

        public FRM_Estoque_Vencimento_Produtos()
        {
            InitializeComponent();
        }

        private void FRM_Estoque_Vencimento_Produtos_Load(object sender, EventArgs e)
        {
            try
            {
                string Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");

                // TODO: esta linha de código carrega dados na tabela 'dS_Estoque.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Estoque.RPT_Cabecalho_Geral);
                this.rPT_Estoque_Vencimento_ProdutosTableAdapter.Fill(this.dS_Estoque.RPT_Estoque_Vencimento_Produtos, Convert.ToDateTime(Data_Atual));

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Estoque_Vencimento_Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
