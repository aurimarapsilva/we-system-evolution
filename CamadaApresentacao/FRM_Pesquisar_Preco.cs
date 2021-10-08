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
    public partial class FRM_Pesquisar_Preco : Form
    {
        private decimal Quant_Ideal = 0;
        private decimal Preco_Venda = 0;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Pesquisar_Preco _Instancia;

        public static FRM_Pesquisar_Preco GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Pesquisar_Preco();
            }
            return _Instancia;
        }

        //Mostrar mensagem de alerta
        private void MensagemAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public FRM_Pesquisar_Preco()
        {
            InitializeComponent();
            
        }

        private void Limpar()
        {
            this.TXB_Descricao.Text = string.Empty;
            this.TXB_Tipo.Text = string.Empty;
            this.TXB_Estoque_Atual.Text = string.Empty;
            this.TXB_Corredor_Expo.Text = string.Empty;
            this.TXB_Prateleira_Expo.Text = string.Empty;
            this.TXB_Corredor_Dep.Text = string.Empty;
            this.TXB_Prateleira_Dep.Text = string.Empty;
            this.TXB_Valor_Dinheiro.Text = string.Empty;
            this.TXB_Valor_Card_Cred.Text = string.Empty;
            this.TXB_Valor_Cred_Loja.Text = string.Empty;
            this.PX_Imagem.Image = Properties.Resources.DefaultImage;
            this.Quant_Ideal = 0;
            this.Preco_Venda = 0;
            this.TXB_Estoque_Atual.BackColor = Color.WhiteSmoke;
            this.TXB_Estoque_Atual.ForeColor = Color.Green;
        }


        public void SetProduto(string descricao, string tipo, string estoque_atual, string corredor_expo, string prateleira_expo, string corredor_dep, string prateleira_dep, decimal preco_venda, byte[] imagem, decimal quant_ideal)
        {
            this.TXB_Descricao.Text = descricao;
            this.TXB_Tipo.Text = tipo;
            this.TXB_Estoque_Atual.Text = estoque_atual;
            this.TXB_Corredor_Expo.Text = corredor_expo;
            this.TXB_Prateleira_Expo.Text = prateleira_expo;
            this.TXB_Corredor_Dep.Text = corredor_dep;
            this.TXB_Prateleira_Dep.Text = prateleira_dep;

            this.Preco_Venda = preco_venda;
            this.TXB_Valor_Dinheiro.Text = this.Preco_Venda.ToString("C");

            this.CB_Parcel_Card_Cred.SelectedIndex = 0;
            this.CB_Parcel_Cred_Loja.SelectedIndex = 0;
            this.Calcular_Juros_Parcelamento_CB_Card_Cred(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Card_Cred.Text));
            this.Calcular_Juros_Parcelamento_CB_Cred_Loja(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Cred_Loja.Text));

            byte[] imageBuffer = imagem;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
            this.PX_Imagem.Image = Image.FromStream(ms);
            this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;

            decimal Quant_Ideal = quant_ideal;
            if (Convert.ToDecimal(this.TXB_Estoque_Atual.Text) < quant_ideal)
            {
                this.TXB_Estoque_Atual.BackColor = Color.WhiteSmoke;
                this.TXB_Estoque_Atual.ForeColor = Color.Red;
            }
        }

        private void Pesquisar_Preco_Codigo_Barras()
        {
            this.DGV_Pesquisar_Preco_Codigo_Barras.DataSource = NProduto.Pesquisar_Preco(this.TXB_Descricao.Text);
        }

        private decimal Taxa_Juros_Card_Cred = 0;
        private decimal Taxa_Juros_Cred_Loja = 0;
        private string Status = "";
        
        private void Calcular_Juros_Parcelamento_CB_Card_Cred(decimal Preco_Venda, decimal Quant_Parc)
        {
            if (Status.Equals("SIM"))
            {
                // CARTÃO DE CRÉDITO
                decimal Valor_Juros_Card_Cred = (Preco_Venda * this.Taxa_Juros_Card_Cred / 100);
                decimal Valor_Total_Juros_Card_Cred = Valor_Juros_Card_Cred * Quant_Parc;
                decimal Valor_Final_Card_Cred = Preco_Venda + Valor_Total_Juros_Card_Cred;
                this.TXB_Valor_Card_Cred.Text = Valor_Final_Card_Cred.ToString("C");
            }
            else
            {
                // CARTÃO DE CRÉDITO
                this.TXB_Valor_Card_Cred.Text = Preco_Venda.ToString("C");
            }
        }


        private void Calcular_Juros_Parcelamento_CB_Cred_Loja(decimal Preco_Venda, decimal Quant_Parc)
        {
            if (Status.Equals("SIM"))
            {
                // CREDIÁRIO DA LOJA
                decimal Valor_Juros_Cred_Loja = (Preco_Venda * this.Taxa_Juros_Cred_Loja / 100);
                decimal Valor_Total_Juros_Cred_Loja = Valor_Juros_Cred_Loja * Quant_Parc;
                decimal Valor_Final_Cred_Loja = Preco_Venda + Valor_Total_Juros_Cred_Loja;
                this.TXB_Valor_Cred_Loja.Text = Valor_Final_Cred_Loja.ToString("C");
            }
            else
            {
                // CREDIÁRIO DA LOJA
                this.TXB_Valor_Cred_Loja.Text = Preco_Venda.ToString("C");
            }
        }

        private void FRM_Pesquisar_Preco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void TXB_Descricao_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Pesquisar_Preco_Codigo_Barras();

            if (this.DGV_Pesquisar_Preco_Codigo_Barras.Rows.Count == 1)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.Quant_Ideal = 0;

                    // Mostrando dados
                    this.TXB_Descricao.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[1].Value.ToString();
                    this.TXB_Tipo.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[5].Value.ToString();
                    this.TXB_Estoque_Atual.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[3].Value.ToString();
                    this.TXB_Corredor_Expo.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[7].Value.ToString();
                    this.TXB_Prateleira_Expo.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[8].Value.ToString();
                    this.TXB_Corredor_Dep.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[9].Value.ToString();
                    this.TXB_Prateleira_Dep.Text = this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[10].Value.ToString();

                    this.Preco_Venda = Convert.ToDecimal(this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[2].Value);
                    this.TXB_Valor_Dinheiro.Text = this.Preco_Venda.ToString("C");

                    this.CB_Parcel_Card_Cred.SelectedIndex = 0;
                    this.CB_Parcel_Cred_Loja.SelectedIndex = 0;
                    this.Calcular_Juros_Parcelamento_CB_Card_Cred(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Card_Cred.Text));
                    this.Calcular_Juros_Parcelamento_CB_Cred_Loja(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Cred_Loja.Text));

                    byte[] imageBuffer = (byte[])this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[11].Value;
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                    this.PX_Imagem.Image = Image.FromStream(ms);
                    this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;

                    this.Quant_Ideal = Convert.ToDecimal(this.DGV_Pesquisar_Preco_Codigo_Barras.Rows[0].Cells[6].Value);
                    // Estoque abaixo do ideal
                    if (Convert.ToDecimal(this.TXB_Estoque_Atual.Text) < Quant_Ideal)
                    {
                        this.TXB_Estoque_Atual.BackColor = Color.WhiteSmoke;
                        this.TXB_Estoque_Atual.ForeColor = Color.Red;

                        this.MensagemAlerta("Estoque abaixo do ideal.");
                    }
                }
            }
        }

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.TXB_Descricao.Focus();
        }

        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            this.Limpar();
            this.Close();
        }

        private void FRM_Pesquisar_Preco_Load(object sender, EventArgs e)
        {
            this.TXB_Valor_Dinheiro.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Dinheiro.ForeColor = Color.Red;

            this.TXB_Valor_Card_Cred.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Card_Cred.ForeColor = Color.Red;

            this.TXB_Valor_Cred_Loja.BackColor = Color.WhiteSmoke;
            this.TXB_Valor_Cred_Loja.ForeColor = Color.Red;

            this.TXB_Estoque_Atual.BackColor = Color.WhiteSmoke;
            this.TXB_Estoque_Atual.ForeColor = Color.Green;

            // Obtendo Dados dos Juros de PArcelamento
            DataTable TBL_Dados_Juros_Parcelamento = NConfig_Juros_Parcelamento.Mostrar();
            this.Taxa_Juros_Card_Cred = Convert.ToDecimal(TBL_Dados_Juros_Parcelamento.Rows[0][1]);
            this.Taxa_Juros_Cred_Loja = Convert.ToDecimal(TBL_Dados_Juros_Parcelamento.Rows[0][2]);
            this.Status = TBL_Dados_Juros_Parcelamento.Rows[0][3].ToString();
        }

        private void FRM_Pesquisar_Preco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                FRM_Buscar_Produto_Pesquisa_Preco frm = FRM_Buscar_Produto_Pesquisa_Preco.GetInstancia();
                frm.txtBuscar.Text = this.TXB_Descricao.Text;
                frm.Show();
            }
        }

        private void CB_Parcel_Card_Cred_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Calcular_Juros_Parcelamento_CB_Card_Cred(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Card_Cred.Text));
        }

        private void CB_Parcel_Cred_Loja_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Calcular_Juros_Parcelamento_CB_Cred_Loja(this.Preco_Venda, Convert.ToDecimal(this.CB_Parcel_Cred_Loja.Text));
        }
    }
}
