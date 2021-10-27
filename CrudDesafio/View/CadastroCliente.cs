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

namespace CrudDesafio
{
    public partial class CadastroCliente : Form

    {
        
        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();
        public CadastroCliente()
        {
            InitializeComponent();
            txtNome.Focus();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            txtNome.Focus();


        }

        private void cadastrarColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CadastroColaborador add = new CadastroColaborador();
            //add.ShowDialog();
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

                clientecontroller.Inserir(clientemodel);
                this.Close();
            }

            //txtNome.Text = "";
            //txtDataNascimento.Text = "";
            //txtCpf.Text = "";
            //txtCep.Text = "";
            //txtCidade.Text = "";
            //txtRua.Text = "";
            //txtBairro.Text = "";
            //txtNumero.Text = "";
            //txtUf.Text = "";
            //txtComplemento.Text = "";
            //txtTelefone.Text = "";
            //txtCelular.Text = "";
            //txtEmail.Text = "";

            
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        

        private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();
        }

        private void txtValorLimite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private bool Validar()
        {
            if (!new Regex(@"^[a-zA-Z]+").Match(txtNome.Text).Success)
            {
                MessageBox.Show("Nome inválido");

                return false ;
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
            else if  (!new Regex(@"[0-9]{5}[-][0-9]{3}$").Match(txtCep.Text.Replace(",", ".")).Success)
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

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
