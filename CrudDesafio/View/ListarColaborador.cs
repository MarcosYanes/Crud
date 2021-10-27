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

namespace CrudDesafio.View
{
    public partial class ListarColaborador : Form
    {

        ColaboradorController colaboradorcontroller = new ColaboradorController();
        ColaboradorModel colaboradormodel = new ColaboradorModel();
        public ListarColaborador()
        {
            InitializeComponent();
        }

        private void ListarColaborador_Load(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
            gridColaborador.Columns["SalarioColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["ComissaoColaborador"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Banco"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Agencia"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["Conta"].DisplayIndex = gridColaborador.Columns.Count - 1;
            gridColaborador.Columns["TipoConta"].DisplayIndex = gridColaborador.Columns.Count - 1;
        }
    }
}
