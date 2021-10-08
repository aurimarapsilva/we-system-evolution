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
    public partial class FRM_Atalho_Novo_Cliente_Venda : Form
    {
        public bool eNovo = false;
       
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Atalho_Novo_Cliente_Venda _Instancia;

        public static FRM_Atalho_Novo_Cliente_Venda GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Atalho_Novo_Cliente_Venda();
            }
            return _Instancia;
        }

        public FRM_Atalho_Novo_Cliente_Venda()
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
        
        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo)
            {
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }

        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo)
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

        private void FRM_Atalho_Novo_Cliente_Load(object sender, EventArgs e)
        {
            this.botoes();
            this.cbSexo.SelectedIndex = 0;
            this.cbEstado.SelectedIndex = 12;
            this.txtNome_Completo.Focus();
            this.txtLimite_Credito.Text = "0,00";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.botoes();
            this.Limpar();
            this.Close();
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

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;         
                    this.botoes();
                    this.Limpar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Atalho_Novo_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
            FRM_Buscar_Cliente_Venda frm = FRM_Buscar_Cliente_Venda.GetInstancia();
            frm.Mostrar();
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
