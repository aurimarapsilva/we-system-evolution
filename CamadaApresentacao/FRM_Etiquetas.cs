using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class FRM_Etiquetas : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Etiquetas _Instancia;

        public static FRM_Etiquetas GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Etiquetas();
            }
            return _Instancia;
        }

        private void Combo_Tipo_Produto()
        {
            this.CB_SubTipo.DataSource = NTipo_Produto.Mostrar();
            this.CB_SubTipo.ValueMember = "idtipo_produto";
            this.CB_SubTipo.DisplayMember = "tipo";
        }


        private void Combo_Categoria_Produto()
        {
            this.CB_SubTipo.DataSource = NCategoria.Mostrar();
            this.CB_SubTipo.ValueMember = "idcategoria";
            this.CB_SubTipo.DisplayMember = "nome";
        }

        private string IdProduto;
        public void SetProduto(string idproduto)
        {
            this.IdProduto = idproduto;
        }

        public FRM_Etiquetas()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
            this.CB_Tamanho_Etiqueta.SelectedIndex = 0;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Etiquetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Por Categoria"))
            {
                if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6080 / 6180 / 6280 / 62580 | 6,67cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6180_Categoria frm = FRM_Etiqueta_Carta_Pimaco6180_Categoria.GetInstancia();
                    frm.IdCategoria = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6081 / 6181 / 6281 / 62581 | 10,16cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6181_Categoria frm = FRM_Etiqueta_Carta_Pimaco6181_Categoria.GetInstancia();
                    frm.IdCategoria = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6082 / 6182 / 6282 / 62582 | 10,16cm X 3,39cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6182_Categoria frm = FRM_Etiqueta_Carta_Pimaco6182_Categoria.GetInstancia();
                    frm.IdCategoria = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
            }
            else if (this.CB_Tipo.Text.Equals("Por Produto Específico") && this.IdProduto != "")
            {
                if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6080 / 6180 / 6280 / 62580 | 6,67cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico frm = FRM_Etiqueta_Carta_Pimaco6180_Prod_Especifico.GetInstancia();
                    frm.IdProduto = Convert.ToInt32(this.IdProduto);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6081 / 6181 / 6281 / 62581 | 10,16cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6181_Prod_Especifico frm = FRM_Etiqueta_Carta_Pimaco6181_Prod_Especifico.GetInstancia();
                    frm.IdProduto = Convert.ToInt32(this.IdProduto);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6082 / 6182 / 6282 / 62582 | 10,16cm X 3,39cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico frm = FRM_Etiqueta_Carta_Pimaco6182_Prod_Especifico.GetInstancia();
                    frm.IdProduto = Convert.ToInt32(this.IdProduto);
                    frm.ShowDialog();
                }
            }
            else
            {
                if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6080 / 6180 / 6280 / 62580 | 6,67cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6180_Tipo frm = FRM_Etiqueta_Carta_Pimaco6180_Tipo.GetInstancia();
                    frm.IdTipo_Produto = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6081 / 6181 / 6281 / 62581 | 10,16cm X 2,54cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6181_Tipo frm = FRM_Etiqueta_Carta_Pimaco6181_Tipo.GetInstancia();
                    frm.IdTipo_Produto = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
                else if (this.CB_Tamanho_Etiqueta.Text.Equals("Pimaco 6082 / 6182 / 6282 / 62582 | 10,16cm X 3,39cm | Carta"))
                {
                    FRM_Etiqueta_Carta_Pimaco6182_Tipo frm = FRM_Etiqueta_Carta_Pimaco6182_Tipo.GetInstancia();
                    frm.IdTipo_Produto = Convert.ToInt32(this.CB_SubTipo.SelectedValue);
                    frm.ShowDialog();
                }
            }
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Por Categoria"))
            {
                this.Combo_Categoria_Produto();
                this.CB_SubTipo.Enabled = true;
            }
            else if (this.CB_Tipo.Text.Equals("Por Produto Específico"))
            {
                this.CB_SubTipo.Enabled = false;

                FRM_Buscar_Produto_Etiquetas frm = FRM_Buscar_Produto_Etiquetas.GetInstancia();
                frm.Show();
            }
            else if (this.CB_Tipo.Text.Equals("Por Tipo"))
            {
                this.Combo_Tipo_Produto();
                this.CB_SubTipo.Enabled = true;
            }
        }
    }
}
