﻿using System.Collections.Generic;
using System.Linq;

namespace CrudDesafio.Model
{
    public class PedidoModel
    {

        public PedidoModel()
        {
            Produtos = new List<CarrinhoProduto>();
        }
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }
        
        public string FormaPagamento { get; set; }
        public double TotalBruto { get => Produtos.Sum(x => x.Total); }
        public double TotalDeDesconto { get => Produtos.Sum(x => x.Desconto); }
        //public double TotalDesconto {
        //    get => Produtos.Sum(x => x.Desconto)
        //        ; 
        //}
        public double TotalLiquido { get => Produtos.Sum(x=>x.PrecoLiquido); }

        public List<CarrinhoProduto> Produtos { get; set; }

        public void AdicionarProduto(CarrinhoProduto carrinhoproduto)
        {
            Produtos.Add(carrinhoproduto);
        }
    }
}
