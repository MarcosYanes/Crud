using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
   public  class RelatorioClienteModel
    {
        public int IdCliente{ get; set; }
        public string Nome{ get; set; }
        public int IdPedido { get; set; }
        public double TotalBruto { get; set; }
        public double TotalDeDesconto { get; set; }
        public double TotalLiquido { get; set; }
    }
}
