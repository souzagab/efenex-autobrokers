using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efenex.controller
{
    class ClientesController : BaseController
    {
        public List<Cliente> Index
        {
            get 
            {
                IEnumerable<Cliente> clientes = Connection.Query<Cliente>("SELECT * FROM clientes");
                return clientes.ToList();
            }
        }

        public object Show(int id)
        {

            Cliente cliente = new Cliente();
            return cliente.Find(id);
 
        }

        public bool Create(Cliente parametros)
        {
            Cliente cliente = new Cliente { Nome= parametros.Nome, Cpf= parametros.Cpf, Rg = parametros.Rg, DataNascimento= parametros.DataNascimento };
            return cliente.Save();
        }
        public bool Update(int id, Cliente parametros)
        {
            Cliente cliente = new Cliente { Id= id, Nome = parametros.Nome, Cpf = parametros.Cpf, Rg = parametros.Rg, DataNascimento = parametros.DataNascimento };
            var query = Connection.Execute("UPDATE clientes SET Nome=@Nome, Cpf=@Cpf, Rg=@Rg, DataNascimento=@DataNascimento WHERE Id=@Id", cliente);
            return query == 1;
        }
        public bool Delete(int id)
        {
            Cliente cliente = new Cliente();
            return cliente.Destroy(id);
        }
    }
}
