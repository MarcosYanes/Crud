using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class Pedido : Form
    {
        private ClienteModel clientemodel = new ClienteModel();
        private ColaboradorModel colaboradormodel = new ColaboradorModel();
        private PedidoController pedidoController = new PedidoController();
        private ProdutoModel produtomodel = new ProdutoModel();
        private PedidoModel _pedido = new PedidoModel();
        
        

        public Pedido()
        {
            InitializeComponent();
            
            
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            EscolherProduto escolherproduto = new EscolherProduto();
            escolherproduto.ShowDialog();
            produtomodel = escolherproduto.produtomodel;
          
            CarregarProduto();
        }

        public void CarregarProduto()
        {
            txtIdProduto.Text = produtomodel.IdProduto.ToString();
            txtNomeProduto.Text = produtomodel.NomeProduto;
            txtPrecoVenda.Text = produtomodel.PrecoDeVenda.ToString();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnSelecionarCliente_Click(object sender, EventArgs e)
        {
            EscolherCliente escolhercliente = new EscolherCliente();
            escolhercliente.ShowDialog();
            clientemodel = escolhercliente.clientemodel;
            CarregarCliente();
        }

        public void CarregarCliente()
        {
            txtIdCliente.Text = clientemodel.IdCliente.ToString();
            txtNomeCliente.Text = clientemodel.Nome;
        }

        public void CarregarColaborador()
        {
            txtIdColaborador.Text = colaboradormodel.IdColaborador.ToString();
            txtNomeColaborador.Text = colaboradormodel.Nome;
        }

        private void BtnSelecionarColaborador_Click(object sender, EventArgs e)
        {
            EscolherColaborador escolhercolaborador = new EscolherColaborador();
            escolhercolaborador.ShowDialog();
            colaboradormodel = escolhercolaborador.colaboradormodel;
            CarregarColaborador();
        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CalcularCusto()
        {
            int quantidade = Convert.ToInt32(txtQuantidade.Value);
            double precoVenda = Convert.ToDouble(txtPrecoVenda.Text);
            double desconto = Convert.ToDouble(txtDesconto.Value);
            txtTotalBrutoProduto.Text = (precoVenda * quantidade).ToString();

            txtTotal.Text = ((precoVenda * quantidade) - desconto).ToString();
          
        }


        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
        }

      

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            var produto = new CarrinhoProduto()
            {
                IdProduto = int.Parse(txtIdProduto.Text),
                NomeProduto = txtNomeProduto.Text,
                PrecoVenda = double.Parse(txtPrecoVenda.Text),
                Desconto = double.Parse(txtDesconto.Text),
                Quantidade = Convert.ToInt32(txtQuantidade.Text),
            };

            _pedido.AdicionarProduto(produto);
            AtualizarGrid();
            CalcularTotaisPedido();
                     
            

            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtTotal.Text = "";
            txtPrecoVenda.Text = "0";
            txtDesconto.Value = 0;
            txtQuantidade.Value = 0;
        }

        private void CalcularTotaisPedido()
        {
            txtTotalBruto.Text = _pedido.TotalBruto.ToString();
            txtTotalDesconto.Text = _pedido.TotalDeDesconto.ToString();
            txtTotalLiquido.Text = _pedido.TotalLiquido.ToString();
            //txtTotalBruto.Text = _pedido.Produtos.Sum(x => x.TotalBruto).ToString();
            //txtTotalDesconto.Text = _pedido.Produtos.Sum(x => x.Desconto).ToString();

            //double TotalBruto = double.Parse(txtTotalBruto.Text);
            //double TotalDesconto = double.Parse(txtTotalDesconto.Text);
            //double Total = TotalBruto - TotalDesconto;
            //txtTotalLiquido.Text = Total.ToString();

           

        }

        private void AtualizarGrid()
        {
            gridCarrinho.DataSource = null;
            gridCarrinho.DataSource = _pedido.Produtos;
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {            
            var index = gridCarrinho.SelectedRows[0].Index;
            
            _pedido.Produtos.RemoveAt(index);
            AtualizarGrid();
            CalcularTotaisPedido();


        }


        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularCusto();
        }

        private void txtTotalBruto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQuantidade_ValueChanged(object sender, EventArgs e) => CalcularCusto();

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            CalcularCusto();
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularCusto();
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularCusto();
        }

        private void txtTotalLiquido_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //clientemodel.IdCliente = int.Parse(txtIdCliente.Text);
            //colaboradormodel.IdColaborador = int.Parse(txtIdColaborador.Text);
            _pedido.IdCliente = clientemodel.IdCliente;
            _pedido.IdColaborador = colaboradormodel.IdColaborador;
            _pedido.FormaPagamento = txtFormaPagamento.Text;

            pedidoController.Inserir(_pedido);
            MessageBox.Show("Cadastro Efetuado com Sucesso");
        }
    }
}
