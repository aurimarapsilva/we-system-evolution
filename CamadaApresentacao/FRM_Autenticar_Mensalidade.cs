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
    public partial class FRM_Autenticar_Mensalidade : Form
    {
        private DataTable TBL_Dados_Autenticacao;
        private bool Bloquear = false;
        public DateTime DATA_ATUAL;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Autenticar_Mensalidade _Instancia;

        public static FRM_Autenticar_Mensalidade GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Autenticar_Mensalidade();
            }
            return _Instancia;
        }

        public FRM_Autenticar_Mensalidade()
        {
            InitializeComponent();
        }


        // Metodo de limapr campos
        private void Limpar_Campos()
        {
            this.TXB_Codigo_Autenticacao.Text = string.Empty;
        }


        private void Mostrar_Mensalidades()
        {
            // Capturando Dados Necessarios
            this.DGV_Mensalidades.DataSource = NAutenticacao.Mostrar_Tudo();

            // Ocultar Colunas
            this.DGV_Mensalidades.Columns[1].Visible = false;
            this.DGV_Mensalidades.Columns[3].Visible = false;
            this.DGV_Mensalidades.Columns[4].Visible = false;

            // Nome das Colunas
            this.DGV_Mensalidades.Columns[2].HeaderText = "Mensalidade";
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
        private void MensagemAviso(string mensagem)
        {
            MessageBox.Show(mensagem, "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (this.DGV_Mensalidades.CurrentRow.Cells[4].Value.ToString().Equals(""))
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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

                                this.Limpar_Campos();

                                this.MensagemOk("Mensalidade autenticada com sucesso.");
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
                    this.MensagemAviso("Esta mensalidade já foi autenticada");
                    this.TXB_Codigo_Autenticacao.Text = string.Empty;
                    this.TXB_Codigo_Autenticacao.Focus();
                }
            }
            else
            {
                this.MensagemErro("Selecione uma mensalidade.");
            }
            this.CHK_Selecionar.Checked = false;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Limpar_Campos();
            this.Close();
        }

        private void FRM_Autenticar_Mensalidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FRM_Autenticar_Mensalidade_Load(object sender, EventArgs e)
        {
            this.Mostrar_Mensalidades();
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

        private void DGV_Mensalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV_Mensalidades.Columns["Select"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DGV_Mensalidades.Rows[e.RowIndex].Cells["Select"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }
    }
}
