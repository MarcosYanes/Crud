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

    public partial class RelatorioProdutos : Form
    {
        PedidoController pedidocontroller = new PedidoController();
        private List<RelatorioVendasModel> _relatorioVenda;
        PedidoModel pedidomodel = new PedidoModel();
        ClienteModel clientemodel = new ClienteModel();
        public RelatorioProdutos()
        {
            InitializeComponent();           
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {         
           
        }
        private void CalcularRelatorioProdutos()
        {            
            txtQuantidade.Text = _relatorioVenda.Sum(x => x.Quantidade).ToString();
        }      

        private void btnBuscarPorProduto_Click_1(object sender, EventArgs e)
        {
            _relatorioVenda = pedidocontroller.BuscarRelatorio(txtBuscarPorProduto.Text, txtBuscaPorCliente.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            gridRelatorioProdutos.DataSource = _relatorioVenda;
            CalcularRelatorioProdutos();
        }     

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            EscolherCliente escolhercliente = new EscolherCliente();
            escolhercliente.ShowDialog();
            clientemodel = escolhercliente.clientemodel;
            CarregarCliente();
        }

        public void CarregarCliente()
        {
            txtBuscaPorCliente.Text = clientemodel.Nome;
        }
    }
}
