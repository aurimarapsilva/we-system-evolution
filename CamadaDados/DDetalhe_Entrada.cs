using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Entrada
    {
        private int _IdDetalhe_entrada;
        private int _IdEntrada;
        private int _IdProduto;
        private decimal _Preco_Custo;
        private decimal _Quant;
        private string _Fabricacao;
        private string _Vencimento;
        private DateTime _Antecipacao_Venc;
        private string _TextoBuscar;
        private string _TextoBuscar2;

        public int IdDetalhe_entrada
        {
            get
            {
                return _IdDetalhe_entrada;
            }

            set
            {
                _IdDetalhe_entrada = value;
            }
        }

        public int IdEntrada
        {
            get
            {
                return _IdEntrada;
            }

            set
            {
                _IdEntrada = value;
            }
        }

        public int IdProduto
        {
            get
            {
                return _IdProduto;
            }

            set
            {
                _IdProduto = value;
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

        public decimal Quant
        {
            get
            {
                return _Quant;
            }

            set
            {
                _Quant = value;
            }
        }

        public string Fabricacao
        {
            get
            {
                return _Fabricacao;
            }

            set
            {
                _Fabricacao = value;
            }
        }

        public string Vencimento
        {
            get
            {
                return _Vencimento;
            }

            set
            {
                _Vencimento = value;
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

        public string TextoBuscar2
        {
            get
            {
                return _TextoBuscar2;
            }

            set
            {
                _TextoBuscar2 = value;
            }
        }

        
        public DDetalhe_Entrada()
        {

        }

        public DDetalhe_Entrada(int iddetalhe_entrada, int identrada,
            int idproduto, decimal preco_custo,
          decimal quant, string fabricacao, string vencimento, DateTime antecipacao_venc, string textobuscar,
          string textobuscar2)
        {
            this.IdDetalhe_entrada = iddetalhe_entrada;
            this.IdEntrada = identrada;
            this.IdProduto = idproduto;
            this.Preco_Custo = preco_custo;
            this.Quant = quant;
            this.Fabricacao = fabricacao;
            this.Vencimento = vencimento;
            this.Antecipacao_Venc = antecipacao_venc;
            this.TextoBuscar = textobuscar;
            this.TextoBuscar2 = textobuscar2;
        }


        //Método Inserir
        public string Inserir(DDetalhe_Entrada Detalhe_Entrada,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {
                //codigo
                // SqlCon.ConnectionString = Conexao.Cn;
                //  SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_detalhe_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIDEntrada = new SqlParameter();
                ParIDEntrada.ParameterName = "@identrada";
                ParIDEntrada.SqlDbType = SqlDbType.Int;
                ParIDEntrada.Value = Detalhe_Entrada.IdEntrada;
                SqlCmd.Parameters.Add(ParIDEntrada);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_Entrada.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParPreco_Custo = new SqlParameter();
                ParPreco_Custo.ParameterName = "@preco_custo";
                ParPreco_Custo.SqlDbType = SqlDbType.Decimal;
                ParPreco_Custo.Precision = 7;
                ParPreco_Custo.Scale = 2;
                ParPreco_Custo.Value = Detalhe_Entrada.Preco_Custo;
                SqlCmd.Parameters.Add(ParPreco_Custo);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_Entrada.Quant;
                SqlCmd.Parameters.Add(ParQuant);

                SqlParameter ParFabricacao = new SqlParameter();
                ParFabricacao.ParameterName = "@fabricacao";
                ParFabricacao.SqlDbType = SqlDbType.VarChar;
                ParFabricacao.Size = 13;
                ParFabricacao.Value = Detalhe_Entrada.Fabricacao;
                SqlCmd.Parameters.Add(ParFabricacao);

                SqlParameter ParVencimento = new SqlParameter();
                ParVencimento.ParameterName = "@vencimento";
                ParVencimento.SqlDbType = SqlDbType.VarChar;
                ParVencimento.Size = 13;
                ParVencimento.Value = Detalhe_Entrada.Vencimento;
                SqlCmd.Parameters.Add(ParVencimento);

                SqlParameter ParAntecipacao_Venc = new SqlParameter();
                ParAntecipacao_Venc.ParameterName = "@antecipacao_venc";
                ParAntecipacao_Venc.SqlDbType = SqlDbType.Date;
                ParAntecipacao_Venc.Value = Detalhe_Entrada.Antecipacao_Venc;
                SqlCmd.Parameters.Add(ParAntecipacao_Venc);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() != 0 ? "Ok" : "Registro não foi Inserido";


            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }


            return resp;

        }
    }
}
