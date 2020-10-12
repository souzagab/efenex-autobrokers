using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Efenex.controller
{
    class BaseController : IBaseController
    {
        protected IDbConnection Connection = DatabaseConnection.Instance;



        public List<object> Index()
        {
            throw new NotImplementedException();
        }

        public object Show(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create()
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, object parametros)
        {
            throw new NotImplementedException();
        }
    }
}
