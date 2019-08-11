﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace lasthomework
{
    class DBWorker
    {
        static string host = "127.0.0.1";
        static int port = 3306;
        static string db = "itea";
        static string username = "root";
        static string password = "";

        public static MySqlConnection getMySqlConnection() //method for connet to database 
        {
            return MySQLConnector.getConnection(host, port, db, username, password);
        }
    }
}
