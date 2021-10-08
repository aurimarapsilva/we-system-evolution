using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DNivel_Acesso
    {
        private int _IdNivel_Acesso;
        private string _Nivel_Acesso;
        private string _BTN_Listagem_Vendas;
        private string _BTN_Backup;
        private string _BTN_Configuracoes;
        private string _BTN_Licenciamento;
        private string _BTN_Desbloquear;
        private string _BTN_Caixa;
        private string _BTN_Clientes;
        private string _BTN_Estoque;
        private string _BTN_Fornecedores;
        private string _BTN_Funcionarios;
        private string _BTN_Livro_Caixa;
        private string _BTN_Contas_Receber;
        private string _BTN_Contas_Pagar;
        private string _BTN_Outras_Financas;
        private string _BTN_OS;
        private string _BTN_Relatorios;
        private string _Deletar_Item_Venda;
        private string _Deletar_Conta_Receber;
        private string _Inserir_Conta_Receber;

        public int IdNivel_Acesso
        {
            get
            {
                return _IdNivel_Acesso;
            }

            set
            {
                _IdNivel_Acesso = value;
            }
        }

        public string Nivel_Acesso
        {
            get
            {
                return _Nivel_Acesso;
            }

            set
            {
                _Nivel_Acesso = value;
            }
        }

        public string BTN_Listagem_Vendas
        {
            get
            {
                return _BTN_Listagem_Vendas;
            }

            set
            {
                _BTN_Listagem_Vendas = value;
            }
        }

        public string BTN_Backup
        {
            get
            {
                return _BTN_Backup;
            }

            set
            {
                _BTN_Backup = value;
            }
        }

        public string BTN_Configuracoes
        {
            get
            {
                return _BTN_Configuracoes;
            }

            set
            {
                _BTN_Configuracoes = value;
            }
        }

        public string BTN_Licenciamento
        {
            get
            {
                return _BTN_Licenciamento;
            }

            set
            {
                _BTN_Licenciamento = value;
            }
        }

        public string BTN_Desbloquear
        {
            get
            {
                return _BTN_Desbloquear;
            }

            set
            {
                _BTN_Desbloquear = value;
            }
        }

        public string BTN_Caixa
        {
            get
            {
                return _BTN_Caixa;
            }

            set
            {
                _BTN_Caixa = value;
            }
        }

        public string BTN_Clientes
        {
            get
            {
                return _BTN_Clientes;
            }

            set
            {
                _BTN_Clientes = value;
            }
        }

        public string BTN_Estoque
        {
            get
            {
                return _BTN_Estoque;
            }

            set
            {
                _BTN_Estoque = value;
            }
        }

        public string BTN_Fornecedores
        {
            get
            {
                return _BTN_Fornecedores;
            }

            set
            {
                _BTN_Fornecedores = value;
            }
        }

        public string BTN_Funcionarios
        {
            get
            {
                return _BTN_Funcionarios;
            }

            set
            {
                _BTN_Funcionarios = value;
            }
        }

        public string BTN_Livro_Caixa
        {
            get
            {
                return _BTN_Livro_Caixa;
            }

            set
            {
                _BTN_Livro_Caixa = value;
            }
        }

        public string BTN_Contas_Receber
        {
            get
            {
                return _BTN_Contas_Receber;
            }

            set
            {
                _BTN_Contas_Receber = value;
            }
        }

        public string BTN_Contas_Pagar
        {
            get
            {
                return _BTN_Contas_Pagar;
            }

            set
            {
                _BTN_Contas_Pagar = value;
            }
        }

        public string BTN_Outras_Financas
        {
            get
            {
                return _BTN_Outras_Financas;
            }

            set
            {
                _BTN_Outras_Financas = value;
            }
        }

        public string BTN_OS
        {
            get
            {
                return _BTN_OS;
            }

            set
            {
                _BTN_OS = value;
            }
        }

        public string BTN_Relatorios
        {
            get
            {
                return _BTN_Relatorios;
            }

            set
            {
                _BTN_Relatorios = value;
            }
        }

        public string Deletar_Item_Venda
        {
            get
            {
                return _Deletar_Item_Venda;
            }

            set
            {
                _Deletar_Item_Venda = value;
            }
        }

        public string Deletar_Conta_Receber
        {
            get
            {
                return _Deletar_Conta_Receber;
            }

            set
            {
                _Deletar_Conta_Receber = value;
            }
        }

        public string Inserir_Conta_Receber
        {
            get
            {
                return _Inserir_Conta_Receber;
            }

            set
            {
                _Inserir_Conta_Receber = value;
            }
        }

        public DNivel_Acesso()
        {

        }


        public DNivel_Acesso(int idnivel_acesso, string nivel_acesso, string btn_listagem_vendas, string btn_backup, string btn_configuracoes, string btn_licenciamento, string btn_desbloquear, string btn_caixa, string btn_clientes, string btn_estoque, string btn_fornecedores, string btn_funcionarios, string btn_livro_caixa, string btn_contas_receber, string btn_contas_pagar, string btn_outras_financas, string btn_os, string btn_relatorios, string deletar_item_venda, string deletar_conta_receber, string inserir_conta_receber)
        {
            this.IdNivel_Acesso = idnivel_acesso;
            this.Nivel_Acesso = nivel_acesso;
            this.BTN_Listagem_Vendas = btn_listagem_vendas;
            this.BTN_Backup = btn_backup;
            this.BTN_Configuracoes = btn_configuracoes;
            this.BTN_Licenciamento = btn_licenciamento;
            this.BTN_Desbloquear = btn_desbloquear;
            this.BTN_Caixa = btn_caixa;
            this.BTN_Clientes = btn_clientes;
            this.BTN_Estoque = btn_estoque;
            this.BTN_Fornecedores = btn_fornecedores;
            this.BTN_Funcionarios = btn_funcionarios;
            this.BTN_Livro_Caixa = btn_livro_caixa;
            this.BTN_Contas_Receber = btn_contas_receber;
            this.BTN_Contas_Pagar = btn_contas_pagar;
            this.BTN_Outras_Financas = btn_outras_financas;
            this.BTN_OS = btn_os;
            this.BTN_Relatorios = btn_relatorios;
            this.Deletar_Item_Venda = deletar_item_venda;
            this.Deletar_Conta_Receber = deletar_conta_receber;
            this.Inserir_Conta_Receber = inserir_conta_receber;
        }


        //Metodo Inserir 
        public string Inserir(DNivel_Acesso Nivel_Acesso)
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
                SqlCmd.CommandText = "spinserir_nivel_acesso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idnivel_acesso";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);
                
                SqlParameter ParNivel_Acesso = new SqlParameter();
                ParNivel_Acesso.ParameterName = "@nivel_acesso";
                ParNivel_Acesso.SqlDbType = SqlDbType.VarChar;
                ParNivel_Acesso.Size = 50;
                ParNivel_Acesso.Value = Nivel_Acesso.Nivel_Acesso;
                SqlCmd.Parameters.Add(ParNivel_Acesso);
                
                SqlParameter ParBTN_Listagem_Vendas = new SqlParameter();
                ParBTN_Listagem_Vendas.ParameterName = "@btn_listagem_vendas";
                ParBTN_Listagem_Vendas.SqlDbType = SqlDbType.VarChar;
                ParBTN_Listagem_Vendas.Size = 3;
                ParBTN_Listagem_Vendas.Value = Nivel_Acesso.BTN_Listagem_Vendas;
                SqlCmd.Parameters.Add(ParBTN_Listagem_Vendas);

                SqlParameter ParBTN_Backup = new SqlParameter();
                ParBTN_Backup.ParameterName = "@btn_backup";
                ParBTN_Backup.SqlDbType = SqlDbType.VarChar;
                ParBTN_Backup.Size = 3;
                ParBTN_Backup.Value = Nivel_Acesso.BTN_Backup;
                SqlCmd.Parameters.Add(ParBTN_Backup);

                SqlParameter ParBTN_Configuracoes = new SqlParameter();
                ParBTN_Configuracoes.ParameterName = "@btn_configuracoes";
                ParBTN_Configuracoes.SqlDbType = SqlDbType.VarChar;
                ParBTN_Configuracoes.Size = 3;
                ParBTN_Configuracoes.Value = Nivel_Acesso.BTN_Configuracoes;
                SqlCmd.Parameters.Add(ParBTN_Configuracoes);

                SqlParameter ParBTN_Licenciamento = new SqlParameter();
                ParBTN_Licenciamento.ParameterName = "@btn_licenciamento";
                ParBTN_Licenciamento.SqlDbType = SqlDbType.VarChar;
                ParBTN_Licenciamento.Size = 3;
                ParBTN_Licenciamento.Value = Nivel_Acesso.BTN_Licenciamento;
                SqlCmd.Parameters.Add(ParBTN_Licenciamento);

                SqlParameter ParBTN_Desbloquear = new SqlParameter();
                ParBTN_Desbloquear.ParameterName = "@btn_desbloquear";
                ParBTN_Desbloquear.SqlDbType = SqlDbType.VarChar;
                ParBTN_Desbloquear.Size = 3;
                ParBTN_Desbloquear.Value = Nivel_Acesso.BTN_Desbloquear;
                SqlCmd.Parameters.Add(ParBTN_Desbloquear);

                SqlParameter ParBTN_Caixa = new SqlParameter();
                ParBTN_Caixa.ParameterName = "@btn_caixa";
                ParBTN_Caixa.SqlDbType = SqlDbType.VarChar;
                ParBTN_Caixa.Size = 3;
                ParBTN_Caixa.Value = Nivel_Acesso.BTN_Caixa;
                SqlCmd.Parameters.Add(ParBTN_Caixa);

                SqlParameter ParBTN_Clientes = new SqlParameter();
                ParBTN_Clientes.ParameterName = "@btn_clientes";
                ParBTN_Clientes.SqlDbType = SqlDbType.VarChar;
                ParBTN_Clientes.Size = 3;
                ParBTN_Clientes.Value = Nivel_Acesso.BTN_Clientes;
                SqlCmd.Parameters.Add(ParBTN_Clientes);

                SqlParameter ParBTN_Estoque = new SqlParameter();
                ParBTN_Estoque.ParameterName = "@btn_estoque";
                ParBTN_Estoque.SqlDbType = SqlDbType.VarChar;
                ParBTN_Estoque.Size = 3;
                ParBTN_Estoque.Value = Nivel_Acesso.BTN_Estoque;
                SqlCmd.Parameters.Add(ParBTN_Estoque);

                SqlParameter ParBTN_Fornecedores = new SqlParameter();
                ParBTN_Fornecedores.ParameterName = "@btn_fornecedores";
                ParBTN_Fornecedores.SqlDbType = SqlDbType.VarChar;
                ParBTN_Fornecedores.Size = 3;
                ParBTN_Fornecedores.Value = Nivel_Acesso.BTN_Fornecedores;
                SqlCmd.Parameters.Add(ParBTN_Fornecedores);

                SqlParameter ParBTN_Funcionarios = new SqlParameter();
                ParBTN_Funcionarios.ParameterName = "@btn_funcionarios";
                ParBTN_Funcionarios.SqlDbType = SqlDbType.VarChar;
                ParBTN_Funcionarios.Size = 3;
                ParBTN_Funcionarios.Value = Nivel_Acesso.BTN_Funcionarios;
                SqlCmd.Parameters.Add(ParBTN_Funcionarios);

                SqlParameter ParBTN_Livro_Caixa = new SqlParameter();
                ParBTN_Livro_Caixa.ParameterName = "@btn_livro_caixa";
                ParBTN_Livro_Caixa.SqlDbType = SqlDbType.VarChar;
                ParBTN_Livro_Caixa.Size = 3;
                ParBTN_Livro_Caixa.Value = Nivel_Acesso.BTN_Livro_Caixa;
                SqlCmd.Parameters.Add(ParBTN_Livro_Caixa);

                SqlParameter ParBTN_Contas_Receber = new SqlParameter();
                ParBTN_Contas_Receber.ParameterName = "@btn_contas_receber";
                ParBTN_Contas_Receber.SqlDbType = SqlDbType.VarChar;
                ParBTN_Contas_Receber.Size = 3;
                ParBTN_Contas_Receber.Value = Nivel_Acesso.BTN_Contas_Receber;
                SqlCmd.Parameters.Add(ParBTN_Contas_Receber);

                SqlParameter ParBTN_Contas_Pagar = new SqlParameter();
                ParBTN_Contas_Pagar.ParameterName = "@btn_contas_pagar";
                ParBTN_Contas_Pagar.SqlDbType = SqlDbType.VarChar;
                ParBTN_Contas_Pagar.Size = 3;
                ParBTN_Contas_Pagar.Value = Nivel_Acesso.BTN_Contas_Pagar;
                SqlCmd.Parameters.Add(ParBTN_Contas_Pagar);

                SqlParameter ParBTN_Outras_Financas = new SqlParameter();
                ParBTN_Outras_Financas.ParameterName = "@btn_outras_financas";
                ParBTN_Outras_Financas.SqlDbType = SqlDbType.VarChar;
                ParBTN_Outras_Financas.Size = 3;
                ParBTN_Outras_Financas.Value = Nivel_Acesso.BTN_Outras_Financas;
                SqlCmd.Parameters.Add(ParBTN_Outras_Financas);

                SqlParameter ParBTN_OS = new SqlParameter();
                ParBTN_OS.ParameterName = "@btn_os";
                ParBTN_OS.SqlDbType = SqlDbType.VarChar;
                ParBTN_OS.Size = 3;
                ParBTN_OS.Value = Nivel_Acesso.BTN_OS;
                SqlCmd.Parameters.Add(ParBTN_OS);

                SqlParameter ParBTN_Relatorios = new SqlParameter();
                ParBTN_Relatorios.ParameterName = "@btn_relatorios";
                ParBTN_Relatorios.SqlDbType = SqlDbType.VarChar;
                ParBTN_Relatorios.Size = 3;
                ParBTN_Relatorios.Value = Nivel_Acesso.BTN_Relatorios;
                SqlCmd.Parameters.Add(ParBTN_Relatorios);

                SqlParameter ParDeletar_Item_Venda = new SqlParameter();
                ParDeletar_Item_Venda.ParameterName = "@deletar_item_venda";
                ParDeletar_Item_Venda.SqlDbType = SqlDbType.VarChar;
                ParDeletar_Item_Venda.Size = 3;
                ParDeletar_Item_Venda.Value = Nivel_Acesso.Deletar_Item_Venda;
                SqlCmd.Parameters.Add(ParDeletar_Item_Venda);

                SqlParameter ParDeletar_Conta_Receber = new SqlParameter();
                ParDeletar_Conta_Receber.ParameterName = "@deletar_conta_receber";
                ParDeletar_Conta_Receber.SqlDbType = SqlDbType.VarChar;
                ParDeletar_Conta_Receber.Size = 3;
                ParDeletar_Conta_Receber.Value = Nivel_Acesso.Deletar_Conta_Receber;
                SqlCmd.Parameters.Add(ParDeletar_Conta_Receber);

                SqlParameter ParInserir_Conta_Receber = new SqlParameter();
                ParInserir_Conta_Receber.ParameterName = "@inserir_conta_receber";
                ParInserir_Conta_Receber.SqlDbType = SqlDbType.VarChar;
                ParInserir_Conta_Receber.Size = 3;
                ParInserir_Conta_Receber.Value = Nivel_Acesso.Inserir_Conta_Receber;
                SqlCmd.Parameters.Add(ParInserir_Conta_Receber);
                
                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

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
        public string Editar(DNivel_Acesso Nivel_Acesso)
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
                SqlCmd.CommandText = "speditar_nivel_acesso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idnivel_acesso";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Nivel_Acesso.IdNivel_Acesso;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParNivel_Acesso = new SqlParameter();
                ParNivel_Acesso.ParameterName = "@nivel_acesso";
                ParNivel_Acesso.SqlDbType = SqlDbType.VarChar;
                ParNivel_Acesso.Size = 50;
                ParNivel_Acesso.Value = Nivel_Acesso.Nivel_Acesso;
                SqlCmd.Parameters.Add(ParNivel_Acesso);

                SqlParameter ParBTN_Listagem_Vendas = new SqlParameter();
                ParBTN_Listagem_Vendas.ParameterName = "@btn_listagem_vendas";
                ParBTN_Listagem_Vendas.SqlDbType = SqlDbType.VarChar;
                ParBTN_Listagem_Vendas.Size = 3;
                ParBTN_Listagem_Vendas.Value = Nivel_Acesso.BTN_Listagem_Vendas;
                SqlCmd.Parameters.Add(ParBTN_Listagem_Vendas);

                SqlParameter ParBTN_Backup = new SqlParameter();
                ParBTN_Backup.ParameterName = "@btn_backup";
                ParBTN_Backup.SqlDbType = SqlDbType.VarChar;
                ParBTN_Backup.Size = 3;
                ParBTN_Backup.Value = Nivel_Acesso.BTN_Backup;
                SqlCmd.Parameters.Add(ParBTN_Backup);

                SqlParameter ParBTN_Configuracoes = new SqlParameter();
                ParBTN_Configuracoes.ParameterName = "@btn_configuracoes";
                ParBTN_Configuracoes.SqlDbType = SqlDbType.VarChar;
                ParBTN_Configuracoes.Size = 3;
                ParBTN_Configuracoes.Value = Nivel_Acesso.BTN_Configuracoes;
                SqlCmd.Parameters.Add(ParBTN_Configuracoes);

                SqlParameter ParBTN_Licenciamento = new SqlParameter();
                ParBTN_Licenciamento.ParameterName = "@btn_licenciamento";
                ParBTN_Licenciamento.SqlDbType = SqlDbType.VarChar;
                ParBTN_Licenciamento.Size = 3;
                ParBTN_Licenciamento.Value = Nivel_Acesso.BTN_Licenciamento;
                SqlCmd.Parameters.Add(ParBTN_Licenciamento);

                SqlParameter ParBTN_Desbloquear = new SqlParameter();
                ParBTN_Desbloquear.ParameterName = "@btn_desbloquear";
                ParBTN_Desbloquear.SqlDbType = SqlDbType.VarChar;
                ParBTN_Desbloquear.Size = 3;
                ParBTN_Desbloquear.Value = Nivel_Acesso.BTN_Desbloquear;
                SqlCmd.Parameters.Add(ParBTN_Desbloquear);

                SqlParameter ParBTN_Caixa = new SqlParameter();
                ParBTN_Caixa.ParameterName = "@btn_caixa";
                ParBTN_Caixa.SqlDbType = SqlDbType.VarChar;
                ParBTN_Caixa.Size = 3;
                ParBTN_Caixa.Value = Nivel_Acesso.BTN_Caixa;
                SqlCmd.Parameters.Add(ParBTN_Caixa);

                SqlParameter ParBTN_Clientes = new SqlParameter();
                ParBTN_Clientes.ParameterName = "@btn_clientes";
                ParBTN_Clientes.SqlDbType = SqlDbType.VarChar;
                ParBTN_Clientes.Size = 3;
                ParBTN_Clientes.Value = Nivel_Acesso.BTN_Clientes;
                SqlCmd.Parameters.Add(ParBTN_Clientes);

                SqlParameter ParBTN_Estoque = new SqlParameter();
                ParBTN_Estoque.ParameterName = "@btn_estoque";
                ParBTN_Estoque.SqlDbType = SqlDbType.VarChar;
                ParBTN_Estoque.Size = 3;
                ParBTN_Estoque.Value = Nivel_Acesso.BTN_Estoque;
                SqlCmd.Parameters.Add(ParBTN_Estoque);

                SqlParameter ParBTN_Fornecedores = new SqlParameter();
                ParBTN_Fornecedores.ParameterName = "@btn_fornecedores";
                ParBTN_Fornecedores.SqlDbType = SqlDbType.VarChar;
                ParBTN_Fornecedores.Size = 3;
                ParBTN_Fornecedores.Value = Nivel_Acesso.BTN_Fornecedores;
                SqlCmd.Parameters.Add(ParBTN_Fornecedores);

                SqlParameter ParBTN_Funcionarios = new SqlParameter();
                ParBTN_Funcionarios.ParameterName = "@btn_funcionarios";
                ParBTN_Funcionarios.SqlDbType = SqlDbType.VarChar;
                ParBTN_Funcionarios.Size = 3;
                ParBTN_Funcionarios.Value = Nivel_Acesso.BTN_Funcionarios;
                SqlCmd.Parameters.Add(ParBTN_Funcionarios);

                SqlParameter ParBTN_Livro_Caixa = new SqlParameter();
                ParBTN_Livro_Caixa.ParameterName = "@btn_livro_caixa";
                ParBTN_Livro_Caixa.SqlDbType = SqlDbType.VarChar;
                ParBTN_Livro_Caixa.Size = 3;
                ParBTN_Livro_Caixa.Value = Nivel_Acesso.BTN_Livro_Caixa;
                SqlCmd.Parameters.Add(ParBTN_Livro_Caixa);

                SqlParameter ParBTN_Contas_Receber = new SqlParameter();
                ParBTN_Contas_Receber.ParameterName = "@btn_contas_receber";
                ParBTN_Contas_Receber.SqlDbType = SqlDbType.VarChar;
                ParBTN_Contas_Receber.Size = 3;
                ParBTN_Contas_Receber.Value = Nivel_Acesso.BTN_Contas_Receber;
                SqlCmd.Parameters.Add(ParBTN_Contas_Receber);

                SqlParameter ParBTN_Contas_Pagar = new SqlParameter();
                ParBTN_Contas_Pagar.ParameterName = "@btn_contas_pagar";
                ParBTN_Contas_Pagar.SqlDbType = SqlDbType.VarChar;
                ParBTN_Contas_Pagar.Size = 3;
                ParBTN_Contas_Pagar.Value = Nivel_Acesso.BTN_Contas_Pagar;
                SqlCmd.Parameters.Add(ParBTN_Contas_Pagar);

                SqlParameter ParBTN_Outras_Financas = new SqlParameter();
                ParBTN_Outras_Financas.ParameterName = "@btn_outras_financas";
                ParBTN_Outras_Financas.SqlDbType = SqlDbType.VarChar;
                ParBTN_Outras_Financas.Size = 3;
                ParBTN_Outras_Financas.Value = Nivel_Acesso.BTN_Outras_Financas;
                SqlCmd.Parameters.Add(ParBTN_Outras_Financas);

                SqlParameter ParBTN_OS = new SqlParameter();
                ParBTN_OS.ParameterName = "@btn_os";
                ParBTN_OS.SqlDbType = SqlDbType.VarChar;
                ParBTN_OS.Size = 3;
                ParBTN_OS.Value = Nivel_Acesso.BTN_OS;
                SqlCmd.Parameters.Add(ParBTN_OS);

                SqlParameter ParBTN_Relatorios = new SqlParameter();
                ParBTN_Relatorios.ParameterName = "@btn_relatorios";
                ParBTN_Relatorios.SqlDbType = SqlDbType.VarChar;
                ParBTN_Relatorios.Size = 3;
                ParBTN_Relatorios.Value = Nivel_Acesso.BTN_Relatorios;
                SqlCmd.Parameters.Add(ParBTN_Relatorios);

                SqlParameter ParDeletar_Item_Venda = new SqlParameter();
                ParDeletar_Item_Venda.ParameterName = "@deletar_item_venda";
                ParDeletar_Item_Venda.SqlDbType = SqlDbType.VarChar;
                ParDeletar_Item_Venda.Size = 3;
                ParDeletar_Item_Venda.Value = Nivel_Acesso.Deletar_Item_Venda;
                SqlCmd.Parameters.Add(ParDeletar_Item_Venda);

                SqlParameter ParDeletar_Conta_Receber = new SqlParameter();
                ParDeletar_Conta_Receber.ParameterName = "@deletar_conta_receber";
                ParDeletar_Conta_Receber.SqlDbType = SqlDbType.VarChar;
                ParDeletar_Conta_Receber.Size = 3;
                ParDeletar_Conta_Receber.Value = Nivel_Acesso.Deletar_Conta_Receber;
                SqlCmd.Parameters.Add(ParDeletar_Conta_Receber);

                SqlParameter ParInserir_Conta_Receber = new SqlParameter();
                ParInserir_Conta_Receber.ParameterName = "@inserir_conta_receber";
                ParInserir_Conta_Receber.SqlDbType = SqlDbType.VarChar;
                ParInserir_Conta_Receber.Size = 3;
                ParInserir_Conta_Receber.Value = Nivel_Acesso.Inserir_Conta_Receber;
                SqlCmd.Parameters.Add(ParInserir_Conta_Receber);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Ok" : "Registro não foi inserido";

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


        // Metodo Mostrar 
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("nivel_acesso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_nivel_acesso";
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


        // Metodo Mostrar pelo ID
        public DataTable Mostrar_Pelo_ID(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("nivel_acesso");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_nivel_acesso_pelo_id";
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
