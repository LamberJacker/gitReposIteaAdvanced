using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            UserControler dbCommand  = new UserControler();
            
            //Show list of users
            List<User> list1 = dbCommand.GetAllUser();
            Console.WriteLine("\n" + new String('-', 40) + "Show list of all users" + new String('-', 40));
            foreach (User user in list1)
            {
                Console.WriteLine(user.ToString());
            }
            
            //Show only one user
            Console.WriteLine("\n"+new String('-',40) + "Show only one user" + new String('-', 40));
            Console.WriteLine(dbCommand.GetUser(1).ToString());

            //Add new user to table users
            Console.WriteLine("\n" + new String('-', 40) + "Add new user to table users" + new String('-', 40));
            dbCommand.AddUser("Try", "Try", "Try", "Try", 20);
            
            //Show list of users
            List<User> list2 = dbCommand.GetAllUser();
            Console.WriteLine("\n" + new String('-', 40) + "Show list of all users" + new String('-', 40));
            foreach (User user in list2)
            {
                Console.WriteLine(user.ToString());
            }

            //Delete some user
            Console.WriteLine("\n" + new String('-', 40) + "Delete some user" + new String('-', 40));
            dbCommand.DeleteUser(16);

            //Show list of users
            List<User> list3 = dbCommand.GetAllUser();
            Console.WriteLine("\n" + new String('-', 40) + "Show list of all users" + new String('-', 40));
            foreach (User user in list3) 
            {
                Console.WriteLine(user.ToString());
            }

            //Add new order to orders
            Console.WriteLine("\n" + new String('-', 40) + "Add new order to orders" + new String('-', 40));
            dbCommand.AddNewOrderToUser(1, "Iphone", 10);

            //Show list of orders
            List<Order> list4 = dbCommand.GetAllOrders();
            Console.WriteLine("\n" + new String('-', 40) + "Show list of all users" + new String('-', 40));
            foreach (Order order in list4) 
            {
                Console.WriteLine(order.ToString());
            }



        }
    }
}
