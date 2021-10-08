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
    public partial class FRM_Selecionar_Bandeira_Cartao_Credito : Form
    {
        private string bandeira = "";
        private decimal taxa = 0;

        public FRM_Selecionar_Bandeira_Cartao_Credito()
        {
            InitializeComponent();
        }

        //Codificação para evitar de abrir o Form 2X
        private static FRM_Selecionar_Bandeira_Cartao_Credito _Instancia;

        public static FRM_Selecionar_Bandeira_Cartao_Credito GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Selecionar_Bandeira_Cartao_Credito();
            }
            return _Instancia;
        }

        private void Mostrar_Bandeiras()
        {
            // Obtendo daods
            this.DGV_Bandeiras.DataSource = NConfig_Cartao_Credito.Mostrar();
            this.label2.Text = Convert.ToString(this.DGV_Bandeiras.Rows.Count);

            // Ocultar Colunas
            this.DGV_Bandeiras.Columns[0].Visible = false;
            this.DGV_Bandeiras.Columns[2].Visible = false;
            this.DGV_Bandeiras.Columns[3].Visible = false;
            this.DGV_Bandeiras.Columns[4].Visible = false;

            // Nome das Colunas
            this.DGV_Bandeiras.Columns[1].HeaderText = "Bandeira";

            // Tabanho das Colunas
            this.DGV_Bandeiras.Columns[1].Width = 235;
        }

        private void FRM_Selecionar_Bandeira_Load(object sender, EventArgs e)
        {
            this.Mostrar_Bandeiras();
        }

        private void FRM_Selecionar_Bandeira_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;

            this.bandeira = "";
            this.taxa = 0;
        }

        private void DGV_Bandeiras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Informacoes_Cartao_Credito frm = FRM_Informacoes_Cartao_Credito.GetInstancia();

            this.bandeira = this.DGV_Bandeiras.CurrentRow.Cells[1].Value.ToString();
            
            frm.Set_Bandeira(this.bandeira);
            this.Close();
        }
    }
}
