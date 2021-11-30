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
    class ProdutoController
    {

        private ProdutoDAO produtodao = new ProdutoDAO();

        public void Inserir(ProdutoModel produtomodel)
        {
            produtodao.Inserir(produtomodel);


        }

        public void Alterar(ProdutoModel produtomodel)
        {
            produtodao.Alterar(produtomodel);
        }

        public List<ProdutoModel> Listar()
        {
            return produtodao.Listar();
        }
        public List<ProdutoModel> ListarAtivos()
        {
            return produtodao.ListarAtivos();
        }

        public List<ProdutoModel> BuscarLista(string NomeProduto)
        {
            var lista = produtodao.BuscarLista(NomeProduto);
            return lista;
        }

        public ProdutoModel Buscar(int Id)
        {
            return produtodao.Buscar(Id);
        }

        //public CarrinhoProduto BuscarCarrinhoProduto(int Id)
        //{
        //    return produtodao.BuscarCarrinhoProduto(Id);
        //}



        public void Excluir(ProdutoModel produtomodel)
        {
            produtodao.Excluir(produtomodel);
        }
    }
}
