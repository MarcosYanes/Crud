using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public string FormaPagamento { get; set; }
        public double TotalBruto { get; set; }
        public double TotalDesconto { get; set; }
        public double TotalLiquido { get; set; }
    }
}
