using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class MyThread
    {
        string name;
        public MyThread(string name)
        {
            this.name = name;
            new Thread(MyMethod).Start();
        }
        public void MyMethod()
        {
            Console.WriteLine("Start new threadless "+name);
            Thread.Sleep(2000);
            Console.WriteLine("End "+name);
        }
    }
}
