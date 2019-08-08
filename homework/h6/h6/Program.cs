using System;
using System.Threading;

namespace h6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashbox cashbox = new Cashbox();
            new Buyer("#1", cashbox);
            new Buyer("#2", cashbox);
            new Buyer("#3", cashbox);
            new Buyer("#4", cashbox);
            new Buyer("#5", cashbox);
            Console.WriteLine("main finish ");
        }
    }
}
