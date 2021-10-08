using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NEntrada
    {
        //Método Inserir
        public static string Inserir(int idremetente, DateTime data, int idfornecedor, string estado, string tipo_comprovante, string num_comprovante, string tipo_compra, int idfuncionario, DataTable dtDetalhes)
        {
            DEntrada Obj = new DEntrada();
            Obj.IdRemetente = idremetente;
            Obj.Data = data;
            Obj.IdFornecedor = idfornecedor;
            Obj.Estado = estado;
            Obj.Tipo_comprovante = tipo_comprovante;
            Obj.Num_Comprovante = num_comprovante;
            Obj.Tipo_Compra = tipo_compra;
            Obj.IdFuncionario = idfuncionario;

            List<DDetalhe_Entrada> detalhes = new List<DDetalhe_Entrada>();

            foreach (DataRow row in dtDetalhes.Rows)
            {
                DDetalhe_Entrada detalhe = new DDetalhe_Entrada();
                detalhe.IdProduto = Convert.ToInt32(row["idproduto"].ToString());
                detalhe.Quant = Convert.ToDecimal(row["quant"].ToString());
                detalhe.Fabricacao = row["fabricacao"].ToString();
                detalhe.Vencimento = row["vencimento"].ToString();
                detalhe.Preco_Custo = Convert.ToDecimal(row["preco_custo"].ToString());
                detalhe.Antecipacao_Venc = Convert.ToDateTime(row["antecipacao_venc"]);
                detalhes.Add(detalhe);
            }

            return Obj.Inserir(Obj, detalhes);
        }


        //Método Anular
        public static string Anular(int id)
        {
            DEntrada Obj = new DEntrada();
            Obj.IdEntrada = id;

            return Obj.Anular(Obj);
        }


        //Método Excluir
        public static string Excluir(int id)
        {
            DEntrada Obj = new DEntrada();
            Obj.IdEntrada = id;

            return Obj.Excluir(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DEntrada().Mostrar();
        }

        //Método Mostrar Produtos Disponiveis para entrada - POR DESCRIÇÃO
        public static DataTable Mostrar_Produtos_Disp_Entrada(string textobuscar)
        {
            return new DEntrada().Mostrar_Produtos_Disp_Entrada(textobuscar);
        }

        //Método Mostrar Produtos Disponiveis para entrada - POR CODIGO
        public static DataTable Mostrar_Produtos_Disp_Entrada_Codigo(string textobuscar)
        {
            return new DEntrada().Mostrar_Produtos_Disp_Entrada_Codigo(textobuscar);
        }

        //Método Buscar por Data
        public static DataTable BuscarData(string textobuscar, string textobuscar2)
        {
            DEntrada Obj = new DEntrada();
            return Obj.BuscarData(textobuscar, textobuscar2);
        }


        //Método Mostrar Detalhes da Entrada
        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DEntrada Obj = new DEntrada();
            return Obj.MostrarDetalhes(textobuscar);
        }


        //Método Mostrar Entrada pelo ID
        public static DataTable Mostrar_Entrada_Pelo_ID(string textobuscar)
        {
            DEntrada Obj = new DEntrada();
            return Obj.Mostrar_Entrada_Pelo_ID(textobuscar);
        }
    }
}
