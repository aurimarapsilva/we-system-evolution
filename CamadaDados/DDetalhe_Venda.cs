using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Venda
    {
        private int _IdDetalhe_venda;
        private int _IdVenda;
        private int _IdProduto;
        private decimal _Preco_Venda;
        private decimal _Quant;

        public int IdDetalhe_venda
        {
            get
            {
                return _IdDetalhe_venda;
            }

            set
            {
                _IdDetalhe_venda = value;
            }
        }

        public int IdVenda
        {
            get
            {
                return _IdVenda;
            }

            set
            {
                _IdVenda = value;
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


        public DDetalhe_Venda()
        {

        }

        public DDetalhe_Venda(int iddetalhe_venda, int idvenda, int idproduto, decimal preco_venda, decimal quant)
        {
            this.IdDetalhe_venda = iddetalhe_venda;
            this.IdVenda = idvenda;
            this.IdProduto = idproduto;
            this.Preco_Venda = preco_venda;
            this.Quant = quant;
        }


        //Método Inserir
        public string Inserir(DDetalhe_Venda Detalhe_Venda,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_detalhe_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_venda";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIDEntrada = new SqlParameter();
                ParIDEntrada.ParameterName = "@idvenda";
                ParIDEntrada.SqlDbType = SqlDbType.Int;
                ParIDEntrada.Value = Detalhe_Venda.IdVenda;
                SqlCmd.Parameters.Add(ParIDEntrada);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_Venda.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_Venda.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_Venda.Quant;
                SqlCmd.Parameters.Add(ParQuant);


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
