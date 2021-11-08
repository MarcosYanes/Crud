using System;
using System.Collections.Generic;
using System.ComponentModel;                         
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrudDesafio.Controller;
using CrudDesafio.Model;



namespace CrudDesafio.View
{
    public partial class CadastroColaborador : Form
    {

        ColaboradorController colaboradorcontroller = new ColaboradorController();
        ColaboradorModel colaboradormodel = new ColaboradorModel();
        
        public CadastroColaborador()
        {
            InitializeComponent();
            txtNomeColaborador.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //double.TryParse(txtSalarioColaborador.Text, out double salario);
            //int.TryParse(txtConta.Text, out int conta);

            if (Validar())
            {
             
                colaboradormodel.Nome = txtNomeColaborador.Text;
                if (rbMasculino.Checked == true)
                    colaboradormodel.Sexo = "m";
                else
                    colaboradormodel.Sexo = "F";

                colaboradormodel.DataNascimento = Convert.ToDateTime(txtDataNascimentoColaborador.Text);
                colaboradormodel.Salario = double.Parse(txtSalarioColaborador.Text);
                colaboradormodel.Comissao = txtComissaoColaborador.Text;
                colaboradormodel.Cep = txtCepColaborador.Text;
                colaboradormodel.Rua = txtLogradouroColaborador.Text;
                colaboradormodel.Cidade = txtCidadeColaborador.Text;
                colaboradormodel.Uf = txtUfColaborador.Text;
                colaboradormodel.Complemento = txtComplementoColaborador.Text;
                colaboradormodel.Bairro = txtBairroColaborador.Text;
                colaboradormodel.Numero = txtNumeroColaborador.Text;
                colaboradormodel.Telefone = Funcoes.ObterSomenteNumeros(txtTelefoneColaborador.Text);
                colaboradormodel.Celular = Funcoes.ObterSomenteNumeros(txtCelularColaborador.Text);
                colaboradormodel.Email = txtEmailColaborador.Text;
                colaboradormodel.Cpf = Funcoes.ObterSomenteNumeros(txtCpfColaborador.Text);
                colaboradormodel.Banco = txtBanco.Text;
                colaboradormodel.Agencia = Convert.ToInt32(Funcoes.ObterSomenteNumeros(txtAgencia.Text));
                colaboradormodel.Conta = Convert.ToInt32(Funcoes.ObterSomenteNumeros(txtConta.Text)); 
                colaboradormodel.TipoConta = txtTipoConta.Text;


                colaboradorcontroller.Inserir(colaboradormodel);
                MessageBox.Show("Cadastro Efetuado com Sucesso");
                this.Close();
            }

            

        }

        

        public bool Validar()
        {
           

             if (!Validacoes.ValidarParaQueSejaNumero(txtSalarioColaborador.Text))
            {
                MessageBox.Show("Salário Inválido!");
                return false;
            }

            else if (!Validacoes.ValidarNome(txtNomeColaborador.Text))
            {
                MessageBox.Show("Nome inválido");

                return false;
            }
            else if (!Validacoes.ValidarDataNascimento(txtDataNascimentoColaborador.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");

                return false;
            }
            else if (!Validacoes.ValidarCpf(txtCpfColaborador.Text.Replace(",", ".")))
            {
                MessageBox.Show("CPF inválido");

                return false;
            }
            else if (!Validacoes.ValidarNome(txtCidadeColaborador.Text))
            {
                MessageBox.Show("Cidade inválida");

                return false;
            }
            else if (!Validacoes.ValidarCep(txtCepColaborador.Text))
            {
                MessageBox.Show("Cep inválido");

                return false;
            }
            else if (txtLogradouroColaborador.Text == string.Empty)
            {
                MessageBox.Show(" Logradouro inválido");

                return false;
            }
            else if (txtBairroColaborador.Text == string.Empty)
            {
                MessageBox.Show("Bairro inválido");

                return false;
            }
            else if (!Validacoes.ValidarNumeroDoEndereco(txtNumeroColaborador.Text))
            {
                MessageBox.Show("Número inválido");

                return false;
            }
            else if (!Validacoes.ValidarUf(txtUfColaborador.Text))
            {
                MessageBox.Show("UF inválido");

                return false;
            }
          
            else if (txtAgencia.Text == string.Empty)
            {
                MessageBox.Show("Agência inválida");

                return false;

            }
            else if (txtConta.Text == string.Empty)
            {
                MessageBox.Show("Conta inválida");

                return false;

            }
            else if (txtBanco.Text == string.Empty)
            {
                MessageBox.Show("Banco Inválido");
                return false;
            }
            else if (!Validacoes.ValidarConta(txtTipoConta.Text))
            {
                MessageBox.Show("Tipo de conta inválida");
                return false;
            }
            else if(txtSalarioColaborador.Text == string.Empty)
            {
                MessageBox.Show("Salario Inválido");
                return false;

            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtAgencia.Text))
            {
                MessageBox.Show("Agência inválida!");
                return false;
            }
             else if (Validacoes.ValidarConta(txtConta.Text))
            {
                MessageBox.Show("Conta Inválida !");
                return false;
            }
            else if (!Validacoes.ValidarEmail(txtEmailColaborador.Text))
            {
                MessageBox.Show("Email Inválido ");

                return false;
            }
            else if (Funcoes.ObterSomenteNumeros(txtCelularColaborador.Text) == string.Empty && Funcoes.ObterSomenteNumeros(txtTelefoneColaborador.Text) == string.Empty)
            {
                MessageBox.Show("Informe Algum Meio De Comunicação(Celular ou Telefone)");
                return false;
            }


            return true;
        }

        private void CadastroColaborador_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void txtComissaoColaborador_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplementoColaborador_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridColaborador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
