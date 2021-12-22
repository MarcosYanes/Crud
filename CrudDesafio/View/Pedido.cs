using CrudDesafio.Controller;
using CrudDesafio.Helpers;
using CrudDesafio.Model;
using DGVPrinterHelper;
using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class Pedido : Form
    {
        private ClienteModel clientemodel = new ClienteModel();
        private ColaboradorModel colaboradormodel = new ColaboradorModel();
        private PedidoController pedidoController = new PedidoController();
        private ProdutoModel produtomodel;
        private PedidoModel _pedido;
        private ProdutoController produtoController = new ProdutoController();
        public CarrinhoProduto carrinhoProduto;
        public ClienteController clientecontroller = new ClienteController();

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
                _pedido.TotalPreAlteracao = _pedido.TotalLiquido;
                btnSalvar.Enabled = true;
                var carrinho = _pedido.Produtos;
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
            if (clientemodel.ValidarDataAniversario())
                MessageBox.Show($"Parabéns {clientemodel.Nome}, Hoje é seu aniversário", "Parabéns");
            //var Email = clientemodel.Email;
            txtIdCliente.Text = clientemodel.IdCliente.ToString();
            txtNomeCliente.Text = clientemodel.Nome;
            var valorLimite = clientemodel.ValorLimite;
        }
        public bool CarregarValorLimite()
        {
            var ValorLimite = clientemodel.ValorLimite;
            double valor = Convert.ToDouble(Funcoes.ObterTotalLiquido(txtTotalLiquido.Text));

            if (valor > ValorLimite)
            {
                return false;
            }
            return true;
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
            double.TryParse(txtDesconto.Text.Replace(".", ","), out double Desconto);
            int quantidade = Convert.ToInt32(txtQuantidade.Value);
            double precoVenda = Convert.ToDouble(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text));
            double desconto = Convert.ToDouble(Desconto.ToString());
            txtTotalBrutoProduto.Text = (precoVenda * quantidade).ToString("c");
            txtTotal.Text = ((precoVenda * quantidade) - desconto).ToString("c");
        }
        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularCusto();
        }
        public bool ValidarCamposAntesDeAdicionarOsProdutos()
        {
            if (!Validacoes.ValidarParaQueSejaNumero(txtDesconto.Text))
            {
                MessageBox.Show("Desconto Inválido ");
                return false;
            }
            else if (txtIdProduto.Text == string.Empty)
            {
                MessageBox.Show("Escolha um produto");
                return false;
            }
            else if (txtQuantidade.Text.Equals("") || txtTotal.Text == string.Empty)
            {
                MessageBox.Show("Campo Quantidade deve ser preenchido");
                return false;
            }
            else if (txtQuantidade.Text == "0")
            {
                MessageBox.Show("Quantidade não pode ser 0");
                return false;
            }
            return true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (produtomodel.Estoque < txtQuantidade.Value)
            {
                MessageBox.Show("Quantidade No Estoque Indisponível");
                return;
            }
         
            double.TryParse(txtDesconto.Text.Replace(".", ","), out double desconto);
            btnSalvar.Enabled = true;
            if (ValidarCamposAntesDeAdicionarOsProdutos() == false)
            {
                return;
            }
            double PrecoVenda = Convert.ToDouble(Funcoes.ObterSomenteNumeros(txtPrecoVenda.Text));
            if (desconto > PrecoVenda)
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
                _pedido.Produtos[indice].Desconto = Convert.ToDouble(txtDesconto.Text);
            }
            AtualizarGrid();
            CalcularTotaisPedido();
            LimparTextBox();
            txtQuantidade.Enabled = false;
            txtDesconto.Enabled = false;
        }
        private void CalcularTotaisPedido()
        {
            txtTotalBruto.Text = _pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = _pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = _pedido.TotalLiquido.ToString("c");
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
            gridCarrinho.Columns["nomeproduto"].HeaderText = "Nome do Produto";
            gridCarrinho.Columns["precovenda"].HeaderText = "Preço";
            gridCarrinho.Columns["precoliquido"].HeaderText = "Total Pago";
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
            produtomodel = produtoController.Buscar(produtoDoCarrinho.IdProduto);
            produtomodel.Estoque += produtoDoCarrinho.Quantidade;
            txtIdProduto.Text = produtoDoCarrinho.IdProduto.ToString();
            txtNomeProduto.Text = produtoDoCarrinho.NomeProduto;
            txtPrecoDeCusto.Text = produtoDoCarrinho.PrecoDeCusto.ToString();
            txtPrecoVenda.Text = produtoDoCarrinho.PrecoVenda.ToString();
            txtQuantidade.Value = produtoDoCarrinho.Quantidade;
            txtDesconto.Text = produtoDoCarrinho.Desconto.ToString();
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
        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            CalcularCusto();
        }
        private void txtQuantidade_KeyUp(object sender, KeyEventArgs e)
        {
            CalcularCusto();
        }        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    if (_pedido.Produtos.Count == 0)
                    {
                        MessageBox.Show("Não é possível Finalizar Um Pedido Sem Escolher Um Produto!");
                        return;
                    }
                    _pedido.IdCliente = clientemodel.IdCliente;
                    _pedido.IdColaborador = colaboradormodel.IdColaborador;
                    _pedido.FormaPagamento = txtFormaPagamento.Text;
                    if (_pedido.IdPedido != 0)
                    {
                        pedidoController.Alterar(_pedido, txtFormaPagamento.SelectedIndex);
                        MessageBox.Show("Cadastro Alterado com Sucesso");
                    }
                    else
                    {
                        if (produtomodel.IdProduto == 0)
                        {
                            MessageBox.Show("Escolha um Produto!");
                            return;
                        }
                        _pedido.DataInicial = DateTime.Now;
                        pedidoController.Inserir(_pedido, txtFormaPagamento.SelectedIndex);
                        MessageBox.Show("Cadastro Efetuado com Sucesso");
                    }
                    EnviarEmail();
                    Imprimir();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha no Cadastro" + ex.Message);
            }
        }
        public bool Validar()
        {
            if (txtFormaPagamento.Text == "A Prazo")
            {
                if (CarregarValorLimite() == false)
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

            else if (txtFormaPagamento.Text == string.Empty)
            {
                MessageBox.Show("Forma de Pagamento Inválida!");
                return false;
            }
            return true;
        }
        public void CarregarDadosParaAlteracao(PedidoModel pedido)
        {
            gridCarrinho.DataSource = pedido.Produtos;
            txtIdCliente.Text = pedido.IdCliente.ToString();
            txtNomeCliente.Text = _pedido.NomeCliente.ToString();
            txtNomeColaborador.Text = _pedido.NomeColaborador.ToString();
            txtIdColaborador.Text = pedido.IdColaborador.ToString();
            txtFormaPagamento.Text = pedido.FormaPagamento.ToString();
            txtTotalBruto.Text = pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = pedido.TotalLiquido.ToString("c");
            clientemodel.Id = pedido.IdCliente;
            colaboradormodel.Id = pedido.IdColaborador;
            clientemodel = clientecontroller.Buscar(pedido.IdCliente);
        }
        public void LimparTextBox()
        {
            txtIdProduto.Text = "";
            txtNomeProduto.Text = "";
            txtTotal.Text = "";
            txtPrecoVenda.Text = "0";
            txtDesconto.Text = "0";
            txtQuantidade.Value = 0;
            txtPrecoDeCusto.Text = "";
            txtTotalBrutoProduto.Text = "";
            txtTotal.Text = "";
        }
        public void Imprimir()
        {
            //IMPRIMIR NOTA
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Augusto Fashion";
            //printer.SubTitle = "";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Desconto:" + txtTotalDesconto.Text + " \r\n" + "Total : " + txtTotalLiquido.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gridCarrinho);
        }
        public void EnviarEmail()
        {
            if (MessageBox.Show("Deseja Enviar E-mail ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
            }
            else
            {
                SmtpClient cliente = new SmtpClient();
                NetworkCredential credenciais = new NetworkCredential();
                cliente.Host = "smtp.gmail.com";
                cliente.Port = 587;
                cliente.EnableSsl = true;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = false;
                credenciais.UserName = "marcosjose.moraes1999";
                credenciais.Password = Conexao.senha;
                cliente.Credentials = credenciais;
                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("marcosjose.moraes1999@gmail.com");
                mensagem.Subject = "Augustu's Fashion";
                mensagem.IsBodyHtml = true;
                mensagem.Body = ConstruirCorpoDoEmail();
                mensagem.To.Add(clientemodel.Email);
                cliente.Send(mensagem);
                MessageBox.Show("Email enviado com sucesso");
            }
        }
        public string ConstruirCorpoDoEmail()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"<strong>Olá {clientemodel.Nome}, sua compra no valor de R${_pedido.TotalLiquido} reais foi registrada </strong><br><br>");
            builder.AppendLine("<table border =\"1\"><tr><th> Nome</th> <th> Quantidade</th> <th> Total De Desconto </th> <th> Total Liquido </th></tr>");

            foreach (var produto in _pedido.Produtos)
            {
                builder.AppendLine($"<tr><td> {produto.NomeProduto}</td> <td> {produto.Quantidade}</td><td> {produto.Desconto.ToString("c")}</td><td> {produto.Total.ToString("c")}</td></tr>");
            }
            builder.AppendLine("</table>");
            builder.AppendLine(" Augustu's Fashion agradece sua preferência, volte sempre ! \n");
            return builder.ToString();
        }
        private void txtDesconto_TextChanged_1(object sender, EventArgs e)
        {
            CalcularCusto();
        }     

        //private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        //{

        //    if (ValidarCampoSeENumero())
        //        textBox1.Text = decimal.Parse(textBox1.Text).ToString("n2");
        //    else
        //        textBox1.Text = decimal.Zero.ToString("n2");

        //}
        //private bool ValidarCampoSeENumero()
        //{
        //    decimal numero;
        //    return decimal.TryParse(textBox1.Text, out numero);
        //}



    }
}
