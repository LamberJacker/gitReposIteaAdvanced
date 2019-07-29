using System;

namespace taks
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionHero colHer = new CollectionHero(); // first collection

            Console.WriteLine(new string('-', 20) + " First Show Collection of HEROES " + new string('-', 20)); // for view in console

            Console.WriteLine(colHer.ToString()); // show first collection

            CollectionHero cloneColHeroes = (CollectionHero)colHer.Clone(); // clone collection

            Console.WriteLine(new string('-', 20) + " Show Clone Collection of HEROES " + new string('-', 20)); // for view in console

            Console.WriteLine(cloneColHeroes.ToString()); // clone collection

            Console.WriteLine(new string('-', 20) + " Second Show Collection of HEROES " + new string('-', 20)); // for view in console

            Console.WriteLine(colHer.ToString()); // show first collection

            Console.ReadKey(); //stop prog
        }
    }
}
