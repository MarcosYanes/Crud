using CrudDesafio.Controller;
using CrudDesafio.Model;
using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text;

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
            //var email = clientemodel.Email;
            
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
            if(clientemodel.ValidarDataAniversario())
                MessageBox.Show($"Parabéns {clientemodel.Nome}, Hoje é seu aniversário", "Parabéns");
            //var Email = clientemodel.Email;
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

        public  bool ValidarCamposAntesDeAdicionarOsProdutos()
        {
            if (txtIdProduto.Text == string.Empty)
            {
                MessageBox.Show("Escolha um produto");
                return false;
            }
            else if (txtQuantidade.Text.Equals("") || txtTotal.Text == string.Empty)
            {
                MessageBox.Show("Campo Quantidade deve ser preenchido");
                return false;
            }
            else if(txtQuantidade.Text == "0")
            {
                MessageBox.Show("Quantidade não pode ser 0");
                return false;
            }
            
            
            
            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double.TryParse(txtDesconto.Text, out double desconto);
            btnSalvar.Enabled = true;
            if (ValidarCamposAntesDeAdicionarOsProdutos()==false)
            {
                return;
            }
            double PrecoVenda = Convert.ToDouble(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text));
            if (((double)txtDesconto.Value > PrecoVenda))
            {
                MessageBox.Show("Desconto não pode ser maior que o valor do produto !");
                return;
            }

            var produto = new CarrinhoProduto()
            {
                IdPedido = _pedido.IdPedido,
                IdProduto = int.Parse(txtIdProduto.Text),
                NomeProduto = txtNomeProduto.Text,
                PrecoDeCusto = double.Parse(Funcoes.ObterSomenteNumeros(txtPrecoDeCusto.Text)),
                PrecoVenda = double.Parse(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text)),
                //Desconto = double.Parse(txtDesconto.Text),
                Desconto = desconto,
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
            LimparTextBox();      
                       
        }
        
        

        private void CalcularTotaisPedido()
        {
            txtTotalBruto.Text = _pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = _pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = _pedido.TotalLiquido.ToString("c");
            txtLucro.Text = _pedido.Lucro.ToString();   
            

        }
        private void AtualizarGrid()
        {
            gridCarrinho.DataSource = null;
            gridCarrinho.DataSource = _pedido.Produtos;
            gridCarrinho.Columns["idpedido_produto"].Visible = false;
            gridCarrinho.Columns["idpedido"].Visible = false;
            gridCarrinho.Columns["idproduto"].Visible = false;
            gridCarrinho.Columns["lucro"].Visible = false;
            gridCarrinho.Columns["precodecusto"].Visible = false;
            gridCarrinho.Columns["nomeproduto"].HeaderText = "nome do produto";
            gridCarrinho.Columns["precovenda"].HeaderText = "preço";
            gridCarrinho.Columns["precoliquido"].HeaderText = "total pago";
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
            CalcularCusto();
        }

        private void txtDesconto_KeyUp(object sender, KeyEventArgs e)
        {            
            CalcularCusto();
        }

        private void txtTotalLiquido_TextChanged(object sender, EventArgs e)
        {
            
            

        }
        public string ConstruirCorpoDoEmail()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"Olá {clientemodel.Nome}, sua compra no valor de R${_pedido.TotalLiquido} reais foi registrada");
             
            foreach (var produto in _pedido.Produtos)
            {
                 builder.AppendLine($"\nNome: {produto.NomeProduto} |" + $" Quantidade: {produto.Quantidade}");
            }
             
               builder.AppendLine("Augustu's Fashion agradece sua preferência, volte sempre !");
            return builder.ToString();
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
                    
                    _pedido.DataInicial = DateTime.Now;
                    pedidoController.Inserir(_pedido);
                    
                    MessageBox.Show("Cadastro Efetuado com Sucesso");

                  
                }
                //enviar email
                SmtpClient cliente = new SmtpClient();
                NetworkCredential credenciais = new NetworkCredential();
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;

                credenciais.UserName = "marcosjose.moraes1999";                
                credenciais.Password = "marcosjose123@";
                

                cliente.Credentials = credenciais;
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("marcosjose.moraes1999@gmail.com");
                mensagem.Subject = "Augustu's Fashion";
                mensagem.Body = ConstruirCorpoDoEmail();
                mensagem.IsBodyHtml = true;
                
                mensagem.To.Add(clientemodel.Email);

                cliente.Send(mensagem);

                //IMPRIMIR NOTA
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
                MessageBox.Show("Email Enviado Com Sucesso");
                this.Close();
            }

            

           
        }

        public bool Validar()
        {
            if (txtFormaPagamento.Text == "A Prazo")
            {
                double valor = Convert.ToDouble(Funcoes.ObterTotalLiquido(txtTotalLiquido.Text));
                if (valor > clientemodel.ValorLimite)
                {
                    MessageBox.Show("Essa venda não pode ser realizada, pois o valor ultrapassa o limite de compras a prazo do cliente");
                    return false;
                }
            }
            else if (clientemodel.IdCliente == 0)
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
        public void LimparTextBox()
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtTotal.Text = "";
            txtPrecoVenda.Text = "0";
            txtDesconto.Value = 0;
            txtQuantidade.Value = 0;
            txtPrecoDeCusto.Text = "";
            txtTotalBrutoProduto.Text = "";
            txtTotal.Text = "";
        }


    }
}
