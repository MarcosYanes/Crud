using CrudDesafio.DAO;
using CrudDesafio.Model;
using CrudDesafio.View;
using System;
using System.Collections.Generic;

namespace CrudDesafio.Controller
{


    public class PedidoController
    {
        private PedidoDAO pedidodao = new PedidoDAO();

        public void Inserir(PedidoModel pedidomodel)
        {
            pedidodao.Inserir(pedidomodel);


        }
        public void Alterar (PedidoModel pedidomodel)
        {
            pedidodao.Alterar(pedidomodel);
        }

        public List<PedidoListagem> Listar()
        {
            return pedidodao.Listar();
        }

        public List<RelatorioVendasModel> ListarRelatorioVendas()
        {
            return pedidodao.ListarRelatorioVendas();
        }
        public List<RelatorioClienteModel> ListarRelatorioClientes()
        {
            return pedidodao.ListarRelatorioClientes();
        }


        public List<PedidoListagem> BuscarLista(string Nome)
          {
            var lista = pedidodao.BuscarLista(Nome);
            return lista;
        }

        public List<RelatorioVendasModel> BuscarRelatorio(string NomeProduto, string Nome, DateTime DataInicial, DateTime DataFinal)
        {
            var lista = pedidodao.BuscarRelatorio(NomeProduto, Nome, DataInicial, DataFinal);
            return lista;
        }
        public List<RelatorioClienteModel> FiltrarRelatorioCliente(string Nome, DateTime DataInicial, DateTime DataFinal, int OrdenarPor, int Crescente, int Top, double MaiorQue)
        {
            var lista = pedidodao.FiltrarRelatorioClientes(Nome, DataInicial, DataFinal, OrdenarPor, Crescente , Top, MaiorQue);
            return lista;
        }

        public PedidoModel Buscar(int idPedido)
        {
            return pedidodao.Buscar(idPedido);
        }

        internal void AbrirFormDePedido()
        {
            var pedido = new Pedido(new PedidoModel());
            pedido.Show();
        }

        internal void AbrirFormDePedidoParaAlterar(PedidoModel pedidomodel)
        {
            var pedido = new Pedido(pedidomodel);
            pedido.Show();
        }

        internal void Inativar(PedidoModel pedidomodel)
        {
             pedidodao.Inativar(pedidomodel);
        }

        //public List<CarrinhoProduto> ListarProduto(int idPedido)
        //{
        //    return pedidodao.ListarProduto(idPedido);
        //}
    }
}
