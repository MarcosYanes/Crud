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
    public partial class AlterarColaborador : Form
    {

        ColaboradorController colaboradorcontroller = new ColaboradorController();
        ColaboradorModel colaboradormodel = new ColaboradorModel();

        public AlterarColaborador()
        {
            InitializeComponent();
            txtId.Enabled = false;
        }
        //public AlterarColaborador(ColaboradorModel colaborador)
        //{

        //    InitializeComponent();
           
        //}

        public void CarregarDadosParaAlteracao(ColaboradorModel colaborador)
        {
            txtId.Enabled = false;
            colaboradormodel = colaborador;
            txtId.Text = colaboradormodel.IdColaborador.ToString();

            txtNomeColaborador.Text = colaboradormodel.Nome;
            txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimento.ToString();
            if (colaboradormodel.Sexo == "m")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
            }
            //txt.Text = colaboradormodel.Sexo;
            txtCpfColaborador.Text = colaboradormodel.Cpf;
            txtSalarioColaborador.Text = colaboradormodel.Salario.ToString();
            txtComissaoColaborador.Text = colaboradormodel.Comissao;
            txtCidadeColaborador.Text = colaboradormodel.Cidade;
            txtCepColaborador.Text = colaboradormodel.Cep;
            txtLogradouroColaborador.Text = colaboradormodel.Rua;
            txtBairroColaborador.Text = colaboradormodel.Bairro;
            txtUfColaborador.Text = colaboradormodel.Uf;
            txtComplementoColaborador.Text = colaboradormodel.Complemento;
            txtTelefoneColaborador.Text = colaboradormodel.Telefone;
            txtCelularColaborador.Text = colaboradormodel.Celular;
            txtEmailColaborador.Text = colaboradormodel.Email;
            
            txtNumeroColaborador.Text = colaboradormodel.Numero;
            txtBanco.Text = colaboradormodel.Banco;
            txtAgencia.Text = colaboradormodel.Agencia.ToString();
            txtConta.Text = colaboradormodel.Conta.ToString();
            txtTipoConta.Text = colaboradormodel.TipoConta;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
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

            colaboradormodel = colaboradorcontroller.Buscar(Convert.ToInt32(txtBuscar.Text));

            if (colaboradormodel.IdColaborador == 0)
            {
                return;
            }
            txtNomeColaborador.Text = colaboradormodel.Nome;
            if (colaboradormodel.Sexo == "m")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFeminino.Checked = true;
            }
            txtId.Text = colaboradormodel.IdColaborador.ToString();
            txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimento.ToString();
           // txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimentoColaborador;
            txtSalarioColaborador.Text = colaboradormodel.Salario.ToString();
            txtComissaoColaborador.Text = colaboradormodel.Comissao;
            txtCepColaborador.Text = colaboradormodel.Cep;
            txtLogradouroColaborador.Text = colaboradormodel.Rua;
            txtCidadeColaborador.Text = colaboradormodel.Cidade;
            txtUfColaborador.Text = colaboradormodel.Uf;
            txtComplementoColaborador.Text = colaboradormodel.Complemento;
            txtBairroColaborador.Text = colaboradormodel.Bairro;
            txtNumeroColaborador.Text = colaboradormodel.Numero;
            txtTelefoneColaborador.Text = colaboradormodel.Telefone;
            txtCelularColaborador.Text = colaboradormodel.Celular;
            txtEmailColaborador.Text = colaboradormodel.Email;
            txtCpfColaborador.Text = colaboradormodel.Cpf;
            txtBanco.Text = colaboradormodel.Banco;
            txtAgencia.Text = colaboradormodel.Agencia.ToString();
            txtConta.Text = colaboradormodel.Conta.ToString();
            txtTipoConta.Text = colaboradormodel.TipoConta;
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (txtId.Text == string.Empty)
            {

                return;
            }

            double.TryParse(txtSalarioColaborador.Text, out double salario);
            int.TryParse(txtAgencia.Text, out int agencia);
            int.TryParse(txtConta.Text, out int conta);

            if (colaboradormodel.Nome == txtNomeColaborador.Text && colaboradormodel.DataNascimento == Convert.ToDateTime(txtDataNascimentoColaborador.Text) &&
                colaboradormodel.Cpf == txtCpfColaborador.Text && colaboradormodel.Salario == salario &&
                colaboradormodel.Comissao == txtComissaoColaborador.Text && colaboradormodel.Cep == txtCepColaborador.Text &&
                colaboradormodel.Rua == txtLogradouroColaborador.Text && colaboradormodel.Cidade == txtCidadeColaborador.Text &&
                colaboradormodel.Bairro == txtBairroColaborador.Text && colaboradormodel.Numero == txtNumeroColaborador.Text &&
                colaboradormodel.Complemento == txtComplementoColaborador.Text && colaboradormodel.Uf == txtUfColaborador.Text &&
                colaboradormodel.Telefone == txtTelefoneColaborador.Text && colaboradormodel.Celular == txtCelularColaborador.Text &&
                colaboradormodel.Email == txtEmailColaborador.Text && colaboradormodel.Banco == txtBanco.Text && colaboradormodel.TipoConta == txtTipoConta.Text &&
                colaboradormodel.Sexo == (rbMasculino.Checked ? "m" : "F") && colaboradormodel.Agencia == agencia && colaboradormodel.Conta == conta)
            {
                MessageBox.Show("Voce precisa alterar um campo");
                return;
            }


            if (Validar() == true)
            {
                               
                colaboradormodel.Nome = txtNomeColaborador.Text;
                if (rbMasculino.Checked == true)
                    colaboradormodel.Sexo = "m";
                else
                    colaboradormodel.Sexo = "F";
                colaboradormodel.DataNascimento = Convert.ToDateTime(txtDataNascimentoColaborador.Text);
                colaboradormodel.Salario = salario;
                colaboradormodel.Comissao= txtComissaoColaborador.Text;
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
                colaboradormodel.Agencia = agencia;
                colaboradormodel.Conta = conta;
                colaboradormodel.TipoConta = txtTipoConta.Text;




                colaboradorcontroller.Alterar(colaboradormodel);
                MessageBox.Show("Cadastro Alterado com Sucesso");


                txtNomeColaborador.Text = "";
                txtDataNascimentoColaborador.Text = "";
                txtCpfColaborador.Text = "";
                txtSalarioColaborador.Text = "";
                txtComissaoColaborador.Text = "";
                txtCepColaborador.Text = "";
                txtLogradouroColaborador.Text = "";
                txtCidadeColaborador.Text = "";
                txtBairroColaborador.Text = "";
                txtNumeroColaborador.Text = "";
                txtComplementoColaborador.Text = "";
                txtUfColaborador.Text = "";
                txtTelefoneColaborador.Text = "";
                txtCepColaborador.Text = "";
                txtEmailColaborador.Text = "";
                txtCelularColaborador.Text = "";
                txtBuscar.Text = "";
                txtBanco.Text = "";
                txtAgencia.Text = "";
                txtConta.Text = "";
                txtTipoConta.Text = "";
                txtId.Text = "";
                gridColaborador.DataSource = colaboradorcontroller.Listar();
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
            else if (txtSalarioColaborador.Text == string.Empty)
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


            return true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {

                return;
            }

            colaboradorcontroller.Excluir(colaboradormodel);
            MessageBox.Show("Colaborador deletado com sucesso");

            txtNomeColaborador.Text = "";
            txtDataNascimentoColaborador.Text = "";
            txtCpfColaborador.Text = "";
            txtSalarioColaborador.Text = "";
            txtComissaoColaborador.Text = "";
            txtCepColaborador.Text = "";
            txtLogradouroColaborador.Text = "";
            txtCidadeColaborador.Text = "";
            txtBairroColaborador.Text = "";
            txtNumeroColaborador.Text = "";
            txtComplementoColaborador.Text = "";
            txtUfColaborador.Text = "";
            txtTelefoneColaborador.Text = "";
            txtCepColaborador.Text = "";
            txtEmailColaborador.Text = "";
            txtCelularColaborador.Text = "";
            txtBuscar.Text = "";
            txtBanco.Text = "";
            txtAgencia.Text = "";
            txtConta.Text = "";
            txtTipoConta.Text = "";
            txtId.Text = "";
            gridColaborador.DataSource = colaboradorcontroller.Listar();
        }

        private void AlterarColaborador_Load(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
            //gridColaborador.DataSource = colaboradorcontroller.Listar();
            //gridColaborador.Columns["SalarioColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            //gridColaborador.Columns["ComissaoColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            //gridColaborador.Columns["Banco"].DisplayIndex = gridColaborador.Columns.Count - 1;
            //gridColaborador.Columns["Agencia"].DisplayIndex = gridColaborador.Columns.Count - 1;
            //gridColaborador.Columns["Conta"].DisplayIndex = gridColaborador.Columns.Count - 1;
            //gridColaborador.Columns["TipoConta"].DisplayIndex = gridColaborador.Columns.Count - 1;
        }

       

        

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNomeColaborador.Text = "";
            txtDataNascimentoColaborador.Text = "";
            txtCpfColaborador.Text = "";
            txtSalarioColaborador.Text = "";
            txtComissaoColaborador.Text = "";
            txtCepColaborador.Text = "";
            txtLogradouroColaborador.Text = "";
            txtCidadeColaborador.Text = "";
            txtBairroColaborador.Text = "";
            txtNumeroColaborador.Text = "";
            txtComplementoColaborador.Text = "";
            txtUfColaborador.Text = "";
            txtTelefoneColaborador.Text = "";
            txtCepColaborador.Text = "";
            txtEmailColaborador.Text = "";
            txtCelularColaborador.Text = "";
            txtBuscar.Text = "";
            txtBanco.Text = "";
            txtAgencia.Text = "";
            txtConta.Text = "";
            txtTipoConta.Text = "";
            txtId.Text = "";

        }
    }
}
