using CrudDesafio.Helpers;
using CrudDesafio.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CrudDesafio.DAO
{
    class ColaboradorDAO
    {
        SqlConnection conexao = null;
        private string strCon = Conexao.connectionString;
        private string strSql = string.Empty;

        internal void Inserir(ColaboradorModel colaboradormodel)
        {

            var insertUsuario = "insert into Usuario(Nome, Sexo, DataNascimento, Cpf, Cidade, Cep, Rua, Bairro, Numero, Uf, Complemento, Telefone, Celular, Email)output inserted.Id values (@Nome, @Sexo, @DataNascimento, @Cpf, @Cidade, @Cep, @Rua, @Bairro, @Numero, @Uf, @Complemento, @Telefone, @Celular, @Email)";
            var insertColaborador = "insert into Colaborador(Id, Salario, Comissao, Banco, Agencia, Conta, TipoConta)output inserted.IdColaborador values(@Id, @Salario, @Comissao, @Banco, @Agencia, @Conta, @TipoConta)";

            try
            {
                using (conexao = new SqlConnection(strCon))


                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {
                        int id = conexao.ExecuteScalar<int>(insertUsuario, colaboradormodel, transacao);

                        colaboradormodel.Id = id;
                        int idcolaborador = conexao.ExecuteScalar<int>(insertColaborador, colaboradormodel, transacao);

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

        internal ColaboradorModel Buscar(int idColaborador)
        {

            strSql = @"select c.IdColaborador, c.Salario, c.Comissao, c.Banco, c.Agencia, c.Conta, c.TipoConta, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, 
            u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u 
            inner join Colaborador c on u.Id = c.Id where IdColaborador=@IdColaborador";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ColaboradorModel>(strSql, new { Idcolaborador = idColaborador }).First();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new ColaboradorModel();


        }

        internal void Alterar(ColaboradorModel colaboradormodel)
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

            var updateColaborador = @"update Colaborador set Salario=@Salario, Comissao=Comissao, Banco=Banco, Agencia=@Agencia, Conta=@Conta, TipoConta=@TipoConta where Id=@Id";



            try
            {
                using (conexao = new SqlConnection(strCon))


                {
                    conexao.Open();

                    using (var transacao = conexao.BeginTransaction())
                    {


                        conexao.Execute(updateUsuario, colaboradormodel, transacao);
                        conexao.Execute(updateColaborador, colaboradormodel, transacao);

                        transacao.Commit();



                        
                    }
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


      



      

        internal List<ColaboradorListagem> Listar()
        {

            strSql = @"select c.IdColaborador, c.Salario, c.Comissao, c.Banco, c.Agencia, c.Conta, c.TipoConta, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u inner join Colaborador c on u.Id = c.Id";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ColaboradorListagem>(strSql).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<ColaboradorListagem>().ToList();

        }

        internal void Excluir(ColaboradorModel colaboradormodel)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");

            }
            else
            {

                var deletecolaborador = "delete from Colaborador where Id=@Id";
                var deleteusuario = "delete from Usuario where Id=@Id";

                try
                {

                    using (conexao = new SqlConnection(strCon))


                    {
                        conexao.Open();

                        using (var transacao = conexao.BeginTransaction())
                        {


                            conexao.Execute(deletecolaborador, new { Id = colaboradormodel.Id }, transacao);
                            conexao.Execute(deleteusuario, new { Id = colaboradormodel.Id }, transacao);


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

       

        internal List<ColaboradorListagem> BuscarLista(string Nome)
        {
            strSql = @"select c.IdColaborador, c.Salario, c.Comissao, c.Banco, c.Agencia, c.Conta, c.TipoConta, c.Id, u.Id, u.Nome, u.Sexo, u.DataNascimento, u.Cpf, 
u.Cidade, u.Cep, u.Rua, u.Bairro, u.Numero, u.Uf, u.Complemento, u.Telefone, u.Celular, u.Email from Usuario u 
inner join Colaborador c on u.Id = c.Id where Nome like @Nome + '%'";

            var parametros = new DynamicParameters();
            parametros.Add("@Nome", Nome, System.Data.DbType.String);

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ColaboradorListagem>(strSql, parametros).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new List<ColaboradorListagem>().ToList();


        }
    }
}
