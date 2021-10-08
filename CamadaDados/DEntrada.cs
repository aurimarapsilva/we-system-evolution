using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DEntrada
    {
        private int _IdEntrada;
        private int _IdRemetente;
        private DateTime _Data;
        private int _idFornecedor;
        private string _Estado;
        private string _Tipo_comprovante;
        private string _Num_Comprovante;
        private string _Tipo_Compra;
        private int _IdFuncionario;

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

        public DateTime Data
        {
            get
            {
                return _Data;
            }

            set
            {
                _Data = value;
            }
        }


        public int IdFornecedor
        {
            get
            {
                return _idFornecedor;
            }

            set
            {
                _idFornecedor = value;
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

        public string Tipo_comprovante
        {
            get
            {
                return _Tipo_comprovante;
            }

            set
            {
                _Tipo_comprovante = value;
            }
        }

        public string Num_Comprovante
        {
            get
            {
                return _Num_Comprovante;
            }

            set
            {
                _Num_Comprovante = value;
            }
        }

        public string Tipo_Compra
        {
            get
            {
                return _Tipo_Compra;
            }

            set
            {
                _Tipo_Compra = value;
            }
        }

        public int IdFuncionario
        {
            get
            {
                return _IdFuncionario;
            }

            set
            {
                _IdFuncionario = value;
            }
        }

        public DEntrada()
        {

        }


        public DEntrada(int identrada, int idremetente, DateTime data,  int idfornecedor, string estado, string tipo_comprovante, string num_comprovante, string tipo_compra, int idfuncionario)
        {
            this.IdEntrada = identrada;
            this.IdRemetente = idremetente;
            this.Data = data;
            this.IdFornecedor = idfornecedor;
            this.Estado = estado;
            this.Tipo_comprovante = tipo_comprovante;
            this.Num_Comprovante = num_comprovante;
            this.Tipo_Compra = tipo_compra;
            this.IdFuncionario = idfuncionario;
        }


       
        //Método Inserir
        public string Inserir(DEntrada Entrada, List<DDetalhe_Entrada> Detalhe)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction();


                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@identrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = Entrada.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Entrada.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParIdFornecedor = new SqlParameter();
                ParIdFornecedor.ParameterName = "@idfornecedor";
                ParIdFornecedor.SqlDbType = SqlDbType.Int;
                ParIdFornecedor.Value = Entrada.IdFornecedor;
                SqlCmd.Parameters.Add(ParIdFornecedor);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 7;
                ParEstado.Value = Entrada.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParTipoComprovante = new SqlParameter();
                ParTipoComprovante.ParameterName = "@tipo_comprovante";
                ParTipoComprovante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprovante.Size = 20;
                ParTipoComprovante.Value = Entrada.Tipo_comprovante;
                SqlCmd.Parameters.Add(ParTipoComprovante);

                SqlParameter ParNum_Comprovante = new SqlParameter();
                ParNum_Comprovante.ParameterName = "@num_comprovante";
                ParNum_Comprovante.SqlDbType = SqlDbType.VarChar;
                ParNum_Comprovante.Size = 20;
                ParNum_Comprovante.Value = Entrada.Num_Comprovante;
                SqlCmd.Parameters.Add(ParNum_Comprovante);

                SqlParameter ParTipo_Compra = new SqlParameter();
                ParTipo_Compra.ParameterName = "@tipo_compra";
                ParTipo_Compra.SqlDbType = SqlDbType.VarChar;
                ParTipo_Compra.Size = 20;
                ParTipo_Compra.Value = Entrada.Tipo_Compra;
                SqlCmd.Parameters.Add(ParTipo_Compra);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Entrada.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdEntrada = Convert.ToInt32(SqlCmd.Parameters["@identrada"].Value);

                    foreach (DDetalhe_Entrada det in Detalhe)
                    {
                        det.IdEntrada = this.IdEntrada;

                        //Chamar método inserir no detalhes entrada
                        resp = det.Inserir(det, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Ok"))
                        {
                            break;
                        }
                    }

                }
                if (resp.Equals("Ok"))
                {
                    SqlTra.Commit();     //Só a partir do comit os dados são salvos com uma transação
                }
                else
                {
                    SqlTra.Rollback();   //Roolback cancela toda a transação, nada é salvo!!
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


        //Método Anular
        public string Anular(DEntrada Entrada)
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
                SqlCmd.CommandText = "spanular_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@identrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Entrada.IdEntrada;
                SqlCmd.Parameters.Add(ParId);



                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "A Anulação não foi feita";


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
        public string Excluir(DEntrada Entrada)
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
                SqlCmd.CommandText = "spdeletar_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Entrada.IdEntrada;
                SqlCmd.Parameters.Add(ParId);


                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A exclusão não foi feita";

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


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_entrada";
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


        //Mostrar Produtos Disponiveis para Entrada - POR DESCRIÇÃO
        public DataTable Mostrar_Produtos_Disp_Entrada(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disponivel_entrada";
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


        //Mostrar Produtos Disponiveis para Entrada - POR CÓDIGO
        public DataTable Mostrar_Produtos_Disp_Entrada_Codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disponivel_entrada_codigo";
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


        //Método Buscar por Datas
        public DataTable BuscarData(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_entrada_data";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 20;
                ParTextoBuscar2.Value = TextoBuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        
        //Método Mostrar Detalhes
        public DataTable MostrarDetalhes(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.Int;
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


        //Método Mostrar Entrada pelo ID
        public DataTable Mostrar_Entrada_Pelo_ID(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("entrada");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_entrada_pelo_id";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 20;
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
    }
}
