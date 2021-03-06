using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.ValueObject;

namespace CrudDesafio.Model
{
    public  class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public CPF Cpf { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public bool ValidarDataAniversario()
        {
            return DataNascimento.Day.Equals(DateTime.Today.Day) && DataNascimento.Month.Equals(DateTime.Today.Month);
        }
    }

   

   

}
