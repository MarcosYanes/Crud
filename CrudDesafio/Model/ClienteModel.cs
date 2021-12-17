using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class ClienteModel : Usuario
    {    


        public int IdCliente { get; set; }
        
        public double ValorLimite { get; set; }
        public double LimiteRestante { get; set; }
        public double ValorLimitePreAlteracao { get; set; }
        public bool Ativo { get; set; }



    }

    
}
