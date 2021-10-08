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
    public partial class FRM_Estoque_Inventario : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Estoque_Inventario _Instancia;

        public static FRM_Estoque_Inventario GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Estoque_Inventario();
            }
            return _Instancia;
        }

        public FRM_Estoque_Inventario()
        {
            InitializeComponent();
        }

        private void FRM_Estoque_Inventario_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Estoque.RPT_Estoque_Inventario'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Estoque_InventarioTableAdapter.Fill(this.dS_Estoque.RPT_Estoque_Inventario);
                // TODO: esta linha de código carrega dados na tabela 'dS_Estoque.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Estoque.RPT_Cabecalho_Geral);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Estoque_Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
