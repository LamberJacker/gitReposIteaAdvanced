using System;

namespace taks
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero trynd = new Tryndamere();
            Hero kayle = new Kayle();
            Hero br = new Brand();
            Hero zed = new Zed();
            Hero yas = new Yasuo();
            Hero ori = new Oriana();
            Hero nas = new Nasus();


            Console.WriteLine(trynd.ToString());

            Console.ReadKey(); //stop prog
        }
    }
}
