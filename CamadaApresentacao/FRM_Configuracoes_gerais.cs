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
    public partial class FRM_Configuracoes_gerais : Form
    {
        private bool eEditar = false;
        private DataTable Dados;
        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Configuracoes_gerais _Instancia;

        public static FRM_Configuracoes_gerais GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Configuracoes_gerais();
            }
            return _Instancia;
        }

        public FRM_Configuracoes_gerais()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.PB_Logo, "Insira a logo marca da empresa");
            this.ttMensagem.SetToolTip(this.BTN_CarregarFoto, "Selecionar logo");
            this.ttMensagem.SetToolTip(this.BTN_LimparFoto, "Remover logo");
            this.ttMensagem.SetToolTip(this.TXB_Telefone, "Informe o Telefone");
            this.ttMensagem.SetToolTip(this.TXB_Email, "Informe o Email");
            this.ttMensagem.SetToolTip(this.TXB_Site, "Informe o Site");
            this.ttMensagem.SetToolTip(this.CB_Categoria_Empresa, "Selecione a categoria da empresa");
            this.ttMensagem.SetToolTip(this.TXB_Aliquota, "Informe o percentual do imposto");

            this.TXB_Id.Visible = false;
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


        // Bloquear TextBox
        private void Bloqueado(bool estado)
        {
            this.TXB_Razao_social.ReadOnly = estado;
            this.TXB_Nome_Fantasia.ReadOnly = estado;
            this.TXB_Cnpj.ReadOnly = estado;
            this.TXB_IE.ReadOnly = estado;
            this.TXB_Endereco.ReadOnly = estado;
            this.TXB_Bairro.ReadOnly = estado;
            this.TXB_Cidade.ReadOnly = estado;
            this.TXB_Cep.ReadOnly = estado;
            this.TXB_Uf.ReadOnly = estado;
        }
        
        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Telefone.ReadOnly = !valor;
            this.TXB_Email.ReadOnly = !valor;
            this.TXB_Site.ReadOnly = !valor;
            this.CB_Categoria_Empresa.Enabled = valor;
            this.TXB_Aliquota.ReadOnly = !valor;
        }


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eEditar)
            {
                this.Bloqueado(true);
                this.Habilitar(true);
                this.BTN_Alterar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
                this.BTN_CarregarFoto.Enabled = true;
                this.BTN_LimparFoto.Enabled = true;
            }
            else
            {
                this.Bloqueado(true);
                this.Habilitar(false);
                this.BTN_Alterar.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
                this.BTN_CarregarFoto.Enabled = false;
                this.BTN_LimparFoto.Enabled = false;
            }
        }


        // Mostrar no Data Grid 
        private void Mostrar()
        {
            this.Dados = NRemetente.Mostrar();
        }

        private void CarregarDados()
        {
            // Exibir informaçõs ao iniciar
            if (this.Dados.Rows[0]["logo"].ToString() == "")
            {
                this.TXB_Id.Text = this.Dados.Rows[0]["idremetente"].ToString();
                this.TXB_Razao_social.Text = this.Dados.Rows[0]["razao_social"].ToString();
                this.TXB_Nome_Fantasia.Text = this.Dados.Rows[0]["nome_fantasia"].ToString();
                this.TXB_Cnpj.Text = this.Dados.Rows[0]["cnpj"].ToString();
                this.TXB_IE.Text = this.Dados.Rows[0]["ie"].ToString();
                this.TXB_Endereco.Text = this.Dados.Rows[0]["endereco"].ToString();
                this.TXB_Bairro.Text = this.Dados.Rows[0]["bairro"].ToString();
                this.TXB_Cidade.Text = this.Dados.Rows[0]["cidade"].ToString();
                this.TXB_Cep.Text = this.Dados.Rows[0]["cep"].ToString();
                this.TXB_Uf.Text = this.Dados.Rows[0]["uf"].ToString();
                this.TXB_Telefone.Text = this.Dados.Rows[0]["telefone"].ToString();
                this.TXB_Email.Text = this.Dados.Rows[0]["email"].ToString();
                this.TXB_Site.Text = this.Dados.Rows[0]["url"].ToString();
                this.CB_Categoria_Empresa.Text = this.Dados.Rows[0]["categoria_empresa"].ToString();
                this.TXB_Aliquota.Text = this.Dados.Rows[0]["aliquota"].ToString();
            }
            else
            {
                this.TXB_Id.Text = this.Dados.Rows[0]["idremetente"].ToString();
                this.TXB_Razao_social.Text = this.Dados.Rows[0]["razao_social"].ToString();
                this.TXB_Nome_Fantasia.Text = this.Dados.Rows[0]["nome_fantasia"].ToString();

                byte[] imageBuffer = (byte[])this.Dados.Rows[0]["logo"];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                this.PB_Logo.Image = Image.FromStream(ms);
                this.PB_Logo.SizeMode = PictureBoxSizeMode.StretchImage;

                this.TXB_Cnpj.Text = this.Dados.Rows[0]["cnpj"].ToString();
                this.TXB_IE.Text = this.Dados.Rows[0]["ie"].ToString();
                this.TXB_Endereco.Text = this.Dados.Rows[0]["endereco"].ToString();
                this.TXB_Bairro.Text = this.Dados.Rows[0]["bairro"].ToString();
                this.TXB_Cidade.Text = this.Dados.Rows[0]["cidade"].ToString();
                this.TXB_Cep.Text = this.Dados.Rows[0]["cep"].ToString();
                this.TXB_Uf.Text = this.Dados.Rows[0]["uf"].ToString();
                this.TXB_Telefone.Text = this.Dados.Rows[0]["telefone"].ToString();
                this.TXB_Email.Text = this.Dados.Rows[0]["email"].ToString();
                this.TXB_Site.Text = this.Dados.Rows[0]["url"].ToString();
                this.CB_Categoria_Empresa.Text = this.Dados.Rows[0]["categoria_empresa"].ToString();
                this.TXB_Aliquota.Text = this.Dados.Rows[0]["aliquota"].ToString();
            }
        }

        private void FRM_Configuracoes_gerais_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Bloqueado(true);
            this.Habilitar(false);
            this.botoes();
            this.CarregarDados();
        }

        private void BTN_Alterar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Bloqueado(true);
            this.Habilitar(true);
            this.CB_Categoria_Empresa.SelectedIndex = 0;
            this.TXB_Aliquota.Text = "0,00";
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                this.PB_Logo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imagem = ms.GetBuffer();
                if (this.eEditar)
                {
                    resp = NRemetente.Editar(Convert.ToInt32(this.TXB_Id.Text), imagem, this.TXB_Telefone.Text, this.TXB_Email.Text, this.TXB_Site.Text, this.CB_Categoria_Empresa.Text, Convert.ToDecimal(this.TXB_Aliquota.Text));
                }
                if (resp.Equals("Ok"))
                {
                    this.MensagemOk("Registro alterado com sucesso");
                }
                else
                {
                    this.MensagemErro(resp);
                } 

                this.eEditar = false;
                this.botoes();
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_CarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPeg Image|*.jpg";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.PB_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PB_Logo.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void BTN_LimparFoto_Click(object sender, EventArgs e)
        {
            this.PB_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PB_Logo.Image = global::CamadaApresentacao.Properties.Resources.Fundo_White;
        }

        private void FRM_Configuracoes_gerais_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void TXB_Aliquota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TXB_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.CHK_Celular.Checked) // Usar Celular
            {
                if (this.TXB_Uf.Text.Equals("MG"))
                {
                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (TXB_Telefone.TextLength)
                        {
                            case 0:
                                this.TXB_Telefone.Text = "(31) ";
                                this.TXB_Telefone.SelectionStart = 5;
                                break;
                            case 10:
                                this.TXB_Telefone.Text += " - ";
                                this.TXB_Telefone.SelectionStart = 13;
                                break;
                        }
                    }
                }
                else
                {
                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (TXB_Telefone.TextLength)
                        {
                            case 0:
                                this.TXB_Telefone.Text = "(  ) ";
                                this.TXB_Telefone.SelectionStart = 5;
                                break;
                            case 10:
                                this.TXB_Telefone.Text += " - ";
                                this.TXB_Telefone.SelectionStart = 13;
                                break;
                        }
                    }
                }
            }
            else // Usar Tel. Fixo
            {
                if (this.TXB_Uf.Text.Equals("MG"))
                {
                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (TXB_Telefone.TextLength)
                        {
                            case 0:
                                this.TXB_Telefone.Text = "(31) ";
                                this.TXB_Telefone.SelectionStart = 5;
                                break;
                            case 9:
                                this.TXB_Telefone.Text += " - ";
                                this.TXB_Telefone.SelectionStart = 12;
                                break;
                        }
                    }
                }
                else
                {
                    if (char.IsNumber(e.KeyChar) == true)
                    {
                        switch (TXB_Telefone.TextLength)
                        {
                            case 0:
                                this.TXB_Telefone.Text = "(  ) ";
                                this.TXB_Telefone.SelectionStart = 5;
                                break;
                            case 9:
                                this.TXB_Telefone.Text += " - ";
                                this.TXB_Telefone.SelectionStart = 12;
                                break;
                        }
                    }
                }
            }
        }

        private void CHK_Celular_CheckedChanged(object sender, EventArgs e)
        {
            this.TXB_Telefone.Text = string.Empty;
            this.TXB_Telefone.Focus();

            if (this.CHK_Celular.Checked)
            {
                this.TXB_Telefone.MaxLength = 17; // Usar Celular
            }
            else
            {
                this.TXB_Telefone.MaxLength = 16; // Usar Tel. Fixo
            } 
        }
    }
}
