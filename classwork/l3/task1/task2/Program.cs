using System;
using System.Collections;
using System.Collections.Generic;

namespace task2
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("A");
            stringList.Add("B");
            stringList.Add("C");

            foreach (string str in stringList)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(new string ('-',20));

            for (int i = 0; i < stringList.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

        }
    }
}
