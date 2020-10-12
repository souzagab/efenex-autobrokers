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
        Object Find(long id);

        bool Update(long id, Object parametros);
        bool Destroy(long id);
    }
}
