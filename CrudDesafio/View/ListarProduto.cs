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
    public partial class ListarProduto : Form
    {
        ProdutoController produtocontroller = new ProdutoController();
        ProdutoModel produtomodel = new ProdutoModel();
        public ListarProduto()
        {
            InitializeComponent();
        }

        private void ListarProduto_Load(object sender, EventArgs e)
        {
            gridProduto.DataSource = produtocontroller.Listar();
        }

        private void gridProduto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        public int SelecionarProdutoModel()
        {
            var id = Convert.ToInt32(gridProduto.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarProdutoModel();
            var produto = produtocontroller.Buscar(id);
            AlterarProduto alterarproduto = new AlterarProduto();
            alterarproduto.Show();

            alterarproduto.CarregarDadosParaAlteracao(produto);

            alterarproduto.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridProduto.DataSource = produtocontroller.BuscarLista(txtBuscar.Text);
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            gridProduto.DataSource = produtocontroller.Listar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridProduto.DataSource = produtocontroller.Listar();
        }
    }
}
