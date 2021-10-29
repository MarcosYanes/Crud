using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CrudDesafio.View;

namespace CrudDesafio.Model
{
    public static class Validacoes
    {

        public static bool ValidarNome(string nome) => new Regex(@"^[a-zA-Z\s]+$").Match(nome).Success;

        public static bool ValidarValorLimite(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            return true;
        }

        public static bool ValidarCpf(string cpf) => new Regex(@"^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(cpf).Success;
        public static bool ValidarCep(string cep) => new Regex(@"[0-9]{5}[-][0-9]{3}$").Match(cep).Success;

        //public static bool ValidarDataNascimento(string datanascimento) => new Regex(@"^[0-3][0-9][/][0-1][0-9][/][0-9]{4}$").Match(datanascimento).Success;
    }
}
