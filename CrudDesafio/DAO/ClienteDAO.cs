using CrudDesafio.Model;
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

        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=DESKTOP-NQA0NEO\SQLEXPRESS;Initial Catalog=CrudDesafio;Integrated Security=True";
        private string strSql = string.Empty;

        internal void Inserir(ClienteModel clientemodel)
        {
            strSql = "insert into Cliente (Nome,sexo,DataNascimento,Cpf,Cidade,Cep,Rua,Bairro,Numero,Uf,Complemento,Telefone,Celular,Email,ValorLimite) values(@Nome,@sexo,@DataNascimento,@Cpf,@Cidade,@Cep,@Rua,@Bairro,@Numero,@Uf,@Complemento,@Telefone,@Celular,@Email,@ValorLimite)";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);
            
            comando.Parameters.Add("@id", SqlDbType.Int).Value = clientemodel.IdCliente;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = clientemodel.Nome;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = clientemodel.Sexo;
            comando.Parameters.Add("@DataNascimento", SqlDbType.VarChar).Value = clientemodel.DataNascimento;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = clientemodel.Cpf;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = clientemodel.Cidade;
            comando.Parameters.Add("@Cep", SqlDbType.VarChar).Value = clientemodel.Cep;
            comando.Parameters.Add("@Rua", SqlDbType.VarChar).Value = clientemodel.Rua;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = clientemodel.Bairro;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = clientemodel.Numero;
            comando.Parameters.Add("@Uf", SqlDbType.VarChar).Value = clientemodel.Uf;
            comando.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = clientemodel.Complemento;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = clientemodel.Telefone;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = clientemodel.Celular;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = clientemodel.Email;
            comando.Parameters.Add("@ValorLimite", SqlDbType.Decimal).Value = clientemodel.ValorLimite;
            
            

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }


           
        }

        internal ClienteModel Buscar(int IdCliente)
        {

            strSql = "select * from Cliente where Id=@Id";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = IdCliente;

            var clientemodel = new ClienteModel();

            try
            {
                //if (clientemodel.Id == string.Empty)
                //{
                //    MessageBox.Show("Você precisa digitar um id");
                //}

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado");
                }
                dr.Read();
               
                 clientemodel.IdCliente = Convert.ToInt32(dr["Id"]);
                 clientemodel.Nome = Convert.ToString(dr["Nome"]);
                 clientemodel.Sexo = Convert.ToString(dr["sexo"]);
                 clientemodel.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                clientemodel.Cpf = Convert.ToString(dr["Cpf"]);
                clientemodel.Cidade = Convert.ToString(dr["Cidade"]);
                clientemodel.Cep = Convert.ToString(dr["Cep"]);
                clientemodel.Rua = Convert.ToString(dr["Rua"]);
                clientemodel.Bairro = Convert.ToString(dr["Bairro"]);
                clientemodel.Numero = Convert.ToString(dr["Numero"]);
                clientemodel.Uf = Convert.ToString(dr["Uf"]);
                clientemodel.Complemento = Convert.ToString(dr["Complemento"]);
                clientemodel.Telefone = Convert.ToString(dr["Telefone"]);
                clientemodel.Celular = Convert.ToString(dr["Celular"]);
                clientemodel.Email = Convert.ToString(dr["Email"]);
                clientemodel.ValorLimite = Convert.ToString(dr["ValorLimite"]);





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            return clientemodel;
        }


        internal List<ClienteModel> Listar()
        {
            strSql = "select * from Cliente";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var lista = new List<ClienteModel>();
            try
            {
               
                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    var clientemodel = new ClienteModel();


                    clientemodel.IdCliente = Convert.ToInt32(dr["Id"]);
                    clientemodel.Nome = Convert.ToString(dr["Nome"]);
                    clientemodel.Sexo = Convert.ToString(dr["sexo"]);
                    clientemodel.DataNascimento = Convert.ToString(dr["DataNascimento"]);
                    clientemodel.Cpf = Convert.ToString(dr["Cpf"]);
                    clientemodel.Cidade = Convert.ToString(dr["Cidade"]);
                    clientemodel.Cep = Convert.ToString(dr["Cep"]);
                    clientemodel.Rua = Convert.ToString(dr["Rua"]);
                    clientemodel.Bairro = Convert.ToString(dr["Bairro"]);
                    clientemodel.Numero = Convert.ToString(dr["Numero"]);
                    clientemodel.Uf = Convert.ToString(dr["Uf"]);
                    clientemodel.Complemento = Convert.ToString(dr["Complemento"]);
                    clientemodel.Telefone = Convert.ToString(dr["Telefone"]);
                    clientemodel.Celular = Convert.ToString(dr["Celular"]);
                    clientemodel.Email = Convert.ToString(dr["Email"]);
                    clientemodel.ValorLimite = Convert.ToString(dr["ValorLimite"]);
                    lista.Add(clientemodel);
                }

                dr.Close();

                




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            return lista;


        }

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
                        where Id=@Id";
            //strSql = "update Cliente set Nome=@Nome, sexo=@sexo, DataNascimento=@DataNascimento, Cpf=@Cpf, Cidade=@Cidade, Cep=@Cep, Rua=@Rua, Bairro=Bairro, Numero=@Numero, Uf=Uf, Complemento=@Complemento, Telefone=@Telefone, Celular=@Celular, Email=@Email, ValorLimite=@ValorLimite";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("Id", SqlDbType.Int).Value = clientemodel.IdCliente;
            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = clientemodel.Nome;
            comando.Parameters.Add("@sexo", SqlDbType.VarChar).Value = clientemodel.Sexo;
            comando.Parameters.Add("@DataNascimento", SqlDbType.VarChar).Value = clientemodel.DataNascimento;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = clientemodel.Cpf;
            comando.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = clientemodel.Cidade;
            comando.Parameters.Add("@Cep", SqlDbType.VarChar).Value = clientemodel.Cep;
            comando.Parameters.Add("@Rua", SqlDbType.VarChar).Value = clientemodel.Rua;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = clientemodel.Bairro;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = clientemodel.Numero;
            comando.Parameters.Add("@Uf", SqlDbType.VarChar).Value = clientemodel.Uf;
            comando.Parameters.Add("@Complemento", SqlDbType.VarChar).Value = clientemodel.Complemento;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = clientemodel.Telefone;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = clientemodel.Celular;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = clientemodel.Email;
            comando.Parameters.Add("@ValorLimite", SqlDbType.Decimal).Value = clientemodel.ValorLimite;








            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastro Alterado com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }



        }

        internal void Excluir(ClienteModel clienteModel)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");
            }
            else
            {
                strSql = "delete from Cliente where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = clienteModel.IdCliente;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente deletado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }
            }
        }  
        
    }
}
