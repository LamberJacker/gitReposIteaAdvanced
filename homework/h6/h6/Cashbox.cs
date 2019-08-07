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
            if (rnd.Next(0, 100) < 30)
            { 
                flag = false;
                Console.WriteLine("Sorry, cashbox is closed");
            }
        }
        public Boolean IsOpen()
        {
            return flag;
        }
    }
}
