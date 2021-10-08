using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DOS
    {
        private int _IdOS;
        private int _IdRemetente;
        private DateTime _Data;
        private int _Num_OS;
        private string _Tipo;
        private int _IdCliente;
        private int _IdTecnico;
        private int _IdEquipamento;
        private string _Marca;
        private string _Modelo;
        private string _Num_Serie;
        private string _Cor;
        private string _Senha;
        private string _Placa;
        private string _Uf_Placa;
        private string _Km;
        private string _Observacoes_Cliente;
        private string _Diagnostico;
        private string _Auto_Cliente;
        private string _Estado_OS;
        private DateTime _Data_Entrada;
        private string _Data_Auto_Cliente;
        private string _Data_Pronto;
        private string _Data_Retirada;
        private decimal _Total;
        private string _Previsao_entrega;
        private string _Acessorios;
        private string _Parafusos_Faltando;
        private string _Partes_Quebradas;
        private string _Arranhoes;
        private string _Outros;
        private string _Texto_Buscar;

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

        public int Num_OS
        {
            get
            {
                return _Num_OS;
            }

            set
            {
                _Num_OS = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        public int IdCliente
        {
            get
            {
                return _IdCliente;
            }

            set
            {
                _IdCliente = value;
            }
        }

        public int IdTecnico
        {
            get
            {
                return _IdTecnico;
            }

            set
            {
                _IdTecnico = value;
            }
        }

        public int IdEquipamento
        {
            get
            {
                return _IdEquipamento;
            }

            set
            {
                _IdEquipamento = value;
            }
        }

        public string Marca
        {
            get
            {
                return _Marca;
            }

            set
            {
                _Marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return _Modelo;
            }

            set
            {
                _Modelo = value;
            }
        }

        public string Num_Serie
        {
            get
            {
                return _Num_Serie;
            }

            set
            {
                _Num_Serie = value;
            }
        }

        public string Cor
        {
            get
            {
                return _Cor;
            }

            set
            {
                _Cor = value;
            }
        }

        public string Senha
        {
            get
            {
                return _Senha;
            }

            set
            {
                _Senha = value;
            }
        }

        public string Placa
        {
            get
            {
                return _Placa;
            }

            set
            {
                _Placa = value;
            }
        }

        public string Uf_Placa
        {
            get
            {
                return _Uf_Placa;
            }

            set
            {
                _Uf_Placa = value;
            }
        }

        public string Km
        {
            get
            {
                return _Km;
            }

            set
            {
                _Km = value;
            }
        }

        public string Observacoes_Cliente
        {
            get
            {
                return _Observacoes_Cliente;
            }

            set
            {
                _Observacoes_Cliente = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return _Diagnostico;
            }

            set
            {
                _Diagnostico = value;
            }
        }

        public string Auto_Cliente
        {
            get
            {
                return _Auto_Cliente;
            }

            set
            {
                _Auto_Cliente = value;
            }
        }

        public string Estado_OS
        {
            get
            {
                return _Estado_OS;
            }

            set
            {
                _Estado_OS = value;
            }
        }

        public DateTime Data_Entrada
        {
            get
            {
                return _Data_Entrada;
            }

            set
            {
                _Data_Entrada = value;
            }
        }

        public string Data_Auto_Cliente
        {
            get
            {
                return _Data_Auto_Cliente;
            }

            set
            {
                _Data_Auto_Cliente = value;
            }
        }

        public string Data_Pronto
        {
            get
            {
                return _Data_Pronto;
            }

            set
            {
                _Data_Pronto = value;
            }
        }

        public string Data_Retirada
        {
            get
            {
                return _Data_Retirada;
            }

            set
            {
                _Data_Retirada = value;
            }
        }

        public decimal Total
        {
            get
            {
                return _Total;
            }

            set
            {
                _Total = value;
            }
        }

        public string Previsao_entrega
        {
            get
            {
                return _Previsao_entrega;
            }

            set
            {
                _Previsao_entrega = value;
            }
        }

        public string Acessorios
        {
            get
            {
                return _Acessorios;
            }

            set
            {
                _Acessorios = value;
            }
        }

        public string Parafusos_Faltando
        {
            get
            {
                return _Parafusos_Faltando;
            }

            set
            {
                _Parafusos_Faltando = value;
            }
        }

        public string Partes_Quebradas
        {
            get
            {
                return _Partes_Quebradas;
            }

            set
            {
                _Partes_Quebradas = value;
            }
        }

        public string Arranhoes
        {
            get
            {
                return _Arranhoes;
            }

            set
            {
                _Arranhoes = value;
            }
        }

        public string Outros
        {
            get
            {
                return _Outros;
            }

            set
            {
                _Outros = value;
            }
        }

        public string Texto_Buscar
        {
            get
            {
                return _Texto_Buscar;
            }

            set
            {
                _Texto_Buscar = value;
            }
        }

        
        public DOS()
        {

        }

        public DOS(int idos, int idremetente, DateTime data, int num_os, string tipo, int idcliente, int idtecnico, int idequipamento, string marca, string modelo, string num_serie, string cor, string senha, string placa, string uf_placa, string km, string observacoes_cliente, string diagnostico, string auto_cliente, string estado_os, DateTime data_entrada, string data_auto_cliente, string data_pronto, string data_retirada, decimal total, string previsao_entrega, string acessorios, string parafusos_faltando, string partes_quebradas, string arranhoes, string outros, string texto_buscar)
        {
            this.IdOS = idos;
            this.IdRemetente = idremetente;
            this.Data = data;
            this.Num_OS = num_os;
            this.Tipo = tipo;
            this.IdCliente = idcliente;
            this.IdTecnico = idtecnico;
            this.IdEquipamento = idequipamento;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Num_Serie = num_serie;
            this.Cor = cor;
            this.Senha = senha;
            this.Placa = placa;
            this.Uf_Placa = uf_placa;
            this.Km = km;
            this.Observacoes_Cliente = observacoes_cliente;
            this.Diagnostico = diagnostico;
            this.Auto_Cliente = auto_cliente;
            this.Estado_OS = estado_os;
            this.Data_Entrada = data_entrada;
            this.Data_Auto_Cliente = data_auto_cliente;
            this.Data_Pronto = data_pronto;
            this.Data_Retirada = data_retirada;
            this.Total = total;
            this.Previsao_entrega = previsao_entrega;
            this.Acessorios = acessorios;
            this.Parafusos_Faltando = parafusos_faltando;
            this.Partes_Quebradas = partes_quebradas;
            this.Arranhoes = arranhoes;
            this.Outros = outros;
            this.Texto_Buscar = texto_buscar;
       }

        //Metodo Atualizar Numeração Automática - OS
        public string Atualizar_Num_Auto_OS(int atual_os)
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
                SqlCmd.CommandText = "spatualizar_num_auto_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@atual_os";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = atual_os;
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


        // Inserir Somente OS
        public string Inserir_OS(DOS OS)
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
                SqlCmd.CommandText = "spinserir_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = OS.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = OS.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParNum_OS = new SqlParameter();
                ParNum_OS.ParameterName = "@num_os";
                ParNum_OS.SqlDbType = SqlDbType.Int;
                ParNum_OS.Value = OS.Num_OS;
                SqlCmd.Parameters.Add(ParNum_OS);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = OS.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = OS.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTecnico = new SqlParameter();
                ParIdTecnico.ParameterName = "@idtecnico";
                ParIdTecnico.SqlDbType = SqlDbType.Int;
                ParIdTecnico.Value = OS.IdTecnico;
                SqlCmd.Parameters.Add(ParIdTecnico);

                SqlParameter ParIdEquipamento = new SqlParameter();
                ParIdEquipamento.ParameterName = "@idequipamento";
                ParIdEquipamento.SqlDbType = SqlDbType.Int;
                ParIdEquipamento.Value = OS.IdEquipamento;
                SqlCmd.Parameters.Add(ParIdEquipamento);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = OS.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = OS.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParNum_Serie = new SqlParameter();
                ParNum_Serie.ParameterName = "@num_serie";
                ParNum_Serie.SqlDbType = SqlDbType.VarChar;
                ParNum_Serie.Size = 50;
                ParNum_Serie.Value = OS.Num_Serie;
                SqlCmd.Parameters.Add(ParNum_Serie);

                SqlParameter ParCor = new SqlParameter();
                ParCor.ParameterName = "@cor";
                ParCor.SqlDbType = SqlDbType.VarChar;
                ParCor.Size = 50;
                ParCor.Value = OS.Cor;
                SqlCmd.Parameters.Add(ParCor);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = OS.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = OS.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParUf_Placa = new SqlParameter();
                ParUf_Placa.ParameterName = "@uf_placa";
                ParUf_Placa.SqlDbType = SqlDbType.VarChar;
                ParUf_Placa.Size = 2;
                ParUf_Placa.Value = OS.Uf_Placa;
                SqlCmd.Parameters.Add(ParUf_Placa);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@km";
                ParKm.SqlDbType = SqlDbType.VarChar;
                ParKm.Size = 50;
                ParKm.Value = OS.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParObservacoes_Cliente = new SqlParameter();
                ParObservacoes_Cliente.ParameterName = "@observacoes_cliente";
                ParObservacoes_Cliente.SqlDbType = SqlDbType.VarChar;
                ParObservacoes_Cliente.Size = 150;
                ParObservacoes_Cliente.Value = OS.Observacoes_Cliente;
                SqlCmd.Parameters.Add(ParObservacoes_Cliente);

                SqlParameter ParDiagnostico = new SqlParameter();
                ParDiagnostico.ParameterName = "@diagnostico";
                ParDiagnostico.SqlDbType = SqlDbType.VarChar;
                ParDiagnostico.Size = 150;
                ParDiagnostico.Value = OS.Diagnostico;
                SqlCmd.Parameters.Add(ParDiagnostico);

                SqlParameter ParAuto_Cliente = new SqlParameter();
                ParAuto_Cliente.ParameterName = "@auto_cliente";
                ParAuto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParAuto_Cliente.Size = 9;
                ParAuto_Cliente.Value = OS.Auto_Cliente;
                SqlCmd.Parameters.Add(ParAuto_Cliente);

                SqlParameter ParEstado_OS = new SqlParameter();
                ParEstado_OS.ParameterName = "@estado_os";
                ParEstado_OS.SqlDbType = SqlDbType.VarChar;
                ParEstado_OS.Size = 20;
                ParEstado_OS.Value = OS.Estado_OS;
                SqlCmd.Parameters.Add(ParEstado_OS);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.DateTime;
                ParData_Entrada.Value = OS.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParData_Auto_Cliente = new SqlParameter();
                ParData_Auto_Cliente.ParameterName = "@data_auto_cliente";
                ParData_Auto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParData_Auto_Cliente.Size = 20;
                ParData_Auto_Cliente.Value = OS.Data_Auto_Cliente;
                SqlCmd.Parameters.Add(ParData_Auto_Cliente);

                SqlParameter ParData_Pronto = new SqlParameter();
                ParData_Pronto.ParameterName = "@data_pronto";
                ParData_Pronto.SqlDbType = SqlDbType.VarChar;
                ParData_Pronto.Size = 20;
                ParData_Pronto.Value = OS.Data_Pronto;
                SqlCmd.Parameters.Add(ParData_Pronto);

                SqlParameter ParData_Retirada = new SqlParameter();
                ParData_Retirada.ParameterName = "@data_retirada";
                ParData_Retirada.SqlDbType = SqlDbType.VarChar;
                ParData_Retirada.Size = 20;
                ParData_Retirada.Value = OS.Data_Retirada;
                SqlCmd.Parameters.Add(ParData_Retirada);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Precision = 7;
                ParTotal.Scale = 2;
                ParTotal.Value = OS.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParPrevisao_entrega = new SqlParameter();
                ParPrevisao_entrega.ParameterName = "@previsao_entrega";
                ParPrevisao_entrega.SqlDbType = SqlDbType.VarChar;
                ParPrevisao_entrega.Size = 20;
                ParPrevisao_entrega.Value = OS.Previsao_entrega;
                SqlCmd.Parameters.Add(ParPrevisao_entrega);

                SqlParameter ParAcessorios = new SqlParameter();
                ParAcessorios.ParameterName = "@entrada_com_acessorios";
                ParAcessorios.SqlDbType = SqlDbType.VarChar;
                ParAcessorios.Size = 50;
                ParAcessorios.Value = OS.Acessorios;
                SqlCmd.Parameters.Add(ParAcessorios);

                SqlParameter ParParafusos_Faltando = new SqlParameter();
                ParParafusos_Faltando.ParameterName = "@parafusos_faltando";
                ParParafusos_Faltando.SqlDbType = SqlDbType.VarChar;
                ParParafusos_Faltando.Size = 5;
                ParParafusos_Faltando.Value = OS.Parafusos_Faltando;
                SqlCmd.Parameters.Add(ParParafusos_Faltando);

                SqlParameter ParPartes_Quebradas = new SqlParameter();
                ParPartes_Quebradas.ParameterName = "@partes_quebradas";
                ParPartes_Quebradas.SqlDbType = SqlDbType.VarChar;
                ParPartes_Quebradas.Size = 50;
                ParPartes_Quebradas.Value = OS.Partes_Quebradas;
                SqlCmd.Parameters.Add(ParPartes_Quebradas);

                SqlParameter ParArranhoes = new SqlParameter();
                ParArranhoes.ParameterName = "@arranhados";
                ParArranhoes.SqlDbType = SqlDbType.VarChar;
                ParArranhoes.Size = 50;
                ParArranhoes.Value = OS.Arranhoes;
                SqlCmd.Parameters.Add(ParArranhoes);

                SqlParameter ParOutros = new SqlParameter();
                ParOutros.ParameterName = "@outros";
                ParOutros.SqlDbType = SqlDbType.VarChar;
                ParOutros.Size = 50;
                ParOutros.Value = OS.Outros;
                SqlCmd.Parameters.Add(ParOutros);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    resp = Atualizar_Num_Auto_OS(this.Num_OS);
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


        //Método Inserir OS + Detalhe OS
        public string Inserir_Tudo(DOS OS, List<DDetalhe_OS> DOS)
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
                SqlCmd.CommandText = "spinserir_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdRemetente = new SqlParameter();
                ParIdRemetente.ParameterName = "@idremetente";
                ParIdRemetente.SqlDbType = SqlDbType.Int;
                ParIdRemetente.Value = OS.IdRemetente;
                SqlCmd.Parameters.Add(ParIdRemetente);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = OS.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParNum_OS = new SqlParameter();
                ParNum_OS.ParameterName = "@num_os";
                ParNum_OS.SqlDbType = SqlDbType.Int;
                ParNum_OS.Value = OS.Num_OS;
                SqlCmd.Parameters.Add(ParNum_OS);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = OS.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = OS.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTecnico = new SqlParameter();
                ParIdTecnico.ParameterName = "@idtecnico";
                ParIdTecnico.SqlDbType = SqlDbType.Int;
                ParIdTecnico.Value = OS.IdTecnico;
                SqlCmd.Parameters.Add(ParIdTecnico);

                SqlParameter ParIdEquipamento = new SqlParameter();
                ParIdEquipamento.ParameterName = "@idequipamento";
                ParIdEquipamento.SqlDbType = SqlDbType.Int;
                ParIdEquipamento.Value = OS.IdEquipamento;
                SqlCmd.Parameters.Add(ParIdEquipamento);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = OS.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = OS.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParNum_Serie = new SqlParameter();
                ParNum_Serie.ParameterName = "@num_serie";
                ParNum_Serie.SqlDbType = SqlDbType.VarChar;
                ParNum_Serie.Size = 50;
                ParNum_Serie.Value = OS.Num_Serie;
                SqlCmd.Parameters.Add(ParNum_Serie);

                SqlParameter ParCor = new SqlParameter();
                ParCor.ParameterName = "@cor";
                ParCor.SqlDbType = SqlDbType.VarChar;
                ParCor.Size = 50;
                ParCor.Value = OS.Cor;
                SqlCmd.Parameters.Add(ParCor);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = OS.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = OS.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParUf_Placa = new SqlParameter();
                ParUf_Placa.ParameterName = "@uf_placa";
                ParUf_Placa.SqlDbType = SqlDbType.VarChar;
                ParUf_Placa.Size = 2;
                ParUf_Placa.Value = OS.Uf_Placa;
                SqlCmd.Parameters.Add(ParUf_Placa);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@km";
                ParKm.SqlDbType = SqlDbType.VarChar;
                ParKm.Size = 50;
                ParKm.Value = OS.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParObservacoes_Cliente = new SqlParameter();
                ParObservacoes_Cliente.ParameterName = "@observacoes_cliente";
                ParObservacoes_Cliente.SqlDbType = SqlDbType.VarChar;
                ParObservacoes_Cliente.Size = 150;
                ParObservacoes_Cliente.Value = OS.Observacoes_Cliente;
                SqlCmd.Parameters.Add(ParObservacoes_Cliente);

                SqlParameter ParDiagnostico = new SqlParameter();
                ParDiagnostico.ParameterName = "@diagnostico";
                ParDiagnostico.SqlDbType = SqlDbType.VarChar;
                ParDiagnostico.Size = 150;
                ParDiagnostico.Value = OS.Diagnostico;
                SqlCmd.Parameters.Add(ParDiagnostico);

                SqlParameter ParAuto_Cliente = new SqlParameter();
                ParAuto_Cliente.ParameterName = "@auto_cliente";
                ParAuto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParAuto_Cliente.Size = 9;
                ParAuto_Cliente.Value = OS.Auto_Cliente;
                SqlCmd.Parameters.Add(ParAuto_Cliente);

                SqlParameter ParEstado_OS = new SqlParameter();
                ParEstado_OS.ParameterName = "@estado_os";
                ParEstado_OS.SqlDbType = SqlDbType.VarChar;
                ParEstado_OS.Size = 20;
                ParEstado_OS.Value = OS.Estado_OS;
                SqlCmd.Parameters.Add(ParEstado_OS);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.DateTime;
                ParData_Entrada.Value = OS.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParData_Auto_Cliente = new SqlParameter();
                ParData_Auto_Cliente.ParameterName = "@data_auto_cliente";
                ParData_Auto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParData_Auto_Cliente.Size = 20;
                ParData_Auto_Cliente.Value = OS.Data_Auto_Cliente;
                SqlCmd.Parameters.Add(ParData_Auto_Cliente);

                SqlParameter ParData_Pronto = new SqlParameter();
                ParData_Pronto.ParameterName = "@data_pronto";
                ParData_Pronto.SqlDbType = SqlDbType.VarChar;
                ParData_Pronto.Size = 20;
                ParData_Pronto.Value = OS.Data_Pronto;
                SqlCmd.Parameters.Add(ParData_Pronto);

                SqlParameter ParData_Retirada = new SqlParameter();
                ParData_Retirada.ParameterName = "@data_retirada";
                ParData_Retirada.SqlDbType = SqlDbType.VarChar;
                ParData_Retirada.Size = 20;
                ParData_Retirada.Value = OS.Data_Retirada;
                SqlCmd.Parameters.Add(ParData_Retirada);

                SqlParameter ParTotal = new SqlParameter();
                ParTotal.ParameterName = "@total";
                ParTotal.SqlDbType = SqlDbType.Decimal;
                ParTotal.Precision = 7;
                ParTotal.Scale = 2;
                ParTotal.Value = OS.Total;
                SqlCmd.Parameters.Add(ParTotal);

                SqlParameter ParPrevisao_entrega = new SqlParameter();
                ParPrevisao_entrega.ParameterName = "@previsao_entrega";
                ParPrevisao_entrega.SqlDbType = SqlDbType.VarChar;
                ParPrevisao_entrega.Size = 20;
                ParPrevisao_entrega.Value = OS.Previsao_entrega;
                SqlCmd.Parameters.Add(ParPrevisao_entrega);

                SqlParameter ParAcessorios = new SqlParameter();
                ParAcessorios.ParameterName = "@entrada_com_acessorios";
                ParAcessorios.SqlDbType = SqlDbType.VarChar;
                ParAcessorios.Size = 50;
                ParAcessorios.Value = OS.Acessorios;
                SqlCmd.Parameters.Add(ParAcessorios);

                SqlParameter ParParafusos_Faltando = new SqlParameter();
                ParParafusos_Faltando.ParameterName = "@parafusos_faltando";
                ParParafusos_Faltando.SqlDbType = SqlDbType.VarChar;
                ParParafusos_Faltando.Size = 5;
                ParParafusos_Faltando.Value = OS.Parafusos_Faltando;
                SqlCmd.Parameters.Add(ParParafusos_Faltando);

                SqlParameter ParPartes_Quebradas = new SqlParameter();
                ParPartes_Quebradas.ParameterName = "@partes_quebradas";
                ParPartes_Quebradas.SqlDbType = SqlDbType.VarChar;
                ParPartes_Quebradas.Size = 50;
                ParPartes_Quebradas.Value = OS.Partes_Quebradas;
                SqlCmd.Parameters.Add(ParPartes_Quebradas);

                SqlParameter ParArranhoes = new SqlParameter();
                ParArranhoes.ParameterName = "@arranhados";
                ParArranhoes.SqlDbType = SqlDbType.VarChar;
                ParArranhoes.Size = 50;
                ParArranhoes.Value = OS.Arranhoes;
                SqlCmd.Parameters.Add(ParArranhoes);

                SqlParameter ParOutros = new SqlParameter();
                ParOutros.ParameterName = "@outros";
                ParOutros.SqlDbType = SqlDbType.VarChar;
                ParOutros.Size = 50;
                ParOutros.Value = OS.Outros;
                SqlCmd.Parameters.Add(ParOutros);
                
                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    //Obter o código id de entrada gerado
                    this.IdOS = Convert.ToInt32(SqlCmd.Parameters["@idos"].Value);

                    foreach (DDetalhe_OS detOS in DOS)
                    {
                        detOS.IdOS = this.IdOS;

                        //Chamar método inserir no detalhes entrada
                        resp = detOS.Inserir_Tudo(detOS, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Ok"))
                        {
                            break;
                        }
                        else
                        {
                            if (resp.Equals("Ok"))
                            {
                                resp = Atualizar_Num_Auto_OS(this.Num_OS);
                            }
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


        //Metodo Editar
        public string Editar(DOS OS)
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
                SqlCmd.CommandText = "speditar_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = OS.IdOS;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = OS.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = OS.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = OS.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTecnico = new SqlParameter();
                ParIdTecnico.ParameterName = "@idtecnico";
                ParIdTecnico.SqlDbType = SqlDbType.Int;
                ParIdTecnico.Value = OS.IdTecnico;
                SqlCmd.Parameters.Add(ParIdTecnico);

                SqlParameter ParIdEquipamento = new SqlParameter();
                ParIdEquipamento.ParameterName = "@idequipamento";
                ParIdEquipamento.SqlDbType = SqlDbType.Int;
                ParIdEquipamento.Value = OS.IdEquipamento;
                SqlCmd.Parameters.Add(ParIdEquipamento);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = OS.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = OS.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParNum_Serie = new SqlParameter();
                ParNum_Serie.ParameterName = "@num_serie";
                ParNum_Serie.SqlDbType = SqlDbType.VarChar;
                ParNum_Serie.Size = 50;
                ParNum_Serie.Value = OS.Num_Serie;
                SqlCmd.Parameters.Add(ParNum_Serie);

                SqlParameter ParCor = new SqlParameter();
                ParCor.ParameterName = "@cor";
                ParCor.SqlDbType = SqlDbType.VarChar;
                ParCor.Size = 50;
                ParCor.Value = OS.Cor;
                SqlCmd.Parameters.Add(ParCor);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = OS.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = OS.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParUf_Placa = new SqlParameter();
                ParUf_Placa.ParameterName = "@uf_placa";
                ParUf_Placa.SqlDbType = SqlDbType.VarChar;
                ParUf_Placa.Size = 2;
                ParUf_Placa.Value = OS.Uf_Placa;
                SqlCmd.Parameters.Add(ParUf_Placa);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@km";
                ParKm.SqlDbType = SqlDbType.VarChar;
                ParKm.Size = 50;
                ParKm.Value = OS.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParObservacoes_Cliente = new SqlParameter();
                ParObservacoes_Cliente.ParameterName = "@observacoes_cliente";
                ParObservacoes_Cliente.SqlDbType = SqlDbType.VarChar;
                ParObservacoes_Cliente.Size = 150;
                ParObservacoes_Cliente.Value = OS.Observacoes_Cliente;
                SqlCmd.Parameters.Add(ParObservacoes_Cliente);

                SqlParameter ParDiagnostico = new SqlParameter();
                ParDiagnostico.ParameterName = "@diagnostico";
                ParDiagnostico.SqlDbType = SqlDbType.VarChar;
                ParDiagnostico.Size = 150;
                ParDiagnostico.Value = OS.Diagnostico;
                SqlCmd.Parameters.Add(ParDiagnostico);

                SqlParameter ParAuto_Cliente = new SqlParameter();
                ParAuto_Cliente.ParameterName = "@auto_cliente";
                ParAuto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParAuto_Cliente.Size = 9;
                ParAuto_Cliente.Value = OS.Auto_Cliente;
                SqlCmd.Parameters.Add(ParAuto_Cliente);

                SqlParameter ParEstado_OS = new SqlParameter();
                ParEstado_OS.ParameterName = "@estado_os";
                ParEstado_OS.SqlDbType = SqlDbType.VarChar;
                ParEstado_OS.Size = 20;
                ParEstado_OS.Value = OS.Estado_OS;
                SqlCmd.Parameters.Add(ParEstado_OS);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.DateTime;
                ParData_Entrada.Value = OS.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParData_Auto_Cliente = new SqlParameter();
                ParData_Auto_Cliente.ParameterName = "@data_auto_cliente";
                ParData_Auto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParData_Auto_Cliente.Size = 20;
                ParData_Auto_Cliente.Value = OS.Data_Auto_Cliente;
                SqlCmd.Parameters.Add(ParData_Auto_Cliente);

                SqlParameter ParData_Pronto = new SqlParameter();
                ParData_Pronto.ParameterName = "@data_pronto";
                ParData_Pronto.SqlDbType = SqlDbType.VarChar;
                ParData_Pronto.Size = 20;
                ParData_Pronto.Value = OS.Data_Pronto;
                SqlCmd.Parameters.Add(ParData_Pronto);

                SqlParameter ParData_Retirada = new SqlParameter();
                ParData_Retirada.ParameterName = "@data_retirada";
                ParData_Retirada.SqlDbType = SqlDbType.VarChar;
                ParData_Retirada.Size = 20;
                ParData_Retirada.Value = OS.Data_Retirada;
                SqlCmd.Parameters.Add(ParData_Retirada);

                SqlParameter ParPrevisao_entrega = new SqlParameter();
                ParPrevisao_entrega.ParameterName = "@previsao_entrega";
                ParPrevisao_entrega.SqlDbType = SqlDbType.VarChar;
                ParPrevisao_entrega.Size = 20;
                ParPrevisao_entrega.Value = OS.Previsao_entrega;
                SqlCmd.Parameters.Add(ParPrevisao_entrega);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A atualização não foi feita";

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
        public string Excluir(DOS OS)
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
                SqlCmd.CommandText = "spdeletar_os";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = OS.IdOS;
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
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_os";
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

        //Metodo Buscar pelo Cliente
        public DataTable Buscar_Pelo_Cliente(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_cliente";
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


        //Metodo Buscar Pronta pelo Cliente
        public DataTable Buscar_OS_Pronta_Pelo_Cliente(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_pronto_cliente";
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


        //Metodo Buscar pelo Numero da OS
        public DataTable Buscar_Pelo_Numero_OS(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_numero";
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


        //Metodo Buscar OS Pronta pelo Numero 
        public DataTable Buscar_OS_Pronta_Pelo_Numero(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_pronto_numero";
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


        //Método Buscar por Datas
        public DataTable BuscarData(string TextoBuscar, string TextoBuscar2)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_data";
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
            DataTable DtResultado = new DataTable("detalhe_os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_os";
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


        // Inserir OS em Branco
        public string Inserir_OS_Em_Branco(DOS OS)
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
                SqlCmd.CommandText = "spinserir_os_em_branco";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = OS.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParNum_OS = new SqlParameter();
                ParNum_OS.ParameterName = "@num_os";
                ParNum_OS.SqlDbType = SqlDbType.Int;
                ParNum_OS.Value = OS.Num_OS;
                SqlCmd.Parameters.Add(ParNum_OS);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = OS.Tipo;
                SqlCmd.Parameters.Add(ParTipo);
                
                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.DateTime;
                ParData_Entrada.Value = OS.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);
                
                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "Registro não foi Inserido";

                if (resp.Equals("Ok"))
                {
                    resp = Atualizar_Num_Auto_OS(this.Num_OS);
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
        public string Editar_OS_Em_Branco(DOS OS)
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
                SqlCmd.CommandText = "speditar_os_em_branco";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idos";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = OS.IdOS;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = OS.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = OS.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = OS.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);

                SqlParameter ParIdTecnico = new SqlParameter();
                ParIdTecnico.ParameterName = "@idtecnico";
                ParIdTecnico.SqlDbType = SqlDbType.Int;
                ParIdTecnico.Value = OS.IdTecnico;
                SqlCmd.Parameters.Add(ParIdTecnico);

                SqlParameter ParIdEquipamento = new SqlParameter();
                ParIdEquipamento.ParameterName = "@idequipamento";
                ParIdEquipamento.SqlDbType = SqlDbType.Int;
                ParIdEquipamento.Value = OS.IdEquipamento;
                SqlCmd.Parameters.Add(ParIdEquipamento);

                SqlParameter ParMarca = new SqlParameter();
                ParMarca.ParameterName = "@marca";
                ParMarca.SqlDbType = SqlDbType.VarChar;
                ParMarca.Size = 50;
                ParMarca.Value = OS.Marca;
                SqlCmd.Parameters.Add(ParMarca);

                SqlParameter ParModelo = new SqlParameter();
                ParModelo.ParameterName = "@modelo";
                ParModelo.SqlDbType = SqlDbType.VarChar;
                ParModelo.Size = 50;
                ParModelo.Value = OS.Modelo;
                SqlCmd.Parameters.Add(ParModelo);

                SqlParameter ParNum_Serie = new SqlParameter();
                ParNum_Serie.ParameterName = "@num_serie";
                ParNum_Serie.SqlDbType = SqlDbType.VarChar;
                ParNum_Serie.Size = 50;
                ParNum_Serie.Value = OS.Num_Serie;
                SqlCmd.Parameters.Add(ParNum_Serie);

                SqlParameter ParCor = new SqlParameter();
                ParCor.ParameterName = "@cor";
                ParCor.SqlDbType = SqlDbType.VarChar;
                ParCor.Size = 50;
                ParCor.Value = OS.Cor;
                SqlCmd.Parameters.Add(ParCor);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = OS.Senha;
                SqlCmd.Parameters.Add(ParSenha);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 8;
                ParPlaca.Value = OS.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParUf_Placa = new SqlParameter();
                ParUf_Placa.ParameterName = "@uf_placa";
                ParUf_Placa.SqlDbType = SqlDbType.VarChar;
                ParUf_Placa.Size = 2;
                ParUf_Placa.Value = OS.Uf_Placa;
                SqlCmd.Parameters.Add(ParUf_Placa);

                SqlParameter ParKm = new SqlParameter();
                ParKm.ParameterName = "@km";
                ParKm.SqlDbType = SqlDbType.VarChar;
                ParKm.Size = 50;
                ParKm.Value = OS.Km;
                SqlCmd.Parameters.Add(ParKm);

                SqlParameter ParObservacoes_Cliente = new SqlParameter();
                ParObservacoes_Cliente.ParameterName = "@observacoes_cliente";
                ParObservacoes_Cliente.SqlDbType = SqlDbType.VarChar;
                ParObservacoes_Cliente.Size = 150;
                ParObservacoes_Cliente.Value = OS.Observacoes_Cliente;
                SqlCmd.Parameters.Add(ParObservacoes_Cliente);

                SqlParameter ParDiagnostico = new SqlParameter();
                ParDiagnostico.ParameterName = "@diagnostico";
                ParDiagnostico.SqlDbType = SqlDbType.VarChar;
                ParDiagnostico.Size = 150;
                ParDiagnostico.Value = OS.Diagnostico;
                SqlCmd.Parameters.Add(ParDiagnostico);

                SqlParameter ParAuto_Cliente = new SqlParameter();
                ParAuto_Cliente.ParameterName = "@auto_cliente";
                ParAuto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParAuto_Cliente.Size = 9;
                ParAuto_Cliente.Value = OS.Auto_Cliente;
                SqlCmd.Parameters.Add(ParAuto_Cliente);

                SqlParameter ParEstado_OS = new SqlParameter();
                ParEstado_OS.ParameterName = "@estado_os";
                ParEstado_OS.SqlDbType = SqlDbType.VarChar;
                ParEstado_OS.Size = 20;
                ParEstado_OS.Value = OS.Estado_OS;
                SqlCmd.Parameters.Add(ParEstado_OS);

                SqlParameter ParData_Entrada = new SqlParameter();
                ParData_Entrada.ParameterName = "@data_entrada";
                ParData_Entrada.SqlDbType = SqlDbType.DateTime;
                ParData_Entrada.Value = OS.Data_Entrada;
                SqlCmd.Parameters.Add(ParData_Entrada);

                SqlParameter ParData_Auto_Cliente = new SqlParameter();
                ParData_Auto_Cliente.ParameterName = "@data_auto_cliente";
                ParData_Auto_Cliente.SqlDbType = SqlDbType.VarChar;
                ParData_Auto_Cliente.Size = 20;
                ParData_Auto_Cliente.Value = OS.Data_Auto_Cliente;
                SqlCmd.Parameters.Add(ParData_Auto_Cliente);

                SqlParameter ParData_Pronto = new SqlParameter();
                ParData_Pronto.ParameterName = "@data_pronto";
                ParData_Pronto.SqlDbType = SqlDbType.VarChar;
                ParData_Pronto.Size = 20;
                ParData_Pronto.Value = OS.Data_Pronto;
                SqlCmd.Parameters.Add(ParData_Pronto);

                SqlParameter ParData_Retirada = new SqlParameter();
                ParData_Retirada.ParameterName = "@data_retirada";
                ParData_Retirada.SqlDbType = SqlDbType.VarChar;
                ParData_Retirada.Size = 20;
                ParData_Retirada.Value = OS.Data_Retirada;
                SqlCmd.Parameters.Add(ParData_Retirada);

                SqlParameter ParPrevisao_entrega = new SqlParameter();
                ParPrevisao_entrega.ParameterName = "@previsao_entrega";
                ParPrevisao_entrega.SqlDbType = SqlDbType.VarChar;
                ParPrevisao_entrega.Size = 20;
                ParPrevisao_entrega.Value = OS.Previsao_entrega;
                SqlCmd.Parameters.Add(ParPrevisao_entrega);

                SqlParameter ParAcessorios = new SqlParameter();
                ParAcessorios.ParameterName = "@entrada_com_acessorios";
                ParAcessorios.SqlDbType = SqlDbType.VarChar;
                ParAcessorios.Size = 50;
                ParAcessorios.Value = OS.Acessorios;
                SqlCmd.Parameters.Add(ParAcessorios);

                SqlParameter ParParafusos_Faltando = new SqlParameter();
                ParParafusos_Faltando.ParameterName = "@parafusos_faltando";
                ParParafusos_Faltando.SqlDbType = SqlDbType.VarChar;
                ParParafusos_Faltando.Size = 5;
                ParParafusos_Faltando.Value = OS.Parafusos_Faltando;
                SqlCmd.Parameters.Add(ParParafusos_Faltando);

                SqlParameter ParPartes_Quebradas = new SqlParameter();
                ParPartes_Quebradas.ParameterName = "@partes_quebradas";
                ParPartes_Quebradas.SqlDbType = SqlDbType.VarChar;
                ParPartes_Quebradas.Size = 50;
                ParPartes_Quebradas.Value = OS.Partes_Quebradas;
                SqlCmd.Parameters.Add(ParPartes_Quebradas);

                SqlParameter ParArranhoes = new SqlParameter();
                ParArranhoes.ParameterName = "@arranhados";
                ParArranhoes.SqlDbType = SqlDbType.VarChar;
                ParArranhoes.Size = 50;
                ParArranhoes.Value = OS.Arranhoes;
                SqlCmd.Parameters.Add(ParArranhoes);

                SqlParameter ParOutros = new SqlParameter();
                ParOutros.ParameterName = "@outros";
                ParOutros.SqlDbType = SqlDbType.VarChar;
                ParOutros.Size = 50;
                ParOutros.Value = OS.Outros;
                SqlCmd.Parameters.Add(ParOutros);

                //Executar o comando
                resp = SqlCmd.ExecuteNonQuery() > 0 ? "Ok" : "A atualização não foi feita";

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


        //Método Mostrar OS em Branco
        public DataTable Mostrar_OS_Em_Branco()
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_os_em_branco";
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


        //Método Buscar OS pelo ID
        public DataTable Buscar_OS_ID(int IDOS)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_id";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDOS = new SqlParameter();
                ParIDOS.ParameterName = "@idos";
                ParIDOS.SqlDbType = SqlDbType.Int;
                ParIDOS.Value = IDOS;
                SqlCmd.Parameters.Add(ParIDOS);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Buscar OS Pronta pelo ID
        public DataTable Buscar_OS_Pronta_ID(int IDOS)
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_pronta_id";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIDOS = new SqlParameter();
                ParIDOS.ParameterName = "@idos";
                ParIDOS.SqlDbType = SqlDbType.Int;
                ParIDOS.Value = IDOS;
                SqlCmd.Parameters.Add(ParIDOS);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        //Método Buscar OS Pronta
        public DataTable Buscar_OS_Pronta()
        {
            DataTable DtResultado = new DataTable("os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_os_pronto";
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


        //Método Mostrar Detalhes para Importação no caixa
        public DataTable MostrarDetalhes_Import_Caixa(int TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_os");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_os_importacao_caixa";
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


        //Metodo Atualizar Status OS Importada
        public string Atualizar_Status_OS_Importada(DOS OS)
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
                SqlCmd.CommandText = "spatualizar_status_os_importada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = OS.IdOS;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParData_Retirada = new SqlParameter();
                ParData_Retirada.ParameterName = "@data_retirada";
                ParData_Retirada.SqlDbType = SqlDbType.VarChar;
                ParData_Retirada.Size = 20;
                ParData_Retirada.Value = OS.Data_Retirada;
                SqlCmd.Parameters.Add(ParData_Retirada);

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
    }
}
