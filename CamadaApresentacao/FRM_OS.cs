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
    public partial class FRM_OS : Form
    {
        private bool chave = true;
        private bool eNovo = false;
        public bool eEditar = false;
        private bool OS_Em_Branco = false;
        private DataTable dtProd_Serv;
        private DataTable DT_Dados_Remetente;
        private DataTable DT_Num_Auto;
      //  private decimal totalPago = 0;
        private decimal Total_Geral = 0;

        // Variavel para receber IdCliente
        private int IdCliente;

        // Variavel para receber IdRemetente
        private int idremetente;
        
        // Metodo Analise de OS: Em Branco ou Preenchida
        public void Tarefas_OS_Em_Branco(string ACAO, string ID, string NUM_OS)
        {
            if (ACAO.Equals("Reimprimir"))
            {
                FRM_Ordem_Servico_Em_Branco frm = FRM_Ordem_Servico_Em_Branco.GetInstancia();
                frm.IdOS = Convert.ToInt32(ID);
                frm.Show();
            }
            else if (ACAO.Equals("Preencher"))
            {
                DataTable TBL_Dados_OS = NOS.Buscar_OS_ID(Convert.ToInt32(ID));

                this.eEditar = true;
                this.OS_Em_Branco = true;
                this.Habilitar(true);
                this.botoes();
                this.Bloquear();
                this.ComboEquipamento();
                this.ComboTecnico();
                this.BTN_Adicionar_Produtos_Servicos.Enabled = false;

                this.TXB_Acessorios.ReadOnly = false;
                this.TXB_Parafusos_Faltando.ReadOnly = false;
                this.TXB_Partes_Quebradas.ReadOnly = false;
                this.TXB_Arranhoes.ReadOnly = false;
                this.TXB_Outros.ReadOnly = false;

                this.TXB_Id.Text = ID;
                this.label3.Text = NUM_OS;
                this.DT_Data_Inicial.Value = Convert.ToDateTime(TBL_Dados_OS.Rows[0]["data"]);
                this.CB_Tipo_OS.Text = TBL_Dados_OS.Rows[0]["tipo"].ToString();
                this.TXB_Data_Entrada.Text = TBL_Dados_OS.Rows[0]["data_entrada"].ToString();

                this.tabControl1.SelectedIndex = 1;
            }
        }


        // Dados do Remetente
        private void Dados_Remetente()
        {
            // Recupernado dados
            this.DT_Dados_Remetente = NRemetente.Mostrar();

            // Adicionado dados a variavel para gerar venda
            this.idremetente = Convert.ToInt32(this.DT_Dados_Remetente.Rows[0][0]);
        }


        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_OS _Instancia;

        public static FRM_OS GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_OS();
            }
            return _Instancia;
        }


        //Metodo Numeração Automática 
        private int Auxiliar_NA;    //Variavel Auxiliar

        private void Numeracao_Automatica()
        {
            this.DT_Num_Auto = NNumeracao_Auto.Mostrar_Num_Auto_OS();
            this.Auxiliar_NA = Convert.ToInt32(this.DT_Num_Auto.Rows[0][2]);
        }


        public FRM_OS()
        {
            InitializeComponent();
            this.ttMensagem.SetToolTip(this.TXB_Cliente, "Informe o nome completo");
            this.ttMensagem.SetToolTip(this.TXB_Rg, "Informe o número do RG");
            this.ttMensagem.SetToolTip(this.TXB_Cpf, "Informe o número do CPF");
            this.ttMensagem.SetToolTip(this.TXB_Endereco_Completo, "Informe o endereço");
            this.ttMensagem.SetToolTip(this.TXB_Celular, "Informe o Nº do celular");
            this.ttMensagem.SetToolTip(this.BTN_Selecionar_Cliente, "Clique para selecionar um cliente");
            this.ttMensagem.SetToolTip(this.CB_Tipo_Equipamento, "Selecione o equipamento");
            this.ttMensagem.SetToolTip(this.TXB_Marca, "Informe a marca");
            this.ttMensagem.SetToolTip(this.TXB_Modelo, "Informe o modelo");
            this.ttMensagem.SetToolTip(this.TXB_Num_Serie, "Informe o Nº de Série");
            this.ttMensagem.SetToolTip(this.TXB_Cor, "Informe a cor");
            this.ttMensagem.SetToolTip(this.TXB_Obs_Cliente, "Insira observações do cliente");
            this.ttMensagem.SetToolTip(this.TXB_Diagnostico, "Insira o diagnostico");
            this.TXB_Id.Visible = false;

            this.TXB_Total_Geral.ReadOnly = true;
            this.TXB_Total_Geral.BackColor = Color.WhiteSmoke;
            this.TXB_Total_Geral.ForeColor = Color.Green;
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
            this.TXB_Id.Text = string.Empty;
            this.CB_Tipo_OS.Text = string.Empty;
            this.TXB_Cliente.Text = string.Empty;
            this.TXB_Rg.Text = string.Empty;
            this.TXB_Cpf.Text = string.Empty;
            this.DT_Data_Inicial.Text = string.Empty;
            this.TXB_Endereco_Completo.Text = string.Empty;
            this.TXB_Celular.Text = string.Empty;
            this.CB_Tipo_Equipamento.Text = string.Empty;
            this.CB_Tecnico.Text = string.Empty;
            this.TXB_Marca.Text = string.Empty;
            this.TXB_Modelo.Text = string.Empty;
            this.TXB_Num_Serie.Text = string.Empty;
            this.TXB_Cor.Text = string.Empty;
            this.TXB_Senha.Text = string.Empty;
            this.TXB_Acessorios.Text = string.Empty;
            this.TXB_Parafusos_Faltando.Text = string.Empty;
            this.TXB_Placa.Text = string.Empty;
            this.CB_Uf.Text = string.Empty;
            this.TXB_Km.Text = string.Empty;
            this.TXB_Obs_Cliente.Text = string.Empty;
            this.TXB_Diagnostico.Text = string.Empty;
            this.TXB_Total_Geral.Text = "R$ 0,00";
            this.CB_Auto_Cliente.Text = string.Empty;
            this.CB_Estado_OS.Text = string.Empty;
            this.TXB_Data_Entrada.Text = string.Empty;
            this.TXB_Data_Auto_Cliente.Text = string.Empty;
            this.TXB_Data_Pronto.Text = string.Empty;
            this.TXB_Data_Retirada.Text = string.Empty;
            this.TXB_Previsao_Entrega.Text = string.Empty;
            this.TXB_Acessorios.Text = string.Empty;
            this.TXB_Parafusos_Faltando.Text = string.Empty;
            this.TXB_Partes_Quebradas.Text = string.Empty;
            this.TXB_Arranhoes.Text = string.Empty;
            this.TXB_Outros.Text = string.Empty;
            this.label3.Text = string.Empty;

            // Limpar Grid - DGV_Prod_Serv
            if (this.DGV_Prod_Serv.DataSource != null)
            {
                this.DGV_Prod_Serv.DataSource = null;
            }
            else
            {
                this.DGV_Prod_Serv.Rows.Clear();
            }
        }

        //Habilitar os textBox
        public void Habilitar(bool valor)
        {
            this.CB_Tipo_OS.Enabled = valor;
            this.CB_Tecnico.Enabled = valor;
            this.DT_Data_Inicial.Enabled = valor;
            this.CB_Tipo_Equipamento.Enabled = valor;
            this.TXB_Marca.ReadOnly = !valor;
            this.TXB_Modelo.ReadOnly = !valor;
            this.TXB_Num_Serie.ReadOnly = !valor;
            this.TXB_Cor.ReadOnly = !valor;
            this.TXB_Senha.ReadOnly = !valor;
            this.TXB_Obs_Cliente.ReadOnly = !valor;
            this.TXB_Diagnostico.ReadOnly = !valor;
            this.TXB_Total_Geral.ReadOnly = !valor;
            this.CB_Auto_Cliente.Enabled = valor;
            this.CB_Estado_OS.Enabled = valor;
            this.TXB_Previsao_Entrega.ReadOnly = !valor;

            // ELETRO
            if (valor)
            {
                this.CB_Tipo_OS.BackColor = Color.White;
                this.CB_Tecnico.BackColor = Color.White;
                this.TXB_Cliente.BackColor = Color.White;
                this.CB_Tipo_Equipamento.BackColor = Color.White;
                this.TXB_Marca.BackColor = Color.White;
                this.TXB_Modelo.BackColor = Color.White;
                this.TXB_Cor.BackColor = Color.White;
                this.TXB_Acessorios.BackColor = Color.White;
            }
            else
            {
                this.CB_Tipo_OS.BackColor = Color.WhiteSmoke;
                this.CB_Tecnico.BackColor = Color.WhiteSmoke;
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.CB_Tipo_Equipamento.BackColor = Color.WhiteSmoke;
                this.TXB_Marca.BackColor = Color.WhiteSmoke;
                this.TXB_Modelo.BackColor = Color.WhiteSmoke;
                this.TXB_Cor.BackColor = Color.WhiteSmoke;
                this.TXB_Acessorios.BackColor = Color.WhiteSmoke;
            }


            // AUTOMOTIVO
            if (valor)
            {
                this.CB_Tipo_OS.BackColor = Color.White;
                this.CB_Tecnico.BackColor = Color.White;
                this.TXB_Cliente.BackColor = Color.White;
                this.CB_Tipo_Equipamento.BackColor = Color.White;
                this.TXB_Marca.BackColor = Color.White;
                this.TXB_Modelo.BackColor = Color.White;
                this.TXB_Cor.BackColor = Color.White;
                this.TXB_Placa.BackColor = Color.White;
                this.CB_Uf.BackColor = Color.White;
                this.TXB_Km.BackColor = Color.White;
            }
            else
            {
                this.CB_Tipo_OS.BackColor = Color.WhiteSmoke;
                this.CB_Tecnico.BackColor = Color.WhiteSmoke;
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.CB_Tipo_Equipamento.BackColor = Color.WhiteSmoke;
                this.TXB_Marca.BackColor = Color.WhiteSmoke;
                this.TXB_Modelo.BackColor = Color.WhiteSmoke;
                this.TXB_Cor.BackColor = Color.WhiteSmoke;
                this.TXB_Placa.BackColor = Color.WhiteSmoke;
                this.CB_Uf.BackColor = Color.WhiteSmoke;
                this.TXB_Km.BackColor = Color.WhiteSmoke;
            }
        }


        // Bloquear TextBox
        public void Bloquear()
        {
            // Dados do Cliente
            this.TXB_Cliente.ReadOnly = true;
            this.TXB_Rg.ReadOnly = true;
            this.TXB_Cpf.ReadOnly = true;
            this.TXB_Endereco_Completo.ReadOnly = true;
            this.TXB_Celular.ReadOnly = true;

            // Campos Automotivo
            this.TXB_Placa.ReadOnly = true;
            this.CB_Uf.Enabled = false;
            this.TXB_Km.ReadOnly = true;

            // Datas
            this.TXB_Data_Entrada.ReadOnly = true;
            this.TXB_Data_Auto_Cliente.ReadOnly = true;
            this.TXB_Data_Pronto.ReadOnly = true;
            this.TXB_Data_Retirada.ReadOnly = true;
        }

        //Habilitar os Botões
        public void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
                this.BTN_Selecionar_Cliente.Enabled = true;
                this.BTN_Adicionar_Produtos_Servicos.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
                this.BTN_Selecionar_Cliente.Enabled = false;
                this.BTN_Adicionar_Produtos_Servicos.Enabled = false;
            }
        }

        //Metodo ocultar colunas do Grid
        private void Formatar_Grid()
        {
            // Ocultar Colunas
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;
            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[6].Visible = false;
            this.dataLista.Columns[8].Visible = false;
            this.dataLista.Columns[9].Visible = false;
            this.dataLista.Columns[10].Visible = false;
            this.dataLista.Columns[11].Visible = false;
            this.dataLista.Columns[12].Visible = false;
            this.dataLista.Columns[13].Visible = false;
            this.dataLista.Columns[14].Visible = false;
            this.dataLista.Columns[15].Visible = false;
            this.dataLista.Columns[17].Visible = false;
            this.dataLista.Columns[19].Visible = false;
            this.dataLista.Columns[20].Visible = false;
            this.dataLista.Columns[21].Visible = false;
            this.dataLista.Columns[22].Visible = false;
            this.dataLista.Columns[23].Visible = false;
            this.dataLista.Columns[24].Visible = false;
            this.dataLista.Columns[25].Visible = false;
            this.dataLista.Columns[30].Visible = false;
            this.dataLista.Columns[31].Visible = false;
            this.dataLista.Columns[32].Visible = false;
            this.dataLista.Columns[34].Visible = false;
            this.dataLista.Columns[35].Visible = false;
            this.dataLista.Columns[36].Visible = false;
            this.dataLista.Columns[37].Visible = false;
            this.dataLista.Columns[38].Visible = false;
            this.dataLista.Columns[39].Visible = false;

            // Nome das colunas
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "OS";
            this.dataLista.Columns[4].HeaderText = "Tipo";
            this.dataLista.Columns[7].HeaderText = "Cliente";
            this.dataLista.Columns[18].HeaderText = "Marca";
            this.dataLista.Columns[26].HeaderText = "Diagnóstico";
            this.dataLista.Columns[27].HeaderText = "Autorização";
            this.dataLista.Columns[28].HeaderText = "Status Geral";
            this.dataLista.Columns[29].HeaderText = "Entrada em:";
            this.dataLista.Columns[33].HeaderText = "Total";

            //Formato Colunas Grid
            this.dataLista.Columns[33].DefaultCellStyle.Format = "c";
        }

        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.dataLista.DataSource = NOS.Mostrar();
            this.Formatar_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }

        // Mostrar Detalhes da OS
        public void MostrarDetalhes()
        {
            this.DGV_Prod_Serv.DataSource = NOS.MostrarDetalhes(this.TXB_Id.Text);
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);

            // Ocultar Colunas
            this.DGV_Prod_Serv.Columns[1].Visible = false;

            //definir tamanho do Grid
            this.DGV_Prod_Serv.Columns[3].Width = 280;

            //Formatar Grid
            this.DGV_Prod_Serv.Columns[4].DefaultCellStyle.Format = "c";
            this.DGV_Prod_Serv.Columns[5].DefaultCellStyle.Format = "c";
        }


        // Buscar pelo Nome do Cliente
        private void Buscar_Pelo_Cliente()
        {
            this.dataLista.DataSource = NOS.Buscar_Pelo_Cliente(this.txtBuscar.Text);
            this.Formatar_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Cliente";
        }


        // Buscar pelo Nº da OS
        private void Buscar_Pelo_Num_OS()
        {
            this.dataLista.DataSource = NOS.Buscar_Pelo_Numero_OS(this.txtBuscar.Text);
            this.Formatar_Grid();
            lblTotal.Text = "Total de registros: " + Convert.ToString(dataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Nº da O.S.";
        }

        private void CriarTabela()
        {
            this.dtProd_Serv = new DataTable("Detalhe");
            this.dtProd_Serv.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.dtProd_Serv.Columns.Add("quant", System.Type.GetType("System.Decimal"));
            this.dtProd_Serv.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtProd_Serv.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.dtProd_Serv.Columns.Add("Subtotal", System.Type.GetType("System.Decimal"));

            this.DGV_Prod_Serv.DataSource = this.dtProd_Serv;

            //Ocultar Coluna do Grid
            this.DGV_Prod_Serv.Columns[1].Visible = false;

            //definir tamanho do Grid
            this.DGV_Prod_Serv.Columns[3].Width = 280;

            //Formatar Grid
            this.DGV_Prod_Serv.Columns[4].DefaultCellStyle.Format = "c";
            this.DGV_Prod_Serv.Columns[5].DefaultCellStyle.Format = "c";
        }

        //Metodo criar linha no Grid - dataListaDetalhes ao iniciar
        private void CriarLinha()
        {
            DataRow row = this.dtProd_Serv.NewRow();
            this.dtProd_Serv.Rows.Add(row);
        }

        // Metodo Pegar Prosutos para OS
        public void SetProduto(int idproduto, string descricao, decimal preco_venda)
        {
            bool salvar = true;
            foreach (DataGridViewRow linha in DGV_Prod_Serv.Rows)
            {
                if (linha.Cells[1].Value.Equals(idproduto))
                {
                    salvar = false;
             
                    MessageBox.Show("Este produto ou serviço já foi adicionado a lista.", "WE System Evolution", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (salvar)
            {
                if (this.DGV_Prod_Serv.CurrentRow.Cells[2].Value.ToString() == "")
                {
                    this.DGV_Prod_Serv.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Prod_Serv.CurrentRow.Cells[2].Value = 1;
                    this.DGV_Prod_Serv.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Prod_Serv.CurrentRow.Cells[4].Value = preco_venda;
                }
                else
                {
                    this.DGV_Prod_Serv.CurrentRow.Cells[1].Value = idproduto;
                    this.DGV_Prod_Serv.CurrentRow.Cells[3].Value = descricao;
                    this.DGV_Prod_Serv.CurrentRow.Cells[4].Value = preco_venda;
                }
            }
        }


        // Metodo Pegar Cliente para OS
        public void SetCliente(int idcliente, string nome_completo, string num_cpf, string num_rg, string endereco, string bairro, string cidade, string cep, string uf, string celular)
        {
            this.IdCliente = idcliente;
            this.TXB_Cliente.Text = nome_completo;
            this.TXB_Cpf.Text = num_cpf;
            this.TXB_Rg.Text = num_rg;
            this.TXB_Endereco_Completo.Text = endereco + " - " + bairro + " - " + cidade + " - " + cep + " - " + uf;
            this.TXB_Celular.Text = celular;
        }


        public void ComboTecnico()
        {
            CB_Tecnico.DataSource = NTecnico.Mostrar();
            CB_Tecnico.ValueMember = "Idtecnico";
            CB_Tecnico.DisplayMember = "nome_completo";
        }


        public void ComboEquipamento()
        {
            CB_Tipo_Equipamento.DataSource = NEquipamento.Mostrar();
            CB_Tipo_Equipamento.ValueMember = "Idequipamento";
            CB_Tipo_Equipamento.DisplayMember = "nome";
        }


        // Mostrar Produtos pelo Codigode Barras
        public void Selecionar_Produto_Codigo_Barra()
        {
            this.DGV_Select_Prod_Cod_Barra.DataSource = NProduto.Selecionar_Produto_Codigo_Barra_Venda(Convert.ToString(this.DGV_Prod_Serv.CurrentRow.Cells[3].Value));
        }


        private void MoveNext()
        {
            if (this.DGV_Prod_Serv.CurrentRow.Cells[2].Selected)
            {
                int index = this.DGV_Prod_Serv.CurrentRow.Index;

                this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[3];
            }
            else if (this.DGV_Prod_Serv.CurrentRow.Cells[3].Selected)
            {
                int index = this.DGV_Prod_Serv.CurrentRow.Index;

                this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[4];
            }
            else if (this.DGV_Prod_Serv.CurrentRow.Cells[4].Selected)
            {
                int index = this.DGV_Prod_Serv.CurrentRow.Index;

                this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[5];
            }
            else if (this.DGV_Prod_Serv.CurrentRow.Cells[5].Selected)
            {
                this.CriarLinha();

                int index = this.DGV_Prod_Serv.CurrentRow.Index + 1;
                this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[2];
            }
        }


        // Metodo Alerta de Campo Obrigatorio em Branco - ELETRO
        private void Alerta_Campos_Obrigatorios_Eletro()
        {
            if (this.eNovo || this.eEditar)
            {
                this.CB_Tipo_OS.BackColor = Color.LemonChiffon;
                this.CB_Tecnico.BackColor = Color.LemonChiffon;
                this.TXB_Cliente.BackColor = Color.LemonChiffon;
                this.CB_Tipo_Equipamento.BackColor = Color.LemonChiffon;
                this.TXB_Marca.BackColor = Color.LemonChiffon;
                this.TXB_Modelo.BackColor = Color.LemonChiffon;
                this.TXB_Cor.BackColor = Color.LemonChiffon;
                this.TXB_Acessorios.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.CB_Tipo_OS.BackColor = Color.WhiteSmoke;
                this.CB_Tecnico.BackColor = Color.WhiteSmoke;
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.CB_Tipo_Equipamento.BackColor = Color.WhiteSmoke;
                this.TXB_Marca.BackColor = Color.WhiteSmoke;
                this.TXB_Modelo.BackColor = Color.WhiteSmoke;
                this.TXB_Cor.BackColor = Color.WhiteSmoke;
                this.TXB_Acessorios.BackColor = Color.WhiteSmoke;
            }
        }

        // Metodo Alerta de Campo Obrigatorio em Branco - AUTOMOTIVO
        private void Alerta_Campos_Obrigatorios_Automotivo()
        {
            if (this.eNovo || this.eEditar)
            {
                this.CB_Tipo_OS.BackColor = Color.LemonChiffon;
                this.CB_Tecnico.BackColor = Color.LemonChiffon;
                this.TXB_Cliente.BackColor = Color.LemonChiffon;
                this.CB_Tipo_Equipamento.BackColor = Color.LemonChiffon;
                this.TXB_Marca.BackColor = Color.LemonChiffon;
                this.TXB_Modelo.BackColor = Color.LemonChiffon;
                this.TXB_Cor.BackColor = Color.LemonChiffon;
                this.TXB_Placa.BackColor = Color.LemonChiffon;
                this.CB_Uf.BackColor = Color.LemonChiffon;
                this.TXB_Km.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.CB_Tipo_OS.BackColor = Color.WhiteSmoke;
                this.CB_Tecnico.BackColor = Color.WhiteSmoke;
                this.TXB_Cliente.BackColor = Color.WhiteSmoke;
                this.CB_Tipo_Equipamento.BackColor = Color.WhiteSmoke;
                this.TXB_Marca.BackColor = Color.WhiteSmoke;
                this.TXB_Modelo.BackColor = Color.WhiteSmoke;
                this.TXB_Cor.BackColor = Color.WhiteSmoke;
                this.TXB_Placa.BackColor = Color.WhiteSmoke;
                this.CB_Uf.BackColor = Color.WhiteSmoke;
                this.TXB_Km.BackColor = Color.WhiteSmoke;
            }
        }

        private void BTN_Selecionar_Cliente_Click(object sender, EventArgs e)
        {
            FRM_Buscar_Cliente_OS frm = FRM_Buscar_Cliente_OS.GetInstancia();
            frm.Show();
        }

        private void BTN_Novo_Cliente_Click(object sender, EventArgs e)
        {

        }

        private void FRM_OS_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Bloquear();
            this.botoes();
            this.cbBuscar.SelectedIndex = 0;
            this.Dados_Remetente();
            this.Numeracao_Automatica();
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

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.TXB_Marca.Focus();
            this.Total_Geral = 0;
            this.DGV_Prod_Serv.DataSource = null;
            this.ComboTecnico();
            this.ComboEquipamento();
            this.CB_Auto_Cliente.SelectedIndex = 0;
            this.CB_Estado_OS.SelectedIndex = 0;
            this.CB_Tipo_OS.SelectedIndex = 0;
            this.TXB_Acessorios.ReadOnly = false; 
            this.TXB_Parafusos_Faltando.ReadOnly = false;
            this.TXB_Partes_Quebradas.ReadOnly = false;
            this.TXB_Arranhoes.ReadOnly = false;
            this.TXB_Outros.ReadOnly = false;
            this.TXB_Data_Entrada.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy  HH:mm"));

            string Config_Num_Auto = this.DT_Num_Auto.Rows[0][3].ToString();

            if (Config_Num_Auto == "SIM")
            {
                //Incrementando para gerar novo número de venda
                Auxiliar_NA++;

                //passado novo numero de venda para o TextBox
                this.label3.Text = Convert.ToString(Auxiliar_NA);
            }
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                bool Trava = true;
                if (this.CB_Tipo_OS.Text.Equals("ELETRO-ELETRÔNICOS"))
                {
                    if (this.CB_Tipo_OS.Text == string.Empty || this.CB_Tecnico.Text == string.Empty || this.TXB_Cliente.Text == string.Empty || this.CB_Tipo_Equipamento.Text == string.Empty || this.TXB_Marca.Text == string.Empty || this.TXB_Modelo.Text == string.Empty || this.TXB_Cor.Text == string.Empty || this.TXB_Acessorios.Text == string.Empty)
                    {
                        Trava = false;
                        MensagemErro("Preencha todos os campos obrigatórios.");
                        this.Alerta_Campos_Obrigatorios_Eletro();
                    }
                }
                else
                {
                    if (this.CB_Tipo_OS.Text == string.Empty || this.CB_Tecnico.Text == string.Empty || this.TXB_Cliente.Text == string.Empty || this.CB_Tipo_Equipamento.Text == string.Empty || this.TXB_Marca.Text == string.Empty || this.TXB_Modelo.Text == string.Empty || this.TXB_Cor.Text == string.Empty || this.TXB_Placa.Text == string.Empty || this.CB_Uf.Text == string.Empty || this.TXB_Km.Text == string.Empty)
                    {
                        Trava = false;
                        MensagemErro("Preencha todos os campos obrigatórios.");
                        this.Alerta_Campos_Obrigatorios_Automotivo();
                    }
                }
                if (Trava)
                {
                    if (this.eNovo)
                    {
                        if (this.DGV_Prod_Serv.DataSource == null)
                        {
                            resp = NOS.Inserir_OS(idremetente, DT_Data_Inicial.Value, Convert.ToInt32(label3.Text), CB_Tipo_OS.Text, IdCliente, Convert.ToInt32(CB_Tecnico.SelectedValue), Convert.ToInt32(CB_Tipo_Equipamento.SelectedValue), TXB_Marca.Text,
                            TXB_Modelo.Text, TXB_Num_Serie.Text, TXB_Cor.Text, TXB_Senha.Text, TXB_Placa.Text, CB_Uf.Text, TXB_Km.Text, TXB_Obs_Cliente.Text, TXB_Diagnostico.Text, CB_Auto_Cliente.Text, CB_Estado_OS.Text, Convert.ToDateTime(TXB_Data_Entrada.Text),
                            TXB_Data_Auto_Cliente.Text, TXB_Data_Pronto.Text, TXB_Data_Retirada.Text, this.Total_Geral, this.TXB_Previsao_Entrega.Text, this.TXB_Acessorios.Text, this.TXB_Parafusos_Faltando.Text, this.TXB_Partes_Quebradas.Text, this.TXB_Arranhoes.Text, this.TXB_Outros.Text);
                        }
                        else
                        {
                            this.Total_Geral = 0;

                            resp = NOS.Inserir_Tudo(idremetente, DT_Data_Inicial.Value, Convert.ToInt32(label3.Text), CB_Tipo_OS.Text, IdCliente, Convert.ToInt32(CB_Tecnico.SelectedValue), Convert.ToInt32(CB_Tipo_Equipamento.SelectedValue), TXB_Marca.Text,
                            TXB_Modelo.Text, TXB_Num_Serie.Text, TXB_Cor.Text, TXB_Senha.Text, TXB_Placa.Text, CB_Uf.Text, TXB_Km.Text, TXB_Obs_Cliente.Text, TXB_Diagnostico.Text, CB_Auto_Cliente.Text, CB_Estado_OS.Text, Convert.ToDateTime(TXB_Data_Entrada.Text),
                            TXB_Data_Auto_Cliente.Text, TXB_Data_Pronto.Text, TXB_Data_Retirada.Text, this.Total_Geral, this.TXB_Previsao_Entrega.Text, this.TXB_Acessorios.Text, this.TXB_Parafusos_Faltando.Text, this.TXB_Partes_Quebradas.Text, this.TXB_Arranhoes.Text, this.TXB_Outros.Text, dtProd_Serv);
                        }
                    }
                    else
                    {
                        if (this.OS_Em_Branco)
                        {
                            resp = NOS.Editar_OS_Em_Branco(Convert.ToInt32(TXB_Id.Text), DT_Data_Inicial.Value, CB_Tipo_OS.Text, IdCliente, Convert.ToInt32(CB_Tecnico.SelectedValue), Convert.ToInt32(CB_Tipo_Equipamento.SelectedValue), TXB_Marca.Text,
                            TXB_Modelo.Text, TXB_Num_Serie.Text, TXB_Cor.Text, TXB_Senha.Text, TXB_Placa.Text, CB_Uf.Text, TXB_Km.Text, TXB_Obs_Cliente.Text, TXB_Diagnostico.Text, CB_Auto_Cliente.Text, CB_Estado_OS.Text, Convert.ToDateTime(TXB_Data_Entrada.Text),
                            TXB_Data_Auto_Cliente.Text, TXB_Data_Pronto.Text, TXB_Data_Retirada.Text, this.TXB_Previsao_Entrega.Text, this.TXB_Acessorios.Text, this.TXB_Parafusos_Faltando.Text, this.TXB_Partes_Quebradas.Text, this.TXB_Arranhoes.Text, this.TXB_Outros.Text);

                            this.BTN_Adicionar_Produtos_Servicos.Enabled = true;
                        }
                        else
                        {
                            resp = NOS.Editar(Convert.ToInt32(TXB_Id.Text), DT_Data_Inicial.Value, CB_Tipo_OS.Text, IdCliente, Convert.ToInt32(CB_Tecnico.SelectedValue), Convert.ToInt32(CB_Tipo_Equipamento.SelectedValue), TXB_Marca.Text,
                            TXB_Modelo.Text, TXB_Num_Serie.Text, TXB_Cor.Text, TXB_Senha.Text, TXB_Placa.Text, CB_Uf.Text, TXB_Km.Text, TXB_Obs_Cliente.Text, TXB_Diagnostico.Text, CB_Auto_Cliente.Text, CB_Estado_OS.Text, Convert.ToDateTime(TXB_Data_Entrada.Text),
                            TXB_Data_Auto_Cliente.Text, TXB_Data_Pronto.Text, TXB_Data_Retirada.Text, this.TXB_Previsao_Entrega.Text);
                        }
                    }

                    if (resp.Equals("Ok"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOk("Registro salvo com sucesso");
                            
                            DialogResult Opcao;
                            Opcao = MessageBox.Show("Deseja imprimir a ordem de serviço e seu respectivo comprovante de abertura?", "WE System Evolution", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (Opcao == DialogResult.Yes)
                            {
                                DataTable TBL_Dados_OS = NOS.Mostrar();
                                int idos = Convert.ToInt32(TBL_Dados_OS.Rows[0][0]);
                                string tipo_os = TBL_Dados_OS.Rows[0][3].ToString();

                                if (tipo_os.Equals("ELETRO-ELETRÔNICOS"))
                                {
                                    FRM_Ordem_Servico_Preenchida_Eletro_Print_Master frm = FRM_Ordem_Servico_Preenchida_Eletro_Print_Master.GetInstancia();
                                    frm.IdOS = idos;
                                    frm.Show();
                                }
                                else
                                {
                                    FRM_Ordem_Servico_Preenchida_Automotivo_Print_Master frm = FRM_Ordem_Servico_Preenchida_Automotivo_Print_Master.GetInstancia();
                                    frm.IdOS = idos;
                                    frm.Show();
                                }
                            }
                        }
                        else
                        {
                            this.MensagemOk("Atualização efetuada com sucesso");
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
                    this.TXB_Acessorios.ReadOnly = true;
                    this.TXB_Parafusos_Faltando.ReadOnly = true;
                    this.TXB_Partes_Quebradas.ReadOnly = true;
                    this.TXB_Arranhoes.ReadOnly = true;
                    this.TXB_Outros.ReadOnly = true;
                    this.Mostrar();
                    this.Alerta_Campos_Obrigatorios_Eletro();
                    this.Alerta_Campos_Obrigatorios_Automotivo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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

        private void DGV_Prod_Serv_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.MoveNext();
            this.DGV_Prod_Serv.CurrentRow.Cells[3].ReadOnly = false;
        }

        private void FRM_OS_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios_Eletro();
            this.Alerta_Campos_Obrigatorios_Automotivo();
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.Total_Geral = 0;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios_Eletro();
            this.Alerta_Campos_Obrigatorios_Automotivo();
        }

        private void BTN_Adicionar_Produtos_Servicos_Click(object sender, EventArgs e)
        {
            this.CB_Auto_Cliente.SelectedIndex = 1;
            this.DGV_Prod_Serv.Focus();

            this.CriarTabela();
            this.CriarLinha();

            int index = DGV_Prod_Serv.CurrentRow.Index;
            DGV_Prod_Serv.CurrentCell = DGV_Prod_Serv.Rows[index].Cells[2];
        }

        private void DGV_Prod_Serv_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void CHK_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_Selecionar.Checked)
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
                            Resp = NOS.Excluir(Convert.ToInt32(Codigo));

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
                    this.CHK_Selecionar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataLista_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Nome das colunas
            this.dataLista.Columns[2].HeaderText = "Data";
            this.dataLista.Columns[3].HeaderText = "OS";
            this.dataLista.Columns[4].HeaderText = "Tipo";
            this.dataLista.Columns[7].HeaderText = "Cliente";
            this.dataLista.Columns[18].HeaderText = "Marca";
            this.dataLista.Columns[26].HeaderText = "Diagnóstico";
            this.dataLista.Columns[27].HeaderText = "Autorização";
            this.dataLista.Columns[28].HeaderText = "Status Geral";
            this.dataLista.Columns[29].HeaderText = "Entrada em:";
            this.dataLista.Columns[33].HeaderText = "Total";
        }

        private void BTN_Atualizar_Click(object sender, EventArgs e)
        {
            FRM_Opcoes_Atualizar_OS frm = FRM_Opcoes_Atualizar_OS.GetInstancia();
            frm.idos = this.TXB_Id.Text;
            frm.num_os = this.label3.Text;
            frm.ShowDialog();
        }

        private void DGV_Prod_Serv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.DGV_Prod_Serv.Columns[2].HeaderText = "Quant.";
            this.DGV_Prod_Serv.Columns[3].HeaderText = "Descrição";
            this.DGV_Prod_Serv.Columns[4].HeaderText = "Valor Unit.";
        }

        private void CB_Tipo_OS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Tipo_OS.Text == "AUTOMOTIVO")
            {
                this.TXB_Placa.ReadOnly = false;
                this.CB_Uf.Enabled = true;
                this.TXB_Km.ReadOnly = false;
                this.TXB_Num_Serie.ReadOnly = true;
                this.TXB_Senha.ReadOnly = true;
                this.TXB_Acessorios.ReadOnly = true;
                this.TXB_Parafusos_Faltando.ReadOnly = true;
                this.CB_Uf.SelectedIndex = 21;
            }
            else
            {
                this.TXB_Placa.ReadOnly = true;
                this.CB_Uf.Enabled = false;
                this.TXB_Km.ReadOnly = true;
                this.TXB_Num_Serie.ReadOnly = false;
                this.TXB_Senha.ReadOnly = false;
                this.TXB_Acessorios.ReadOnly = false;
                this.TXB_Parafusos_Faltando.ReadOnly = false;
                this.CB_Uf.Text = string.Empty;
            }
        }

        private void CB_Auto_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Auto_Cliente.Text == "APROVADO" || CB_Auto_Cliente.Text == "REPROVADO")
            {
                this.TXB_Data_Auto_Cliente.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy  HH:mm"));
            }
        }

        private void CB_Estado_OS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Estado_OS.Text == "PRONTO")
            {
                this.TXB_Data_Pronto.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy  HH:mm"));
            }
            else if (CB_Estado_OS.Text == "EQUIP. RETIRADO")
            {
                this.TXB_Data_Retirada.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy  HH:mm"));
            }
        }

        private void DGV_Prod_Serv_KeyUp(object sender, KeyEventArgs e)
        {
            // Selecionando produto atraves do codigo de barras
            this.Selecionar_Produto_Codigo_Barra();

            if (this.DGV_Select_Prod_Cod_Barra.Rows.Count == 1)
            {
                if (this.DGV_Prod_Serv.CurrentRow.Cells[3].Selected && e.KeyCode == Keys.Enter)
                {
                    // Pegando Dados
                    int idproduto = Convert.ToInt32(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[0].Value);
                    string descricao = Convert.ToString(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[1].Value);
                    decimal preco_venda = Convert.ToDecimal(this.DGV_Select_Prod_Cod_Barra.Rows[0].Cells[2].Value);

                    string valor;

                    bool salvar = true;
                    foreach (DataGridViewRow linha in DGV_Prod_Serv.Rows)
                    {
                        if (linha.Cells[1].Value.Equals(idproduto))
                        {
                            salvar = false;

                            // Capturando linha a ser atualizada
                            int row_atual = linha.Index;

                            // Capturando quantidade atual
                            decimal qtd = Convert.ToDecimal(DGV_Prod_Serv.Rows[row_atual].Cells[2].Value);

                            // inserindo quantidade atualizada
                            DGV_Prod_Serv.Rows[row_atual].Cells[2].Value = qtd + 1;

                            // Tranferindo quantidade atualizada para variavel
                            decimal qtd_atual = Convert.ToDecimal(DGV_Prod_Serv.Rows[row_atual].Cells[2].Value);

                            // Capturando preço de venda atual
                            decimal preco_venda_atual = Convert.ToDecimal(DGV_Prod_Serv.Rows[row_atual].Cells[4].Value);

                            // Analisando situação
                            if (preco_venda_atual == preco_venda)
                            {
                                // Calculando novo subtotal
                                decimal novo_subtotal = qtd_atual * preco_venda;
                                this.Total_Geral = 0;
                                DGV_Prod_Serv.Rows[row_atual].Cells[5].Value = novo_subtotal;
                            }
                            else
                            {
                                // Calculando novo subtotal
                                decimal novo_subtotal = qtd_atual * preco_venda_atual;
                                this.Total_Geral = 0;
                                DGV_Prod_Serv.Rows[row_atual].Cells[5].Value = novo_subtotal;
                            }

                            // Calculando novo total geral
                            for (int i = 0; i <= DGV_Prod_Serv.RowCount - 1; i++)
                            {
                                if (Convert.ToString(DGV_Prod_Serv.Rows[i].Cells[5].Value) != "")
                                {
                                    this.Total_Geral += Convert.ToDecimal(DGV_Prod_Serv.Rows[i].Cells[5].Value);
                                }
                            }
                            TXB_Total_Geral.Text = this.Total_Geral.ToString("C");
                            DGV_Prod_Serv.CurrentRow.Cells[3].Value = "";
                        }
                    }
                    if (salvar)
                    {
                        // Exibindo Dados no Grid Atualizador Conforme situação
                        if (this.DGV_Prod_Serv.CurrentRow.Cells[2].Value.ToString() == "")
                        {
                            this.DGV_Prod_Serv.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Prod_Serv.CurrentRow.Cells[2].Value = 1;
                            this.DGV_Prod_Serv.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Prod_Serv.CurrentRow.Cells[4].Value = preco_venda;
                        }
                        else
                        {
                            this.DGV_Prod_Serv.CurrentRow.Cells[1].Value = idproduto;
                            this.DGV_Prod_Serv.CurrentRow.Cells[3].Value = descricao;
                            this.DGV_Prod_Serv.CurrentRow.Cells[4].Value = preco_venda;
                        }


                        int index = this.DGV_Prod_Serv.CurrentRow.Index;
                        this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[4];

                        if (DGV_Prod_Serv.CurrentRow.Cells[4].Selected)
                        {
                            decimal cell1 = Convert.ToDecimal(DGV_Prod_Serv.CurrentRow.Cells[2].Value);

                            decimal cell2 = Convert.ToDecimal(DGV_Prod_Serv.CurrentRow.Cells[4].Value);

                            if (cell1.ToString() != "" && cell2.ToString() != "")
                            {
                                DGV_Prod_Serv.CurrentRow.Cells[5].Value = cell1 * cell2;

                                valor = "";
                                this.Total_Geral = 0;

                                if (Convert.ToString(DGV_Prod_Serv.CurrentRow.Cells[5].Value) != "")
                                {
                                    valor = DGV_Prod_Serv.CurrentRow.Cells[5].Value.ToString();

                                    if (!valor.Equals(""))
                                    {
                                        for (int i = 0; i <= DGV_Prod_Serv.RowCount - 1; i++)
                                        {
                                            if (Convert.ToString(DGV_Prod_Serv.Rows[i].Cells[5].Value) != "")
                                            {
                                                this.Total_Geral += Convert.ToDecimal(DGV_Prod_Serv.Rows[i].Cells[5].Value);
                                            }
                                        }
                                        TXB_Total_Geral.Text = this.Total_Geral.ToString("C");

                                        this.CriarLinha();
                                        index = this.DGV_Prod_Serv.CurrentRow.Index + 1;
                                        this.DGV_Prod_Serv.CurrentCell = this.DGV_Prod_Serv.Rows[index].Cells[2];
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void FRM_OS_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert && this.DGV_Prod_Serv.CurrentRow.Cells[3].Selected)
            {
                this.DGV_Prod_Serv.CurrentRow.Cells[3].ReadOnly = true;

                FRM_Buscar_Produto_OS frm = FRM_Buscar_Produto_OS.GetInstancia();
                frm.txtBuscar.Text = this.DGV_Prod_Serv.CurrentRow.Cells[3].Value.ToString();
                frm.ShowDialog();
            }


            if (this.DGV_Prod_Serv.Rows.Count > 0)
            {
                if (this.eNovo || this.eEditar)
                {
                    if (this.DGV_Prod_Serv.CurrentRow.Cells[4].Selected && Convert.ToString(this.DGV_Prod_Serv.CurrentRow.Cells[2].Value) != "" && Convert.ToString(this.DGV_Prod_Serv.CurrentRow.Cells[4].Value) != "")
                    {
                        decimal cell1 = Convert.ToDecimal(DGV_Prod_Serv.CurrentRow.Cells[2].Value);

                        decimal cell2 = Convert.ToDecimal(DGV_Prod_Serv.CurrentRow.Cells[4].Value);

                        if (cell1.ToString() != "" && cell2.ToString() != "")
                        {
                            DGV_Prod_Serv.CurrentRow.Cells[5].Value = cell1 * cell2;

                            string valor = "";
                            this.Total_Geral = 0;

                            if (Convert.ToString(DGV_Prod_Serv.CurrentRow.Cells[5].Value) != "")
                            {
                                valor = DGV_Prod_Serv.CurrentRow.Cells[5].Value.ToString();

                                if (!valor.Equals(""))
                                {
                                    for (int i = 0; i <= DGV_Prod_Serv.RowCount - 1; i++)
                                    {
                                        if (Convert.ToString(DGV_Prod_Serv.Rows[i].Cells[5].Value) != "")
                                        {
                                            this.Total_Geral += Convert.ToDecimal(DGV_Prod_Serv.Rows[i].Cells[5].Value);
                                        }
                                    }
                                    TXB_Total_Geral.Text = this.Total_Geral.ToString("C");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal valor;
            DateTime dt;
            string endereco, bairro, cidade, cep, uf;

            endereco = Convert.ToString(this.dataLista.CurrentRow.Cells["endereco"].Value);
            bairro = Convert.ToString(this.dataLista.CurrentRow.Cells["bairro"].Value);
            cidade = Convert.ToString(this.dataLista.CurrentRow.Cells["cidade"].Value);
            cep = Convert.ToString(this.dataLista.CurrentRow.Cells["cep"].Value);
            uf = Convert.ToString(this.dataLista.CurrentRow.Cells["uf"].Value);

            this.TXB_Id.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idos"].Value);
            this.DT_Data_Inicial.Value = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            this.label3.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_os"].Value);
            this.CB_Tipo_OS.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo"].Value);
            this.CB_Tecnico.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Técnico"].Value);
            this.IdCliente = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idcliente"].Value);
            this.TXB_Cliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nome_completo"].Value);
            this.TXB_Cpf.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_cpf"].Value);
            this.TXB_Rg.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_rg"].Value);
            this.TXB_Endereco_Completo.Text = endereco + " - " + bairro + " - " + cidade + " - " + cep + " - " + uf;
            this.TXB_Celular.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["celular"].Value);
            this.CB_Tipo_Equipamento.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Equipamento"].Value);
            this.TXB_Marca.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["marca"].Value);
            this.TXB_Modelo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["modelo"].Value);
            this.TXB_Num_Serie.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_serie"].Value);
            this.TXB_Cor.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cor"].Value);
            this.TXB_Senha.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["senha"].Value);
            this.TXB_Placa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["placa"].Value);
            this.CB_Uf.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["uf_placa"].Value);
            this.TXB_Km.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["km"].Value);
            this.TXB_Obs_Cliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["observacoes_cliente"].Value);
            this.TXB_Diagnostico.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["diagnostico"].Value);
            this.CB_Auto_Cliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["auto_cliente"].Value);
            this.CB_Estado_OS.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["estado_os"].Value);

            dt = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data_entrada"].Value);
            this.TXB_Data_Entrada.Text = dt.ToString("dd/MM/yyyy  HH:mm");

            this.TXB_Data_Auto_Cliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["data_auto_cliente"].Value);
            this.TXB_Data_Pronto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["data_pronto"].Value);
            this.TXB_Data_Retirada.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["data_retirada"].Value);

            valor = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["total"].Value);
            this.TXB_Total_Geral.Text = valor.ToString("C");

            this.TXB_Previsao_Entrega.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["previsao_entrega"].Value);
            this.TXB_Acessorios.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["entrada_com_acessorios"].Value);
            this.TXB_Parafusos_Faltando.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["parafusos_faltando"].Value);
            this.TXB_Partes_Quebradas.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["partes_quebradas"].Value);
            this.TXB_Arranhoes.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["arranhados"].Value);
            this.TXB_Outros.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["outros"].Value);

            this.MostrarDetalhes();
            this.BTN_Cancelar.Enabled = true;
            this.BTN_Atualizar.Enabled = true;
            this.DGV_Prod_Serv.ReadOnly = true;
            this.tabControl1.SelectedIndex = 1;
        }

        private void BTN_Assist_Impressao_Click(object sender, EventArgs e)
        {
            FRM_Assistente_Impressao_Ordem_Serviço frm = FRM_Assistente_Impressao_Ordem_Serviço.GetInstancia();
            frm.Show();
        }

        private void BTN_Equipamentos_Click(object sender, EventArgs e)
        {
            FRM_Equipamentos frm = FRM_Equipamentos.GetInstancia();
            frm.ShowDialog();
        }

        private void BTN_Tecnicos_Click(object sender, EventArgs e)
        {
            FRM_Tecnico frm = FRM_Tecnico.GetInstancia();
            frm.ShowDialog();
        }

        private void BTN_Tarefas_OS_Em_Branco_Click(object sender, EventArgs e)
        {
            FRM_Tarefas_OS_Em_Branco frm = FRM_Tarefas_OS_Em_Branco.GetInstancia();
            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbBuscar.Text.Equals("Buscar pelo Cliente"))
            {
                this.Buscar_Pelo_Cliente();
            }
            else
            {
                this.Buscar_Pelo_Num_OS();
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

        private void TXB_Previsao_Entrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == true)
            {
                switch (TXB_Previsao_Entrega.TextLength)
                {
                    case 0:
                        this.TXB_Previsao_Entrega.Text = "";
                        break;
                    case 2:
                        this.TXB_Previsao_Entrega.Text += "/";
                        this.TXB_Previsao_Entrega.SelectionStart = 4;
                        break;
                    case 5:
                        this.TXB_Previsao_Entrega.Text += "/";
                        this.TXB_Previsao_Entrega.SelectionStart = 7;
                        break;
                }
            }
        }
    }
}
