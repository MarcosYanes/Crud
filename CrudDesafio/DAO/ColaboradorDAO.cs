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
    class ColaboradorDAO
    {
        SqlConnection sqlCon = null;
        private string strCon = @"Data Source=DESKTOP-NQA0NEO\SQLEXPRESS;Initial Catalog=CrudDesafio;Integrated Security=True";
        private string strSql = string.Empty;

        internal void Inserir(ColaboradorModel colaboradormodel)
        {
            strSql = "insert into Colaborador (NomeColaborador, SexoColaborador, DataNascimentoColaborador, SalarioColaborador, ComissaoColaborador, CepColaborador, LogradouroColaborador, CidadeColaborador, UfColaborador, ComplementoColaborador, BairroColaborador, NumeroColaborador, TelefoneColaborador, CelularColaborador, EmailColaborador, CpfColaborador, Banco, Agencia, Conta, TipoConta) values(@NomeColaborador, @SexoColaborador, @DataNascimentoColaborador, @SalarioColaborador, @ComissaoColaborador, @CepColaborador, @LogradouroColaborador, @CidadeColaborador, @UfColaborador, @ComplementoColaborador, @BairroColaborador, @NumeroColaborador, @TelefoneColaborador, @CelularColaborador, @EmailColaborador, @CpfColaborador, @Banco, @Agencia, @Conta, @TipoConta)";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdColaborador", SqlDbType.Int).Value = colaboradormodel.IdColaborador;
            comando.Parameters.Add("@NomeColaborador", SqlDbType.VarChar).Value = colaboradormodel.Nome;
            comando.Parameters.Add("@SexoColaborador", SqlDbType.VarChar).Value = colaboradormodel.Sexo;
            comando.Parameters.Add("@DataNascimentoColaborador", SqlDbType.DateTime).Value = colaboradormodel.DataNascimento;
            comando.Parameters.Add("@SalarioColaborador", SqlDbType.Decimal).Value = colaboradormodel.SalarioColaborador;
            comando.Parameters.Add("@ComissaoColaborador", SqlDbType.VarChar).Value = colaboradormodel.ComissaoColaborador;
            comando.Parameters.Add("@CepColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cep;
            comando.Parameters.Add("@LogradouroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Rua;
            comando.Parameters.Add("@CidadeColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cidade;
            comando.Parameters.Add("@UfColaborador", SqlDbType.VarChar).Value = colaboradormodel.Uf;
            comando.Parameters.Add("@ComplementoColaborador", SqlDbType.VarChar).Value = colaboradormodel.Complemento;
            comando.Parameters.Add("@BairroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Bairro;
            comando.Parameters.Add("@NumeroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Numero;
            comando.Parameters.Add("@TelefoneColaborador", SqlDbType.VarChar).Value = colaboradormodel.Telefone;
            comando.Parameters.Add("@CelularColaborador", SqlDbType.VarChar).Value = colaboradormodel.Celular;
            comando.Parameters.Add("@EmailColaborador", SqlDbType.VarChar).Value = colaboradormodel.Email;
            comando.Parameters.Add("@CpfColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cpf;
            comando.Parameters.Add("@Banco", SqlDbType.VarChar).Value = colaboradormodel.Banco;
            comando.Parameters.Add("@Agencia", SqlDbType.Int).Value = colaboradormodel.Agencia;
            comando.Parameters.Add("@Conta", SqlDbType.Int).Value = colaboradormodel.Conta;
            comando.Parameters.Add("@TipoConta", SqlDbType.VarChar).Value = colaboradormodel.TipoConta;


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

       

        internal ColaboradorModel Buscar(int IdColaborador)
        {

            strSql = "select * from Colaborador where IdColaborador=@IdColaborador";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdColaborador", SqlDbType.Int).Value = IdColaborador;

            var colaboradormodel = new ColaboradorModel();

            try
            {
               

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Id não cadastrado");
                }
                dr.Read();

                colaboradormodel.IdColaborador = Convert.ToInt32(dr["IdColaborador"]);
                colaboradormodel.Nome = Convert.ToString(dr["NomeColaborador"]);
                colaboradormodel.Sexo = Convert.ToString(dr["sexoColaborador"]);
                colaboradormodel.DataNascimento = Convert.ToDateTime(dr["DataNascimentoColaborador"]);
                colaboradormodel.SalarioColaborador = Convert.ToDouble(dr["SalarioColaborador"]);

                colaboradormodel.ComissaoColaborador = Convert.ToString(dr["ComissaoColaborador"]);
                colaboradormodel.Cep = Convert.ToString(dr["CepColaborador"]);
                colaboradormodel.Rua = Convert.ToString(dr["LogradouroColaborador"]);
                colaboradormodel.Cidade = Convert.ToString(dr["CidadeColaborador"]);
                colaboradormodel.Uf = Convert.ToString(dr["UfColaborador"]);
                colaboradormodel.Complemento = Convert.ToString(dr["ComplementoColaborador"]);
                colaboradormodel.Bairro = Convert.ToString(dr["BairroColaborador"]);
                colaboradormodel.Numero = Convert.ToString(dr["NumeroColaborador"]);
                colaboradormodel.Telefone = Convert.ToString(dr["TelefoneColaborador"]);
                colaboradormodel.Celular = Convert.ToString(dr["CelularColaborador"]);
                colaboradormodel.Email = Convert.ToString(dr["EmailColaborador"]);
                colaboradormodel.Cpf = Convert.ToString(dr["CpfColaborador"]);
                colaboradormodel.Banco = Convert.ToString(dr["Banco"]);
                colaboradormodel.Agencia = Convert.ToInt32(dr["Agencia"]);
                colaboradormodel.Conta = Convert.ToInt32(dr["Conta"]);
                colaboradormodel.TipoConta = Convert.ToString(dr["TipoConta"]);






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            return colaboradormodel;
        }

        internal void Alterar(ColaboradorModel colaboradormodel)
        {
            strSql = @"update Colaborador set NomeColaborador=@NomeColaborador, SexoColaborador=@SexoColaborador, DataNascimentoColaborador=@DataNascimentoColaborador, SalarioColaborador=@SalarioColaborador, ComissaoColaborador=@ComissaoColaborador, CepColaborador=@CepColaborador, LogradouroColaborador=@LogradouroColaborador, CidadeColaborador=@CidadeColaborador, UfColaborador=@UfColaborador, ComplementoColaborador=@ComplementoColaborador, BairroColaborador=@BairroColaborador, NumeroColaborador=@NumeroColaborador, TelefoneColaborador=@TelefoneColaborador, CelularColaborador=@CelularColaborador, EmailColaborador=@EmailColaborador, CpfColaborador=@CpfColaborador, Banco=@Banco, Agencia=@Agencia, Conta=@Conta, TipoConta=@TipoConta  where IdColaborador=@IdColaborador";
                        
                         
                        
            //strSql = "update Cliente set Nome=@Nome, sexo=@sexo, DataNascimento=@DataNascimento, Cpf=@Cpf, Cidade=@Cidade, Cep=@Cep, Rua=@Rua, Bairro=Bairro, Numero=@Numero, Uf=Uf, Complemento=@Complemento, Telefone=@Telefone, Celular=@Celular, Email=@Email, ValorLimite=@ValorLimite";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("IdColaborador", SqlDbType.Int).Value = colaboradormodel.IdColaborador;
            comando.Parameters.Add("@NomeColaborador", SqlDbType.VarChar).Value = colaboradormodel.Nome;
            comando.Parameters.Add("@SexoColaborador", SqlDbType.VarChar).Value = colaboradormodel.Sexo;
            comando.Parameters.Add("@DataNascimentoColaborador", SqlDbType.DateTime).Value = colaboradormodel.DataNascimento;
          
            comando.Parameters.Add("@SalarioColaborador", SqlDbType.Decimal).Value = colaboradormodel.SalarioColaborador;
            comando.Parameters.Add("@ComissaoColaborador", SqlDbType.VarChar).Value = colaboradormodel.ComissaoColaborador;
            comando.Parameters.Add("@CepColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cep;
            comando.Parameters.Add("@LogradouroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Rua;
            //comando.Parameters.Add("")
            //comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = clientemodel.Cpf;
            comando.Parameters.Add("@CidadeColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cidade;
            
            comando.Parameters.Add("@UfColaborador", SqlDbType.VarChar).Value = colaboradormodel.Uf;
            comando.Parameters.Add("@ComplementoColaborador", SqlDbType.VarChar).Value = colaboradormodel.Complemento;
            comando.Parameters.Add("@BairroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Bairro;
            comando.Parameters.Add("@NumeroColaborador", SqlDbType.VarChar).Value = colaboradormodel.Numero;
            comando.Parameters.Add("@TelefoneColaborador", SqlDbType.VarChar).Value = colaboradormodel.Telefone;
            comando.Parameters.Add("@CelularColaborador", SqlDbType.VarChar).Value = colaboradormodel.Celular;
            comando.Parameters.Add("@EmailColaborador", SqlDbType.VarChar).Value = colaboradormodel.Email;
            comando.Parameters.Add("@CpfColaborador", SqlDbType.VarChar).Value = colaboradormodel.Cpf;
            comando.Parameters.Add("@Banco", SqlDbType.VarChar).Value = colaboradormodel.Banco;
            comando.Parameters.Add("@Agencia", SqlDbType.Int).Value = colaboradormodel.Agencia;
            comando.Parameters.Add("@Conta", SqlDbType.Int).Value = colaboradormodel.Conta;
            comando.Parameters.Add("@TipoConta", SqlDbType.VarChar).Value = colaboradormodel.TipoConta;










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

        internal void Excluir(ColaboradorModel colaboradormodel)
        {
            if (MessageBox.Show("Deseja realmente excluir?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");
            }
            else
            {
                strSql = "delete from Colaborador where IdColaborador=@IdColaborador";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);
                comando.Parameters.Add("@IdColaborador", SqlDbType.Int).Value = colaboradormodel.IdColaborador;
                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Colaborador deletado com sucesso");
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

        internal List<ColaboradorModel> Listar()
        {
            strSql = "select * from Colaborador";
            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            var lista = new List<ColaboradorModel>();
            try
            {

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    var colaboradormodel = new ColaboradorModel();

                    colaboradormodel.IdColaborador = Convert.ToInt32(dr["IdColaborador"]);
                    colaboradormodel.Nome = Convert.ToString(dr["NomeColaborador"]);
                    colaboradormodel.Sexo = Convert.ToString(dr["SexoColaborador"]);
                    colaboradormodel.DataNascimento = Convert.ToDateTime(dr["DataNascimentoColaborador"]);
                    colaboradormodel.SalarioColaborador = Convert.ToDouble(dr["SalarioColaborador"]);
                    colaboradormodel.ComissaoColaborador = Convert.ToString(dr["ComissaoColaborador"]);
                    colaboradormodel.Cep= Convert.ToString(dr["CepColaborador"]);
                    colaboradormodel.Rua = Convert.ToString(dr["LogradouroColaborador"]);
                    colaboradormodel.Cidade = Convert.ToString(dr["CidadeColaborador"]);
                    colaboradormodel.Uf = Convert.ToString(dr["UfColaborador"]);
                    colaboradormodel.Complemento = Convert.ToString(dr["ComplementoColaborador"]);
                    colaboradormodel.Bairro = Convert.ToString(dr["BairroColaborador"]);
                    colaboradormodel.Numero = Convert.ToString(dr["NumeroColaborador"]);
                    colaboradormodel.Telefone = Convert.ToString(dr["TelefoneColaborador"]);
                    colaboradormodel.Celular = Convert.ToString(dr["CelularColaborador"]);
                    colaboradormodel.Email = Convert.ToString(dr["EmailColaborador"]);
                    colaboradormodel.Cpf = Convert.ToString(dr["CpfColaborador"]);
                    colaboradormodel.Banco = Convert.ToString(dr["Banco"]);
                    colaboradormodel.Agencia = Convert.ToInt32(dr["Agencia"]);
                    colaboradormodel.Conta = Convert.ToInt32(dr["Conta"]);
                    colaboradormodel.TipoConta = Convert.ToString(dr["TipoConta"]);

                    lista.Add(colaboradormodel);
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
    }
}
