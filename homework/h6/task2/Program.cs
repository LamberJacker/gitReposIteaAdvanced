using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> woreksList = new List<Worker>();
            GoldMine gmine = new GoldMine();
            Stronghold home = new Stronghold(woreksList, gmine);

        }
    }
}
