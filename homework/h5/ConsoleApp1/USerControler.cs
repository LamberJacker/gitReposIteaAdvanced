using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;


namespace ConsoleApp1
{
    class UserControler
    {
        public User GetUser(int idUser) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();
            User user = new User();
            string query = "SELECT * FROM users WHERE id=" + idUser;
            MySqlCommand command = new MySqlCommand();
            command.Connection = connect;
            command.CommandText = query;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idO = reader.GetOrdinal("id");
                        int nameO = reader.GetOrdinal("name");
                        int loginO = reader.GetOrdinal("login");
                        int passwordO = reader.GetOrdinal("password");
                        int addressO = reader.GetOrdinal("address");
                        int ageO = reader.GetOrdinal("age");

                        long id = Convert.ToInt64(reader.GetValue(idO));
                        string name = reader.GetString(nameO);
                        string login = reader.GetString(loginO);
                        string password = reader.GetString(passwordO);
                        string address = reader.GetString(addressO);
                        long age = Convert.ToInt64(reader.GetValue(ageO));

                        user.id = id;
                        user.name = name;
                        user.login = login;
                        user.password = password;
                        user.address = address;
                        user.age = age;
                    }
                }
            }
            connect.Close();
            return user;
        }
        public List<User> GetAllUser() 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();

            string query = "SELECT * FROM users";

            MySqlCommand command = new MySqlCommand(query, connect);

            List<User> userCol = new List<User>(); // collection for my users
            using (DbDataReader reader = command.ExecuteReader()) 
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idO = reader.GetOrdinal("id");
                        int nameO = reader.GetOrdinal("name");
                        int loginO = reader.GetOrdinal("login");
                        int passwordO = reader.GetOrdinal("password");
                        int addressO = reader.GetOrdinal("address");
                        int ageO = reader.GetOrdinal("age");

                        long id = Convert.ToInt64(reader.GetValue(idO));
                        string name = reader.GetString(nameO);
                        string login = reader.GetString(loginO);
                        string password = reader.GetString(passwordO);
                        string address = reader.GetString(addressO);
                        long age = Convert.ToInt64(reader.GetValue(ageO));

                        User tempUser = new User(); // temp user
                        tempUser.id = id;
                        tempUser.name = name;
                        tempUser.login = login;
                        tempUser.password = password;
                        tempUser.address = address;
                        tempUser.age = age;

                        userCol.Add(tempUser);
                    }
                }
            }
            connect.Close();
            return userCol;
        }
        public void DeleteUser(int idUser) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();
            string query = "DELETE FROM users WHERE id = " + idUser + ";";
            MySqlCommand command = new MySqlCommand(query, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void AddUser(string name, string login, string password, string address, int age) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();

            string query = "INSERT INTO users (name, login, password, address, age) VALUES (@name, @login, @password," +
                "@address, @age)";

            MySqlCommand command = new MySqlCommand(query, connect);
            command.Parameters.Add(new MySqlParameter("@name", name));
            command.Parameters.Add(new MySqlParameter("@login",login));
            command.Parameters.Add(new MySqlParameter("@password", password));
            command.Parameters.Add(new MySqlParameter("@address", address));
            command.Parameters.Add(new MySqlParameter("@age", age));
            command.ExecuteNonQuery();
            connect.Close();
        }
        public void AddNewOrderToUser(int user_id, string nameOrder, int modelOrder) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();

            string query = "INSERT INTO orders (user_id, name, model) VALUES (@user_id, @name, @model)";

            MySqlCommand command = new MySqlCommand(query, connect);
            command.Parameters.Add(new MySqlParameter("@user_id", user_id));
            command.Parameters.Add(new MySqlParameter("@name", nameOrder));
            command.Parameters.Add(new MySqlParameter("@model", modelOrder));
            command.ExecuteNonQuery();
            connect.Close();
        }
        public List<Order> GetAllOrders() 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();

            string query = "SELECT * FROM orders";

            MySqlCommand command = new MySqlCommand(query, connect);

            List<Order> orderCol = new List<Order>(); // collection for my users
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int idO = reader.GetOrdinal("id");
                        int user_idO = reader.GetOrdinal("user_id");
                        int nameO = reader.GetOrdinal("name");
                        int modelO = reader.GetOrdinal("model");

                        long id = Convert.ToInt64(reader.GetValue(idO));
                        long user_id = Convert.ToInt64(reader.GetValue(user_idO));
                        string name = reader.GetString(nameO);
                        int model = Convert.ToInt32(reader.GetValue(modelO));

                        Order tempOrder = new Order(); // temp user
                        tempOrder.id = id;
                        tempOrder.user_id = user_id;
                        tempOrder.name = name;
                        tempOrder.model = model;

                        orderCol.Add(tempOrder);
                    }
                }
            }
            connect.Close();
            return orderCol;
        }
        public List<UserWithOrder> GetUserWithOrders(int id) 
        {
            MySqlConnection connect = DBWorker.getMySqlConnection();
            connect.Open();

            string query = "SELECT users.name, orders.name, orders.model FROM users JOIN orders ON users.id = orders.users_id" +
                "WHERE users.id = " + id;

            MySqlCommand command = new MySqlCommand(query, connect);

            List<UserWithOrder> usWithOr = new List<UserWithOrder>();
            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int nameO = reader.GetOrdinal("name");
                        int nameOrderO = reader.GetOrdinal("name");
                        int modelOrderO = reader.GetOrdinal("model");

                        string name = reader.GetString(nameO);
                        string nameOrder = reader.GetString(nameOrderO);
                        int model = Convert.ToInt32(reader.GetValue(modelOrderO));

                        UserWithOrder userAndOrders = new UserWithOrder(); // temp user
                        userAndOrders.name = name;
                        userAndOrders.nameOrder = nameOrder;
                        userAndOrders.model = model;

                        usWithOr.Add(userAndOrders);
                    }
                }
            }
            connect.Close();
            return usWithOr;
        }
    }
}

