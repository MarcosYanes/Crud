using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class ColaboradorListagem 
    {
        public int IdColaborador { get; set; }
        public string NomeColaborador { get; set; }
        public string SexoColaborador { get; set; }
        public DateTime DataNascimentoColaborador { get; set; }
        public string CidadeColaborador { get; set; }

        public double SalarioColaborador { get; set; }
        public string ComissaoColaborador { get; set; }
    }
}
