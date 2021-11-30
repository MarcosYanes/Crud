using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace CrudDesafio.View
{
    public partial class CadastroProduto : Form
    {
        ProdutoController produtocontroller = new ProdutoController();
        ProdutoModel produtomodel = new ProdutoModel();
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Validar() == true)
            {
                produtomodel.NomeProduto = txtNomeProduto.Text;
                produtomodel.PrecoDeCusto = double.Parse(txtPrecoDeCusto.Text.Replace(".", ","));
                produtomodel.PrecoDeVenda = double.Parse(txtPrecoDeVenda.Text.Replace(".", ","));
                produtomodel.Estoque = int.Parse(txtEstoque.Text);
                produtomodel.Fabricante = txtFabricante.Text;
                produtomodel.Ativo = cbSim.Checked;
                produtomodel.CodigoDeBarra = txtCodigoDeBarra.Text;

                produtocontroller.Inserir(produtomodel);
                MessageBox.Show("Cadastro Efetuado com Sucesso");
                this.Close();
            }
            

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }
        
        public bool Validar()
        {
            if (!Validacoes.ValidarNomeProduto(txtNomeProduto.Text))
            {
                MessageBox.Show("Nome inválido");

                return false;
            }         
            else if (!Validacoes.ValidarParaQueSejaNumero(txtPrecoDeCusto.Text.Replace(".", ",")))
            {
                MessageBox.Show("Preço de custo inválido !");
                return false;
            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtPrecoDeVenda.Text.Replace(".", ",")))
            {
                MessageBox.Show("Preço de venda inválido !");
                return false;
            }
            else if (!Validacoes.ValidarNumeroPositivo(txtEstoque.Text))
            {
                MessageBox.Show("Estoque inválido !");
                return false;
            }
            else if (!Validacoes.ValidarNumeroPositivo(txtCodigoDeBarra.Text))
            {
                MessageBox.Show("Código de barra inváido !");
                return false;
            }
            else if(txtFabricante.Text == string.Empty)
            {
                MessageBox.Show("Fabricante Inválido !");
                return false;
            }

            return true;
        }


    }
}
