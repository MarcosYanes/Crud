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
            if (Validar() == true)
            {
                if (!Validacoes.ValidarNumeroNegativo(Convert.ToDouble(txtSalarioColaborador.Text)))
                {
                    MessageBox.Show("O  Sálario Não Pode Ser Um Valor Negativo ");
                    return;
                }


                colaboradormodel.Nome = txtNomeColaborador.Text;
                if (rbMasculino.Checked == true)
                    colaboradormodel.Sexo = "m";
                else
                    colaboradormodel.Sexo = "F";

               
               
                colaboradormodel.DataNascimento = Convert.ToDateTime(txtDataNascimentoColaborador.Text);
                
                
                colaboradormodel.SalarioColaborador = double.Parse(txtSalarioColaborador.Text);

               
                    colaboradormodel.ComissaoColaborador = txtComissaoColaborador.Text;
                colaboradormodel.Cep = txtCepColaborador.Text;
                colaboradormodel.Rua = txtLogradouroColaborador.Text;
                colaboradormodel.Cidade = txtCidadeColaborador.Text;
                colaboradormodel.Uf = txtUfColaborador.Text;
                colaboradormodel.Complemento = txtComplementoColaborador.Text;
                colaboradormodel.Bairro = txtBairroColaborador.Text;
                colaboradormodel.Numero = txtNumeroColaborador.Text;
                colaboradormodel.Telefone = txtTelefoneColaborador.Text;
                colaboradormodel.Celular = txtCelularColaborador.Text;
                colaboradormodel.Email = txtEmailColaborador.Text;
                colaboradormodel.Cpf = txtCpfColaborador.Text;
                colaboradormodel.Banco = txtBanco.Text;
                colaboradormodel.Agencia = Convert.ToInt32(txtAgencia.Text);
                colaboradormodel.Conta = Convert.ToInt32(txtConta.Text);
                colaboradormodel.TipoConta = txtTipoConta.Text;


                colaboradorcontroller.Inserir(colaboradormodel);
                this.Close();
            }

            

        }

        public bool Validar()
        {
            if (!Validacoes.ValidarNome(txtNomeColaborador.Text))
            {
                MessageBox.Show("Nome inválido");

                return false;
            }
            else if (!new Regex(@"[0-3][0-9][/][0-1][0-9][/][0-9]{4}").Match(txtDataNascimentoColaborador.Text).Success)
            {
                MessageBox.Show("Data de Nascimento inválida");

                return false;
            }
            else if (!new Regex(@"[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(txtCpfColaborador.Text.Replace(",", ".")).Success)
            {
                MessageBox.Show("CPF inválido");

                return false;
            }
            else if (txtCidadeColaborador .Text == string.Empty)
            {
                MessageBox.Show("Cidade inválida");

                return false;
            }
            else if (!new Regex(@"[0-9]{5}[-][0-9]{3}$").Match(txtCepColaborador.Text.Replace(",", ".")).Success)
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
            else if (txtNumeroColaborador.Text == string.Empty)
            {
                MessageBox.Show("Número inválido");

                return false;
            }
            else if (txtUfColaborador.Text == string.Empty)
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
            else if (txtTipoConta.Text == string.Empty)
            {
                MessageBox.Show("Tipo de conta inválida");
                return false;
            }
            else if(txtSalarioColaborador.Text == string.Empty)
            {
                MessageBox.Show("Salario Inválido");
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
