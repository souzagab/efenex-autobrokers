using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex
{
    public class ConcreteVeiculoSuv : VeiculoSuv
    {
        public ConcreteVeiculoSuv(string marca, string modelo, DateTime ano, string versao, string placa, double valor) : base(marca, modelo, ano, versao, placa, valor)
        {

        }
        public override void gravaVeiculo()
        {
            throw new NotImplementedException();
        }
    }
}
