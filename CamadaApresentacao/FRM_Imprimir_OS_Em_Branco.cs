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
    public partial class FRM_Imprimir_OS_Em_Branco : Form
    {
        private int Num_OS;
        private void Numeracao_Automatica()
        {
            DataTable TBL_Num_Auto = NNumeracao_Auto.Mostrar_Num_Auto_OS();
            this.Num_OS = Convert.ToInt32(TBL_Num_Auto.Rows[0][2]);
        }

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Imprimir_OS_Em_Branco _Instancia;

        public static FRM_Imprimir_OS_Em_Branco GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Imprimir_OS_Em_Branco();
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

        public FRM_Imprimir_OS_Em_Branco()
        {
            InitializeComponent();
        }

        private void BTN_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Os dados estão corretos?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Opcao == DialogResult.Yes)
            {
                string resp = "";

                // Criar O.S. em Branco
                resp = NOS.Inserir_OS_Em_Branco(this.DT_Data.Value, this.Num_OS, this.CB_Tipo_OS.Text, this.DT_Data.Value);

                if (resp.Equals("Ok"))
                {
                    // Obter ID da O.S. em banco criada
                    DataTable TBL_Dados_OS_Em_Branco = NOS.Mostrar_OS_Em_Branco();
       
                    if (TBL_Dados_OS_Em_Branco.Rows.Count > 0)
                    {
                        int ultima_linha = TBL_Dados_OS_Em_Branco.Rows.Count - 1;
                        int idos = Convert.ToInt32(TBL_Dados_OS_Em_Branco.Rows[ultima_linha][0]);

                        // Abrir e Imprimir O.S. em Branco
                        FRM_Ordem_Servico_Em_Branco frm = FRM_Ordem_Servico_Em_Branco.GetInstancia();
                        frm.IdOS = idos;
                        frm.Show();
                        this.Close();
                    }
                    else
                    {
                        this.MensagemErro("Não há registro.");
                    }
                }
            }
        }

        private void FRM_Imprimir_OS_Em_Branco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Imprimir_OS_Em_Branco_Load(object sender, EventArgs e)
        {
            this.Numeracao_Automatica();
            this.Num_OS++;
        }

        private void CB_Tipo_OS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CB_Tipo_OS.Text.Equals(""))
            {
                this.BTN_Imprimir.Enabled = false;
            }
            else
            {
                this.BTN_Imprimir.Enabled = true;
            }
        }
    }
}
