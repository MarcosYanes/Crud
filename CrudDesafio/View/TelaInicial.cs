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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.ShowDialog();


        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarCliente listarcliente = new ListarCliente();
            listarcliente.ShowDialog();
        }

        private void clienteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarCliente alterarcliente = new AlterarCliente();
            alterarcliente.ShowDialog();        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroColaborador cadastrocolaborador = new CadastroColaborador();
            cadastrocolaborador.ShowDialog();
        }

        private void colaboradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AlterarColaborador alterarcolaborador = new AlterarColaborador();
            alterarcolaborador.ShowDialog();
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListarColaborador listarcolaborador = new ListarColaborador();
            listarcolaborador.ShowDialog();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
