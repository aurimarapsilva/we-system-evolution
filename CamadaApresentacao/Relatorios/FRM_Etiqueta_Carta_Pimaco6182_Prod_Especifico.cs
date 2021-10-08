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
    public partial class FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico : Form
    {
        private int _IdProduto;

        public int IdProduto
        {
            get
            {
                return _IdProduto;
            }

            set
            {
                _IdProduto = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico _Instancia;

        public static FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico();
            }
            return _Instancia;
        }

        public FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico()
        {
            InitializeComponent();
        }

        
        private void FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico_Load(object sender, EventArgs e)
        {
            try
            {
                this.rPT_Etiquetas_Carta_Pimaco6180_Prod_EspecificoTableAdapter.Fill(this.dS_Etiquetas.RPT_Etiquetas_Carta_Pimaco6180_Prod_Especifico, this.IdProduto);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
