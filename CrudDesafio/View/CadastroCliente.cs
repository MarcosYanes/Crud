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
            if(txtNome.Text == string.Empty)
            {
                MessageBox.Show("Você Precisa digitar o Nome");

                return;
            }
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

            
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (txtBuscar.Text == string.Empty)
        //    {
        //        MessageBox.Show("Você precisa digitar um id");

        //        return;
        //    }

        //    clientemodel = clientecontroller.Buscar(Convert.ToInt32(txtBuscar.Text));

        //    if(clientemodel.Id == 0)
        //    {
        //        return;
        //    }
        //    txtNome.Text = clientemodel.Nome;
        //    if (clientemodel.Sexo == "m")
        //    {
        //        rbMasculino.Checked = true;
        //    }
        //    else
        //    {
        //        rbFeminino.Checked = true;
        //    }
        //    txtDataNascimento.Text = clientemodel.DataNascimento;
        //    txtCpf.Text = clientemodel.Cpf;
        //    txtCidade.Text = clientemodel.Cidade;
        //    txtCep.Text = clientemodel.Cep;
        //    txtRua.Text = clientemodel.Rua;
        //    txtBairro.Text = clientemodel.Bairro;
        //    txtNumero.Text = clientemodel.Numero;
        //    txtUf.Text = clientemodel.Uf;
        //    txtComplemento.Text = clientemodel.Complemento;
        //    txtTelefone.Text = clientemodel.Telefone;
        //    txtCelular.Text = clientemodel.Celular;
        //    txtEmail.Text = clientemodel.Email;
        //    txtValorLimite.Text = clientemodel.ValorLimite;

        //    btnSalvar.Enabled = false;
        //}

        //private void btnAlterar_Click(object sender, EventArgs e)
        //{

        //    if (txtBuscar.Text == string.Empty)
        //    {
        //        MessageBox.Show("Você precisa buscar o Id que deseja Alterar");
        //        return;
        //    }
        //    clientemodel.Nome = txtNome.Text;
            

        //    if (rbMasculino.Checked == true)
        //        clientemodel.Sexo = "m";
        //    else
        //        clientemodel.Sexo = "F";
        //    clientemodel.DataNascimento = txtDataNascimento.Text;
        //    clientemodel.Cpf = txtCpf.Text;
        //    clientemodel.Cidade = txtCidade.Text;
        //    clientemodel.Cep = txtCep.Text;
        //    clientemodel.Rua = txtRua.Text;
        //    clientemodel.Bairro = txtBairro.Text;
        //    clientemodel.Numero = txtNumero.Text;
        //    clientemodel.Uf = txtUf.Text;
        //    clientemodel.Complemento = txtComplemento.Text;
        //    clientemodel.Telefone = txtTelefone.Text;
        //    clientemodel.Celular = txtCelular.Text;
        //    clientemodel.Email = txtEmail.Text;
        //    clientemodel.ValorLimite = txtValorLimite.Text;

        //    clientecontroller.Alterar(clientemodel);
        //}

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    if (txtBuscar.Text == string.Empty)
        //    {
        //        MessageBox.Show("Você precisa buscar o Id que deseja  excluir");
        //        return;
        //    }
        //    clientecontroller.Excluir(clientemodel);
        //}

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
    }
}
