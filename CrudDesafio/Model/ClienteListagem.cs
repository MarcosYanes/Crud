using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    public class ClienteListagem
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }
        public double ValorLimite { get; set; }
        public double LimiteRestante { get; set; }

    }
}
