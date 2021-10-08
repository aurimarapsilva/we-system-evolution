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
    public partial class FRM_Informacoes_Cheque_Orcamento : Form
    {
        public decimal Valor_Total = 0;
        private decimal Valor_Parcelas = 0;
        private int Quant_Parcelas = 1;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Informacoes_Cheque_Orcamento _Instancia;

        public static FRM_Informacoes_Cheque_Orcamento GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Informacoes_Cheque_Orcamento();
            }
            return _Instancia;
        }

        public FRM_Informacoes_Cheque_Orcamento()
        {
            InitializeComponent();
            this.CB_Banco_Emissor.SelectedIndex = 0;
            this.CB_Intervalo_Parcelas.SelectedIndex = 0;
        }

        private void FRM_Informacoes_Cheque_Orcamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Tem certeza que os dados estão corretos?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                FRM_Detalhes_Cheque_Orcamento frm = FRM_Detalhes_Cheque_Orcamento.GetInstancia();
                frm.Data = this.DTP_Data.Value;
                frm.banco_emissor = this.CB_Banco_Emissor.Text;
                frm.nome_titular = this.TXB_Nome_Titular.Text;
                frm.valor_total = this.Valor_Total;
                frm.valor_parcela = this.Valor_Parcelas;
                frm.quant_parcelas = this.Quant_Parcelas;
                frm.Intervalo_Parcelas = Convert.ToInt32(this.CB_Intervalo_Parcelas.Text);
                frm.Show();
                this.Close();
            }
        }

        private void FRM_Informacoes_Cheque_Orcamento_Load(object sender, EventArgs e)
        {
            this.TXB_Valor.Text = this.Valor_Total.ToString("C");
            this.TXB_Quant_Parc.Text = this.Quant_Parcelas.ToString();
        }

        private void BTN_Incrementar_Click(object sender, EventArgs e)
        {
            this.Quant_Parcelas++;
            this.TXB_Quant_Parc.Text = this.Quant_Parcelas.ToString();
        }

        private void BTN_Decrementar_Click(object sender, EventArgs e)
        {
            if (this.Quant_Parcelas.Equals(1))
            {
                MessageBox.Show("Não é permitido valor menor que 1", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Quant_Parcelas--;
                this.TXB_Quant_Parc.Text = this.Quant_Parcelas.ToString();
            }
        }

        private void TXB_Quant_Parc_TextChanged(object sender, EventArgs e)
        {
            this.Valor_Parcelas = this.Valor_Total / Convert.ToDecimal(this.Quant_Parcelas);
            this.TXB_Valor.Text = this.Valor_Parcelas.ToString("C");
        }
    }
}
