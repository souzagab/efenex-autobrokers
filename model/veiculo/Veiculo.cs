using Efenex.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex
{
    public class Veiculo:BaseModel
    {
        public string marca { get; set; }

        public string modelo { get; set; }

        public DateTime Ano { get; set; }

        public string versao { get; set; }

        public string placa { get; set; }

        public double valor { get; set; }

    }
}
