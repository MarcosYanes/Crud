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
            produtomodel.NomeProduto = txtNomeProduto.Text;
            produtomodel.PrecoDeCusto = double.Parse(txtPrecoDeCusto.Text);
            produtomodel.PrecoDeVenda = double.Parse(txtPrecoDeVenda.Text);
            produtomodel.Estoque = int.Parse(txtEstoque.Text);
            produtomodel.Fabricante = txtFabricante.Text;
            
            
                produtomodel.Ativo = cbSim.Checked;
            
                                
                            
           produtomodel.CodigoDeBarra = txtCodigoDeBarra.Text;

            produtocontroller.Inserir(produtomodel);

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {

        }

       
    }
}
