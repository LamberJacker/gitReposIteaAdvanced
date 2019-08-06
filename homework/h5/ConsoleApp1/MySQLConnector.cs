using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MySQLConnector
    {
        public static MySqlConnection getConnection(string host, int port ,string db, string username, string password)
        {
            String config = "Server=" + host + ";Database="  + db + ";port=" 
                + port + ";USer id=" + username + ";Password=" + password;
            MySqlConnection connect = new MySqlConnection(config);
            return connect;
        }
    }
}
