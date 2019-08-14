using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserControler uc = new UserControler();
            //Console.WriteLine(uc.AddUser("vladislav@gmail.com", "12323541",  "vlad", "12323541", "kyiv", "13", 1));
            //Console.WriteLine(uc.Login("vlad@gmail.com","1qa2w3ed"));
            Console.WriteLine(uc.EditUser("vlad@gmail.com", "123123123", "", "", "23", 1)); 
        }
    }
}
