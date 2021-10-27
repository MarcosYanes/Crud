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
            txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimento;
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


            //if (colaboradormodel.NomeColaborador == txtNomeColaborador.Text && colaboradormodel.DataNascimentoColaborador == txtDataNascimentoColaborador.Text &&
            //    colaboradormodel.CpfColaborador == txtCpfColaborador.Text && colaboradormodel.SalarioColaborador == double.Parse(txtSalarioColaborador.Text) && 
            //    colaboradormodel.ComissaoColaborador == txtComissaoColaborador.Text && colaboradormodel.CepColaborador == txtCepColaborador.Text &&
            //    colaboradormodel.LogradouroColaborador == txtLogradouroColaborador.Text && colaboradormodel.CidadeColaborador == txtCidadeColaborador.Text && 
            //    colaboradormodel.BairroColaborador == txtBairroColaborador.Text && colaboradormodel.NumeroColaborador == txtNumeroColaborador.Text && 
            //    colaboradormodel.ComplementoColaborador == txtComplementoColaborador.Text && colaboradormodel.UfColaborador == txtUfColaborador.Text &&
            //    colaboradormodel.TelefoneColaborador == txtTelefoneColaborador.Text && colaboradormodel.CelularColaborador == txtCelularColaborador.Text && 
            //    colaboradormodel.EmailColaborador == txtEmailColaborador.Text && colaboradormodel.Banco == txtBanco.Text && colaboradormodel.TipoConta == txtTipoConta.Text &&
            //    colaboradormodel.SexoColaborador == (rbMasculino.Checked ? "m" : "F") && colaboradormodel.Agencia == int.Parse(txtAgencia.Text) && colaboradormodel.Conta == int.Parse(txtConta.Text))
            //{
            //    MessageBox.Show("Voce precisa alterar um campo");
            //    return;
            //}



                colaboradormodel.Nome = txtNomeColaborador.Text;
                if (rbMasculino.Checked == true)
                    colaboradormodel.Sexo = "m";
                else
                    colaboradormodel.Sexo = "F";
                colaboradormodel.DataNascimento = txtDataNascimentoColaborador.Text;
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




            colaboradorcontroller.Alterar(colaboradormodel);


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
