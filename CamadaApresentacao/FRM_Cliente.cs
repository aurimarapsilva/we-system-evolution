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
    public partial class FRM_Cliente : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Cliente _Instancia;

        public static FRM_Cliente GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Cliente();
            }
            return _Instancia;
        }


        public FRM_Cliente()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.txtNome_Completo, "Informe o nome completo");
            this.ttMensagem.SetToolTip(this.pxFoto, "Insira uma foto");
            this.ttMensagem.SetToolTip(this.cbSexo, "Selecione o sexo");
            this.ttMensagem.SetToolTip(this.dtData_Nasc, "InForme a data de nascimento");
            this.ttMensagem.SetToolTip(this.txtRg, "Informe o número do RG");
            this.ttMensagem.SetToolTip(this.txtCpf, "Informe o número do CPF");
            this.ttMensagem.SetToolTip(this.txtEndereco, "Informe o endereço");
            this.ttMensagem.SetToolTip(this.txtBairro, "Informe o bairro");
            this.ttMensagem.SetToolTip(this.txtCidade, "Informe a cidade");
            this.ttMensagem.SetToolTip(this.txtCep, "Informe o cep");
            this.ttMensagem.SetToolTip(this.cbEstado, "Selecione o estado");
            this.ttMensagem.SetToolTip(this.txtTelefone, "Informe o Nº do telefone fixo");
            this.ttMensagem.SetToolTip(this.txtCelular, "Informe o Nº do celular");
            this.ttMensagem.SetToolTip(this.txtEmail, "Informe o Email");
            this.ttMensagem.SetToolTip(this.txtLimite_Credito, "Informe o limite de crédito");
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
            this.txtNome_Completo.Text = string.Empty;
            this.pxFoto.Image = global::CamadaApresentacao.Properties.Resources.Fundo_White;
            this.txtRg.Text = string.Empty;
            this.txtCpf.Text = string.Empty;
            this.dtData_Nasc.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtBairro.Text = string.Empty;
            this.txtCidade.Text = string.Empty;
            this.txtCep.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.txtCelular.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtLimite_Credito.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.txtId.ReadOnly = !valor;
            this.txtNome_Completo.ReadOnly = !valor;
            this.cbSexo.Enabled = valor;
            this.dtData_Nasc.Enabled = valor;
            this.txtRg.ReadOnly = !valor;
            this.txtCpf.ReadOnly = !valor;
            this.txtEndereco.ReadOnly = !valor;
            this.txtBairro.ReadOnly = !valor;
            this.txtCidade.ReadOnly = !valor;
            this.txtCep.ReadOnly = !valor;
            this.cbEstado.Enabled = valor;
            this.txtTelefone.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtLimite_Credito.ReadOnly = !valor;

            if (valor)
            {
                this.txtNome_Completo.BackColor = Color.White;
                this.cbSexo.BackColor = Color.White;
                this.txtEndereco.BackColor = Color.White;
                this.txtBairro.BackColor = Color.White;
                this.txtCidade.BackColor = Color.White;
                this.txtCep.BackColor = Color.White;
                this.cbEstado.BackColor = Color.White;
                this.txtCelular.BackColor = Color.White;
                this.txtLimite_Credito.BackColor = Color.White;
            }
            else
            {
                this.txtNome_Completo.BackColor = Color.WhiteSmoke;
                this.cbSexo.BackColor = Color.WhiteSmoke;
                this.txtEndereco.BackColor = Color.WhiteSmoke;
                this.txtBairro.BackColor = Color.WhiteSmoke;
                this.txtCidade.BackColor = Color.WhiteSmoke;
                this.txtCep.BackColor = Color.WhiteSmoke;
                this.cbEstado.BackColor = Color.WhiteSmoke;
                this.txtCelular.BackColor = Color.WhiteSmoke;
                this.txtLimite_Credito.BackColor = Color.WhiteSmoke;
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
            this.dataLista.Columns[3].Visible = false;
            this.dataLista.Columns[4].Visible = false;
            this.dataLista.Columns[11].Visible = false;
            this.dataLista.Columns[12].Visible = false;
            this.dataLista.Columns[13].Visible = false;
            this.dataLista.Columns[15].Visible = false;
        }

        //Alterar nome exibido no data lista    
        private void Exibicao_DataLista()
        {
            this.dataLista.Columns[2].HeaderText = "Nome Completo";
            this.dataLista.Columns[5].HeaderText = "Data de Nascimento";
            this.dataLista.Columns[6].HeaderText = "RG";
            this.dataLista.Columns[7].HeaderText = "CPF";
            this.dataLista.Columns[8].HeaderText = "Endereço";
            this.dataLista.Columns[9].HeaderText = "Bairro";
            this.dataLista.Columns[10].HeaderText = "Cidade";
            this.dataLista.Columns[14].HeaderText = "Celular";
            this.dataLista.Columns[16].HeaderText = "Limite de Crédito";
        }


        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.dataLista.DataSource = NCliente.Mostrar();
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar pelo Nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCliente.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nome";
        }


        // Buscar pelo RG
        private void BuscarRG()
        {
            this.dataLista.DataSource = NCliente.BuscarRG(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "RG";
        }


        // Buscar pelo CPF
        private void BuscarCPF()
        {
            this.dataLista.DataSource = NCliente.BuscarCPF(this.txtBuscar.Text);
            this.ocultarColunas();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "CPF";
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eEditar)
            {
                this.txtNome_Completo.BackColor = Color.LemonChiffon;
                this.cbSexo.BackColor = Color.LemonChiffon;
                this.txtEndereco.BackColor = Color.LemonChiffon;
                this.txtBairro.BackColor = Color.LemonChiffon;
                this.txtCidade.BackColor = Color.LemonChiffon;
                this.txtCep.BackColor = Color.LemonChiffon;
                this.cbEstado.BackColor = Color.LemonChiffon;
                this.txtCelular.BackColor = Color.LemonChiffon;
                this.txtLimite_Credito.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.txtNome_Completo.BackColor = Color.WhiteSmoke;
                this.cbSexo.BackColor = Color.WhiteSmoke;
                this.txtEndereco.BackColor = Color.WhiteSmoke;
                this.txtBairro.BackColor = Color.WhiteSmoke;
                this.txtCidade.BackColor = Color.WhiteSmoke;
                this.txtCep.BackColor = Color.WhiteSmoke;
                this.cbEstado.BackColor = Color.WhiteSmoke;
                this.txtCelular.BackColor = Color.WhiteSmoke;
                this.txtLimite_Credito.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Cliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.cbBuscar.SelectedIndex = 0;
            this.cbSexo.SelectedIndex = 0;
            this.cbEstado.SelectedIndex = 12;
            this.Exibicao_DataLista();
        }


        
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text.Equals(""))
            {
                this.BTN_Pesquisar.Enabled = false;
            }
            else
            {
                this.BTN_Pesquisar.Enabled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNome_Completo.Focus();
            this.txtId.Enabled = false;
            this.txtLimite_Credito.Text = "0,00";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtNome_Completo.Text == string.Empty || this.cbSexo.Text == string.Empty || this.txtEndereco.Text == string.Empty || this.txtBairro.Text == string.Empty || this.txtCidade.Text == string.Empty || this.txtCep.Text == string.Empty || this.cbEstado.Text == string.Empty || this.txtCelular.Text == string.Empty || this.txtLimite_Credito.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imagem = ms.GetBuffer();
                    if (this.eNovo)
                    {
                        resp = NCliente.Inserir(this.txtNome_Completo.Text.Trim().ToUpper(), imagem, this.cbSexo.Text, this.dtData_Nasc.Value, this.txtRg.Text.Trim(), this.txtCpf.Text.Trim(), this.txtEndereco.Text.ToUpper(), this.txtBairro.Text.ToUpper(), this.txtCidade.Text.ToUpper(), this.txtCep.Text, this.cbEstado.Text, this.txtTelefone.Text, this.txtCelular.Text, this.txtEmail.Text, Convert.ToDecimal(this.txtLimite_Credito.Text));
                    }
                    else
                    {
                        resp = NCliente.Editar(Convert.ToInt32(this.txtId.Text), this.txtNome_Completo.Text.Trim().ToUpper(), imagem, this.cbSexo.Text, this.dtData_Nasc.Value, this.txtRg.Text.Trim(), this.txtCpf.Text.Trim(), this.txtEndereco.Text.ToUpper(), this.txtBairro.Text.ToUpper(), this.txtCidade.Text.ToUpper(), this.txtCep.Text, this.cbEstado.Text, this.txtTelefone.Text, this.txtCelular.Text, this.txtEmail.Text, Convert.ToDecimal(this.txtLimite_Credito.Text));
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
                Opcao = MessageBox.Show("Realmente deseja apagar os registros?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NCliente.Excluir(Convert.ToInt32(Codigo));

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

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtBuscar.Text = string.Empty;
            this.txtBuscar.Focus();

            if (this.cbBuscar.Text.Equals("CPF"))
            {
                this.txtBuscar.MaxLength = 14;
            }
            else
            {
                this.txtBuscar.MaxLength = 32767;
            }
        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.pxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxFoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnLimparFoto_Click(object sender, EventArgs e)
        {
            this.pxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxFoto.Image = global::CamadaApresentacao.Properties.Resources.Fundo_White;
        }

        private void FRM_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value);
            this.txtNome_Completo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nome_completo"].Value);

            byte[] imageBuffer = (byte[])this.dataLista.CurrentRow.Cells["foto"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
            this.pxFoto.Image = Image.FromStream(ms);
            this.pxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

            this.cbSexo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["sexo"].Value);
            this.dtData_Nasc.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["data_nasc"].Value);
            this.txtRg.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_rg"].Value);
            this.txtCpf.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_cpf"].Value);
            this.txtEndereco.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["endereco"].Value);
            this.txtBairro.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["bairro"].Value);
            this.txtCidade.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cidade"].Value);
            this.txtCep.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cep"].Value);
            this.cbEstado.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["uf"].Value);
            this.txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["telefone"].Value);
            this.txtCelular.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["celular"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["email"].Value);
            this.txtLimite_Credito.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["limite_credito"].Value);


            this.btnNovo.Enabled = false;
            this.btnCancelar.Enabled = true;
            this.btnEditar.Enabled = true;

            this.tabControl1.SelectedIndex = 1;
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Clientes frm = FRM_Tipo_Relatorio_Clientes.GetInstancia();
            frm.Show();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Nome"))
            {
                this.BuscarNome();
            }
            else if (this.cbBuscar.Text.Equals("RG"))
            {
                this.BuscarRG();
            }
            else
            {
                this.BuscarCPF();
            }
            this.txtBuscar.Text = string.Empty;
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

        private void BTN_Mostrar_Tudo_Click(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (txtCpf.TextLength)
                {
                    case 0:
                        this.txtCpf.Text = "";
                        break;
                    case 3:
                        this.txtCpf.Text += ".";
                        this.txtCpf.SelectionStart = 5;
                        break;
                    case 7:
                        this.txtCpf.Text += ".";
                        this.txtCpf.SelectionStart = 9;
                        break;
                    case 11:
                        this.txtCpf.Text += "-";
                        this.txtCpf.SelectionStart = 13;
                        break;
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

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (this.cbEstado.Text.Equals("MG"))
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCelular.TextLength)
                    {
                        case 0:
                            this.txtCelular.Text = "(31) ";
                            this.txtCelular.SelectionStart = 5;
                            break;
                        case 10:
                            this.txtCelular.Text += " - ";
                            this.txtCelular.SelectionStart = 13;
                            break;
                    }
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar) == true)
                {
                    switch (txtCelular.TextLength)
                    {
                        case 0:
                            this.txtCelular.Text = "(  ) ";
                            this.txtCelular.SelectionStart = 5;
                            break;
                        case 10:
                            this.txtCelular.Text += " - ";
                            this.txtCelular.SelectionStart = 13;
                            break;
                    }
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.cbBuscar.Text.Equals("CPF"))
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

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtTelefone.Text = string.Empty;
            this.txtTelefone.Focus();

            this.txtCelular.Text = string.Empty;
        }

        private void txtLimite_Credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
