using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NNivel_Acesso
    {
        //Medoto Inserir
        public static string Inserir(string nivel_acesso, string btn_listagem_vendas, string btn_backup, string btn_configuracoes, string btn_licenciamento, string btn_desbloquear, string btn_caixa, string btn_clientes, string btn_estoque, string btn_fornecedores, string btn_funcionarios, string btn_livro_caixa, string btn_contas_receber, string btn_contas_pagar, string btn_outras_financas, string btn_os, string btn_relatorios, string deletar_item_venda, string deletar_conta_receber, string inserir_conta_receber)
        {
            DNivel_Acesso Obj = new DNivel_Acesso();
            Obj.Nivel_Acesso = nivel_acesso;
            Obj.BTN_Listagem_Vendas = btn_listagem_vendas;
            Obj.BTN_Backup = btn_backup;
            Obj.BTN_Configuracoes = btn_configuracoes;
            Obj.BTN_Licenciamento = btn_licenciamento;
            Obj.BTN_Desbloquear = btn_desbloquear;
            Obj.BTN_Caixa = btn_caixa;
            Obj.BTN_Clientes = btn_clientes;
            Obj.BTN_Estoque = btn_estoque;
            Obj.BTN_Fornecedores = btn_fornecedores;
            Obj.BTN_Funcionarios = btn_funcionarios;
            Obj.BTN_Livro_Caixa = btn_livro_caixa;
            Obj.BTN_Contas_Receber = btn_contas_receber;
            Obj.BTN_Contas_Pagar = btn_contas_pagar;
            Obj.BTN_Outras_Financas = btn_outras_financas;
            Obj.BTN_OS = btn_os;
            Obj.BTN_Relatorios = btn_relatorios;
            Obj.Deletar_Item_Venda = deletar_item_venda;
            Obj.Deletar_Conta_Receber = deletar_conta_receber;
            Obj.Inserir_Conta_Receber = inserir_conta_receber;
            return Obj.Inserir(Obj);
        }


        //Medoto Editar
        public static string Editar(int idnivel_acesso, string nivel_acesso, string btn_listagem_vendas, string btn_backup, string btn_configuracoes, string btn_licenciamento, string btn_desbloquear, string btn_caixa, string btn_clientes, string btn_estoque, string btn_fornecedores, string btn_funcionarios, string btn_livro_caixa, string btn_contas_receber, string btn_contas_pagar, string btn_outras_financas, string btn_os, string btn_relatorios, string deletar_item_venda, string deletar_conta_receber, string inserir_conta_receber)
        {
            DNivel_Acesso Obj = new DNivel_Acesso();
            Obj.IdNivel_Acesso = idnivel_acesso;
            Obj.Nivel_Acesso = nivel_acesso;
            Obj.BTN_Listagem_Vendas = btn_listagem_vendas;
            Obj.BTN_Backup = btn_backup;
            Obj.BTN_Configuracoes = btn_configuracoes;
            Obj.BTN_Licenciamento = btn_licenciamento;
            Obj.BTN_Desbloquear = btn_desbloquear;
            Obj.BTN_Caixa = btn_caixa;
            Obj.BTN_Clientes = btn_clientes;
            Obj.BTN_Estoque = btn_estoque;
            Obj.BTN_Fornecedores = btn_fornecedores;
            Obj.BTN_Funcionarios = btn_funcionarios;
            Obj.BTN_Livro_Caixa = btn_livro_caixa;
            Obj.BTN_Contas_Receber = btn_contas_receber;
            Obj.BTN_Contas_Pagar = btn_contas_pagar;
            Obj.BTN_Outras_Financas = btn_outras_financas;
            Obj.BTN_OS = btn_os;
            Obj.BTN_Relatorios = btn_relatorios;
            Obj.Deletar_Item_Venda = deletar_item_venda;
            Obj.Deletar_Conta_Receber = deletar_conta_receber;
            Obj.Inserir_Conta_Receber = inserir_conta_receber;
            return Obj.Editar(Obj);
        }


        //Método Mostrar 
        public static DataTable Mostrar()
        {
            DNivel_Acesso Obj = new DNivel_Acesso();
            return Obj.Mostrar();
        }


        //Método Mostrar Pelo OD
        public static DataTable Mostrar_Pelo_ID(string textobuscar)
        {
            DNivel_Acesso Obj = new DNivel_Acesso();
            return Obj.Mostrar_Pelo_ID(textobuscar);
        }
    }
}
