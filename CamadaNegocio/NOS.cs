using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NOS
    {
        // Inserir Somente OS
        public static string Inserir_OS(int idremetente, DateTime data, int num_os, string tipo, int idcliente, int idtecnico, int idequipamento, string marca, string modelo, string num_serie, string cor, string senha, string placa, string uf_placa, string km, string observacoes_cliente, string diagnostico, string auto_cliente, string estado_os, DateTime data_entrada, string data_auto_cliente, string data_pronto, string data_retirada, decimal total, string previsao_entrega, string acessorios, string parafusos_faltando, string partes_quebradas, string arranhoes, string outros)
        {
            DOS Obj = new DOS();
            Obj.IdRemetente = idremetente;
            Obj.Data = data;
            Obj.Num_OS = num_os;
            Obj.Tipo = tipo;
            Obj.IdCliente = idcliente;
            Obj.IdTecnico = idtecnico;
            Obj.IdEquipamento = idequipamento;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Num_Serie = num_serie;
            Obj.Cor = cor;
            Obj.Senha = senha;
            Obj.Placa = placa;
            Obj.Uf_Placa = uf_placa;
            Obj.Km = km;
            Obj.Observacoes_Cliente = observacoes_cliente;
            Obj.Diagnostico = diagnostico;
            Obj.Auto_Cliente = auto_cliente;
            Obj.Estado_OS = estado_os;
            Obj.Data_Entrada = data_entrada;
            Obj.Data_Auto_Cliente = data_auto_cliente;
            Obj.Data_Pronto = data_pronto;
            Obj.Data_Retirada = data_retirada;
            Obj.Total = total;
            Obj.Previsao_entrega = previsao_entrega;
            Obj.Acessorios = acessorios;
            Obj.Parafusos_Faltando = parafusos_faltando;
            Obj.Partes_Quebradas = partes_quebradas;
            Obj.Arranhoes = arranhoes;
            Obj.Outros = outros;
            return Obj.Inserir_OS(Obj);
        }

        //Método Inserir OS + Detalhe OS
        public static string Inserir_Tudo(int idremetente, DateTime data, int num_os, string tipo, int idcliente, int idtecnico, int idequipamento, string marca, string modelo, string num_serie, string cor, string senha, string placa, string uf_placa, string km, string observacoes_cliente, string diagnostico, string auto_cliente, string estado_os, DateTime data_entrada, string data_auto_cliente, string data_pronto, string data_retirada, decimal total, string previsao_entrega, string acessorios, string parafusos_faltando, string partes_quebradas, string arranhoes, string outros, DataTable dtDOS)
        {
            DOS Obj = new DOS();
            Obj.IdRemetente = idremetente;
            Obj.Data = data;
            Obj.Num_OS = num_os;
            Obj.Tipo = tipo;
            Obj.IdCliente = idcliente;
            Obj.IdTecnico = idtecnico;
            Obj.IdEquipamento = idequipamento;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Num_Serie = num_serie;
            Obj.Cor = cor;
            Obj.Senha = senha;
            Obj.Placa = placa;
            Obj.Uf_Placa = uf_placa;
            Obj.Km = km;
            Obj.Observacoes_Cliente = observacoes_cliente;
            Obj.Diagnostico = diagnostico;
            Obj.Auto_Cliente = auto_cliente;
            Obj.Estado_OS = estado_os;
            Obj.Data_Entrada = data_entrada;
            Obj.Data_Auto_Cliente = data_auto_cliente;
            Obj.Data_Pronto = data_pronto;
            Obj.Data_Retirada = data_retirada;
            Obj.Total = total;
            Obj.Previsao_entrega = previsao_entrega;
            Obj.Acessorios = acessorios;
            Obj.Parafusos_Faltando = parafusos_faltando;
            Obj.Partes_Quebradas = partes_quebradas;
            Obj.Arranhoes = arranhoes;
            Obj.Outros = outros;

            List<DDetalhe_OS> dos = new List<DDetalhe_OS>();

            foreach (DataRow row in dtDOS.Rows)
            {
                DDetalhe_OS detalheOS = new DDetalhe_OS();
                detalheOS.IdProduto = Convert.ToInt32(row["idproduto"].ToString());
                detalheOS.Quant = Convert.ToDecimal(row["quant"].ToString());
                detalheOS.Preco_Venda = Convert.ToDecimal(row["preco_venda"].ToString());
                dos.Add(detalheOS);
            }

            return Obj.Inserir_Tudo(Obj, dos);
        }


        //Método Editar
        public static string Editar(int idos, DateTime data, string tipo, int idcliente, int idtecnico, int idequipamento, string marca, string modelo, string num_serie, string cor, string senha, string placa, string uf_placa, string km, string observacoes_cliente, string diagnostico, string auto_cliente, string estado_os, DateTime data_entrada, string data_auto_cliente, string data_pronto, string data_retirada, string previsao_entrega)
        {
            DOS Obj = new DOS();
            Obj.IdOS = idos;
            Obj.Data = data;
            Obj.Tipo = tipo;
            Obj.IdCliente = idcliente;
            Obj.IdTecnico = idtecnico;
            Obj.IdEquipamento = idequipamento;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Num_Serie = num_serie;
            Obj.Cor = cor;
            Obj.Senha = senha;
            Obj.Placa = placa;
            Obj.Uf_Placa = uf_placa;
            Obj.Km = km;
            Obj.Observacoes_Cliente = observacoes_cliente;
            Obj.Diagnostico = diagnostico;
            Obj.Auto_Cliente = auto_cliente;
            Obj.Estado_OS = estado_os;
            Obj.Data_Entrada = data_entrada;
            Obj.Data_Auto_Cliente = data_auto_cliente;
            Obj.Data_Pronto = data_pronto;
            Obj.Data_Retirada = data_retirada;
            Obj.Previsao_entrega = previsao_entrega;
            return Obj.Editar(Obj);
        }


        //Método Excluir
        public static string Excluir(int idos)
        {
            DOS Obj = new DOS();
            Obj.IdOS = idos;

            return Obj.Excluir(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DOS().Mostrar();
        }

        //Método Buscar pelo Cliente
        public static DataTable Buscar_Pelo_Cliente(string textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_Pelo_Cliente(textobuscar);
        }

        //Método Buscar OS Pronta pelo Cliente
        public static DataTable Buscar_OS_Pronta_Pelo_Cliente(string textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_OS_Pronta_Pelo_Cliente(textobuscar);
        }



        //Método Buscar pelo Numero da OS
        public static DataTable Buscar_Pelo_Numero_OS(string textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_Pelo_Numero_OS(textobuscar);
        }

        //Método Buscar OS Pronto pelo Numero
        public static DataTable Buscar_OS_Pronta_Pelo_Numero(string textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_OS_Pronta_Pelo_Numero(textobuscar);
        }


        //Método Mostrar Detalhes OS
        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.MostrarDetalhes(textobuscar);
        }



        // Inserir Somente OS - EM BRANCO
        public static string Inserir_OS_Em_Branco(DateTime data, int num_os, string tipo,  DateTime data_entrada)
        {
            DOS Obj = new DOS();
            Obj.Data = data;
            Obj.Num_OS = num_os;
            Obj.Tipo = tipo;
            Obj.Data_Entrada = data_entrada;
            return Obj.Inserir_OS_Em_Branco(Obj);
        }

        //Método Editar Somente OS - EM BRANCO
        public static string Editar_OS_Em_Branco(int idos, DateTime data, string tipo, int idcliente, int idtecnico, int idequipamento, string marca, string modelo, string num_serie, string cor, string senha, string placa, string uf_placa, string km, string observacoes_cliente, string diagnostico, string auto_cliente, string estado_os, DateTime data_entrada, string data_auto_cliente, string data_pronto, string data_retirada, string previsao_entrega, string acessorios, string parafusos_faltando, string partes_quebradas, string arranhoes, string outros)
        {
            DOS Obj = new DOS();
            Obj.IdOS = idos;
            Obj.Data = data;
            Obj.Tipo = tipo;
            Obj.IdCliente = idcliente;
            Obj.IdTecnico = idtecnico;
            Obj.IdEquipamento = idequipamento;
            Obj.Marca = marca;
            Obj.Modelo = modelo;
            Obj.Num_Serie = num_serie;
            Obj.Cor = cor;
            Obj.Senha = senha;
            Obj.Placa = placa;
            Obj.Uf_Placa = uf_placa;
            Obj.Km = km;
            Obj.Observacoes_Cliente = observacoes_cliente;
            Obj.Diagnostico = diagnostico;
            Obj.Auto_Cliente = auto_cliente;
            Obj.Estado_OS = estado_os;
            Obj.Data_Entrada = data_entrada;
            Obj.Data_Auto_Cliente = data_auto_cliente;
            Obj.Data_Pronto = data_pronto;
            Obj.Data_Retirada = data_retirada;
            Obj.Previsao_entrega = previsao_entrega;
            Obj.Acessorios = acessorios;
            Obj.Parafusos_Faltando = parafusos_faltando;
            Obj.Partes_Quebradas = partes_quebradas;
            Obj.Arranhoes = arranhoes;
            Obj.Outros = outros;
            return Obj.Editar_OS_Em_Branco(Obj);
        }


        //Método Mostrar OS em Branco
        public static DataTable Mostrar_OS_Em_Branco()
        {
            return new DOS().Mostrar_OS_Em_Branco();
        }


        //Método Buscar OS pelo ID
        public static DataTable Buscar_OS_ID(int idos)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_OS_ID(idos);
        }

        //Método Buscar OS Pronta pelo ID
        public static DataTable Buscar_OS_Pronta_ID(int idos)
        {
            DOS Obj = new DOS();
            return Obj.Buscar_OS_Pronta_ID(idos);
        }


        //Método Mostrar OS Pronta
        public static DataTable Buscar_OS_Pronta()
        {
            return new DOS().Buscar_OS_Pronta();
        }

        //Método Mostrar Detalhes OS para Importação no caixa
        public static DataTable MostrarDetalhes_Import_Caixa(int textobuscar)
        {
            DOS Obj = new DOS();
            return Obj.MostrarDetalhes_Import_Caixa(textobuscar);
        }


        //Método Editar
        public static string Atualizar_Status_OS_Importada(int idos, string data_retirada)
        {
            DOS Obj = new DOS();
            Obj.IdOS = idos;
            Obj.Data_Retirada = data_retirada;
            return Obj.Atualizar_Status_OS_Importada(Obj);
        }
    }
}
