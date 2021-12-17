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

    class ClienteDAO
    {
        //execute = inserção e update
        //query = select


        SqlConnection conexao = null;
        private string strCon = Conexao.connectionString;
        private string strSql = string.Empty;

        internal void Inserir(ClienteModel clientemodel)
        {

            var insertUsuario = "insert into Usuario(Nome, Sexo, DataNascimento, Cpf, Cidade, Cep, Rua, Bairro, Numero, Uf, Complemento, Telefone, Celular, Email)output inserted.Id values " +
                "(@Nome, @Sexo, @DataNascimento, @Cpf, @Cidade, @Cep, @Rua, @Bairro, @Numero, @Uf, @Complemento, @Telefone, @Celular, @Email)";
            var insertCliente = "insert into Cliente(Id, ValorLimite, LimiteRestante, Ativo)output inserted.IdCliente values(@Id, @ValorLimite, @LimiteRestante, @Ativo)";

            try
            {
                using (conexao = new SqlConnection(strCon))


                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {
                        int id = conexao.ExecuteScalar<int>(insertUsuario, new
                        {
                            clientemodel.Id,
                            clientemodel.Nome,
                            clientemodel.DataNascimento,
                            clientemodel.Sexo,
                            Cpf = clientemodel.Cpf.ObterSomenteNumeros(),
                            clientemodel.Cidade,
                            clientemodel.Cep,
                            clientemodel.Rua,
                            clientemodel.Bairro,
                            clientemodel.Numero,
                            clientemodel.Uf,
                            clientemodel.Complemento,
                            clientemodel.Telefone,
                            clientemodel.Celular,
                            clientemodel.Email,
                            
                        }, transacao);

                        clientemodel.Id = id;
                        clientemodel.LimiteRestante = clientemodel.ValorLimite;
                        int idcliente = conexao.ExecuteScalar<int>(insertCliente, clientemodel, transacao);

                        transacao.Commit();



                        // conexao.Execute(strSql, clientemodel);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal ClienteModel Buscar(int idCliente)
        {

            strSql = @"select c.IdCliente, c.ValorLimite, c.LimiteRestante, c.Ativo,  c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, 
            u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u 
            inner join Cliente c on u.Id = c.Id where IdCliente=@IdCliente";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ClienteModel>(strSql, new { IdCliente = idCliente }).First();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new ClienteModel();


        }



        internal List<ClienteListagem> Listar()
        {

            strSql = @"select c.IdCliente, c.ValorLimite, c.LimiteRestante, c.Ativo, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u inner join Cliente c on u.Id = c.Id";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ClienteListagem>(strSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<ClienteListagem>().ToList();

        }
        internal List<ClienteListagem> ListarClientesAtivos()
        {

            strSql = @"select c.IdCliente, c.ValorLimite, c.LimiteRestante, c.Ativo, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u inner join Cliente c on u.Id = c.Id where Ativo = 1";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ClienteListagem>(strSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<ClienteListagem>().ToList();

        }

        internal List<ClienteListagem> BuscarLista(string Nome)
        {
            strSql = @"select c.IdCliente, c.ValorLimite, c.LimiteRestante, c.Ativo, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, 
            u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u 
            inner join Cliente c on u.Id = c.Id where Nome like @Nome + '%'";
            //strSql = @"select Id as IdCliente, Nome, Sexo, DataNascimento, Cidade from cliente where Nome like @Nome + '%'";

            var parametros = new DynamicParameters();
            parametros.Add("@Nome", Nome, System.Data.DbType.String);

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ClienteListagem>(strSql, parametros).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<ClienteListagem>().ToList();


        }


        internal void Alterar(ClienteModel clientemodel)
        {

            var updateUsuario = @"update Usuario set
                        Nome=@Nome, 
                        sexo=@sexo, 
                        DataNascimento=@DataNascimento, 
                        Cpf=@Cpf, 
                        Cidade=@Cidade, 
                        Cep=@Cep, 
                        Rua=@Rua, 
                        Bairro=@Bairro, 
                        Numero=@Numero, 
                        Uf=@Uf, 
                        Complemento=@Complemento, 
                        Telefone=@Telefone, 
                        Celular=@Celular, 
                        Email=@Email
                        
                        where Id=@Id";

            var updateCliente = @"update Cliente set ValorLimite=@ValorLimite, LimiteRestante=@LimiteRestante, Ativo=@Ativo where Id=@Id";
            var valorLimite = @"update Cliente 
                            set LimiteRestante = (ValorLimite - @ValorLimitePreAlteracao) + LimiteRestante
                            where IdCliente = @IdCliente ";
            //var valorAcumulado = clientemodel.ValorLimite - clientemodel.ValorLimitePreAlteracao;


            try
            {
                using (conexao = new SqlConnection(strCon))


                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {


                        conexao.Execute(updateUsuario, new
                        {
                            clientemodel.Id,
                            clientemodel.Nome,
                            clientemodel.DataNascimento,
                            clientemodel.Sexo,
                            Cpf = clientemodel.Cpf.ObterSomenteNumeros(),
                            clientemodel.Cidade,
                            clientemodel.Cep,
                            clientemodel.Rua,
                            clientemodel.Bairro,
                            clientemodel.Numero,
                            clientemodel.Uf,
                            clientemodel.Complemento,
                            clientemodel.Telefone,
                            clientemodel.Celular,
                            clientemodel.Email,
                            clientemodel.Ativo,
                        }, transacao);
                        //clientemodel.LimiteRestante = clientemodel.LimiteRestante + valorAcumulado;
                        conexao.Execute(updateCliente, clientemodel, transacao);
                        conexao.Execute(valorLimite, clientemodel, transacao);


                        transacao.Commit();



                        // conexao.Execute(strSql, clientemodel);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        internal void Excluir(ClienteModel clientemodel)
        {

            var deletecliente = "delete from Cliente where Id=@Id";
            var deleteusuario = "delete from Usuario where Id=@Id";

            try
            {

                using (conexao = new SqlConnection(strCon))


                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {


                        conexao.Execute(deletecliente, new { Id = clientemodel.Id }, transacao);
                        conexao.Execute(deleteusuario, new { Id = clientemodel.Id }, transacao);


                        transacao.Commit();



                        // conexao.Execute(strSql, clientemodel);
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
