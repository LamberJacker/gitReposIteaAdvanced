using System;
using System.Threading;

namespace h6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashbox cashbox = new Cashbox();
            Buyer bayer1 = new Buyer("#1", cashbox);
            Buyer bayer2 = new Buyer("#2", cashbox);
            Buyer bayer3 = new Buyer("#3", cashbox);
            Buyer bayer4 = new Buyer("#4", cashbox);
            Buyer bayer5 = new Buyer("#5", cashbox);
        }
    }
}
