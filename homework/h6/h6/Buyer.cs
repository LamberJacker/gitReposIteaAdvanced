using System;
using System.Threading;

namespace h6
{
    class Buyer
    {
        string name;
        Cashbox cashbox;
        Thread thread;
        public Buyer(string name, Cashbox cashbox)
        {
            this.name = name;
            this.cashbox = cashbox;
            thread = new Thread(Buy);
            thread.Start();
        }
        private void Buy()
        {
            lock (cashbox)
            {
                if (cashbox.IsOpen())
                {
                    Console.WriteLine("Buyer " + name + " now buys!");
                    Thread.Sleep(3000);
                    cashbox.ToServe();
                }
            }
        }
    }
}
