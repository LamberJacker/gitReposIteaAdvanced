using System;

namespace taks
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionHero newColHeroes = new CollectionHero(); // first collection

            Console.WriteLine(newColHeroes.ToString()); // show first collection

            CollectionHero cloneColHeroes = (CollectionHero)newColHeroes.Clone(); // clone collection

            Console.WriteLine(cloneColHeroes.ToString()); // clone collection

            Console.ReadKey(); //stop prog
        }
    }
}
