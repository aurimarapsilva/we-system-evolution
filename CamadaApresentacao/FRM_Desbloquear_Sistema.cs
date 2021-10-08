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
    public partial class FRM_Desbloquear_Sistema : Form
    {
        private DataTable TBL_Dados_Autenticacao;
        private bool Bloquear = false;
        public DateTime data_atual;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Desbloquear_Sistema _Instancia;

        public static FRM_Desbloquear_Sistema GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Desbloquear_Sistema();
            }
            return _Instancia;
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


        //Mostrar mensagem de Erro
        private void MensagemPergunta(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        private void Mostrar_Mensalidades_Vencidas()
        {
            // Capturando Dados Necessarios
            this.DGV_Mensalidades.DataSource = NAutenticacao.Mostrar_Autenticacao(this.data_atual.ToString("dd/MM/yyyy"));

            // Ocultar Colunas
            this.DGV_Mensalidades.Columns[1].Visible = false;
            this.DGV_Mensalidades.Columns[3].Visible = false;
            this.DGV_Mensalidades.Columns[4].Visible = false;

            // Nome das Colunas
            this.DGV_Mensalidades.Columns[2].HeaderText = "Mensalidade";
        }

        private void Status_Autenticação()
        {
            string resp = "";
            if (Bloquear)
            {
                // Alerta de Bloqueio
                MessageBox.Show("                       >>>>> SISTEMA BLOQUEADO <<<<< \n\nPara mais informações ligue para WE Automação: (31) 98315 1472 | 98581 8801", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Alerta de Desbloqueio
                MessageBox.Show(" >>>>> SISTEMA DESBLOQUEADO <<<<< \n\nO sistema será fechado para aplicar as alteações.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alterando Status da licença para ATIVO
                resp = NRemetente.Atualizar_Status_Licença_Ativo();
            }
        }
        
               
        public void Autenticacao()
        {
            this.TBL_Dados_Autenticacao = NAutenticacao.Mostrar_Autenticacao(this.data_atual.ToString("dd/MM/yyyy"));

            foreach (DataRow row in TBL_Dados_Autenticacao.Rows)
            {
                string resp = "";

                // MENSALIDADE 1
                if (row[1].ToString().Equals("1"))
                {
                    if (row[3].ToString().Equals("DR70N3HVJ62GCMU"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 2
                if (row[1].ToString().Equals("2"))
                {
                    if (row[3].ToString().Equals("5XL1FTH9BP40E8A"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 3
                if (row[1].ToString().Equals("3"))
                {
                    if (row[3].ToString().Equals("F6T9NB2PJXE8MAI"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 4
                if (row[1].ToString().Equals("4"))
                {
                    if (row[3].ToString().Equals("P4IXLET8A2KS1OW"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 5
                if (row[1].ToString().Equals("5"))
                {
                    if (row[3].ToString().Equals("QE5SM1H9WPDL8V4"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 6
                if (row[1].ToString().Equals("6"))
                {
                    if (row[3].ToString().Equals("1O3HWKDS7JR0NV2"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 7
                if (row[1].ToString().Equals("7"))
                {
                    if (row[3].ToString().Equals("CRF6N2VJXEMUIQ5"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 8
                if (row[1].ToString().Equals("8"))
                {
                    if (row[3].ToString().Equals("GVC4R6K0MU3QY9B"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 9
                if (row[1].ToString().Equals("9"))
                {
                    if (row[3].ToString().Equals("9B2P4JXLET8AIKS"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 10
                if (row[1].ToString().Equals("10"))
                {
                    if (row[3].ToString().Equals("TH8AP4XL0EGOWKS"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 11
                if (row[1].ToString().Equals("11"))
                {
                    if (row[3].ToString().Equals("RF6N2VJXCEMUIQ1"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }


                // MENSALIDADE 12
                if (row[1].ToString().Equals("12"))
                {
                    if (row[3].ToString().Equals("MA1I9WQE5SDLHP4"))
                    {
                        // Desbloquar
                        this.Bloquear = false;

                        // Excluir mensalidade autenticada
                        int id = Convert.ToInt32(row[0]);
                        resp = NAutenticacao.Excluir(id);
                    }
                    else
                    {
                        this.Bloquear = true;
                    }
                }
            }

            this.Status_Autenticação();
        }


        public FRM_Desbloquear_Sistema()
        {
            InitializeComponent();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Desbloquear_Sistema_Load(object sender, EventArgs e)
        {
            this.Mostrar_Mensalidades_Vencidas();
        }

        private void BTN_Confirmar_Click(object sender, EventArgs e)
        {
            string resp = "";
            bool chave = false;

            foreach (DataGridViewRow row in DGV_Mensalidades.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    chave = true;
                }
            }
            if (chave)
            {
                if (this.TXB_Codigo_Autenticacao.Text == string.Empty)
                {
                    this.MensagemErro("Insira o código de autenticação");
                }
                else
                {
                    if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("1"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("DR70N3HVJ62GCMU"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("2"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("5XL1FTH9BP40E8A"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("3"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("F6T9NB2PJXE8MAI"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("4"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("P4IXLET8A2KS1OW"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("5"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("QE5SM1H9WPDL8V4"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("6"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("1O3HWKDS7JR0NV2"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("7"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("CRF6N2VJXEMUIQ5"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("8"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("GVC4R6K0MU3QY9B"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("9"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("9B2P4JXLET8AIKS"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("10"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("TH8AP4XL0EGOWKS"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("11"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("RF6N2VJXCEMUIQ1"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                    else if (this.DGV_Mensalidades.CurrentRow.Cells[2].Value.ToString().Equals("12"))
                    {
                        if (this.TXB_Codigo_Autenticacao.Text.Trim().Equals("MA1I9WQE5SDLHP4"))
                        {
                            // Inserindo código de autenticação
                            int id = Convert.ToInt32(this.DGV_Mensalidades.CurrentRow.Cells[1].Value);
                            resp = NAutenticacao.Editar(id, this.TXB_Codigo_Autenticacao.Text);

                            // Excluir mensalidade autenticada do grid
                            int index = DGV_Mensalidades.CurrentRow.Index;
                            DataGridViewRow row = DGV_Mensalidades.Rows[index];
                            DGV_Mensalidades.Rows.Remove(row);

                            // Executar Autenticação
                            this.Autenticacao();

                            if (this.DGV_Mensalidades.Rows.Count > 0)
                            {
                                DialogResult Opcao;
                                Opcao = MessageBox.Show("Deseja inserir o código de autenticação das demais mensalidades agora?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (Opcao == DialogResult.Yes)
                                {
                                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                                    this.CHK_Selecionar.Checked = false;
                                }
                                else
                                {
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            this.MensagemErro("Código de autenticação inválido");
                            this.TXB_Codigo_Autenticacao.Text = string.Empty;
                            this.TXB_Codigo_Autenticacao.Focus();
                        }
                    }
                }
            }
            else
            {
                this.MensagemErro("Selecione uma mensalidade.");
            }
        }

        private void DGV_Mensalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Mensalidades.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Mensalidades.Rows[e.RowIndex].Cells["Select"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
            {
                this.DGV_Mensalidades.Columns[0].Visible = true;
            }
            else
            {
                this.DGV_Mensalidades.Columns[0].Visible = false;

                foreach (DataGridViewRow _row in this.DGV_Mensalidades.Rows)
                {
                    (_row.Cells[0] as DataGridViewCheckBoxCell).Value = false;
                }
            }
        }

        private void FRM_Desbloquear_Sistema_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }
    }
}
