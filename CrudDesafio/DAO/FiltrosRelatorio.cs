using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.DAO
{
    public class FiltrosRelatorio
    {
        //public double MaiorQue { get; set; }
        public int OrdenarMaiorQue { get; set; }
        public int Operador { get; set; }
        public int OrdenarPor { get; set; }

        public string Operadores()
        {
            if (Operador == 0)
            {
                return " >";

            }
            
                return " <";
            

        }
        public string Filtragem()
        {
            if (OrdenarMaiorQue == 0)
            {
                return "having Count(pp.IdPedido)";
            }
            if (OrdenarMaiorQue == 1)
            {
                return "having SUM(p.TotalBruto)";
            }
            if (OrdenarMaiorQue == 2)
            {
                return "having SUM(p.TotalDeDesconto)";
            }


            return "having SUM(p.TotalLiquido)";


        }

        public string FiltragemParaOrdenar()
        {
            if(OrdenarPor == 0)
            {
                return "order by Count(pp.IdPedido)";
            }
            if(OrdenarPor == 1)
            {
                return "order by SUM(p.TotalBruto)";
            }
            if (OrdenarPor == 2)
            {
                return "order by SUM(p.TotalDeDesconto)";
            }

            return "order by SUM(p.TotalLiquido)";
        }

    }
}
