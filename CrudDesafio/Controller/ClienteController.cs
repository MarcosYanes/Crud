using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.Model;
using System.Data.SqlClient;
using CrudDesafio.DAO;
using CrudDesafio.View;

namespace CrudDesafio.Controller
{
    public class ClienteController
    {
        private ClienteDAO clientedao = new ClienteDAO();
        
        public void Inserir(ClienteModel clientemodel)
        {
            clientedao.Inserir(clientemodel);


        }


        public ClienteModel Buscar (int IdCliente)
        {          

            return clientedao.Buscar(IdCliente);
        }
       
        public List<ClienteListagem> BuscarLista(string Nome)
        {
            var lista = clientedao.BuscarLista(Nome);
            return lista;
        }
        public List<ClienteListagem> BuscarClientesAtivos(string Nome)
        {
            var lista = clientedao.BuscarClientesAtivos(Nome);
            return lista;
        }

        public List<ClienteListagem> Listar()
        {
            return clientedao.Listar();
        }
        public List<ClienteListagem> ListarClientesAtivos()
        {
            return clientedao.ListarClientesAtivos();
        }

        public void Alterar(ClienteModel clientemodel)
        {
            clientedao.Alterar(clientemodel);
        }

        public void Excluir(ClienteModel clientemodel)
        {
            clientedao.Excluir(clientemodel);
        }

       


    }
}
