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
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa digitar um id");

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
            txtDataNascimento.Text = clientemodel.DataNascimento;
            txtCpf.Text = clientemodel.Cpf;
            txtCidade.Text = clientemodel.Cidade;
            txtCep.Text = clientemodel.Cep;
            txtRua.Text = clientemodel.Rua;
            txtBairro.Text = clientemodel.Bairro;
            txtNumero.Text = clientemodel.Numero;
            txtUf.Text = clientemodel.Uf;
            txtComplemento.Text = clientemodel.Complemento;
            txtTelefone.Text = clientemodel.Telefone;
            txtCelular.Text = clientemodel.Celular;
            txtEmail.Text = clientemodel.Email;
            txtValorLimite.Text = clientemodel.ValorLimite;

            
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
            gridClientes.Columns["ValorLimite"].DisplayIndex = gridClientes.Columns.Count - 1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa buscar o Id que deseja Alterar");
                return;
            }

          

            if (clientemodel.Nome == txtNome.Text && clientemodel.DataNascimento == txtDataNascimento.Text && clientemodel.Cidade == txtCidade.Text && clientemodel.Cep == txtCep.Text && clientemodel.Rua == txtRua.Text 
                && clientemodel.Bairro == txtBairro.Text && clientemodel.Numero == txtNumero.Text && clientemodel.Uf == txtUf.Text && clientemodel.Complemento == txtComplemento.Text && clientemodel.Telefone == txtTelefone.Text 
                && clientemodel.Celular == txtCelular.Text && clientemodel.Email == txtEmail.Text && clientemodel.ValorLimite == txtValorLimite.Text && clientemodel.Sexo == (rbMasculino.Checked?"m":"F") && clientemodel.Cpf == txtCpf.Text)
            {
                MessageBox.Show("Voce precisa alterar um campo");
                return;
            }


            if (Validar() == true)
            {

                clientemodel.Nome = txtNome.Text;


                if (rbMasculino.Checked == true)
                    clientemodel.Sexo = "m";
                else
                    clientemodel.Sexo = "F";
                clientemodel.DataNascimento = txtDataNascimento.Text;
                clientemodel.Cpf = txtCpf.Text;
                clientemodel.Cidade = txtCidade.Text;
                clientemodel.Cep = txtCep.Text;
                clientemodel.Rua = txtRua.Text;
                clientemodel.Bairro = txtBairro.Text;
                clientemodel.Numero = txtNumero.Text;
                clientemodel.Uf = txtUf.Text;
                clientemodel.Complemento = txtComplemento.Text;
                clientemodel.Telefone = txtTelefone.Text;
                clientemodel.Celular = txtCelular.Text;
                clientemodel.Email = txtEmail.Text;
                clientemodel.ValorLimite = txtValorLimite.Text;

                clientecontroller.Alterar(clientemodel);
            }

            //this.Close();
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            txtSexo.Text = "";
            txtCpf.Text = "";
            txtValorLimite.Text = "0.00";
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

        }

        private bool Validar()
        {
            if (!new Regex(@"^[a-zA-Z]+").Match(txtNome.Text).Success)
            {
                MessageBox.Show("Nome inválido");

                return false;
            }
            else if (!new Regex(@"[0-3][0-9][/][0-1][0-9][/][0-9]{4}").Match(txtDataNascimento.Text).Success)
            {
                MessageBox.Show("Data de Nascimento inválida");

                return false;
            }
            else if (!new Regex(@"[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(txtCpf.Text.Replace(",", ".")).Success)
            {
                MessageBox.Show("CPF inválido");

                return false;
            }
            else if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Cidade inválida");

                return false;
            }
            else if (!new Regex(@"[0-9]{5}[-][0-9]{3}$").Match(txtCep.Text.Replace(",", ".")).Success)
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
            else if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Número inválido");

                return false;
            }
            else if (txtUf.Text == string.Empty)
            {
                MessageBox.Show("UF inválido");

                return false;
            }





            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa buscar o Id que deseja  excluir");
                return;
            }
            clientecontroller.Excluir(clientemodel);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "";
            txtDataNascimento.Text = "";
            
            txtCpf.Text = "";
            txtValorLimite.Text = "0.00";
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
        }
    }
}
