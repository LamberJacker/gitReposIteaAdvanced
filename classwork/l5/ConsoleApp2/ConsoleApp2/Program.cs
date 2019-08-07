using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shared shr = new Shared();
            //MyThread1 th1 = new MyThread1(shr);
            //MyThread2 th2 = new MyThread2(shr);
            //Producer pr = new Producer(shr);
            //Customer cust = new Customer(shr);
            StringProducer strpr = new StringProducer();
            Semaphore sem = new Semaphore(1,1);
            new MyThread(strpr, "A", sem);
            new MyThread(strpr, "B", sem);
            new MyThread(strpr, "C", sem);
        }
    }
}
