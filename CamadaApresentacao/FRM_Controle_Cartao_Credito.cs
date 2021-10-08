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
    public partial class FRM_Controle_Cartao_Credito : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Controle_Cartao_Credito _Instancia;

        public static FRM_Controle_Cartao_Credito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Controle_Cartao_Credito();
            }
            return _Instancia;
        }

        public FRM_Controle_Cartao_Credito()
        {
            InitializeComponent();
        }

        //Mostrar mensagem de confirmação
        private void MensagemOk(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Mostrar mensagem de Erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Metodo ocultar colunas do Grid
        private void Formato_Grid()
        {
            // Ocultar Coluns
            this.DGV_Dados.Columns[1].Visible = false;

            // Nome das Colunas
            this.DGV_Dados.Columns[2].HeaderText = "Código da Venda";
            this.DGV_Dados.Columns[3].HeaderText = "Data";
            this.DGV_Dados.Columns[4].HeaderText = "Bandeira";
            this.DGV_Dados.Columns[5].HeaderText = "Nº da Parcela";
            this.DGV_Dados.Columns[6].HeaderText = "Valor";
            this.DGV_Dados.Columns[7].HeaderText = "Valor Líquido";
            this.DGV_Dados.Columns[8].HeaderText = "Data Compensação";

            // Formato Moeda
            this.DGV_Dados.Columns[6].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[7].DefaultCellStyle.Format = "c";
        }

        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.DGV_Dados.DataSource = NCartao_Credito.Mostrar();
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar por Datas
        private void Buscar_Datas()
        {
            this.DGV_Dados.DataSource = NCartao_Credito.Buscar_Datas(this.dtInicial.Value.ToString("dd/MM/yyyy"), this.dtFinal.Value.ToString("dd/MM/yyyy"));
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Datas";
        }

        
        private void FRM_Controle_Cartao_Credito_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.DGV_Dados.Columns[0].Visible = true;

                this.BTN_Compensar.Enabled = true;
                this.BTN_Deletar.Enabled = true;
                this.BTN_Ver_Origem.Enabled = true;
            }
            else
            {
                this.DGV_Dados.Columns[0].Visible = false;

                this.BTN_Compensar.Enabled = false;
                this.BTN_Deletar.Enabled = false;
                this.BTN_Ver_Origem.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Dados.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void DGV_Dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Dados.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Dados.Rows[e.RowIndex].Cells["Selecionar"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void FRM_Controle_Cartao_Credito_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Ver_Origem_Click(object sender, EventArgs e)
        {
            try
            {
                bool chave = false;
                string IdVenda = "";

                foreach (DataGridViewRow row in DGV_Dados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        IdVenda = row.Cells[2].Value.ToString();
                    }
                }
                if (chave)
                {
                    FRM_Ver_Venda_de_Origem_CCred frm = FRM_Ver_Venda_de_Origem_CCred.GetInstancia();
                    frm.idvenda = IdVenda;
                    frm.ShowDialog();
                }
                else
                {
                    this.MensagemErro("Selecione um registro");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void btnBuscar_Datas_Click(object sender, EventArgs e)
        {
            this.Buscar_Datas();
        }

        private void LB_Modo_Exibicao_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Modo_Exibicao.Text == "Mostrar Tudo")
            {
                this.BTN_Mostrar_Tudo.Visible = false;
            }
            else
            {
                this.BTN_Mostrar_Tudo.Visible = true;
            }
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            bool chave = false;
            string Id = "";

            foreach (DataGridViewRow row in DGV_Dados.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    chave = true;
                    Id = row.Cells[1].Value.ToString();
                }
            }
            if (chave)
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string resp = "";

                    resp = NCartao_Credito.Excluir(Convert.ToInt32(Id));

                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Registro excluido com sucesso.");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                }
            }
            else
            {
                this.MensagemErro("Selecione um registro.");
            }
        }

        private void BTN_Compensar_Click(object sender, EventArgs e)
        {
            bool chave = false;
            string resp = "";
            string IdRegistro = "";
            decimal valor = 0;
            string Num_Doc = "";

            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja compensar este(s) registro(s)?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in DGV_Dados.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            // Liberando permissão para prosseguir
                            chave = true;

                            // Capturando Dados
                            IdRegistro = row.Cells[1].Value.ToString();
                            valor += Convert.ToDecimal(row.Cells[7].Value);
                            Num_Doc += "V" + row.Cells[2].Value.ToString() + " - P" + row.Cells[5].Value.ToString() + ", ";

                            // Excluir registro compensado
                            resp = NCartao_Credito.Excluir(Convert.ToInt32(IdRegistro));
                        }
                    }
                    if (chave)
                    {
                        // inserindo no livro caixa
                        DateTime Data = DateTime.Now;
                        resp = NLivro_Caixa.Inserir(Data, "COMPENSAÇÃO DE CARTÃO DE CRÉDITO", Num_Doc, valor, Convert.ToDecimal("0,00"));

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Compensação realizada com sucesso.");
                            this.Mostrar();
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }
                        this.CHK_Selecionar.Checked = false;
                    }
                    else
                    {
                        this.MensagemErro("Selecione um registro.");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }
    }
}
