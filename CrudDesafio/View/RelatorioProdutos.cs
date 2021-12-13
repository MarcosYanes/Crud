﻿using CrudDesafio.Controller;
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
       private  RelatorioVendasModel _relatorioVenda = new RelatorioVendasModel();
        CarrinhoProduto produtos = new CarrinhoProduto();
        public RelatorioProdutos()
        {
            InitializeComponent();
            
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RelatorioProdutos_Load(object sender, EventArgs e)
        {
            gridRelatorioProdutos.DataSource = pedidocontroller.ListarRelatorioVendas();
            
        }

        private void CarregarDados(PedidoModel pedido)
        {
            
            txtQuantidade.Text = _relatorioVenda.TotalizadorQuantidade.ToString();
        }

        private void btnBuscarPorProduto_Click_1(object sender, EventArgs e)
        {
            gridRelatorioProdutos.DataSource = pedidocontroller.BuscarRelatorio(txtBuscarPorProduto.Text, txtBuscaPorCliente.Text, dtpDataInicial.Value, dtpDataFinal.Value);
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            gridRelatorioProdutos.DataSource = pedidocontroller.ListarRelatorioVendas();
        }

       
    }
}
