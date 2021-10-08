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
    public partial class FRM_Clientes_LIstagem_Especifica_Divida_Atual : Form
    {
        private int _IdCliente;

        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }

            set
            {
                _IdCliente = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Clientes_LIstagem_Especifica_Divida_Atual _Instancia;

        public static FRM_Clientes_LIstagem_Especifica_Divida_Atual GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Clientes_LIstagem_Especifica_Divida_Atual();
            }
            return _Instancia;
        }

        public FRM_Clientes_LIstagem_Especifica_Divida_Atual()
        {
            InitializeComponent();
        }

       
        private void FRM_Clientes_LIstagem_Especifica_Divida_Atual_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dS_Clientes.RPT_Cabecalho_Geral'. Você pode movê-la ou removê-la conforme necessário.
                this.rPT_Cabecalho_GeralTableAdapter.Fill(this.dS_Clientes.RPT_Cabecalho_Geral);
                this.rPT_Cliente_Divida_AtualTableAdapter.Fill(this.dS_Clientes.RPT_Cliente_Divida_Atual, this.IdCliente);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Clientes_LIstagem_Especifica_Divida_Atual_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
