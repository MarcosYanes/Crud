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
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }

        public double Salario { get; set; }
        public string Comissao { get; set; }
        public bool Ativo { get; set; }
    }
}
