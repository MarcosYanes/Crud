using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace CrudDesafio
{
    public partial class CadastroCliente : Form
    {
        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();
        public CadastroCliente()
        {
            InitializeComponent();
            
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            
        }                

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {              

                clientemodel.Nome = txtNome.Text;

                if (rbMasculino.Checked == true)
                    clientemodel.Sexo = "m";
                else
                    clientemodel.Sexo = "F";
               
                clientemodel.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                clientemodel.Cpf = Funcoes.ObterSomenteNumeros(txtCpf.Text);
                clientemodel.Cidade = txtCidade.Text;
                clientemodel.Cep = txtCep.Text;
                clientemodel.Rua = txtRua.Text;
                clientemodel.Bairro = txtBairro.Text;
                clientemodel.Numero = txtNumero.Text;
                clientemodel.Uf = txtUf.Text;
                clientemodel.Complemento = txtComplemento.Text;
                clientemodel.Telefone = Funcoes.ObterSomenteNumeros(txtTelefone.Text);
                clientemodel.Celular = Funcoes.ObterSomenteNumeros(txtCelular.Text);
                clientemodel.Email = txtEmail.Text;
                clientemodel.ValorLimite = double.Parse(txtValorLimite.Text);

                clientecontroller.Inserir(clientemodel);
                MessageBox.Show("Cadastro Efetuado com Sucesso");
                this.Close();
            }
            //else
            //{
            //    MessageBox.Show("Campos Incorretos!");
            //}
            
        }

        public bool Validar()
        {
            if (!Validacoes.ValidarNome(txtNome.Text))
            {
                MessageBox.Show("Nome inválido");

                return false ;
            }
            else if (!Validacoes.ValidarDataNascimento(txtDataNascimento.Text))
            {
                MessageBox.Show("Data de Nascimento inválida");

                return false;
            }
            
            else if (!Validacoes.ValidarCpf(txtCpf.Text.Replace(",", ".")))
            {
                MessageBox.Show("CPF inválido");

                return false;
            }
            else if (!Validacoes.ValidarNome(txtCidade.Text))
            {
                MessageBox.Show("Cidade inválida");

                return false;
            }
            else if  (!Validacoes.ValidarCep(txtCep.Text))
                {
                MessageBox.Show("Cep inválido");

                return false;
            }
            else if (txtRua.Text == string.Empty)
            {
                MessageBox.Show(" Logradouro inválido");

                return false;
            }
            else if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Bairro inválido");

                return false;
            }
            else if (!Validacoes.ValidarNumeroDoEndereco(txtNumero.Text))
            {
                MessageBox.Show("Número inválido");

                return false;
            }
            else if (!Validacoes.ValidarUf(txtUf.Text))
            {
                MessageBox.Show("UF inválido");

                return false;
            }
            else if(txtValorLimite.Text == string.Empty)
            {
                MessageBox.Show("Valor limite inválido");

                return false;
            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtValorLimite.Text))
            {
                MessageBox.Show("Valor Limite Inválido!");

                return false;

            }
            else if (!Validacoes.ValidarEmail(txtEmail.Text))
            {
                MessageBox.Show("Email Inválido ");

                return false;
            }
            else if (Funcoes.ObterSomenteNumeros(txtCelular.Text) == string.Empty && Funcoes.ObterSomenteNumeros(txtTelefone.Text) == string.Empty)
            {
                MessageBox.Show("Informe Algum Meio De Comunicação(Celular ou Telefone)");
                return false;
            }

            return true;
        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
    }
}
