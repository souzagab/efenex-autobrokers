using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex
{
    public class ConcreteVeiculoHatch : VeiculoHatch
    {
        public ConcreteVeiculoHatch(string marca, string modelo, int ano, string versao, string placa, double valor) : base(marca, modelo, ano, versao, placa, valor)
        {

        }
        public override void gravaVeiculo()
        {
            throw new NotImplementedException();
        }
    }
}
