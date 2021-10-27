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

            if (txtNomeColaborador.Text == string.Empty)
            {
                MessageBox.Show("Você Precisa digitar o Nome");

                return;
            }
            else if (txtAgencia.Text == string.Empty)
            {
                MessageBox.Show("Você Precisa digitar a Agência");

                return;

            }
            else if (txtConta.Text == string.Empty)
            {
                MessageBox.Show("Você Precisa digitar a Conta");

                return;

            }
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


            colaboradorcontroller.Inserir(colaboradormodel);

            this.Close();

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
