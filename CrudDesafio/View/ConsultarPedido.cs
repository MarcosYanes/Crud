using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class ConsultarPedido : Form
    {
        private PedidoModel _pedido;
        PedidoController pedidoController = new PedidoController();
        ClienteModel clienteModel = new ClienteModel();
        ColaboradorModel colaboradorModel = new ColaboradorModel();


        public ConsultarPedido(PedidoModel pedido)
        {
            InitializeComponent();
           
            _pedido = pedido;
            clienteModel.Nome = _pedido.NomeCliente;
            colaboradorModel.Nome = _pedido.NomeCliente;

            
        }

        private void ConsultarPedido_Load(object sender, EventArgs e)
        {
            VerificarStatusAtivo();
            CarregarDados();
        }

        public int SelecionarPedidoModel()
        {
            var id = Convert.ToInt32(gridPedidos.SelectedRows[0].Cells[0].Value);
            return id;
        }

        public void CarregarDados()
        {
            gridPedidos.DataSource = _pedido.Produtos;
            txtIdPedido.Text = _pedido.IdPedido.ToString();
            txtNomeCliente.Text = _pedido.NomeCliente.ToString();
            txtNomeColaborador.Text = _pedido.NomeColaborador.ToString();
            txtIdCliente.Text = _pedido.IdCliente.ToString();
            txtIdColaborador.Text = _pedido.IdColaborador.ToString();
            txtFormaPagamento.Text = _pedido.FormaPagamento.ToString();
            txtTotalBruto.Text = _pedido.TotalBruto.ToString("c");
            txtTotalDesconto.Text = _pedido.TotalDeDesconto.ToString("c");
            txtTotalLiquido.Text = _pedido.TotalLiquido.ToString("c");
            txtLucro.Text = _pedido.Lucro.ToString("c");
        }

      

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            pedidoController.AbrirFormDePedidoParaAlterar(_pedido);
            this.Close();
        }
        
        public void VerificarStatusAtivo()
        {
            if (!_pedido.Status)
            {
                btnInativar.Visible = false;
                btnAlterar.Visible = false;
            }
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente Inativar o Pedido?", "cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada");

            }
            else
            {
                pedidoController.Inativar(_pedido);
                MessageBox.Show("Pedido Inativo");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
