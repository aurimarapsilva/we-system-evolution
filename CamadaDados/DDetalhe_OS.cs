using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_OS
    {
        private int _IdDetalhe_OS;
        private int _IdOS;
        private int _IdProduto;
        private decimal _Quant;
        private decimal _Preco_Venda;

        public int IdDetalhe_OS
        {
            get
            {
                return _IdDetalhe_OS;
            }

            set
            {
                _IdDetalhe_OS = value;
            }
        }

        public int IdOS
        {
            get
            {
                return _IdOS;
            }

            set
            {
                _IdOS = value;
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

        public DDetalhe_OS()
        {

        }

        public DDetalhe_OS(int iddetalhe_os, int idos, int idproduto, decimal quant, decimal preco_venda)
        {
            this.IdDetalhe_OS = iddetalhe_os;
            this.IdOS = idos;
            this.IdProduto = idproduto;
            this.Quant = quant;
            this.Preco_Venda = preco_venda;
        }


        // Inserir Somente Detalhe OS
        public string Inserir_DetalheOS(DDetalhe_OS Detalhe_OS)
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
                SqlCmd.CommandText = "spinserir_detalhe_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_os";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOS = new SqlParameter();
                ParIdOS.ParameterName = "@idos";
                ParIdOS.SqlDbType = SqlDbType.Int;
                ParIdOS.Value = Detalhe_OS.IdOS;
                SqlCmd.Parameters.Add(ParIdOS);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_OS.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_OS.Quant;
                SqlCmd.Parameters.Add(ParQuant);

                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_OS.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

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



        //Método Inserir OS + Detalhe OS
        public string Inserir_Tudo(DDetalhe_OS Detalhe_OS,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_detalhe_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_os";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdOS = new SqlParameter();
                ParIdOS.ParameterName = "@idos";
                ParIdOS.SqlDbType = SqlDbType.Int;
                ParIdOS.Value = Detalhe_OS.IdOS;
                SqlCmd.Parameters.Add(ParIdOS);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_OS.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_OS.Quant;
                SqlCmd.Parameters.Add(ParQuant);
                
                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_OS.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);
                
                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";
                
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            return resp;
        }


        //Método Editar Somente Detalhe OS
        public string EditarDetalheOS(DDetalhe_OS Detalhe_OS)
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
                SqlCmd.CommandText = "speditar_detalhe_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdOS = new SqlParameter();
                ParIdOS.ParameterName = "@idos";
                ParIdOS.SqlDbType = SqlDbType.Int;
                ParIdOS.Value = Detalhe_OS.IdOS;
                SqlCmd.Parameters.Add(ParIdOS);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_OS.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_OS.Quant;
                SqlCmd.Parameters.Add(ParQuant);

                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_OS.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

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

        //Método Editar
        public string EditarJunto(DDetalhe_OS Detalhe_OS,
            ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string resp = "";

            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "speditar_detalhe_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                
                SqlParameter ParIdOS = new SqlParameter();
                ParIdOS.ParameterName = "@idos";
                ParIdOS.SqlDbType = SqlDbType.Int;
                ParIdOS.Value = Detalhe_OS.IdOS;
                SqlCmd.Parameters.Add(ParIdOS);

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_OS.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);

                SqlParameter ParQuant = new SqlParameter();
                ParQuant.ParameterName = "@quant";
                ParQuant.SqlDbType = SqlDbType.Decimal;
                ParQuant.Precision = 10;
                ParQuant.Scale = 3;
                ParQuant.Value = Detalhe_OS.Quant;
                SqlCmd.Parameters.Add(ParQuant);

                SqlParameter ParPreco_Venda = new SqlParameter();
                ParPreco_Venda.ParameterName = "@preco_venda";
                ParPreco_Venda.SqlDbType = SqlDbType.Decimal;
                ParPreco_Venda.Precision = 7;
                ParPreco_Venda.Scale = 2;
                ParPreco_Venda.Value = Detalhe_OS.Preco_Venda;
                SqlCmd.Parameters.Add(ParPreco_Venda);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }

            return resp;
        }
    }
}
