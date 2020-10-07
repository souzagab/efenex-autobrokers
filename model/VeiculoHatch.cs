using Efenex.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex
{
    public abstract class VeiculoHatch :Veiculo
    {
        public VeiculoHatch(string marca, string modelo, DateTime ano, string versao, string placa, double valor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.Ano = ano;
            this.versao = versao;
            this.placa = placa;
            this.valor = valor;
        }

        public abstract void gravaVeiculo();
    }
}
