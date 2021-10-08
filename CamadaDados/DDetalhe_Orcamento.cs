using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Orcamento
    {
        private int _IdProdutos_Orcamento;
        private int _IdOrcamento;
        private int _IdProduto;
        private decimal _Quant;
        private decimal _Preco_Venda;

        public int IdProdutos_Orcamento
        {
            get
            {
                return _IdProdutos_Orcamento;
            }

            set
            {
                _IdProdutos_Orcamento = value;
            }
        }

        public int IdOrcamento
        {
            get
            {
                return _IdOrcamento;
            }

            set
            {
                _IdOrcamento = value;
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

        public DDetalhe_Orcamento()
        {

        }

        public DDetalhe_Orcamento(int idprodutos_orcamento, int idorcamento, int idproduto, decimal quant, decimal preco_venda) 
        {
            this.IdProdutos_Orcamento = idprodutos_orcamento;
            this.IdOrcamento = idorcamento;
            this.IdProduto = idproduto;
            this.Quant = quant;
            this.Preco_Venda = preco_venda;
        }


        //Método Inserir
        public string Inserir(DDetalhe_Orcamento Detalhe_Orcamento,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_produtos_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idprodutos_orcamento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOrcamento = new SqlParameter();
                ParIdOrcamento.ParameterName = "@idorcamento";
                ParIdOrcamento.SqlDbType = SqlDbType.Int;
                ParIdOrcamento.Value = Detalhe_Orcamento.IdOrcamento;
                SqlCmd.Parameters.Add(ParIdOrcamento);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_Orcamento.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);
                
                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_Orcamento.Quant;
                SqlCmd.Parameters.Add(ParQuant);

                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_Orcamento.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";
                
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            return resp;
        }
    }
}
