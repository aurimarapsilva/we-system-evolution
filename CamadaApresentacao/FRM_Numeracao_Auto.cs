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
    public partial class FRM_Numeracao_Auto : Form
    {
        private bool eEditar;

        public int num_auto_venda;
        
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Numeracao_Auto _Instancia;

        public static FRM_Numeracao_Auto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Numeracao_Auto();
            }
            return _Instancia;
        }

        public FRM_Numeracao_Auto()
        {
            InitializeComponent();
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


        //Mostar Configurações De Numeração Automática Venda
        private void Mostar_Config_Num_Auto_Venda()
        {
            this.DGV_Config_Num_Auto.DataSource = NNumeracao_Auto.Mostrar_Num_Auto_Venda();

            // Ocular Colunas
            this.DGV_Config_Num_Auto.Columns[0].Visible = false;
            this.DGV_Config_Num_Auto.Columns[2].Visible = false;

            //Nome das Colunas
            this.DGV_Config_Num_Auto.Columns[1].HeaderText = "Iniciar em:";
            this.DGV_Config_Num_Auto.Columns[3].HeaderText = "Habilitado";

            //Tamanho das Colunas
            this.DGV_Config_Num_Auto.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGV_Config_Num_Auto.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        //Mostar Configurações De Numeração Automática OS
        private void Mostar_Config_Num_Auto_OS()
        {
            this.DGV_Config_OS.DataSource = NNumeracao_Auto.Mostrar_Num_Auto_OS();

            // Ocular Colunas
            this.DGV_Config_OS.Columns[0].Visible = false;
            this.DGV_Config_OS.Columns[2].Visible = false;

            //Nome das Colunas
            this.DGV_Config_OS.Columns[1].HeaderText = "Iniciar em:";
            this.DGV_Config_OS.Columns[3].HeaderText = "Habilitado";

            //Tamanho das Colunas
            this.DGV_Config_OS.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DGV_Config_OS.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            // VENDA
            this.CB_Estado_Config.Enabled = valor;
            this.TXB_Inicio_Venda.ReadOnly = !valor;

            if (this.eEditar)
            {
                this.TXB_Inicio_Venda.BackColor = Color.White;
                this.CB_Estado_Config.BackColor = Color.White;
            }
            else
            {
                this.TXB_Inicio_Venda.BackColor = Color.WhiteSmoke;
                this.CB_Estado_Config.BackColor = Color.WhiteSmoke;
            }

            // OS
            this.CB_Estado_Config_OS.Enabled = valor;
            this.TXB_Inicio_OS.ReadOnly = !valor;

            if (this.eEditar)
            {
                this.TXB_Inicio_OS.BackColor = Color.White;
                this.CB_Estado_Config_OS.BackColor = Color.White;
            }
            else
            {
                this.TXB_Inicio_OS.BackColor = Color.WhiteSmoke;
                this.CB_Estado_Config_OS.BackColor = Color.WhiteSmoke;
            }
        }

        //Metodo Limpar
        private void Limpar()
        {
            TXB_Inicio_Venda.Text = string.Empty;
            TXB_Inicio_OS.Text = string.Empty;
        }

        //Habilitar os Botões
        private void botoes()
        {
            if (this.eEditar)
            {
                this.Habilitar(true);
                this.BTN_Alterar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Alterar.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
            }
        }


        // Metodo Alerta de Campo Obrigatorio em Branco - VENDA
        private void Alerta_Campos_Obrigatorios_Venda()
        {
            if (this.eEditar)
            {
                this.TXB_Inicio_Venda.BackColor = Color.LemonChiffon;
                this.CB_Estado_Config.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Inicio_Venda.BackColor = Color.WhiteSmoke;
                this.CB_Estado_Config.BackColor = Color.WhiteSmoke;
            }
        }


        // Metodo Alerta de Campo Obrigatorio em Branco - OS
        private void Alerta_Campos_Obrigatorios_OS()
        {
            if (this.eEditar)
            {
                this.TXB_Inicio_OS.BackColor = Color.LemonChiffon;
                this.CB_Estado_Config_OS.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Inicio_OS.BackColor = Color.WhiteSmoke;
                this.CB_Estado_Config_OS.BackColor = Color.WhiteSmoke;
            }
        }


        private void FRM_Numeracao_Auto_Load(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Mostar_Config_Num_Auto_Venda();
            this.Mostar_Config_Num_Auto_OS();
        }


        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eEditar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios_Venda();
            this.Alerta_Campos_Obrigatorios_OS();
            this.Close();
        }


        private void BTN_Alterar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
            this.TXB_Inicio_Venda.Focus();
        
            //Enviando dados do Grid para os TextBox
            this.TXB_Id.Text = Convert.ToString(this.DGV_Config_Num_Auto.Rows[0].Cells[0].Value);
            this.TXB_Inicio_Venda.Text = Convert.ToString(this.DGV_Config_Num_Auto.Rows[0].Cells[1].Value);
            this.CB_Estado_Config.Text = Convert.ToString(this.DGV_Config_Num_Auto.Rows[0].Cells[3].Value);
        }


        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Inicio_Venda.Text == string.Empty || CB_Estado_Config.Text == string.Empty)
                {
                    this.MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios_Venda();
                }
                else
                {
                    if (this.eEditar)
                    {
                        resp = NNumeracao_Auto.Editar_Num_Auto_Venda(Convert.ToInt32(this.TXB_Id.Text), Convert.ToInt32(this.TXB_Inicio_Venda.Text), Convert.ToInt32(this.TXB_Inicio_Venda.Text), this.CB_Estado_Config.Text);
                    }
                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Configuração gravada com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostar_Config_Num_Auto_Venda();
                    this.Alerta_Campos_Obrigatorios_Venda();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FRM_Numeracao_Auto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios_Venda();
            this.Alerta_Campos_Obrigatorios_OS();
        }

        private void CB_Estado_Config_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BTN_Alterar_OS_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
            this.TXB_Inicio_Venda.Focus();

            //Enviando dados do Grid para os TextBox
            this.TXB_Id.Text = Convert.ToString(this.DGV_Config_OS.Rows[0].Cells[0].Value);
            this.TXB_Inicio_OS.Text = Convert.ToString(this.DGV_Config_OS.Rows[0].Cells[1].Value);
            this.CB_Estado_Config_OS.Text = Convert.ToString(this.DGV_Config_OS.Rows[0].Cells[3].Value);
        }

        private void BTN_Salvar_OS_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.TXB_Inicio_OS.Text == string.Empty || this.CB_Estado_Config_OS.Text == string.Empty)
                {
                    this.MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios_OS();
                }
                else
                {
                    if (this.eEditar)
                    {
                        resp = NNumeracao_Auto.Editar_Num_Auto_OS(Convert.ToInt32(this.TXB_Id.Text), Convert.ToInt32(this.TXB_Inicio_OS.Text), Convert.ToInt32(this.TXB_Inicio_OS.Text), this.CB_Estado_Config_OS.Text);
                    }
                    if (resp.Equals("Ok"))
                    {
                        this.MensagemOk("Configuração gravada com sucesso");
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }

                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostar_Config_Num_Auto_OS();
                    this.Alerta_Campos_Obrigatorios_OS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TXB_Inicio_Venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TXB_Inicio_OS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
