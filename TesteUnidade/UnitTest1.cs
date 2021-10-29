using CrudDesafio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteUnidade
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("dsdgh", true)]
        [DataRow("ffasd0", false)]
        [DataRow("5555", false)]
        public void Teste_se_nome_nao_possui_numeros_deve_retornar_true(string texto, bool esperado)
        {
            Assert.AreEqual(Validacoes.ValidarNome(texto), esperado);
        }

        [TestMethod]
        public void Teste_se_valorLimite_e_maior_que_0()
        {
            var valor = 20;
            
            
            var resultado = Validacoes.ValidarValorLimite(valor);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Teste_se_cpf_e_valido()
        {
            var cpf = "333.333.333-12";


            var resultado = Validacoes.ValidarCpf(cpf);
            Assert.IsTrue(resultado);
        }


        [DataTestMethod]
        [DataRow("15704-104", true)]
        [DataRow("11", false)]
        [DataRow("11111.100", false)]
        [TestMethod]
        public void Teste_se_cep_e_valido(string texto, bool esperado)
        {
            


            
           Assert.AreEqual(Validacoes.ValidarCep(texto), esperado);
        }

        //[DataTestMethod]
        //[DataRow(new DateTime(2001, 05, 06), false)]
        //public void Teste_se_data_nascimento_e_valida()
        //{
        //    var data = "10/09/1999";


        //    var resultado = Validacoes.ValidarDataNascimento(data);
        //    Assert.IsTrue(resultado);
        //}


    }
}
