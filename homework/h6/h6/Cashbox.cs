using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace h6
{
    class Cashbox
    {
        bool flag = true;
        Random rnd = new Random();
        public void ToServe() 
        {
            if (rnd.Next(0, 10) < 3)
            {
                flag = false;
                Console.WriteLine("Cashbox is closed");
            }
        }
        public bool IsOpen()
        {
            return flag;
        }
    }
}
