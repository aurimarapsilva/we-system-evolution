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
    public partial class FRM_Etiqueta_Carta_Pimaco6181_Categoria : Form
    {
        private int _IdCategoria;

        public int IdCategoria
        {
            get
            {
                return _IdCategoria;
            }

            set
            {
                _IdCategoria = value;
            }
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Etiqueta_Carta_Pimaco6181_Categoria _Instancia;

        public static FRM_Etiqueta_Carta_Pimaco6181_Categoria GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Etiqueta_Carta_Pimaco6181_Categoria();
            }
            return _Instancia;
        }

        public FRM_Etiqueta_Carta_Pimaco6181_Categoria()
        {
            InitializeComponent();
        }

        
        private void FRM_Etiqueta_Carta_Pimaco6181_Categoria_Load(object sender, EventArgs e)
        {
            try
            {
                this.rPT_Etiquetas_Carta_Pimaco6180_CategoriaTableAdapter.Fill(this.dS_Etiquetas.RPT_Etiquetas_Carta_Pimaco6180_Categoria, this.IdCategoria);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }

        private void FRM_Etiqueta_Carta_Pimaco6181_Categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
