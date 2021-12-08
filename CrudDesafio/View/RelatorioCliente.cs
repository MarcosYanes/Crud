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
    public partial class RelatorioCliente : Form
    {
        PedidoController pedidocontroller = new PedidoController();
        public RelatorioCliente()
        {
            InitializeComponent();
        }

        private void RelatorioCliente_Load(object sender, EventArgs e)
        {

            gridRelatorioClientes.DataSource = pedidocontroller.ListarRelatorioClientes();
            gridRelatorioClientes.Columns["IdPedido"].HeaderText = "Quantidade De Venda";
            gridRelatorioClientes.Columns["TotalBruto"].HeaderText = "Total Bruto";
            gridRelatorioClientes.Columns["TotalLiquido"].HeaderText = "Total Líquido";
            gridRelatorioClientes.Columns["TotalDeDesconto"].HeaderText = "Total De Desconto";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
           
            if (txtTop.Text == "")
            {
                txtTop.Text = "0";
                
            }
            else if (!Validacoes.ValidarNumeroPositivo(txtTop.Text))
            {
                MessageBox.Show("Digite apenas Números Positivos");
                return;
            }
            if(txtMaiorQue.Text == "")
            {
                txtMaiorQue.Text = "0.0";
            }
            else if (!Validacoes.ValidarParaQueSejaNumero(txtMaiorQue.Text))
            {
                MessageBox.Show("Digite apenas Números");
                return;
            }
            gridRelatorioClientes.DataSource = pedidocontroller.FiltrarRelatorioCliente(txtBuscarCliente.Text, dtpDataInical.Value,
                dtpDataFinal.Value, cbOrdenarPor.SelectedIndex, cbCrescente.SelectedIndex, Convert.ToInt32(txtTop.Text), Convert.ToDouble(txtMaiorQue.Text.Replace(",", "."))) ;
                        
        }
    }
}
