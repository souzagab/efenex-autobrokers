using System;
using System.Collections.Generic;
using System.Text;

namespace Efenex.controller
{
    // Strategy 
    interface IBaseController
    {
        public List<Object> Index();

        public bool Create();
        public Object Show(int id);
        public bool Update(int id, Object parametros);

        public bool Delete(int id);

    }
}
