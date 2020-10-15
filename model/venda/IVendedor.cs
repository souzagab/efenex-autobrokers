using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Efenex.model.venda
{
    interface IVendedor
    {
        public void RealizarVenda()
        {
            MessageBox.Show("Venda Realizada!");
        }
    }
}
