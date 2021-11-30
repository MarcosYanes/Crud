using CrudDesafio.Controller;
using CrudDesafio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudDesafio.View
{
    public partial class ListarPedido : Form
    {

        PedidoController pedidocontroller = new PedidoController();
        PedidoModel pedidomodel = new PedidoModel();
        public ListarPedido()
        {
            InitializeComponent();
        }

        private void ListarPedido_Load(object sender, EventArgs e)
        {
            gridPedidos.DataSource = pedidocontroller.Listar();
        }

        private void gridPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //var id = SelecionarPedidoModel();
            //var cliente = pedidocontroller.Buscar(id);
            //AlterarCliente alterarcliente = new AlterarCliente();
            //alterarcliente.Show();

            //alterarcliente.CarregarDadosParaAlteracao(cliente);

            //alterarcliente.Show();
        }

        public int SelecionarPedidoModel()
        {
            var id = Convert.ToInt32(gridPedidos.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void txtConsultar_Click(object sender, EventArgs e)
        {
            var id = SelecionarPedidoModel();
            var pedido = pedidocontroller.Buscar(id);
            ConsultarPedido consultarpedido = new ConsultarPedido(pedido);
            consultarpedido.Show();         

            //this.Dispose();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridPedidos.DataSource = pedidocontroller.BuscarLista(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridPedidos.DataSource = pedidocontroller.Listar();
        }
    }
}
