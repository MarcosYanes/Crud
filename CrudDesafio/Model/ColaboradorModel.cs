using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class ColaboradorModel : Usuario
    {
        public int IdColaborador { get; set; }
       
        public double Salario { get; set; }
        public string Comissao { get; set; }
        
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string TipoConta { get; set; }


    }
}
