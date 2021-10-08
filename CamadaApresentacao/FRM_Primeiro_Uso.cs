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
    public partial class FRM_Primeiro_Uso : Form
    {
        private bool eNovo;
        
        public FRM_Primeiro_Uso()
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
            this.TXB_Usuario.Text = string.Empty;
            this.TXB_Senha.Text = string.Empty;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.TXB_Usuario.ReadOnly = !valor;
            this.TXB_Senha.ReadOnly = !valor;
        }

        
        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Usuario.Text == string.Empty || this.TXB_Senha.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos");
                }
                else
                {
                    if (this.eNovo)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        this.PB_Foto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imagem = ms.GetBuffer();
                        resp = NFuncionario.Inserir("ADMINISTRADOR", "", imagem, "N", Convert.ToDateTime("01/01/2001"), "XXXXXX", "XXXXXX", "USUÁRIO PRIMARIO", "Exemplo", "Exemplo", "Exemplo", "Exemplo", "XX", "", "Exemplo", "", 3, this.TXB_Usuario.Text, this.TXB_Senha.Text, Convert.ToDecimal("0,00"), "Lucro da Venda", Convert.ToDecimal("0,00"));
                    }
                   
                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Registro salvo com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eNovo = false;
                    this.Limpar();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_limpar_Click(object sender, EventArgs e)
        {
            this.TXB_Senha.Text = string.Empty;
        }

        private void FRM_Primeiro_Uso_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRM_Login frm = FRM_Login.GetInstancia();
            frm.ComboUsuario();
            frm.Show();
        }

        private void FRM_Primeiro_Uso_Load(object sender, EventArgs e)
        {
            eNovo = true;
        }
    }
}
