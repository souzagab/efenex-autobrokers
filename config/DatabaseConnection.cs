using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;
using System.Data;

namespace Efenex
{
    public sealed class DatabaseConnection
    {
        private static IDbConnection instance = null;

        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        private DatabaseConnection() { }

        public static IDbConnection Instance
        {
            get
            {
                try
                {
                    if (instance == null)
                    {
                        instance = new SQLiteConnection(ConnectionString);
                        instance.Open();

                    }
                    if (instance.State == ConnectionState.Closed) { instance.Open(); }
                    return instance;
                }
                catch (ObjectDisposedException)
                {
                    // Workaround: Garbage Collector apaga a instancia do objeto.
                    instance = new SQLiteConnection(ConnectionString);
                    instance.Open();
                    return instance;
                }
            }
        }

    }
}
