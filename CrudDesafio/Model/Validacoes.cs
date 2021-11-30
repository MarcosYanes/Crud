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
        public static bool ValidarNomeProduto(string nome) => new Regex(@"^[a-zA-Z0-9\s]+$").Match(nome).Success;



        public static bool ValidarParaQueSejaNumero(string valor) =>
           new Regex(@"^[0-90.0-9.00,0-9,0\s]+$").Match(valor).Success;

        public static bool ValidarNumeroDoEndereco(string valor) =>
           new Regex(@"^[0-9\s]+$").Match(valor).Success;


        public static bool ValidarConta(string valor) =>
             new Regex(@"^[a-zA-ZÀ-úÀ-ÿ\s]+$").Match(valor).Success;

        public static bool ValidarUf(string valor) =>
             new Regex(@"^[a-zA-Z]{2}$").Match(valor).Success;



        public static bool ValidarCpf(string cpf) => new Regex(@"^[0-9]{3}[.][0-9]{3}[.][0-9]{3}[-][0-9]{2}$").Match(cpf).Success;
       
        public static bool ValidarCep(string cep) => new Regex(@"[0-9]{5}[-][0-9]{3}$").Match(cep).Success;

        public static bool ValidarBusca(string valor) =>
          new Regex(@"^[0-9\s]+$").Match(valor).Success;

        public static bool ValidarNumeroPositivo(string valor) =>
          new Regex(@"^[0-9\s]+$").Match(valor).Success;


        public static bool ValidarDataNascimento(string datanascimento) => new Regex(@"^[0-3][0-9][/][0-1][0-9][/][0-9]{4}$").Match(datanascimento).Success;

        public static bool ValidarEmail(string valor) =>
            new Regex(@"^[a-zA-Z0-9._-]+[@][a-z]+[.]([a-zA-Z]{2,3})+$").Match(valor).Success;
    }
}
