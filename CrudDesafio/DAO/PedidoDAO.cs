﻿using CrudDesafio.Helpers;
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
            var InsertPedido = @"insert into Pedido (IdCliente, IdColaborador, FormaPagamento, TotalBruto, TotalDeDesconto, TotalLiquido, Lucro, DataInicial) output inserted.IdPedido values (@IdCliente, 
            @IdColaborador, @FormaPagamento, @TotalBruto, @TotalDeDesconto, @TotalLiquido, @Lucro, @DataInicial)";

            var InsertPedido_Produto = @"insert into Pedido_Produto (IdPedido, IdProduto, PrecoDeCusto, PrecoDeVenda, PrecoLiquido, Quantidade, Desconto, Total, Lucro)
            values (@IdPedido, @IdProduto, @PrecoDeCusto, @PrecoVenda, @PrecoLiquido, @Quantidade, @Desconto, @Total, @Lucro)";

            var  AlterarEstoque = @"update Produto set Estoque -= @Quantidade where IdProduto = @IdProduto";

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
                            conexao.Execute(AlterarEstoque, produto, transacao);
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

        public void Inativar(PedidoModel pedidomodel)
        {
            var update = @"update Pedido set Status=0 where IdPedido=@IdPedido";
            var SelecionarEstoque = @"select IdProduto, Quantidade from Pedido_produto where IdPedido=@IdPedido";
            var somarEstoque = @"update Produto set Estoque += @Quantidade where IdProduto = @IdProduto";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(update, pedidomodel, transacao);

                        //Estornar estoques dos produtos
                        var produtoantigo = conexao.Query<CarrinhoProduto>(SelecionarEstoque, new { pedidomodel.IdPedido }, transacao).ToList();

                       


                        foreach (var produto in produtoantigo)
                        {
                            conexao.Execute(somarEstoque, produto, transacao);
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

        public void Alterar(PedidoModel pedidomodel)
        {
            var UpdatePedido = @"update Pedido set IdCliente=@IdCliente, IdColaborador=@IdColaborador, FormaPagamento=@FormaPagamento, TotalBruto=@TotalBruto, TotalDeDesconto=@TotalDeDesconto, TotalLiquido=@TotalLiquido, Lucro=@Lucro where IdPedido=@IdPedido";


            var UpdatePedido_Produto = @"update Pedido_Produto set IdProduto=@IdProduto, PrecoDeVenda=@PrecoVenda, PrecoLiquido=@PrecoLiquido, Quantidade=@Quantidade, Desconto=@Desconto, Total=@Total, Lucro=@Lucro where IdPedido_Produto=@IdPedido_Produto";

            var InsertPedido_Produto = @"insert into Pedido_Produto (IdPedido, IdProduto, PrecoDeVenda, PrecoLiquido, Quantidade, Desconto, Total, Lucro)
            values (@IdPedido, @IdProduto, @PrecoVenda, @PrecoLiquido, @Quantidade, @Desconto, @Total, @Lucro)";

            var SelecionarEstoque = @"select IdProduto, Quantidade from Pedido_produto where IdPedido=@IdPedido";

            var AlterarEstoque = @"update Produto set Estoque -= @Quantidade where IdProduto = @IdProduto";
            var somarEstoque = @"update Produto set Estoque += @Quantidade where IdProduto = @IdProduto";



            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    using (var transacao = conexao.BeginTransaction())
                    {
                        conexao.Execute(UpdatePedido, pedidomodel, transacao);

                        //Estornar estoques dos produtos
                        var produtoantigo = conexao.Query<CarrinhoProduto>(SelecionarEstoque, new { pedidomodel.IdPedido }, transacao).ToList();
                        
                       
                        foreach (var produto in produtoantigo)
                        {                                               
                                                            
                           conexao.Execute(somarEstoque, produto, transacao);
                            
                            
                        }                                         


                        foreach (var produto in pedidomodel.Produtos)
                        {
                            if (produto.IdPedido_produto == 0)
                            {
                                produto.IdPedido = pedidomodel.IdPedido;
                                conexao.Execute(InsertPedido_Produto, produto, transacao);
                                conexao.Execute(AlterarEstoque, produto, transacao);
                            }
                            else
                            {                               
                                
                                conexao.Execute(UpdatePedido_Produto, produto, transacao);
                                conexao.Execute(AlterarEstoque, produto, transacao);
                            }
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

            selecionarPedidoSql = @"select p.IdPedido, u.Nome as NomeCliente, u2.Nome as NomeColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto, p.TotalLiquido, p.Lucro, p.Status
             from Pedido p inner join Colaborador as co on p.IdColaborador = co.IdColaborador
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
        internal List<RelatorioVendasModel> ListarRelatorioVendas()
        {

            selecionarPedidoSql = @"select p.IdProduto, p.NomeProduto, SUM(pp.Quantidade) as 'Quantidade', SUM(pp.Total) as 'total', SUM(pp.Desconto) as 'Desconto', SUM(pp.PrecoLiquido) as 'PrecoLiquido',
            SUM(pp.Lucro) as 'Lucro', SUM(pp.PrecoDeCusto * pp.Quantidade) as 'PrecoDeCusto' from 
            Pedido_produto pp 
            inner join Produto p on pp.IdProduto = p.IdProduto 
            group by p.IdProduto, p.NomeProduto";



            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<RelatorioVendasModel>(selecionarPedidoSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<RelatorioVendasModel>().ToList();

        }

        internal List<RelatorioClienteModel> ListarRelatorioClientes()
        {

            selecionarPedidoSql = @"select c.IdCliente, u.Nome,count(pp.IdPedido) as IdPedido , SUM(pp.Quantidade) AS
            'Quantidade de produtos', SUM(p.TotalBruto)as 'TotalBruto',
            SUM(p.TotalDeDesconto) as 'TotalDeDesconto', SUM(p.TotalLiquido) as 'TotalLiquido' from Cliente c 
            inner join Pedido p on p.IdCliente = c.IdCliente inner join Pedido_produto pp on 
            pp.IdPedido = p.IdPedido 
            inner  join Usuario u on u.Id = c.Id group by c.IdCliente, u.Nome ";



            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<RelatorioClienteModel>(selecionarPedidoSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<RelatorioClienteModel>().ToList();

        }
        internal List<RelatorioClienteModel> FiltrarRelatorioClientes(string Nome, DateTime DataInicial, DateTime DataFinal, int OrdenarPor, int Crescente, int Top, double MaiorQue, int OrdenarMaiorQue, int Operador)
        {
            
            selecionarPedidoSql = @"Select";
            if (Top != 0)
            {
                selecionarPedidoSql += @" top(@Top)";
            }

            selecionarPedidoSql += @"  c.IdCliente, u.Nome, count(pp.IdPedido) as IdPedido, SUM(pp.Quantidade) AS
            'Quantidade de produtos', SUM(p.TotalBruto) as 'TotalBruto',
            SUM(p.TotalDeDesconto) as 'TotalDeDesconto', SUM(p.TotalLiquido) as 'TotalLiquido' from Cliente c 
            inner join Pedido p on p.IdCliente = c.IdCliente inner join Pedido_produto pp on 
            pp.IdPedido = p.IdPedido 
            inner  join Usuario u on u.Id = c.Id
            where u.Nome like @Nome and Cast (DataInicial as Date) between @DataInicial and @DataFinal group by c.IdCliente, u.Nome ";

            var parametros = new DynamicParameters();
            parametros.Add("@Nome", Nome + '%', System.Data.DbType.String);
            parametros.Add("@DataInicial", DataInicial.Date, System.Data.DbType.String);
            parametros.Add("@DataFinal", DataFinal.Date, System.Data.DbType.String);
            parametros.Add("@Top", Top, System.Data.DbType.Int32);
            parametros.Add("@MaiorQue", MaiorQue, System.Data.DbType.String);


            if (MaiorQue != 0 && OrdenarMaiorQue == 0)
            {
                if (Operador == 0)
                {
                    selecionarPedidoSql += "having Count(pp.IdPedido)>@MaiorQue  ";
                }
                else
                {
                    selecionarPedidoSql += "having Count(pp.IdPedido)<@MaiorQue  ";
                }

            }
            else if(MaiorQue != 0 && OrdenarMaiorQue == 1)
            {
                if (Operador == 0)
                {
                    selecionarPedidoSql += "having SUM(p.TotalBruto)>@MaiorQue  ";
                }
                else
                {
                    selecionarPedidoSql += "having SUM(p.TotalBruto)<@MaiorQue  ";
                }
            }
            else if(MaiorQue != 0 && OrdenarMaiorQue == 2)
            {
                if (Operador == 0)
                {
                    selecionarPedidoSql += "having SUM(p.TotalDeDesconto)>@MaiorQue ";
                }
                else
                {
                    selecionarPedidoSql += "having SUM(p.TotalDeDesconto)<@MaiorQue ";
                }
            }
            else if (MaiorQue != 0 && OrdenarMaiorQue == 3)
            {
                if(Operador == 0)
                {
                    selecionarPedidoSql += "having SUM(p.TotalLiquido)>@MaiorQue  ";
                }
                else
                {
                    selecionarPedidoSql += "having SUM(p.TotalLiquido)<@MaiorQue  ";
                }
                
            }
            
            

                if (OrdenarPor == 0)
                {
                    selecionarPedidoSql += "order by Count(pp.IdPedido)";
                }
                else if (OrdenarPor == 1)
                {
                    selecionarPedidoSql += "order by SUM(p.TotalBruto)";
                }
                else if (OrdenarPor == 2)
                {
                    selecionarPedidoSql += "order by SUM(p.TotalDeDesconto)";
                }
                else if (OrdenarPor == 3)
                {
                    selecionarPedidoSql += "order by SUM(p.TotalLiquido)";
                }
            
           

            if (Crescente == 1)
            {
                selecionarPedidoSql += " desc";
            }




            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<RelatorioClienteModel>(selecionarPedidoSql, parametros).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<RelatorioClienteModel>().ToList();

        }


        internal List<RelatorioVendasModel> BuscarRelatorio(string NomeProduto, string Nome, DateTime DataInicial, DateTime DataFinal)
        {                              

            selecionarPedidoSql = @"select  p.IdProduto, p.NomeProduto,   SUM(pp.Quantidade) as 'Quantidade', SUM(pp.Total) as 'total', SUM(pp.Desconto) as 'Desconto', SUM(pp.PrecoLiquido) as 'PrecoLiquido',
            SUM(pp.Lucro) as 'Lucro', SUM(pp.PrecoDeCusto * pp.Quantidade) as 'PrecoDeCusto', (SUM(pp.PrecoLiquido)- SUM(pp.PrecoDeCusto* pp.Quantidade))/SUM(pp.PrecoDeCusto* pp.Quantidade)*100 as 'Lucro em %'from
            Produto p
            inner join Pedido_produto pp on pp.IdProduto = p.IdProduto inner join Pedido pedido on pp.IdPedido = pedido.IdPedido inner join  Cliente c on pedido.IdCliente = c.IdCliente inner join Usuario u on u.Id = c.Id  
            where p.NomeProduto like @NomeProduto  and u.Nome like @Nome  and Cast (DataInicial as Date) between @DataInicial and @DataFinal
            group by p.IdProduto, p.NomeProduto";

            var parametros = new DynamicParameters();
            parametros.Add("@NomeProduto", NomeProduto + '%',  System.Data.DbType.String);
            parametros.Add("@Nome", Nome + '%', System.Data.DbType.String);
            parametros.Add("@DataInicial", DataInicial.Date, System.Data.DbType.String);
            parametros.Add("@DataFinal", DataFinal.Date, System.Data.DbType.String);
            
            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<RelatorioVendasModel>(selecionarPedidoSql, parametros).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<RelatorioVendasModel>().ToList();

        }

        internal List<PedidoListagem> BuscarLista(string Nome)
        {

            selecionarPedidoSql = @"select p.IdPedido, u.Nome as NomeCliente, u2.Nome as NomeColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto, p.TotalLiquido, p.Lucro, p.Status
             from Pedido p inner join Colaborador as co on p.IdColaborador = co.IdColaborador
             inner join Cliente as c on p.IdCliente = c.IdCliente inner join Usuario u on u.Id = c.Id inner join Usuario u2 on u2.Id = co.Id where u.Nome  like @NomeCliente + '%'";

            var parametros = new DynamicParameters();
            parametros.Add("@NomeCliente", Nome, System.Data.DbType.String);
            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<PedidoListagem>(selecionarPedidoSql, parametros).ToList();
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

            var selecionarPedidoSql = @"select p.IdPedido, p.IdCliente, u.Nome as NomeCliente, u.Email, u2.Nome as NomeColaborador, p.IdColaborador, p.FormaPagamento, p.TotalBruto, p.TotalDeDesconto, p.Status,
            p.TotalLiquido from Pedido p 
            inner join Cliente c on p.IdCliente = c.IdCliente inner join Colaborador co  on p.IdColaborador = co.IdColaborador inner join Usuario u on u.Id = c.Id inner join Usuario u2 on u2.Id = co.Id
            where IdPedido=@IdPedido";

            var selecionarProdutosSql = @"select pp.IdPedido_produto, pp.IdPedido, pp.IdProduto, p.NomeProduto, pp.PrecoDeCusto, pp.PrecoDeVenda as PrecoVenda, pp.Desconto, pp.Quantidade from 
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

       
    }
}
