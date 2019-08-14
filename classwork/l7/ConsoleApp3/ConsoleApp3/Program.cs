using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------
            String[] str = { "tesla", "bmw", "toyota", "dacia", "renault" };
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].StartsWith("t")) Console.WriteLine(str[i]);
            }
            Console.WriteLine(new string ('-',50));
            //--------------------------------------------------------
            var query = from t in str where t.StartsWith("t") orderby t select t;
            foreach (var item in query) { Console.WriteLine(item); }
            //--------------------------------------------------------
            Console.WriteLine(new string('-', 50));
            var query1 = str.Where(x => x.StartsWith("t"));
            foreach (var item in query1) { Console.WriteLine(item); }
            Console.WriteLine(new string('-', 50));
            //--------------------------------------------------------
            List<Cat> listCat = new List<Cat>();
            listCat.Add(new Cat("cat1", 4));
            listCat.Add(new Cat("cat2", 5));
            listCat.Add(new Cat("cat3", 10));
            listCat.Add(new Cat("cat4", 7));
            listCat.Add(new Cat("cat5", 3));
            var query2 = listCat.Where(x => x.age>5);
            foreach (var item in query2) { Console.WriteLine(item); }
            Console.WriteLine(new string('-', 50));
            //--------------------------------------------------------


        }
    }
}
