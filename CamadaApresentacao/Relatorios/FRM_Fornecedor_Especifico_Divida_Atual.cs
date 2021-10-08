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
    public partial class FRM_Fornecedor_Especifico_Divida_Atual : Form
    {
        private int _IdFornecedor;

        public int IdFornecedor
        {
            get
            {
                return _IdFornecedor;
            }

            set
            {
                _IdFornecedor = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Fornecedor_Especifico_Divida_Atual _Instancia;

        public static FRM_Fornecedor_Especifico_Divida_Atual GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Fornecedor_Especifico_Divida_Atual();
            }
            return _Instancia;
        }

        public FRM_Fornecedor_Especifico_Divida_Atual()
        {
            InitializeComponent();
        }

        
        private void FRM_Fornecedor_Especifico_Divida_Atual_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Fornecedores.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Fornecedores.RPT_Cabecalho_Geral);
                this.rPT_Fornecedor_EspecificoTableAdapter.Fill(this.dS_Fornecedores.RPT_Fornecedor_Especifico, this.IdFornecedor);
                this.rPT_Fornecedor_Especifico_Divida_AtualTableAdapter.Fill(this.dS_Fornecedores.RPT_Fornecedor_Especifico_Divida_Atual, this.IdFornecedor);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
