using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NProduto
    {
        //Medoto Inserir
        public static string Inserir(int idremetente, int idnumeracao_auto, int idtipo_produto, string codigo, string descricao, byte[] imagem,  int idcategoria, int idunid_medida, int idfornecedor, decimal preco_custo, decimal preco_venda, string data_fab, string data_venc, DateTime antecipacao_venc, string estado, string corredor_expo, string prateleira_expo, string corredor_dep, string prateleira_dep, decimal quant_atual, decimal quant_ideal, decimal unid_vendidas, byte[] barcode)
        {
            DProduto Obj = new DProduto();
            Obj.IdRemetente = idremetente;
            Obj.IdNumeracao_Auto = idnumeracao_auto;
            Obj.IdTipo_Produto = idtipo_produto;
            Obj.Codigo = codigo;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.Idcategoria = idcategoria;
            Obj.Idunid_medida = idunid_medida;
            Obj.Idfornecedor = idfornecedor;
            Obj.Preco_Custo = preco_custo;
            Obj.Preco_Venda = preco_venda;
            Obj.Data_Fab = data_fab;
            Obj.Data_venc = data_venc;
            Obj.Antecipacao_Venc = antecipacao_venc;
            Obj.Estado = estado;
            Obj.Corredor_Expo = corredor_expo;
            Obj.Prateleira_Expo = prateleira_expo;
            Obj.Corredor_Dep = corredor_dep;
            Obj.Prateleira_Dep = prateleira_dep;
            Obj.Quant_Atual = quant_atual;
            Obj.Quant_Ideal = quant_ideal;
            Obj.Unid_Vendidas = unid_vendidas;
            Obj.BarCode = barcode;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int id, int idtipo_produto, string codigo, string descricao, byte[] imagem,  int idcategoria, int idunid_medida, int idfornecedor, decimal preco_custo, decimal preco_venda, string data_fab, string data_venc, string corredor_expo, string prateleira_expo, string corredor_dep, string prateleira_dep, decimal quant_atual, decimal quant_ideal, byte[] barcode)
        {
            DProduto Obj = new DProduto();
            Obj.Id = id;
            Obj.IdTipo_Produto = idtipo_produto;
            Obj.Codigo = codigo;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.Idcategoria = idcategoria;
            Obj.Idunid_medida = idunid_medida;
            Obj.Idfornecedor = idfornecedor;
            Obj.Preco_Custo = preco_custo;
            Obj.Preco_Venda = preco_venda;
            Obj.Data_Fab = data_fab;
            Obj.Data_venc = data_venc;
            Obj.Corredor_Expo = corredor_expo;
            Obj.Prateleira_Expo = prateleira_expo;
            Obj.Corredor_Dep = corredor_dep;
            Obj.Prateleira_Dep = prateleira_dep;
            Obj.Quant_Atual = quant_atual;
            Obj.Quant_Ideal = quant_ideal;
            Obj.BarCode = barcode;
            return Obj.Editar(Obj);
        }


        //Medoto Deletar
        public static string Excluir(int id)
        {
            DProduto Obj = new DProduto();
            Obj.Id = id;
            return Obj.Excluir(Obj);
        }


        //Metodo Mostrar
        public static DataTable Mostrar()
        {
            return new DProduto().Mostrar();
        }


        //Metodo Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DProduto Obj = new DProduto();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }



        //Metodo Buscar Nome
        public static DataTable BuscarCodigo(string textobuscar)
        {
            DProduto Obj = new DProduto();
            return Obj.Buscar_Codigo(textobuscar);
        }


        //Metodo Selecionar Produto pelo Codigo de Barras - VENDA
        public static DataTable Selecionar_Produto_Codigo_Barra_Venda(string codigo_barra)
        {
            DProduto Obj = new DProduto();
            return Obj.Selecionar_Produto_Codigo_Barra_Venda(codigo_barra);
        }

        //Metodo Selecionar Produto pelo Codigo de Barras - ENTRADA
        public static DataTable Selecionar_Produto_Codigo_Barra_Entrada(string codigo_barra)
        {
            DProduto Obj = new DProduto();
            return Obj.Selecionar_Produto_Codigo_Barra_Entrada(codigo_barra);
        }

       
        //Metodo Mostrar Quant_Atual_Abaixo_Zero
        public static DataTable Quant_Atual_Abaixo_Zero()
        {
            return new DProduto().Quant_Atual_Abaixo_Zero();
        }


        //Metodo Pesquisar Preço por Codigo de Barras
        public static DataTable Pesquisar_Preco(string codigo_barra)
        {
            DProduto Obj = new DProduto();
            return Obj.Pesquisar_Preco(codigo_barra);
        }


        //Metodo Buscar Produto Pesquisa Preço - POR DESCRIÇÃO
        public static DataTable Buscar_Produto_Pesquisa_Preco(string textobuscar)
        {
            DProduto Obj = new DProduto();
            return Obj.Buscar_Produto_Pesquisa_Preco(textobuscar);
        }

        //Metodo Buscar Produto Pesquisa Preço - POR CÓDIGO
        public static DataTable Buscar_Produto_Pesquisa_Preco_Codigo(string textobuscar)
        {
            DProduto Obj = new DProduto();
            return Obj.Buscar_Produto_Pesquisa_Preco_Codigo(textobuscar);
        }

        //Metodo Buscar ID Importação no caixa
        public static DataTable Buscar_ID_import(int id)
        {
            DProduto Obj = new DProduto();
            return Obj.Buscar_ID_Import(id);
        }
    }
}
