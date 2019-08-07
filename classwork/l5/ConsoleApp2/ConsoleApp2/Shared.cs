using System;
using System.Threading;

namespace ConsoleApp2
{
    class Shared 
    {
        public int x = 0;
        bool flag;
        public void Put()
        {
            lock (this)
            {
                if (flag) { Monitor.Wait(this); }
                x++;
                Console.WriteLine("X = " + x + " - put shared");
                flag = true;
                Monitor.Pulse(this);
            }
        }
        public void Take()
        {
            lock (this)
            {
                if (!flag) { Monitor.Wait(this); }
                Console.WriteLine("X = " + x + " - take shared");
                x--;
                flag = false;
                Monitor.Pulse(this);

            }
        }
    }
    class MyThread1 
    {
        Shared shared;
        public MyThread1(Shared shared)
        {
            this.shared = shared;
            new Thread(Method).Start();
        }
        public void Method()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                lock (shared)
                {
                    shared.x++;
                }
            }
        }
    }
    class MyThread2 
    {
        Shared shared;
        public MyThread2(Shared shared)
        {
            this.shared = shared;
            new Thread(Method).Start();
        }
        public void Method()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                lock (shared)
                {
                    if (shared.x % 2 == 0)
                    {
                        Console.WriteLine(shared.x);
                    }
                }
            }
        }
    }
    class Producer 
    {
        Shared shared;
        public Producer(Shared shared)
        {
            this.shared = shared;
            new Thread(Method).Start();
        }
        public void Method()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                shared.Put();
            }
        }
    }
    class Customer 
    {
        Shared shared;
        public Customer(Shared shared)
        {
            this.shared = shared;
            new Thread(Method).Start(); ;
        }
        public void Method()
        {
            for (int i = 0; i < 1000000000; i++)
            {
                shared.Take();
            }
        }
    }
    class StringProducer 
    {
        public void MethodProducer(string letter)
        {

            Console.Write("[ " + letter);
            Thread.Sleep(1000);
            Console.Write(" ]");
        }
    }
    class MyThread 
    {
        StringProducer strprod;
        string letter;
        Semaphore sem;
        public MyThread(StringProducer strprod, string letter, Semaphore sem)
        {
            this.strprod = strprod;
            this.letter = letter;
            this.sem = sem;
            new Thread(MyMethod).Start();
        }
        public void MyMethod()
        {
            sem.WaitOne();
            strprod.MethodProducer(letter);
            sem.Release();
        }
    }
}
