using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.Model;
using System.Data.SqlClient;
using CrudDesafio.DAO;

namespace CrudDesafio.Controller
{

    
    public class PedidoController
    {
        private PedidoDAO pedidodao = new PedidoDAO();

        public void Inserir(PedidoModel pedidomodel)
        {
            pedidodao.Inserir(pedidomodel);


        }

        public List<PedidoListagem> Listar()
        {
            return pedidodao.Listar();
        }

        public PedidoModel Buscar(int idPedido)
        {
            return pedidodao.Buscar(idPedido);
        }

        //public List<CarrinhoProduto> ListarProduto(int idPedido)
        //{
        //    return pedidodao.ListarProduto(idPedido);
        //}
    }
}
