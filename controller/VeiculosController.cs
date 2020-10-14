﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efenex.controller
{
    public class VeiculosController: BaseController
    {
        public List<Veiculo> Index
        {
            get
            {
                IEnumerable<Veiculo> veiculos = Connection.Query<Veiculo>("SELECT * FROM veiculos");
                return veiculos.ToList();

            }
        }

        public object Show(int id)
        {

            Veiculo veiculo = new Veiculo();
            return veiculo.Find(id);

        }

        public bool Create(Veiculo parametros)
        {
            Veiculo veiculo = new Veiculo { Marca = parametros.Marca, Ano = parametros.Ano, Modelo = parametros.Modelo, Placa = parametros.Placa, Tipo = parametros.Tipo};
            return veiculo.Save();
        }
    
       public bool Update(long id, Veiculo parametros)
        {
            Veiculo veiculo = new Veiculo { Id = id, Marca = parametros.Marca, Ano = parametros.Ano, Modelo = parametros.Modelo, Placa = parametros.Placa, Tipo = parametros.Tipo };
            var query = Connection.Execute("UPDATE veiculos SET Marca=@Marca, Ano=@Ano, Modelo=@Modelo, Placa=@Placa, Tipo=@Tipo WHERE Id=@Id", veiculo);
            return query == 1;
        }

        public bool Delete(long id)
        {
            Veiculo veiculo = new Veiculo();
            return veiculo.Destroy(id);
        }

    }
}
