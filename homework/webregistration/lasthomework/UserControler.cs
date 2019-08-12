using System;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace lasthomework
{
    public class UserControler
    {
        public Boolean Login(string login, string password)
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();
            string squery = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(squery, connect);
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int loginO = reader.GetOrdinal("login");
                        int passwordO = reader.GetOrdinal("password");
                        string templogin = reader.GetString(loginO);
                        string temppassword = reader.GetString(passwordO);
                        //temppassword -= "14qa15sd16df";
                        command.Dispose();
                        if (login.Equals(templogin) & password.Equals(temppassword)) return true;
                    }
                }
                command.Dispose();
                return false;
            }
        }
        public Boolean AddUser(string login, string password, string repassword, string name, string address, string age, string sex)
        {
            bool intage = Int32.TryParse(age, out int resultage);
            if (!intage) return false;

            if (name != null & login != null & password != null & password.Equals(repassword) & address != null & resultage > 0 & sex != null)
            {
                MySqlConnection connect = DBWorker.getMySqlConnection();
                connect.Open();
                //password += "+14qa15sd16df";
                String query = "INSERT INTO users (login, password, name, address, age, sex) VALUES (@login, @password, @name," +
                    "@address, @age, @sex)";
                MySqlCommand command = new MySqlCommand(query, connect);

                command.Parameters.Add(new MySqlParameter("@name", name));
                command.Parameters.Add(new MySqlParameter("@login", login));
                command.Parameters.Add(new MySqlParameter("@password", password));
                command.Parameters.Add(new MySqlParameter("@address", address));
                command.Parameters.Add(new MySqlParameter("@age", resultage));
                command.Parameters.Add(new MySqlParameter("@sex", sex));
                command.ExecuteNonQuery();
                command.Dispose();
                connect.Close();
                return true;

            }
            else return false;
        }
        public Boolean EditUser(string login, string password, string name, string address, string age)
        {
            if (!age.Equals(""))
            {
                Boolean intage = Int32.TryParse(age, out int resultage);
                if (!intage || resultage > 0 || resultage < 110) return false;
                else
                {
                    MySqlConnection connect = DBWorker.getMySqlConnection();
                    connect.Open();
                    string query = "UPDATE users SET age = @age WHERE login = @login";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.Add(new MySqlParameter("@age", age));
                    command.Parameters.Add(new MySqlParameter("@login", login));
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }

            if (name.Equals("") || login.Equals("")  || password.Equals("") || address.Equals(""))
            { 
                MySqlConnection connect = DBWorker.getMySqlConnection();
                connect.Open();
                if (!name.Equals(""))
                {
                    string query = "UPDATE users SET name = @name WHERE login = @login";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.Add(new MySqlParameter("@name", name));
                    command.Parameters.Add(new MySqlParameter("@login", login));
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                if (!password.Equals(""))
                {
                    string query = "UPDATE users SET password = @password WHERE login = @login";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.Add(new MySqlParameter("@password", password));
                    command.Parameters.Add(new MySqlParameter("@login", login));
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                if (!address.Equals(""))
                {
                    string query = "UPDATE users SET address = @address WHERE login = @login";
                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.Add(new MySqlParameter("@address", address));
                    command.Parameters.Add(new MySqlParameter("@login", login));
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
                connect.Close();
                return true;
            }
            else return false;
        }
    }
}
