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
using Microsoft.Office.Interop.Excel;

namespace CrudDesafio.View
{

    public partial class RelatorioProdutos : Form
    {
        PedidoController pedidocontroller = new PedidoController();
        private List<RelatorioVendasModel> _relatorioVenda;
        PedidoModel pedidomodel = new PedidoModel();
        ClienteModel clientemodel = new ClienteModel();
        ProdutoModel produtomodel = new ProdutoModel();
        public RelatorioProdutos()
        {
            InitializeComponent();

        }
        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {

        }
        private void CalcularRelatorioProdutos()
        {
            txtQuantidade.Text = _relatorioVenda.Sum(x => x.Quantidade).ToString();
            txtTotalBruto.Text = _relatorioVenda.Sum(x => x.Total).ToString("c");
            txtDesconto.Text = _relatorioVenda.Sum(x => x.Desconto).ToString("c");
            txtPrecoDeCusto.Text = _relatorioVenda.Sum(x => x.PrecoDeCusto).ToString("c");
            txtPrecoLiquido.Text = _relatorioVenda.Sum(x => x.PrecoLiquido).ToString("c");
            txtLucro.Text = _relatorioVenda.Sum(x => x.Lucro).ToString("c");
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
        private void btnProcurarProduto_Click(object sender, EventArgs e)
        {
            EscolherProduto escolherproduto = new EscolherProduto();
            escolherproduto.ShowDialog();
            produtomodel = escolherproduto.produtomodel;
            CarregarProduto();
        }
        public void CarregarProduto()
        {
            txtBuscarPorProduto.Text = produtomodel.NomeProduto;
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarExcel(gridRelatorioProdutos);
        }
        public void ExportarExcel(DataGridView tabela)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColuna = 0;
            foreach (DataGridViewColumn col in tabela.Columns)
            {
                IndiceColuna++;
                excel.Cells[1, IndiceColuna] = col.Name;
            }
            int IndiceFila = 0;
            foreach (DataGridViewRow row in tabela.Rows)
            {
                IndiceFila++;
                IndiceColuna = 0;
                foreach (DataGridViewColumn col in tabela.Columns)
                {
                    IndiceColuna++;
                    excel.Cells[IndiceFila + 1, IndiceColuna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
    }
}
