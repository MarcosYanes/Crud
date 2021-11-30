using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class NotaFiscalModel
    {
        public int IdPedido { get; set; }
        public string NomeCliente { get; set; }
        public string NomeColaborador { get; set; }
        public string FormaPagamento { get; set; }
        public double TotalBruto { get; set; }
        public double TotalDeDesconto { get; set; }
        public double TotalLiquido { get; set; }
        

    }
}
