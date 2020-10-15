using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace Efenex.model.venda
{
    interface IVeiculo
    {
        public void MarcarComoVendido(long id)
        {
            _ = DatabaseConnection.Instance.Execute("UPDATE veiculos SET vendido='S' WHERE Id=@Id", new { Id = id });
        }
    }
}
