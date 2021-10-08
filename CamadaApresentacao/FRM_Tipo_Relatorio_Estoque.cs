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
    public partial class FRM_Tipo_Relatorio_Estoque : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Tipo_Relatorio_Estoque _Instancia;

        public static FRM_Tipo_Relatorio_Estoque GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Tipo_Relatorio_Estoque();
            }
            return _Instancia;
        }

        private string IdProduto = "";

        public void SetProduto(string idproduto)
        {
            this.IdProduto = idproduto;
        }

        public FRM_Tipo_Relatorio_Estoque()
        {
            InitializeComponent();
            this.CB_Tipo.SelectedIndex = 0;
        }

        private void FRM_Tipo_Relatorio_Estoque_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Selecionar_Click(object sender, EventArgs e)
        {
            if (this.BTN_Selecionar_Produto.Enabled & this.IdProduto.Equals(""))
            {
                MessageBox.Show("Selecione um produto.");
            }
            else
            {
                if (this.CB_Tipo.Text.Equals("Inventario"))
                {
                    FRM_Estoque_Inventario frm = FRM_Estoque_Inventario.GetInstancia();
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Listagem - dez mais vendidos"))
                {
                    FRM_Estoque_Dez_Mais_Vendidos frm = FRM_Estoque_Dez_Mais_Vendidos.GetInstancia();
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Listagem - dez menos vendidos"))
                {
                    FRM_Estoque_Dez_Menos_Vendidos frm = FRM_Estoque_Dez_Menos_Vendidos.GetInstancia();
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Listagem geral - detalhado"))
                {
                    FRM_Estoque_Listagem_Geral_Detalhado frm = FRM_Estoque_Listagem_Geral_Detalhado.GetInstancia();
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Listagem geral - resumido"))
                {
                    FRM_Estoque_Listagem_Geral_Resumido frm = FRM_Estoque_Listagem_Geral_Resumido.GetInstancia();
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Produto específico"))
                {
                    FRM_Estoque_Produto_Especifico frm = FRM_Estoque_Produto_Especifico.GetInstancia();
                    frm.IdProduto = Convert.ToInt32(this.IdProduto);
                    frm.ShowDialog();
                }
                else if (this.CB_Tipo.Text.Equals("Reposição dos produtos"))
                {
                    FRM_Estoque_Reposicao_Produtos frm = FRM_Estoque_Reposicao_Produtos.GetInstancia();
                    frm.ShowDialog();
                }
                else
                {
                    FRM_Estoque_Vencimento_Produtos frm = FRM_Estoque_Vencimento_Produtos.GetInstancia();
                    frm.ShowDialog();
                }
            }
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo.Text.Equals("Produto específico"))
            {
                this.BTN_Selecionar_Produto.Enabled = true;
            }
            else
            {
                this.BTN_Selecionar_Produto.Enabled = false;
                this.IdProduto = string.Empty;
            }
        }

        private void BTN_Selecionar_Produto_Click(object sender, EventArgs e)
        {
            FRM_Buscar_Produto_Relatorio_Especifico frm = FRM_Buscar_Produto_Relatorio_Especifico.GetInstancia();
            frm.Show();
        }
    }
}
