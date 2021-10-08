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
    public partial class FRM_Fornecedor : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Fornecedor _Instancia;

        public static FRM_Fornecedor GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Fornecedor();
            }
            return _Instancia;
        }

        public FRM_Fornecedor()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtEmpresa, "Insira o nome da Empresa");
            this.ttMensagem.SetToolTip(this.txtContato, "Insira o nome do Contato");
            this.ttMensagem.SetToolTip(this.cbSetor_Comercial, "Selecione um Setor Comercial");
            this.ttMensagem.SetToolTip(this.cbDoc_Principal, "Selecione um Tipo de Documento");
            this.ttMensagem.SetToolTip(this.txtNum_Doc_Principal, "InForme o Número do Documento Principal");
            this.ttMensagem.SetToolTip(this.cbDoc_Secundario, "Selecione um Tipo de Documento");
            this.ttMensagem.SetToolTip(this.txtNum_Doc_Secundario, "InForme o Número do Documento Secundário");
            this.ttMensagem.SetToolTip(this.txtEndereco, "Informe o Endereço do Fornecedor");
            this.ttMensagem.SetToolTip(this.txtBairro, "Informe o Bairro");
            this.ttMensagem.SetToolTip(this.txtCidade, "Informe a Cidade");
            this.ttMensagem.SetToolTip(this.txtCep, "Informe o Cep");
            this.ttMensagem.SetToolTip(this.cbEstado, "Selecione o Estado");
            this.ttMensagem.SetToolTip(this.txtTelefone, "Informe o Telefone");
            this.ttMensagem.SetToolTip(this.txtTelefone, "Informe o Celular/WhatsApp");
            this.ttMensagem.SetToolTip(this.txtEmail, "Informe o Email");
            this.ttMensagem.SetToolTip(this.txtUrl, "Informe o Site");
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
            this.txtId.Text = string.Empty;
            this.txtEmpresa.Text = string.Empty;
            this.txtContato.Text = string.Empty;
            this.txtNum_Doc_Principal.Text = string.Empty;
            this.txtNum_Doc_Secundario.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtBairro.Text = string.Empty;
            this.txtCidade.Text = string.Empty;
            this.txtCep.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtWhatsapp.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtUrl.Text = string.Empty;
        }


        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.txtId.ReadOnly = !valor;
            this.txtEmpresa.ReadOnly = !valor;
            this.txtContato.ReadOnly = !valor;
            this.cbDoc_Principal.Enabled = valor;
            this.txtNum_Doc_Principal.ReadOnly = !valor;
            this.cbDoc_Secundario.Enabled = valor;
            this.txtNum_Doc_Secundario.ReadOnly = !valor;
            this.txtEndereco.ReadOnly = !valor;
            this.txtBairro.ReadOnly = !valor;
            this.txtCidade.ReadOnly = !valor;
            this.txtCep.ReadOnly = !valor;
            this.cbEstado.Enabled = valor;
            this.txtTelefone.ReadOnly = !valor;
            this.txtWhatsapp.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtUrl.ReadOnly = !valor;
            this.cbSetor_Comercial.Enabled = valor;

            if (valor)
            {
                this.txtEmpresa.BackColor = Color.White;
                this.txtContato.BackColor = Color.White;
                this.cbSetor_Comercial.BackColor = Color.White;
                this.cbDoc_Principal.BackColor = Color.White;
                this.txtNum_Doc_Principal.BackColor = Color.White;
                this.cbDoc_Secundario.BackColor = Color.White;
                this.txtNum_Doc_Secundario.BackColor = Color.White;
                this.txtEndereco.BackColor = Color.White;
                this.txtBairro.BackColor = Color.White;
                this.txtCidade.BackColor = Color.White;
                this.txtCep.BackColor = Color.White;
                this.cbEstado.BackColor = Color.White;
                this.txtTelefone.BackColor = Color.White;
            }
            else
            {
                this.txtEmpresa.BackColor = Color.WhiteSmoke;
                this.txtContato.BackColor = Color.WhiteSmoke;
                this.cbSetor_Comercial.BackColor = Color.WhiteSmoke;
                this.cbDoc_Principal.BackColor = Color.WhiteSmoke;
                this.txtNum_Doc_Principal.BackColor = Color.WhiteSmoke;
                this.cbDoc_Secundario.BackColor = Color.WhiteSmoke;
                this.txtNum_Doc_Secundario.BackColor = Color.WhiteSmoke;
                this.txtEndereco.BackColor = Color.WhiteSmoke;
                this.txtBairro.BackColor = Color.WhiteSmoke;
                this.txtCidade.BackColor = Color.WhiteSmoke;
                this.txtCep.BackColor = Color.WhiteSmoke;
                this.cbEstado.BackColor = Color.WhiteSmoke;
                this.txtTelefone.BackColor = Color.WhiteSmoke;
            }
        }


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }


        //Metodo ocultar colunas do Grid
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;
            this.dataLista.Columns[12].Visible = false;
            this.dataLista.Columns[15].Visible = false;
            this.dataLista.Columns[16].Visible = false;
            this.dataLista.Columns[17].Visible = false;
        }


        //Alterar nome exibido no data lista    
        private void Exibicao_DataLista()
        {
            this.dataLista.Columns[2].HeaderText = "Empresa";
            this.dataLista.Columns[3].HeaderText = "Contato";
            this.dataLista.Columns[4].HeaderText = "Setor Comercial";
            this.dataLista.Columns[5].HeaderText = "Doc. Principal";
            this.dataLista.Columns[6].HeaderText = "Nº do Doc. Principal";
            this.dataLista.Columns[7].HeaderText = "Doc. Secundário";
            this.dataLista.Columns[8].HeaderText = "Nº do Doc. Secundário";
            this.dataLista.Columns[9].HeaderText = "Endereço";
            this.dataLista.Columns[10].HeaderText = "Bairro";
            this.dataLista.Columns[11].HeaderText = "Cidade";
            this.dataLista.Columns[13].HeaderText = "UF";
            this.dataLista.Columns[14].HeaderText = "Telefone";
        }

        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.dataLista.DataSource = NFornecedor.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar pela Empresa
        private void BuscarEmpresa()
        {
            this.dataLista.DataSource = NFornecedor.BuscarEmpresa(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nome da Empresa";
        }


        // Buscar pelo Nº Doc Principal
        private void BuscarDocPrincipal()
        {
            this.dataLista.DataSource = NFornecedor.BuscarDocPrincipal(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nº Doc. Principal";
        }


        // Buscar pelo Nº Doc Secundario
        private void BuscarDocSecundario()
        {
            this.dataLista.DataSource = NFornecedor.BuscarDocSecundario(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nº Doc. Secundário";
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eEditar)
            {
                this.txtEmpresa.BackColor = Color.LemonChiffon;
                this.txtContato.BackColor = Color.LemonChiffon;
                this.cbSetor_Comercial.BackColor = Color.LemonChiffon;
                this.cbDoc_Principal.BackColor = Color.LemonChiffon;
                this.txtNum_Doc_Principal.BackColor = Color.LemonChiffon;
                this.cbDoc_Secundario.BackColor = Color.LemonChiffon;
                this.txtNum_Doc_Secundario.BackColor = Color.LemonChiffon;
                this.txtEndereco.BackColor = Color.LemonChiffon;
                this.txtBairro.BackColor = Color.LemonChiffon;
                this.txtCidade.BackColor = Color.LemonChiffon;
                this.txtCep.BackColor = Color.LemonChiffon;
                this.cbEstado.BackColor = Color.LemonChiffon;
                this.txtTelefone.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.txtEmpresa.BackColor = Color.WhiteSmoke;
                this.txtContato.BackColor = Color.WhiteSmoke;
                this.cbSetor_Comercial.BackColor = Color.WhiteSmoke;
                this.cbDoc_Principal.BackColor = Color.WhiteSmoke;
                this.txtNum_Doc_Principal.BackColor = Color.WhiteSmoke;
                this.cbDoc_Secundario.BackColor = Color.WhiteSmoke;
                this.txtNum_Doc_Secundario.BackColor = Color.WhiteSmoke;
                this.txtEndereco.BackColor = Color.WhiteSmoke;
                this.txtBairro.BackColor = Color.WhiteSmoke;
                this.txtCidade.BackColor = Color.WhiteSmoke;
                this.txtCep.BackColor = Color.WhiteSmoke;
                this.cbEstado.BackColor = Color.WhiteSmoke;
                this.txtTelefone.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Fornecedor_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.cbBuscar.SelectedIndex = 0;
            this.cbSetor_Comercial.SelectedIndex = 0;
            this.cbDoc_Principal.SelectedIndex = 0;
            this.cbDoc_Secundario.SelectedIndex = 0;
            this.cbEstado.SelectedIndex = 0;
            this.Exibicao_DataLista();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals(""))
            {
                this.btnBuscar.Enabled = false;
            }
            else
            {
                this.btnBuscar.Enabled = true;
            }
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();

            if (this.cbBuscar.Text.Equals("Nº Doc. Principal - CNPJ"))
            {
                this.txtBuscar.MaxLength = 18;
            }
            else if (this.cbBuscar.Text.Equals("Nº Doc. Principal - CPF"))
            {
                this.txtBuscar.MaxLength = 14;
            }
            else
            {
                this.txtBuscar.MaxLength = 32767;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtEmpresa.Focus();
            this.txtId.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtEmpresa.Text == string.Empty || this.txtContato.Text == string.Empty || this.cbSetor_Comercial.Text == string.Empty || this.cbDoc_Principal.Text == string.Empty || this.txtNum_Doc_Principal.Text == string.Empty || this.cbDoc_Secundario.Text == string.Empty || this.txtNum_Doc_Secundario.Text == string.Empty || this.txtEndereco.Text == string.Empty || this.txtBairro.Text == string.Empty || this.txtCidade.Text == string.Empty || this.txtCep.Text == string.Empty || this.cbEstado.Text == string.Empty || this.txtTelefone.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NFornecedor.Inserir(this.txtEmpresa.Text.Trim().ToUpper(), this.txtContato.Text.ToUpper(), this.cbSetor_Comercial.Text, this.cbDoc_Principal.Text, this.txtNum_Doc_Principal.Text.Trim(), this.cbDoc_Secundario.Text, this.txtNum_Doc_Secundario.Text.Trim(), this.txtEndereco.Text.Trim().ToUpper(), this.txtBairro.Text.ToUpper(), this.txtCidade.Text.ToUpper(), this.txtCep.Text, this.cbEstado.Text, this.txtTelefone.Text, this.txtWhatsapp.Text, this.txtEmail.Text, this.txtUrl.Text);
                    }
                    else
                    {
                        resp = NFornecedor.Editar(Convert.ToInt32(this.txtId.Text), this.txtEmpresa.Text.Trim().ToUpper(), this.txtContato.Text.ToUpper(), this.cbSetor_Comercial.Text, this.cbDoc_Principal.Text, this.txtNum_Doc_Principal.Text.Trim(), this.cbDoc_Secundario.Text, this.txtNum_Doc_Secundario.Text.Trim(), this.txtEndereco.Text.Trim().ToUpper(), this.txtBairro.Text.ToUpper(), this.txtCidade.Text.ToUpper(), this.txtCep.Text, this.cbEstado.Text, this.txtTelefone.Text, this.txtWhatsapp.Text, this.txtEmail.Text, this.txtUrl.Text);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;
                this.btnDeletar.Enabled = true;
            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
                this.btnDeletar.Enabled = false;
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NFornecedor.Excluir(Convert.ToInt32(Codigo));

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
                    this.chkDeletar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
        }

        private void FRM_Fornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idfornecedor"].Value);
            this.txtEmpresa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["empresa"].Value);
            this.txtContato.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["contato"].Value);
            this.cbSetor_Comercial.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["setor_comercial"].Value);
            this.cbDoc_Principal.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["doc_principal"].Value);
            this.txtNum_Doc_Principal.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_doc_principal"].Value);
            this.cbDoc_Secundario.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["doc_secundario"].Value);
            this.txtNum_Doc_Secundario.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_doc_secundario"].Value);
            this.txtEndereco.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["endereco"].Value);
            this.txtBairro.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["bairro"].Value);
            this.txtCidade.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cidade"].Value);
            this.txtCep.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cep"].Value);
            this.cbEstado.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["uf"].Value);
            this.txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["telefone"].Value);
            this.txtWhatsapp.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["whatsapp"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["email"].Value);
            this.txtUrl.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["url"].Value);

            this.btnNovo.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.btnEditar.Enabled = true;

            this.tabControl1.SelectedIndex = 1;
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Fornecedores frm = FRM_Tipo_Relatorio_Fornecedores.GetInstancia();
            frm.Show();
        }

        private void cbDoc_Principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNum_Doc_Principal.Text = string.Empty;
            this.txtNum_Doc_Principal.Focus();

            // DOC. PRINCIPAL
            if (this.cbDoc_Principal.Text.Equals("CNPJ"))
            {
                this.txtNum_Doc_Principal.MaxLength = 18;
            }
            else
            {
                this.txtNum_Doc_Principal.MaxLength = 14;
            }
        }

        private void txtNum_Doc_Principal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (this.cbDoc_Principal.Text.Equals("CNPJ"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtNum_Doc_Principal.TextLength)
                    {
                        case 0:
                            this.txtNum_Doc_Principal.Text = "";
                            break;
                        case 2:
                            this.txtNum_Doc_Principal.Text += ".";
                            this.txtNum_Doc_Principal.SelectionStart = 4;
                            break;
                        case 6:
                            this.txtNum_Doc_Principal.Text += ".";
                            this.txtNum_Doc_Principal.SelectionStart = 8;
                            break;
                        case 10:
                            this.txtNum_Doc_Principal.Text += "/";
                            this.txtNum_Doc_Principal.SelectionStart = 12;
                            break;
                        case 15:
                            this.txtNum_Doc_Principal.Text += "-";
                            this.txtNum_Doc_Principal.SelectionStart = 17;
                            break;
                    }
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtNum_Doc_Principal.TextLength)
                    {
                        case 0:
                            this.txtNum_Doc_Principal.Text = "";
                            break;
                        case 3:
                            this.txtNum_Doc_Principal.Text += ".";
                            this.txtNum_Doc_Principal.SelectionStart = 5;
                            break;
                        case 7:
                            this.txtNum_Doc_Principal.Text += ".";
                            this.txtNum_Doc_Principal.SelectionStart = 9;
                            break;
                        case 11:
                            this.txtNum_Doc_Principal.Text += "-";
                            this.txtNum_Doc_Principal.SelectionStart = 13;
                            break;
                    }
                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCep.TextLength)
                {
                    case 0:
                        this.txtCep.Text = "";
                        break;
                    case 2:
                        this.txtCep.Text += ".";
                        this.txtCep.SelectionStart = 4;
                        break;
                    case 6:
                        this.txtCep.Text += "-";
                        this.txtCep.SelectionStart = 8;
                        break;
                }
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (this.cbEstado.Text.Equals("MG"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtTelefone.TextLength)
                    {
                        case 0:
                            this.txtTelefone.Text = "(31) ";
                            this.txtTelefone.SelectionStart = 5;
                            break;
                        case 9:
                            this.txtTelefone.Text += " - ";
                            this.txtTelefone.SelectionStart = 12;
                            break;
                    }
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtTelefone.TextLength)
                    {
                        case 0:
                            this.txtTelefone.Text = "(  ) ";
                            this.txtTelefone.SelectionStart = 5;
                            break;
                        case 9:
                            this.txtTelefone.Text += " - ";
                            this.txtTelefone.SelectionStart = 12;
                            break;
                    }
                }
            }
        }

        private void txtWhatsapp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (this.cbEstado.Text.Equals("MG"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtWhatsapp.TextLength)
                    {
                        case 0:
                            this.txtWhatsapp.Text = "(31) ";
                            this.txtWhatsapp.SelectionStart = 5;
                            break;
                        case 10:
                            this.txtWhatsapp.Text += " - ";
                            this.txtWhatsapp.SelectionStart = 13;
                            break;
                    }
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtWhatsapp.TextLength)
                    {
                        case 0:
                            this.txtWhatsapp.Text = "(  ) ";
                            this.txtWhatsapp.SelectionStart = 5;
                            break;
                        case 10:
                            this.txtWhatsapp.Text += " - ";
                            this.txtWhatsapp.SelectionStart = 13;
                            break;
                    }
                }
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTelefone.Text = string.Empty;
            this.txtTelefone.Focus();

            this.txtWhatsapp.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Empresa"))
            {
                this.BuscarEmpresa();
            }
            else if (cbBuscar.Text.Equals("Nº Doc. Principal - CNPJ") || cbBuscar.Text.Equals("Nº Doc. Principal - CPF"))
            {
                this.BuscarDocPrincipal();
            }
            else
            {
                this.BuscarDocSecundario();
            }
            this.txtBuscar.Text = string.Empty;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbBuscar.Text.Equals("Nº Doc. Principal - CNPJ"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtBuscar.TextLength)
                    {
                        case 0:
                            this.txtBuscar.Text = "";
                            break;
                        case 2:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 4;
                            break;
                        case 6:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 8;
                            break;
                        case 10:
                            this.txtBuscar.Text += "/";
                            this.txtBuscar.SelectionStart = 12;
                            break;
                        case 15:
                            this.txtBuscar.Text += "-";
                            this.txtBuscar.SelectionStart = 17;
                            break;
                    }
                }
            }
            else if (cbBuscar.Text.Equals("Nº Doc. Principal - CPF"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtBuscar.TextLength)
                    {
                        case 0:
                            this.txtBuscar.Text = "";
                            break;
                        case 3:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 5;
                            break;
                        case 7:
                            this.txtBuscar.Text += ".";
                            this.txtBuscar.SelectionStart = 9;
                            break;
                        case 11:
                            this.txtBuscar.Text += "-";
                            this.txtBuscar.SelectionStart = 13;
                            break;
                    }
                }
            }
        }

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void LB_Modo_Exibicao_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Modo_Exibicao.Text.Equals("Mostrar Tudo"))
            {
                this.BTN_Mostrar_Tudo.Visible = false;
            }
            else
            {
                this.BTN_Mostrar_Tudo.Visible = true;
            }
        }
    }
}
