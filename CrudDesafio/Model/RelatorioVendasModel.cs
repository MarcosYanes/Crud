using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
   public  class RelatorioVendasModel
    {
        //public RelatorioVendasModel()
        //{
        //    Pedido = new PedidoModel();
        //}

       
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public double Total { get; set; }//TotalBruto
        public double Desconto { get; set; }
        public double PrecoLiquido { get; set; }//TotalLiquido
        public double PrecoDeCusto { get; set; }
        public double Lucro { get; set; }
        public double LucroEmPorcentagem { get => (PrecoLiquido - PrecoDeCusto) / PrecoDeCusto * 100; }
        //public PedidoModel Pedido { get; set; }
        //public int TotalizadorQuantidade { get => Pedido.Produtos.Sum(x => x.Quantidade); }





    }
}
