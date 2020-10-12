using Efenex.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Efenex
{
    // Strategy
    interface IBaseModel
    {
        bool Save(Object model);
        Object Find(int id);

        bool Update(int id, Object parametros);
        bool Destroy(int id);
    }
}
