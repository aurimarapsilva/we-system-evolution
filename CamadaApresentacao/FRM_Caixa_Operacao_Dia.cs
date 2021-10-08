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
    public partial class FRM_Caixa_Operacao_Dia : Form
    {
        //Codificação para evitar de abrir o Form 2X
        private static FRM_Caixa_Operacao_Dia _Instancia;

        public static FRM_Caixa_Operacao_Dia GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Caixa_Operacao_Dia();
            }
            return _Instancia;
        }

        public FRM_Caixa_Operacao_Dia()
        {
            InitializeComponent();
            this.ComboGuiche();
            this.ComboFuncionario();
        }

        private void ComboGuiche()
        {
            this.CB_Caixa.DataSource = NGuiche_Atendimento.Mostrar();
            this.CB_Caixa.ValueMember = "idguiche_atendimento";
            this.CB_Caixa.DisplayMember = "nome";
        }

        private void ComboFuncionario()
        {
            this.CB_Funcionario.DataSource = NFuncionario.Mostrar();
            this.CB_Funcionario.ValueMember = "idfuncionario";
            this.CB_Funcionario.DisplayMember = "usuario";
        }


        //Metodo ocultar colunas do Grid
        private void FormatoColuna()
        {
            // Ocultar Colunas
            this.DGV_Dados.Columns[1].Visible = false;
            this.DGV_Dados.Columns[3].Visible = false;

            // Nome das Colunas
            this.DGV_Dados.Columns[0].HeaderText = "Nº";
            this.DGV_Dados.Columns[2].HeaderText = "Guiche";
            this.DGV_Dados.Columns[5].HeaderText = "Data";
            this.DGV_Dados.Columns[6].HeaderText = "Aberto às";
            this.DGV_Dados.Columns[7].HeaderText = "fechado às";
            this.DGV_Dados.Columns[8].HeaderText = "Valor Inicial";
            this.DGV_Dados.Columns[9].HeaderText = "Cartão Crédito";
            this.DGV_Dados.Columns[10].HeaderText = "Cartão Debito";
            this.DGV_Dados.Columns[11].HeaderText = "Cheque";
            this.DGV_Dados.Columns[12].HeaderText = "Crediário da Loja";
            this.DGV_Dados.Columns[13].HeaderText = "Dinheiro";
            this.DGV_Dados.Columns[14].HeaderText = "Total";

            // Formato Moeda
            this.DGV_Dados.Columns[8].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[9].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[10].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[11].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[12].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[13].DefaultCellStyle.Format = "c";
            this.DGV_Dados.Columns[14].DefaultCellStyle.Format = "c";
        }

        // Metodo Mostrar 
        private void Mostrar()
        {
            this.DGV_Dados.DataSource = NCaixa_Operacao_Dia.Mostrar();
            this.FormatoColuna();
            LB_Total_Registros.Text = Convert.ToString(DGV_Dados.Rows.Count);
        }

        // Metodo Pesquisar por Caixa 
        private void BuscarCaixa()
        {
            this.DGV_Dados.DataSource = NCaixa_Operacao_Dia.BuscarCaixa(CB_Caixa.SelectedValue.ToString());
            this.FormatoColuna();
            LB_Total_Registros.Text = Convert.ToString(DGV_Dados.Rows.Count);
        }

        // Metodo Pesquisar por Datas
        private void BuscarDatas()
        {
            this.DGV_Dados.DataSource = NCaixa_Operacao_Dia.BuscarDatas(dtInicial.Text, dtFinal.Text);
            this.FormatoColuna();
            LB_Total_Registros.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
        }

        // Metodo Pesquisar por Funcionario
        private void BuscarFuncionario()
        {
            this.DGV_Dados.DataSource = NCaixa_Operacao_Dia.BuscarFuncionario(CB_Funcionario.SelectedValue.ToString());
            this.FormatoColuna();
            LB_Total_Registros.Text = "Total de registros: " + Convert.ToString(DGV_Dados.Rows.Count);
        }

        private void FRM_Caixa_Operacao_Dia_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void FRM_Caixa_Operacao_Dia_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        private void BTN_Pesquisar_Caixa_Click(object sender, EventArgs e)
        {
            this.BuscarCaixa();
            this.LB_Modo_Exibicao.Text = "Guiche";
        }

        private void btnBuscar_Datas_Click(object sender, EventArgs e)
        {
            this.BuscarDatas();
            this.LB_Modo_Exibicao.Text = "Datas";
        }

        private void BTN_Pesquisar_Funcionario_Click(object sender, EventArgs e)
        {
            this.BuscarFuncionario();
            this.LB_Modo_Exibicao.Text = "Funcionário";
        }

        private void LB_Modo_Exibicao_TextChanged(object sender, EventArgs e)
        {
            if (this.LB_Modo_Exibicao.Text == "Mostrar Tudo")
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
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }
    }
}
