using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    class ColaboradorModel : Usuario
    {
        public int IdColaborador { get; set; }
       
        public double SalarioColaborador { get; set; }
        public string ComissaoColaborador { get; set; }
        
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string TipoConta { get; set; }


    }
}
