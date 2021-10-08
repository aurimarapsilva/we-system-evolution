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
    public partial class FRM_Deletar_mais_1_Item_Venda : Form
    {
        public int linha_atual;
        public decimal quant_atual = 0;
        public decimal valor_item_deletado = 0;
        public decimal subtotal_atual = 0;
        public decimal preco_custo_item_deletado = 0;
        public decimal subtotal_custo_atual = 0;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Deletar_mais_1_Item_Venda _Instancia;

        public static FRM_Deletar_mais_1_Item_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Deletar_mais_1_Item_Venda();
            }
            return _Instancia;
        }

        private decimal Quant = 1;

        public FRM_Deletar_mais_1_Item_Venda()
        {
            InitializeComponent();
        }

        private void FRM_Deletar_mais_1_Item_Load(object sender, EventArgs e)
        {
            this.TXB_Quant.Text = this.Quant.ToString();
        }

        private void TXB_Quant_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTN_Incremento_Click(object sender, EventArgs e)
        {
            this.Quant++;
            this.TXB_Quant.Text = this.Quant.ToString();
        }

        private void BTN_decremento_Click(object sender, EventArgs e)
        {
            this.Quant--;
            this.TXB_Quant.Text = this.Quant.ToString();
        }

        private void FRM_Deletar_mais_1_Item_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            FRM_Caixa frm = FRM_Caixa.GetInstancia();
            DataGridView Grid = frm.dataListaDetalhes;
            frm.CHK_Selecionar.Checked = false;
            Grid.Focus();
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Realmente deseja deletar " + this.Quant.ToString() + " item(s)?" , "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                FRM_Caixa frm = FRM_Caixa.GetInstancia();
                frm.Deletar_Mais_1_Item(this.Quant, this.linha_atual, this.quant_atual, this.valor_item_deletado, this.subtotal_atual, this.preco_custo_item_deletado, this.subtotal_custo_atual);
                this.Close();
            }
        }
    }
}
