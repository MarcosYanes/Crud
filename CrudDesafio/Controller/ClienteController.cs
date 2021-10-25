﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudDesafio.Model;
using System.Data.SqlClient;
using CrudDesafio.DAO;

namespace CrudDesafio.Controller
{
    class ClienteController
    {
        private ClienteDAO clientedao = new ClienteDAO();
        
        public void Inserir(ClienteModel clientemodel)
        {
            clientedao.Inserir(clientemodel);


        }

        public ClienteModel Buscar (int Id)
        {
           

            return clientedao.Buscar(Id);
        }

        public List<ClienteModel> Listar()
        {
            return clientedao.Listar();
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
