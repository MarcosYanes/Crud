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
using System.Configuration;
using CrudDesafio.View;
using CrudDesafio.DAO;



namespace CrudDesafio.View
{
    public partial class ListarCliente : Form
    {

        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();
        //private ClienteDAO clientedao = new ClienteDAO();
        public ListarCliente()
        {
            InitializeComponent();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
            //gridClientes.Columns["ValorLimite"].DisplayIndex = gridClientes.Columns.Count-1;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.BuscarLista(txtBuscar.Text);
            
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
        }



      

        private void gridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarClienteModel();
            var cliente = clientecontroller.Buscar(id);
            AlterarCliente alterarcliente = new AlterarCliente();
            alterarcliente.Show();

           alterarcliente.obterDadosPara(cliente);

            alterarcliente.Show();



        }

        public int SelecionarClienteModel()
        {
            var id = Convert.ToInt32(gridClientes.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridClientes.DataSource = clientecontroller.Listar();
        }
    }
}
