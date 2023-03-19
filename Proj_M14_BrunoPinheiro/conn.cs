using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proj_M14_BrunoPinheiro
{
    internal class conn
    {
        private static readonly string connectionString = "server=localhost;userid=root;database=clube_desportivo_brunopinheiro;password=";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
