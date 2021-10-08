using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DOrcamento
    {
        private int _IdOrcamento;
        private DateTime _Data;
        private string _Cliente;
        private string _Telefone;
        private string _Entrada_Dinheiro;
        private decimal _Valor_Entrada;
        private string _Forma_Pagamento;
        private int _IdFuncionario;
        private int _Numero;

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

        public string Cliente
        {
            get
            {
                return _Cliente;
            }

            set
            {
                _Cliente = value;
            }
        }

        public string Telefone
        {
            get
            {
                return _Telefone;
            }

            set
            {
                _Telefone = value;
            }
        }

        public string Entrada_Dinheiro
        {
            get
            {
                return _Entrada_Dinheiro;
            }

            set
            {
                _Entrada_Dinheiro = value;
            }
        }

        public decimal Valor_Entrada
        {
            get
            {
                return _Valor_Entrada;
            }

            set
            {
                _Valor_Entrada = value;
            }
        }

        public string Forma_Pagamento
        {
            get
            {
                return _Forma_Pagamento;
            }

            set
            {
                _Forma_Pagamento = value;
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

        public int Numero
        {
            get
            {
                return _Numero;
            }

            set
            {
                _Numero = value;
            }
        }

        public DOrcamento()
        {

        }

        public DOrcamento(int idorcamento, DateTime data, string cliente, string telefone, string entrada_dinheiro, decimal valor_entrada, string forma_pagamento, int idfuncionario, int numero)
        {
            this.IdOrcamento = idorcamento;
            this.Data = data;
            this.Cliente = cliente;
            this.Telefone = telefone;
            this.Entrada_Dinheiro = entrada_dinheiro;
            this.Valor_Entrada = valor_entrada;
            this.Forma_Pagamento = forma_pagamento;
            this.IdFuncionario = idfuncionario;
            this.Numero = numero;
        }


        //Metodo Atualizar Numeração Automática - OS
        public string Atualizar_Num_Auto_Orcamento(int num_atual)
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
                SqlCmd.CommandText = "spatualizar_num_auto_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Parnum_atual = new SqlParameter();
                Parnum_atual.ParameterName = "@atual_orcamento";
                Parnum_atual.SqlDbType = SqlDbType.Int;
                Parnum_atual.Value = num_atual;
                SqlCmd.Parameters.Add(Parnum_atual);

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

        //Método Inserir
        public string Inserir(DOrcamento Orcamento, List<DDetalhe_Orcamento> Detalhe, List<DFormas_Pgto_Orcamento> Formas_Pgto_Orc)
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
                SqlCmd.CommandText = "spinserir_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idorcamento";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Orcamento.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParCliente = new SqlParameter();
                ParCliente.ParameterName = "@cliente";
                ParCliente.SqlDbType = SqlDbType.VarChar;
                ParCliente.Size = 70;
                ParCliente.Value = Orcamento.Cliente;
                SqlCmd.Parameters.Add(ParCliente);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 17;
                ParTelefone.Value = Orcamento.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEntrada_Dinheiro = new SqlParameter();
                ParEntrada_Dinheiro.ParameterName = "@entrada_dinehrio";
                ParEntrada_Dinheiro.SqlDbType = SqlDbType.VarChar;
                ParEntrada_Dinheiro.Size = 3;
                ParEntrada_Dinheiro.Value = Orcamento.Entrada_Dinheiro;
                SqlCmd.Parameters.Add(ParEntrada_Dinheiro);

                SqlParameter ParValor_Entrada = new SqlParameter();
                ParValor_Entrada.ParameterName = "@valor_entrada";
                ParValor_Entrada.SqlDbType = SqlDbType.Decimal;
                ParValor_Entrada.Precision = 7;
                ParValor_Entrada.Scale = 2;
                ParValor_Entrada.Value = Orcamento.Valor_Entrada;
                SqlCmd.Parameters.Add(ParValor_Entrada);

                SqlParameter ParForma_Pagamento = new SqlParameter();
                ParForma_Pagamento.ParameterName = "@forma_pagamento";
                ParForma_Pagamento.SqlDbType = SqlDbType.VarChar;
                ParForma_Pagamento.Size = 20;
                ParForma_Pagamento.Value = Orcamento.Forma_Pagamento;
                SqlCmd.Parameters.Add(ParForma_Pagamento);

                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Orcamento.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);

                SqlParameter ParNumero = new SqlParameter();
                ParNumero.ParameterName = "@numero";
                ParNumero.SqlDbType = SqlDbType.Int;
                ParNumero.Value = Orcamento.Numero;
                SqlCmd.Parameters.Add(ParNumero);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdOrcamento = Convert.ToInt32(SqlCmd.Parameters["@idorcamento"].Value);

                    string Num_Auto = Atualizar_Num_Auto_Orcamento(this.Numero);

                    // Inserindo Produtos do Orçamento
                    foreach (DDetalhe_Orcamento det in Detalhe)
                    {
                        det.IdOrcamento = this.IdOrcamento;

                        //Chamar método inserir no Detalhes do Orçamento
                        resp = det.Inserir(det, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Ok"))
                        {
                            break;
                        }
                    }


                    // Inserindo Forma(s) de Pagamento do Orçamento
                    foreach (DFormas_Pgto_Orcamento pgto in Formas_Pgto_Orc)
                    {
                        pgto.IdOrcamento = this.IdOrcamento;

                        //Chamar método inserir no Detalhes do Orçamento
                        resp = pgto.Inserir(pgto, ref SqlCon, ref SqlTra);

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


        //Método Mostrar
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_orcamento";
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


        
        //Método Mostrar Produtos do Orçamento
        public DataTable Mostrar_Produtos_Orcamento(int IDORCAMENTO)
        {
            DataTable DtResultado = new DataTable("produtos_orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_produtos_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDORCAMENTO = new SqlParameter();
                ParIDORCAMENTO.ParameterName = "@idorcamento";
                ParIDORCAMENTO.SqlDbType = SqlDbType.Int;
                ParIDORCAMENTO.Value = IDORCAMENTO;
                SqlCmd.Parameters.Add(ParIDORCAMENTO);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Produtos do Orçamento - IMPORTA~ÇÃO CAIXA
        public DataTable Mostrar_Produtos_Orcamento_Import_Caixa(int IDORCAMENTO)
        {
            DataTable DtResultado = new DataTable("produtos_orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_produtos_orcamento_importacao_caixa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDORCAMENTO = new SqlParameter();
                ParIDORCAMENTO.ParameterName = "@idorcamento";
                ParIDORCAMENTO.SqlDbType = SqlDbType.Int;
                ParIDORCAMENTO.Value = IDORCAMENTO;
                SqlCmd.Parameters.Add(ParIDORCAMENTO);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Mostrar Formas de Pagamento do Orçamento
        public DataTable Mostrar_Formas_Pgto_Orcamento(int IDORCAMENTO)
        {
            DataTable DtResultado = new DataTable("formas_pgto_orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_formas_pgto_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDORCAMENTO = new SqlParameter();
                ParIDORCAMENTO.ParameterName = "@idorcamento";
                ParIDORCAMENTO.SqlDbType = SqlDbType.Int;
                ParIDORCAMENTO.Value = IDORCAMENTO;
                SqlCmd.Parameters.Add(ParIDORCAMENTO);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método buscar pelo ID
        public DataTable Buscar_ID(int IDORCAMENTO)
        {
            DataTable DtResultado = new DataTable("orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_orcamento_id";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDORCAMENTO = new SqlParameter();
                ParIDORCAMENTO.ParameterName = "@idorcamento";
                ParIDORCAMENTO.SqlDbType = SqlDbType.Int;
                ParIDORCAMENTO.Value = IDORCAMENTO;
                SqlCmd.Parameters.Add(ParIDORCAMENTO);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Buscar Orçamento - CLIENTE
        public DataTable Buscar_Orcamento_Cliente(string textobuscar)
        {
            DataTable DtResultado = new DataTable("orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_orcamento_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Value = textobuscar;
                Partextobuscar.Size = 20;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Buscar Orçamento - DATAS
        public DataTable Buscar_Orcamento_Data(string textobuscar, string textobuscar2)
        {
            DataTable DtResultado = new DataTable("orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_orcamento_data";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Value = textobuscar;
                Partextobuscar.Size = 20;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlParameter Partextobuscar2 = new SqlParameter();
                Partextobuscar2.ParameterName = "@textobuscar2";
                Partextobuscar2.SqlDbType = SqlDbType.VarChar;
                Partextobuscar2.Value = textobuscar2;
                Partextobuscar2.Size = 20;
                SqlCmd.Parameters.Add(Partextobuscar2);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Buscar Orçamento - Nº / ID
        public DataTable Buscar_Orcamento_Num(string textobuscar)
        {
            DataTable DtResultado = new DataTable("orcamento");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_orcamento_num";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Partextobuscar = new SqlParameter();
                Partextobuscar.ParameterName = "@textobuscar";
                Partextobuscar.SqlDbType = SqlDbType.VarChar;
                Partextobuscar.Value = textobuscar;
                Partextobuscar.Size = 20;
                SqlCmd.Parameters.Add(Partextobuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Metodo Excluir 
        public string Excluir(DOrcamento Orcamento)
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
                SqlCmd.CommandText = "spdeletar_orcamento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Orcamento.IdOrcamento;
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


        // Buscar Produto p/ orçamento - POR DESCRIÇÃO
        public DataTable Buscar_Produtos_Descricao(string textobuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disp_orcamento_descricao";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
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

        // Buscar Produto p/ orçamento - POR CÓDIGO
        public DataTable Buscar_Produtos_Codigo(string textobuscar)
        {
            DataTable DtResultado = new DataTable("produto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spproduto_disponivel_orcamento_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
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
