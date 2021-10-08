using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NOrcamento
    {
        //Método Inserir
        public static string Inserir(DateTime data, string cliente, string telefone, string entrada_dinheiro, decimal valor_entrada, string forma_pagamento, int idfuncionario, int numero, DataTable dtDO, DataTable dtFPO)
        {
            // Inserir Tabela Orçamento
            DOrcamento Obj = new DOrcamento();
            Obj.Data = data;
            Obj.Cliente = cliente;
            Obj.Telefone = telefone;
            Obj.Entrada_Dinheiro = entrada_dinheiro;
            Obj.Valor_Entrada = valor_entrada;
            Obj.Forma_Pagamento = forma_pagamento;
            Obj.IdFuncionario = idfuncionario;
            Obj.Numero = numero;

            // Inserir tabela detalhe orcamento
            List<DDetalhe_Orcamento> DO = new List<DDetalhe_Orcamento>();
            foreach (DataRow row in dtDO.Rows)
            {
                DDetalhe_Orcamento detalheO = new DDetalhe_Orcamento();
                detalheO.IdProduto = Convert.ToInt32(row["idproduto"].ToString());
                detalheO.Quant = Convert.ToDecimal(row["quant"].ToString());
                detalheO.Preco_Venda = Convert.ToDecimal(row["preco_venda"].ToString());
                DO.Add(detalheO);
            }

            // Inserir tabela formas pgto orcamento
            List<DFormas_Pgto_Orcamento> FPO = new List<DFormas_Pgto_Orcamento>();
            foreach (DataRow linha in dtFPO.Rows)
            {
                DFormas_Pgto_Orcamento f = new DFormas_Pgto_Orcamento();
                f.Forma = linha["forma"].ToString();
                f.Valor_Primario = Convert.ToDecimal(linha["valor_primario"].ToString());
                f.Valor_Final = Convert.ToDecimal(linha["valor_final"].ToString());
                f.Qtd_Parcelas = Convert.ToInt32(linha["qtd_parcelas"].ToString());
                FPO.Add(f);
            }

            return Obj.Inserir(Obj, DO, FPO);
        }


        //Método Excluir
        public static string Excluir(int id)
        {
            DOrcamento Obj = new DOrcamento();
            Obj.IdOrcamento = id;

            return Obj.Excluir(Obj);
        }


        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DOrcamento().Mostrar();
        }


        //Método Mostrar Produtos Orçamento
        public static DataTable Mostrar_Produtos_Orcamento(int idorcamento)
        {
            return new DOrcamento().Mostrar_Produtos_Orcamento(idorcamento);
        }

        //Método Mostrar Produtos Orçamento - IMPORTAÇÃO NO CAIXA
        public static DataTable Mostrar_Produtos_Orcamento_import_Caixa(int idorcamento)
        {
            return new DOrcamento().Mostrar_Produtos_Orcamento_Import_Caixa(idorcamento);
        }

        //Método Mostrar Formas de Pagamento Orçamento
        public static DataTable Mostrar_Formas_Pgto_Orcamento(int idorcamento)
        {
            return new DOrcamento().Mostrar_Formas_Pgto_Orcamento(idorcamento);
        }

        //Método Busar pelo ID
        public static DataTable Buscar_ID(int idorcamento)
        {
            return new DOrcamento().Buscar_ID(idorcamento);
        }


        //Método Buscar Orçamento - CLIENTE
        public static DataTable Buscar_Orcamento_Cliente(string textobuscar)
        {
            return new DOrcamento().Buscar_Orcamento_Cliente(textobuscar);
        }

        //Método Buscar Orçamento - DATAS
        public static DataTable Buscar_Orcamento_Data(string textobuscar, string textobuscar2)
        {
            return new DOrcamento().Buscar_Orcamento_Data(textobuscar, textobuscar2);
        }

        //Método Buscar Orçamento - NUM / ID
        public static DataTable Buscar_Orcamento_Num(string textobuscar)
        {
            return new DOrcamento().Buscar_Orcamento_Num(textobuscar);
        }

        //Método Buscar Produtos - POR DESCRIÇÃO
        public static DataTable Buscar_Produtos_Descricao(string textobuscar)
        {
            DOrcamento Obj = new DOrcamento();
            return Obj.Buscar_Produtos_Descricao(textobuscar);
        }

        //Método Buscar Produtos - POR CÓDIGO
        public static DataTable Buscar_Produtos_Codigo(string textobuscar)
        {
            DOrcamento Obj = new DOrcamento();
            return Obj.Buscar_Produtos_Codigo(textobuscar);
        }
    }
}
