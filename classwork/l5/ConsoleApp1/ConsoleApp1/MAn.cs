using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    
    class Man
    {
        public string way = "";
        public string name;
        public Thread t1;
        public Man(string name)
        {
            this.name = name;
            t1 = new Thread(Step);
            t1.Start();
        }
        public void Step()
        {
            Random rnd = new Random();
            while (way.Length < 20)
            {
                int rndValue = rnd.Next(0, 4);
                for (int i = 0; i <= rndValue; i++)
                {
                    way += "-";
                }
                Console.WriteLine(name + way);
                Thread.Sleep(1000);
            }
        }
    }
}
