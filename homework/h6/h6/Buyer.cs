using System;
using System.Collections.Generic;
using System.Text;
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
        public void Buy()
        {
            if (!cashbox.IsOpen()) thread.Abort();
            else
            {
                while (cashbox.IsOpen())
                {
                    lock (cashbox)
                    {
                        Console.WriteLine("Buyer " + name + " now buys!");
                        cashbox.ToServe();
                        Thread.Sleep(3000);
                    }
                }
            }
        }
    }
}
