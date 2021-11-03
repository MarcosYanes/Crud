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
using CrudDesafio.Controller;
using CrudDesafio.DAO;

namespace CrudDesafio.View
{
    public partial class ExibirInformacao : Form
    {
        ClienteController clientecontroller = new ClienteController();
        ClienteModel clientemodel = new ClienteModel();
        public ExibirInformacao()
        {
            InitializeComponent();
        }

        private void ExibirInformacao_Load(object sender, EventArgs e)
        {
            
        }
    }
}
