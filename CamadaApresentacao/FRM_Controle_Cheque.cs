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
    public partial class FRM_Controle_Cheque : Form
    {
        private int idcheque = 0;
        private decimal valor_cheque = 0;
        private string num_doc_livro_caixa = "";

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Controle_Cheque _Instancia;

        public static FRM_Controle_Cheque GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Controle_Cheque();
            }
            return _Instancia;
        }

        public FRM_Controle_Cheque()
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
            this.DGV_Dados.Columns[1].Visible = false; // ID Cheque

            // Nome das Colunas
            this.DGV_Dados.Columns[2].HeaderText = "Código da Venda";
            this.DGV_Dados.Columns[3].HeaderText = "Data";
            this.DGV_Dados.Columns[4].HeaderText = "Banco Emissor";
            this.DGV_Dados.Columns[5].HeaderText = "Nome do Titular";
            this.DGV_Dados.Columns[6].HeaderText = "Nº do Cheque";
            this.DGV_Dados.Columns[7].HeaderText = "Nº da Parcela";
            this.DGV_Dados.Columns[8].HeaderText = "Valor";
            this.DGV_Dados.Columns[9].HeaderText = "Depositar dia";
            this.DGV_Dados.Columns[10].HeaderText = "Status";

            // Formato Moeda
            this.DGV_Dados.Columns[8].DefaultCellStyle.Format = "c";
        }

        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.DGV_Dados.DataSource = NCheque.Mostrar();
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar Cheque para Depositar Hoje
        private void Buscar_Depositar_Hoje()
        {
            string Data_Atual = DateTime.Now.ToString("dd/MM/yyyy");

            this.DGV_Dados.DataSource = NCheque.Buscar_Depositar_Hoje(Data_Atual);
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cheques para Depositar Hoje";
        }


        // Buscar Cheque para Depositaado
        private void Buscar_Depositado()
        {
            this.DGV_Dados.DataSource = NCheque.Buscar_Depositado();
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cheques Depositados";
        }


        // Buscar Cheque para Aguardando
        private void Buscar_Aguardando()
        {
            this.DGV_Dados.DataSource = NCheque.Buscar_Aguardando();
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cheques Aguardando";
        }


        // Buscar Cheque para Devolvido
        private void Buscar_Devolvido()
        {
            this.DGV_Dados.DataSource = NCheque.Buscar_Devolvido();
            this.Formato_Grid();
            this.LB_Total_Registros.Text = Convert.ToString(this.DGV_Dados.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cheques Devolvidos";
        }

        private void FRM_Controle_Cheque_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void Buscar_Depositr_Hoje_Click(object sender, EventArgs e)
        {
            this.Buscar_Depositar_Hoje();
        }

        private void BTN_Buscar_Aguardando_Click(object sender, EventArgs e)
        {
            this.Buscar_Aguardando();
        }

        private void BTN_Buscar_Depositado_Click(object sender, EventArgs e)
        {
            this.Buscar_Depositado();
        }

        private void BTN_Buscar_Devolvido_Click(object sender, EventArgs e)
        {
            this.Buscar_Devolvido();
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
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

        private void DGV_Dados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Dados.Columns["Selecionar"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Dados.Rows[e.RowIndex].Cells["Selecionar"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.DGV_Dados.Columns[0].Visible = true;

                this.BTN_Compensar.Enabled = true;
                this.BTN_Deletar.Enabled = true;
                this.BTN_Ver_Origem.Enabled = true;
                this.BTN_Atualizar_Depositar.Enabled = true;
                this.BTN_Atualizar_Devolvido.Enabled = true;
            }
            else
            {
                this.DGV_Dados.Columns[0].Visible = false;

                this.BTN_Compensar.Enabled = false;
                this.BTN_Deletar.Enabled = false;
                this.BTN_Ver_Origem.Enabled = false;
                this.BTN_Atualizar_Depositar.Enabled = false;
                this.BTN_Atualizar_Devolvido.Enabled = false;

                foreach (DataGridViewRow _row in this.DGV_Dados.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void BTN_Atualizar_Depositar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool chave = false;
                foreach (DataGridViewRow row in DGV_Dados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        this.idcheque = Convert.ToInt32(row.Cells[1].Value);
                    }
                }
                if (chave)
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja atualizar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.OK)
                    {
                        resp = NCheque.Atualizar_Status_Depositado(this.idcheque);

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Atualização efetuada com sucesso.");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.Mostrar();
                    }
                }
                else
                {
                    this.MensagemErro("Selecione um registro");
                }
                this.CHK_Selecionar.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void BTN_Atualizar_Devolvido_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool chave = false;
                foreach (DataGridViewRow row in DGV_Dados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        chave = true;
                        this.idcheque = Convert.ToInt32(row.Cells[1].Value);
                    }
                }
                if (chave)
                {
                    DialogResult Opcao;
                    Opcao = MessageBox.Show("Realmente deseja atualizar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcao == DialogResult.OK)
                    {
                        resp = NCheque.Atualizar_Status_Devolvido(this.idcheque);

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Atualização efetuada com sucesso.");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.Mostrar();
                    }
                }
                else
                {
                    this.MensagemErro("Selecione um cheque");
                }
                this.CHK_Selecionar.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void FRM_Controle_Cheque_FormClosed(object sender, FormClosedEventArgs e)
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
                    FRM_Ver_Venda_Origem_Cheque frm = FRM_Ver_Venda_Origem_Cheque.GetInstancia();
                    frm.idvenda = IdVenda;
                    frm.ShowDialog();
                }
                else
                {
                    this.MensagemErro("Selecione um registro.");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void BTN_Compensar_Click(object sender, EventArgs e)
        {
            string resp = "";

            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja compensar este(s) cheque(s)?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    bool chave = false;
                    foreach (DataGridViewRow row in DGV_Dados.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            // Liberando permissão para prosseguir
                            chave = true;

                            // Obtendo dados
                            this.idcheque = Convert.ToInt32(row.Cells[1].Value);
                            this.valor_cheque += Convert.ToDecimal(row.Cells[8].Value);
                            this.num_doc_livro_caixa += "V" + row.Cells[2].Value.ToString() + " - P" + row.Cells[7].Value.ToString() + ", ";

                            // Deletar cheque compensados
                            resp = NCheque.Excluir(this.idcheque);
                        }
                    }
                    if (chave)
                    {
                        // inserindo no livro caixa
                        DateTime Data = DateTime.Now;
                        resp = NLivro_Caixa.Inserir(Data, "COMPENSAÇÃO DE CHEQUE", this.num_doc_livro_caixa, this.valor_cheque, Convert.ToDecimal("0,00"));

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Compensação realizada com sucesso.");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.Mostrar();
                    }
                    else
                    {
                        this.MensagemErro("Selecione um registro.");
                    }
                    this.CHK_Selecionar.Checked = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            string resp = "";

            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja excluir este(s) cheque(s)?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    bool chave = false;
                    foreach (DataGridViewRow row in DGV_Dados.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            // Liberando permissão para prosseguir
                            chave = true;

                            // Obtendo dados
                            this.idcheque = Convert.ToInt32(row.Cells[1].Value);
                        }
                    }
                    if (chave)
                    {
                        // Deletar cheque
                        resp = NCheque.Excluir(this.idcheque);

                        if (resp.Equals("Ok"))
                        {
                            this.MensagemOk("Exclusão realizada com sucesso.");
                        }
                        else
                        {
                            this.MensagemErro(resp);
                        }

                        this.Mostrar();
                    }
                    else
                    {
                        this.MensagemErro("Selecione um registro.");
                    }
                }
                this.CHK_Selecionar.Checked = false;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.StackTrace);
            }
        }
    }
}
