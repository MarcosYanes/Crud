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
    public partial class EscolherProduto : Form
    {
        ProdutoController produtocontroller = new ProdutoController();
        public ProdutoModel produtomodel = new ProdutoModel();
        //public List<Carrinho> carrinho = new List<Carrinho>();
        
        public EscolherProduto()
        {
            InitializeComponent();
        }

        private void EscolherProduto_Load(object sender, EventArgs e)
        {
            GridProduto.DataSource = produtocontroller.ListarAtivos();
        }

        public int SelecionarProdutoModel()
        {
            var id = Convert.ToInt32(GridProduto.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void GridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            var id = SelecionarProdutoModel();
            produtomodel = produtocontroller.Buscar(id);
            //Pedido pedido = new Pedido();

            
            this.Close();

            //pedido.Show();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            var id = SelecionarProdutoModel();
            produtomodel = produtocontroller.Buscar(id);
            //Pedido pedido = new Pedido();

            //this.Dispose();
            this.Close();


        }
    }
}
