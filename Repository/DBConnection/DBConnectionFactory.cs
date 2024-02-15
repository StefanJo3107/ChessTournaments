using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace Repository
{

    public class DBConnectionFactory
    {
        private static DBConnectionFactory instance;
        private DBConnection connection = new DBConnection();

        public static DBConnectionFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnectionFactory();
                }
                return instance;
            }
        }
        private DBConnectionFactory()
        {

        }

        public DBConnection GetDBConnection()
        {
            if (!connection.IsReady())
            {
                connection.OpenConnection();
            }
            return connection;
        }



    }
}
