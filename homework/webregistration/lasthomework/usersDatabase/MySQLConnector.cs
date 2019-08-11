﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lasthomework
{
    class MySQLConnector
    {
        public static MySqlConnection getConnection(string host, int port, string db, string username, string password)
        {
            String config = "Server=" + host + ";Database=" + db + ";port="
                + port + ";USer id=" + username + ";Password=" + password;
            MySqlConnection connect = new MySqlConnection(config);
            return connect;
        }
    }
}
