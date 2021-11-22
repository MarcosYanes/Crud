using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
   public  class ProdutoModel
    {
        public int IdProduto { get; set; }
        public string  CodigoDeBarra { get; set; }
        public string NomeProduto { get; set; }
        public double PrecoDeVenda { get; set; }
        public double PrecoDeCusto { get; set; }
        public int Estoque { get; set; }
        public bool Ativo { get; set; }
        public string Fabricante { get; set; }
    }
}
