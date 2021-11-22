using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class PedidoProduto
    {
        public int IdPedidoProduto { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public double PrecoDeVenda { get; set; }
        public int Quantidade { get; set; }
        public double  Desconto { get; set; }
        public double  PrecoLiquido { get; set; }
        public double  Total { get; set; }

    }
}
