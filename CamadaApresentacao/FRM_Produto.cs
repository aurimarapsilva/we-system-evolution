using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using CamadaNegocio;
using BarcodeLib;

namespace CamadaApresentacao
{
    public partial class FRM_Produto : Form
    {
        private string tipo_produto;
        private string categoria;
        private string unid_medida;
        private string fornecedor;
        private int produto;
        public int idfuncionario;
        private bool eNovo = false;
        private bool eEditar = false;
        private DataTable DT_Dados_Remetente;
        private DataTable DT_Numeracao_Auto;
        // Variavel para receber data Atual
        private DateTime Data_Atual;

        // Variavel para receber IdRemetente
        private int idremetente;

        private void Dados_Remetente()
        {
            // Recupernado dados
            this.DT_Dados_Remetente = NRemetente.Mostrar();

            // Adicionado dados a variavel para gerar venda
            this.idremetente = Convert.ToInt32(this.DT_Dados_Remetente.Rows[0][0]);
        }


        // Variavel para receber IdNumeracao_Auto
        private int idnumeracao_auto;

        private void Dados_TBLNumeracao_Auto()
        {
            // Recupernado dados
            this.DT_Numeracao_Auto = NNumeracao_Auto.Mostrar();

            // Adicionado dados a variavel para gerar venda
            this.idnumeracao_auto = Convert.ToInt32(this.DT_Numeracao_Auto.Rows[0][0]);
            
        }

        //Codificação para Evitar de abrir o mesmo form 2X.
        private static FRM_Produto _Instancia;

