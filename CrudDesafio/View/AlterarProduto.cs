using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudDesafio.Model;
using CrudDesafio.Controller;


namespace CrudDesafio.View
{
    public partial class AlterarProduto : Form
    {

        ProdutoController produtocontroller = new ProdutoController();
        ProdutoModel produtomodel = new ProdutoModel();
        public AlterarProduto()
        {
            InitializeComponent();
        }
        public void CarregarDadosParaAlteracao(ProdutoModel produto)
        {
            txtIdProduto.Enabled = false;
            produtomodel = produto;
            txtIdProduto.Text = produto.IdProduto.ToString();

            txtNomeProduto.Text = produto.NomeProduto;
            txtPrecoDeVenda.Text = produto.PrecoDeVenda.ToString();
            txtPrecoDeCusto.Text = produto.PrecoDeCusto.ToString();
            txtCodigoDeBarra.Text = produto.CodigoDeBarra;
            txtEstoque.Text = produto.Estoque.ToString();
            cbSim.Checked = produtomodel.Ativo;
           

            txtFabricante.Text = produto.Fabricante;



        }



        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text == string.Empty)
            {
                return;
            }

            if (Validar() == true)
            {
                if(produtomodel.NomeProduto == txtNomeProduto.Text && produtomodel.CodigoDeBarra == txtCodigoDeBarra.Text && 
                    produtomodel.PrecoDeCusto == double.Parse(txtPrecoDeCusto.Text)&& produtomodel.PrecoDeVenda == double.Parse(txtPrecoDeVenda.Text) &&
                    produtomodel.Estoque == int.Parse(txtEstoque.Text) && produtomodel.Fabricante == txtFabricante.Text && produtomodel.Ativo == cbSim.Checked)
                {
                    MessageBox.Show("Você precisa alterar algum campo ");
                    return;
                }
               
                produtomodel.IdProduto = Convert.ToInt32(txtIdProduto.Text);
                produtomodel.NomeProduto = txtNomeProduto.Text;
                produtomodel.CodigoDeBarra = txtCodigoDeBarra.Text;
                produtomodel.PrecoDeCusto = double.Parse(txtPrecoDeCusto.Text);
                produtomodel.PrecoDeVenda = double.Parse(txtPrecoDeVenda.Text);
                produtomodel.Estoque = int.Parse(txtEstoque.Text);
                produtomodel.Ativo = cbSim.Checked;

                produtomodel.Fabricante = txtFabricante.Text;

                produtocontroller.Alterar(produtomodel);
                MessageBox.Show("Produto Alterado com Sucesso");
                LimparCampos();
            }
        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                MessageBox.Show("Você precisa digitar um id");

                return;
            }
           
            if (!Validacoes.ValidarBusca(txtBusca.Text))
            {
                MessageBox.Show("Busca Inválida ! ");
                return;
            }

            produtomodel = produtocontroller.Buscar(Convert.ToInt32(txtBusca.Text));

            if (produtomodel.IdProduto == 0)
            {
                return;
            }
            txtIdProduto.Text = produtomodel.IdProduto.ToString();
            txtNomeProduto.Text = produtomodel.NomeProduto;
            txtPrecoDeVenda.Text = produtomodel.PrecoDeVenda.ToString();
            txtPrecoDeCusto.Text = produtomodel.PrecoDeCusto.ToString();
            txtCodigoDeBarra.Text = produtomodel.CodigoDeBarra;
            txtEstoque.Text = produtomodel.Estoque.ToString();
            cbSim.Checked = produtomodel.Ativo;
            txtFabricante.Text = produtomodel.Fabricante;



        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (txtIdProduto.Text == string.Empty)
            {

                return;
            }

            if (MessageBox.Show("Deseja realmente excluir?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");

            }
            else
            {

                produtocontroller.Excluir(produtomodel);
                MessageBox.Show("Produto Deletado  com Sucesso");
            }
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
            else if (txtFabricante.Text == string.Empty)
            {
                MessageBox.Show("Fabricante Inválido !");
                return false;
            }

            return true;
        }

        private void LimparCampos()
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtPrecoDeVenda.Text = "";
            txtPrecoDeCusto.Text = "";
            txtCodigoDeBarra.Text = "";
            txtEstoque.Text = "";
            cbSim.Checked = false;
            txtFabricante.Text = "";
        }



    }
}
