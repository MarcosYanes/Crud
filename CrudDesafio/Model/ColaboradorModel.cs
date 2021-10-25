using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudDesafio.Model
{
    class ColaboradorModel
    {
        public int IdColaborador { get; set; }
        public string NomeColaborador { get; set; }
        public string  SexoColaborador { get; set; }
        public string DataNascimentoColaborador { get; set; }
        public double SalarioColaborador { get; set; }
        public string ComissaoColaborador { get; set; }
        public string LogradouroColaborador { get; set; }

        public string CpfColaborador { get; set; }
        public string CidadeColaborador  { get; set; }
        public string CepColaborador { get; set; }
       
        public string BairroColaborador { get; set; }
        public string NumeroColaborador { get; set; }
        public string UfColaborador { get; set; }
        public string ComplementoColaborador { get; set; }
        public string TelefoneColaborador { get; set; }
        public string CelularColaborador { get; set; }
        public string EmailColaborador { get; set; }
        public string Banco { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }
        public string TipoConta { get; set; }


    }
}
