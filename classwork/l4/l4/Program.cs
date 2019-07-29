using System;
using System.Collections.Generic;
namespace task1
{
    class Program
    {
        static void Main()
        {
            //-------------------------------
            Dictionary<int, string> dd1 = new Dictionary<int, string>();
            Dictionary<int, string> dd2 = new Dictionary<int, string>();
            Dictionary<int, Dictionary<int, string>> d = new Dictionary<int, Dictionary<int, string>>();
            //-------------------------------
            dd1.Add(0, "1");
            dd1.Add(1, "2");
            dd1.Add(2, "3");
            dd1.Add(3, "4");
            //-------------------------------
            dd2.Add(0, "11");
            dd2.Add(1, "22");
            dd2.Add(2, "33");
            dd2.Add(3, "44");
            //-------------------------------
            d.Add(1, dd1);
            d.Add(2, dd2);
            //-------------------------------
            // show:
            foreach (KeyValuePair<int, Dictionary<int, string>> d1 in d)
            {
                foreach (KeyValuePair<int, string> d2 in d1.Value)
                {
                    Console.WriteLine(d2);
                }
            }
            //-------------------------------
            Console.ReadKey();
        }
    }
}
