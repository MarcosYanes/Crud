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
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.BuscarLista(txtBuscar.Text);            
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
        }        
        public int SelecionarColaboradorModel()
        {
            var id = Convert.ToInt32(gridColaborador.SelectedRows[0].Cells[0].Value);
            return id;
        }      
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            gridColaborador.DataSource = colaboradorcontroller.Listar();
        }

        private void gridColaborador_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = SelecionarColaboradorModel();
            var colaborador = colaboradorcontroller.Buscar(id);
            AlterarColaborador alterarcolaborador = new AlterarColaborador();
            alterarcolaborador.Show();

            alterarcolaborador.CarregarDadosParaAlteracao(colaborador);

            alterarcolaborador.Show();
        }
    }
}
