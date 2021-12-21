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
    public partial class EscolherColaborador : Form
    {
        ColaboradorController colaboradorcontroller = new ColaboradorController();
        public ColaboradorModel colaboradormodel = new ColaboradorModel();
        public EscolherColaborador()
        {
            InitializeComponent();
        }

        private void EscolherColaborador_Load(object sender, EventArgs e)
        {
           
                gridColaborador.DataSource = colaboradorcontroller.ListarColaboradoresAtivos();
            
           
        }

        public int SelecionarColaboradorModel()
        {
            var id = Convert.ToInt32(gridColaborador.SelectedRows[0].Cells[0].Value);
            return id;
        }

        private void btnAdicionarColaborador_Click(object sender, EventArgs e)
        {
            var id = SelecionarColaboradorModel();
            colaboradormodel = colaboradorcontroller.Buscar(id);
            //Pedido pedido = new Pedido();

            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.BuscarColaboradoresAtivos(txtBuscar.Text);
        }
    }
}
