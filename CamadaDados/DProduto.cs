using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CamadaDados
{
    public class DProduto
    {
        private int _Id;
        private int _IdRemetente;
        private int _IdNumeracao_Auto;
        private int _IdTipo_Produto;
        private string _Codigo;
        private string _Descricao;
        private byte[] _Imagem;
        private int _Idcategoria;
        private int _Idunid_medida;
        private int _Idfornecedor;
        private decimal _Preco_Custo;
        private decimal _Preco_Venda;
        private string _Data_Fab;
        private string _Data_venc;
        private DateTime _Antecipacao_Venc;
        private string _Estado;
        private string _Corredor_Expo;
        private string _Prateleira_Expo;
        private string _Corredor_Dep;
        private string _Prateleira_Dep;
        private decimal _Quant_Atual;
        private decimal _Quant_Ideal;
        private decimal _Unid_Vendidas;
        private byte[] _BarCode;
        private string _TextoBuscar;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public int IdRemetente
        {
            get
            {
                return _IdRemetente;
            }

            set
            {
                _IdRemetente = value;
            }
        }

        public int IdNumeracao_Auto
        {
            get
            {
                return _IdNumeracao_Auto;
            }

            set
            {
                _IdNumeracao_Auto = value;
            }
        }

        public int IdTipo_Produto
        {
            get
            {
                return _IdTipo_Produto;
            }

            set
            {
                _IdTipo_Produto = value;
            }
        }

        public string Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }

            set
            {
                _Descricao = value;
            }
        }

        public byte[] Imagem
        {
            get
            {
                return _Imagem;
            }

            set
            {
                _Imagem = value;
            }
        }

        public int Idcategoria
        {
            get
            {
                return _Idcategoria;
            }

            set
            {
                _Idcategoria = value;
            }
        }

        public int Idunid_medida
        {
            get
            {
                return _Idunid_medida;
            }

            set
            {
                _Idunid_medida = value;
            }
        }

        public int Idfornecedor
        {
            get
            {
                return _Idfornecedor;
            }

            set
            {
                _Idfornecedor = value;
            }
        }

        public decimal Preco_Custo
        {
            get
            {
                return _Preco_Custo;
            }

            set
            {
                _Preco_Custo = value;
            }
        }

        public decimal Preco_Venda
        {
            get
            {
                return _Preco_Venda;
            }

            set
            {
                _Preco_Venda = value;
            }
        }

        public string Data_Fab
        {
            get
            {
                return _Data_Fab;
            }

            set
            {
                _Data_Fab = value;
            }
        }

        public string Data_venc
        {
            get
            {
                return _Data_venc;
            }

            set
            {
                _Data_venc = value;
            }
        }

        public DateTime Antecipacao_Venc
        {
            get
            {
                return _Antecipacao_Venc;
            }

            set
            {
                _Antecipacao_Venc = value;
            }
        }

        public string Estado
        {
            get
            {
                return _Estado;
            }

            set
            {
                _Estado = value;
            }
        }

        public string Corredor_Expo
        {
            get
            {
                return _Corredor_Expo;
            }

            set
            {
                _Corredor_Expo = value;
            }
        }

        public string Prateleira_Expo
        {
            get
            {
                return _Prateleira_Expo;
            }

            set
            {
                _Prateleira_Expo = value;
            }
        }

        public string Corredor_Dep
        {
            get
            {
                return _Corredor_Dep;
            }

            set
            {
                _Corredor_Dep = value;
            }
        }

        public string Prateleira_Dep
        {
            get
            {
                return _Prateleira_Dep;
            }

            set
            {
                _Prateleira_Dep = value;
            }
        }

        public decimal Quant_Atual
        {
            get
            {
                return _Quant_Atual;
            }

            set
            {
                _Quant_Atual = value;
            }
        }

        public decimal Quant_Ideal
        {
            get
            {
                return _Quant_Ideal;
            }

            set
            {
                _Quant_Ideal = value;
            }
        }

        public decimal Unid_Vendidas
        {
            get
            {
                return _Unid_Vendidas;
            }

            set
            {
                _Unid_Vendidas = value;
            }
        }

        public byte[] BarCode
        {
            get
            {
                return _BarCode;
            }

            set
            {
                _BarCode = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        
        //Construtor vazio
        public DProduto()
        {

        }

        //Construtor com parametros
        public DProduto(int id, int idremetente, int idnumeracao_auto, int idtipo_produto, string codigo, string descricao, byte[] imagem,  int idcategoria, int idunid_medida, int idfornecedor, decimal preco_custo, decimal preco_venda, string data_fab, string data_venc, DateTime antecipacao_venc, string estado, string corredor_expo, string prateleira_expo, string corredor_dep, string prateleira_dep, decimal quant_atual, decimal quant_ideal, decimal unid_vendidas, string textobuscar, byte[] barcode)
        {
            this.Id = id;
            this.IdRemetente = idremetente;
            this.IdNumeracao_Auto = idnumeracao_auto;
            this.IdTipo_Produto = idtipo_produto;
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Imagem = imagem;
            this.Idcategoria = idcategoria;
            this.Idunid_medida = idunid_medida;
            this.Idfornecedor = idfornecedor;
            this.Preco_Custo = preco_custo;
            this.Preco_Venda = preco_venda;
            this.Data_Fab = data_fab;
            this.Data_venc = data_venc;
            this.Antecipacao_Venc = antecipacao_venc;
            this.Estado = estado;
            this.Corredor_Expo = corredor_expo;
            this.Prateleira_Expo = prateleira_expo;
            this.Corredor_Dep = corredor_dep;
            this.Prateleira_Dep = prateleira_dep;
            this.Quant_Atual = quant_atual;
            this.Quant_Ideal = quant_ideal;
            this.Unid_Vendidas = unid_vendidas;
            this.BarCode = barcode;
            this.TextoBuscar = textobuscar;
        }

        //Metodo Atualizar Numeração Automática - PRODUTO
        public string Atualizar_Num_Auto_Produto(int atual_produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spatualizar_num_auto_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@atual_produto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = atual_produto;
                SqlCmd.Parameters.Add(ParIdProduto);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A atualização não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        //Metodo Inserir 
        public string Inserir(DProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = Produto.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParIdNumeracao_Auto = new SqlParameter();
                ParIdNumeracao_Auto.ParameterName = "@idnumeracao_auto";
                ParIdNumeracao_Auto.SqlDbType = SqlDbType.Int;
                ParIdNumeracao_Auto.Value = Produto.IdNumeracao_Auto;
                SqlCmd.Parameters.Add(ParIdNumeracao_Auto);

                SqlParameter ParIdTipo_Produto = new SqlParameter();
                ParIdTipo_Produto.ParameterName = "@idtipo_produto";
                ParIdTipo_Produto.SqlDbType = SqlDbType.Int;
                ParIdTipo_Produto.Value = Produto.IdTipo_Produto;
                SqlCmd.Parameters.Add(ParIdTipo_Produto);


                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Produto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);


                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 500;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);


                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@imagem";
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);

                
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Produto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);


                SqlParameter ParIdunid_medida = new SqlParameter();
                ParIdunid_medida.ParameterName = "@idunid_medida";
                ParIdunid_medida.SqlDbType = SqlDbType.Int;
                ParIdunid_medida.Value = Produto.Idunid_medida;
                SqlCmd.Parameters.Add(ParIdunid_medida);


                SqlParameter ParIdfornecedor = new SqlParameter();
                ParIdfornecedor.ParameterName = "@idfornecedor";
                ParIdfornecedor.SqlDbType = SqlDbType.Int;
                ParIdfornecedor.Value = Produto.Idfornecedor;
                SqlCmd.Parameters.Add(ParIdfornecedor);

                SqlParameter ParPreco_Custo = new SqlParameter();
                ParPreco_Custo.ParameterName = "@preco_custo";
                ParPreco_Custo.SqlDbType = SqlDbType.Decimal;
                ParPreco_Custo.Precision = 7;
                ParPreco_Custo.Scale = 2;
                ParPreco_Custo.Value = Produto.Preco_Custo;
                SqlCmd.Parameters.Add(ParPreco_Custo);


                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Produto.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);


                SqlParameter ParData_Fab = new SqlParameter();
                ParData_Fab.ParameterName = "@data_fab";
                ParData_Fab.SqlDbType = SqlDbType.VarChar;
                ParData_Fab.Size = 13;
                ParData_Fab.Value = Produto.Data_Fab;
                SqlCmd.Parameters.Add(ParData_Fab);
                

                SqlParameter ParData_venc = new SqlParameter();
                ParData_venc.ParameterName = "@data_venc";
                ParData_venc.SqlDbType = SqlDbType.VarChar;
                ParData_venc.Size = 13;
                ParData_venc.Value = Produto.Data_venc;
                SqlCmd.Parameters.Add(ParData_venc);

                SqlParameter ParAntecipacao_Venc = new SqlParameter();
                ParAntecipacao_Venc.ParameterName = "@antecipacao_venc";
                ParAntecipacao_Venc.SqlDbType = SqlDbType.Date;
                ParAntecipacao_Venc.Value = Produto.Antecipacao_Venc;
                SqlCmd.Parameters.Add(ParAntecipacao_Venc);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 9;
                ParEstado.Value = Produto.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCorredor_Expo = new SqlParameter();
                ParCorredor_Expo.ParameterName = "@corredor_expo";
                ParCorredor_Expo.SqlDbType = SqlDbType.VarChar;
                ParCorredor_Expo.Size = 10;
                ParCorredor_Expo.Value = Produto.Corredor_Expo;
                SqlCmd.Parameters.Add(ParCorredor_Expo);


                SqlParameter ParPrateleira_Expo = new SqlParameter();
                ParPrateleira_Expo.ParameterName = "@prateleira_expo";
                ParPrateleira_Expo.SqlDbType = SqlDbType.VarChar;
                ParPrateleira_Expo.Size = 10;
                ParPrateleira_Expo.Value = Produto.Prateleira_Expo;
                SqlCmd.Parameters.Add(ParPrateleira_Expo);


                SqlParameter ParCorredor_Dep = new SqlParameter();
                ParCorredor_Dep.ParameterName = "@corredor_dep";
                ParCorredor_Dep.SqlDbType = SqlDbType.VarChar;
                ParCorredor_Dep.Size = 10;
                ParCorredor_Dep.Value = Produto.Corredor_Dep;
                SqlCmd.Parameters.Add(ParCorredor_Dep);


                SqlParameter ParPrateleira_Dep = new SqlParameter();
                ParPrateleira_Dep.ParameterName = "@prateleira_dep";
                ParPrateleira_Dep.SqlDbType = SqlDbType.VarChar;
                ParPrateleira_Dep.Size = 10;
                ParPrateleira_Dep.Value = Produto.Prateleira_Dep;
                SqlCmd.Parameters.Add(ParPrateleira_Dep);


                SqlParameter ParQuant_Atual = new SqlParameter();
                ParQuant_Atual.ParameterName = "@quant_atual";
                ParQuant_Atual.SqlDbType = SqlDbType.Decimal;
                ParQuant_Atual.Precision = 10;
                ParQuant_Atual.Scale = 3;
                ParQuant_Atual.Value = Produto.Quant_Atual;
                SqlCmd.Parameters.Add(ParQuant_Atual);
                
                
                SqlParameter ParQuant_Ideal = new SqlParameter();
                ParQuant_Ideal.ParameterName = "@quant_ideal";
                ParQuant_Ideal.SqlDbType = SqlDbType.Decimal;
                ParQuant_Ideal.Precision = 10;
                ParQuant_Ideal.Scale = 3;
                ParQuant_Ideal.Value = Produto.Quant_Ideal;
                SqlCmd.Parameters.Add(ParQuant_Ideal);

                SqlParameter ParUnid_Vendidas = new SqlParameter();
                ParUnid_Vendidas.ParameterName = "@unid_vendidas";
                ParUnid_Vendidas.SqlDbType = SqlDbType.Decimal;
                ParUnid_Vendidas.Precision = 10;
                ParUnid_Vendidas.Scale = 3;
                ParUnid_Vendidas.Value = Produto.Unid_Vendidas;
                SqlCmd.Parameters.Add(ParUnid_Vendidas);

                SqlParameter ParBarCode = new SqlParameter();
                ParBarCode.ParameterName = "@barcode";
                ParBarCode.SqlDbType = SqlDbType.Image;
                ParBarCode.Value = Produto.BarCode;
                SqlCmd.Parameters.Add(ParBarCode);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.Id = Convert.ToInt32(SqlCmd.Parameters["@id"].Value);

                    resp = Atualizar_Num_Auto_Produto(this.Id);
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Editar 
        public string Editar(DProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Produto.Id;
                SqlCmd.Parameters.Add(ParId);


                SqlParameter ParIdTipo_Produto = new SqlParameter();
                ParIdTipo_Produto.ParameterName = "@idtipo_produto";
                ParIdTipo_Produto.SqlDbType = SqlDbType.Int;
                ParIdTipo_Produto.Value = Produto.IdTipo_Produto;
                SqlCmd.Parameters.Add(ParIdTipo_Produto);


                SqlParameter ParCodigo = new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 50;
                ParCodigo.Value = Produto.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);


                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 500;
                ParDescricao.Value = Produto.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);


                SqlParameter ParImagem = new SqlParameter();
                ParImagem.ParameterName = "@imagem";
                ParImagem.SqlDbType = SqlDbType.Image;
                ParImagem.Value = Produto.Imagem;
                SqlCmd.Parameters.Add(ParImagem);

                
                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = Produto.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);


                SqlParameter ParIdunid_medida = new SqlParameter();
                ParIdunid_medida.ParameterName = "@idunid_medida";
                ParIdunid_medida.SqlDbType = SqlDbType.Int;
                ParIdunid_medida.Value = Produto.Idunid_medida;
                SqlCmd.Parameters.Add(ParIdunid_medida);


                SqlParameter ParIdfornecedor = new SqlParameter();
                ParIdfornecedor.ParameterName = "@idfornecedor";
                ParIdfornecedor.SqlDbType = SqlDbType.Int;
                ParIdfornecedor.Value = Produto.Idfornecedor;
                SqlCmd.Parameters.Add(ParIdfornecedor);


                SqlParameter ParPreco_Custo = new SqlParameter();
                ParPreco_Custo.ParameterName = "@preco_custo";
                ParPreco_Custo.SqlDbType = SqlDbType.Decimal;
                ParPreco_Custo.Precision = 7;
                ParPreco_Custo.Scale = 2;
                ParPreco_Custo.Value = Produto.Preco_Custo;
                SqlCmd.Parameters.Add(ParPreco_Custo);


                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Produto.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);


                SqlParameter ParData_Fab = new SqlParameter();
                ParData_Fab.ParameterName = "@data_fab";
                ParData_Fab.SqlDbType = SqlDbType.VarChar;
                ParData_Fab.Size = 13;
                ParData_Fab.Value = Produto.Data_Fab;
                SqlCmd.Parameters.Add(ParData_Fab);


                SqlParameter ParData_venc = new SqlParameter();
                ParData_venc.ParameterName = "@data_venc";
                ParData_venc.SqlDbType = SqlDbType.VarChar;
                ParData_venc.Size = 13;
                ParData_venc.Value = Produto.Data_venc;
                SqlCmd.Parameters.Add(ParData_venc);


                SqlParameter ParCorredor_Expo = new SqlParameter();
                ParCorredor_Expo.ParameterName = "@corredor_expo";
                ParCorredor_Expo.SqlDbType = SqlDbType.VarChar;
                ParCorredor_Expo.Size = 10;
                ParCorredor_Expo.Value = Produto.Corredor_Expo;
                SqlCmd.Parameters.Add(ParCorredor_Expo);


                SqlParameter ParPrateleira_Expo = new SqlParameter();
                ParPrateleira_Expo.ParameterName = "@prateleira_expo";
                ParPrateleira_Expo.SqlDbType = SqlDbType.VarChar;
                ParPrateleira_Expo.Size = 10;
                ParPrateleira_Expo.Value = Produto.Prateleira_Expo;
                SqlCmd.Parameters.Add(ParPrateleira_Expo);


                SqlParameter ParCorredor_Dep = new SqlParameter();
                ParCorredor_Dep.ParameterName = "@corredor_dep";
                ParCorredor_Dep.SqlDbType = SqlDbType.VarChar;
                ParCorredor_Dep.Size = 10;
                ParCorredor_Dep.Value = Produto.Corredor_Dep;
                SqlCmd.Parameters.Add(ParCorredor_Dep);


                SqlParameter ParPrateleira_Dep = new SqlParameter();
                ParPrateleira_Dep.ParameterName = "@prateleira_dep";
                ParPrateleira_Dep.SqlDbType = SqlDbType.VarChar;
                ParPrateleira_Dep.Size = 10;
                ParPrateleira_Dep.Value = Produto.Prateleira_Dep;
                SqlCmd.Parameters.Add(ParPrateleira_Dep);


                SqlParameter ParQuant_Atual = new SqlParameter();
                ParQuant_Atual.ParameterName = "@quant_atual";
                ParQuant_Atual.SqlDbType = SqlDbType.Decimal;
                ParQuant_Atual.Precision = 10;
                ParQuant_Atual.Scale = 3;
                ParQuant_Atual.Value = Produto.Quant_Atual;
                SqlCmd.Parameters.Add(ParQuant_Atual);


                SqlParameter ParQuant_Ideal = new SqlParameter();
                ParQuant_Ideal.ParameterName = "@quant_ideal";
                ParQuant_Ideal.SqlDbType = SqlDbType.Decimal;
                ParQuant_Ideal.Precision = 10;
                ParQuant_Ideal.Scale = 3;
                ParQuant_Ideal.Value = Produto.Quant_Ideal;
                SqlCmd.Parameters.Add(ParQuant_Ideal);

                SqlParameter ParBarCode = new SqlParameter();
                ParBarCode.ParameterName = "@barcode";
                ParBarCode.SqlDbType = SqlDbType.Image;
                ParBarCode.Value = Produto.BarCode;
                SqlCmd.Parameters.Add(ParBarCode);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A edição não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Excluir 
        public string Excluir(DProduto Produto)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Produto.Id;
                SqlCmd.Parameters.Add(ParId);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A exclusão não foi feita";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }


        //Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_produto";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Nome 
        public DataTable BuscarNome(DProduto Produto)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_descricao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Produto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo Buscar Produto pelo Codigo
        public DataTable Buscar_Codigo(string Texto_Buscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTexto_Buscar = new SqlParameter();
                ParTexto_Buscar.ParameterName = "@textobuscar";
                ParTexto_Buscar.SqlDbType = SqlDbType.VarChar;
                ParTexto_Buscar.Size = 50;
                ParTexto_Buscar.Value = Texto_Buscar;
                SqlCmd.Parameters.Add(ParTexto_Buscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Selecionar Produto pelo Codigo de barras - VENDA
        public DataTable Selecionar_Produto_Codigo_Barra_Venda(string Codigo_Barra)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spselecionar_produto_codigo_barra_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo_Barra = new SqlParameter();
                ParCodigo_Barra.ParameterName = "@codigo_barra";
                ParCodigo_Barra.SqlDbType = SqlDbType.VarChar;
                ParCodigo_Barra.Size = 50;
                ParCodigo_Barra.Value = Codigo_Barra;
                SqlCmd.Parameters.Add(ParCodigo_Barra);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Selecionar Produto pelo Codigo de barras - ENTRADA
        public DataTable Selecionar_Produto_Codigo_Barra_Entrada(string Codigo_Barra)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spselecionar_produto_codigo_barra_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo_Barra = new SqlParameter();
                ParCodigo_Barra.ParameterName = "@codigo_barra";
                ParCodigo_Barra.SqlDbType = SqlDbType.VarChar;
                ParCodigo_Barra.Size = 50;
                ParCodigo_Barra.Value = Codigo_Barra;
                SqlCmd.Parameters.Add(ParCodigo_Barra);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        

        //Metodo Mostrar Quantidade Atual Abaixo de 0
        public DataTable Quant_Atual_Abaixo_Zero()
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spquant_atual_abaixo_zero_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Pesquisar Preço por Codigo de Barras
        public DataTable Pesquisar_Preco(string Codigo_Barra)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sppesquisar_preco_codigo_barra";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParCodigo_Barra = new SqlParameter();
                ParCodigo_Barra.ParameterName = "@codigo_barra";
                ParCodigo_Barra.SqlDbType = SqlDbType.VarChar;
                ParCodigo_Barra.Size = 50;
                ParCodigo_Barra.Value = Codigo_Barra;
                SqlCmd.Parameters.Add(ParCodigo_Barra);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Produto Pesquisa Preço - POR DESCRIÇÃO
        public DataTable Buscar_Produto_Pesquisa_Preco(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_pesquisa_preco";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Buscar Produto Pesquisa Preço - POR CODIGO
        public DataTable Buscar_Produto_Pesquisa_Preco_Codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_pesquisa_preco_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        //Metodo Buscar Produto pelo Codigo
        public DataTable Buscar_ID_Import(int ID)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_produto_id_import";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParID = new SqlParameter();
                ParID.ParameterName = "@id";
                ParID.SqlDbType = SqlDbType.Int;
                ParID.Value = ID;
                SqlCmd.Parameters.Add(ParID);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
