using System;

namespace task2
{
    interface IHero
    {
        string getName();
        string getLevel();
    }
    class Pudge : IHero, IUltimate
    {
        string name = "Pudge";
        string level = "15";

        public string getName()
        {
            return name;
        }
        public string getLevel()
        {
            return level;
        }
        public void getUltimate()
        {
            Console.WriteLine("UltPudge");
        }
    }
    class Zeus : IHero
    {
         string name = "Zeus";
         string level = "25";

        public string getName()
        {
            return name;
        }
        public string getLevel()
        {
            return level;
        }
    }
 
    class Program
    {
        static void Main()
        {
            IHero pudge = new Pudge();
            Console.WriteLine(pudge.getName());
            Console.WriteLine(pudge.getLevel());

            IUltimate pudgeUlt = new Pudge();
            pudgeUlt.getUltimate();

            IHero zeus = new Zeus();
            Console.WriteLine(zeus.getName());
            Console.WriteLine(zeus.getLevel());
            Console.ReadLine();
        }
    }
}
