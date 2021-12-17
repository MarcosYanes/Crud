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
    public partial class TelaInicial : Form
    {
        private  ClienteModel _cliente = new ClienteModel();
        public TelaInicial()
        {
            InitializeComponent();
        }
        public TelaInicial(ClienteModel cliente)
        {
            InitializeComponent();
            cliente = _cliente;

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.ShowDialog();


        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarCliente listarcliente = new ListarCliente();
            listarcliente.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarcliente = new AlterarCliente();
            alterarcliente.ShowDialog();
        }
        //internal void AbrirFormDeAlterarCliente()
        //{
        //    var pedido = new Pedido(new PedidoModel());
        //    pedido.Show();
        //}

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroColaborador cadastrocolaborador = new CadastroColaborador();
            cadastrocolaborador.ShowDialog();
        }

        private void colaboradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarColaborador alterarcolaborador = new AlterarColaborador();
            alterarcolaborador.ShowDialog();
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarColaborador listarcolaborador = new ListarColaborador();
            listarcolaborador.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroproduto = new CadastroProduto();
            cadastroproduto.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarProduto listarproduto = new ListarProduto();
            listarproduto.ShowDialog();
        }

        private void produtoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarProduto alterarproduto = new AlterarProduto();
            alterarproduto.Show();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            PedidoController pedidocontroller = new PedidoController();
            pedidocontroller.AbrirFormDePedido();
                      
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarPedido listarpedido = new ListarPedido();
            listarpedido.Show();
        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioProdutos relatorio = new RelatorioProdutos();
            relatorio.Show();
        }

        private void relatorioDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelatorioCliente relatoriocliente = new RelatorioCliente();
            relatoriocliente.Show();
        }
    }
}
