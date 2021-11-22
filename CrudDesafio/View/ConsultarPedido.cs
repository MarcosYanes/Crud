using CrudDesafio.Model;
using System;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class ConsultarPedido : Form
    {
        public ConsultarPedido()
        {
            InitializeComponent();
        }

        private void ConsultarPedido_Load(object sender, EventArgs e)
        {
        }

        public int SelecionarPedidoModel()
        {
            var id = Convert.ToInt32(gridPedidos.SelectedRows[0].Cells[0].Value);
            return id;
        }

        public void CarregarDados(PedidoModel pedido)
        {
            gridPedidos.DataSource = pedido.Produtos;
            txtIdPedido.Text = pedido.IdPedido.ToString();
            txtIdCliente.Text = pedido.IdCliente.ToString();
            txtIdColaborador.Text = pedido.IdColaborador.ToString();
            txtFormaPagamento.Text = pedido.FormaPagamento.ToString();
            txtTotalBruto.Text = pedido.TotalBruto.ToString();
            txtTotalDesconto.Text = pedido.TotalDeDesconto.ToString();
            txtTotalLiquido.Text = pedido.TotalLiquido.ToString();
        }
    }
}
