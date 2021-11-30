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
    class ProdutoDAO
    {
        SqlConnection conexao = null;
        private string strCon = Conexao.connectionString;
        private string strSql = string.Empty;

        internal void Inserir(ProdutoModel produtomodel)
        {
            strSql = @"insert into Produto (CodigoDeBarra, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo, Fabricante) 
                    values(@CodigoDeBarra, @NomeProduto, @PrecoDeVenda, @PrecoDeCusto, @Estoque, @Ativo, @Fabricante)";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    conexao.Execute(strSql, produtomodel);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal List<ProdutoModel> Listar()
        {
            // List<ProdutoModel> teste = new List<ProdutoModel>();
            strSql = @"select IdProduto, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo, Fabricante, CodigoDeBarra from Produto";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ProdutoModel>(strSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new List<ProdutoModel>().ToList();

        }

        internal List<ProdutoModel> ListarAtivos()
        {
            // List<ProdutoModel> teste = new List<ProdutoModel>();
            strSql = @"select IdProduto, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo,  Fabricante, CodigoDeBarra from Produto where Ativo=1";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ProdutoModel>(strSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new List<ProdutoModel>().ToList();

        }

        internal List<ProdutoModel> BuscarLista(string NomeProduto)
        {
            strSql = @"select IdProduto, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo, Fabricante, CodigoDeBarra from Produto where NomeProduto like @NomeProduto + '%'";
            

            var parametros = new DynamicParameters();
            parametros.Add("@NomeProduto", NomeProduto, System.Data.DbType.String);

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ProdutoModel>(strSql, parametros).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<ProdutoModel>().ToList();


        }


        internal ProdutoModel Buscar(int id)

        {

            strSql = @"select IdProduto, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo, Fabricante, CodigoDeBarra
from Produto where IdProduto=@IdProduto";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ProdutoModel>(strSql, new { IdProduto = id }).First();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new ProdutoModel();


        }

        //internal CarrinhoProduto BuscarCarrinhoProduto(int id)
        //{

        //    strSql = @"select IdProduto, NomeProduto, PrecoVenda, Quantidade, Desconto from  ";

        //    try
        //    {
        //        using (conexao = new SqlConnection(strCon))
        //        {
        //            conexao.Open();

        //            return conexao.Query<CarrinhoProduto>(strSql, new { IdProduto = id }).First();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    return new CarrinhoProduto();


        //}


        internal void Alterar(ProdutoModel produtomodel)
        {
            strSql = @"update Produto set
                        NomeProduto=@NomeProduto, 
                        PrecoDeVenda=@PrecoDeVenda, 
                        PrecoDeCusto=@PrecoDeCusto, 
                        Estoque=@Estoque, 
                        Ativo=@Ativo, 
                        Fabricante=@Fabricante, 
                        CodigoDeBarra=@CodigoDeBarra
                                               
                        where IdProduto=@IdProduto";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    conexao.Execute(strSql, produtomodel);
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal void Excluir(ProdutoModel produtomodel)
        {
                   
            

                strSql = "delete from Produto where IdProduto=@IdProduto";

                try
                {
                    using (conexao = new SqlConnection(strCon))
                    {
                        conexao.Open();

                        conexao.Execute(strSql, produtomodel );
                    }
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

        }


    }
}
