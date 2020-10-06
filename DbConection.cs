using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Efenex
{
    class DbConection
    {
        private static string connectionString = "Data Source=MSSQLLocalDB";
        private static DbConection singleton;
        private static SqlConnection sqlConnection;

        public SqlConnection SqlConnetionFactory
        {
            get { return sqlConnection; }
        }

        private DbConection() { }

        public static DbConection Singleton
        {
            get
            {
                if (singleton == null)
                    singleton = new DbConection();

                sqlConnection = new SqlConnection(connectionString);
                return singleton;
            }
        }
    }
}
