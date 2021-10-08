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
    public partial class FRM_Etiqueta_Carta_Pimaco6181_Tipo : Form
    {
        private int _IdTipo_Produto;

        public int IdTipo_Produto
        {
            get
            {
                return _IdTipo_Produto;
            }

            set
            {
                _IdTipo_Produto = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Etiqueta_Carta_Pimaco6181_Tipo _Instancia;

        public static FRM_Etiqueta_Carta_Pimaco6181_Tipo GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Etiqueta_Carta_Pimaco6181_Tipo();
            }
            return _Instancia;
        }

        public FRM_Etiqueta_Carta_Pimaco6181_Tipo()
        {
            InitializeComponent();
        }

        
        private void FRM_Etiqueta_Carta_Pimaco6181_Tipo_Load(object sender, EventArgs e)
        {
            try
            {
                this.rPT_Etiquetas_Carta_Pimaco6180_TipoTableAdapter.Fill(this.dS_Etiquetas.RPT_Etiquetas_Carta_Pimaco6180_Tipo, this.IdTipo_Produto);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Etiqueta_Carta_Pimaco6181_Tipo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
