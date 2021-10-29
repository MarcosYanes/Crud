using CrudDesafio.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDesafio.DAO
{

    class ClienteDAO
    {
        //execute = inserção e update
        //query = select


        SqlConnection conexao = null;
        private string strCon = @"Data Source=DESKTOP-NQA0NEO\SQLEXPRESS;Initial Catalog=CrudDesafio;Integrated Security=True";
        private string strSql = string.Empty;

        internal void Inserir(ClienteModel clientemodel)
        {
            strSql = @"insert into Cliente (Nome,sexo,DataNascimento,Cpf,Cidade,Cep,Rua,Bairro,
                    Numero,Uf,Complemento,Telefone,Celular,Email,ValorLimite) 
                    values(@Nome,@Sexo,@DataNascimento,@Cpf,@Cidade,@Cep,@Rua,@Bairro,
                    @Numero,@Uf,@Complemento,@Telefone,@Celular,@Email,@ValorLimite)";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    conexao.Execute(strSql, clientemodel);
                }
                MessageBox.Show("Cadastro Efetuado com Sucesso");


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        internal ClienteModel Buscar(int IdCliente)
        {

            strSql = @"select Id as IdCliente, sexo, Nome, ValorLimite, DataNascimento, Cpf, Cidade, Cep, Rua, Bairro, Numero,
                    Uf, Complemento, Telefone, Celular, Email  from Cliente where Id=@Id";
            
            try
            {
                using(conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    return conexao.Query<ClienteModel>(strSql, new { Id = IdCliente }).First();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return new ClienteModel();

            
        }

        internal  List<ClienteListagem> Listar()
        {
            
            strSql = @"select Id as IdCliente, Nome, Sexo, DataNascimento, Cidade from Cliente";
            
            try
            {
                using(conexao = new SqlConnection(strCon))
                {
                    conexao.Open();
                    return conexao.Query<ClienteListagem>(strSql).ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return new List<ClienteListagem>().ToList();
            
        }

        internal  List<ClienteListagem> BuscarLista(string Nome)
        {
            strSql = @"select Id as IdCliente, Nome, Sexo, DataNascimento, Cidade from cliente where Nome=@Nome";
            
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


        //internal List<ClienteModel> Listar()
        //{
        //    strSql = "select * from Cliente";
        //    conexao = new SqlConnection(strCon);

        //    SqlCommand comando = new SqlCommand(strSql, conexao);

        //    var lista = new List<ClienteModel>();
        //    try
        //    {

        //        conexao.Open();

        //        SqlDataReader dr = comando.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            var clientemodel = new ClienteModel();


        //            clientemodel.IdCliente = Convert.ToInt32(dr["Id"]);
        //            clientemodel.Nome = Convert.ToString(dr["Nome"]);
        //            clientemodel.Sexo = Convert.ToString(dr["sexo"]);
        //            clientemodel.DataNascimento = Convert.ToDateTime(dr["DataNascimento"]);
        //            clientemodel.Cpf = Convert.ToString(dr["Cpf"]);
        //            clientemodel.Cidade = Convert.ToString(dr["Cidade"]);
        //            clientemodel.Cep = Convert.ToString(dr["Cep"]);
        //            clientemodel.Rua = Convert.ToString(dr["Rua"]);
        //            clientemodel.Bairro = Convert.ToString(dr["Bairro"]);
        //            clientemodel.Numero = Convert.ToString(dr["Numero"]);
        //            clientemodel.Uf = Convert.ToString(dr["Uf"]);
        //            clientemodel.Complemento = Convert.ToString(dr["Complemento"]);
        //            clientemodel.Telefone = Convert.ToString(dr["Telefone"]);
        //            clientemodel.Celular = Convert.ToString(dr["Celular"]);
        //            clientemodel.Email = Convert.ToString(dr["Email"]);
        //            clientemodel.ValorLimite = Convert.ToString(dr["ValorLimite"]);
        //            lista.Add(clientemodel);
        //        }

        //        dr.Close();






        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conexao.Close();
        //    }
        //    return lista;


        //}



        internal void Alterar(ClienteModel clientemodel)
        {
            strSql = @"update Cliente set
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
                        Email=@Email, 
                        ValorLimite=@ValorLimite 
                        where Id=@IdCliente";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    conexao.Execute(strSql, clientemodel);
                }
                MessageBox.Show("Cliente Alterado com Sucesso");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        

        internal void Excluir(ClienteModel clientemodel)
        {
            strSql = "delete from Cliente where Id=@IdCliente";

            try
            {
                using (conexao = new SqlConnection(strCon))
                {
                    conexao.Open();

                    conexao.Execute(strSql, clientemodel);
                }
                MessageBox.Show("Cliente Deletado  com Sucesso");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
