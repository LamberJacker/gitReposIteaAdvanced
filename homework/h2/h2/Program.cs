using System;

namespace h2
{ 
    class Program
    {
        static void Main()
        {
            // First Phantom:
            PhantomDancer phantomDancer = new PhantomDancer();
            phantomDancer.ShowHeroStats();
            Console.WriteLine(phantomDancer.getUltimate()[0]);

            // First clone of Phantom:
            PhantomDancer clonePhantomDancer = (PhantomDancer)phantomDancer.Clone();
            clonePhantomDancer.ShowHeroStats();
            Console.WriteLine(clonePhantomDancer.getUltimate()[0]);
            
            // Second clone of Phantom:
            Hero secondPhantomDancer = (PhantomDancer)phantomDancer.Clone();
            secondPhantomDancer.ShowHeroStats();
            Console.WriteLine(secondPhantomDancer.getUltimate()[0]);
            
            // Second clone of Mage:
            Hero antiMage = new AntiMage();
            antiMage.ShowHeroStats();
            Console.WriteLine(antiMage.getUltimate()[0]);

            PhantomDancer newTryHero = new PhantomDancer(phantomDancer);
            newTryHero.ShowHeroStats();
            Console.WriteLine(clonePhantomDancer.getUltimate()[0]);


            Console.ReadKey();
        }
    }
}
