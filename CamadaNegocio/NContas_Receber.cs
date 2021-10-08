using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NContas_Receber
    {
        //Medoto Inserir Contas Receber Após Venda
        public static string Inserir_Contas_Receber_Apos_Venda(int idvenda, DateTime data_entrada, string cliente_nome, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCR)
        {
            DContas_Receber Obj = new DContas_Receber();
            Obj.IdVenda = idvenda;
            Obj.Data_Entrada = data_entrada;
            Obj.Cliente_Nome = cliente_nome;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;
            Obj.Valor_Total_Atualizado = valor_total;

            List<DDetalhe_Contas_Receber> detalhes = new List<DDetalhe_Contas_Receber>();

            foreach (DataRow row in dtCR.Rows)
            {
                DDetalhe_Contas_Receber detalheCR = new DDetalhe_Contas_Receber();
                detalheCR.IdCliente = Convert.ToInt32(row["idcliente"].ToString());
                detalheCR.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCR.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCR.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCR.Estado = row["estado"].ToString();
                detalheCR.Obs = row["obs"].ToString();
                detalheCR.Valor_Atualizado = Convert.ToDecimal(row["valor"].ToString());
                detalhes.Add(detalheCR);
            }

            return Obj.Inserir_Contas_Receber_Apos_Venda(Obj, detalhes);
        }


        //Medoto Inserir Devedor Cadastrado
        public static string Inserir_Devedor_Cadastrado(DateTime data_entrada, string cliente_nome, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCR)
        {
            DContas_Receber Obj = new DContas_Receber();
            Obj.Data_Entrada = data_entrada;
            Obj.Cliente_Nome = cliente_nome;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;
            Obj.Valor_Total_Atualizado = valor_total;

            List<DDetalhe_Contas_Receber> detalhes = new List<DDetalhe_Contas_Receber>();

            foreach (DataRow row in dtCR.Rows)
            {
                DDetalhe_Contas_Receber detalheCR = new DDetalhe_Contas_Receber();
                detalheCR.IdCliente = Convert.ToInt32(row["idcliente"].ToString());
                detalheCR.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCR.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCR.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCR.Estado = row["estado"].ToString();
                detalheCR.Obs = row["obs"].ToString();
                detalheCR.Valor_Atualizado = Convert.ToDecimal(row["valor"].ToString());
                detalhes.Add(detalheCR);
            }
            
            return Obj.Inserir_Devedor_Cadastrado(Obj, detalhes);
        }


        //Medoto Inserir Devedor Não Cadastrado
        public static string Inserir_Devedor_Nao_Cadastrado(DateTime data_entrada, string devedor_nao_cadastrado, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCR)
        {
            DContas_Receber Obj = new DContas_Receber();
            Obj.Data_Entrada = data_entrada;
            Obj.Devedor_Nao_Cadastrado = devedor_nao_cadastrado;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;
            Obj.Valor_Total_Atualizado = valor_total;

            List<DDetalhe_Contas_Receber> detalhes = new List<DDetalhe_Contas_Receber>();

            foreach (DataRow row in dtCR.Rows)
            {
                DDetalhe_Contas_Receber detalheCR = new DDetalhe_Contas_Receber();
                detalheCR.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCR.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCR.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCR.Estado = row["estado"].ToString();
                detalheCR.Obs = row["obs"].ToString();
                detalheCR.Valor_Atualizado = Convert.ToDecimal(row["valor"].ToString());
                detalhes.Add(detalheCR);
            }

            return Obj.Inserir_Devedor_Nao_Cadastrado(Obj, detalhes);
        }

        //Medoto Inserir Parcela
        public static string Inserir_Parcela(int idcontas_receber, int idcliente, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs)
        {
            DDetalhe_Contas_Receber Obj = new DDetalhe_Contas_Receber();
            Obj.IdContas_Receber = idcontas_receber;
            Obj.IdCliente = idcliente;
            Obj.Num_Parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Vencimento = vencimento;
            Obj.Estado = estado;
            Obj.Obs = obs;
            Obj.Valor_Atualizado = valor;
            return Obj.Inserir_Parcela(Obj);
        }


        //Medoto Deletar Parcelas
        public static string ExcluirParcelas(int id)
        {
            DDetalhe_Contas_Receber Obj = new DDetalhe_Contas_Receber();
            Obj.IdDetalhe_Contas_Receber = id;
            return Obj.Excluir(Obj);
        }


        //Medoto Deletar Tudo
        public static string ExcluirTudo(int id)
        {
            DContas_Receber Obj = new DContas_Receber();
            Obj.IdContas_Receber = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DContas_Receber().Mostrar();
        }


        //Método Mostrar Detalhes
        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DContas_Receber Obj = new DContas_Receber();
            return Obj.MostrarDetalhes(textobuscar);
        }


        //Método Buscar Pelo Nome Cliente
        public static DataTable Buscar_Pelo_Cliente(string textobuscar)
        {
            DContas_Receber Obj = new DContas_Receber();
            return Obj.Buscar_Pelo_Cliente(textobuscar);
        }


        //Método Pesquisa Específica
        public static DataTable Pesquisa_Especifica(string data_inicial, string data_final, string devedor)
        {
            DContas_Receber Obj = new DContas_Receber();
            return Obj.Pesquisa_Especifica(data_inicial, data_final, devedor);
        }

        //Método Buscar Parcelas Vencidas
        public static DataTable Buscar_Parcelas_Vencidas(string Data_Atual)
        {
            DContas_Receber Obj = new DContas_Receber();
            return Obj.Buscar_Parcelas_Vencidas(Data_Atual);
        }

        //Medoto Atualizar Status Detalhe Contas Receber
        public static string Atualizar_Status_Parcelas(int id)
        {
            DDetalhe_Contas_Receber Obj = new DDetalhe_Contas_Receber();
            Obj.IdDetalhe_Contas_Receber = id;
            return Obj.Atualizar_Status_Parcelas_Contas_Receber(Obj);
        }

        //Medoto Atualizar Valor Detalhe Contas Receber
        public static string Atualizar_Valor_Detalhe_Contas_Receber(int id, decimal valor_atualizado)
        {
            DDetalhe_Contas_Receber Obj = new DDetalhe_Contas_Receber();
            Obj.IdDetalhe_Contas_Receber = id;
            Obj.Valor_Atualizado = valor_atualizado;
            return Obj.Atualizar_Valor_Detalhe_Contas_Receber(Obj);
        }


        //Medoto Atualizar Valor Total Contas Receber
        public static string Atualizar_Valor_Total_Contas_Receber(int id, decimal valor_total_atualizado)
        {
            DContas_Receber Obj = new DContas_Receber();
            Obj.IdContas_Receber = id;
            Obj.Valor_Total_Atualizado = valor_total_atualizado;
            return Obj.Atualizar_Valor_Total_Contas_Receber(Obj);
        }


        //Metodo Mostrar Todos os registros
        public static DataTable Mostrar_Todos_Registros()
        {
            return new DContas_Receber().Mostrar_Todos_Registros();
        }
    } 
}
