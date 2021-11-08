using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudDesafio.Controller;
using CrudDesafio.Model;
using System.Configuration;
using CrudDesafio.View;
using System.Text.RegularExpressions;

namespace CrudDesafio.View
{
    public partial class AlterarCliente : Form
    {

        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();

        public AlterarCliente()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        public void CarregarDadosParaAlteracao(ClienteModel cliente)
        {
            txtId.Enabled = false;
            clientemodel = cliente;
            txtId.Text = clientemodel.IdCliente.ToString();

            txtNome.Text = clientemodel.Nome;
            txtDataNascimento.Text = clientemodel.DataNascimento.ToString();
            if (clientemodel.Sexo == "m")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
            }
            txtCpf.Text = clientemodel.Cpf;
            txtCidade.Text = clientemodel.Cidade;
            txtCep.Text = clientemodel.Cep;
            txtRua.Text = clientemodel.Rua;
            txtBairro.Text = clientemodel.Bairro;
            txtUf.Text = clientemodel.Uf;
            txtComplemento.Text = clientemodel.Complemento;
            txtTelefone.Text = Funcoes.ObterSomenteNumeros(clientemodel.Telefone);
            txtCelular.Text = Funcoes.ObterSomenteNumeros(clientemodel.Celular);
            txtEmail.Text = clientemodel.Email;
            txtValorLimite.Text = clientemodel.ValorLimite.ToString();
            txtNumero.Text = clientemodel.Numero;

            


        }
        
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa digitar um id");

                return;
            }
            if (!Validacoes.ValidarBusca(txtBuscar.Text))
            {
                MessageBox.Show("Busca Inválida ! ");
                return;
            }
           

            clientemodel = clientecontroller.Buscar(Convert.ToInt32(txtBuscar.Text));

            if (clientemodel.IdCliente == 0)
            {
                return;
            }
            txtNome.Text = clientemodel.Nome;
            if (clientemodel.Sexo == "m")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
            }
            txtId.Text = clientemodel.IdCliente.ToString();
            txtDataNascimento.Text = clientemodel.DataNascimento.ToString();
            txtCpf.Text = clientemodel.Cpf;
            txtCidade.Text = clientemodel.Cidade;
            txtCep.Text = clientemodel.Cep;
            txtRua.Text = clientemodel.Rua;
            txtBairro.Text = clientemodel.Bairro;
            txtNumero.Text = clientemodel.Numero;
            txtUf.Text = clientemodel.Uf;
            txtComplemento.Text = clientemodel.Complemento;
            txtTelefone.Text = Funcoes.ObterSomenteNumeros(clientemodel.Telefone);
            txtCelular.Text = Funcoes.ObterSomenteNumeros(clientemodel.Celular);
            txtEmail.Text = clientemodel.Email;
            txtValorLimite.Text = clientemodel.ValorLimite.ToString();

            
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
            
            //gridClientes.Columns["ValorLimite"].DisplayIndex = gridClientes.Columns.Count - 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {

                return;
            }

            if (Validar() == true)
            {
                if (clientemodel.Nome == txtNome.Text && clientemodel.Cidade == txtCidade.Text && clientemodel.Cep == txtCep.Text && clientemodel.Rua == txtRua.Text
               && clientemodel.Bairro == txtBairro.Text && clientemodel.Numero == txtNumero.Text && clientemodel.Uf == txtUf.Text && clientemodel.Complemento == txtComplemento.Text && clientemodel.Telefone == Funcoes.ObterSomenteNumeros(txtTelefone.Text)
               && clientemodel.Celular == Funcoes.ObterSomenteNumeros(txtCelular.Text) && clientemodel.Email == txtEmail.Text && clientemodel.ValorLimite == double.Parse(txtValorLimite.Text) && clientemodel.Sexo == (rbMasculino.Checked ? "m" : "F") && clientemodel.Cpf == Funcoes.ObterSomenteNumeros(txtCpf.Text) && clientemodel.DataNascimento == Convert.ToDateTime(txtDataNascimento.Text))
                {
                    MessageBox.Show("Voce precisa alterar um campo");
                    return;
                }


                //if (!Validacoes.ValidarNumeroNegativo(double.Parse(txtValorLimite.Text)))
                //{
                //    MessageBox.Show("O  Valor Limite de Compra  Não Pode Ser Negativo ");
                //    return;
                //}

                clientemodel.IdCliente = Convert.ToInt32(txtId.Text);
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

                clientecontroller.Alterar(clientemodel);
                MessageBox.Show("Cadastro Alterado com Sucesso");

                txtNome.Text = "";
                txtDataNascimento.Text = "";
                txtSexo.Text = "";
                txtCpf.Text = "";
                txtValorLimite.Text = "";
                txtCidade.Text = "";
                txtCep.Text = "";
                txtRua.Text = "";
                txtBairro.Text = "";
                txtNumero.Text = "";
                txtUf.Text = "";
                txtComplemento.Text = "";
                txtTelefone.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
                txtBuscar.Text = "";
                txtId.Text = "";
                gridClientes.DataSource = clientecontroller.Listar();


            }

            
           

        }

        public bool Validar()
        {
            if (!Validacoes.ValidarNome(txtNome.Text))
            {
                MessageBox.Show("Nome inválido");

                return false;
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
            else if (!Validacoes.ValidarCep(txtCep.Text))
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
            else if (txtValorLimite.Text == string.Empty)
            {
                MessageBox.Show("Valor limite inválido");

                return false;
            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtValorLimite.Text))
            {
                MessageBox.Show("Valor Limite Inválido!");

                return false;

            }
            else if(txtTelefone.Text == string.Empty && txtCelular.Text == string.Empty)
            {
                MessageBox.Show("Você precisa informar o Número para contato ");
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

        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                
                return;
            }

            clientecontroller.Excluir(clientemodel);
            MessageBox.Show("Cliente deletado com sucesso");

            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtSexo.Text = "";
            txtCpf.Text = "";
            txtValorLimite.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtUf.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtBuscar.Text = "";
            txtId.Text = "";
            gridClientes.DataSource = clientecontroller.Listar();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            
            txtCpf.Text = "";
            txtValorLimite.Text = "";
            txtCidade.Text = "";
            txtCep.Text = "";
            txtRua.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            txtUf.Text = "";
            txtComplemento.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
            txtBuscar.Text = "";
            txtId.Text = "";
        }
    }
}
