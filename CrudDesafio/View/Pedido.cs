using CrudDesafio.Controller;
using CrudDesafio.Model;
using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class Pedido : Form
    {
        private ClienteModel clientemodel = new ClienteModel();
        private ColaboradorModel colaboradormodel = new ColaboradorModel();
        private PedidoController pedidoController = new PedidoController();
        private ProdutoModel produtomodel = new ProdutoModel();
        private PedidoModel _pedido;
        private ProdutoController produtoController = new ProdutoController();
        public CarrinhoProduto carrinhoProduto = new CarrinhoProduto();
        
              
        

        public Pedido(PedidoModel pedidoModel)
        {
            InitializeComponent();
            
            _pedido = pedidoModel;
            clientemodel.IdCliente = pedidoModel.IdCliente;
            clientemodel.Nome = pedidoModel.NomeCliente;
            colaboradormodel.Nome = pedidoModel.NomeColaborador;
            colaboradormodel.IdColaborador = pedidoModel.IdColaborador;
            btnSalvar.Enabled = false;
            txtQuantidade.Enabled = false;
            txtDesconto.Enabled = false;






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
            txtQuantidade.Enabled = true;
            txtDesconto.Enabled = true;
            txtIdProduto.Text = produtomodel.IdProduto.ToString();
            txtNomeProduto.Text = produtomodel.NomeProduto;
            txtPrecoVenda.Text = produtomodel.PrecoDeVenda.ToString("c");
            txtPrecoDeCusto.Text = produtomodel.PrecoDeCusto.ToString("c");
           
            
            
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            
            if (_pedido.IdPedido != 0)
            {
                
                btnSalvar.Enabled = true;
                CarregarDadosParaAlteracao(_pedido);
                AtualizarGrid();
            }
                
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

        

        private void CalcularCusto()
        {
                    

                int quantidade = Convert.ToInt32(txtQuantidade.Value);
                double precoVenda = Convert.ToDouble(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text));
                double desconto = Convert.ToDouble(txtDesconto.Value);
                txtTotalBrutoProduto.Text = (precoVenda * quantidade).ToString("c");

                txtTotal.Text = ((precoVenda * quantidade) - desconto).ToString("c");
            

        }


        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
        }

        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            //if ()
            //{
            //    MessageBox.Show("Erro");
            //    return;
            //}

            if (txtIdProduto.Text == string.Empty)
            {
                MessageBox.Show("Escolha um produto");
                return;
            }
            
            btnSalvar.Enabled = true;

            var produto = new CarrinhoProduto()
            {
                
                IdPedido = _pedido.IdPedido,
                IdProduto = int.Parse(txtIdProduto.Text),
                NomeProduto = txtNomeProduto.Text,
                PrecoDeCusto = double.Parse(Funcoes.ObterSomenteNumeros(txtPrecoDeCusto.Text)),
                PrecoVenda = double.Parse(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text)),
                Desconto = double.Parse(txtDesconto.Text),
                Quantidade = Convert.ToInt32(txtQuantidade.Text),

                
            };


            var produtoJaInserido = SelecionarProdutoDoCarrinho(produto.IdProduto);

            if (produtoJaInserido == null)
            {
                _pedido.AdicionarProduto(produto);
            }
            else
            {
                int indice = _pedido.Produtos.IndexOf(produtoJaInserido);

                _pedido.Produtos[indice].Quantidade = Convert.ToInt32(txtQuantidade.Value);
                _pedido.Produtos[indice].Desconto = Convert.ToDouble(txtDesconto.Value);
               // _pedido.Produtos[indice].PrecoDeCusto = Convert.ToDouble(txtPrecoDeCusto.Text);
            }

            

           
            AtualizarGrid();
            CalcularTotaisPedido();
                     
            

            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtTotal.Text = "";
            txtPrecoVenda.Text = "0";
            txtDesconto.Value = 0;
            txtQuantidade.Value = 0;
            txtPrecoDeCusto.Text = "";
        }
        

        private void CalcularTotaisPedido()
        {
            txtTotalBruto.Text = _pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = _pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = _pedido.TotalLiquido.ToString("c");
            txtLucro.Text = _pedido.Lucro.ToString();
            
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
            gridCarrinho.Columns["IdPedido_produto"].Visible = false;
            gridCarrinho.Columns["IdPedido"].Visible = false;
            gridCarrinho.Columns["IdProduto"].Visible = false;
            gridCarrinho.Columns["Lucro"].Visible = false;
            gridCarrinho.Columns["PrecoDeCusto"].Visible = false;
            gridCarrinho.Columns["NomeProduto"].HeaderText = "Nome do Produto";
            gridCarrinho.Columns["PrecoVenda"].HeaderText = "Preço";
            gridCarrinho.Columns["PrecoLiquido"].HeaderText = "Total Pago";
        }

        public int SelecionarProduto()
        {
            var id = Convert.ToInt32(gridCarrinho.SelectedRows[0].Cells[2].Value);
            return id;
        }

        private void gridCarrinho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDesconto.Enabled = true;
            txtQuantidade.Enabled = true;
             var id = SelecionarProduto();
             var produtoDoCarrinho = SelecionarProdutoDoCarrinho(id);

             CarregarProdutoDoCarrinho(produtoDoCarrinho);            
        }

        private void CarregarProdutoDoCarrinho(CarrinhoProduto produtoDoCarrinho)
        {
            txtIdProduto.Text = produtoDoCarrinho.IdProduto.ToString();
            txtNomeProduto.Text = produtoDoCarrinho.NomeProduto;
            txtPrecoDeCusto.Text = produtoDoCarrinho.PrecoDeCusto.ToString();
            txtPrecoVenda.Text = produtoDoCarrinho.PrecoVenda.ToString();
            txtQuantidade.Value = produtoDoCarrinho.Quantidade;
            txtDesconto.Value = Convert.ToDecimal(produtoDoCarrinho.Desconto);
        }

        private CarrinhoProduto SelecionarProdutoDoCarrinho(int id)
        {
            return (from x in _pedido.Produtos where x.IdProduto == id select x).FirstOrDefault();
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (_pedido.Produtos.Count == 0)
            {
                MessageBox.Show("Não Tem Mais Itens Para Remover");
                return;
            }
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

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            
            CalcularCusto();
        }

        private void txtDesconto_ValueChanged(object sender, EventArgs e)
        {
            CalcularCusto();
        }

        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            //if (!Validacoes.ValidarNumeroPositivo(txtQuantidade.Value.ToString()))
            //{
            //    MessageBox.Show("campo inválido");
            //    return;
            //}
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
            if (Validar())
            {
                if(_pedido.Produtos.Count == 0)
                {
                    MessageBox.Show("Impossível Finalizar Um Pedido Sem Escolher Um Produto!");
                    return;
                }

                _pedido.IdCliente = clientemodel.IdCliente;
                _pedido.IdColaborador = colaboradormodel.IdColaborador;
                _pedido.FormaPagamento = txtFormaPagamento.Text;

                if (_pedido.IdPedido != 0)
                {


                    pedidoController.Alterar(_pedido);
                    MessageBox.Show("Cadastro Alterado com Sucesso");
                }
                else
                {
                    if (produtomodel.IdProduto == 0)
                    {
                        MessageBox.Show("Escolha um Produto!");
                        return ;
                    }
                    pedidoController.Inserir(_pedido);
                    
                    MessageBox.Show("Cadastro Efetuado com Sucesso");

                  
                }
                

                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Augusto Fashion";
                //printer.SubTitle = "";
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Desconto:" + txtTotalDesconto.Text + "% \r\n" + "Total : " + txtTotalLiquido.Text;
                printer.FooterSpacing = 15;
                printer.PrintDataGridView(gridCarrinho);
                this.Close();
            }

            

           
        }

        public bool Validar()
        {
            if (clientemodel.IdCliente == 0)
            {
                MessageBox.Show("Cliente inválido"); 
                return false;
            }
            else if (colaboradormodel.IdColaborador == 0)
            {
                MessageBox.Show("Colaborador Inválido");
                return false;
            }
            
            else if(txtFormaPagamento.Text == string.Empty)
            {
                MessageBox.Show("Forma de Pagamento Inválida!");
                return false;
            }
            return true;
        }

        public void CarregarDadosParaAlteracao(PedidoModel pedido)
        {
            gridCarrinho.DataSource = pedido.Produtos;

            //txtIdPedido.Text = pedido.IdPedido.ToString();
            txtIdCliente.Text = pedido.IdCliente.ToString();
            txtNomeCliente.Text = _pedido.NomeCliente.ToString();
            txtNomeColaborador.Text = _pedido.NomeColaborador.ToString();
            txtIdColaborador.Text = pedido.IdColaborador.ToString();
            txtFormaPagamento.Text = pedido.FormaPagamento.ToString();
            txtTotalBruto.Text = pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = pedido.TotalLiquido.ToString("c");
            txtLucro.Text = pedido.Lucro.ToString();
            


            clientemodel.Id = pedido.IdCliente;
            colaboradormodel.Id = pedido.IdColaborador;
        }

       
    }
}
