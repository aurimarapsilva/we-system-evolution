using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NVenda
    {
        //Método Inserir
        public static string Inserir(int idremetente, int idguiche_atendimento, DateTime data, int idcliente, int idfuncionario, string tipo_comprovante, string num_comprovante, string recebimento, string detalhe_recebimento, decimal valor_entrada, decimal comissao_paga, DataTable dtDV, DataTable dtFP)
        {
            DVenda Obj = new DVenda();
            Obj.IdRemetente = idremetente;
            Obj.IdGuiche_Atendimento = idguiche_atendimento;
            Obj.Data = data;
            Obj.IdCliente = idcliente;
            Obj.IdFuncionario = idfuncionario;
            Obj.Tipo_comprovante = tipo_comprovante;
            Obj.Num_Comprovante = num_comprovante;
            Obj.Recebimento = recebimento;
            Obj.Detalhe_Recebimento = detalhe_recebimento;
            Obj.Valor_Entrada = valor_entrada;
            Obj.Comissao_Paga = comissao_paga;

            // Inserir tabela detalhe_venda
            List<DDetalhe_Venda> dv = new List<DDetalhe_Venda>();
            foreach (DataRow row in dtDV.Rows)
            {
                DDetalhe_Venda detalheV = new DDetalhe_Venda();
                detalheV.IdProduto = Convert.ToInt32(row["idproduto"].ToString());
                detalheV.Quant = Convert.ToDecimal(row["quant"].ToString());
                detalheV.Preco_Venda = Convert.ToDecimal(row["preco_venda"].ToString());
                dv.Add(detalheV);
            }

            // Inserir tabela pagamento
            List<DForma_Pagamento> fp = new List<DForma_Pagamento>();
            foreach (DataRow linha in dtFP.Rows)
            {
                DForma_Pagamento f = new DForma_Pagamento();
                f.Forma = linha["forma"].ToString();
                f.Valor_Primario = Convert.ToDecimal(linha["valor_primario"].ToString());
                f.Valor_Final = Convert.ToDecimal(linha["valor_final"].ToString());
                fp.Add(f);
            }

            return Obj.Inserir(Obj, dv, fp);
        }


        //Método Excluir
        public static string Excluir(int id)
        {
            DVenda Obj = new DVenda();
            Obj.IdVenda = id;

            return Obj.Excluir(Obj);
        }

        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DVenda().Mostrar();
        }

        //Método: LIMITE DE CREDITO USADO
        public static DataTable Limite_Credito_Usado(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.Limite_Credito_Usado(textobuscar);
        }

        //Método Buscar por Data
        public static DataTable BuscarData(string textobuscar, string textobuscar2)
        {
            DVenda Obj = new DVenda();
            return Obj.BuscarData(textobuscar, textobuscar2);
        }

        //Método Buscar Produtos Disponiveis para Venda - POR DESCRIÇÃO
        public static DataTable Buscar_Produtos_Disp_Venda(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.Buscar_Produtos_Disp_Venda(textobuscar);
        }

        //Método Buscar Produtos Disponiveis para Venda - POR CÓDIGO
        public static DataTable Buscar_Produtos_Disp_Venda_Codigo(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.Buscar_Produtos_Disp_Venda_Codigo(textobuscar);
        }

        //Método Mostrar
        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.MostrarDetalhes(textobuscar);
        }

        //Método Mostrar Formas de Pagamento - VENDA
        public static DataTable Mostrar_Formas_Pagamento_Venda(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Formas_Pagamento_Venda(textobuscar);
        }

        //Método Mostrar Resultado para fechar dia
        public static DataTable Mostrar_Resultado_Fechar_Dia(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Fechar_Dia(textobuscar, textobuscar2, textobuscar3);
        }

        //Método Mostrar Resultado para fechar dia - CARTÃO DE CREDITO
        public static DataTable Mostrar_Resultado_Dia_Cartao_Credito(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Dia_Cartao_Credito(textobuscar, textobuscar2, textobuscar3);
        }

        //Método Mostrar Resultado para fechar dia - CARTÃO DE DEBITO
        public static DataTable Mostrar_Resultado_Dia_Cartao_Debito(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Dia_Cartao_Debito(textobuscar, textobuscar2, textobuscar3);
        }

        //Método Mostrar Resultado para fechar dia - CHEQUE
        public static DataTable Mostrar_Resultado_Dia_Cheque(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Dia_Cheque(textobuscar, textobuscar2, textobuscar3);
        }

        //Método Mostrar Resultado para fechar dia - CREDIÁRIO DA LOJA
        public static DataTable Mostrar_Resultado_Dia_Crediario_Loja(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Dia_Crediario_Loja(textobuscar, textobuscar2, textobuscar3);
        }

        //Método Mostrar Resultado para fechar dia - DINHEIRO
        public static DataTable Mostrar_Resultado_Dia_Dinheiro(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Resultado_Dia_Dinheiro(textobuscar, textobuscar2, textobuscar3);
        }

        //Método fechar caixa somente uma vez por dia
        public static DataTable Fechar_Caixa_Somente_Uma_Vez(string textobuscar, string textobuscar2, string textobuscar3)
        {
            DVenda Obj = new DVenda();
            return Obj.Fechar_Caixa_Somente_Uma_Vez(textobuscar, textobuscar2, textobuscar3);
        }


        //Metodo Mostrar Quant_Atual_Abaixo_Zero
        public static DataTable Vendas_Quant_Atual_Abaixo_Zero()
        {
            return new DVenda().Vendas_Quant_Atual_Abaixo_Zero();
        }


        //Método Mostrar Venda pelo ID
        public static DataTable Mostrar_Venda_Pelo_ID(string textobuscar)
        {
            DVenda Obj = new DVenda();
            return Obj.Mostrar_Venda_Pelo_ID(textobuscar);
        }
    }
}
