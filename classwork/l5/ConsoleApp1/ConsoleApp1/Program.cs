using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Man man1 = new Man("A");
            Man man2 = new Man("B");
            //do
            //{
            //    Console.WriteLine("DoWhile");
            //} while (man1.way.Length < 20 && man2.way.Length < 20);

            man1.t1.Join();
            Console.WriteLine((man2.t1.IsAlive ? man1.name : man2.name) + " win");
            Console.WriteLine("main end");
        }
    }
}
