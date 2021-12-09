using CrudDesafio.Controller;
using CrudDesafio.DAO;
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
    public partial class RelatorioCliente : Form
    {
        PedidoController pedidocontroller = new PedidoController();
        FiltrosRelatorio filtro = new FiltrosRelatorio();
        public RelatorioCliente()
        {
            InitializeComponent();
        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {
            cbOperador.SelectedIndex = 0;
            cbOrdenarPor.SelectedIndex = 0;
            cbCrescente.SelectedIndex = 0;
            cbOrdenarMaiorQue.SelectedIndex = 0;
            gridRelatorioClientes.DataSource = pedidocontroller.ListarRelatorioClientes();
            gridRelatorioClientes.Columns["IdPedido"].HeaderText = "Quantidade De Venda";
            gridRelatorioClientes.Columns["TotalBruto"].HeaderText = "Total Bruto";
            gridRelatorioClientes.Columns["TotalLiquido"].HeaderText = "Total Líquido";
            gridRelatorioClientes.Columns["TotalDeDesconto"].HeaderText = "Total De Desconto";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ValidarTextBox();
           
            if (Validar() == false)
            {
                return;
            }           
         
            filtro.OrdenarMaiorQue = cbOrdenarMaiorQue.SelectedIndex;
            filtro.Operador = cbOperador.SelectedIndex;
            filtro.OrdenarPor = cbOrdenarPor.SelectedIndex;
            gridRelatorioClientes.DataSource = pedidocontroller.FiltrarRelatorioCliente(txtBuscarCliente.Text, dtpDataInical.Value,
                dtpDataFinal.Value,  cbCrescente.SelectedIndex, Convert.ToInt32(txtTop.Text), Convert.ToDouble(txtMaiorQue.Text.Replace(",", ".")), filtro) ;
                        
        }
        public void ValidarTextBox()
        {
            if (txtTop.Text == "")
            {
                txtTop.Text = "0";

            }

            if (txtMaiorQue.Text == "")
            {
                txtMaiorQue.Text = "0.0";
            }
        }

        public bool Validar()
        {
           
            if (!Validacoes.ValidarNumeroPositivo(txtTop.Text))
            {
                MessageBox.Show("Digite Apenas Números Positivos");
                return false;
            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtMaiorQue.Text))
            {
                MessageBox.Show("Digite Apenas Números Positivos ");
                return false;
            }
            return true;

        }
    }
}
