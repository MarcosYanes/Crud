using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CrudDesafio.View
{
    public partial class AlterarCliente : Form
    {

        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();
        PedidoModel _pedidoModel = new PedidoModel();
        PedidoController pedidocontroller = new PedidoController();
        

        public AlterarCliente()
        {
            InitializeComponent();
            txtId.Enabled = false;

           

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
            txtCpf.Text = clientemodel.Cpf.ToString();
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
            clientemodel.ValorLimitePreAlteracao = clientemodel.ValorLimite;
            cbSim.Checked = clientemodel.Ativo;     
            

        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
            
            gridClientes.DataSource = clientecontroller.Listar();
            if (clientemodel.IdCliente != 0)
            {
                CarregarDadosParaAlteracao(clientemodel);
            }

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text == string.Empty)
            {

                return;
            }

            if (Validar() == true)
            {              
                

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
                clientemodel.Ativo = cbSim.Checked;

                clientecontroller.Alterar(clientemodel);
                MessageBox.Show("Dados Salvos com Sucesso");

                limparTextBoxes(groupBox1.Controls);
                limparTextBoxes(groupBox2.Controls);
                limparTextBoxes(groupBox3.Controls);
                limparTextBoxes(groupBox4.Controls);
                cbSim.Checked = false;
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
            else if (txtTelefone.Text == string.Empty && txtCelular.Text == string.Empty)
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
        public void  BuscarPedido(PedidoModel pedidoModel)
        {
            
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //if (pedidoModel.IdCliente != 0){
            //    MessageBox.Show("errO");
            //    return;
            //}
            if (txtId.Text == string.Empty)
            {

                return;
            }
            if (MessageBox.Show("Deseja realmente excluir?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");

            }
            else
            {
                try
                {
                    clientecontroller.Excluir(clientemodel);
                    MessageBox.Show("Cliente deletado com sucesso");
                    limparTextBoxes(groupBox1.Controls);
                    limparTextBoxes(groupBox2.Controls);
                    limparTextBoxes(groupBox3.Controls);
                    limparTextBoxes(groupBox4.Controls);
                    cbSim.Checked = false;

                }

                catch
                {
                    MessageBox.Show("Você não pode Excluir o Cliente, pois ele está vinculado a uma compra");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparTextBoxes(groupBox1.Controls);
            limparTextBoxes(groupBox2.Controls);
            limparTextBoxes(groupBox3.Controls);
            limparTextBoxes(groupBox4.Controls);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void limparTextBoxes(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
                if (ctrl is MaskedTextBox)
                {
                    ((MaskedTextBox)(ctrl)).Text = string.Empty;
                }
            }
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
            txtCpf.Text = Funcoes.ObterSomenteNumeros(clientemodel.Cpf.ToString());
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
            cbSim.Checked = clientemodel.Ativo;
        }


    }
}
