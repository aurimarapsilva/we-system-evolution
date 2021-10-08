using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NContas_Pagar
    {
        //Medoto Inserir Apos Entrada
        public static string Inserir_Contas_Pagar_Apos_Entrada(int identrada, DateTime data_entrada, string fornecedor_nome, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCP)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            Obj.IdEntrada = identrada;
            Obj.Data_Entrada = data_entrada;
            Obj.Fornecedor_Nome = fornecedor_nome;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;

            List<DDetalhe_Contas_Pagar> detalhes = new List<DDetalhe_Contas_Pagar>();

            foreach (DataRow row in dtCP.Rows)
            {
                DDetalhe_Contas_Pagar detalheCP = new DDetalhe_Contas_Pagar();
                detalheCP.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCP.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCP.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCP.Estado = row["estado"].ToString();
                detalheCP.Obs = row["obs"].ToString();
                detalheCP.IdFornecedor = Convert.ToInt32(row["idfornecedor"].ToString());
                detalhes.Add(detalheCP);
            }

            return Obj.Inserir_Contas_Pagar_Apos_Entrada(Obj, detalhes);
        }


        //Medoto Inserir Credor Cadastrado
        public static string Inserir_Credor_Cadastrado(DateTime data_entrada, string fornecedor_nome, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCP)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            Obj.Data_Entrada = data_entrada;
            Obj.Fornecedor_Nome = fornecedor_nome;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;

            List<DDetalhe_Contas_Pagar> detalhes = new List<DDetalhe_Contas_Pagar>();

            foreach (DataRow row in dtCP.Rows)
            {
                DDetalhe_Contas_Pagar detalheCP = new DDetalhe_Contas_Pagar();
                detalheCP.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCP.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCP.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCP.Estado = row["estado"].ToString();
                detalheCP.Obs = row["obs"].ToString();
                detalheCP.IdFornecedor = Convert.ToInt32(row["idfornecedor"].ToString());
                detalhes.Add(detalheCP);
            }

            return Obj.Inserir_Credor_Cadastrado(Obj, detalhes);
        }



        //Medoto Inserir Credor Não Cadastrado
        public static string Inserir_Credor_Nao_Cadastrado(DateTime data_entrada, string credor_nao_cadastrado, string num_doc, string total_parcelas, decimal valor_total, DataTable dtCP)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            Obj.Data_Entrada = data_entrada;
            Obj.Credor_Nao_Cadastrado = credor_nao_cadastrado;
            Obj.Num_Doc = num_doc;
            Obj.Total_Parcelas = total_parcelas;
            Obj.Valor_Total = valor_total;

            List<DDetalhe_Contas_Pagar> detalhes = new List<DDetalhe_Contas_Pagar>();

            foreach (DataRow row in dtCP.Rows)
            {
                DDetalhe_Contas_Pagar detalheCP = new DDetalhe_Contas_Pagar();
                detalheCP.Num_Parcela = Convert.ToInt32(row["num_parcela"].ToString());
                detalheCP.Valor = Convert.ToDecimal(row["valor"].ToString());
                detalheCP.Vencimento = Convert.ToDateTime(row["vencimento"].ToString());
                detalheCP.Estado = row["estado"].ToString();
                detalheCP.Obs = row["obs"].ToString();
                detalhes.Add(detalheCP);
            }

            return Obj.Inserir_Credor_Nao_Cadastrado(Obj, detalhes);
        }


        //Medoto Inserir Parcela
        public static string Inserir_Parcela(int idcontas_pagar, int num_parcela, decimal valor, DateTime vencimento, string estado, string obs, int idfornecedor)
        {
            DDetalhe_Contas_Pagar Obj = new DDetalhe_Contas_Pagar();
            Obj.IdContas_Pagar = idcontas_pagar;
            Obj.Num_Parcela = num_parcela;
            Obj.Valor = valor;
            Obj.Vencimento = vencimento;
            Obj.Estado = estado;
            Obj.Obs = obs;
            Obj.IdFornecedor = idfornecedor;
            return Obj.Inserir_Parcela(Obj);
        }


        //Medoto Deletar Parcelas
        public static string ExcluirParcelas(int id)
        {
            DDetalhe_Contas_Pagar Obj = new DDetalhe_Contas_Pagar();
            Obj.IdDetalhe_Contas_Pagar = id;
            return Obj.Excluir(Obj);
        }


        //Medoto Deletar Tudo
        public static string ExcluirTudo(int id)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            Obj.IdContas_Pagar = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DContas_Pagar().Mostrar();
        }


        //Método Mostrar Detalhes
        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            return Obj.MostrarDetalhes(textobuscar);
        }


        //Método Buscar Pelo Nome do Fornecedor
        public static DataTable Buscar_Pelo_Credor(string textobuscar)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            return Obj.Buscar_Pelo_Credor(textobuscar);
        }


        //Método Pesquisa Específica
        public static DataTable Pesquisa_Especifica(string data_inicial, string data_final, string credor)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            return Obj.Pesquisa_Especifica(data_inicial, data_final, credor);
        }


        //Método Buscar Parcelas Vencidas
        public static DataTable Buscar_Parcelas_Vencidas(string Data_Atual)
        {
            DContas_Pagar Obj = new DContas_Pagar();
            return Obj.Buscar_Parcelas_Vencidas(Data_Atual);
        }


        //Medoto Atualizar Status Detalhe Contas Receber
        public static string Atualizar_Status_Parcelas(int id)
        {
            DDetalhe_Contas_Pagar Obj = new DDetalhe_Contas_Pagar();
            Obj.IdDetalhe_Contas_Pagar = id;
            return Obj.Atualizar_Status_Parcelas_Contas_Pagar(Obj);
        }
    }
}
