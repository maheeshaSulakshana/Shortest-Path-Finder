using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPathFinder
{
    internal class DbConnection
    {
        public MySqlConnection getConnection()
        {
            String con_string = "server=localhost;username=root;password=;database=map";
            MySqlConnection con = new MySqlConnection(con_string);
            return con;
        }
    }
}

