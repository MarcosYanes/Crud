using CrudDesafio.Helpers;
using CrudDesafio.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CrudDesafio.DAO
{
    class PedidoDAO
    {

        SqlConnection conexao = null;
        private string strCon = Conexao.connectionString;
        private string selecionarPedidoSql = string.Empty;

        public void Inserir(PedidoModel pedidomodel)
        {
            var InsertPedido = @"insert into Pedido (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDeDesconto, TotalLiquido) output inserted.IdPedido values (@IdCliente, 
            @IdColaborador, @FormaPagamento, @TotalBruto, @TotalDeDesconto, @TotalLiquido)";

            var InsertPedido_Produto = @"insert into Pedido_Produto (IdPedido, IdProduto, PrecoDeVenda, PrecoLiquido, Quantidade, Desconto, Total)
            values (@IdPedido, @IdProduto, @PrecoVenda, @PrecoLiquido, @Quantidade, @Desconto, @Total)";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        var idPedido = conexao.ExecuteScalar<int>(InsertPedido, pedidomodel, transacao);

                        foreach (var produto in pedidomodel.Produtos)
                        {
                            produto.IdPedido = idPedido;
                            conexao.Execute(InsertPedido_Produto, produto, transacao);
                        }
                        transacao.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        



        internal List<PedidoListagem> Listar()
        {

            selecionarPedidoSql = @"select p.IdPedido, u.Nome as NomeCliente, u2.Nome as NomeColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto, p.TotalLiquido from Pedido p inner join Colaborador as co on p.IdColaborador = co.IdColaborador
inner join Cliente as c on p.IdCliente = c.IdCliente inner join Usuario u on u.Id = c.Id inner join Usuario u2 on u2.Id = co.Id";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<PedidoListagem>(selecionarPedidoSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<PedidoListagem>().ToList();

        }


        internal PedidoModel Buscar(int idPedido)
        {

            var selecionarPedidoSql = @"select p.IdPedido, p.IdCliente, p.IdColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto,
            p.TotalLiquido from Pedido p 
            inner join Cliente c on p.IdCliente = c.IdCliente inner join Colaborador co  on p.IdColaborador = co.IdColaborador
            where IdPedido=@IdPedido";

            var selecionarProdutosSql = @"select pp.IdPedido, pp.IdProduto, p.NomeProduto,  pp.PrecoDeVenda as PrecoVenda, pp.Desconto, pp.Quantidade from 
            Pedido_Produto pp inner join Produto p on pp.IdProduto = p.IdProduto where IdPedido = @IdPedido;";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    var pedidoModel = conexao.QuerySingle<PedidoModel>(selecionarPedidoSql, new { idPedido });

                    var listaDeProdutos = conexao.Query<CarrinhoProduto>(selecionarProdutosSql, new { idPedido }).ToList();
                    pedidoModel.Produtos = listaDeProdutos;

                    return pedidoModel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new PedidoModel();
        }

        //internal List<CarrinhoProduto> ListarProduto(int idPedido)
        //{

        //    selecionarPedidoSql = @"select pp.IdPedido, pp.IdProduto, pp.PrecoDeVenda, pp.Quantidade, pp.Desconto, pp.Total, pp.PrecoLiquido
        //    //from Pedido_Produto pp inner join Pedido p on pp.IdPedido = p.IdPedido inner join Produto pro on pp.IdProduto = pro.IdProduto where IdPedido = @IdPedido";

        //    try
        //    {
        //        using (conexao = new SqlConnection(strCon))
        //        {
        //            conexao.Open();
        //            return conexao.Query<CarrinhoProduto>(selecionarPedidoSql, new {idPedido }).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //    return new List<CarrinhoProduto>().ToList();

        //}


        //internal List<PedidoModel> ConsultarPedidos(int idPedido)
        //{

        //    strSql = @"select p.IdPedido, p.IdCliente, p.IdColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto, p.TotalLiquido from Pedido p inner join Cliente c on p.IdCliente = c.IdCliente inner join Colaborador co  on p.IdColaborador = co.IdColaborador where IdPedido=@IdPedido ";
        //    //select pp.IdPedido, pp.IdProduto, pp.PrecoDeVenda, pp.Quantidade, pp.Desconto, pp.Total, pp.PrecoLiquido from Pedido_Produto pp inner join Pedido p on pp.IdPedido = p.IdPedido inner join Produto pro on pp.IdProduto = pro.IdProduto where IdPedido = @IdPedido
        //    try
        //    {
        //        using (conexao = new SqlConnection(strCon))
        //        {
        //            conexao.Open();
        //            return conexao.Query<PedidoModel>(strSql, new {IdPedido = idPedido } ).ToList();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }


        //    return new List<PedidoModel>().ToList();

        //}
    }
}
