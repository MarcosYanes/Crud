using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public static class Funcoes
    {
        public static  string ObterSomenteNumeros(string valor)
        {
            var valor2 = new string((from c in valor where char.IsDigit(c) select c).ToArray());
            return valor2;

        }
    }
}
