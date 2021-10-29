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
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa digitar um id");

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
            txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimento.ToString();
           // txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimentoColaborador;
            txtSalarioColaborador.Text = colaboradormodel.SalarioColaborador.ToString();
            txtComissaoColaborador.Text = colaboradormodel.ComissaoColaborador;
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

            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa buscar o Id que deseja Alterar");
                return;
            }

            double.TryParse(txtSalarioColaborador.Text, out double salario);
            int.TryParse(txtAgencia.Text, out int agencia);
            int.TryParse(txtConta.Text, out int conta);

            if (colaboradormodel.Nome == txtNomeColaborador.Text && colaboradormodel.DataNascimento == Convert.ToDateTime(txtDataNascimentoColaborador.Text) &&
                colaboradormodel.Cpf == txtCpfColaborador.Text && colaboradormodel.SalarioColaborador == salario &&
                colaboradormodel.ComissaoColaborador == txtComissaoColaborador.Text && colaboradormodel.Cep == txtCepColaborador.Text &&
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

                if (!Validacoes.ValidarValorLimite(salario))
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
                colaboradormodel.SalarioColaborador = salario;
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
                colaboradormodel.Agencia = agencia;
                colaboradormodel.Conta = conta;
                colaboradormodel.TipoConta = txtTipoConta.Text;




                colaboradorcontroller.Alterar(colaboradormodel);


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
            }


        }

        public bool Validar()
        {
            if (!new Regex(@"^[a-zA-Z]+$").Match(txtNomeColaborador.Text).Success)
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
            else if (txtCidadeColaborador.Text == string.Empty)
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
                MessageBox.Show("Sálario inválido");
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
            colaboradorcontroller.Excluir(colaboradormodel);

            txtNomeColaborador.Text = "";
            txtDataNascimentoColaborador.Text = "";
            txtCpfColaborador.Text = "";
            txtSalarioColaborador.Text = "0.00";
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
        }

        private void AlterarColaborador_Load(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
            gridColaborador.DataSource = colaboradorcontroller.Listar();
            gridColaborador.Columns["SalarioColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["ComissaoColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Banco"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Agencia"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Conta"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["TipoConta"].DisplayIndex = gridColaborador.Columns.Count - 1;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
        }

        

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNomeColaborador.Text = "";
            txtDataNascimentoColaborador.Text = "";
            txtCpfColaborador.Text = "";
            txtSalarioColaborador.Text = "0.00";
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

        }
    }
}
