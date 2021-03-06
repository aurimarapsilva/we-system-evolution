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
    public partial class FRM_Categoria : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Categoria _Instancia;

        public static FRM_Categoria GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Categoria();
            }
            return _Instancia;
        }

        public FRM_Categoria()
        {
            InitializeComponent();
            this.TT_Mensagem.SetToolTip(this.TXB_Nome, "Insira o nome da Categoria");
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


        //Limpar campos
        private void Limpar()
        {
            this.TXB_Nome.Text = string.Empty;
            this.TXB_Id.Text = string.Empty;
            this.TXB_Descricao.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Nome.ReadOnly = !valor;
            this.TXB_Id.ReadOnly = !valor;
            this.TXB_Descricao.ReadOnly = !valor;

            if (valor)
            {
                this.TXB_Nome.BackColor = Color.White;
            }
            else
            {
                this.TXB_Nome.BackColor = Color.WhiteSmoke;
            }
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }

        //Metodo ocultar colunas do Grid
        private void ocultarColunas()
        {
            this.DataLista.Columns[0].Visible = false;
            this.DataLista.Columns[1].Visible = false;
        }

        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.DataLista.DataSource = NCategoria.Mostrar();
            this.ocultarColunas();
            LB_Total.Text = "Total de registros: " + Convert.ToString(DataLista.Rows.Count);
        }

        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.DataLista.DataSource = NCategoria.BuscarNome(this.TXB_Buscar.Text);
            this.ocultarColunas();
            LB_Total.Text = "Total de registros: " + Convert.ToString(DataLista.Rows.Count);
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eEditar)
            {
                this.TXB_Nome.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Nome.BackColor = Color.WhiteSmoke;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRM_Categoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
        }

        private void TXB_Buscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.TXB_Nome.Focus();
            this.TXB_Id.Enabled = false;
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Nome.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NCategoria.Inserir(this.TXB_Nome.Text.Trim().ToUpper(), this.TXB_Descricao.Text.Trim());
                    }
                    else
                    {
                        resp = NCategoria.Editar(Convert.ToInt32(this.TXB_Id.Text),
                            this.TXB_Nome.Text.Trim().ToUpper(),
                            this.TXB_Descricao.Text.Trim());
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                        else
                        {
                            this.MensagemOk("Registro editado com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                    this.Alerta_Campos_Obrigatorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void CHKB_Deletar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKB_Deletar.Checked)
            {
                this.DataLista.Columns[0].Visible = true;
                this.BTN_Deletar.Enabled = true;
            }
            else
            {
                this.DataLista.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;
            }
        }

        private void DataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell CHKDeletar = (DataGridViewCheckBoxCell)DataLista.Rows[e.RowIndex].Cells["Deletar"];
                CHKDeletar.Value = !Convert.ToBoolean(CHKDeletar.Value);
            }
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in DataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NCategoria.Excluir(Convert.ToInt32(Codigo));

                            if (Resp.Equals("Ok"))
                            {
                                this.MensagemOk("A exclusão foi realizada com sucesso");
                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.CHKB_Deletar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Categoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();

            FRM_Produto frm = FRM_Produto.GetInstancia();
            frm.ComboCategoria();
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
        }

        private void DataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TXB_Id.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["idcategoria"].Value);
            this.TXB_Nome.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["nome"].Value);
            this.TXB_Descricao.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["descricao"].Value);
            this.tabControl1.SelectedIndex = 1;

            this.BTN_Editar.Enabled = true;
            this.BTN_Novo.Enabled = false;
            this.BTN_Cancelar.Enabled = true;
        }
    }
}
