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
    public partial class EscolherCliente : Form
    {

        ClienteController clientecontroller = new ClienteController();
        public ClienteModel clientemodel = new ClienteModel();
        public EscolherCliente()
        {
            InitializeComponent();
        }

        private void EscolherCliente_Load(object sender, EventArgs e)
        {
            gridCliente.DataSource = clientecontroller.Listar();
        }

        private void txtAdicionar_Click(object sender, EventArgs e)
        {
            var id = SelecionarClienteModel();
            clientemodel = clientecontroller.Buscar(id);
            //Pedido pedido = new Pedido();

            this.Close();
        }

        public int SelecionarClienteModel()
        {
            var id = Convert.ToInt32(gridCliente.SelectedRows[0].Cells[0].Value);
            return id;
        }
    }
}
