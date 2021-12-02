using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudDesafio.Model
{
    public class PedidoModel
    {

        public PedidoModel()
        {
            Produtos = new List<CarrinhoProduto>();
            Cliente = new ClienteModel();
        }
       
        
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador { get; set; }

        public string FormaPagamento { get; set; }
        public double TotalBruto { get => Produtos.Sum(x => x.Total); }
        public double TotalDeDesconto { get => Produtos.Sum(x => x.Desconto); }
        //public double TotalDesconto {
        //    get => Produtos.Sum(x => x.Desconto)
        //        ; 
        //}
        public double TotalLiquido { get => Produtos.Sum(x=>x.PrecoLiquido); }
        public double Lucro { get => Produtos.Sum(x => x.Lucro); }
        public bool Status { get; set; }
        public DateTime DataInicial { get; set; }
        public ClienteModel Cliente { get; set; }

        public List<CarrinhoProduto> Produtos { get; set; }

        public void AdicionarProduto(CarrinhoProduto carrinhoproduto)
        {
            Produtos.Add(carrinhoproduto);
        }
    }
}
