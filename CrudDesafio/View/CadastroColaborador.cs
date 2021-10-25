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
            colaboradormodel.NomeColaborador = txtNomeColaborador.Text;
            if (rbMasculino.Checked == true)
                colaboradormodel.SexoColaborador = "m";
            else
                colaboradormodel.SexoColaborador = "F";
            colaboradormodel.DataNascimentoColaborador = txtDataNascimentoColaborador.Text;
            colaboradormodel.SalarioColaborador = double.Parse(txtSalarioColaborador.Text);
            colaboradormodel.ComissaoColaborador = txtComissaoColaborador.Text;
            colaboradormodel.CepColaborador = txtCepColaborador.Text;
            colaboradormodel.LogradouroColaborador = txtLogradouroColaborador.Text;
            colaboradormodel.CidadeColaborador = txtCidadeColaborador.Text;
            colaboradormodel.UfColaborador = txtUfColaborador.Text;
            colaboradormodel.ComplementoColaborador = txtComplementoColaborador.Text;
            colaboradormodel.BairroColaborador = txtBairroColaborador.Text;
            colaboradormodel.NumeroColaborador = txtNumeroColaborador.Text;
            colaboradormodel.TelefoneColaborador = txtTelefoneColaborador.Text;
            colaboradormodel.CelularColaborador = txtCelularColaborador.Text;
            colaboradormodel.EmailColaborador = txtEmailColaborador.Text;
            colaboradormodel.CpfColaborador = txtCpfColaborador.Text;
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

        //private void btnBuscar_Click(object sender, EventArgs e)
        //{
        //    if (txtBuscarColaborador.Text == string.Empty)
        //    {
        //        MessageBox.Show("Você precisa digitar um id");
        //    }

        //    colaboradormodel = colaboradorcontroller.Buscar(Convert.ToInt32(txtBuscarColaborador.Text));
        //    txtNomeColaborador.Text = colaboradormodel.NomeColaborador;
        //    if (colaboradormodel.SexoColaborador == "m")
        //    {
        //        rbMasculino.Checked = true;
        //    }
        //    else
        //    {
        //        rbFeminino.Checked = true;
        //    }
        //    txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimentoColaborador;
        //    txtDataNascimentoColaborador.Text = colaboradormodel.DataNascimentoColaborador;
        //    txtSalarioColaborador.Text = colaboradormodel.SalarioColaborador.ToString();
        //    txtComissaoColaborador.Text = colaboradormodel.ComissaoColaborador;
        //    txtCepColaborador.Text = colaboradormodel.CepColaborador;
        //    txtLogradouroColaborador.Text = colaboradormodel.LogradouroColaborador;
        //    txtCidadeColaborador.Text = colaboradormodel.CidadeColaborador;
        //    txtUfColaborador.Text = colaboradormodel.UfColaborador;
        //    txtComplementoColaborador.Text = colaboradormodel.ComplementoColaborador;
        //    txtBairroColaborador.Text = colaboradormodel.BairroColaborador;
        //    txtNumeroColaborador.Text = colaboradormodel.NumeroColaborador;
        //    txtTelefoneColaborador.Text = colaboradormodel.TelefoneColaborador;
        //    txtCelularColaborador.Text = colaboradormodel.CelularColaborador;
        //    txtEmailColaborador.Text = colaboradormodel.EmailColaborador;
        //    txtCpfColaborador.Text = colaboradormodel.CpfColaborador;
            
        //}

        //private void btnAlterar_Click(object sender, EventArgs e)
        //{
        //   colaboradormodel.NomeColaborador = txtNomeColaborador.Text;
        //    if (rbMasculino.Checked == true)
        //        colaboradormodel.SexoColaborador = "m";
        //    else
        //        colaboradormodel.SexoColaborador = "F";
        //    colaboradormodel.DataNascimentoColaborador = txtDataNascimentoColaborador.Text;
        //    colaboradormodel.SalarioColaborador = double.Parse(txtSalarioColaborador.Text);
        //    colaboradormodel.ComissaoColaborador = txtComissaoColaborador.Text;
        //    colaboradormodel.CepColaborador = txtCepColaborador.Text;
        //    colaboradormodel.LogradouroColaborador = txtLogradouroColaborador.Text;
        //    colaboradormodel.CidadeColaborador = txtCidadeColaborador.Text;
        //    colaboradormodel.UfColaborador = txtUfColaborador.Text;
        //    colaboradormodel.ComplementoColaborador = txtComplementoColaborador.Text;
        //    colaboradormodel.BairroColaborador = txtBairroColaborador.Text;
        //    colaboradormodel.NumeroColaborador = txtNumeroColaborador.Text;
        //    colaboradormodel.TelefoneColaborador = txtTelefoneColaborador.Text;
        //    colaboradormodel.CelularColaborador = txtCelularColaborador.Text;
        //    colaboradormodel.EmailColaborador = txtEmailColaborador.Text;
        //    colaboradormodel.CpfColaborador = txtCpfColaborador.Text;



        //    colaboradorcontroller.Alterar(colaboradormodel);
        //}

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    if (txtBuscarColaborador.Text == string.Empty)
        //    {
        //        MessageBox.Show("Você precisa buscar o Id que deseja  excluir");
        //        return;
        //    }
        //    colaboradorcontroller.Excluir(colaboradormodel);
        //}

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