        public static FRM_Produto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FRM_Produto();
            }
            return _Instancia;
        }

        public FRM_Produto()
        {
            InitializeComponent();
            this.TT_Mensagem.SetToolTip(this.TXB_Descricao, "Descreva o produto.");
            this.TT_Mensagem.SetToolTip(this.PX_Imagem, "Insira uma imagem para o produto.");
            
            this.TT_Mensagem.SetToolTip(this.TXB_Corredor_Dep, "Informe um corredor no deposito.");
            this.TT_Mensagem.SetToolTip(this.TXB_Prateleira_Dep, "Informe uma prateleira no deposito.");
            this.TT_Mensagem.SetToolTip(this.TXB_Corredor_Expo, "Informe um corredor na área de exposição do produto.");
            this.TT_Mensagem.SetToolTip(this.TXB_Prateleira_Expo, "Informe uma prateleira na área de exposição do produto.");
            this.TT_Mensagem.SetToolTip(this.TXB_Preco_Venda, "Informe o preço de venda.");
            this.TT_Mensagem.SetToolTip(this.TXB_Quant_Atual, "Informe a quantidade ideal.");
            this.ComboCategoria();
            this.ComboFornecedor();
            this.ComboUnid_Medida();
            this.ComboTipo();
            this.TXB_Id.Visible = false;
            this.TXB_Codigo_Barras.Text = string.Empty;
            this.cbBuscar.SelectedIndex = 0;
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
            this.CB_Fornecedor.SelectedIndex = 0;
            this.CB_Tipo.SelectedIndex = 0;
            this.TXB_Codigo_Barras.Text = string.Empty;
            this.TXB_Descricao.Text = string.Empty;
            this.PX_Imagem.Image = global::CamadaApresentacao.Properties.Resources.DefaultImage;
            this.PXB_Cod_Bar.Image = global::CamadaApresentacao.Properties.Resources.No_BarCode_2;
            this.TXB_Corredor_Expo.Text = string.Empty;
            this.TXB_Prateleira_Expo.Text = string.Empty;
            this.TXB_Corredor_Dep.Text = string.Empty;
            this.TXB_Prateleira_Dep.Text = string.Empty;
            this.TXB_Preco_Custo.Text = string.Empty;
            this.TXB_Preco_Venda.Text = string.Empty;
            this.TXB_Lucro.Text = string.Empty;
            this.TXB_Margem.Text = string.Empty;
            this.TXB_Quant_Atual.Text = string.Empty;
            this.TXB_Quant_Ideal.Text = string.Empty;
            this.TXB_Unid_Vendidas.Text = string.Empty;
            this.CHK_Habilitar.Checked = false;
            this.DT_Fabricacao.Text = string.Empty;
            this.DT_Vencimento.Text = string.Empty;

            this.TXB_Quant_Atual.BackColor = Color.WhiteSmoke;
            this.TXB_Quant_Atual.ForeColor = Color.Black;
        }

        //Habilitar os textBox
        private void Habilitar(bool valor)
        {
            this.CB_Tipo.Enabled = valor;
            this.TXB_Descricao.ReadOnly = !valor;
            this.CB_Fornecedor.Enabled = valor;
            this.CB_Categoria.Enabled = valor;
            this.CB_Unid_Medida.Enabled = valor;
            this.TXB_Corredor_Expo.ReadOnly = !valor;
            this.TXB_Prateleira_Expo.ReadOnly = !valor;
            this.TXB_Corredor_Dep.ReadOnly = !valor;
            this.TXB_Prateleira_Dep.ReadOnly = !valor;
            this.TXB_Preco_Venda.ReadOnly = !valor;
            this.TXB_Quant_Ideal.ReadOnly = !valor;
            this.CHK_Habilitar.Enabled = valor;
            this.CHK_Config.Enabled = valor;

            if (valor)
            {
                this.TXB_Descricao.BackColor = Color.White;
                this.TXB_Preco_Venda.BackColor = Color.White;
                this.TXB_Quant_Ideal.BackColor = Color.White;
            }
            else
            {
                this.TXB_Descricao.BackColor = Color.WhiteSmoke;
                this.TXB_Preco_Venda.BackColor = Color.WhiteSmoke;
                this.TXB_Quant_Ideal.BackColor = Color.WhiteSmoke;
            }
        }


        //Habilitar os Botões
        private void botoes()
        {
            if (this.eNovo || this.eEditar)
            {
                this.Habilitar(true);
                this.BTN_Novo.Enabled = false;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;
                this.BTN_Carregar_Image.Enabled = true;
                this.BTN_Limpar_imagem.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.BTN_Novo.Enabled = true;
                this.BTN_Editar.Enabled = false;
                this.BTN_Salvar.Enabled = false;
                this.BTN_Cancelar.Enabled = false;
                this.BTN_Carregar_Image.Enabled = false;
                this.BTN_Limpar_imagem.Enabled = false;
            }
        }




        //Metodo para Formtar Grid
        private void FormataGrid()
        {
            // Ocultar colunas do Grid
            this.DataLista.Columns[0].Visible = false;
            this.DataLista.Columns[1].Visible = false;
            this.DataLista.Columns[5].Visible = false;
            this.DataLista.Columns[6].Visible = false;
            this.DataLista.Columns[8].Visible = false;
            this.DataLista.Columns[20].Visible = false;
            this.DataLista.Columns[22].Visible = false;
            this.DataLista.Columns[23].Visible = false;

            // Nome das Colunas
            this.DataLista.Columns[2].HeaderText = "Tipo";
            this.DataLista.Columns[3].HeaderText = "Código";
            this.DataLista.Columns[4].HeaderText = "Descrição";
            this.DataLista.Columns[7].HeaderText = "Categoria";
            this.DataLista.Columns[9].HeaderText = "Unidade";
            this.DataLista.Columns[10].HeaderText = "Preço de Custo";
            this.DataLista.Columns[11].HeaderText = "Preço de Venda";
            this.DataLista.Columns[12].HeaderText = "Fabricação";
            this.DataLista.Columns[13].HeaderText = "Vencimento";
            this.DataLista.Columns[14].HeaderText = "Corredor Exposição";
            this.DataLista.Columns[15].HeaderText = "Prateleira Exposição";
            this.DataLista.Columns[16].HeaderText = "Corredor Deposito";
            this.DataLista.Columns[17].HeaderText = "Prateleira Deposito";
            this.DataLista.Columns[18].HeaderText = "Quant. Atual";
            this.DataLista.Columns[19].HeaderText = "Quant. Ideal";
            this.DataLista.Columns[21].HeaderText = "Fornecedor";

            //Formato das Colunas
            this.DataLista.Columns[10].DefaultCellStyle.Format = "c";
            this.DataLista.Columns[11].DefaultCellStyle.Format = "c";
        }



        // Mostrar no Data Grid 
        public void Mostrar()
        {
            this.DataLista.DataSource = NProduto.Mostrar();
            this.FormataGrid();
            LB_Total.Text = "Total de registros: " + Convert.ToString(DataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Mostrar Tudo";
        }


        // Buscar pelo nome 
        private void BuscarNome()
        {
            this.DataLista.DataSource = NProduto.BuscarNome(this.TXB_Buscar.Text);
            this.FormataGrid();
            LB_Total.Text = "Total de registros: " + Convert.ToString(DataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Descrição";
        }

        // Buscar pelo Codigo
        private void Buscar_Codigo()
        {
            this.DataLista.DataSource = NProduto.BuscarCodigo(this.TXB_Buscar.Text);
            this.FormataGrid();
            LB_Total.Text = "Total de registros: " + Convert.ToString(DataLista.Rows.Count);
            this.LB_Modo_Exibicao.Text = "Código";
        }


        public void ComboCategoria()
        {
            CB_Categoria.DataSource = NCategoria.Mostrar();
            CB_Categoria.ValueMember = "IdCategoria";
            CB_Categoria.DisplayMember = "nome";
        }

        private void ComboFornecedor()
        {
            CB_Fornecedor.DataSource = NFornecedor.Mostrar();
            CB_Fornecedor.ValueMember = "IdFornecedor";
            CB_Fornecedor.DisplayMember = "empresa";
        }


        public void ComboUnid_Medida()
        {
            CB_Unid_Medida.DataSource = NUnid_Medida.Mostrar();
            CB_Unid_Medida.ValueMember = "IdUnid_Medida";
            CB_Unid_Medida.DisplayMember = "unidade";
        }


        private void ComboTipo()
        {
            CB_Tipo.DataSource = NTipo_Produto.Mostrar();
            CB_Tipo.ValueMember = "Idtipo_produto";
            CB_Tipo.DisplayMember = "tipo";
        }


        private void StatusEstoque()
        {
            string atual = this.TXB_Quant_Atual.Text;
            string ideal = this.TXB_Quant_Ideal.Text;
            if (Convert.ToDecimal(atual) >= Convert.ToDecimal(ideal))
            {
                this.TXB_Quant_Atual.BackColor = Color.WhiteSmoke;
                this.TXB_Quant_Atual.ForeColor = Color.Green;
            }
            else
            {
                this.TXB_Quant_Atual.BackColor = Color.WhiteSmoke;
                this.TXB_Quant_Atual.ForeColor = Color.Red;
            }
        }

        private void Calculos_Financeiros()
        {
            decimal preco_custo = Convert.ToDecimal(this.TXB_Preco_Custo.Text);
            decimal preco_venda = Convert.ToDecimal(this.TXB_Preco_Venda.Text);
            decimal lucro = preco_venda - preco_custo;

            this.TXB_Lucro.Text = lucro.ToString();
        }


        private void Gerar_Codigo_Barras()
        {
            if (this.TXB_Codigo_Barras.Text != "")
            {
                Barcode Codigo = new Barcode();
                Codigo.IncludeLabel = true;
                this.PXB_Cod_Bar.Image = Codigo.Encode(TYPE.CODE128, this.TXB_Codigo_Barras.Text, Color.Black, Color.White, 165, 57);
            }
        }


        // Metodo Alerta de Campo Obrigatorio em Branco
        private void Alerta_Campos_Obrigatorios()
        {
            if (this.eNovo || this.eEditar)
            {
                this.TXB_Descricao.BackColor = Color.LemonChiffon;
                this.TXB_Preco_Venda.BackColor = Color.LemonChiffon;
                this.TXB_Quant_Ideal.BackColor = Color.LemonChiffon;
            }
            else
            {
                this.TXB_Descricao.BackColor = Color.WhiteSmoke;
                this.TXB_Preco_Venda.BackColor = Color.WhiteSmoke;
                this.TXB_Quant_Ideal.BackColor = Color.WhiteSmoke;
            }
        }

        private void FRM_Produto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
            this.CHK_Habilitar.Checked = false;
            this.DT_Fabricacao.Enabled = false;
            this.DT_Vencimento.Enabled = false;
            this.TXB_Preco_Custo.ReadOnly = true;
            this.TXB_Quant_Atual.ReadOnly = true;
            this.Dados_Remetente();
            this.Dados_TBLNumeracao_Auto();
            this.produto = Convert.ToInt32(DT_Numeracao_Auto.Rows[0][4]);
        }

        private void TXB_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (this.TXB_Buscar.Text.Equals(""))
            {
                this.BTN_Pesquisar.Enabled = false;
            }
            else
            {
                this.BTN_Pesquisar.Enabled = true;
            }
        }

        private void BTN_Novo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.TXB_Descricao.Focus();
            this.TXB_Preco_Custo.Text = "0,00";
            this.TXB_Quant_Atual.Text = "0";
            this.TXB_Unid_Vendidas.Text = "0";

            if (this.DT_Numeracao_Auto.Rows[0][5].ToString() == "SIM" && this.CHK_Config.Checked == true)
            {
                this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);
                this.produto++;

                this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
            }
        }

        private void BTN_Salvar_Click(object sender, EventArgs e)
        {

            try
            {
                string resp = "";
                if (this.TXB_Descricao.Text == string.Empty || this.TXB_Preco_Venda.Text == string.Empty || this.TXB_Quant_Ideal.Text == string.Empty)
                {
                    MensagemErro("Preencha todos os campos obrigatórios.");
                    this.Alerta_Campos_Obrigatorios();
                }
                else
                {
                    // Salvar Imagem do Produto
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.PX_Imagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imagem = ms.GetBuffer();

                    // Salvar Codigo de Barrras do Produto
                    this.Gerar_Codigo_Barras();

                    System.IO.MemoryStream ms2 = new System.IO.MemoryStream();
                    this.PXB_Cod_Bar.Image.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] BarCode = ms2.GetBuffer();

                    if (this.eNovo)
                    {
                        if (this.CHK_Habilitar.Checked)
                        {
                            resp = NProduto.Inserir(this.idremetente, this.idnumeracao_auto, Convert.ToInt32(this.CB_Tipo.SelectedValue), this.TXB_Codigo_Barras.Text, this.TXB_Descricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.CB_Categoria.SelectedValue), Convert.ToInt32(this.CB_Unid_Medida.SelectedValue), Convert.ToInt32(this.CB_Fornecedor.SelectedValue), Convert.ToDecimal(this.TXB_Preco_Custo.Text), Convert.ToDecimal(this.TXB_Preco_Venda.Text), this.DT_Fabricacao.Text, this.DT_Vencimento.Text, this.Data_Atual, "A VENCER", this.TXB_Corredor_Expo.Text, this.TXB_Prateleira_Expo.Text, this.TXB_Corredor_Dep.Text, this.TXB_Prateleira_Dep.Text, Convert.ToDecimal(this.TXB_Quant_Atual.Text), Convert.ToDecimal(this.TXB_Quant_Ideal.Text), Convert.ToDecimal(this.TXB_Unid_Vendidas.Text), BarCode);
                        }
                        else
                        {
                            resp = NProduto.Inserir(this.idremetente, this.idnumeracao_auto,  Convert.ToInt32(this.CB_Tipo.SelectedValue), this.TXB_Codigo_Barras.Text, this.TXB_Descricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.CB_Categoria.SelectedValue), Convert.ToInt32(this.CB_Unid_Medida.SelectedValue), Convert.ToInt32(this.CB_Fornecedor.SelectedValue), Convert.ToDecimal(this.TXB_Preco_Custo.Text), Convert.ToDecimal(this.TXB_Preco_Venda.Text), "INDETERMINADA", "INDETERMINADA", this.Data_Atual, "A VENCER", this.TXB_Corredor_Expo.Text, this.TXB_Prateleira_Expo.Text, this.TXB_Corredor_Dep.Text, this.TXB_Prateleira_Dep.Text, Convert.ToDecimal(this.TXB_Quant_Atual.Text), Convert.ToDecimal(this.TXB_Quant_Ideal.Text), Convert.ToDecimal(this.TXB_Unid_Vendidas.Text), BarCode);
                        }
                    }
                    else
                    {
                        if (this.CHK_Habilitar.Checked)
                        {
                            resp = NProduto.Editar(Convert.ToInt32(this.TXB_Id.Text), Convert.ToInt32(this.CB_Tipo.SelectedValue), this.TXB_Codigo_Barras.Text, this.TXB_Descricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.CB_Categoria.SelectedValue), Convert.ToInt32(this.CB_Unid_Medida.SelectedValue), Convert.ToInt32(this.CB_Fornecedor.SelectedValue), Convert.ToDecimal(this.TXB_Preco_Custo.Text), Convert.ToDecimal(this.TXB_Preco_Venda.Text), this.DT_Fabricacao.Text, this.DT_Vencimento.Text, this.TXB_Corredor_Expo.Text, this.TXB_Prateleira_Expo.Text, this.TXB_Corredor_Dep.Text, this.TXB_Prateleira_Dep.Text, Convert.ToDecimal(this.TXB_Quant_Atual.Text), Convert.ToDecimal(this.TXB_Quant_Ideal.Text), BarCode);
                        }
                        else
                        {
                            resp = NProduto.Editar(Convert.ToInt32(this.TXB_Id.Text), Convert.ToInt32(this.CB_Tipo.SelectedValue), this.TXB_Codigo_Barras.Text, this.TXB_Descricao.Text.Trim().ToUpper(), imagem, Convert.ToInt32(this.CB_Categoria.SelectedValue), Convert.ToInt32(this.CB_Unid_Medida.SelectedValue), Convert.ToInt32(this.CB_Fornecedor.SelectedValue), Convert.ToDecimal(this.TXB_Preco_Custo.Text), Convert.ToDecimal(this.TXB_Preco_Venda.Text), "INDETERMINADA", "INDETERMINADA", this.TXB_Corredor_Expo.Text, this.TXB_Prateleira_Expo.Text, this.TXB_Corredor_Dep.Text, this.TXB_Prateleira_Dep.Text, Convert.ToDecimal(this.TXB_Quant_Atual.Text), Convert.ToDecimal(this.TXB_Quant_Ideal.Text), BarCode);
                        }
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
                    this.CHK_Config.Checked = true;
                    this.Alerta_Campos_Obrigatorios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTN_Editar_Click(object sender, EventArgs e)
        {
            this.eEditar = true;
            this.botoes();
            this.Habilitar(true);
            this.BTN_Cancelar.Enabled = true;
            this.produto = Convert.ToInt32(this.TXB_Id.Text);
        }

        private void BTN_Cancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.Habilitar(false);
            this.botoes();
            this.Limpar();
            this.Alerta_Campos_Obrigatorios();
        }

        private void DataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataLista.Columns["Deletar"].Index)
            {
                DataGridViewCheckBoxCell chkDeletar = (DataGridViewCheckBoxCell)DataLista.Rows[e.RowIndex].Cells["Deletar"];
                chkDeletar.Value = !Convert.ToBoolean(chkDeletar.Value);
            }
        }

        private void CHKB_Deletar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKB_Deletar.Checked)
            {
                this.DataLista.Columns[0].Visible = true;
                this.BTN_Deletar.Enabled = true;
            }
            else
            {
                this.DataLista.Columns[0].Visible = false;
                this.BTN_Deletar.Enabled = false;
            }
        }

        private void BTN_Carregar_Image_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
                this.PX_Imagem.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void BTN_Limpar_imagem_Click(object sender, EventArgs e)
        {
            this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            this.PX_Imagem.Image = global::CamadaApresentacao.Properties.Resources.DefaultImage;
        }

        private void BTN_Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Realmente deseja apagar este registro?", "WE System Evolution", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in DataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NProduto.Excluir(Convert.ToInt32(Codigo));

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
                    this.CHKB_Deletar.Checked = false;
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CHK_Habilitar_CheckedChanged(object sender, EventArgs e)
        {
            

            if (CHK_Habilitar.Checked)
            {
                this.DT_Fabricacao.Enabled = true;
                this.DT_Vencimento.Enabled = true;
            }
            else
            {
                this.DT_Fabricacao.Enabled = false;
                this.DT_Vencimento.Enabled = false;
            }
        }

        private void FRM_Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
            this.Alerta_Campos_Obrigatorios();
        }

        private void DT_Vencimento_ValueChanged(object sender, EventArgs e)
        {
            this.Data_Atual = this.DT_Vencimento.Value;
            this.Data_Atual = this.Data_Atual.AddDays(-30);
        }

        private void CB_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CHK_Config.Checked)
            {
                if (this.eNovo)
                {
                    this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
                else
                {
                    this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                    this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                    this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                    this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
            }
            if (this.eNovo)
            {
                if (this.CB_Tipo.Text.Equals("SERVIÇO"))
                {
                    this.TXB_Quant_Atual.Text = "1";
                    this.TXB_Quant_Ideal.Text = "1";
                    this.TXB_Quant_Ideal.ReadOnly = true;
                    this.PX_Imagem.Image = global::CamadaApresentacao.Properties.Resources.servicos2;
                    this.CB_Categoria.SelectedIndex = 3;
                    this.CB_Unid_Medida.SelectedIndex = 21;
                    this.TXB_Descricao.Focus();
                }
                else
                {
                    this.TXB_Quant_Atual.Text = "0";
                    this.TXB_Quant_Ideal.Text = string.Empty;
                    this.TXB_Quant_Ideal.ReadOnly = false;
                }
            }
        }

        private void CB_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CHK_Config.Checked)
            {
                if (this.eNovo)
                {
                    this.categoria = Convert.ToString(CB_Categoria.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
                else
                {
                    this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                    this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                    this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                    this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
            }
        }

        private void CB_Unid_Medida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CHK_Config.Checked)
            {
                if (this.eNovo)
                {
                    this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
                else
                {
                    this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                    this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                    this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                    this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
            }
        }

        private void CB_Fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CHK_Config.Checked)
            {
                if (this.eNovo)
                {
                    this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + "0" + categoria + "0" + fornecedor + "0" + produto;
                }
                else
                {
                    this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                    this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                    this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                    this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                    this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + produto;
                }
            }
        }

        private void CHK_Config_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CHK_Config.Checked)
            {
                this.tipo_produto = Convert.ToString(CB_Tipo.SelectedValue);
                this.categoria = Convert.ToString(CB_Categoria.SelectedValue);
                this.unid_medida = Convert.ToString(CB_Unid_Medida.SelectedValue);
                this.fornecedor = Convert.ToString(CB_Fornecedor.SelectedValue);

                this.TXB_Codigo_Barras.Text = tipo_produto + categoria + unid_medida + fornecedor + this.produto;
                this.TXB_Codigo_Barras.ReadOnly = true;
            }
            else
            {
                this.TXB_Codigo_Barras.Text = string.Empty;
                this.TXB_Codigo_Barras.ReadOnly = false;
                this.TXB_Codigo_Barras.Focus();
            }
        }

        private void DataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CHK_Config.Checked = false;

            if (Convert.ToString(this.DataLista.CurrentRow.Cells["data_fab"].Value) == "INDETERMINADA" || Convert.ToString(this.DataLista.CurrentRow.Cells["data_venc"].Value) == "INDETERMINADA")
            {
                this.TXB_Id.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["idproduto"].Value);
                this.CB_Tipo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["tipo"].Value);
                this.CB_Fornecedor.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["empresa"].Value);
                this.TXB_Codigo_Barras.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["codigo"].Value);
                this.TXB_Descricao.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["descricao"].Value);

                // Imagem do Produto
                byte[] imageBuffer = (byte[])this.DataLista.CurrentRow.Cells["imagem"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                this.PX_Imagem.Image = Image.FromStream(ms);
                this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;

                // Código de Barras
                byte[] imageBuffer2 = (byte[])this.DataLista.CurrentRow.Cells["barcode"].Value;
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2);
                this.PXB_Cod_Bar.Image = Image.FromStream(ms2);
                this.PXB_Cod_Bar.SizeMode = PictureBoxSizeMode.StretchImage;

                this.CB_Categoria.SelectedValue = Convert.ToString(this.DataLista.CurrentRow.Cells["idcategoria"].Value);
                this.CB_Unid_Medida.SelectedValue = Convert.ToString(this.DataLista.CurrentRow.Cells["idunid_medida"].Value);
                this.TXB_Preco_Custo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["preco_custo"].Value);
                this.TXB_Preco_Venda.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["preco_venda"].Value);

                decimal preco_venda = Convert.ToDecimal(this.TXB_Preco_Venda.Text);
                decimal preco_custo = Convert.ToDecimal(this.TXB_Preco_Custo.Text);
                decimal lucro = preco_venda - preco_custo;
                decimal margem = (lucro * 100) / (preco_venda);
                decimal margem_arredondada = Math.Round(Convert.ToDecimal(margem.ToString()), 2);
                this.TXB_Lucro.Text = lucro.ToString();
                this.TXB_Margem.Text = margem_arredondada.ToString();

                this.TXB_Corredor_Expo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["corredor_expo"].Value);
                this.TXB_Prateleira_Expo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["prateleira_expo"].Value);
                this.TXB_Corredor_Dep.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["corredor_dep"].Value);
                this.TXB_Prateleira_Dep.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["prateleira_dep"].Value);
                this.TXB_Quant_Atual.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["quant_atual"].Value);
                this.TXB_Quant_Ideal.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["quant_ideal"].Value);
                this.TXB_Unid_Vendidas.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["unid_vendidas"].Value);

                this.BTN_Editar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;

                this.StatusEstoque();
                this.tabControl1.SelectedIndex = 1;
            }
            else
            {
                this.TXB_Id.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["idproduto"].Value);
                this.CB_Tipo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["tipo"].Value);
                this.CB_Fornecedor.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["empresa"].Value);
                this.TXB_Codigo_Barras.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["codigo"].Value);
                this.TXB_Descricao.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["descricao"].Value);

                // Imagem do Produto
                byte[] imageBuffer = (byte[])this.DataLista.CurrentRow.Cells["imagem"].Value;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBuffer);
                this.PX_Imagem.Image = Image.FromStream(ms);
                this.PX_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;

                // Código de Barras
                byte[] imageBuffer2 = (byte[])this.DataLista.CurrentRow.Cells["barcode"].Value;
                System.IO.MemoryStream ms2 = new System.IO.MemoryStream(imageBuffer2);
                this.PXB_Cod_Bar.Image = Image.FromStream(ms2);
                this.PXB_Cod_Bar.SizeMode = PictureBoxSizeMode.StretchImage;

                this.CB_Categoria.SelectedValue = Convert.ToString(this.DataLista.CurrentRow.Cells["idcategoria"].Value);
                this.CB_Unid_Medida.SelectedValue = Convert.ToString(this.DataLista.CurrentRow.Cells["idunid_medida"].Value);
                this.CB_Fornecedor.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["empresa"].Value);
                this.TXB_Preco_Custo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["preco_custo"].Value);
                this.TXB_Preco_Venda.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["preco_venda"].Value);

                decimal preco_venda = Convert.ToDecimal(this.TXB_Preco_Venda.Text);
                decimal preco_custo = Convert.ToDecimal(this.TXB_Preco_Custo.Text);
                decimal lucro = preco_venda - preco_custo;
                decimal margem = (lucro * 100) / (preco_venda);
                decimal margem_arredondada = Math.Round(Convert.ToDecimal(margem.ToString()), 2);
                this.TXB_Lucro.Text = lucro.ToString();
                this.TXB_Margem.Text = margem_arredondada.ToString();

                this.DT_Fabricacao.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["data_fab"].Value);
                this.DT_Vencimento.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["data_venc"].Value);
                this.TXB_Corredor_Expo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["corredor_expo"].Value);
                this.TXB_Prateleira_Expo.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["prateleira_expo"].Value);
                this.TXB_Corredor_Dep.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["corredor_dep"].Value);
                this.TXB_Prateleira_Dep.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["prateleira_dep"].Value);
                this.TXB_Quant_Atual.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["quant_atual"].Value);
                this.TXB_Quant_Ideal.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["quant_ideal"].Value);
                this.TXB_Unid_Vendidas.Text = Convert.ToString(this.DataLista.CurrentRow.Cells["unid_vendidas"].Value);

                this.BTN_Editar.Enabled = true;
                this.BTN_Cancelar.Enabled = true;

                this.CHK_Habilitar.Checked = true;
                this.StatusEstoque();
                this.tabControl1.SelectedIndex = 1;
            }
        }

        private void BTN_Relatorios_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Relatorio_Estoque frm = FRM_Tipo_Relatorio_Estoque.GetInstancia();
            frm.Show();
        }

        private void BTN_Categorias_Click(object sender, EventArgs e)
        {
            FRM_Categoria frm = new FRM_Categoria();
            frm.ShowDialog();
        }

        private void BTN_Unid_Medida_Click(object sender, EventArgs e)
        {
            FRM_Unid_Medida frm = new FRM_Unid_Medida();
            frm.ShowDialog();
        }

        private void BTN_Entrada_Click(object sender, EventArgs e)
        {
            FRM_Entrada frm = FRM_Entrada.GetInstancia();
            frm.IdFuncionario = this.idfuncionario;
            frm.Show();
        }

        private void BTN_Etiquetas_Click(object sender, EventArgs e)
        {
            FRM_Etiquetas frm = FRM_Etiquetas.GetInstancia();
            frm.Show();
        }

        private void BTN_Pesquisar_Click(object sender, EventArgs e)
        {
            if (this.cbBuscar.Text.Equals("Descrição"))
            {
                this.BuscarNome();
            }
            else if (this.cbBuscar.Text.Equals("Código"))
            {
                this.Buscar_Codigo();
            }
            this.TXB_Buscar.Text = string.Empty;
        }

        private void cbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TXB_Buscar.Text = string.Empty;
            this.TXB_Buscar.Focus();
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

        private void TXB_Preco_Venda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void TXB_Quant_Ideal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
    }
}
