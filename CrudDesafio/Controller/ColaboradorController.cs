using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.DAO;
using CrudDesafio.Model;

namespace CrudDesafio.Controller
{
    class ColaboradorController
    {

        private ColaboradorDAO colaboradordao = new ColaboradorDAO();
        

        public void Inserir(ColaboradorModel colaboradormodel)
        {
            colaboradordao.Inserir(colaboradormodel);


        }
       

        public ColaboradorModel Buscar(int IdColaborador)
        {
            return colaboradordao.Buscar(IdColaborador);
        }

        public void Alterar(ColaboradorModel colaboradormodel)
        {
            colaboradordao.Alterar(colaboradormodel);
        }

        public void Excluir(ColaboradorModel colaboradormodel)
        {
            colaboradordao.Excluir(colaboradormodel);
        }

        public List<ColaboradorListagem> Listar()
        {
            return colaboradordao.Listar();
        }

        public List<ColaboradorListagem> BuscarLista(string Nome)
        {
            var lista = colaboradordao.BuscarLista(Nome);
            return lista;
        }


    }
}
