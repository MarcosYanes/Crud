using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.ValueObject
{
   public  class CPF
    {
        private string _cpf;

        public CPF(string input)
        {
            _cpf = input;
        }

        public string CpfFormatado
        {
            get => Convert.ToInt32(_cpf).ToString(@"000.000.000-00");
        }

        public  string ObterSomenteNumeros()
        {
            string valor = _cpf;
            valor = new string((from c in valor where char.IsDigit(c) select c).ToArray());
            return valor;

        }


        public string RetornarCpf { get => _cpf; }
        public static implicit operator CPF(string input) => new CPF(input);

        public override string ToString()
        {
            return _cpf;
        }
    }
}

